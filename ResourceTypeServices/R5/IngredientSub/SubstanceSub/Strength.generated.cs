
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.IngredientSub.SubstanceSub.StrengthSub;

namespace ResourceTypeServices.R5.IngredientSub.SubstanceSub
{
    public class Strength : BackboneElement<Strength>
    {

        #region Property
        [Element("presentation", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Presentation {get; set;}
[Element("textPresentation", typeof(FhirString), true, false, false, false)]
public FhirString TextPresentation {get; set;}
[Element("concentration", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Concentration {get; set;}
[Element("textConcentration", typeof(FhirString), true, false, false, false)]
public FhirString TextConcentration {get; set;}
[Element("basis", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Basis {get; set;}
[Element("measurementPoint", typeof(FhirString), true, false, false, false)]
public FhirString MeasurementPoint {get; set;}
[Element("country", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Country {get; set;}
[Element("referenceStrength", typeof(ReferenceStrength), false, true, false, true)]
public IEnumerable<ReferenceStrength> ReferenceStrength {get; set;}

        #endregion
        #region Constructor
        public  Strength() { }
        public  Strength(string value) : base(value) { }
        public  Strength(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Strength";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
