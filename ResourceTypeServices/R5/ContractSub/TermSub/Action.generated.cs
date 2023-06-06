
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ContractSub.TermSub.ActionSub;

namespace ResourceTypeServices.R5.ContractSub.TermSub
{
    public class Action : BackboneElement<Action>
    {

        #region Property
        [Element("doNotPerform", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean DoNotPerform {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subject", typeof(Subject), false, true, false, true)]
public IEnumerable<Subject> Subject {get; set;}
[Element("intent", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Intent {get; set;}
[Element("linkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> LinkId {get; set;}
[Element("status", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Status {get; set;}
[Element("context", typeof(Reference), false, false, false, false)]
public Reference Context {get; set;}
[Element("contextLinkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> ContextLinkId {get; set;}
[Element("occurrence", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurrence {get; set;}
[Element("requester", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Requester {get; set;}
[Element("requesterLinkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> RequesterLinkId {get; set;}
[Element("performerType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> PerformerType {get; set;}
[Element("performerRole", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PerformerRole {get; set;}
[Element("performer", typeof(Reference), false, false, false, false)]
public Reference Performer {get; set;}
[Element("performerLinkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> PerformerLinkId {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("reasonLinkId", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> ReasonLinkId {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("securityLabelNumber", typeof(FhirUnsignedInt), true, true, false, false)]
public IEnumerable<FhirUnsignedInt> SecurityLabelNumber {get; set;}

        #endregion
        #region Constructor
        public  Action() { }
        public  Action(string value) : base(value) { }
        public  Action(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Action";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
