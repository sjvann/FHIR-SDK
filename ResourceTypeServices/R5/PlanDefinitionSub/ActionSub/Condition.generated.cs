
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.PlanDefinitionSub.ActionSub
{
    public class Condition : BackboneElement<Condition>
    {

        #region Property
        [Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("expression", typeof(Expression), false, false, false, false)]
public Expression Expression {get; set;}

        #endregion
        #region Constructor
        public  Condition() { }
        public  Condition(string value) : base(value) { }
        public  Condition(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Condition";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
