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
    public class NamingSystem : ResourceType<NamingSystem>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private NamingSystemVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirCode? _status;
private FhirCode? _kind;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirString? _responsible;
private CodeableConcept? _type;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<CodeableConcept>? _topic;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<RelatedArtifact>? _relatedArtifact;
private FhirString? _usage;
private List<NamingSystemUniqueId>? _uniqueId;

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

public NamingSystemVersionAlgorithmChoice? VersionAlgorithm
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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirCode? Kind
{
get { return _kind; }
set {
_kind= value;
OnPropertyChanged("kind", value);
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

public FhirString? Responsible
{
get { return _responsible; }
set {
_responsible= value;
OnPropertyChanged("responsible", value);
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

public List<CodeableConcept>? Topic
{
get { return _topic; }
set {
_topic= value;
OnPropertyChanged("topic", value);
}
}

public List<ContactDetail>? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<ContactDetail>? Editor
{
get { return _editor; }
set {
_editor= value;
OnPropertyChanged("editor", value);
}
}

public List<ContactDetail>? Reviewer
{
get { return _reviewer; }
set {
_reviewer= value;
OnPropertyChanged("reviewer", value);
}
}

public List<ContactDetail>? Endorser
{
get { return _endorser; }
set {
_endorser= value;
OnPropertyChanged("endorser", value);
}
}

public List<RelatedArtifact>? RelatedArtifact
{
get { return _relatedArtifact; }
set {
_relatedArtifact= value;
OnPropertyChanged("relatedArtifact", value);
}
}

public FhirString? Usage
{
get { return _usage; }
set {
_usage= value;
OnPropertyChanged("usage", value);
}
}

public List<NamingSystemUniqueId>? UniqueId
{
get { return _uniqueId; }
set {
_uniqueId= value;
OnPropertyChanged("uniqueId", value);
}
}


		#endregion
		#region Constructor
		public  NamingSystem() { }
		public  NamingSystem(string value) : base(value) { }
		public  NamingSystem(JsonNode? source) : base(source) { }
		#endregion
	}
		public class NamingSystemUniqueId : BackboneElementType<NamingSystemUniqueId>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirString? _value;
private FhirBoolean? _preferred;
private FhirString? _comment;
private Period? _period;
private FhirBoolean? _authoritative;

		#endregion
		#region public Method
		public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public FhirBoolean? Preferred
{
get { return _preferred; }
set {
_preferred= value;
OnPropertyChanged("preferred", value);
}
}

public FhirString? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
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

public FhirBoolean? Authoritative
{
get { return _authoritative; }
set {
_authoritative= value;
OnPropertyChanged("authoritative", value);
}
}


		#endregion
		#region Constructor
		public  NamingSystemUniqueId() { }
		public  NamingSystemUniqueId(string value) : base(value) { }
		public  NamingSystemUniqueId(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class NamingSystemVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public NamingSystemVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public NamingSystemVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public NamingSystemVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
