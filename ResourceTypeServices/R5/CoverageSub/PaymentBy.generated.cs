
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageSub
{
    public class PaymentBy : BackboneElement<PaymentBy>
    {

        #region Property
        [Element("party", typeof(Reference), false, false, false, false)]
public Reference Party {get; set;}
[Element("responsibility", typeof(FhirString), true, false, false, false)]
public FhirString Responsibility {get; set;}

        #endregion
        #region Constructor
        public  PaymentBy() { }
        public  PaymentBy(string value) : base(value) { }
        public  PaymentBy(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PaymentBy";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
