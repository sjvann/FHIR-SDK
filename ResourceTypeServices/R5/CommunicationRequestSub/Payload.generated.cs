
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.CommunicationRequestSub
{
    public class Payload : BackboneElement<Payload>
    {

        #region Property
        [Element("content", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Content {get; set;}

        #endregion
        #region Constructor
        public  Payload() { }
        public  Payload(string value) : base(value) { }
        public  Payload(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Payload";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
