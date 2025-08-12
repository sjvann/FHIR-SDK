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
    public class ValueSet : ResourceType<ValueSet>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private ValueSetVersionAlgorithmChoice? _versionAlgorithm;
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
private FhirBoolean? _immutable;
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
private ValueSetCompose? _compose;
private ValueSetExpansion? _expansion;
private ValueSetScope? _scope;

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

public ValueSetVersionAlgorithmChoice? VersionAlgorithm
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

public FhirBoolean? Immutable
{
get { return _immutable; }
set {
_immutable= value;
OnPropertyChanged("immutable", value);
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

public ValueSetCompose? Compose
{
get { return _compose; }
set {
_compose= value;
OnPropertyChanged("compose", value);
}
}

public ValueSetExpansion? Expansion
{
get { return _expansion; }
set {
_expansion= value;
OnPropertyChanged("expansion", value);
}
}

public ValueSetScope? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}


		#endregion
		#region Constructor
		public  ValueSet() { }
		public  ValueSet(string value) : base(value) { }
		public  ValueSet(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ValueSetComposeIncludeConceptDesignation : BackboneElementType<ValueSetComposeIncludeConceptDesignation>, IBackboneElementType
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
		public  ValueSetComposeIncludeConceptDesignation() { }
		public  ValueSetComposeIncludeConceptDesignation(string value) : base(value) { }
		public  ValueSetComposeIncludeConceptDesignation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetComposeIncludeConcept : BackboneElementType<ValueSetComposeIncludeConcept>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirString? _display;
private List<ValueSetComposeIncludeConceptDesignation>? _designation;

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

public List<ValueSetComposeIncludeConceptDesignation>? Designation
{
get { return _designation; }
set {
_designation= value;
OnPropertyChanged("designation", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetComposeIncludeConcept() { }
		public  ValueSetComposeIncludeConcept(string value) : base(value) { }
		public  ValueSetComposeIncludeConcept(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetComposeIncludeFilter : BackboneElementType<ValueSetComposeIncludeFilter>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _property;
private FhirCode? _op;
private FhirString? _value;

		#endregion
		#region public Method
		public FhirCode? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public FhirCode? Op
{
get { return _op; }
set {
_op= value;
OnPropertyChanged("op", value);
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
		public  ValueSetComposeIncludeFilter() { }
		public  ValueSetComposeIncludeFilter(string value) : base(value) { }
		public  ValueSetComposeIncludeFilter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetComposeInclude : BackboneElementType<ValueSetComposeInclude>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _system;
private FhirString? _version;
private List<ValueSetComposeIncludeConcept>? _concept;
private List<ValueSetComposeIncludeFilter>? _filter;
private List<FhirCanonical>? _valueSet;
private FhirString? _copyright;

		#endregion
		#region public Method
		public FhirUri? System
{
get { return _system; }
set {
_system= value;
OnPropertyChanged("system", value);
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

public List<ValueSetComposeIncludeConcept>? Concept
{
get { return _concept; }
set {
_concept= value;
OnPropertyChanged("concept", value);
}
}

public List<ValueSetComposeIncludeFilter>? Filter
{
get { return _filter; }
set {
_filter= value;
OnPropertyChanged("filter", value);
}
}

public List<FhirCanonical>? ValueSet
{
get { return _valueSet; }
set {
_valueSet= value;
OnPropertyChanged("valueSet", value);
}
}

public FhirString? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetComposeInclude() { }
		public  ValueSetComposeInclude(string value) : base(value) { }
		public  ValueSetComposeInclude(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetCompose : BackboneElementType<ValueSetCompose>, IBackboneElementType
	{

		#region Private Method
		private FhirDate? _lockedDate;
private FhirBoolean? _inactive;
private List<ValueSetComposeInclude>? _include;
private List<FhirString>? _property;

		#endregion
		#region public Method
		public FhirDate? LockedDate
{
get { return _lockedDate; }
set {
_lockedDate= value;
OnPropertyChanged("lockedDate", value);
}
}

public FhirBoolean? Inactive
{
get { return _inactive; }
set {
_inactive= value;
OnPropertyChanged("inactive", value);
}
}

public List<ValueSetComposeInclude>? Include
{
get { return _include; }
set {
_include= value;
OnPropertyChanged("include", value);
}
}

public List<FhirString>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetCompose() { }
		public  ValueSetCompose(string value) : base(value) { }
		public  ValueSetCompose(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetExpansionParameter : BackboneElementType<ValueSetExpansionParameter>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private ValueSetExpansionParameterValueChoice? _value;

		#endregion
		#region public Method
		public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public ValueSetExpansionParameterValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetExpansionParameter() { }
		public  ValueSetExpansionParameter(string value) : base(value) { }
		public  ValueSetExpansionParameter(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetExpansionProperty : BackboneElementType<ValueSetExpansionProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirUri? _uri;

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


		#endregion
		#region Constructor
		public  ValueSetExpansionProperty() { }
		public  ValueSetExpansionProperty(string value) : base(value) { }
		public  ValueSetExpansionProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetExpansionContainsPropertySubProperty : BackboneElementType<ValueSetExpansionContainsPropertySubProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private ValueSetExpansionContainsPropertySubPropertyValueChoice? _value;

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

public ValueSetExpansionContainsPropertySubPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetExpansionContainsPropertySubProperty() { }
		public  ValueSetExpansionContainsPropertySubProperty(string value) : base(value) { }
		public  ValueSetExpansionContainsPropertySubProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetExpansionContainsProperty : BackboneElementType<ValueSetExpansionContainsProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private ValueSetExpansionContainsPropertyValueChoice? _value;
private List<ValueSetExpansionContainsPropertySubProperty>? _subProperty;

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

public ValueSetExpansionContainsPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public List<ValueSetExpansionContainsPropertySubProperty>? SubProperty
{
get { return _subProperty; }
set {
_subProperty= value;
OnPropertyChanged("subProperty", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetExpansionContainsProperty() { }
		public  ValueSetExpansionContainsProperty(string value) : base(value) { }
		public  ValueSetExpansionContainsProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetExpansionContains : BackboneElementType<ValueSetExpansionContains>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _system;
private FhirBoolean? _abstract;
private FhirBoolean? _inactive;
private FhirString? _version;
private FhirCode? _code;
private FhirString? _display;
private List<ValueSetExpansionContainsProperty>? _property;

		#endregion
		#region public Method
		public FhirUri? System
{
get { return _system; }
set {
_system= value;
OnPropertyChanged("system", value);
}
}

public FhirBoolean? Abstract
{
get { return _abstract; }
set {
_abstract= value;
OnPropertyChanged("abstract", value);
}
}

public FhirBoolean? Inactive
{
get { return _inactive; }
set {
_inactive= value;
OnPropertyChanged("inactive", value);
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

public List<ValueSetExpansionContainsProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetExpansionContains() { }
		public  ValueSetExpansionContains(string value) : base(value) { }
		public  ValueSetExpansionContains(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetExpansion : BackboneElementType<ValueSetExpansion>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _identifier;
private FhirUri? _next;
private FhirDateTime? _timestamp;
private FhirInteger? _total;
private FhirInteger? _offset;
private List<ValueSetExpansionParameter>? _parameter;
private List<ValueSetExpansionProperty>? _property;
private List<ValueSetExpansionContains>? _contains;

		#endregion
		#region public Method
		public FhirUri? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirUri? Next
{
get { return _next; }
set {
_next= value;
OnPropertyChanged("next", value);
}
}

public FhirDateTime? Timestamp
{
get { return _timestamp; }
set {
_timestamp= value;
OnPropertyChanged("timestamp", value);
}
}

public FhirInteger? Total
{
get { return _total; }
set {
_total= value;
OnPropertyChanged("total", value);
}
}

public FhirInteger? Offset
{
get { return _offset; }
set {
_offset= value;
OnPropertyChanged("offset", value);
}
}

public List<ValueSetExpansionParameter>? Parameter
{
get { return _parameter; }
set {
_parameter= value;
OnPropertyChanged("parameter", value);
}
}

public List<ValueSetExpansionProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<ValueSetExpansionContains>? Contains
{
get { return _contains; }
set {
_contains= value;
OnPropertyChanged("contains", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetExpansion() { }
		public  ValueSetExpansion(string value) : base(value) { }
		public  ValueSetExpansion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ValueSetScope : BackboneElementType<ValueSetScope>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _inclusionCriteria;
private FhirString? _exclusionCriteria;

		#endregion
		#region public Method
		public FhirString? InclusionCriteria
{
get { return _inclusionCriteria; }
set {
_inclusionCriteria= value;
OnPropertyChanged("inclusionCriteria", value);
}
}

public FhirString? ExclusionCriteria
{
get { return _exclusionCriteria; }
set {
_exclusionCriteria= value;
OnPropertyChanged("exclusionCriteria", value);
}
}


		#endregion
		#region Constructor
		public  ValueSetScope() { }
		public  ValueSetScope(string value) : base(value) { }
		public  ValueSetScope(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ValueSetVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ValueSetVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ValueSetVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ValueSetVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ValueSetExpansionParameterValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","booleanintegerdecimaluricodedateTime"
        ];

        public ValueSetExpansionParameterValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ValueSetExpansionParameterValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ValueSetExpansionParameterValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ValueSetExpansionContainsPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "code","CodingstringintegerbooleandateTimedecimal"
        ];

        public ValueSetExpansionContainsPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ValueSetExpansionContainsPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ValueSetExpansionContainsPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ValueSetExpansionContainsPropertySubPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "code","CodingstringintegerbooleandateTimedecimal"
        ];

        public ValueSetExpansionContainsPropertySubPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ValueSetExpansionContainsPropertySubPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ValueSetExpansionContainsPropertySubPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
