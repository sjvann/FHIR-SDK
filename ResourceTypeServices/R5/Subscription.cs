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
    public class Subscription : ResourceType<Subscription>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirString? _name;
private FhirCode? _status;
private FhirCanonical? _topic;
private List<ContactPoint>? _contact;
private FhirInstant? _end;
private ReferenceType? _managingEntity;
private FhirString? _reason;
private List<SubscriptionFilterBy>? _filterBy;
private Coding? _channelType;
private FhirUrl? _endpoint;
private List<SubscriptionParameter>? _parameter;
private FhirUnsignedInt? _heartbeatPeriod;
private FhirUnsignedInt? _timeout;
private FhirCode? _contentType;
private FhirCode? _content;
private FhirPositiveInt? _maxCount;

		#endregion
		#region Public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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

public List<ContactPoint>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public FhirInstant? End
{
get { return _end; }
set {
_end= value;
OnPropertyChanged("end", value);
}
}

public ReferenceType? ManagingEntity
{
get { return _managingEntity; }
set {
_managingEntity= value;
OnPropertyChanged("managingEntity", value);
}
}

public FhirString? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<SubscriptionFilterBy>? FilterBy
{
get { return _filterBy; }
set {
_filterBy= value;
OnPropertyChanged("filterBy", value);
}
}

public Coding? ChannelType
{
get { return _channelType; }
set {
_channelType= value;
OnPropertyChanged("channelType", value);
}
}

public FhirUrl? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
}
}

public List<SubscriptionParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}

public FhirUnsignedInt? HeartbeatPeriod
{
get { return _heartbeatPeriod; }
set {
_heartbeatPeriod= value;
OnPropertyChanged("heartbeatPeriod", value);
}
}

public FhirUnsignedInt? Timeout
{
get { return _timeout; }
set {
_timeout= value;
OnPropertyChanged("timeout", value);
}
}

public FhirCode? ContentType
{
get { return _contentType; }
set {
_contentType= value;
OnPropertyChanged("contentType", value);
}
}

public FhirCode? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}

public FhirPositiveInt? MaxCount
{
get { return _maxCount; }
set {
_maxCount= value;
OnPropertyChanged("maxCount", value);
}
}


		#endregion
		#region Constructor
		public  Subscription() { }
		public  Subscription(string value) : base(value) { }
		public  Subscription(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubscriptionFilterBy : BackboneElementType<SubscriptionFilterBy>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _resourceType;
private FhirString? _filterParameter;
private FhirCode? _comparator;
private FhirCode? _modifier;
private FhirString? _value;

		#endregion
		#region public Method
		public FhirUri? ResourceType
{
get { return _resourceType; }
set {
_resourceType= value;
OnPropertyChanged("resourceType", value);
}
}

public FhirString? FilterParameter
{
get { return _filterParameter; }
set {
_filterParameter= value;
OnPropertyChanged("filterParameter", value);
}
}

public FhirCode? Comparator
{
get { return _comparator; }
set {
_comparator= value;
OnPropertyChanged("comparator", value);
}
}

public FhirCode? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
}
}

public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionFilterBy() { }
		public  SubscriptionFilterBy(string value) : base(value) { }
		public  SubscriptionFilterBy(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubscriptionParameter : BackboneElementType<SubscriptionParameter>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private FhirString? _value;

		#endregion
		#region public Method
		public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionParameter() { }
		public  SubscriptionParameter(string value) : base(value) { }
		public  SubscriptionParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
