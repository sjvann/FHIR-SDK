using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class SubscriptionTopic : ResourceType<SubscriptionTopic>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private SubscriptionTopicVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private List<FhirCanonical>? _derivedFrom;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<SubscriptionTopicResourceTrigger>? _resourceTrigger;
private List<SubscriptionTopicEventTrigger>? _eventTrigger;
private List<SubscriptionTopicCanFilterBy>? _canFilterBy;
private List<SubscriptionTopicNotificationShape>? _notificationShape;

		#endregion
		#region Public Method
		public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public SubscriptionTopicVersionAlgorithmChoice? VersionAlgorithm
{
get { return _versionAlgorithm; }
set {
_versionAlgorithm= value;
OnPropertyChanged("versionAlgorithm", value);
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

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public List<FhirCanonical>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
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

public FhirBoolean? Experimental
{
get { return _experimental; }
set {
_experimental= value;
OnPropertyChanged("experimental", value);
}
}

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public FhirString? Publisher
{
get { return _publisher; }
set {
_publisher= value;
OnPropertyChanged("publisher", value);
}
}

public List<ContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<UsageContext>? UseContext
{
get { return _useContext; }
set {
_useContext= value;
OnPropertyChanged("useContext", value);
}
}

public List<CodeableConcept>? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public FhirMarkdown? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}

public FhirMarkdown? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
}
}

public FhirString? CopyrightLabel
{
get { return _copyrightLabel; }
set {
_copyrightLabel= value;
OnPropertyChanged("copyrightLabel", value);
}
}

public FhirDate? ApprovalDate
{
get { return _approvalDate; }
set {
_approvalDate= value;
OnPropertyChanged("approvalDate", value);
}
}

public FhirDate? LastReviewDate
{
get { return _lastReviewDate; }
set {
_lastReviewDate= value;
OnPropertyChanged("lastReviewDate", value);
}
}

public Period? EffectivePeriod
{
get { return _effectivePeriod; }
set {
_effectivePeriod= value;
OnPropertyChanged("effectivePeriod", value);
}
}

public List<SubscriptionTopicResourceTrigger>? ResourceTrigger
{
get { return _resourceTrigger; }
set {
_resourceTrigger= value;
OnPropertyChanged("resourceTrigger", value);
}
}

public List<SubscriptionTopicEventTrigger>? EventTrigger
{
get { return _eventTrigger; }
set {
_eventTrigger= value;
OnPropertyChanged("eventTrigger", value);
}
}

public List<SubscriptionTopicCanFilterBy>? CanFilterBy
{
get { return _canFilterBy; }
set {
_canFilterBy= value;
OnPropertyChanged("canFilterBy", value);
}
}

public List<SubscriptionTopicNotificationShape>? NotificationShape
{
get { return _notificationShape; }
set {
_notificationShape= value;
OnPropertyChanged("notificationShape", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionTopic() { }
		public  SubscriptionTopic(string value) : base(value) { }
		public  SubscriptionTopic(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubscriptionTopicResourceTriggerQueryCriteria : BackboneElementType<SubscriptionTopicResourceTriggerQueryCriteria>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _previous;
private FhirCode? _resultForCreate;
private FhirString? _current;
private FhirCode? _resultForDelete;
private FhirBoolean? _requireBoth;

		#endregion
		#region public Method
		public FhirString? Previous
{
get { return _previous; }
set {
_previous= value;
OnPropertyChanged("previous", value);
}
}

public FhirCode? ResultForCreate
{
get { return _resultForCreate; }
set {
_resultForCreate= value;
OnPropertyChanged("resultForCreate", value);
}
}

public FhirString? Current
{
get { return _current; }
set {
_current= value;
OnPropertyChanged("current", value);
}
}

public FhirCode? ResultForDelete
{
get { return _resultForDelete; }
set {
_resultForDelete= value;
OnPropertyChanged("resultForDelete", value);
}
}

public FhirBoolean? RequireBoth
{
get { return _requireBoth; }
set {
_requireBoth= value;
OnPropertyChanged("requireBoth", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionTopicResourceTriggerQueryCriteria() { }
		public  SubscriptionTopicResourceTriggerQueryCriteria(string value) : base(value) { }
		public  SubscriptionTopicResourceTriggerQueryCriteria(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubscriptionTopicResourceTrigger : BackboneElementType<SubscriptionTopicResourceTrigger>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private FhirUri? _resource;
private List<FhirCode>? _supportedInteraction;
private SubscriptionTopicResourceTriggerQueryCriteria? _queryCriteria;
private FhirString? _fhirPathCriteria;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirUri? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public List<FhirCode>? SupportedInteraction
{
get { return _supportedInteraction; }
set {
_supportedInteraction= value;
OnPropertyChanged("supportedInteraction", value);
}
}

public SubscriptionTopicResourceTriggerQueryCriteria? QueryCriteria
{
get { return _queryCriteria; }
set {
_queryCriteria= value;
OnPropertyChanged("queryCriteria", value);
}
}

public FhirString? FhirPathCriteria
{
get { return _fhirPathCriteria; }
set {
_fhirPathCriteria= value;
OnPropertyChanged("fhirPathCriteria", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionTopicResourceTrigger() { }
		public  SubscriptionTopicResourceTrigger(string value) : base(value) { }
		public  SubscriptionTopicResourceTrigger(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubscriptionTopicEventTrigger : BackboneElementType<SubscriptionTopicEventTrigger>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private CodeableConcept? _event;
private FhirUri? _resource;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public CodeableConcept? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public FhirUri? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionTopicEventTrigger() { }
		public  SubscriptionTopicEventTrigger(string value) : base(value) { }
		public  SubscriptionTopicEventTrigger(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubscriptionTopicCanFilterBy : BackboneElementType<SubscriptionTopicCanFilterBy>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private FhirUri? _resource;
private FhirString? _filterParameter;
private FhirUri? _filterDefinition;
private List<FhirCode>? _comparator;
private List<FhirCode>? _modifier;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirUri? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
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

public FhirUri? FilterDefinition
{
get { return _filterDefinition; }
set {
_filterDefinition= value;
OnPropertyChanged("filterDefinition", value);
}
}

public List<FhirCode>? Comparator
{
get { return _comparator; }
set {
_comparator= value;
OnPropertyChanged("comparator", value);
}
}

public List<FhirCode>? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionTopicCanFilterBy() { }
		public  SubscriptionTopicCanFilterBy(string value) : base(value) { }
		public  SubscriptionTopicCanFilterBy(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubscriptionTopicNotificationShape : BackboneElementType<SubscriptionTopicNotificationShape>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _resource;
private List<FhirString>? _include;
private List<FhirString>? _revInclude;

		#endregion
		#region public Method
		public FhirUri? Resource
{
get { return _resource; }
set {
_resource= value;
OnPropertyChanged("resource", value);
}
}

public List<FhirString>? Include
{
get { return _include; }
set {
_include= value;
OnPropertyChanged("include", value);
}
}

public List<FhirString>? RevInclude
{
get { return _revInclude; }
set {
_revInclude= value;
OnPropertyChanged("revInclude", value);
}
}


		#endregion
		#region Constructor
		public  SubscriptionTopicNotificationShape() { }
		public  SubscriptionTopicNotificationShape(string value) : base(value) { }
		public  SubscriptionTopicNotificationShape(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SubscriptionTopicVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public SubscriptionTopicVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public SubscriptionTopicVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public SubscriptionTopicVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
