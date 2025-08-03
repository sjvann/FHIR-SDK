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
    public class Evidence : ResourceType<Evidence>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private EvidenceVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private EvidenceCiteAsChoice? _citeAs;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private List<ContactDetail>? _author;
private List<ContactDetail>? _editor;
private List<ContactDetail>? _reviewer;
private List<ContactDetail>? _endorser;
private List<UsageContext>? _useContext;
private FhirMarkdown? _purpose;
private FhirMarkdown? _copyright;
private FhirString? _copyrightLabel;
private List<RelatedArtifact>? _relatedArtifact;
private FhirMarkdown? _description;
private FhirMarkdown? _assertion;
private List<Annotation>? _note;
private List<EvidenceVariableDefinition>? _variableDefinition;
private CodeableConcept? _synthesisType;
private List<CodeableConcept>? _studyDesign;
private List<EvidenceStatistic>? _statistic;
private List<EvidenceCertainty>? _certainty;

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

public EvidenceVersionAlgorithmChoice? VersionAlgorithm
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

public EvidenceCiteAsChoice? CiteAs
{
get { return _citeAs; }
set {
_citeAs= value;
OnPropertyChanged("citeAs", value);
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

public List<RelatedArtifact>? RelatedArtifact
{
get { return _relatedArtifact; }
set {
_relatedArtifact= value;
OnPropertyChanged("relatedArtifact", value);
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

public FhirMarkdown? Assertion
{
get { return _assertion; }
set {
_assertion= value;
OnPropertyChanged("assertion", value);
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

public List<EvidenceVariableDefinition>? VariableDefinition
{
get { return _variableDefinition; }
set {
_variableDefinition= value;
OnPropertyChanged("variableDefinition", value);
}
}

public CodeableConcept? SynthesisType
{
get { return _synthesisType; }
set {
_synthesisType= value;
OnPropertyChanged("synthesisType", value);
}
}

public List<CodeableConcept>? StudyDesign
{
get { return _studyDesign; }
set {
_studyDesign= value;
OnPropertyChanged("studyDesign", value);
}
}

public List<EvidenceStatistic>? Statistic
{
get { return _statistic; }
set {
_statistic= value;
OnPropertyChanged("statistic", value);
}
}

public List<EvidenceCertainty>? Certainty
{
get { return _certainty; }
set {
_certainty= value;
OnPropertyChanged("certainty", value);
}
}


		#endregion
		#region Constructor
		public  Evidence() { }
		public  Evidence(string value) : base(value) { }
		public  Evidence(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EvidenceVariableDefinition : BackboneElementType<EvidenceVariableDefinition>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private List<Annotation>? _note;
private CodeableConcept? _variableRole;
private ReferenceType? _observed;
private ReferenceType? _intended;
private CodeableConcept? _directnessMatch;

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

public CodeableConcept? VariableRole
{
get { return _variableRole; }
set {
_variableRole= value;
OnPropertyChanged("variableRole", value);
}
}

public ReferenceType? Observed
{
get { return _observed; }
set {
_observed= value;
OnPropertyChanged("observed", value);
}
}

public ReferenceType? Intended
{
get { return _intended; }
set {
_intended= value;
OnPropertyChanged("intended", value);
}
}

public CodeableConcept? DirectnessMatch
{
get { return _directnessMatch; }
set {
_directnessMatch= value;
OnPropertyChanged("directnessMatch", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceVariableDefinition() { }
		public  EvidenceVariableDefinition(string value) : base(value) { }
		public  EvidenceVariableDefinition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceStatisticSampleSize : BackboneElementType<EvidenceStatisticSampleSize>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private List<Annotation>? _note;
private FhirUnsignedInt? _numberOfStudies;
private FhirUnsignedInt? _numberOfParticipants;
private FhirUnsignedInt? _knownDataCount;

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

public FhirUnsignedInt? NumberOfStudies
{
get { return _numberOfStudies; }
set {
_numberOfStudies= value;
OnPropertyChanged("numberOfStudies", value);
}
}

public FhirUnsignedInt? NumberOfParticipants
{
get { return _numberOfParticipants; }
set {
_numberOfParticipants= value;
OnPropertyChanged("numberOfParticipants", value);
}
}

public FhirUnsignedInt? KnownDataCount
{
get { return _knownDataCount; }
set {
_knownDataCount= value;
OnPropertyChanged("knownDataCount", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceStatisticSampleSize() { }
		public  EvidenceStatisticSampleSize(string value) : base(value) { }
		public  EvidenceStatisticSampleSize(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceStatisticAttributeEstimate : BackboneElementType<EvidenceStatisticAttributeEstimate>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private List<Annotation>? _note;
private CodeableConcept? _type;
private Quantity? _quantity;
private FhirDecimal? _level;
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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public FhirDecimal? Level
{
get { return _level; }
set {
_level= value;
OnPropertyChanged("level", value);
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
		public  EvidenceStatisticAttributeEstimate() { }
		public  EvidenceStatisticAttributeEstimate(string value) : base(value) { }
		public  EvidenceStatisticAttributeEstimate(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceStatisticModelCharacteristicVariable : BackboneElementType<EvidenceStatisticModelCharacteristicVariable>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _variableDefinition;
private FhirCode? _handling;
private List<CodeableConcept>? _valueCategory;
private List<Quantity>? _valueQuantity;
private List<Range>? _valueRange;

		#endregion
		#region public Method
		public ReferenceType? VariableDefinition
{
get { return _variableDefinition; }
set {
_variableDefinition= value;
OnPropertyChanged("variableDefinition", value);
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

public List<CodeableConcept>? ValueCategory
{
get { return _valueCategory; }
set {
_valueCategory= value;
OnPropertyChanged("valueCategory", value);
}
}

public List<Quantity>? ValueQuantity
{
get { return _valueQuantity; }
set {
_valueQuantity= value;
OnPropertyChanged("valueQuantity", value);
}
}

public List<Range>? ValueRange
{
get { return _valueRange; }
set {
_valueRange= value;
OnPropertyChanged("valueRange", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceStatisticModelCharacteristicVariable() { }
		public  EvidenceStatisticModelCharacteristicVariable(string value) : base(value) { }
		public  EvidenceStatisticModelCharacteristicVariable(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceStatisticModelCharacteristic : BackboneElementType<EvidenceStatisticModelCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private Quantity? _value;
private List<EvidenceStatisticModelCharacteristicVariable>? _variable;

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

public Quantity? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public List<EvidenceStatisticModelCharacteristicVariable>? Variable
{
get { return _variable; }
set {
_variable= value;
OnPropertyChanged("variable", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceStatisticModelCharacteristic() { }
		public  EvidenceStatisticModelCharacteristic(string value) : base(value) { }
		public  EvidenceStatisticModelCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceStatistic : BackboneElementType<EvidenceStatistic>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private List<Annotation>? _note;
private CodeableConcept? _statisticType;
private CodeableConcept? _category;
private Quantity? _quantity;
private FhirUnsignedInt? _numberOfEvents;
private FhirUnsignedInt? _numberAffected;
private EvidenceStatisticSampleSize? _sampleSize;
private List<EvidenceStatisticAttributeEstimate>? _attributeEstimate;
private List<EvidenceStatisticModelCharacteristic>? _modelCharacteristic;

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

public CodeableConcept? StatisticType
{
get { return _statisticType; }
set {
_statisticType= value;
OnPropertyChanged("statisticType", value);
}
}

public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public FhirUnsignedInt? NumberOfEvents
{
get { return _numberOfEvents; }
set {
_numberOfEvents= value;
OnPropertyChanged("numberOfEvents", value);
}
}

public FhirUnsignedInt? NumberAffected
{
get { return _numberAffected; }
set {
_numberAffected= value;
OnPropertyChanged("numberAffected", value);
}
}

public EvidenceStatisticSampleSize? SampleSize
{
get { return _sampleSize; }
set {
_sampleSize= value;
OnPropertyChanged("sampleSize", value);
}
}

public List<EvidenceStatisticAttributeEstimate>? AttributeEstimate
{
get { return _attributeEstimate; }
set {
_attributeEstimate= value;
OnPropertyChanged("attributeEstimate", value);
}
}

public List<EvidenceStatisticModelCharacteristic>? ModelCharacteristic
{
get { return _modelCharacteristic; }
set {
_modelCharacteristic= value;
OnPropertyChanged("modelCharacteristic", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceStatistic() { }
		public  EvidenceStatistic(string value) : base(value) { }
		public  EvidenceStatistic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EvidenceCertainty : BackboneElementType<EvidenceCertainty>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private List<Annotation>? _note;
private CodeableConcept? _type;
private CodeableConcept? _rating;
private FhirString? _rater;

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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? Rating
{
get { return _rating; }
set {
_rating= value;
OnPropertyChanged("rating", value);
}
}

public FhirString? Rater
{
get { return _rater; }
set {
_rater= value;
OnPropertyChanged("rater", value);
}
}


		#endregion
		#region Constructor
		public  EvidenceCertainty() { }
		public  EvidenceCertainty(string value) : base(value) { }
		public  EvidenceCertainty(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class EvidenceVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public EvidenceVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public EvidenceVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public EvidenceVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class EvidenceCiteAsChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(Citation)","markdown"
        ];

        public EvidenceCiteAsChoice(JsonObject value) : base("citeAs", value, _supportType)
        {
        }
        public EvidenceCiteAsChoice(IComplexType? value) : base("citeAs", value)
        {
        }
        public EvidenceCiteAsChoice(IPrimitiveType? value) : base("citeAs", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"citeAs".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
