using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRAppointment:MRBased<Appointment>
    {
        #region Constructor
        public MRAppointment(List<Appointment> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Appointment";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Appointment current = GetCurrentResource();
            if (current != null)
            {
                if(current.ReasonReference != null && current.ReasonReference.Any())
                {
                    List<SubElement> tmp = new();
                    foreach(var item in current.ReasonReference.Where(x=>x.IsContainedReference))
                    {
                        tmp.Add(new SubElement("reasonReference", item.Reference, _fs));
                    }
                    ReasonReference = tmp;
                }
                if(current.SupportingInformation != null && current.SupportingInformation.Any())
                {
                    List<SubElement> tmp = new();
                    foreach (var item in current.SupportingInformation.Where(x => x.IsContainedReference))
                    {
                        tmp.Add(new SubElement("supportingInformation", item.Reference, _fs));
                    }
                    SupportingInformation = tmp;
                }
                if (current.BasedOn != null && current.BasedOn.Any())
                {
                    List<SubElement> tmp = new();
                    foreach (var item in current.BasedOn.Where(x => x.IsContainedReference))
                    {
                        tmp.Add(new SubElement("basedOn", item.Reference, _fs));
                    }
                    BasedOn = tmp;
                }
                if(current.Participant != null && current.Participant.Any())
                {
                     List<GroupElementParticipant> tmp = new();
                    foreach(var item in current.Participant)
                    {
                        tmp.Add(new GroupElementParticipant(item, _fs));
                    }
                    Participant = tmp;
                }
            }
        }
        #endregion
        #region SubElement
      
        public List<SubElement> ReasonReference { get; private set; }
        public List<SubElement> SupportingInformation { get; private set; }
        public List<SubElement> Slot { get; private set; }
        public List<SubElement> BasedOn { get; private set; }

        public List<GroupElementParticipant> Participant { get; set; }
        #endregion
    }
}
