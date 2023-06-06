
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.NutritionOrderSub.OralDietSub;

namespace ResourceTypeServices.R5.NutritionOrderSub
{
    public class OralDiet : BackboneElement<OralDiet>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("schedule", typeof(Schedule), false, false, false, true)]
public Schedule Schedule {get; set;}
[Element("nutrient", typeof(Nutrient), false, true, false, true)]
public IEnumerable<Nutrient> Nutrient {get; set;}
[Element("texture", typeof(Texture), false, true, false, true)]
public IEnumerable<Texture> Texture {get; set;}
[Element("fluidConsistencyType", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> FluidConsistencyType {get; set;}
[Element("instruction", typeof(FhirString), true, false, false, false)]
public FhirString Instruction {get; set;}

        #endregion
        #region Constructor
        public  OralDiet() { }
        public  OralDiet(string value) : base(value) { }
        public  OralDiet(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "OralDiet";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
