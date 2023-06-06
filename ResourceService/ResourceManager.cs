using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Threading.Tasks;
using ResourceMgr.Managed;
using System.Net.Http;
using Hl7.Fhir.Rest;
using ResourceTypeBased;
using System.Text.Json.Nodes;

namespace ResourceMgr
{
    public class ResourceManager : IResourceManager
    {

        private readonly IFhirServer? _fs;
        private readonly bool _isBundle;
        private readonly string _bundleType = string.Empty;
        private readonly Dictionary<string, List<Resource>>? _entryResource;
        private readonly bool _hasError;

        public ResourceManager(IFhirServer fs)
        {
            _fs = fs;
          
        }
        public ResourceManager(object source, IFhirServer fs)
        {
            _fs = fs;
            _resource = ParserService(source);
            if (_resource.TypeName == ResourceType.Bundle.ToString())
            {
                Bundle bResource = _resource as Bundle;
                _isBundle = true;
                _bundleType = bResource.Type.ToString();
                _entryResource = ParserBundleResource(bResource);
                _hasError = _entryResource.ContainsKey(ResourceType.OperationOutcome.ToString());
            }
        }      
        
        #region Public Field
        public bool IsBundle { get { return _isBundle; } }
        public bool HasError { get { return _hasError; } }
        public string BundleType { get { return _bundleType; } }
        public string GetResourceType { get { return _resource.TypeName; } }
        public IEnumerable<string> GetBundleContainResourceType
        {
            get
            {
                if (_entryResource == null || _entryResource.Any()) { return new List<string>(); }
                return _entryResource.Keys;
            }
        }
        #endregion

        #region Public Method
        public static IEnumerable<T> GetResourceByFullUri<T>(Uri fullUri, string token = "") where T: Resource
        {
            List<T> result = new ();
            using HttpClient client = new();

            client.DefaultRequestHeaders.Add("Accept", "application/json+fhir");
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            }
            HttpResponseMessage rm = client.GetAsync(fullUri).Result;
            if (rm.IsSuccessStatusCode)
            {
                var target = rm.Content.ReadAsStringAsync().Result;
                if (target != null)
                {
                    Resource r = parser.Parse<Resource>(target);
                    if (r.TypeName == "Bundle")
                    {
                        Bundle bundle = (Bundle)r;
                      
                        foreach (var m in bundle.Entry.Select(x=>x.Resource))
                        {
                            result.Add((T)m);
                        }
                    }
                    else
                    {
                        result.Add((T)r);
                    }
                }
            }
            return result;
        }
        public IEnumerable<TResource> GetResource<TResource>(string typeName) where  TResource:Resource
        {
            var rs = from values in _entryResource
                     where values.Key == typeName
                     from resource in values.Value
                     select resource as TResource;
           
            return rs;
        }
        public TRM GetManagedResource<TRM, TR>() where TRM : MRBased<TR> where TR:Resource
        {
            var request = (from r in _entryResource
                          where r.Key == typeof(TRM).Name
                           select r.Value).FirstOrDefault();
            object[] args = new object[2];
            args[0] = request;
            args[1] = _fs;
            return (TRM)Activator.CreateInstance(typeof(TRM), args);
        }
        
        public TRM GetManagedResource<TRM, TR>(string reference)  where TRM : MRBased<TR> where TR:Resource
        {
             Resource result  = GetResourceAsync(reference);
            object[] args = new object[2];
            args[0] = result;
            args[1] = _fs;
            return (TRM)Activator.CreateInstance(typeof(TRM), args);
        }

        public static JsonNode? ParserService(object resource)
        {
            string? source = resource.ToString();
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("資料為空");
            }
            else
            {
                if (source.StartsWith("{") && source.EndsWith("}") || source.StartsWith("[") && source.EndsWith("]"))
                {
                    return JsonNode.Parse(source);
                }
                else
                {
                    throw new ArgumentException("格式錯誤");
                }
            }
        }
        public static T ParserService<T>(object resource) where T: Resource
        {

            return (T)ParserService(resource);
        }
        public T ReferenceService<T>(string url, bool isFullUrl = false) where T:Resource
        {
           
            string checkedUrl = url.StartsWith("/") ? _fs.GetBasedUrl() + url : $"{_fs.GetBasedUrl()}/{url}";
            string refUrl = isFullUrl ? url : checkedUrl;
             
            return  GetResourceByFullUri<T>(new Uri(refUrl)).FirstOrDefault() ;

        }
        #region CRUD Resources
        public async Task<IEnumerable<T>> GetResourcesAsync<T>() where T : Resource
        {
            using var client = new FhirClient(_fs.GetBasedUrl());
            string url = $"{_fs.GetBasedUrl()}/{typeof(T).Name}";
            var retrived = await client.ReadAsync<Bundle>(new Uri(url));
            return ParserBundleResource<T>(retrived);
        }
        public async Task<T> GetResourceAsync<T>(int id) where T : Resource
        {
            using var client = new FhirClient(_fs.GetBasedUrl());
            string url = $"{_fs.GetBasedUrl()}/{typeof(T).Name}/{id}";
            var retrived = await client.ReadAsync<T>(new Uri(url));
            return retrived;
        }
        public async Task<T> GetResourceAsync<T>(string refUrl) where T:Resource
        {
            using var client = new FhirClient(_fs.GetBasedUrl());
            string url = $"{_fs.GetBasedUrl()}/{refUrl}";
            return await client.ReadAsync<T>(new Uri(url));

        }

        public Resource GetResourceAsync(string refUrl)
        {
            using var client = new FhirClient(_fs.GetBasedUrl());
            string url = $"{_fs.GetBasedUrl()}/{refUrl}";
            var tmp = client.ReadAsync<Resource>(new Uri(url));

            return tmp.GetAwaiter().GetResult();

        }
        public async Task<T> SaveResourceAsync<T>(Resource resource) where T : Resource
        {
            using var client = new FhirClient(_fs.GetBasedUrl());
            var saved = await client.CreateAsync((T)resource);
            return saved;
        }

        public async Task<T> UpdateResource<T>(Resource resource) where T : Resource
        {
            using var client = new FhirClient(_fs.GetBasedUrl());
            var updated = await client.UpdateAsync((T)resource);
            return updated;
        }
        public async System.Threading.Tasks.Task DeleteResouceAsync<T>(int id) where T : Resource
        {
            using var client = new FhirClient(new Uri(_fs.GetBasedUrl()));
            string url = $"{_fs.GetBasedUrl()}/{typeof(T).Name}/{id}";
            await client.DeleteAsync(new Uri(url));

        }
        #endregion
        #endregion

        #region Private Method
        private static IEnumerable<T> ParserBundleResource<T>(Bundle retrived) where T : Resource
        {
            if (retrived != null)
            {
                Bundle bResource = retrived;
                return (from r in bResource.Entry
                        where r.Resource.TypeName != ResourceType.OperationOutcome.ToString() && r.Resource.TypeName == typeof(T).Name
                        select (T)r.Resource).ToList();
            }
            else
            {
                return new List<T>();
            }

        }
        private static Dictionary<string, List<Resource>> ParserBundleResource(Bundle retrived)
        {
            Dictionary<string, List<Resource>> finalResult = new();
            if (retrived != null)
            {
                Bundle bResource = retrived;

                if (bResource != null && bResource.Entry != null && bResource.Entry.Any() && bResource.Total > 0)
                {
                    var allResource = bResource.Entry.Select(x => x.Resource);
                    finalResult = allResource.GroupBy(x => x.TypeName).ToDictionary(g => g.Key, g => g.ToList());

                }
            }
            return finalResult;

        }
        
        #endregion
    }
}
