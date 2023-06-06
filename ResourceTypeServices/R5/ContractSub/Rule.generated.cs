
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.ContractSub
{
    public class Rule : BackboneElement<Rule>
    {

        #region Property
        [Element("content", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Content {get; set;}

        #endregion
        #region Constructor
        public  Rule() { }
        public  Rule(string value) : base(value) { }
        public  Rule(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Rule";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
