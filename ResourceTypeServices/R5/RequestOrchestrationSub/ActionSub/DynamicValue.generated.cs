
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RequestOrchestrationSub.ActionSub
{
    public class DynamicValue : BackboneElement<DynamicValue>
    {

        #region Property
        [Element("path", typeof(FhirString), true, false, false, false)]
public FhirString Path {get; set;}
[Element("expression", typeof(Expression), false, false, false, false)]
public Expression Expression {get; set;}

        #endregion
        #region Constructor
        public  DynamicValue() { }
        public  DynamicValue(string value) : base(value) { }
        public  DynamicValue(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DynamicValue";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
