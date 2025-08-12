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
    public class MessageDefinition : ResourceType<MessageDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private MessageDefinitionVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private List<FhirCanonical>? _replaces;
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
private FhirCanonical? _base;
private List<FhirCanonical>? _parent;
private MessageDefinitionEventChoice? _event;
private FhirCode? _category;
private List<MessageDefinitionFocus>? _focus;
private FhirCode? _responseRequired;
private List<MessageDefinitionAllowedResponse>? _allowedResponse;
private FhirCanonical? _graph;

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

public MessageDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public List<FhirCanonical>? Replaces
{
get { return _replaces; }
set {
_replaces= value;
OnPropertyChanged("replaces", value);
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

public FhirCanonical? Base
{
get { return _base; }
set {
_base= value;
OnPropertyChanged("base", value);
}
}

public List<FhirCanonical>? Parent
{
get { return _parent; }
set {
_parent= value;
OnPropertyChanged("parent", value);
}
}

public MessageDefinitionEventChoice? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public FhirCode? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public List<MessageDefinitionFocus>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public FhirCode? ResponseRequired
{
get { return _responseRequired; }
set {
_responseRequired= value;
OnPropertyChanged("responseRequired", value);
}
}

public List<MessageDefinitionAllowedResponse>? AllowedResponse
{
get { return _allowedResponse; }
set {
_allowedResponse= value;
OnPropertyChanged("allowedResponse", value);
}
}

public FhirCanonical? Graph
{
get { return _graph; }
set {
_graph= value;
OnPropertyChanged("graph", value);
}
}


		#endregion
		#region Constructor
		public  MessageDefinition() { }
		public  MessageDefinition(string value) : base(value) { }
		public  MessageDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MessageDefinitionFocus : BackboneElementType<MessageDefinitionFocus>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirCanonical? _profile;
private FhirUnsignedInt? _min;
private FhirString? _max;

		#endregion
		#region public Method
		public FhirCode? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirCanonical? Profile
{
get { return _profile; }
set {
_profile= value;
OnPropertyChanged("profile", value);
}
}

public FhirUnsignedInt? Min
{
get { return _min; }
set {
_min= value;
OnPropertyChanged("min", value);
}
}

public FhirString? Max
{
get { return _max; }
set {
_max= value;
OnPropertyChanged("max", value);
}
}


		#endregion
		#region Constructor
		public  MessageDefinitionFocus() { }
		public  MessageDefinitionFocus(string value) : base(value) { }
		public  MessageDefinitionFocus(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MessageDefinitionAllowedResponse : BackboneElementType<MessageDefinitionAllowedResponse>, IBackboneElementType
	{

		#region Private Method
		private FhirCanonical? _message;
private FhirMarkdown? _situation;

		#endregion
		#region public Method
		public FhirCanonical? Message
{
get { return _message; }
set {
_message= value;
OnPropertyChanged("message", value);
}
}

public FhirMarkdown? Situation
{
get { return _situation; }
set {
_situation= value;
OnPropertyChanged("situation", value);
}
}


		#endregion
		#region Constructor
		public  MessageDefinitionAllowedResponse() { }
		public  MessageDefinitionAllowedResponse(string value) : base(value) { }
		public  MessageDefinitionAllowedResponse(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MessageDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public MessageDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public MessageDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public MessageDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MessageDefinitionEventChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Coding","uri"
        ];

        public MessageDefinitionEventChoice(JsonObject value) : base("event", value, _supportType)
        {
        }
        public MessageDefinitionEventChoice(IComplexType? value) : base("event", value)
        {
        }
        public MessageDefinitionEventChoice(IPrimitiveType? value) : base("event", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"event".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
