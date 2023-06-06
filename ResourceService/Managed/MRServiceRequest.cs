using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using ResourceMgr.Elements;
namespace ResourceMgr.Managed
{
    public class MRServiceRequest : MRBased<ServiceRequest>
    {
        #region Constructor
        public MRServiceRequest(List<ServiceRequest> resources, IFhirServer fs) : base(resources, fs)
        {
            _resourceName = "ServiceRequest";
        }
        #endregion
        #region Override
        public override void SetupSubElement()
        {
            ServiceRequest current = GetCurrentResource();
            if (current != null)
            {
                InstantiatesCanonical = GetCanonical("instantiatesCanonical", current.InstantiatesCanonical);
                BasedOn = GetReference("basedOn", current.BasedOn);
                Replaces = GetReference("replaces", current.Replaces);
                Quantity = GetDataType("quantity", current.Quantity);
                Subject = GetReference("subject", current.Subject);
                Encounter = GetReference("encounter", current.Encounter);
                Occurrence = GetDataType("occurrence", current.Occurrence);
                AsNeeded = GetDataType("asNeeded", current.AsNeeded);
                Requester = GetReference("requester", current.Requester);
                Performer = GetReference("performerType", current.Performer);
                LocationReference = GetReference("locationReference", current.LocationReference);
                ReasonReference = GetReference("reasonReference", current.ReasonReference);
                Insurance = GetReference("insurance", current.Insurance);
                SupportingInfo = GetReference("supportingInfo", current.SupportingInfo);
                Specimen = GetReference("specimen", current.Specimen);
                RelevantHistory = GetReference("relevantHistory", current.RelevantHistory);
                
            }
        }
        #endregion
        #region SubElement
     
        public SubElement Quantity { get; private set; }
        public SubElement Occurrence { get; private set; }
        public SubElement AsNeeded { get; private set; }
        public SubElement Subject { get; private set; }
        public SubElement Encounter { get; private set; }
        public SubElement Requester { get; private set; }

        public List<SubElement> InstantiatesCanonical { get; private set; }
        public List<SubElement> BasedOn { get; private set; }
        public List<SubElement> Replaces { get; private set; }
        public List<SubElement> Performer { get; private set; }
        public List<SubElement> LocationReference { get; private set; }
        public List<SubElement> ReasonReference { get; private set; }
        public List<SubElement> Insurance { get; private set; }
        public List<SubElement> SupportingInfo { get; private set; }
        public List<SubElement> Specimen { get; private set; }
        public List<SubElement> RelevantHistory { get; private set; }
        #endregion
    }
}
