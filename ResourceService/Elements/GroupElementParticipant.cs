using Hl7.Fhir.Model;

namespace ResourceMgr.Elements
{
    public class GroupElementParticipant
    {
       
        public GroupElementParticipant(Encounter.ParticipantComponent source, IFhirServer _fs)
        {
            if(source != null && source.Individual != null && source.Individual.IsContainedReference)
            {
                string _ref = source.Individual.Reference;
                Individual = new SubElement("individual", _ref, _fs);
            }
            
        }
        public GroupElementParticipant(Appointment.ParticipantComponent source, IFhirServer _fs)
        {
            if (source != null && source.Actor != null && source.Actor.IsContainedReference)
            {
                string _ref = source.Actor.Reference;
                Actor = new SubElement("actor", _ref, _fs);
            }

        }
        public GroupElementParticipant(CareTeam.ParticipantComponent source, IFhirServer _fs)
        {
            if(source != null)
            {
                if(source.Member != null && source.Member.IsContainedReference)
                {
                    Member = new SubElement("member", source.Member.Reference, _fs);
                }
                if(source.OnBehalfOf != null && source.OnBehalfOf.IsContainedReference)
                {
                    OnBehalfOf = new SubElement("onBehalfOf", source.OnBehalfOf.Reference, _fs);
                }
            }
        }

        public SubElement Individual { get; private set; }
        public SubElement Member { get; private set; }
        public SubElement OnBehalfOf { get; private set; }
        public SubElement Actor { get; private set; }
    }
}
