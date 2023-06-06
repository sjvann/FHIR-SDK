
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub.MetadataSub
{
    public class Capability : BackboneElement<Capability>
    {

        #region Property
        [Element("required", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Required {get; set;}
[Element("validated", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Validated {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("origin", typeof(FhirInteger), true, true, false, false)]
public IEnumerable<FhirInteger> Origin {get; set;}
[Element("destination", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Destination {get; set;}
[Element("link", typeof(FhirUri), true, true, false, false)]
public IEnumerable<FhirUri> Link {get; set;}
[Element("capabilities", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Capabilities {get; set;}

        #endregion
        #region Constructor
        public  Capability() { }
        public  Capability(string value) : base(value) { }
        public  Capability(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Capability";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
