
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.CoverageEligibilityResponseSub.InsuranceSub;

namespace ResourceTypeServices.R5.CoverageEligibilityResponseSub
{
    public class Insurance : BackboneElement<Insurance>
    {

        #region Property
        [Element("coverage", typeof(Reference), false, false, false, false)]
public Reference Coverage {get; set;}
[Element("inforce", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Inforce {get; set;}
[Element("benefitPeriod", typeof(Period), false, false, false, false)]
public Period BenefitPeriod {get; set;}
[Element("item", typeof(Item), false, true, false, true)]
public IEnumerable<Item> Item {get; set;}

        #endregion
        #region Constructor
        public  Insurance() { }
        public  Insurance(string value) : base(value) { }
        public  Insurance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Insurance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
