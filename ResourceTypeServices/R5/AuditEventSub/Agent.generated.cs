
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AuditEventSub
{
    public class Agent : BackboneElement<Agent>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("role", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Role {get; set;}
[Element("who", typeof(Reference), false, false, false, false)]
public Reference Who {get; set;}
[Element("requestor", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Requestor {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("policy", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Policy {get; set;}
[Element("network", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Network {get; set;}
[Element("authorization", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Authorization {get; set;}

        #endregion
        #region Constructor
        public  Agent() { }
        public  Agent(string value) : base(value) { }
        public  Agent(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Agent";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
