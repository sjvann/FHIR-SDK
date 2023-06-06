using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementContact
    {
       
        public GroupElementContact(Patient.ContactComponent source, IFhirServer fs)
        {
            if(source != null && source.Organization != null && source.Organization.IsContainedReference)
            {
                string _ref = source.Organization.Reference;
                Organization = new SubElement("organization", _ref, fs);
            }
            
        }

        public SubElement Organization { get; private set; }
    }
}
