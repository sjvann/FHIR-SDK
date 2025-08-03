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
    public class SpecimenDefinition : ResourceType<SpecimenDefinition>
	{
		#region private Property
		private FhirUri? _url;
private Identifier? _identifier;
private FhirString? _version;
private SpecimenDefinitionVersionAlgorithmChoice? _versionAlgorithm;
private FhirString? _name;
private FhirString? _title;
private List<FhirCanonical>? _derivedFromCanonical;
private List<FhirUri>? _derivedFromUri;
private FhirCode? _status;
private FhirBoolean? _experimental;
private SpecimenDefinitionSubjectChoice? _subject;
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
private CodeableConcept? _typeCollected;
private List<CodeableConcept>? _patientPreparation;
private FhirString? _timeAspect;
private List<CodeableConcept>? _collection;
private List<SpecimenDefinitionTypeTested>? _typeTested;

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

public SpecimenDefinitionVersionAlgorithmChoice? VersionAlgorithm
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

public SpecimenDefinitionSubjectChoice? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
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

public CodeableConcept? TypeCollected
{
get { return _typeCollected; }
set {
_typeCollected= value;
OnPropertyChanged("typeCollected", value);
}
}

public List<CodeableConcept>? PatientPreparation
{
get { return _patientPreparation; }
set {
_patientPreparation= value;
OnPropertyChanged("patientPreparation", value);
}
}

public FhirString? TimeAspect
{
get { return _timeAspect; }
set {
_timeAspect= value;
OnPropertyChanged("timeAspect", value);
}
}

public List<CodeableConcept>? Collection
{
get { return _collection; }
set {
_collection= value;
OnPropertyChanged("collection", value);
}
}

public List<SpecimenDefinitionTypeTested>? TypeTested
{
get { return _typeTested; }
set {
_typeTested= value;
OnPropertyChanged("typeTested", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenDefinition() { }
		public  SpecimenDefinition(string value) : base(value) { }
		public  SpecimenDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SpecimenDefinitionTypeTestedContainerAdditive : BackboneElementType<SpecimenDefinitionTypeTestedContainerAdditive>, IBackboneElementType
	{

		#region Private Method
		private SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice? _additive;

		#endregion
		#region public Method
		public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice? Additive
{
get { return _additive; }
set {
_additive= value;
OnPropertyChanged("additive", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenDefinitionTypeTestedContainerAdditive() { }
		public  SpecimenDefinitionTypeTestedContainerAdditive(string value) : base(value) { }
		public  SpecimenDefinitionTypeTestedContainerAdditive(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SpecimenDefinitionTypeTestedContainer : BackboneElementType<SpecimenDefinitionTypeTestedContainer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _material;
private CodeableConcept? _type;
private CodeableConcept? _cap;
private FhirMarkdown? _description;
private Quantity? _capacity;
private SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice? _minimumVolume;
private List<SpecimenDefinitionTypeTestedContainerAdditive>? _additive;
private FhirMarkdown? _preparation;

		#endregion
		#region public Method
		public CodeableConcept? Material
{
get { return _material; }
set {
_material= value;
OnPropertyChanged("material", value);
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

public CodeableConcept? Cap
{
get { return _cap; }
set {
_cap= value;
OnPropertyChanged("cap", value);
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

public Quantity? Capacity
{
get { return _capacity; }
set {
_capacity= value;
OnPropertyChanged("capacity", value);
}
}

public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice? MinimumVolume
{
get { return _minimumVolume; }
set {
_minimumVolume= value;
OnPropertyChanged("minimumVolume", value);
}
}

public List<SpecimenDefinitionTypeTestedContainerAdditive>? Additive
{
get { return _additive; }
set {
_additive= value;
OnPropertyChanged("additive", value);
}
}

public FhirMarkdown? Preparation
{
get { return _preparation; }
set {
_preparation= value;
OnPropertyChanged("preparation", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenDefinitionTypeTestedContainer() { }
		public  SpecimenDefinitionTypeTestedContainer(string value) : base(value) { }
		public  SpecimenDefinitionTypeTestedContainer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SpecimenDefinitionTypeTestedHandling : BackboneElementType<SpecimenDefinitionTypeTestedHandling>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _temperatureQualifier;
private Range? _temperatureRange;
private Duration? _maxDuration;
private FhirMarkdown? _instruction;

		#endregion
		#region public Method
		public CodeableConcept? TemperatureQualifier
{
get { return _temperatureQualifier; }
set {
_temperatureQualifier= value;
OnPropertyChanged("temperatureQualifier", value);
}
}

public Range? TemperatureRange
{
get { return _temperatureRange; }
set {
_temperatureRange= value;
OnPropertyChanged("temperatureRange", value);
}
}

public Duration? MaxDuration
{
get { return _maxDuration; }
set {
_maxDuration= value;
OnPropertyChanged("maxDuration", value);
}
}

public FhirMarkdown? Instruction
{
get { return _instruction; }
set {
_instruction= value;
OnPropertyChanged("instruction", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenDefinitionTypeTestedHandling() { }
		public  SpecimenDefinitionTypeTestedHandling(string value) : base(value) { }
		public  SpecimenDefinitionTypeTestedHandling(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SpecimenDefinitionTypeTested : BackboneElementType<SpecimenDefinitionTypeTested>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _isDerived;
private CodeableConcept? _type;
private FhirCode? _preference;
private SpecimenDefinitionTypeTestedContainer? _container;
private FhirMarkdown? _requirement;
private Duration? _retentionTime;
private FhirBoolean? _singleUse;
private List<CodeableConcept>? _rejectionCriterion;
private List<SpecimenDefinitionTypeTestedHandling>? _handling;
private List<CodeableConcept>? _testingDestination;

		#endregion
		#region public Method
		public FhirBoolean? IsDerived
{
get { return _isDerived; }
set {
_isDerived= value;
OnPropertyChanged("isDerived", value);
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

public FhirCode? Preference
{
get { return _preference; }
set {
_preference= value;
OnPropertyChanged("preference", value);
}
}

public SpecimenDefinitionTypeTestedContainer? Container
{
get { return _container; }
set {
_container= value;
OnPropertyChanged("container", value);
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

public Duration? RetentionTime
{
get { return _retentionTime; }
set {
_retentionTime= value;
OnPropertyChanged("retentionTime", value);
}
}

public FhirBoolean? SingleUse
{
get { return _singleUse; }
set {
_singleUse= value;
OnPropertyChanged("singleUse", value);
}
}

public List<CodeableConcept>? RejectionCriterion
{
get { return _rejectionCriterion; }
set {
_rejectionCriterion= value;
OnPropertyChanged("rejectionCriterion", value);
}
}

public List<SpecimenDefinitionTypeTestedHandling>? Handling
{
get { return _handling; }
set {
_handling= value;
OnPropertyChanged("handling", value);
}
}

public List<CodeableConcept>? TestingDestination
{
get { return _testingDestination; }
set {
_testingDestination= value;
OnPropertyChanged("testingDestination", value);
}
}


		#endregion
		#region Constructor
		public  SpecimenDefinitionTypeTested() { }
		public  SpecimenDefinitionTypeTested(string value) : base(value) { }
		public  SpecimenDefinitionTypeTested(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SpecimenDefinitionVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public SpecimenDefinitionVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public SpecimenDefinitionVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public SpecimenDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SpecimenDefinitionSubjectChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Group)"
        ];

        public SpecimenDefinitionSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public SpecimenDefinitionSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public SpecimenDefinitionSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity {SimpleQuantity}","string"
        ];

        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice(JsonObject value) : base("minimumVolume", value, _supportType)
        {
        }
        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice(IComplexType? value) : base("minimumVolume", value)
        {
        }
        public SpecimenDefinitionTypeTestedContainerMinimumVolumeChoice(IPrimitiveType? value) : base("minimumVolume", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"minimumVolume".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(SubstanceDefinition)"
        ];

        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice(JsonObject value) : base("additive", value, _supportType)
        {
        }
        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice(IComplexType? value) : base("additive", value)
        {
        }
        public SpecimenDefinitionTypeTestedContainerAdditiveAdditiveChoice(IPrimitiveType? value) : base("additive", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"additive".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
