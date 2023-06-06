
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TestReportSub.SetupSub.ActionSub.AssertSub;

namespace ResourceTypeServices.R5.TestReportSub.SetupSub.ActionSub
{
    public class Assert : BackboneElement<Assert>
    {

        #region Property
        [Element("result", typeof(FhirCode), true, false, false, false)]
public FhirCode Result {get; set;}
[Element("message", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Message {get; set;}
[Element("detail", typeof(FhirString), true, false, false, false)]
public FhirString Detail {get; set;}
[Element("requirement", typeof(Requirement), false, true, false, true)]
public IEnumerable<Requirement> Requirement {get; set;}

        #endregion
        #region Constructor
        public  Assert() { }
        public  Assert(string value) : base(value) { }
        public  Assert(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Assert";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
