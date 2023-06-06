
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.ContractSub
{
    public class Legal : BackboneElement<Legal>
    {

        #region Property
        [Element("content", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Content {get; set;}

        #endregion
        #region Constructor
        public  Legal() { }
        public  Legal(string value) : base(value) { }
        public  Legal(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Legal";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
