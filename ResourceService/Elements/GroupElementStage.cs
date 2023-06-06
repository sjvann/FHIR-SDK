using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class GroupElementStage
    {
       
        public GroupElementStage(Condition.StageComponent source, IFhirServer fs)
        {
            if(source != null && source.Assessment != null && source.Assessment.Any())
            {
                foreach(var item in source.Assessment)
                {
                    if(item != null && item.IsContainedReference)
                    {
                        string _ref = item.Reference;
                        Assessment.Add(new SubElement("assessment", _ref, fs));
                    }
                }
            }
            
        }

        public List<SubElement> Assessment { get; private set; }
    }
}
