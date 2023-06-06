

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationRequestSub
{
    public class MedicationRequest : DomainResource<MedicationRequest>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("priorPrescription", typeof(Reference), false, false, false, false)]
public Reference PriorPrescription {get; set;}
[Element("groupIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier GroupIdentifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("statusReason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept StatusReason {get; set;}
[Element("statusChanged", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StatusChanged {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("doNotPerform", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean DoNotPerform {get; set;}
[Element("medication", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Medication {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("informationSource", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> InformationSource {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("supportingInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInformation {get; set;}
[Element("authoredOn", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime AuthoredOn {get; set;}
[Element("requester", typeof(Reference), false, false, false, false)]
public Reference Requester {get; set;}
[Element("reported", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Reported {get; set;}
[Element("performerType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PerformerType {get; set;}
[Element("performer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Performer {get; set;}
[Element("device", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Device {get; set;}
[Element("recorder", typeof(Reference), false, false, false, false)]
public Reference Recorder {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("courseOfTherapyType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept CourseOfTherapyType {get; set;}
[Element("insurance", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Insurance {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("renderedDosageInstruction", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown RenderedDosageInstruction {get; set;}
[Element("effectiveDosePeriod", typeof(Period), false, false, false, false)]
public Period EffectiveDosePeriod {get; set;}
[Element("dosageInstruction", typeof(Dosage), false, true, false, false)]
public IEnumerable<Dosage> DosageInstruction {get; set;}
[Element("dispenseRequest", typeof(DispenseRequest), false, false, false, true)]
public DispenseRequest DispenseRequest {get; set;}
[Element("substitution", typeof(Substitution), false, false, false, true)]
public Substitution Substitution {get; set;}
[Element("eventHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EventHistory {get; set;}

        #endregion
        #region Constructor
        public  MedicationRequest() { }

        public  MedicationRequest(string value) : base(value) { }
        public  MedicationRequest(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicationRequest";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
