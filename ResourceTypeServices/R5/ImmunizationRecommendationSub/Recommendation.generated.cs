
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ImmunizationRecommendationSub.RecommendationSub;

namespace ResourceTypeServices.R5.ImmunizationRecommendationSub
{
    public class Recommendation : BackboneElement<Recommendation>
    {

        #region Property
        [Element("vaccineCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> VaccineCode {get; set;}
[Element("targetDisease", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> TargetDisease {get; set;}
[Element("contraindicatedVaccineCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ContraindicatedVaccineCode {get; set;}
[Element("forecastStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ForecastStatus {get; set;}
[Element("forecastReason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ForecastReason {get; set;}
[Element("dateCriterion", typeof(DateCriterion), false, true, false, true)]
public IEnumerable<DateCriterion> DateCriterion {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("series", typeof(FhirString), true, false, false, false)]
public FhirString Series {get; set;}
[Element("doseNumber", typeof(FhirString), true, false, false, false)]
public FhirString DoseNumber {get; set;}
[Element("seriesDoses", typeof(FhirString), true, false, false, false)]
public FhirString SeriesDoses {get; set;}
[Element("supportingImmunization", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingImmunization {get; set;}
[Element("supportingPatientInformation", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupportingPatientInformation {get; set;}

        #endregion
        #region Constructor
        public  Recommendation() { }
        public  Recommendation(string value) : base(value) { }
        public  Recommendation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Recommendation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
