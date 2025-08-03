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
    public class Requirements : ResourceType<Requirements>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private RequirementsVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
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
private List<FhirCanonical>? _derivedFrom;
private List<FhirUrl>? _reference;
private List<FhirCanonical>? _actor;
private List<RequirementsStatement>? _statement;

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

public RequirementsVersionAlgorithmChoice? VersionAlgorithm
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

public List<FhirCanonical>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
}
}

public List<FhirUrl>? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public List<FhirCanonical>? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}

public List<RequirementsStatement>? Statement
{
get { return _statement; }
set {
_statement= value;
OnPropertyChanged("statement", value);
}
}


		#endregion
		#region Constructor
		public  Requirements() { }
		public  Requirements(string value) : base(value) { }
		public  Requirements(JsonNode? source) : base(source) { }
		#endregion
	}
		public class RequirementsStatement : BackboneElementType<RequirementsStatement>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _key;
private FhirString? _label;
private List<FhirCode>? _conformance;
private FhirBoolean? _conditionality;
private FhirMarkdown? _requirement;
private FhirString? _derivedFrom;
private FhirString? _parent;
private List<FhirUrl>? _satisfiedBy;
private List<FhirUrl>? _reference;
private List<ReferenceType>? _source;

		#endregion
		#region public Method
		public FhirId? Key
{
get { return _key; }
set {
_key= value;
OnPropertyChanged("key", value);
}
}

public FhirString? Label
{
get { return _label; }
set {
_label= value;
OnPropertyChanged("label", value);
}
}

public List<FhirCode>? Conformance
{
get { return _conformance; }
set {
_conformance= value;
OnPropertyChanged("conformance", value);
}
}

public FhirBoolean? Conditionality
{
get { return _conditionality; }
set {
_conditionality= value;
OnPropertyChanged("conditionality", value);
}
}

public FhirMarkdown? Requirement
{
get { return _requirement; }
set {
_requirement= value;
OnPropertyChanged("requirement", value);
}
}

public FhirString? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
}
}

public FhirString? Parent
{
get { return _parent; }
set {
_parent= value;
OnPropertyChanged("parent", value);
}
}

public List<FhirUrl>? SatisfiedBy
{
get { return _satisfiedBy; }
set {
_satisfiedBy= value;
OnPropertyChanged("satisfiedBy", value);
}
}

public List<FhirUrl>? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public List<ReferenceType>? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  RequirementsStatement() { }
		public  RequirementsStatement(string value) : base(value) { }
		public  RequirementsStatement(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class RequirementsVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public RequirementsVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public RequirementsVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public RequirementsVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
