

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubscriptionStatusSub
{
    public class SubscriptionStatus : DomainResource<SubscriptionStatus>
    {
        #region Property
        [Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("eventsSinceSubscriptionStart", typeof(FhirInteger64), true, false, false, false)]
public FhirInteger64 EventsSinceSubscriptionStart {get; set;}
[Element("notificationEvent", typeof(NotificationEvent), false, true, false, true)]
public IEnumerable<NotificationEvent> NotificationEvent {get; set;}
[Element("subscription", typeof(Reference), false, false, false, false)]
public Reference Subscription {get; set;}
[Element("topic", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Topic {get; set;}
[Element("error", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Error {get; set;}

        #endregion
        #region Constructor
        public  SubscriptionStatus() { }

        public  SubscriptionStatus(string value) : base(value) { }
        public  SubscriptionStatus(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SubscriptionStatus";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
