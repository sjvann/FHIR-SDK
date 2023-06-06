using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRCareTeam : MRBased<CareTeam>
    {
        #region Constructor
        public MRCareTeam(List<CareTeam> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "CareTeam";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            CareTeam current = GetCurrentResource();
            if (current != null)
            {
                if (current.Subject != null && current.Subject.IsContainedReference)
                {
                    Subject = new SubElement("subject", current.Subject.Reference, _fs);
                }
                if (current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    Encounter = new SubElement("encounter", current.Encounter.Reference, _fs);
                }
                if(current.Participant != null && current.Participant.Any())
                {
                    List<GroupElementParticipant> temp = new();
                    foreach(var item in current.Participant)
                    {
                        temp.Add(new GroupElementParticipant(item, _fs));
                    }
                    Participant = temp;
                }
                if(current.ReasonReference!= null && current.ReasonReference.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.ReasonReference.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("reasonReference", item.Reference, _fs));
                    }
                    ReasonReference = temp;
                }
                if(current.ManagingOrganization != null && current.ManagingOrganization.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.ManagingOrganization.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("managingOrganization", item.Reference, _fs));
                    }
                    ManagingOrganization = temp;
                }
            }
        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }
        public List<SubElement> ManagingOrganization { get; private set; }

        public List<GroupElementParticipant> Participant { get; private set; }
        #endregion
    }
}
