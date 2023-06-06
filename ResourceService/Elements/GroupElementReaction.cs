using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementReaction
    {
       
        public GroupElementReaction(Immunization.ReactionComponent source, IFhirServer fs)
        {
            if(source != null && source.Detail != null && source.Detail.IsContainedReference)
            {  
                Detail = new SubElement("eetail", source.Detail.Reference, fs);
            }
            
        }

        public SubElement Detail { get; private set; }
    }
}
