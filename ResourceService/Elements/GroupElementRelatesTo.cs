using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementRelatesTo
    {
       
        public GroupElementRelatesTo(DocumentReference.RelatesToComponent source, IFhirServer fs)
        {
            if(source != null && source.Target != null && source.Target.IsContainedReference)
            {
               
                Target = new SubElement("target", source.Target.Reference, fs);
            }
            
        }

        public SubElement Target { get; private set; }
    }
}
