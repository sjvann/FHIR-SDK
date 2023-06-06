

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class ExplanationOfBenefit : DomainResource<ExplanationOfBenefit>
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
[Element("fundsReserveRequested", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FundsReserveRequested {get; set;}
[Element("fundsReserve", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FundsReserve {get; set;}
[Element("related", typeof(Related), false, true, false, true)]
public IEnumerable<Related> Related {get; set;}
[Element("prescription", typeof(Reference), false, false, false, false)]
public Reference Prescription {get; set;}
[Element("originalPrescription", typeof(Reference), false, false, false, false)]
public Reference OriginalPrescription {get; set;}
[Element("event", typeof(Event), false, true, false, true)]
public IEnumerable<Event> Event {get; set;}
[Element("payee", typeof(Payee), false, false, false, true)]
public Payee Payee {get; set;}
[Element("referral", typeof(Reference), false, false, false, false)]
public Reference Referral {get; set;}
[Element("encounter", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Encounter {get; set;}
[Element("facility", typeof(Reference), false, false, false, false)]
public Reference Facility {get; set;}
[Element("claim", typeof(Reference), false, false, false, false)]
public Reference Claim {get; set;}
[Element("claimResponse", typeof(Reference), false, false, false, false)]
public Reference ClaimResponse {get; set;}
[Element("outcome", typeof(FhirCode), true, false, false, false)]
public FhirCode Outcome {get; set;}
[Element("decision", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Decision {get; set;}
[Element("disposition", typeof(FhirString), true, false, false, false)]
public FhirString Disposition {get; set;}
[Element("preAuthRef", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> PreAuthRef {get; set;}
[Element("preAuthRefPeriod", typeof(Period), false, true, false, false)]
public IEnumerable<Period> PreAuthRefPeriod {get; set;}
[Element("diagnosisRelatedGroup", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DiagnosisRelatedGroup {get; set;}
[Element("careTeam", typeof(CareTeam), false, true, false, true)]
public IEnumerable<CareTeam> CareTeam {get; set;}
[Element("supportingInfo", typeof(SupportingInfo), false, true, false, true)]
public IEnumerable<SupportingInfo> SupportingInfo {get; set;}
[Element("diagnosis", typeof(Diagnosis), false, true, false, true)]
public IEnumerable<Diagnosis> Diagnosis {get; set;}
[Element("procedure", typeof(Procedure), false, true, false, true)]
public IEnumerable<Procedure> Procedure {get; set;}
[Element("precedence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Precedence {get; set;}
[Element("insurance", typeof(Insurance), false, true, false, true)]
public IEnumerable<Insurance> Insurance {get; set;}
[Element("accident", typeof(Accident), false, false, false, true)]
public Accident Accident {get; set;}
[Element("patientPaid", typeof(Money), false, false, false, false)]
public Money PatientPaid {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}
[Element("addItem", typeof(AddItem), false, true, false, true)]
public IEnumerable<AddItem> AddItem {get; set;}
[Element("total", typeof(Total), false, true, false, true)]
public IEnumerable<Total> Total {get; set;}
[Element("payment", typeof(Payment), false, false, false, true)]
public Payment Payment {get; set;}
[Element("formCode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FormCode {get; set;}
[Element("form", typeof(Attachment), false, false, false, false)]
public Attachment Form {get; set;}
[Element("processNote", typeof(ProcessNote), false, true, false, true)]
public IEnumerable<ProcessNote> ProcessNote {get; set;}
[Element("benefitPeriod", typeof(Period), false, false, false, false)]
public Period BenefitPeriod {get; set;}
[Element("benefitBalance", typeof(BenefitBalance), false, true, false, true)]
public IEnumerable<BenefitBalance> BenefitBalance {get; set;}

        #endregion
        #region Constructor
        public  ExplanationOfBenefit() { }

        public  ExplanationOfBenefit(string value) : base(value) { }
        public  ExplanationOfBenefit(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ExplanationOfBenefit";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
