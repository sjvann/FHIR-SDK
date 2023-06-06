
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class DeviceName : BackboneElement<DeviceName>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}

        #endregion
        #region Constructor
        public  DeviceName() { }
        public  DeviceName(string value) : base(value) { }
        public  DeviceName(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "DeviceName";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
