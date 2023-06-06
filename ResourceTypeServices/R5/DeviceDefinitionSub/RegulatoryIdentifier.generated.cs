
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class RegulatoryIdentifier : BackboneElement<RegulatoryIdentifier>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("deviceIdentifier", typeof(FhirString), true, false, false, false)]
public FhirString DeviceIdentifier {get; set;}
[Element("issuer", typeof(FhirUri), true, false, false, false)]
public FhirUri Issuer {get; set;}
[Element("jurisdiction", typeof(FhirUri), true, false, false, false)]
public FhirUri Jurisdiction {get; set;}

        #endregion
        #region Constructor
        public  RegulatoryIdentifier() { }
        public  RegulatoryIdentifier(string value) : base(value) { }
        public  RegulatoryIdentifier(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RegulatoryIdentifier";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
