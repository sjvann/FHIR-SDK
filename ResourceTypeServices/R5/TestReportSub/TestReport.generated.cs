

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestReportSub
{
    public class TestReport : DomainResource<TestReport>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, false, false, false)]
public Identifier Identifier {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("testScript", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical TestScript {get; set;}
[Element("result", typeof(FhirCode), true, false, false, false)]
public FhirCode Result {get; set;}
[Element("score", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Score {get; set;}
[Element("tester", typeof(FhirString), true, false, false, false)]
public FhirString Tester {get; set;}
[Element("issued", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Issued {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("setup", typeof(Setup), false, false, false, true)]
public Setup Setup {get; set;}
[Element("test", typeof(Test), false, true, false, true)]
public IEnumerable<Test> Test {get; set;}
[Element("teardown", typeof(Teardown), false, false, false, true)]
public Teardown Teardown {get; set;}

        #endregion
        #region Constructor
        public  TestReport() { }

        public  TestReport(string value) : base(value) { }
        public  TestReport(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "TestReport";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
