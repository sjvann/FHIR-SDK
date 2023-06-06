using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRMedicationRequest : MRBased<MedicationRequest>
    {
        #region Constructor
        public MRMedicationRequest(List<MedicationRequest> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "MedicationRequest";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            MedicationRequest current = GetCurrentResource();
            if (current != null)
            {
               if(current.Reported != null && current.Reported.TypeName == FHIRDefinedType.Reference.ToString())
                {
                    ResourceReference temp = current.Reported as ResourceReference;
                    Reported = new SubElement("reported", temp.Reference, _fs);
                }
                else
                {
                    Reported = new SubElement("reported",current.Reported.TypeName,current.Reported);
                }
                if (current.Medication != null && current.Medication.TypeName == FHIRDefinedType.Reference.ToString())
                {
                    ResourceReference temp = current.Medication as ResourceReference;
                    Medication = new SubElement("reported", temp.Reference, _fs);
                }
                else
                {
                    Medication = new SubElement("reported", current.Medication.TypeName, current.Medication);
                }
                if(current.Subject != null && current.Subject.IsContainedReference)
                {
                    Subject = new SubElement("subject", current.Subject.Reference, _fs);
                }
                if (current.Encounter != null && current.Encounter.IsContainedReference)
                {
                    Encounter = new SubElement("encounter", current.Encounter.Reference, _fs);
                }
                if (current.Requester != null && current.Requester.IsContainedReference)
                {
                    Requester = new SubElement("requester", current.Requester.Reference, _fs);
                }
                if (current.Performer != null && current.Performer.IsContainedReference)
                {
                    Performer = new SubElement("performer", current.Performer.Reference, _fs);
                }
                if (current.Recorder != null && current.Recorder.IsContainedReference)
                {
                    Recorder = new SubElement("recorder", current.Recorder.Reference, _fs);
                }
                if (current.PriorPrescription != null && current.PriorPrescription.IsContainedReference)
                {
                    PriorPrescription = new SubElement("priorPrescription", current.PriorPrescription.Reference, _fs);
                }
                if(current.SupportingInformation != null && current.SupportingInformation.Any())
                {
                    List<SubElement> temp = new();
                    foreach(var item in current.SupportingInformation.Where(x=>x.IsContainedReference))
                    {
                        temp.Add(new SubElement("supportingInformation", item.Reference, _fs));
                    }
                    SupportingInformation = temp;
                }
                if (current.ReasonReference != null && current.ReasonReference.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.ReasonReference.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("reasonReference", item.Reference, _fs));
                    }
                    ReasonReference = temp;
                }

                if (current.BasedOn != null && current.BasedOn.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.BasedOn.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("basedOn", item.Reference, _fs));
                    }
                    BasedOn = temp;
                }
                if (current.Insurance != null && current.Insurance.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.Insurance.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("insurance", item.Reference, _fs));
                    }
                    Insurance = temp;
                }
                if (current.DetectedIssue != null && current.DetectedIssue.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.DetectedIssue.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("detectedIssue", item.Reference, _fs));
                    }
                    DetectedIssue = temp;
                }
                if (current.EventHistory != null && current.EventHistory.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.EventHistory.Where(x => x.IsContainedReference))
                    {
                        temp.Add(new SubElement("eventHistory", item.Reference, _fs));
                    }
                    EventHistory = temp;
                }

                if (current.InstantiatesCanonical != null && current.InstantiatesCanonical.Any())
                {
                    List<SubElement> temp = new();
                    foreach (var item in current.InstantiatesCanonical)
                    {
                        temp.Add(new SubElement("instantiatesCanonical",string.Empty, item));
                    }
                    InstantiatesCanonical = temp;
                }
                if(current.DispenseRequest != null)
                {
                    DispenseRequest = new GroupElementDispenseRequest(current.DispenseRequest, _fs);
                }
                if (current.Substitution != null)
                {
                    Substitution = new GroupElementSubstitution(current.Substitution, _fs);
                }
            }

        }
        #endregion
        #region SubElement
        public SubElement Reported { get; private set; }
        public SubElement Medication { get; private set; }
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Requester { get; private set; }
        public SubElement Performer { get; private set; }
        public SubElement Recorder { get; private set; }
        public SubElement PriorPrescription { get; private set; }
        public List<SubElement> SupportingInformation { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }
        public List<SubElement> InstantiatesCanonical { get; private set; }
        public List<SubElement> BasedOn { get; private set; }
        public List<SubElement> Insurance { get; private set; }
        public List<SubElement> DetectedIssue { get; private set; }
        public List<SubElement> EventHistory { get; private set; }
        public GroupElementDispenseRequest DispenseRequest { get; private set; }
        public GroupElementSubstitution Substitution { get; private set; }

        #endregion
    }
}
