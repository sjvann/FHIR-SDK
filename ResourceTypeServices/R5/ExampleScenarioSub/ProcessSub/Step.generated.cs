
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ExampleScenarioSub.ProcessSub.StepSub;

namespace ResourceTypeServices.R5.ExampleScenarioSub.ProcessSub
{
    public class Step : BackboneElement<Step>
    {

        #region Property
        [Element("number", typeof(FhirString), true, false, false, false)]
public FhirString Number {get; set;}
[Element("workflow", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Workflow {get; set;}
[Element("operation", typeof(Operation), false, false, false, true)]
public Operation Operation {get; set;}
[Element("alternative", typeof(Alternative), false, true, false, true)]
public IEnumerable<Alternative> Alternative {get; set;}
[Element("pause", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Pause {get; set;}

        #endregion
        #region Constructor
        public  Step() { }
        public  Step(string value) : base(value) { }
        public  Step(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Step";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
