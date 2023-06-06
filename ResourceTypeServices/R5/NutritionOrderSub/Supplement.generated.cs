
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.NutritionOrderSub.SupplementSub;

namespace ResourceTypeServices.R5.NutritionOrderSub
{
    public class Supplement : BackboneElement<Supplement>
    {

        #region Property
        [Element("type", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Type {get; set;}
[Element("productName", typeof(FhirString), true, false, false, false)]
public FhirString ProductName {get; set;}
[Element("schedule", typeof(Schedule), false, false, false, true)]
public Schedule Schedule {get; set;}
[Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("instruction", typeof(FhirString), true, false, false, false)]
public FhirString Instruction {get; set;}

        #endregion
        #region Constructor
        public  Supplement() { }
        public  Supplement(string value) : base(value) { }
        public  Supplement(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Supplement";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
