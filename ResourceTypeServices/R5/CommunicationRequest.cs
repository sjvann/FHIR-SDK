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
    public class CommunicationRequest : ResourceType<CommunicationRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _replaces;
private Identifier? _groupIdentifier;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private FhirCode? _intent;
private List<CodeableConcept>? _category;
private FhirCode? _priority;
private FhirBoolean? _doNotPerform;
private List<CodeableConcept>? _medium;
private ReferenceType? _subject;
private List<ReferenceType>? _about;
private ReferenceType? _encounter;
private List<CommunicationRequestPayload>? _payload;
private CommunicationRequestOccurrenceChoice? _occurrence;
private FhirDateTime? _authoredOn;
private ReferenceType? _requester;
private List<ReferenceType>? _recipient;
private List<ReferenceType>? _informationProvider;
private List<CodeableReference>? _reason;
private List<Annotation>? _note;

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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public List<ReferenceType>? Replaces
{
get { return _replaces; }
set {
_replaces= value;
OnPropertyChanged("replaces", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public List<CodeableConcept>? Medium
{
get { return _medium; }
set {
_medium= value;
OnPropertyChanged("medium", value);
}
}

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public List<ReferenceType>? About
{
get { return _about; }
set {
_about= value;
OnPropertyChanged("about", value);
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

public List<CommunicationRequestPayload>? Payload
{
get { return _payload; }
set {
_payload= value;
OnPropertyChanged("payload", value);
}
}

public CommunicationRequestOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
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

public ReferenceType? Requester
{
get { return _requester; }
set {
_requester= value;
OnPropertyChanged("requester", value);
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

public List<ReferenceType>? InformationProvider
{
get { return _informationProvider; }
set {
_informationProvider= value;
OnPropertyChanged("informationProvider", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}


		#endregion
		#region Constructor
		public  CommunicationRequest() { }
		public  CommunicationRequest(string value) : base(value) { }
		public  CommunicationRequest(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CommunicationRequestPayload : BackboneElementType<CommunicationRequestPayload>, IBackboneElementType
	{

		#region Private Method
		private CommunicationRequestPayloadContentChoice? _content;

		#endregion
		#region public Method
		public CommunicationRequestPayloadContentChoice? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  CommunicationRequestPayload() { }
		public  CommunicationRequestPayload(string value) : base(value) { }
		public  CommunicationRequestPayload(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CommunicationRequestPayloadContentChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Attachment","Reference(Resource)CodeableConcept"
        ];

        public CommunicationRequestPayloadContentChoice(JsonObject value) : base("content", value, _supportType)
        {
        }
        public CommunicationRequestPayloadContentChoice(IComplexType? value) : base("content", value)
        {
        }
        public CommunicationRequestPayloadContentChoice(IPrimitiveType? value) : base("content", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"content".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CommunicationRequestOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public CommunicationRequestOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public CommunicationRequestOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public CommunicationRequestOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
