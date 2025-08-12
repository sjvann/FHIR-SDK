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
    public class ObservationDefinition : ResourceType<ObservationDefinition>
	{
		#region private Property
		private FhirUri? _url;
private Identifier? _identifier;
private FhirString? _version;
private ObservationDefinitionVersionAlgorithmChoice? _versionAlgorithm;
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
private List<FhirCanonical>? _derivedFromCanonical;
private List<FhirUri>? _derivedFromUri;
private List<CodeableConcept>? _subject;
private CodeableConcept? _performerType;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private List<FhirCode>? _permittedDataType;
private FhirBoolean? _multipleResultsAllowed;
private CodeableConcept? _bodySite;
private CodeableConcept? _method;
private List<ReferenceType>? _specimen;
private List<ReferenceType>? _device;
private FhirString? _preferredReportName;
private List<Coding>? _permittedUnit;
private List<ObservationDefinitionQualifiedValue>? _qualifiedValue;
private List<ReferenceType>? _hasMember;
private List<ObservationDefinitionComponent>? _component;

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

public Identifier? Identifier
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

public ObservationDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public List<FhirCanonical>? DerivedFromCanonical
{
get { return _derivedFromCanonical; }
set {
_derivedFromCanonical= value;
OnPropertyChanged("derivedFromCanonical", value);
}
}

public List<FhirUri>? DerivedFromUri
{
get { return _derivedFromUri; }
set {
_derivedFromUri= value;
OnPropertyChanged("derivedFromUri", value);
}
}

public List<CodeableConcept>? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public CodeableConcept? PerformerType
{
get { return _performerType; }
set {
_performerType= value;
OnPropertyChanged("performerType", value);
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

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<FhirCode>? PermittedDataType
{
get { return _permittedDataType; }
set {
_permittedDataType= value;
OnPropertyChanged("permittedDataType", value);
}
}

public FhirBoolean? MultipleResultsAllowed
{
get { return _multipleResultsAllowed; }
set {
_multipleResultsAllowed= value;
OnPropertyChanged("multipleResultsAllowed", value);
}
}

public CodeableConcept? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public CodeableConcept? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
}
}

public List<ReferenceType>? Specimen
{
get { return _specimen; }
set {
_specimen= value;
OnPropertyChanged("specimen", value);
}
}

public List<ReferenceType>? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public FhirString? PreferredReportName
{
get { return _preferredReportName; }
set {
_preferredReportName= value;
OnPropertyChanged("preferredReportName", value);
}
}

public List<Coding>? PermittedUnit
{
get { return _permittedUnit; }
set {
_permittedUnit= value;
OnPropertyChanged("permittedUnit", value);
}
}

public List<ObservationDefinitionQualifiedValue>? QualifiedValue
{
get { return _qualifiedValue; }
set {
_qualifiedValue= value;
OnPropertyChanged("qualifiedValue", value);
}
}

public List<ReferenceType>? HasMember
{
get { return _hasMember; }
set {
_hasMember= value;
OnPropertyChanged("hasMember", value);
}
}

public List<ObservationDefinitionComponent>? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}


		#endregion
		#region Constructor
		public  ObservationDefinition() { }
		public  ObservationDefinition(string value) : base(value) { }
		public  ObservationDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ObservationDefinitionQualifiedValue : BackboneElementType<ObservationDefinitionQualifiedValue>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _context;
private List<CodeableConcept>? _appliesTo;
private FhirCode? _gender;
private Range? _age;
private Range? _gestationalAge;
private FhirString? _condition;
private FhirCode? _rangeCategory;
private Range? _range;
private FhirCanonical? _validCodedValueSet;
private FhirCanonical? _normalCodedValueSet;
private FhirCanonical? _abnormalCodedValueSet;
private FhirCanonical? _criticalCodedValueSet;

		#endregion
		#region public Method
		public CodeableConcept? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public List<CodeableConcept>? AppliesTo
{
get { return _appliesTo; }
set {
_appliesTo= value;
OnPropertyChanged("appliesTo", value);
}
}

public FhirCode? Gender
{
get { return _gender; }
set {
_gender= value;
OnPropertyChanged("gender", value);
}
}

public Range? Age
{
get { return _age; }
set {
_age= value;
OnPropertyChanged("age", value);
}
}

public Range? GestationalAge
{
get { return _gestationalAge; }
set {
_gestationalAge= value;
OnPropertyChanged("gestationalAge", value);
}
}

public FhirString? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public FhirCode? RangeCategory
{
get { return _rangeCategory; }
set {
_rangeCategory= value;
OnPropertyChanged("rangeCategory", value);
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

public FhirCanonical? ValidCodedValueSet
{
get { return _validCodedValueSet; }
set {
_validCodedValueSet= value;
OnPropertyChanged("validCodedValueSet", value);
}
}

public FhirCanonical? NormalCodedValueSet
{
get { return _normalCodedValueSet; }
set {
_normalCodedValueSet= value;
OnPropertyChanged("normalCodedValueSet", value);
}
}

public FhirCanonical? AbnormalCodedValueSet
{
get { return _abnormalCodedValueSet; }
set {
_abnormalCodedValueSet= value;
OnPropertyChanged("abnormalCodedValueSet", value);
}
}

public FhirCanonical? CriticalCodedValueSet
{
get { return _criticalCodedValueSet; }
set {
_criticalCodedValueSet= value;
OnPropertyChanged("criticalCodedValueSet", value);
}
}


		#endregion
		#region Constructor
		public  ObservationDefinitionQualifiedValue() { }
		public  ObservationDefinitionQualifiedValue(string value) : base(value) { }
		public  ObservationDefinitionQualifiedValue(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ObservationDefinitionComponent : BackboneElementType<ObservationDefinitionComponent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private List<FhirCode>? _permittedDataType;
private List<Coding>? _permittedUnit;

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

public List<FhirCode>? PermittedDataType
{
get { return _permittedDataType; }
set {
_permittedDataType= value;
OnPropertyChanged("permittedDataType", value);
}
}

public List<Coding>? PermittedUnit
{
get { return _permittedUnit; }
set {
_permittedUnit= value;
OnPropertyChanged("permittedUnit", value);
}
}


		#endregion
		#region Constructor
		public  ObservationDefinitionComponent() { }
		public  ObservationDefinitionComponent(string value) : base(value) { }
		public  ObservationDefinitionComponent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ObservationDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ObservationDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ObservationDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ObservationDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
