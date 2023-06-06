using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class GroupElementActivity
    {

        public GroupElementActivity(CarePlan.ActivityComponent source, IFhirServer fs)
        {
            if (source != null)
            {
                if (source.OutcomeReference != null && source.OutcomeReference.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in source.OutcomeReference.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("outcomeReference", item.Reference, fs));
                    }
                    OutcomeReference = temp;
                }
                if (source.Reference != null && source.Reference.IsContainedReference)
                {
                    Reference = new SubElement("reference", source.Reference.Reference, fs);
                }
                if (source.Detail != null)
                {
                    Detail = new GroupElementDetail(source.Detail, fs);
                }
            }

        }

        public List<SubElement> OutcomeReference { get; private set; }
        public SubElement Reference { get; private set; }
        public GroupElementDetail Detail { get; private set; }
    }

}
