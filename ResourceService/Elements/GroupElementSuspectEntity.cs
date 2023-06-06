using Hl7.Fhir.Model;
using System.Collections.Generic;

namespace ResourceMgr.Elements
{
    public class GroupElementSuspectEntity
    {
       
        public GroupElementSuspectEntity(AdverseEvent.SuspectEntityComponent source, IFhirServer fs)
        {
            if(source != null )
            {
                if(source.Instance != null && source.Instance.IsContainedReference)
                {
                    string _ref = source.Instance.Reference;
                    Instance = new SubElement("instance", _ref, fs);
                }
                if(source.Causality != null && source.Causality.Count > 0)
                {
                    foreach(var item in source.Causality)
                    {
                        Causality.Add(new GroupElementCausality(item, fs));
                    }
                }
               
            }
            
        }

        public SubElement Instance { get; private set; }
        public List<GroupElementCausality> Causality { get; private set; }
    }
}
