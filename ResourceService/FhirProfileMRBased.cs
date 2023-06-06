using Hl7.Fhir.Model;
using ResourceMgr.Managed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceMgr
{
    public abstract class FhirProfileMRBased<TMRResource, TResource> : IFhirProfile where TMRResource : MRBased<TResource> where TResource : Resource
    {
        protected readonly TMRResource _content;
        private readonly string _url;
        private readonly string _typeName;
        protected TResource _resource;
        protected IFhirServer _fs;
        protected ResourceManager _rm;
        protected FhirProfileMRBased() { }
        protected FhirProfileMRBased(TMRResource source, IFhirServer fhirServer)
        {
            _content = source;
            _resource = source.GetCurrentResource();
            _url = $"{source.ResourceName}/{_resource.Id}";
            _typeName = source.ResourceName;
            _fs = fhirServer;
            _rm = new ResourceManager(fhirServer);

        }

        public int Count()
        {
            return _content.AllResources.Count;
        }

        public string GetFhirId()
        {
            return _resource.Id;
        }

        public string GetFullUri()
        {
            throw new NotImplementedException();
        }

        public ResourceReference GetReference()
        {
            ResourceReference rf = new();
            rf.Reference = _url;
            rf.Type = _typeName;
            rf.Url = new Uri(GetFullUri());
            return rf;
        }

        public abstract string GetResourceJson();


        public abstract string GetText();


        public string GetUri()
        {
            return _url;
        }

        public abstract void SetupElement(string id = null);
    }
}
