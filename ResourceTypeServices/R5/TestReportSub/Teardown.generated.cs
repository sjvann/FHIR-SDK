
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using ResourceTypeServices.R5.TestReportSub.TeardownSub;

namespace ResourceTypeServices.R5.TestReportSub
{
    public class Teardown : BackboneElement<Teardown>
    {

        #region Property
        [Element("action", typeof(ResourceTypeServices.R5.TestReportSub.TeardownSub.Action), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.TestReportSub.TeardownSub.Action> Action {get; set;}

        #endregion
        #region Constructor
        public  Teardown() { }
        public  Teardown(string value) : base(value) { }
        public  Teardown(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Teardown";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
