using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementSubstitution
    {
       
        public GroupElementSubstitution(MedicationRequest.SubstitutionComponent source, IFhirServer fs)
        {
            if(source != null && source.Allowed != null )
            {
               
                Allowed = new SubElement("allowed", source.Allowed.TypeName, source.Allowed);
            }
            
        }

        public SubElement Allowed { get; private set; }
    }
}
