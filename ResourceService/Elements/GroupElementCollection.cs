using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementCollection
    {

        public GroupElementCollection(Specimen.CollectionComponent source, IFhirServer fs)
        {
            if (source != null)
            {
                if (source.Collected != null)
                {
                    Collected = new SubElement("collected", source.Collected.TypeName, source.Collected);
                }
                if (source.FastingStatus != null)
                {
                    FastingStatus = new SubElement("fastingStatus", source.FastingStatus.TypeName, source.FastingStatus);
                }
            }

        }

        public SubElement Collected { get; private set; }
        public SubElement FastingStatus { get; private set; }
    }
}
