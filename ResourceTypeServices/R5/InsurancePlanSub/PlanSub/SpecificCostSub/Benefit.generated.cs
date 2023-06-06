
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.InsurancePlanSub.PlanSub.SpecificCostSub.BenefitSub;

namespace ResourceTypeServices.R5.InsurancePlanSub.PlanSub.SpecificCostSub
{
    public class Benefit : BackboneElement<Benefit>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("cost", typeof(Cost), false, true, false, true)]
public IEnumerable<Cost> Cost {get; set;}

        #endregion
        #region Constructor
        public  Benefit() { }
        public  Benefit(string value) : base(value) { }
        public  Benefit(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Benefit";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
