
using ResourceMgr.Managed;
using ResourceTypeBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr
{
    public abstract class FhirProfileBased<TResource> : IFhirProfile where TResource : Resource
    {  
        private readonly string _url;
        private readonly string _typeName;
        protected TResource _resource;
        protected IFhirServer _fs;
        protected ResourceManager _rm;
        protected  FhirProfileBased() { }
        protected  FhirProfileBased(TResource source, IFhirServer fhirServer)
        {
            _resource = source;
            _typeName = source.TypeName;
            _url = $"{source.TypeName}/{_resource.Id}";
            _fs = fhirServer;
            _rm = new ResourceManager(fhirServer);
           
        }

        public int Count()
        {
            return 1;
        }

        public string GetFhirId()
        {
            return _resource.Id;
        }

        public string GetResourceJson() 
        {
            var serializer = new FhirJsonSerializer();
            return serializer.SerializeToString(GetResource());
        }
        public abstract TResource GetResource(); 
        public abstract string GetText();

        public abstract void SetupElement();

        public string GetFullUri()
        {
           return $"{_fs.GetBasedUrl()}/{_url}";
        }

        public ResourceReference GetReference()
        {
            ResourceReference rf = new();
            rf.Reference = _url;
            rf.Type = _typeName ;
            rf.Url = new Uri(GetFullUri());
            return rf;
        }
    }
}
