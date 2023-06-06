
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ConditionDefinitionSub
{
    public class Plan : BackboneElement<Plan>
    {

        #region Property
        [Element("role", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Role {get; set;}
[Element("reference", typeof(Reference), false, false, false, false)]
public Reference Reference {get; set;}

        #endregion
        #region Constructor
        public  Plan() { }
        public  Plan(string value) : base(value) { }
        public  Plan(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Plan";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
