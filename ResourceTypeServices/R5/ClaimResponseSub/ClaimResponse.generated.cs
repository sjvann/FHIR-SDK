

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClaimResponseSub
{
    public class ClaimResponse : DomainResource<ClaimResponse>
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
[Element("created", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Created {get; set;}
[Element("insurer", typeof(Reference), false, false, false, false)]
public Reference Insurer {get; set;}
[Element("requestor", typeof(Reference), false, false, false, false)]
public Reference Requestor {get; set;}
[Element("request", typeof(Reference), false, false, false, false)]
public Reference Request {get; set;}
[Element("outcome", typeof(FhirCode), true, false, false, false)]
public FhirCode Outcome {get; set;}
[Element("decision", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Decision {get; set;}
[Element("disposition", typeof(FhirString), true, false, false, false)]
public FhirString Disposition {get; set;}
[Element("preAuthRef", typeof(FhirString), true, false, false, false)]
public FhirString PreAuthRef {get; set;}
[Element("preAuthPeriod", typeof(Period), false, false, false, false)]
public Period PreAuthPeriod {get; set;}
[Element("event", typeof(Event), false, true, false, true)]
public IEnumerable<Event> Event {get; set;}
[Element("payeeType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PayeeType {get; set;}
[Element("encounter", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Encounter {get; set;}
[Element("diagnosisRelatedGroup", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DiagnosisRelatedGroup {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}
[Element("addItem", typeof(AddItem), false, true, false, true)]
public IEnumerable<AddItem> AddItem {get; set;}
[Element("total", typeof(Total), false, true, false, true)]
public IEnumerable<Total> Total {get; set;}
[Element("payment", typeof(Payment), false, false, false, true)]
public Payment Payment {get; set;}
[Element("fundsReserve", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FundsReserve {get; set;}
[Element("formCode", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FormCode {get; set;}
[Element("form", typeof(Attachment), false, false, false, false)]
public Attachment Form {get; set;}
[Element("processNote", typeof(ProcessNote), false, true, false, true)]
public IEnumerable<ProcessNote> ProcessNote {get; set;}
[Element("communicationRequest", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> CommunicationRequest {get; set;}
[Element("insurance", typeof(Insurance), false, true, false, true)]
public IEnumerable<Insurance> Insurance {get; set;}
[Element("error", typeof(Error), false, true, false, true)]
public IEnumerable<Error> Error {get; set;}

        #endregion
        #region Constructor
        public  ClaimResponse() { }

        public  ClaimResponse(string value) : base(value) { }
        public  ClaimResponse(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ClaimResponse";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
