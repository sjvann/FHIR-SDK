
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExampleScenarioSub.InstanceSub
{
    public class Version : BackboneElement<Version>
    {

        #region Property
        [Element("key", typeof(FhirString), true, false, false, false)]
public FhirString Key {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("content", typeof(Reference), false, false, false, false)]
public Reference Content {get; set;}

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
