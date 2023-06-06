using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementAgent
    {
       
        public GroupElementAgent(Provenance.AgentComponent source, IFhirServer fs)
        {
            if(source != null )
            {
                if(source.Who != null && source.Who.IsContainedReference)
                {

                    Who = new SubElement("who", source.Who.Reference, fs);
                }
                if(source.OnBehalfOf != null && source.OnBehalfOf.IsContainedReference)
                {
                    OnBehalfOf = new SubElement("onBehalfOf", source.OnBehalfOf.Reference, fs);
                }
            }
            
        }

        public SubElement Who { get; private set; }
        public SubElement OnBehalfOf { get; private set; }
    }
}
