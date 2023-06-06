
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ProvenanceSub
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
[Element("onBehalfOf", typeof(Reference), false, false, false, false)]
public Reference OnBehalfOf {get; set;}

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
