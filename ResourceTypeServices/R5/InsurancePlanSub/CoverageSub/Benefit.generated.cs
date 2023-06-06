
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.InsurancePlanSub.CoverageSub.BenefitSub;

namespace ResourceTypeServices.R5.InsurancePlanSub.CoverageSub
{
    public class Benefit : BackboneElement<Benefit>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("requirement", typeof(FhirString), true, false, false, false)]
public FhirString Requirement {get; set;}
[Element("limit", typeof(Limit), false, true, false, true)]
public IEnumerable<Limit> Limit {get; set;}

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
