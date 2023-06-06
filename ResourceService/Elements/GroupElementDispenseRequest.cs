using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementDispenseRequest
    {
       
        public GroupElementDispenseRequest(MedicationRequest.DispenseRequestComponent source, IFhirServer fs)
        {
            if(source != null && source.Performer != null && source.Performer.IsContainedReference)
            {
                
                Performer = new SubElement("Performer", source.Performer.Reference, fs);
            }
            
        }

        public SubElement Performer { get; private set; }
    }
}
