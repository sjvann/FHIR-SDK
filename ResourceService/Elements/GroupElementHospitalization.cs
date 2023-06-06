using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementHospitalization
    {
       
        public GroupElementHospitalization(Encounter.HospitalizationComponent source, IFhirServer fs)
        {
            if(source != null)
            {
                if (source.Origin != null && source.Origin.IsContainedReference)
                {
                    string _ref = source.Origin.Reference;
                    Origin = new SubElement("origin", _ref, fs);
                }
                if(source.Destination != null && source.Destination.IsContainedReference)
                {
                    string _ref = source.Destination.Reference;
                    Destination = new SubElement("destination", _ref, fs);
                }
            }
            
        }

        public SubElement Origin { get; private set; }
        public SubElement Destination { get; private set; }
    }
}
