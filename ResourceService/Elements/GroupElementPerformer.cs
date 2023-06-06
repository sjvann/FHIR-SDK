using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementPerformer
    {

        public GroupElementPerformer(Procedure.PerformerComponent source, IFhirServer fs)
        {
            if (source != null)
            {
                if (source.Actor != null && source.Actor.IsContainedReference)
                {
                    string _ref = source.Actor.Reference;
                    Actor = new SubElement("actor", _ref, fs);
                }
                if (source.OnBehalfOf != null && source.OnBehalfOf.IsContainedReference)
                {
                    string _ref = source.OnBehalfOf.Reference;
                    OnBehalfOf = new SubElement("onBehalfOf", _ref, fs);
                }
            }

        }

        public GroupElementPerformer(Immunization.PerformerComponent source, IFhirServer fs)
        {
            if (source != null && source.Actor != null && source.Actor.IsContainedReference)
            {
                string _ref = source.Actor.Reference;
                Actor = new SubElement("actor", _ref, fs);
            }

        }

        public SubElement Actor { get; private set; }
        public SubElement OnBehalfOf { get; private set; }
    }
}
