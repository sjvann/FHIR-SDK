using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementMedia
    {

        public GroupElementMedia(DiagnosticReport.MediaComponent source, IFhirServer _fs)
        {
            if (source != null && source.Link != null && source.Link.IsContainedReference)
            {

                Link = new SubElement("link", source.Link.Reference, _fs);

            }

        }

        public SubElement Link { get; private set; }
    }
}
