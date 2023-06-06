
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ExampleScenarioSub.ProcessSub.StepSub
{
    public class Alternative : BackboneElement<Alternative>
    {

        #region Property
        [Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}

        #endregion
        #region Constructor
        public  Alternative() { }
        public  Alternative(string value) : base(value) { }
        public  Alternative(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Alternative";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
