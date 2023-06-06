
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionTopicSub
{
    public class EventTrigger : BackboneElement<EventTrigger>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("event", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Event {get; set;}
[Element("resource", typeof(FhirUri), true, false, false, false)]
public FhirUri Resource {get; set;}

        #endregion
        #region Constructor
        public  EventTrigger() { }
        public  EventTrigger(string value) : base(value) { }
        public  EventTrigger(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "EventTrigger";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
