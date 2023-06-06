

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.OperationOutcomeSub
{
    public class OperationOutcome : DomainResource<OperationOutcome>
    {
        #region Property
        [Element("issue", typeof(Issue), false, true, false, true)]
public IEnumerable<Issue> Issue {get; set;}

        #endregion
        #region Constructor
        public  OperationOutcome() { }

        public  OperationOutcome(string value) : base(value) { }
        public  OperationOutcome(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "OperationOutcome";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
