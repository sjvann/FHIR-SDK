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
    public class Transport : ResourceType<Transport>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCanonical? _instantiatesCanonical;
private FhirUri? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private Identifier? _groupIdentifier;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private FhirCode? _intent;
private FhirCode? _priority;
private CodeableConcept? _code;
private FhirString? _description;
private ReferenceType? _focus;
private ReferenceType? _for;
private ReferenceType? _encounter;
private FhirDateTime? _completionTime;
private FhirDateTime? _authoredOn;
private FhirDateTime? _lastModified;
private ReferenceType? _requester;
private List<CodeableConcept>? _performerType;
private ReferenceType? _owner;
private ReferenceType? _location;
private List<ReferenceType>? _insurance;
private List<Annotation>? _note;
private List<ReferenceType>? _relevantHistory;
private TransportRestriction? _restriction;
private List<TransportInput>? _input;
private List<TransportOutput>? _output;
private ReferenceType? _requestedLocation;
private ReferenceType? _currentLocation;
private CodeableReference? _reason;
private ReferenceType? _history;

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

public CodeableConcept? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public FhirDateTime? CompletionTime
{
get { return _completionTime; }
set {
_completionTime= value;
OnPropertyChanged("completionTime", value);
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

public List<CodeableConcept>? PerformerType
{
get { return _performerType; }
set {
_performerType= value;
OnPropertyChanged("performerType", value);
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

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
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

public TransportRestriction? Restriction
{
get { return _restriction; }
set {
_restriction= value;
OnPropertyChanged("restriction", value);
}
}

public List<TransportInput>? Input
{
get { return _input; }
set {
_input= value;
OnPropertyChanged("input", value);
}
}

public List<TransportOutput>? Output
{
get { return _output; }
set {
_output= value;
OnPropertyChanged("output", value);
}
}

public ReferenceType? RequestedLocation
{
get { return _requestedLocation; }
set {
_requestedLocation= value;
OnPropertyChanged("requestedLocation", value);
}
}

public ReferenceType? CurrentLocation
{
get { return _currentLocation; }
set {
_currentLocation= value;
OnPropertyChanged("currentLocation", value);
}
}

public CodeableReference? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public ReferenceType? History
{
get { return _history; }
set {
_history= value;
OnPropertyChanged("history", value);
}
}


		#endregion
		#region Constructor
		public  Transport() { }
		public  Transport(string value) : base(value) { }
		public  Transport(JsonNode? source) : base(source) { }
		#endregion
	}
		public class TransportRestriction : BackboneElementType<TransportRestriction>, IBackboneElementType
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
		public  TransportRestriction() { }
		public  TransportRestriction(string value) : base(value) { }
		public  TransportRestriction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TransportInput : BackboneElementType<TransportInput>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private TransportInputValueChoice? _value;

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

public TransportInputValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  TransportInput() { }
		public  TransportInput(string value) : base(value) { }
		public  TransportInput(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TransportOutput : BackboneElementType<TransportOutput>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private TransportOutputValueChoice? _value;

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

public TransportOutputValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  TransportOutput() { }
		public  TransportOutput(string value) : base(value) { }
		public  TransportOutput(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class TransportInputValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "base64Binary","booleancanonicalcodedatedateTimedecimalidinstantintegerinteger64markdownoidpositiveIntstringtimeunsignedInturiurluuidAddressAgeAnnotationAttachmentCodeableConceptCodeableReferenceCodingContactPointCountDistanceDurationHumanNameIdentifierMoney"
        ];

        public TransportInputValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public TransportInputValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public TransportInputValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class TransportOutputValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "base64Binary","booleancanonicalcodedatedateTimedecimalidinstantintegerinteger64markdownoidpositiveIntstringtimeunsignedInturiurluuidAddressAgeAnnotationAttachmentCodeableConceptCodeableReferenceCodingContactPointCountDistanceDurationHumanNameIdentifierMoney"
        ];

        public TransportOutputValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public TransportOutputValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public TransportOutputValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
