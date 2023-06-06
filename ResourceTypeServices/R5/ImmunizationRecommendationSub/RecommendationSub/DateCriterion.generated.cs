
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ImmunizationRecommendationSub.RecommendationSub
{
    public class DateCriterion : BackboneElement<DateCriterion>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("value", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Value {get; set;}

        #endregion
        #region Constructor
        public  DateCriterion() { }
        public  DateCriterion(string value) : base(value) { }
        public  DateCriterion(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DateCriterion";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
