using Hl7.Fhir.Model;
using System.Collections.Generic;

namespace ResourceMgr.Managed
{
    internal interface IMRBased<T> where T : Resource
    {
        List<T> AllResources { get; }
        
        string ReferenceUrl { get; }
        string ResourceName { get; }
        T GetCurrentResource(string id = null);
        void SetupSubElement();
        
        public IEnumerable<T> GetResource(Dictionary<string, object> query);
        public Bundle GetBundle();
        public Bundle GetBundle(Dictionary<string, object> query);
        public void AddResource(T newResource);
    }
}