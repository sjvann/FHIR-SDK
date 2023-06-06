
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestReportSub.SetupSub.ActionSub
{
    public class Operation : BackboneElement<Operation>
    {

        #region Property
        [Element("result", typeof(FhirCode), true, false, false, false)]
public FhirCode Result {get; set;}
[Element("message", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Message {get; set;}
[Element("detail", typeof(FhirUri), true, false, false, false)]
public FhirUri Detail {get; set;}

        #endregion
        #region Constructor
        public  Operation() { }
        public  Operation(string value) : base(value) { }
        public  Operation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Operation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
