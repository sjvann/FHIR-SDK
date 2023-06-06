using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MREncounter : MRBased<Encounter>
    {
        #region Constructor
        public MREncounter(List<Encounter> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "Encounter";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            Encounter current = GetCurrentResource();
            if (current != null)
            {
                if (current.Subject != null && current.Subject.IsContainedReference)
                {
                    string _ref = current.Subject.Reference;
                    Subject = new SubElement("subject", _ref, _fs);
                }
                if (current.EpisodeOfCare != null && current.EpisodeOfCare.Count > 0)
                {
                    foreach (var item in current.EpisodeOfCare)
                    {
                        string _ref = item.Reference;
                        EpisodeOfCare.Add(new SubElement("episodeOfCare", _ref, _fs));
                    }
                }
                if (current.BasedOn != null && current.BasedOn.Count > 0)
                {
                    foreach (var item in current.BasedOn.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        BasedOn.Add(new SubElement("basedOn", _ref, _fs));
                    }
                }
                if (current.Participant != null && current.Participant.Count > 0)
                {
                    foreach (var item in current.Participant)
                    {
                        if (item.Individual != null && item.Individual.IsContainedReference)
                        {
                            Participant.Add(new GroupElementParticipant(item, _fs));
                        }
                    }
                }
                if (current.Appointment != null && current.Appointment.Count > 0)
                {
                    foreach (var item in current.Appointment.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Appointment.Add(new SubElement("appointment", _ref, _fs));
                    }
                }
                if(current.ReasonReference != null && current.ReasonReference.Count>0)
                {
                    foreach(var item in current.ReasonReference)
                    {
                        string _ref = item.Reference;
                        ReasonReference.Add(new SubElement("reasonReference", _ref, _fs));
                    }
                }
                if(current.Diagnosis != null && current.Diagnosis.Count >0)
                {
                    foreach(var item in current.Diagnosis)
                    {
                        if(item.Condition != null && item.Condition.IsContainedReference)
                        {
                            Diagnosis.Add(new GroupElementDiagnosis(item, _fs));
                        }
                    }
                }
                if(current.Account != null && current.Account.Count > 0)
                {
                    foreach(var item in current.Account.Where(x=>x.IsContainedReference))
                    {
                        string _ref = item.Reference;
                        Account.Add(new SubElement("account", _ref, _fs));
                    }
                }
                if(current.Hospitalization != null)
                {
                    Hospitalization = new GroupElementHospitalization(current.Hospitalization, _fs);
                }
                if(current.Location != null && current.Location.Count > 0)
                {
                    foreach(var item in current.Location)
                    {
                        Location.Add(new GroupElementLocation(item, _fs));
                    }
                }
                if(current.ServiceProvider != null  && current.ServiceProvider.IsContainedReference)
                {
                    string _ref = current.ServiceProvider.Reference;
                    ServiceProvider = new SubElement("serviceProvider", _ref, _fs);
                }
                if(current.PartOf != null && current.PartOf.IsContainedReference)
                {
                    string _ref = current.PartOf.Reference;
                    PartOf = new SubElement("partOf", _ref, _fs);
                }    
            }
        }
        #endregion
        #region SubElement
        public SubElement Subject { get; private set; }
        public List<SubElement> EpisodeOfCare { get; private set; }
        public List<SubElement> BasedOn { get; private set; }

        public List<GroupElementParticipant> Participant { get; private set; }
        public List<SubElement> Appointment { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }
        public List<GroupElementDiagnosis> Diagnosis { get; private set; }
        public List<SubElement> Account { get; private set; }
        public GroupElementHospitalization Hospitalization { get; private set; }
        public List<GroupElementLocation> Location { get; private set; }
        public SubElement ServiceProvider { get; private set; }
        public SubElement PartOf { get; private set; }

        #endregion
    }
}
