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
    public class ChargeItemDefinition : ResourceType<ChargeItemDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private ChargeItemDefinitionVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private List<FhirUri>? _derivedFromUri;
private List<FhirCanonical>? _partOf;
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
private FhirDate? _approvalDate;
private FhirDate? _lastReviewDate;
private CodeableConcept? _code;
private List<ReferenceType>? _instance;
private List<ChargeItemDefinitionApplicability>? _applicability;
private List<ChargeItemDefinitionPropertyGroup>? _propertyGroup;

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

public ChargeItemDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public List<FhirUri>? DerivedFromUri
{
get { return _derivedFromUri; }
set {
_derivedFromUri= value;
OnPropertyChanged("derivedFromUri", value);
}
}

public List<FhirCanonical>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<ReferenceType>? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}

public List<ChargeItemDefinitionApplicability>? Applicability
{
get { return _applicability; }
set {
_applicability= value;
OnPropertyChanged("applicability", value);
}
}

public List<ChargeItemDefinitionPropertyGroup>? PropertyGroup
{
get { return _propertyGroup; }
set {
_propertyGroup= value;
OnPropertyChanged("propertyGroup", value);
}
}


		#endregion
		#region Constructor
		public  ChargeItemDefinition() { }
		public  ChargeItemDefinition(string value) : base(value) { }
		public  ChargeItemDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ChargeItemDefinitionApplicability : BackboneElementType<ChargeItemDefinitionApplicability>, IBackboneElementType
	{

		#region Private Method
		private ExpressionType? _condition;
private Period? _effectivePeriod;
private RelatedArtifact? _relatedArtifact;

		#endregion
		#region public Method
		public ExpressionType? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
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

public RelatedArtifact? RelatedArtifact
{
get { return _relatedArtifact; }
set {
_relatedArtifact= value;
OnPropertyChanged("relatedArtifact", value);
}
}


		#endregion
		#region Constructor
		public  ChargeItemDefinitionApplicability() { }
		public  ChargeItemDefinitionApplicability(string value) : base(value) { }
		public  ChargeItemDefinitionApplicability(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ChargeItemDefinitionPropertyGroup : BackboneElementType<ChargeItemDefinitionPropertyGroup>, IBackboneElementType
	{

		#region Private Method
		private List<MonetaryComponent>? _priceComponent;

		#endregion
		#region public Method
		public List<MonetaryComponent>? PriceComponent
{
get { return _priceComponent; }
set {
_priceComponent= value;
OnPropertyChanged("priceComponent", value);
}
}


		#endregion
		#region Constructor
		public  ChargeItemDefinitionPropertyGroup() { }
		public  ChargeItemDefinitionPropertyGroup(string value) : base(value) { }
		public  ChargeItemDefinitionPropertyGroup(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ChargeItemDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ChargeItemDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ChargeItemDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ChargeItemDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
