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
    public class MessageHeader : ResourceType<MessageHeader>
	{
		#region private Property
		private MessageHeaderEventChoice? _event;
private List<MessageHeaderDestination>? _destination;
private ReferenceType? _sender;
private ReferenceType? _author;
private MessageHeaderSource? _source;
private ReferenceType? _responsible;
private CodeableConcept? _reason;
private MessageHeaderResponse? _response;
private List<ReferenceType>? _focus;
private FhirCanonical? _definition;

		#endregion
		#region Public Method
		public MessageHeaderEventChoice? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public List<MessageHeaderDestination>? Destination
{
get { return _destination; }
set {
_destination= value;
OnPropertyChanged("destination", value);
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

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public MessageHeaderSource? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public ReferenceType? Responsible
{
get { return _responsible; }
set {
_responsible= value;
OnPropertyChanged("responsible", value);
}
}

public CodeableConcept? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public MessageHeaderResponse? Response
{
get { return _response; }
set {
_response= value;
OnPropertyChanged("response", value);
}
}

public List<ReferenceType>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public FhirCanonical? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}


		#endregion
		#region Constructor
		public  MessageHeader() { }
		public  MessageHeader(string value) : base(value) { }
		public  MessageHeader(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MessageHeaderDestination : BackboneElementType<MessageHeaderDestination>, IBackboneElementType
	{

		#region Private Method
		private MessageHeaderDestinationEndpointChoice? _endpoint;
private FhirString? _name;
private ReferenceType? _target;
private ReferenceType? _receiver;

		#endregion
		#region public Method
		public MessageHeaderDestinationEndpointChoice? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
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

public ReferenceType? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public ReferenceType? Receiver
{
get { return _receiver; }
set {
_receiver= value;
OnPropertyChanged("receiver", value);
}
}


		#endregion
		#region Constructor
		public  MessageHeaderDestination() { }
		public  MessageHeaderDestination(string value) : base(value) { }
		public  MessageHeaderDestination(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MessageHeaderSource : BackboneElementType<MessageHeaderSource>, IBackboneElementType
	{

		#region Private Method
		private MessageHeaderSourceEndpointChoice? _endpoint;
private FhirString? _name;
private FhirString? _software;
private FhirString? _version;
private ContactPoint? _contact;

		#endregion
		#region public Method
		public MessageHeaderSourceEndpointChoice? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
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

public FhirString? Software
{
get { return _software; }
set {
_software= value;
OnPropertyChanged("software", value);
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

public ContactPoint? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}


		#endregion
		#region Constructor
		public  MessageHeaderSource() { }
		public  MessageHeaderSource(string value) : base(value) { }
		public  MessageHeaderSource(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MessageHeaderResponse : BackboneElementType<MessageHeaderResponse>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _identifier;
private FhirCode? _code;
private ReferenceType? _details;

		#endregion
		#region public Method
		public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirCode? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public ReferenceType? Details
{
get { return _details; }
set {
_details= value;
OnPropertyChanged("details", value);
}
}


		#endregion
		#region Constructor
		public  MessageHeaderResponse() { }
		public  MessageHeaderResponse(string value) : base(value) { }
		public  MessageHeaderResponse(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MessageHeaderEventChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Coding","canonical(EventDefinition)"
        ];

        public MessageHeaderEventChoice(JsonObject value) : base("event", value, _supportType)
        {
        }
        public MessageHeaderEventChoice(IComplexType? value) : base("event", value)
        {
        }
        public MessageHeaderEventChoice(IPrimitiveType? value) : base("event", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"event".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MessageHeaderDestinationEndpointChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "url","Reference(Endpoint)"
        ];

        public MessageHeaderDestinationEndpointChoice(JsonObject value) : base("endpoint", value, _supportType)
        {
        }
        public MessageHeaderDestinationEndpointChoice(IComplexType? value) : base("endpoint", value)
        {
        }
        public MessageHeaderDestinationEndpointChoice(IPrimitiveType? value) : base("endpoint", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"endpoint".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MessageHeaderSourceEndpointChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "url","Reference(Endpoint)"
        ];

        public MessageHeaderSourceEndpointChoice(JsonObject value) : base("endpoint", value, _supportType)
        {
        }
        public MessageHeaderSourceEndpointChoice(IComplexType? value) : base("endpoint", value)
        {
        }
        public MessageHeaderSourceEndpointChoice(IPrimitiveType? value) : base("endpoint", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"endpoint".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
