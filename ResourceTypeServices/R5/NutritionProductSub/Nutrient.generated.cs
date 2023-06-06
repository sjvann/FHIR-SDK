
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.NutritionProductSub
{
    public class Nutrient : BackboneElement<Nutrient>
    {

        #region Property
        [Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("amount", typeof(Ratio), false, true, false, false)]
public IEnumerable<Ratio> Amount {get; set;}

        #endregion
        #region Constructor
        public  Nutrient() { }
        public  Nutrient(string value) : base(value) { }
        public  Nutrient(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Nutrient";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
