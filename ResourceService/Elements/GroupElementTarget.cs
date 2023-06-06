using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementTarget
    {

        public GroupElementTarget(Goal.TargetComponent source, IFhirServer fs)
        {
            if (source != null)
            {
                if (source.Detail != null)
                {
                    Detail = new SubElement("detail", source.Detail.TypeName, source.Detail);
                }
                if (source.Due != null)
                {
                    Due = new SubElement("due", source.Due.TypeName, source.Due);
                }
            }

        }

        public SubElement Detail { get; private set; }
        public SubElement Due { get; private set; }
    }
}
