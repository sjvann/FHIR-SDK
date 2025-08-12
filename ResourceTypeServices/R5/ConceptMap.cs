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
    public class ConceptMap : ResourceType<ConceptMap>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private ConceptMapVersionAlgorithmChoice? _versionAlgorithm;
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
private List<ConceptMapProperty>? _property;
private List<ConceptMapAdditionalAttribute>? _additionalAttribute;
private ConceptMapSourceScopeChoice? _sourceScope;
private ConceptMapTargetScopeChoice? _targetScope;
private List<ConceptMapGroup>? _group;

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

public ConceptMapVersionAlgorithmChoice? VersionAlgorithm
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

public List<ConceptMapProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<ConceptMapAdditionalAttribute>? AdditionalAttribute
{
get { return _additionalAttribute; }
set {
_additionalAttribute= value;
OnPropertyChanged("additionalAttribute", value);
}
}

public ConceptMapSourceScopeChoice? SourceScope
{
get { return _sourceScope; }
set {
_sourceScope= value;
OnPropertyChanged("sourceScope", value);
}
}

public ConceptMapTargetScopeChoice? TargetScope
{
get { return _targetScope; }
set {
_targetScope= value;
OnPropertyChanged("targetScope", value);
}
}

public List<ConceptMapGroup>? Group
{
get { return _group; }
set {
_group= value;
OnPropertyChanged("group", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMap() { }
		public  ConceptMap(string value) : base(value) { }
		public  ConceptMap(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ConceptMapProperty : BackboneElementType<ConceptMapProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirUri? _uri;
private FhirString? _description;
private FhirCode? _type;
private FhirCanonical? _system;

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

public FhirCanonical? System
{
get { return _system; }
set {
_system= value;
OnPropertyChanged("system", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMapProperty() { }
		public  ConceptMapProperty(string value) : base(value) { }
		public  ConceptMapProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapAdditionalAttribute : BackboneElementType<ConceptMapAdditionalAttribute>, IBackboneElementType
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
		public  ConceptMapAdditionalAttribute() { }
		public  ConceptMapAdditionalAttribute(string value) : base(value) { }
		public  ConceptMapAdditionalAttribute(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapGroupElementTargetProperty : BackboneElementType<ConceptMapGroupElementTargetProperty>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private ConceptMapGroupElementTargetPropertyValueChoice? _value;

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

public ConceptMapGroupElementTargetPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMapGroupElementTargetProperty() { }
		public  ConceptMapGroupElementTargetProperty(string value) : base(value) { }
		public  ConceptMapGroupElementTargetProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapGroupElementTargetDependsOn : BackboneElementType<ConceptMapGroupElementTargetDependsOn>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _attribute;
private ConceptMapGroupElementTargetDependsOnValueChoice? _value;
private FhirCanonical? _valueSet;

		#endregion
		#region public Method
		public FhirCode? Attribute
{
get { return _attribute; }
set {
_attribute= value;
OnPropertyChanged("attribute", value);
}
}

public ConceptMapGroupElementTargetDependsOnValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
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


		#endregion
		#region Constructor
		public  ConceptMapGroupElementTargetDependsOn() { }
		public  ConceptMapGroupElementTargetDependsOn(string value) : base(value) { }
		public  ConceptMapGroupElementTargetDependsOn(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapGroupElementTarget : BackboneElementType<ConceptMapGroupElementTarget>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirString? _display;
private FhirCanonical? _valueSet;
private FhirCode? _relationship;
private FhirString? _comment;
private List<ConceptMapGroupElementTargetProperty>? _property;
private List<ConceptMapGroupElementTargetDependsOn>? _dependsOn;

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

public FhirCanonical? ValueSet
{
get { return _valueSet; }
set {
_valueSet= value;
OnPropertyChanged("valueSet", value);
}
}

public FhirCode? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
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

public List<ConceptMapGroupElementTargetProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<ConceptMapGroupElementTargetDependsOn>? DependsOn
{
get { return _dependsOn; }
set {
_dependsOn= value;
OnPropertyChanged("dependsOn", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMapGroupElementTarget() { }
		public  ConceptMapGroupElementTarget(string value) : base(value) { }
		public  ConceptMapGroupElementTarget(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapGroupElement : BackboneElementType<ConceptMapGroupElement>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirString? _display;
private FhirCanonical? _valueSet;
private FhirBoolean? _noMap;
private List<ConceptMapGroupElementTarget>? _target;

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

public FhirCanonical? ValueSet
{
get { return _valueSet; }
set {
_valueSet= value;
OnPropertyChanged("valueSet", value);
}
}

public FhirBoolean? NoMap
{
get { return _noMap; }
set {
_noMap= value;
OnPropertyChanged("noMap", value);
}
}

public List<ConceptMapGroupElementTarget>? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMapGroupElement() { }
		public  ConceptMapGroupElement(string value) : base(value) { }
		public  ConceptMapGroupElement(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapGroupUnmapped : BackboneElementType<ConceptMapGroupUnmapped>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _mode;
private FhirCode? _code;
private FhirString? _display;
private FhirCanonical? _valueSet;
private FhirCode? _relationship;
private FhirCanonical? _otherMap;

		#endregion
		#region public Method
		public FhirCode? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
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

public FhirCanonical? ValueSet
{
get { return _valueSet; }
set {
_valueSet= value;
OnPropertyChanged("valueSet", value);
}
}

public FhirCode? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public FhirCanonical? OtherMap
{
get { return _otherMap; }
set {
_otherMap= value;
OnPropertyChanged("otherMap", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMapGroupUnmapped() { }
		public  ConceptMapGroupUnmapped(string value) : base(value) { }
		public  ConceptMapGroupUnmapped(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConceptMapGroup : BackboneElementType<ConceptMapGroup>, IBackboneElementType
	{

		#region Private Method
		private FhirCanonical? _source;
private FhirCanonical? _target;
private List<ConceptMapGroupElement>? _element;
private ConceptMapGroupUnmapped? _unmapped;

		#endregion
		#region public Method
		public FhirCanonical? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public FhirCanonical? Target
{
get { return _target; }
set {
_target= value;
OnPropertyChanged("target", value);
}
}

public List<ConceptMapGroupElement>? Element
{
get { return _element; }
set {
_element= value;
OnPropertyChanged("element", value);
}
}

public ConceptMapGroupUnmapped? Unmapped
{
get { return _unmapped; }
set {
_unmapped= value;
OnPropertyChanged("unmapped", value);
}
}


		#endregion
		#region Constructor
		public  ConceptMapGroup() { }
		public  ConceptMapGroup(string value) : base(value) { }
		public  ConceptMapGroup(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ConceptMapVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ConceptMapVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ConceptMapVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ConceptMapVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ConceptMapSourceScopeChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "uri","canonical(ValueSet)"
        ];

        public ConceptMapSourceScopeChoice(JsonObject value) : base("sourceScope", value, _supportType)
        {
        }
        public ConceptMapSourceScopeChoice(IComplexType? value) : base("sourceScope", value)
        {
        }
        public ConceptMapSourceScopeChoice(IPrimitiveType? value) : base("sourceScope", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"sourceScope".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ConceptMapTargetScopeChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "uri","canonical(ValueSet)"
        ];

        public ConceptMapTargetScopeChoice(JsonObject value) : base("targetScope", value, _supportType)
        {
        }
        public ConceptMapTargetScopeChoice(IComplexType? value) : base("targetScope", value)
        {
        }
        public ConceptMapTargetScopeChoice(IPrimitiveType? value) : base("targetScope", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"targetScope".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ConceptMapGroupElementTargetPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Coding","stringintegerbooleandateTimedecimalcode"
        ];

        public ConceptMapGroupElementTargetPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ConceptMapGroupElementTargetPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ConceptMapGroupElementTargetPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ConceptMapGroupElementTargetDependsOnValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "code","CodingstringbooleanQuantity"
        ];

        public ConceptMapGroupElementTargetDependsOnValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ConceptMapGroupElementTargetDependsOnValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ConceptMapGroupElementTargetDependsOnValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
