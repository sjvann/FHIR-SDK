using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementCausality
    {
       
        public GroupElementCausality(AdverseEvent.CausalityComponent source, IFhirServer fs)
        {
            if(source != null && source.Author != null && source.Author.IsContainedReference)
            {
                string _ref = source.Author.Reference;
                Author = new SubElement("author", _ref, fs);
            }
            
        }

        public SubElement Author { get; private set; }
    }
}
