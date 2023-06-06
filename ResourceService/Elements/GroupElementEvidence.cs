using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class GroupElementEvidence
    {
       
        public GroupElementEvidence( Condition.EvidenceComponent source, IFhirServer fs)
        {
            if (source != null && source.Detail != null && source.Detail.Any())
            {
                foreach (var item in source.Detail)
                {
                    if (item != null && item.IsContainedReference)
                    {
                        string _ref = item.Reference;
                        Detail.Add(new SubElement("detail", _ref, fs));
                    }
                }
            }

        }

        public List<SubElement> Detail { get; private set; }
    }
}
