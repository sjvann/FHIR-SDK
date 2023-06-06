using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementLink
    {
       
        public GroupElementLink(Patient.LinkComponent source, IFhirServer fs)
        {
           
            
            if(source != null && source.Other != null && source.Other.IsContainedReference)
            {
                string _ref = source.Other.Reference;
                Other = new SubElement("other", _ref, fs);
            }
            
        }

        public SubElement Other { get; private set; }
    }
}
