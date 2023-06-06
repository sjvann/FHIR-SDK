using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementProcessing
    {
       
        public GroupElementProcessing(Specimen.ProcessingComponent source, IFhirServer fs)
        {
            if(source != null)
            {
               if(source.Additive != null && source.Additive.Count > 0)
                {
                    foreach(var item in source.Additive.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Additive.Add(new SubElement("additive", _ref, fs));
                    }
                }
               if(source.Time != null)
                {
                     Time = new SubElement("time", source.Time.TypeName, source.Time);
                }
            }
            
        }

        public List<SubElement> Additive { get; private set; }
        public SubElement Time { get; private set; }
    }
}
