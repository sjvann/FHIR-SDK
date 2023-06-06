
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NutritionOrderSub.EnteralFormulaSub
{
    public class Additive : BackboneElement<Additive>
    {

        #region Property
        [Element("type", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Type {get; set;}
[Element("productName", typeof(FhirString), true, false, false, false)]
public FhirString ProductName {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}

        #endregion
        #region Constructor
        public  Additive() { }
        public  Additive(string value) : base(value) { }
        public  Additive(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Additive";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
