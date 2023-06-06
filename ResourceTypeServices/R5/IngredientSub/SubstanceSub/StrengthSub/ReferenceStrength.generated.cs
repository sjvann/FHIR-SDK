
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.IngredientSub.SubstanceSub.StrengthSub
{
    public class ReferenceStrength : BackboneElement<ReferenceStrength>
    {

        #region Property
        [Element("substance", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Substance {get; set;}
[Element("strength", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Strength {get; set;}
[Element("measurementPoint", typeof(FhirString), true, false, false, false)]
public FhirString MeasurementPoint {get; set;}
[Element("country", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Country {get; set;}

        #endregion
        #region Constructor
        public  ReferenceStrength() { }
        public  ReferenceStrength(string value) : base(value) { }
        public  ReferenceStrength(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ReferenceStrength";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
