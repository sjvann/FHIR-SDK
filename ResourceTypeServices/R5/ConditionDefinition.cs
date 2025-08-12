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
    public class ConditionDefinition : ResourceType<ConditionDefinition>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private ConditionDefinitionVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private FhirString? _subtitle;
private FhirCode? _status;
private FhirBoolean? _experimental;
private FhirDateTime? _date;
private FhirString? _publisher;
private List<ContactDetail>? _contact;
private FhirMarkdown? _description;
private List<UsageContext>? _useContext;
private List<CodeableConcept>? _jurisdiction;
private CodeableConcept? _code;
private CodeableConcept? _severity;
private CodeableConcept? _bodySite;
private CodeableConcept? _stage;
private FhirBoolean? _hasSeverity;
private FhirBoolean? _hasBodySite;
private FhirBoolean? _hasStage;
private List<FhirUri>? _definition;
private List<ConditionDefinitionObservation>? _observation;
private List<ConditionDefinitionMedication>? _medication;
private List<ConditionDefinitionPrecondition>? _precondition;
private List<ReferenceType>? _team;
private List<ConditionDefinitionQuestionnaire>? _questionnaire;
private List<ConditionDefinitionPlan>? _plan;

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

public ConditionDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public FhirString? Subtitle
{
get { return _subtitle; }
set {
_subtitle= value;
OnPropertyChanged("subtitle", value);
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

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public CodeableConcept? Severity
{
get { return _severity; }
set {
_severity= value;
OnPropertyChanged("severity", value);
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

public CodeableConcept? Stage
{
get { return _stage; }
set {
_stage= value;
OnPropertyChanged("stage", value);
}
}

public FhirBoolean? HasSeverity
{
get { return _hasSeverity; }
set {
_hasSeverity= value;
OnPropertyChanged("hasSeverity", value);
}
}

public FhirBoolean? HasBodySite
{
get { return _hasBodySite; }
set {
_hasBodySite= value;
OnPropertyChanged("hasBodySite", value);
}
}

public FhirBoolean? HasStage
{
get { return _hasStage; }
set {
_hasStage= value;
OnPropertyChanged("hasStage", value);
}
}

public List<FhirUri>? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public List<ConditionDefinitionObservation>? Observation
{
get { return _observation; }
set {
_observation= value;
OnPropertyChanged("observation", value);
}
}

public List<ConditionDefinitionMedication>? Medication
{
get { return _medication; }
set {
_medication= value;
OnPropertyChanged("medication", value);
}
}

public List<ConditionDefinitionPrecondition>? Precondition
{
get { return _precondition; }
set {
_precondition= value;
OnPropertyChanged("precondition", value);
}
}

public List<ReferenceType>? Team
{
get { return _team; }
set {
_team= value;
OnPropertyChanged("team", value);
}
}

public List<ConditionDefinitionQuestionnaire>? Questionnaire
{
get { return _questionnaire; }
set {
_questionnaire= value;
OnPropertyChanged("questionnaire", value);
}
}

public List<ConditionDefinitionPlan>? Plan
{
get { return _plan; }
set {
_plan= value;
OnPropertyChanged("plan", value);
}
}


		#endregion
		#region Constructor
		public  ConditionDefinition() { }
		public  ConditionDefinition(string value) : base(value) { }
		public  ConditionDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ConditionDefinitionObservation : BackboneElementType<ConditionDefinitionObservation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _code;

		#endregion
		#region public Method
		public CodeableConcept? Category
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


		#endregion
		#region Constructor
		public  ConditionDefinitionObservation() { }
		public  ConditionDefinitionObservation(string value) : base(value) { }
		public  ConditionDefinitionObservation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConditionDefinitionMedication : BackboneElementType<ConditionDefinitionMedication>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _code;

		#endregion
		#region public Method
		public CodeableConcept? Category
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


		#endregion
		#region Constructor
		public  ConditionDefinitionMedication() { }
		public  ConditionDefinitionMedication(string value) : base(value) { }
		public  ConditionDefinitionMedication(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConditionDefinitionPrecondition : BackboneElementType<ConditionDefinitionPrecondition>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private CodeableConcept? _code;
private ConditionDefinitionPreconditionValueChoice? _value;

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

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public ConditionDefinitionPreconditionValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ConditionDefinitionPrecondition() { }
		public  ConditionDefinitionPrecondition(string value) : base(value) { }
		public  ConditionDefinitionPrecondition(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConditionDefinitionQuestionnaire : BackboneElementType<ConditionDefinitionQuestionnaire>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _purpose;
private ReferenceType? _reference;

		#endregion
		#region public Method
		public FhirCode? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}

public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}


		#endregion
		#region Constructor
		public  ConditionDefinitionQuestionnaire() { }
		public  ConditionDefinitionQuestionnaire(string value) : base(value) { }
		public  ConditionDefinitionQuestionnaire(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConditionDefinitionPlan : BackboneElementType<ConditionDefinitionPlan>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _role;
private ReferenceType? _reference;

		#endregion
		#region public Method
		public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
}
}

public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}


		#endregion
		#region Constructor
		public  ConditionDefinitionPlan() { }
		public  ConditionDefinitionPlan(string value) : base(value) { }
		public  ConditionDefinitionPlan(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ConditionDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public ConditionDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public ConditionDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public ConditionDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ConditionDefinitionPreconditionValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Quantity"
        ];

        public ConditionDefinitionPreconditionValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ConditionDefinitionPreconditionValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ConditionDefinitionPreconditionValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
