using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementLocation
    {
       
        public GroupElementLocation(Encounter.LocationComponent source, IFhirServer fs)
        {
            if(source != null && source.Location != null && source.Location.IsContainedReference)
            {
                string _ref = source.Location.Reference;
                Location = new SubElement("location", _ref, fs);
            }
            
        }

        public SubElement Location { get; private set; }
    }
}
