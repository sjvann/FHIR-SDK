
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Fixture : BackboneElement<Fixture>
    {

        #region Property
        [Element("autocreate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Autocreate {get; set;}
[Element("autodelete", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Autodelete {get; set;}
[Element("resource", typeof(Reference), false, false, false, false)]
public Reference Resource {get; set;}

        #endregion
        #region Constructor
        public  Fixture() { }
        public  Fixture(string value) : base(value) { }
        public  Fixture(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Fixture";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
