
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.ContractSub
{
    public class Friendly : BackboneElement<Friendly>
    {

        #region Property
        [Element("content", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Content {get; set;}

        #endregion
        #region Constructor
        public  Friendly() { }
        public  Friendly(string value) : base(value) { }
        public  Friendly(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Friendly";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
