
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceSub
{
    public class UdiCarrier : BackboneElement<UdiCarrier>
    {

        #region Property
        [Element("deviceIdentifier", typeof(FhirString), true, false, false, false)]
public FhirString DeviceIdentifier {get; set;}
[Element("issuer", typeof(FhirUri), true, false, false, false)]
public FhirUri Issuer {get; set;}
[Element("jurisdiction", typeof(FhirUri), true, false, false, false)]
public FhirUri Jurisdiction {get; set;}
[Element("carrierAIDC", typeof(FhirBase64Binary), true, false, false, false)]
public FhirBase64Binary CarrierAIDC {get; set;}
[Element("carrierHRF", typeof(FhirString), true, false, false, false)]
public FhirString CarrierHRF {get; set;}
[Element("entryType", typeof(FhirCode), true, false, false, false)]
public FhirCode EntryType {get; set;}

        #endregion
        #region Constructor
        public  UdiCarrier() { }
        public  UdiCarrier(string value) : base(value) { }
        public  UdiCarrier(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "UdiCarrier";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
