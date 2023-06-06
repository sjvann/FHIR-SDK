
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.InsurancePlanSub.PlanSub.SpecificCostSub;

namespace ResourceTypeServices.R5.InsurancePlanSub.PlanSub
{
    public class SpecificCost : BackboneElement<SpecificCost>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("benefit", typeof(Benefit), false, true, false, true)]
public IEnumerable<Benefit> Benefit {get; set;}

        #endregion
        #region Constructor
        public  SpecificCost() { }
        public  SpecificCost(string value) : base(value) { }
        public  SpecificCost(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SpecificCost";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
