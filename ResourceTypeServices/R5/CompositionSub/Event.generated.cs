
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CompositionSub
{
    public class Event : BackboneElement<Event>
    {

        #region Property
        [Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("detail", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Detail {get; set;}

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
