
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceSub
{
    public class Ingredient : BackboneElement<Ingredient>
    {

        #region Property
        [Element("quantity", typeof(Ratio), false, false, false, false)]
public Ratio Quantity {get; set;}
[Element("substance", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Substance {get; set;}

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
