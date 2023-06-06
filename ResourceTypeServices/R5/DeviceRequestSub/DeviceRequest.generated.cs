

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceRequestSub
{
    public class DeviceRequest : DomainResource<DeviceRequest>
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
[Element("groupIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier GroupIdentifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("intent", typeof(FhirCode), true, false, false, false)]
public FhirCode Intent {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("doNotPerform", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean DoNotPerform {get; set;}
[Element("code", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Code {get; set;}
[Element("quantity", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Quantity {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("authoredOn", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime AuthoredOn {get; set;}
[Element("requester", typeof(Reference), false, false, false, false)]
public Reference Requester {get; set;}
[Element("performer", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Performer {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("asNeeded", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AsNeeded {get; set;}
[Element("asNeededFor", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AsNeededFor {get; set;}
[Element("insurance", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Insurance {get; set;}
[Element("supportingInfo", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingInfo {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("relevantHistory", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> RelevantHistory {get; set;}

        #endregion
        #region Constructor
        public  DeviceRequest() { }

        public  DeviceRequest(string value) : base(value) { }
        public  DeviceRequest(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceRequest";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
