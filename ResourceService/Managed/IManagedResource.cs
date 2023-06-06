using Hl7.Fhir.Model;
using System.Collections.Generic;

namespace ResourceMgr.Managed
{
    public interface IManagedResource
    {
        public string GetResourceName();
        public void SetupSubElement();

    }
}