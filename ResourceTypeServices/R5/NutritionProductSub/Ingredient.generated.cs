
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.NutritionProductSub
{
    public class Ingredient : BackboneElement<Ingredient>
    {

        #region Property
        [Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("amount", typeof(Ratio), false, true, false, false)]
public IEnumerable<Ratio> Amount {get; set;}

        #endregion
        #region Constructor
        public  Ingredient() { }
        public  Ingredient(string value) : base(value) { }
        public  Ingredient(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Ingredient";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
