
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RiskAssessmentSub
{
    public class Prediction : BackboneElement<Prediction>
    {

        #region Property
        [Element("outcome", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Outcome {get; set;}
[Element("probability", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Probability {get; set;}
[Element("qualitativeRisk", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept QualitativeRisk {get; set;}
[Element("relativeRisk", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal RelativeRisk {get; set;}
[Element("when", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased When {get; set;}
[Element("rationale", typeof(FhirString), true, false, false, false)]
public FhirString Rationale {get; set;}

        #endregion
        #region Constructor
        public  Prediction() { }
        public  Prediction(string value) : base(value) { }
        public  Prediction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Prediction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
