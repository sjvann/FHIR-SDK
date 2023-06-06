
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TestPlanSub.TestCaseSub.TestRunSub;

namespace ResourceTypeServices.R5.TestPlanSub.TestCaseSub
{
    public class TestRun : BackboneElement<TestRun>
    {

        #region Property
        [Element("narrative", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Narrative {get; set;}
[Element("script", typeof(Script), false, false, false, true)]
public Script Script {get; set;}

        #endregion
        #region Constructor
        public  TestRun() { }
        public  TestRun(string value) : base(value) { }
        public  TestRun(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TestRun";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
