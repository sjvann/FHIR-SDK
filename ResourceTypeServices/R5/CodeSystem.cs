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
    public class CodeSystem : ResourceType<CodeSystem>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private CodeSystemVersionAlgorithmChoice? _versionAlgorithm;
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
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<CodeableConcept>? _topic;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<RelatedArtifact>? _relatedArtifact;
private FhirBoolean? _caseSensitive;
private FhirCanonical? _valueSet;
private FhirCode? _hierarchyMeaning;
private FhirBoolean? _compositional;
private FhirBoolean? _versionNeeded;
private FhirCode? _content;
private FhirCanonical? _supplements;
private FhirUnsignedInt? _count;
private List<CodeSystemFilter>? _filter;
private List<CodeSystemProperty>? _property;
private List<CodeSystemConcept>? _concept;

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

public CodeSystemVersionAlgorithmChoice? VersionAlgorithm
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

public FhirBoolean? CaseSensitive
{
get { return _caseSensitive; }
set {
_caseSensitive= value;
OnPropertyChanged("caseSensitive", value);
}
}

public FhirCanonical? ValueSet
{
get { return _valueSet; }
set {
_valueSet= value;
OnPropertyChanged("valueSet", value);
}
}

public FhirCode? HierarchyMeaning
{
get { return _hierarchyMeaning; }
set {
_hierarchyMeaning= value;
OnPropertyChanged("hierarchyMeaning", value);
}
}

public FhirBoolean? Compositional
{
get { return _compositional; }
set {
_compositional= value;
OnPropertyChanged("compositional", value);
}
}

public FhirBoolean? VersionNeeded
{
get { return _versionNeeded; }
set {
_versionNeeded= value;
OnPropertyChanged("versionNeeded", value);
}
}

public FhirCode? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}

public FhirCanonical? Supplements
{
get { return _supplements; }
set {
_supplements= value;
OnPropertyChanged("supplements", value);
}
}

public FhirUnsignedInt? Count
{
get { return _count; }
set {
_count= value;
OnPropertyChanged("count", value);
}
}

public List<CodeSystemFilter>? Filter
{
get { return _filter; }
set {
_filter= value;
OnPropertyChanged("filter", value);
}
}

public List<CodeSystemProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<CodeSystemConcept>? Concept
{
get { return _concept; }
set {
_concept= value;
OnPropertyChanged("concept", value);
}
}


		#endregion
		#region Constructor
		public  CodeSystem() { }
		public  CodeSystem(string value) : base(value) { }
		public  CodeSystem(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CodeSystemFilter : BackboneElementType<CodeSystemFilter>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirString? _description;
private List<FhirCode>? _operator;
private FhirString? _value;

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

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<FhirCode>? Operator
{
get { return _operator; }
set {
_operator= value;
OnPropertyChanged("operator", value);
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


		#endregion
		#region Constructor
		public  CodeSystemFilter() { }
		public  CodeSystemFilter(string value) : base(value) { }
		public  CodeSystemFilter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CodeSystemProperty : BackboneElementType<CodeSystemProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirUri? _uri;
private FhirString? _description;
private FhirCode? _type;

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

public FhirUri? Uri
{
get { return _uri; }
set {
_uri= value;
OnPropertyChanged("uri", value);
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

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}


		#endregion
		#region Constructor
		public  CodeSystemProperty() { }
		public  CodeSystemProperty(string value) : base(value) { }
		public  CodeSystemProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CodeSystemConceptDesignation : BackboneElementType<CodeSystemConceptDesignation>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _language;
private Coding? _use;
private List<Coding>? _additionalUse;
private FhirString? _value;

		#endregion
		#region public Method
		public FhirCode? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public Coding? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}

public List<Coding>? AdditionalUse
{
get { return _additionalUse; }
set {
_additionalUse= value;
OnPropertyChanged("additionalUse", value);
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


		#endregion
		#region Constructor
		public  CodeSystemConceptDesignation() { }
		public  CodeSystemConceptDesignation(string value) : base(value) { }
		public  CodeSystemConceptDesignation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CodeSystemConceptProperty : BackboneElementType<CodeSystemConceptProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private CodeSystemConceptPropertyValueChoice? _value;

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

public CodeSystemConceptPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  CodeSystemConceptProperty() { }
		public  CodeSystemConceptProperty(string value) : base(value) { }
		public  CodeSystemConceptProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class CodeSystemConcept : BackboneElementType<CodeSystemConcept>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirString? _display;
private FhirString? _definition;
private List<CodeSystemConceptDesignation>? _designation;
private List<CodeSystemConceptProperty>? _property;

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

public FhirString? Display
{
get { return _display; }
set {
_display= value;
OnPropertyChanged("display", value);
}
}

public FhirString? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public List<CodeSystemConceptDesignation>? Designation
{
get { return _designation; }
set {
_designation= value;
OnPropertyChanged("designation", value);
}
}

public List<CodeSystemConceptProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}


		#endregion
		#region Constructor
		public  CodeSystemConcept() { }
		public  CodeSystemConcept(string value) : base(value) { }
		public  CodeSystemConcept(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class CodeSystemVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public CodeSystemVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public CodeSystemVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public CodeSystemVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class CodeSystemConceptPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "code","CodingstringintegerbooleandateTimedecimal"
        ];

        public CodeSystemConceptPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public CodeSystemConceptPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public CodeSystemConceptPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
