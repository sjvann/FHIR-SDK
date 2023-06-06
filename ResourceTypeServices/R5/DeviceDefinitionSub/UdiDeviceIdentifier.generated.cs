
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.DeviceDefinitionSub.UdiDeviceIdentifierSub;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class UdiDeviceIdentifier : BackboneElement<UdiDeviceIdentifier>
    {

        #region Property
        [Element("deviceIdentifier", typeof(FhirString), true, false, false, false)]
public FhirString DeviceIdentifier {get; set;}
[Element("issuer", typeof(FhirUri), true, false, false, false)]
public FhirUri Issuer {get; set;}
[Element("jurisdiction", typeof(FhirUri), true, false, false, false)]
public FhirUri Jurisdiction {get; set;}
[Element("marketDistribution", typeof(MarketDistribution), false, true, false, true)]
public IEnumerable<MarketDistribution> MarketDistribution {get; set;}

        #endregion
        #region Constructor
        public  UdiDeviceIdentifier() { }
        public  UdiDeviceIdentifier(string value) : base(value) { }
        public  UdiDeviceIdentifier(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "UdiDeviceIdentifier";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
