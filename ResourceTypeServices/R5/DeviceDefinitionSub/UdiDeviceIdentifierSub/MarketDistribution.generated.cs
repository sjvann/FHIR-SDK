
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub.UdiDeviceIdentifierSub
{
    public class MarketDistribution : BackboneElement<MarketDistribution>
    {

        #region Property
        [Element("marketPeriod", typeof(Period), false, false, false, false)]
public Period MarketPeriod {get; set;}
[Element("subJurisdiction", typeof(FhirUri), true, false, false, false)]
public FhirUri SubJurisdiction {get; set;}

        #endregion
        #region Constructor
        public  MarketDistribution() { }
        public  MarketDistribution(string value) : base(value) { }
        public  MarketDistribution(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MarketDistribution";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
