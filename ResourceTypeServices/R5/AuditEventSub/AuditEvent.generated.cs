

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AuditEventSub
{
    public class AuditEvent : DomainResource<AuditEvent>
    {
        #region Property
        [Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("action", typeof(FhirCode), true, false, false, false)]
public FhirCode Action {get; set;}
[Element("severity", typeof(FhirCode), true, false, false, false)]
public FhirCode Severity {get; set;}
[Element("occurred", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Occurred {get; set;}
[Element("recorded", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Recorded {get; set;}
[Element("outcome", typeof(Outcome), false, false, false, true)]
public Outcome Outcome {get; set;}
[Element("authorization", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Authorization {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("patient", typeof(Reference), false, false, false, false)]
public Reference Patient {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("agent", typeof(Agent), false, true, false, true)]
public IEnumerable<Agent> Agent {get; set;}
[Element("source", typeof(Source), false, false, false, true)]
public Source Source {get; set;}
[Element("entity", typeof(Entity), false, true, false, true)]
public IEnumerable<Entity> Entity {get; set;}

        #endregion
        #region Constructor
        public  AuditEvent() { }

        public  AuditEvent(string value) : base(value) { }
        public  AuditEvent(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "AuditEvent";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
