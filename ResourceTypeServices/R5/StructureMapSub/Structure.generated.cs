
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureMapSub
{
    public class Structure : BackboneElement<Structure>
    {

        #region Property
        [Element("url", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Url {get; set;}
[Element("mode", typeof(FhirCode), true, false, false, false)]
public FhirCode Mode {get; set;}
[Element("alias", typeof(FhirString), true, false, false, false)]
public FhirString Alias {get; set;}
[Element("documentation", typeof(FhirString), true, false, false, false)]
public FhirString Documentation {get; set;}

        #endregion
        #region Constructor
        public  Structure() { }
        public  Structure(string value) : base(value) { }
        public  Structure(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Structure";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
