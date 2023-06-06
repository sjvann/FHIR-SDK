
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CoverageEligibilityRequestSub
{
    public class SupportingInfo : BackboneElement<SupportingInfo>
    {

        #region Property
        [Element("sequence", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Sequence {get; set;}
[Element("information", typeof(Reference), false, false, false, false)]
public Reference Information {get; set;}
[Element("appliesToAll", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AppliesToAll {get; set;}

        #endregion
        #region Constructor
        public  SupportingInfo() { }
        public  SupportingInfo(string value) : base(value) { }
        public  SupportingInfo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "SupportingInfo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
