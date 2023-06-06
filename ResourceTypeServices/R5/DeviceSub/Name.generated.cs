
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceSub
{
    public class Name : BackboneElement<Name>
    {

        #region Property
        [Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("display", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Display {get; set;}

        #endregion
        #region Constructor
        public  Name() { }
        public  Name(string value) : base(value) { }
        public  Name(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Name";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
