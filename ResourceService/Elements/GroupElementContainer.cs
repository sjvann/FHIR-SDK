using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementContainer
    {
       
        public GroupElementContainer(Specimen.ContainerComponent source, IFhirServer fs)
        {
            if(source != null && source.Additive != null )
            {
               
                Additive = new SubElement("additive", source.Additive.TypeName ,source.Additive);
            }
            
        }

        public SubElement Additive { get; private set; }
    }
}
