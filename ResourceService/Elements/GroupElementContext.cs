
using Hl7.Fhir.Model;
using System.Collections.Generic;
using System.Linq;

namespace ResourceMgr.Elements
{
    public class GroupElementContext
    {
       
        public GroupElementContext(DocumentReference.ContextComponent source, IFhirServer _fs)
        {
            if(source != null )
            {
              if(source.Encounter != null && source.Encounter.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in source.Encounter.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("encounter", item.Reference, _fs));
                    }
                    Encounter = temp;
                }
              if(source.SourcePatientInfo != null && source.SourcePatientInfo.IsContainedReference)
                {
                    SourcePatientInfo = new SubElement("sourcePatientInfo", source.SourcePatientInfo.Reference, _fs);
                }
              if(source.Related != null && source.Related.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in source.Related.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("related", item.Reference, _fs));
                    }

                }
            }
            
        }

        public List<SubElement> Encounter { get; private set; }
        public SubElement SourcePatientInfo { get; private set; }
        public List<SubElement> Related { get; private set; }
    }
}
