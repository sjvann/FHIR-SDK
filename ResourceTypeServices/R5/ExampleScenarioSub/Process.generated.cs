
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ExampleScenarioSub.ProcessSub;

namespace ResourceTypeServices.R5.ExampleScenarioSub
{
    public class Process : BackboneElement<Process>
    {

        #region Property
        [Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("preConditions", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown PreConditions {get; set;}
[Element("postConditions", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown PostConditions {get; set;}
[Element("step", typeof(Step), false, true, false, true)]
public IEnumerable<Step> Step {get; set;}

        #endregion
        #region Constructor
        public  Process() { }
        public  Process(string value) : base(value) { }
        public  Process(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Process";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
