using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementComponent
    {
       
        public GroupElementComponent(Observation.ComponentComponent source, IFhirServer fs)
        {
            if(source != null && source.Value!= null)
            {
               
                Value = new SubElement("value", source.Value.TypeName, source.Value);
            }
            
        }

        public SubElement Value { get; private set; }
    }
}
