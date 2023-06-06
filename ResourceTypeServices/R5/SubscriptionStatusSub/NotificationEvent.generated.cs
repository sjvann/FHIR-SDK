
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionStatusSub
{
    public class NotificationEvent : BackboneElement<NotificationEvent>
    {

        #region Property
        [Element("eventNumber", typeof(FhirInteger64), true, false, false, false)]
public FhirInteger64 EventNumber {get; set;}
[Element("timestamp", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Timestamp {get; set;}
[Element("focus", typeof(Reference), false, false, false, false)]
public Reference Focus {get; set;}
[Element("additionalContext", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> AdditionalContext {get; set;}

        #endregion
        #region Constructor
        public  NotificationEvent() { }
        public  NotificationEvent(string value) : base(value) { }
        public  NotificationEvent(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "NotificationEvent";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
