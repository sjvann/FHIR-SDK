
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub.ItemSub
{
    public class ReviewOutcome : BackboneElement<ReviewOutcome>
    {

        #region Property
        [Element("decision", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Decision {get; set;}
[Element("reason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Reason {get; set;}
[Element("preAuthRef", typeof(FhirString), true, false, false, false)]
public FhirString PreAuthRef {get; set;}
[Element("preAuthPeriod", typeof(Period), false, false, false, false)]
public Period PreAuthPeriod {get; set;}

        #endregion
        #region Constructor
        public  ReviewOutcome() { }
        public  ReviewOutcome(string value) : base(value) { }
        public  ReviewOutcome(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ReviewOutcome";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
