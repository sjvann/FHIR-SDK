
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.NutritionOrderSub.OralDietSub
{
    public class Nutrient : BackboneElement<Nutrient>
    {

        #region Property
        [Element("modifier", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Modifier {get; set;}
[Element("amount", typeof(Quantity), false, false, false, false)]
public Quantity Amount {get; set;}

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
