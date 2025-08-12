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
    public class Communication : ResourceType<Communication>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private List<ReferenceType>? _inResponseTo;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private List<CodeableConcept>? _category;
private FhirCode? _priority;
private List<CodeableConcept>? _medium;
private ReferenceType? _subject;
private CodeableConcept? _topic;
private List<ReferenceType>? _about;
private ReferenceType? _encounter;
private FhirDateTime? _sent;
private FhirDateTime? _received;
private List<ReferenceType>? _recipient;
private ReferenceType? _sender;
private List<CodeableReference>? _reason;
private List<CommunicationPayload>? _payload;
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

public List<FhirCanonical>? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public List<FhirUri>? InstantiatesUri
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

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
}
}

public List<ReferenceType>? InResponseTo
{
get { return _inResponseTo; }
set {
_inResponseTo= value;
OnPropertyChanged("inResponseTo", value);
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

public CodeableConcept? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
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

public FhirDateTime? Sent
{
get { return _sent; }
set {
_sent= value;
OnPropertyChanged("sent", value);
}
}

public FhirDateTime? Received
{
get { return _received; }
set {
_received= value;
OnPropertyChanged("received", value);
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

public ReferenceType? Sender
{
get { return _sender; }
set {
_sender= value;
OnPropertyChanged("sender", value);
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

public List<CommunicationPayload>? Payload
{
get { return _payload; }
set {
_payload= value;
OnPropertyChanged("payload", value);
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
		public  Communication() { }
		public  Communication(string value) : base(value) { }
		public  Communication(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CommunicationPayload : BackboneElementType<CommunicationPayload>, IBackboneElementType
	{

		#region Private Method
		private CommunicationPayloadContentChoice? _content;

		#endregion
		#region public Method
		public CommunicationPayloadContentChoice? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  CommunicationPayload() { }
		public  CommunicationPayload(string value) : base(value) { }
		public  CommunicationPayload(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CommunicationPayloadContentChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Attachment","Reference(Resource)CodeableConcept"
        ];

        public CommunicationPayloadContentChoice(JsonObject value) : base("content", value, _supportType)
        {
        }
        public CommunicationPayloadContentChoice(IComplexType? value) : base("content", value)
        {
        }
        public CommunicationPayloadContentChoice(IPrimitiveType? value) : base("content", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"content".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
