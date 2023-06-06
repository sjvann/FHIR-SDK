
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.ServiceRequestSub.OrderDetailSub;

namespace ResourceTypeServices.R5.ServiceRequestSub
{
    public class OrderDetail : BackboneElement<OrderDetail>
    {

        #region Property
        [Element("parameterFocus", typeof(CodeableReference), false, false, false, false)]
public CodeableReference ParameterFocus {get; set;}
[Element("parameter", typeof(Parameter), false, true, false, true)]
public IEnumerable<Parameter> Parameter {get; set;}

        #endregion
        #region Constructor
        public  OrderDetail() { }
        public  OrderDetail(string value) : base(value) { }
        public  OrderDetail(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "OrderDetail";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
