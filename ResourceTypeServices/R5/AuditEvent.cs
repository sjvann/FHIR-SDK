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
    public class AuditEvent : ResourceType<AuditEvent>
	{
		#region private Property
		private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private FhirCode? _action;
private FhirCode? _severity;
private AuditEventOccurredChoice? _occurred;
private FhirInstant? _recorded;
private AuditEventOutcome? _outcome;
private List<CodeableConcept>? _authorization;
private List<ReferenceType>? _basedOn;
private ReferenceType? _patient;
private ReferenceType? _encounter;
private List<AuditEventAgent>? _agent;
private AuditEventSource? _source;
private List<AuditEventEntity>? _entity;

		#endregion
		#region Public Method
		public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirCode? Action
{
get { return _action; }
set {
_action= value;
OnPropertyChanged("action", value);
}
}

public FhirCode? Severity
{
get { return _severity; }
set {
_severity= value;
OnPropertyChanged("severity", value);
}
}

public AuditEventOccurredChoice? Occurred
{
get { return _occurred; }
set {
_occurred= value;
OnPropertyChanged("occurred", value);
}
}

public FhirInstant? Recorded
{
get { return _recorded; }
set {
_recorded= value;
OnPropertyChanged("recorded", value);
}
}

public AuditEventOutcome? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public List<CodeableConcept>? Authorization
{
get { return _authorization; }
set {
_authorization= value;
OnPropertyChanged("authorization", value);
}
}

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
}
}

public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public List<AuditEventAgent>? Agent
{
get { return _agent; }
set {
_agent= value;
OnPropertyChanged("agent", value);
}
}

public AuditEventSource? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public List<AuditEventEntity>? Entity
{
get { return _entity; }
set {
_entity= value;
OnPropertyChanged("entity", value);
}
}


		#endregion
		#region Constructor
		public  AuditEvent() { }
		public  AuditEvent(string value) : base(value) { }
		public  AuditEvent(JsonNode? source) : base(source) { }
		#endregion
	}
		public class AuditEventOutcome : BackboneElementType<AuditEventOutcome>, IBackboneElementType
	{

		#region Private Method
		private Coding? _code;
private List<CodeableConcept>? _detail;

		#endregion
		#region public Method
		public Coding? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<CodeableConcept>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  AuditEventOutcome() { }
		public  AuditEventOutcome(string value) : base(value) { }
		public  AuditEventOutcome(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AuditEventAgent : BackboneElementType<AuditEventAgent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<CodeableConcept>? _role;
private ReferenceType? _who;
private FhirBoolean? _requestor;
private ReferenceType? _location;
private List<FhirUri>? _policy;
private AuditEventAgentNetworkChoice? _network;
private List<CodeableConcept>? _authorization;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<CodeableConcept>? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public ReferenceType? Who
{
get { return _who; }
set {
_who= value;
OnPropertyChanged("who", value);
}
}

public FhirBoolean? Requestor
{
get { return _requestor; }
set {
_requestor= value;
OnPropertyChanged("requestor", value);
}
}

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public List<FhirUri>? Policy
{
get { return _policy; }
set {
_policy= value;
OnPropertyChanged("policy", value);
}
}

public AuditEventAgentNetworkChoice? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public List<CodeableConcept>? Authorization
{
get { return _authorization; }
set {
_authorization= value;
OnPropertyChanged("authorization", value);
}
}


		#endregion
		#region Constructor
		public  AuditEventAgent() { }
		public  AuditEventAgent(string value) : base(value) { }
		public  AuditEventAgent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AuditEventSource : BackboneElementType<AuditEventSource>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _site;
private ReferenceType? _observer;
private List<CodeableConcept>? _type;

		#endregion
		#region public Method
		public ReferenceType? Site
{
get { return _site; }
set {
_site= value;
OnPropertyChanged("site", value);
}
}

public ReferenceType? Observer
{
get { return _observer; }
set {
_observer= value;
OnPropertyChanged("observer", value);
}
}

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}


		#endregion
		#region Constructor
		public  AuditEventSource() { }
		public  AuditEventSource(string value) : base(value) { }
		public  AuditEventSource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AuditEventEntityDetail : BackboneElementType<AuditEventEntityDetail>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private AuditEventEntityDetailValueChoice? _value;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public AuditEventEntityDetailValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  AuditEventEntityDetail() { }
		public  AuditEventEntityDetail(string value) : base(value) { }
		public  AuditEventEntityDetail(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AuditEventEntity : BackboneElementType<AuditEventEntity>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _what;
private CodeableConcept? _role;
private List<CodeableConcept>? _securityLabel;
private FhirBase64Binary? _query;
private List<AuditEventEntityDetail>? _detail;

		#endregion
		#region public Method
		public ReferenceType? What
{
get { return _what; }
set {
_what= value;
OnPropertyChanged("what", value);
}
}

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public List<CodeableConcept>? SecurityLabel
{
get { return _securityLabel; }
set {
_securityLabel= value;
OnPropertyChanged("securityLabel", value);
}
}

public FhirBase64Binary? Query
{
get { return _query; }
set {
_query= value;
OnPropertyChanged("query", value);
}
}

public List<AuditEventEntityDetail>? Detail
{
get { return _detail; }
set {
_detail= value;
OnPropertyChanged("detail", value);
}
}


		#endregion
		#region Constructor
		public  AuditEventEntity() { }
		public  AuditEventEntity(string value) : base(value) { }
		public  AuditEventEntity(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class AuditEventOccurredChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Period","dateTime"
        ];
        public AuditEventOccurredChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public AuditEventOccurredChoice(JsonObject value) : base("occurred", value, _supportType)
        {
        }
        public AuditEventOccurredChoice(IComplexType? value) : base("occurred", value)
        {
        }
        public AuditEventOccurredChoice(IPrimitiveType? value) : base("occurred", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurred".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AuditEventAgentNetworkChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Endpoint)","uristring"
        ];
         public AuditEventAgentNetworkChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public AuditEventAgentNetworkChoice(JsonObject value) : base("network", value, _supportType)
        {
        }
        public AuditEventAgentNetworkChoice(IComplexType? value) : base("network", value)
        {
        }
        public AuditEventAgentNetworkChoice(IPrimitiveType? value) : base("network", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"network".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class AuditEventEntityDetailValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","CodeableConceptstringbooleanintegerRangeRatiotimedateTimePeriodbase64Binary"
        ];

        public AuditEventEntityDetailValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public AuditEventEntityDetailValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public AuditEventEntityDetailValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
