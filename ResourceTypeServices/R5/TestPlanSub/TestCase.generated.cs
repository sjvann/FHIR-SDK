
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TestPlanSub.TestCaseSub;

namespace ResourceTypeServices.R5.TestPlanSub
{
    public class TestCase : BackboneElement<TestCase>
    {

        #region Property
        [Element("sequence", typeof(FhirInteger), true, false, false, false)]
public FhirInteger Sequence {get; set;}
[Element("scope", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Scope {get; set;}
[Element("dependency", typeof(Dependency), false, true, false, true)]
public IEnumerable<Dependency> Dependency {get; set;}
[Element("testRun", typeof(TestRun), false, true, false, true)]
public IEnumerable<TestRun> TestRun {get; set;}
[Element("testData", typeof(TestData), false, true, false, true)]
public IEnumerable<TestData> TestData {get; set;}
[Element("assertion", typeof(Assertion), false, true, false, true)]
public IEnumerable<Assertion> Assertion {get; set;}

        #endregion
        #region Constructor
        public  TestCase() { }
        public  TestCase(string value) : base(value) { }
        public  TestCase(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TestCase";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
