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
    public class DocumentReference : ResourceType<DocumentReference>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirString? _version;
private List<ReferenceType>? _basedOn;
private FhirCode? _status;
private FhirCode? _docStatus;
private List<CodeableConcept>? _modality;
private CodeableConcept? _type;
private List<CodeableConcept>? _category;
private ReferenceType? _subject;
private List<ReferenceType>? _context;
private List<CodeableReference>? _event;
private List<CodeableReference>? _bodySite;
private CodeableConcept? _facilityType;
private CodeableConcept? _practiceSetting;
private Period? _period;
private FhirInstant? _date;
private List<ReferenceType>? _author;
private List<DocumentReferenceAttester>? _attester;
private ReferenceType? _custodian;
private List<DocumentReferenceRelatesTo>? _relatesTo;
private FhirMarkdown? _description;
private List<CodeableConcept>? _securityLabel;
private List<DocumentReferenceContent>? _content;

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

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirCode? DocStatus
{
get { return _docStatus; }
set {
_docStatus= value;
OnPropertyChanged("docStatus", value);
}
}

public List<CodeableConcept>? Modality
{
get { return _modality; }
set {
_modality= value;
OnPropertyChanged("modality", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public List<ReferenceType>? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public List<CodeableReference>? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public List<CodeableReference>? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public CodeableConcept? FacilityType
{
get { return _facilityType; }
set {
_facilityType= value;
OnPropertyChanged("facilityType", value);
}
}

public CodeableConcept? PracticeSetting
{
get { return _practiceSetting; }
set {
_practiceSetting= value;
OnPropertyChanged("practiceSetting", value);
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

public FhirInstant? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public List<ReferenceType>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<DocumentReferenceAttester>? Attester
{
get { return _attester; }
set {
_attester= value;
OnPropertyChanged("attester", value);
}
}

public ReferenceType? Custodian
{
get { return _custodian; }
set {
_custodian= value;
OnPropertyChanged("custodian", value);
}
}

public List<DocumentReferenceRelatesTo>? RelatesTo
{
get { return _relatesTo; }
set {
_relatesTo= value;
OnPropertyChanged("relatesTo", value);
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

public List<CodeableConcept>? SecurityLabel
{
get { return _securityLabel; }
set {
_securityLabel= value;
OnPropertyChanged("securityLabel", value);
}
}

public List<DocumentReferenceContent>? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}


		#endregion
		#region Constructor
		public  DocumentReference() { }
		public  DocumentReference(string value) : base(value) { }
		public  DocumentReference(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DocumentReferenceAttester : BackboneElementType<DocumentReferenceAttester>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _mode;
private FhirDateTime? _time;
private ReferenceType? _party;

		#endregion
		#region public Method
		public CodeableConcept? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
}
}

public FhirDateTime? Time
{
get { return _time; }
set {
_time= value;
OnPropertyChanged("time", value);
}
}

public ReferenceType? Party
{
get { return _party; }
set {
_party= value;
OnPropertyChanged("party", value);
}
}


		#endregion
		#region Constructor
		public  DocumentReferenceAttester() { }
		public  DocumentReferenceAttester(string value) : base(value) { }
		public  DocumentReferenceAttester(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DocumentReferenceRelatesTo : BackboneElementType<DocumentReferenceRelatesTo>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private ReferenceType? _target;

		#endregion
		#region public Method
		public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
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


		#endregion
		#region Constructor
		public  DocumentReferenceRelatesTo() { }
		public  DocumentReferenceRelatesTo(string value) : base(value) { }
		public  DocumentReferenceRelatesTo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DocumentReferenceContentProfile : BackboneElementType<DocumentReferenceContentProfile>, IBackboneElementType
	{

		#region Private Method
		private DocumentReferenceContentProfileValueChoice? _value;

		#endregion
		#region public Method
		public DocumentReferenceContentProfileValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  DocumentReferenceContentProfile() { }
		public  DocumentReferenceContentProfile(string value) : base(value) { }
		public  DocumentReferenceContentProfile(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DocumentReferenceContent : BackboneElementType<DocumentReferenceContent>, IBackboneElementType
	{

		#region Private Method
		private Attachment? _attachment;
private List<DocumentReferenceContentProfile>? _profile;

		#endregion
		#region public Method
		public Attachment? Attachment
{
get { return _attachment; }
set {
_attachment= value;
OnPropertyChanged("attachment", value);
}
}

public List<DocumentReferenceContentProfile>? Profile
{
get { return _profile; }
set {
_profile= value;
OnPropertyChanged("profile", value);
}
}


		#endregion
		#region Constructor
		public  DocumentReferenceContent() { }
		public  DocumentReferenceContent(string value) : base(value) { }
		public  DocumentReferenceContent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DocumentReferenceContentProfileValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Coding","uricanonical"
        ];

        public DocumentReferenceContentProfileValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public DocumentReferenceContentProfileValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public DocumentReferenceContentProfileValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
