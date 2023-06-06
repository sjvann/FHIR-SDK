
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ClaimResponseSub
{
    public class Event : BackboneElement<Event>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("when", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased When {get; set;}

        #endregion
        #region Constructor
        public  Event() { }
        public  Event(string value) : base(value) { }
        public  Event(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Event";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
