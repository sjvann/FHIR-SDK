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
    public class Task : ResourceType<Task>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCanonical? _instantiatesCanonical;
private FhirUri? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private Identifier? _groupIdentifier;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private CodeableReference? _statusReason;
private CodeableConcept? _businessStatus;
private FhirCode? _intent;
private FhirCode? _priority;
private FhirBoolean? _doNotPerform;
private CodeableConcept? _code;
private FhirString? _description;
private ReferenceType? _focus;
private ReferenceType? _for;
private ReferenceType? _encounter;
private Period? _requestedPeriod;
private Period? _executionPeriod;
private FhirDateTime? _authoredOn;
private FhirDateTime? _lastModified;
private ReferenceType? _requester;
private List<CodeableReference>? _requestedPerformer;
private ReferenceType? _owner;
private List<TaskPerformer>? _performer;
private ReferenceType? _location;
private List<CodeableReference>? _reason;
private List<ReferenceType>? _insurance;
private List<Annotation>? _note;
private List<ReferenceType>? _relevantHistory;
private TaskRestriction? _restriction;
private List<TaskInput>? _input;
private List<TaskOutput>? _output;

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

public FhirCanonical? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public FhirUri? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
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

public Identifier? GroupIdentifier
{
get { return _groupIdentifier; }
set {
_groupIdentifier= value;
OnPropertyChanged("groupIdentifier", value);
}
}

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public CodeableReference? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
}
}

public CodeableConcept? BusinessStatus
{
get { return _businessStatus; }
set {
_businessStatus= value;
OnPropertyChanged("businessStatus", value);
}
}

public FhirCode? Intent
{
get { return _intent; }
set {
_intent= value;
OnPropertyChanged("intent", value);
}
}

public FhirCode? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public FhirBoolean? DoNotPerform
{
get { return _doNotPerform; }
set {
_doNotPerform= value;
OnPropertyChanged("doNotPerform", value);
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

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public ReferenceType? For
{
get { return _for; }
set {
_for= value;
OnPropertyChanged("for", value);
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

public Period? RequestedPeriod
{
get { return _requestedPeriod; }
set {
_requestedPeriod= value;
OnPropertyChanged("requestedPeriod", value);
}
}

public Period? ExecutionPeriod
{
get { return _executionPeriod; }
set {
_executionPeriod= value;
OnPropertyChanged("executionPeriod", value);
}
}

public FhirDateTime? AuthoredOn
{
get { return _authoredOn; }
set {
_authoredOn= value;
OnPropertyChanged("authoredOn", value);
}
}

public FhirDateTime? LastModified
{
get { return _lastModified; }
set {
_lastModified= value;
OnPropertyChanged("lastModified", value);
}
}

public ReferenceType? Requester
{
get { return _requester; }
set {
_requester= value;
OnPropertyChanged("requester", value);
}
}

public List<CodeableReference>? RequestedPerformer
{
get { return _requestedPerformer; }
set {
_requestedPerformer= value;
OnPropertyChanged("requestedPerformer", value);
}
}

public ReferenceType? Owner
{
get { return _owner; }
set {
_owner= value;
OnPropertyChanged("owner", value);
}
}

public List<TaskPerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
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

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<ReferenceType>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
}
}

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public List<ReferenceType>? RelevantHistory
{
get { return _relevantHistory; }
set {
_relevantHistory= value;
OnPropertyChanged("relevantHistory", value);
}
}

public TaskRestriction? Restriction
{
get { return _restriction; }
set {
_restriction= value;
OnPropertyChanged("restriction", value);
}
}

public List<TaskInput>? Input
{
get { return _input; }
set {
_input= value;
OnPropertyChanged("input", value);
}
}

public List<TaskOutput>? Output
{
get { return _output; }
set {
_output= value;
OnPropertyChanged("output", value);
}
}


		#endregion
		#region Constructor
		public  Task() { }
		public  Task(string value) : base(value) { }
		public  Task(JsonNode? source) : base(source) { }
		#endregion
	}
		public class TaskPerformer : BackboneElementType<TaskPerformer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private ReferenceType? _actor;

		#endregion
		#region public Method
		public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  TaskPerformer() { }
		public  TaskPerformer(string value) : base(value) { }
		public  TaskPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TaskRestriction : BackboneElementType<TaskRestriction>, IBackboneElementType
	{

		#region Private Method
		private FhirPositiveInt? _repetitions;
private Period? _period;
private List<ReferenceType>? _recipient;

		#endregion
		#region public Method
		public FhirPositiveInt? Repetitions
{
get { return _repetitions; }
set {
_repetitions= value;
OnPropertyChanged("repetitions", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public List<ReferenceType>? Recipient
{
get { return _recipient; }
set {
_recipient= value;
OnPropertyChanged("recipient", value);
}
}


		#endregion
		#region Constructor
		public  TaskRestriction() { }
		public  TaskRestriction(string value) : base(value) { }
		public  TaskRestriction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TaskInput : BackboneElementType<TaskInput>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private TaskInputValueChoice? _value;

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

public TaskInputValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  TaskInput() { }
		public  TaskInput(string value) : base(value) { }
		public  TaskInput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TaskOutput : BackboneElementType<TaskOutput>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private TaskOutputValueChoice? _value;

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

public TaskOutputValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  TaskOutput() { }
		public  TaskOutput(string value) : base(value) { }
		public  TaskOutput(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class TaskInputValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "base64Binary","booleancanonicalcodedatedateTimedecimalidinstantintegerinteger64markdownoidpositiveIntstringtimeunsignedInturiurluuidAddressAgeAnnotationAttachmentCodeableConceptCodeableReferenceCodingContactPointCountDistanceDurationHumanNameIdentifierMoney"
        ];

        public TaskInputValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public TaskInputValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public TaskInputValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class TaskOutputValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "base64Binary","booleancanonicalcodedatedateTimedecimalidinstantintegerinteger64markdownoidpositiveIntstringtimeunsignedInturiurluuidAddressAgeAnnotationAttachmentCodeableConceptCodeableReferenceCodingContactPointCountDistanceDurationHumanNameIdentifierMoney"
        ];

        public TaskOutputValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public TaskOutputValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public TaskOutputValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
