
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.NutritionOrderSub.OralDietSub
{
    public class Texture : BackboneElement<Texture>
    {

        #region Property
        [Element("modifier", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Modifier {get; set;}
[Element("foodType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept FoodType {get; set;}

        #endregion
        #region Constructor
        public  Texture() { }
        public  Texture(string value) : base(value) { }
        public  Texture(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Texture";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
