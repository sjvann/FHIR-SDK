using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;

namespace ResourceTypeServices.R5
{
    public class SubscriptionStatus : ResourceType<SubscriptionStatus>
	{
		#region private Property
		private FhirCode? _status;
private FhirCode? _type;
private FhirInteger64? _eventsSinceSubscriptionStart;
private List<SubscriptionStatusNotificationEvent>? _notificationEvent;
private ReferenceType? _subscription;
private FhirCanonical? _topic;
private List<CodeableConcept>? _error;

		#endregion
		#region Public Method
		public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirInteger64? EventsSinceSubscriptionStart
{
get { return _eventsSinceSubscriptionStart; }
set {
_eventsSinceSubscriptionStart= value;
OnPropertyChanged("eventsSinceSubscriptionStart", value);
}
}

public List<SubscriptionStatusNotificationEvent>? NotificationEvent
{
get { return _notificationEvent; }
set {
_notificationEvent= value;
OnPropertyChanged("notificationEvent", value);
}
}

public ReferenceType? Subscription
{
get { return _subscription; }
set {
_subscription= value;
OnPropertyChanged("subscription", value);
}
}

public FhirCanonical? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
}
}

public List<CodeableConcept>? Error
{
get { return _error; }
set {
_error= value;
OnPropertyChanged("error", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionStatus() { }
		public  SubscriptionStatus(string value) : base(value) { }
		public  SubscriptionStatus(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubscriptionStatusNotificationEvent : BackboneElementType<SubscriptionStatusNotificationEvent>, IBackboneElementType
	{

		#region Private Method
		private FhirInteger64? _eventNumber;
private FhirInstant? _timestamp;
private ReferenceType? _focus;
private List<ReferenceType>? _additionalContext;

		#endregion
		#region public Method
		public FhirInteger64? EventNumber
{
get { return _eventNumber; }
set {
_eventNumber= value;
OnPropertyChanged("eventNumber", value);
}
}

public FhirInstant? Timestamp
{
get { return _timestamp; }
set {
_timestamp= value;
OnPropertyChanged("timestamp", value);
}
}

public ReferenceType? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public List<ReferenceType>? AdditionalContext
{
get { return _additionalContext; }
set {
_additionalContext= value;
OnPropertyChanged("additionalContext", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionStatusNotificationEvent() { }
		public  SubscriptionStatusNotificationEvent(string value) : base(value) { }
		public  SubscriptionStatusNotificationEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
