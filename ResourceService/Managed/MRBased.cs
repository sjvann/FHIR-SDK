using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;

namespace ResourceMgr.Managed
{

    public abstract class MRBased<T> : IMRBased<T> where T : Resource
    {
        protected IFhirServer _fs;
        private readonly List<T> _allResource;
        private readonly T _currentResource;
        protected string _resourceName;
        protected MRBased(List<T> resources, IFhirServer fhirServer)
        {
            _fs = fhirServer;
            _allResource = resources;
            _currentResource = resources.FirstOrDefault();
        }
        protected MRBased(T resource, IFhirServer fhirServer)
        {
            List<T> tmp = new();
            tmp.Add(resource);
            _allResource = tmp;
            _currentResource = resource;
            _fs = fhirServer;
        }

        public List<T> AllResources => _allResource ?? new List<T>();
        public string ReferenceUrl => $"{ResourceName}/{GetCurrentResource().Id})";
        public string ResourceName => _resourceName ?? "Resource";
        #region abstract M

        public abstract void SetupSubElement();

        public T GetCurrentResource(string id = null)
        {
            if (string.IsNullOrEmpty(id) && _currentResource != null)
            {
                return _currentResource;
            }
            if (_allResource != null && _allResource.Any())
            {
                return string.IsNullOrEmpty(id) ? _allResource.FirstOrDefault() : _allResource.FirstOrDefault(x => x.Id == id);
            }
            return null;

        }
       
        public IEnumerable<T> GetResource(Dictionary<string, object> query)
        {
            throw new NotImplementedException();
        }

        public Bundle GetBundle()
        {
            Bundle collection = new();
            collection.Type = Bundle.BundleType.Collection;
            if(_allResource != null && _allResource.Any())
            {
                foreach(var item in _allResource)
                {
                    var entry = new Bundle.EntryComponent
                    {
                        FullUrl = _fs.GetBasedUrl() + "/" + item.TypeName + "/" + item.Id,
                        Resource = item
                    };
                    collection.Entry.Add(entry);
                }
            }
            return collection;
        }

        public Bundle GetBundle(Dictionary<string, object> query)
        {
             throw new NotImplementedException();
        }
        public void AddResource(T newResource)
        {
            _allResource.Add(newResource);
        }

        #endregion
        #region Private
        protected SubElement GetReference(string elementName, ResourceReference source)
        {

            if (source != null)
            {
                return new SubElement(elementName, source.Reference, _fs);
            }
            else
            {
                return null;
            }
        }
        protected List<SubElement> GetReference(string elementName, List<ResourceReference> sources)
        {
            List<SubElement> tmp = new();
            if (sources != null && sources.Any())
            {
                foreach (var item in sources.Where(x => x.IsContainedReference))
                {
                    tmp.Add(new SubElement(elementName, item.Reference, _fs));
                }
            }
            return tmp;
        }
        protected SubElement GetCanonical(string elementName, string source)
        {
            return new SubElement(elementName, source, _fs, true);
        }
        protected List<SubElement> GetCanonical(string elementName, IEnumerable<string> source)
        {
            List<SubElement> tmp = new();
            if (source != null && source.Any())
            {
                foreach (var item in source)
                {
                    tmp.Add(new SubElement(elementName, item, _fs, true));
                }
            }
            return tmp;
        }
        protected SubElement GetDataType(string elementName, DataType source)
        {
            return new SubElement(elementName, source.TypeName, source);
        }
        protected List<SubElement> GetDataType(string elementName, List<DataType> sources)
        {
            List<SubElement> tmp = new();
            if (sources != null && sources.Any())
            {
                foreach (var item in sources)
                {
                    tmp.Add(new SubElement(elementName, item.TypeName, item));
                }
            }
            return tmp;
        }
        protected TGroupElement GetGroupElement<TGroupElement>(BackboneElement source) where TGroupElement : GroupElementBased
        {

            return (TGroupElement)Activator.CreateInstance(typeof(TGroupElement), source, _fs);
        }
        protected List<TGroupElement> GetGroupElement<TGroupElement>(List<BackboneElement> source) where TGroupElement : GroupElementBased
        {
            List<TGroupElement> tmp = new();
            foreach (var item in source)
            {
                tmp.Add((TGroupElement)Activator.CreateInstance(typeof(TGroupElement), source, _fs));
            }

            return tmp;
        }

       

        #endregion
    }
}
