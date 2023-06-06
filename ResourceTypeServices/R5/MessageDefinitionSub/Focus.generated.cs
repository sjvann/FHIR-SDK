
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MessageDefinitionSub
{
    public class Focus : BackboneElement<Focus>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("profile", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Profile {get; set;}
[Element("min", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Min {get; set;}
[Element("max", typeof(FhirString), true, false, false, false)]
public FhirString Max {get; set;}

        #endregion
        #region Constructor
        public  Focus() { }
        public  Focus(string value) : base(value) { }
        public  Focus(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Focus";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
