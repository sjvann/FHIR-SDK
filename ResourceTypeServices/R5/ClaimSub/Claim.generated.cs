

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClaimSub
{
    public class Claim : DomainResource<Claim>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("traceNumber", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> TraceNumber {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SubType {get; set;}
[Element("use", typeof(FhirCode), true, false, false, false)]
public FhirCode Use {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("billablePeriod", typeof(Period), false, false, false, false)]
public Period BillablePeriod {get; set;}
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("enterer", typeof(Reference), false, false, false, false)]
public Reference Enterer {get; set;}
[Element("insurer", typeof(Reference), false, false, false, false)]
public Reference Insurer {get; set;}
[Element("provider", typeof(Reference), false, false, false, false)]
public Reference Provider {get; set;}
[Element("priority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Priority {get; set;}
[Element("fundsReserve", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FundsReserve {get; set;}
[Element("related", typeof(Related), false, true, false, true)]
public IEnumerable<Related> Related {get; set;}
[Element("prescription", typeof(Reference), false, false, false, false)]
public Reference Prescription {get; set;}
[Element("originalPrescription", typeof(Reference), false, false, false, false)]
public Reference OriginalPrescription {get; set;}
[Element("payee", typeof(Payee), false, false, false, true)]
public Payee Payee {get; set;}
[Element("referral", typeof(Reference), false, false, false, false)]
public Reference Referral {get; set;}
[Element("encounter", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Encounter {get; set;}
[Element("facility", typeof(Reference), false, false, false, false)]
public Reference Facility {get; set;}
[Element("diagnosisRelatedGroup", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DiagnosisRelatedGroup {get; set;}
[Element("event", typeof(Event), false, true, false, true)]
public IEnumerable<Event> Event {get; set;}
[Element("careTeam", typeof(CareTeam), false, true, false, true)]
public IEnumerable<CareTeam> CareTeam {get; set;}
[Element("supportingInfo", typeof(SupportingInfo), false, true, false, true)]
public IEnumerable<SupportingInfo> SupportingInfo {get; set;}
[Element("diagnosis", typeof(Diagnosis), false, true, false, true)]
public IEnumerable<Diagnosis> Diagnosis {get; set;}
[Element("procedure", typeof(Procedure), false, true, false, true)]
public IEnumerable<Procedure> Procedure {get; set;}
[Element("insurance", typeof(Insurance), false, true, false, true)]
public IEnumerable<Insurance> Insurance {get; set;}
[Element("accident", typeof(Accident), false, false, false, true)]
public Accident Accident {get; set;}
[Element("patientPaid", typeof(Money), false, false, false, false)]
public Money PatientPaid {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}
[Element("total", typeof(Money), false, false, false, false)]
public Money Total {get; set;}

        #endregion
        #region Constructor
        public  Claim() { }

        public  Claim(string value) : base(value) { }
        public  Claim(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Claim";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
