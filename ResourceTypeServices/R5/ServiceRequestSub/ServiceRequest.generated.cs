

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ServiceRequestSub
{
    public class ServiceRequest : DomainResource<ServiceRequest>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("instantiatesCanonical", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> InstantiatesCanonical {get; set;}
[Element("instantiatesUri", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> InstantiatesUri {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("replaces", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Replaces {get; set;}
[Element("requisition", typeof(Identifier), false, false, false, false)]
public Identifier Requisition {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("doNotPerform", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean DoNotPerform {get; set;}
[Element("code", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Code {get; set;}
[Element("orderDetail", typeof(OrderDetail), false, true, false, true)]
public IEnumerable<OrderDetail> OrderDetail {get; set;}
[Element("quantity", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Quantity {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("focus", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Focus {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("asNeeded", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased AsNeeded {get; set;}
[Element("authoredOn", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime AuthoredOn {get; set;}
[Element("requester", typeof(Reference), false, false, false, false)]
public Reference Requester {get; set;}
[Element("performerType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PerformerType {get; set;}
[Element("performer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Performer {get; set;}
[Element("location", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Location {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("insurance", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Insurance {get; set;}
[Element("supportingInfo", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> SupportingInfo {get; set;}
[Element("specimen", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Specimen {get; set;}
[Element("bodySite", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> BodySite {get; set;}
[Element("bodyStructure", typeof(Reference), false, false, false, false)]
public Reference BodyStructure {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("patientInstruction", typeof(PatientInstruction), false, true, false, true)]
public IEnumerable<PatientInstruction> PatientInstruction {get; set;}
[Element("relevantHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RelevantHistory {get; set;}

        #endregion
        #region Constructor
        public  ServiceRequest() { }

        public  ServiceRequest(string value) : base(value) { }
        public  ServiceRequest(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ServiceRequest";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
