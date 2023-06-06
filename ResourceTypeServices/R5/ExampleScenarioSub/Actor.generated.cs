
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExampleScenarioSub
{
    public class Actor : BackboneElement<Actor>
    {

        #region Property
        [Element("key", typeof(FhirString), true, false, false, false)]
public FhirString Key {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}

        #endregion
        #region Constructor
        public  Actor() { }
        public  Actor(string value) : base(value) { }
        public  Actor(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Actor";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
