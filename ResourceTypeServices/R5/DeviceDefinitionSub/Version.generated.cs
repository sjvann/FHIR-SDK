
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class Version : BackboneElement<Version>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("component", typeof(Identifier), false, false, false, false)]
public Identifier Component {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  Version() { }
        public  Version(string value) : base(value) { }
        public  Version(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Version";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
