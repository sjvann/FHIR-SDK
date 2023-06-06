
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.NutritionIntakeSub
{
    public class IngredientLabel : BackboneElement<IngredientLabel>
    {

        #region Property
        [Element("nutrient", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Nutrient {get; set;}
[Element("amount", typeof(Quantity), false, false, false, false)]
public Quantity Amount {get; set;}

        #endregion
        #region Constructor
        public  IngredientLabel() { }
        public  IngredientLabel(string value) : base(value) { }
        public  IngredientLabel(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "IngredientLabel";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
