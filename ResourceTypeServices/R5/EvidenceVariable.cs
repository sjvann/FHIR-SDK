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
    public class EvidenceVariable : ResourceType<EvidenceVariable>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private EvidenceVariableVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirString? _shortTitle;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<Annotation>? _note;
private List<UsageContext>? _useContext;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private Period? _effectivePeriod;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<RelatedArtifact>? _relatedArtifact;
private FhirBoolean? _actual;
private List<EvidenceVariableCharacteristic>? _characteristic;
private FhirCode? _handling;
private List<EvidenceVariableCategory>? _category;

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

public EvidenceVariableVersionAlgorithmChoice? VersionAlgorithm
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

public FhirString? ShortTitle
{
get { return _shortTitle; }
set {
_shortTitle= value;
OnPropertyChanged("shortTitle", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
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

public FhirBoolean? Actual
{
get { return _actual; }
set {
_actual= value;
OnPropertyChanged("actual", value);
}
}

public List<EvidenceVariableCharacteristic>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}

public FhirCode? Handling
{
get { return _handling; }
set {
_handling= value;
OnPropertyChanged("handling", value);
}
}

public List<EvidenceVariableCategory>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariable() { }
		public  EvidenceVariable(string value) : base(value) { }
		public  EvidenceVariable(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EvidenceVariableCharacteristicDefinitionByTypeAndValue : BackboneElementType<EvidenceVariableCharacteristicDefinitionByTypeAndValue>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<CodeableConcept>? _method;
private ReferenceType? _device;
private EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice? _value;
private CodeableConcept? _offset;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<CodeableConcept>? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public CodeableConcept? Offset
{
get { return _offset; }
set {
_offset= value;
OnPropertyChanged("offset", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariableCharacteristicDefinitionByTypeAndValue() { }
		public  EvidenceVariableCharacteristicDefinitionByTypeAndValue(string value) : base(value) { }
		public  EvidenceVariableCharacteristicDefinitionByTypeAndValue(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceVariableCharacteristicDefinitionByCombination : BackboneElementType<EvidenceVariableCharacteristicDefinitionByCombination>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _code;
private FhirPositiveInt? _threshold;

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

public FhirPositiveInt? Threshold
{
get { return _threshold; }
set {
_threshold= value;
OnPropertyChanged("threshold", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariableCharacteristicDefinitionByCombination() { }
		public  EvidenceVariableCharacteristicDefinitionByCombination(string value) : base(value) { }
		public  EvidenceVariableCharacteristicDefinitionByCombination(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceVariableCharacteristicTimeFromEvent : BackboneElementType<EvidenceVariableCharacteristicTimeFromEvent>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private List<Annotation>? _note;
private EvidenceVariableCharacteristicTimeFromEventEventChoice? _event;
private Quantity? _quantity;
private Range? _range;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public EvidenceVariableCharacteristicTimeFromEventEventChoice? Event
{
get { return _event; }
set {
_event= value;
OnPropertyChanged("event", value);
}
}

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public Range? Range
{
get { return _range; }
set {
_range= value;
OnPropertyChanged("range", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariableCharacteristicTimeFromEvent() { }
		public  EvidenceVariableCharacteristicTimeFromEvent(string value) : base(value) { }
		public  EvidenceVariableCharacteristicTimeFromEvent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceVariableCharacteristic : BackboneElementType<EvidenceVariableCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _linkId;
private FhirMarkdown? _description;
private List<Annotation>? _note;
private FhirBoolean? _exclude;
private ReferenceType? _definitionReference;
private FhirCanonical? _definitionCanonical;
private CodeableConcept? _definitionCodeableConcept;
private ExpressionType? _definitionExpression;
private FhirId? _definitionId;
private EvidenceVariableCharacteristicDefinitionByTypeAndValue? _definitionByTypeAndValue;
private EvidenceVariableCharacteristicDefinitionByCombination? _definitionByCombination;
private EvidenceVariableCharacteristicInstancesChoice? _instances;
private EvidenceVariableCharacteristicDurationChoice? _duration;
private List<EvidenceVariableCharacteristicTimeFromEvent>? _timeFromEvent;

		#endregion
		#region public Method
		public FhirId? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public FhirBoolean? Exclude
{
get { return _exclude; }
set {
_exclude= value;
OnPropertyChanged("exclude", value);
}
}

public ReferenceType? DefinitionReference
{
get { return _definitionReference; }
set {
_definitionReference= value;
OnPropertyChanged("definitionReference", value);
}
}

public FhirCanonical? DefinitionCanonical
{
get { return _definitionCanonical; }
set {
_definitionCanonical= value;
OnPropertyChanged("definitionCanonical", value);
}
}

public CodeableConcept? DefinitionCodeableConcept
{
get { return _definitionCodeableConcept; }
set {
_definitionCodeableConcept= value;
OnPropertyChanged("definitionCodeableConcept", value);
}
}

public ExpressionType? DefinitionExpression
{
get { return _definitionExpression; }
set {
_definitionExpression= value;
OnPropertyChanged("definitionExpression", value);
}
}

public FhirId? DefinitionId
{
get { return _definitionId; }
set {
_definitionId= value;
OnPropertyChanged("definitionId", value);
}
}

public EvidenceVariableCharacteristicDefinitionByTypeAndValue? DefinitionByTypeAndValue
{
get { return _definitionByTypeAndValue; }
set {
_definitionByTypeAndValue= value;
OnPropertyChanged("definitionByTypeAndValue", value);
}
}

public EvidenceVariableCharacteristicDefinitionByCombination? DefinitionByCombination
{
get { return _definitionByCombination; }
set {
_definitionByCombination= value;
OnPropertyChanged("definitionByCombination", value);
}
}

public EvidenceVariableCharacteristicInstancesChoice? Instances
{
get { return _instances; }
set {
_instances= value;
OnPropertyChanged("instances", value);
}
}

public EvidenceVariableCharacteristicDurationChoice? Duration
{
get { return _duration; }
set {
_duration= value;
OnPropertyChanged("duration", value);
}
}

public List<EvidenceVariableCharacteristicTimeFromEvent>? TimeFromEvent
{
get { return _timeFromEvent; }
set {
_timeFromEvent= value;
OnPropertyChanged("timeFromEvent", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariableCharacteristic() { }
		public  EvidenceVariableCharacteristic(string value) : base(value) { }
		public  EvidenceVariableCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceVariableCategory : BackboneElementType<EvidenceVariableCategory>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private EvidenceVariableCategoryValueChoice? _value;

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

public EvidenceVariableCategoryValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariableCategory() { }
		public  EvidenceVariableCategory(string value) : base(value) { }
		public  EvidenceVariableCategory(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class EvidenceVariableVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public EvidenceVariableVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public EvidenceVariableVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public EvidenceVariableVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","booleanQuantityRangeReferenceid"
        ];

        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public EvidenceVariableCharacteristicDefinitionByTypeAndValueValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceVariableCharacteristicInstancesChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","Range"
        ];

        public EvidenceVariableCharacteristicInstancesChoice(JsonObject value) : base("instances", value, _supportType)
        {
        }
        public EvidenceVariableCharacteristicInstancesChoice(IComplexType? value) : base("instances", value)
        {
        }
        public EvidenceVariableCharacteristicInstancesChoice(IPrimitiveType? value) : base("instances", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"instances".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceVariableCharacteristicDurationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","Range"
        ];

        public EvidenceVariableCharacteristicDurationChoice(JsonObject value) : base("duration", value, _supportType)
        {
        }
        public EvidenceVariableCharacteristicDurationChoice(IComplexType? value) : base("duration", value)
        {
        }
        public EvidenceVariableCharacteristicDurationChoice(IPrimitiveType? value) : base("duration", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"duration".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceVariableCharacteristicTimeFromEventEventChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","ReferencedateTimeid"
        ];

        public EvidenceVariableCharacteristicTimeFromEventEventChoice(JsonObject value) : base("event", value, _supportType)
        {
        }
        public EvidenceVariableCharacteristicTimeFromEventEventChoice(IComplexType? value) : base("event", value)
        {
        }
        public EvidenceVariableCharacteristicTimeFromEventEventChoice(IPrimitiveType? value) : base("event", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"event".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceVariableCategoryValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantityRange"
        ];

        public EvidenceVariableCategoryValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public EvidenceVariableCategoryValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public EvidenceVariableCategoryValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
