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
    public class MedicationKnowledge : ResourceType<MedicationKnowledge>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _code;
private FhirCode? _status;
private ReferenceType? _author;
private List<CodeableConcept>? _intendedJurisdiction;
private List<FhirString>? _name;
private List<MedicationKnowledgeRelatedMedicationKnowledge>? _relatedMedicationKnowledge;
private List<ReferenceType>? _associatedMedication;
private List<CodeableConcept>? _productType;
private List<MedicationKnowledgeMonograph>? _monograph;
private FhirMarkdown? _preparationInstruction;
private List<MedicationKnowledgeCost>? _cost;
private List<MedicationKnowledgeMonitoringProgram>? _monitoringProgram;
private List<MedicationKnowledgeIndicationGuideline>? _indicationGuideline;
private List<MedicationKnowledgeMedicineClassification>? _medicineClassification;
private List<MedicationKnowledgePackaging>? _packaging;
private List<ReferenceType>? _clinicalUseIssue;
private List<MedicationKnowledgeStorageGuideline>? _storageGuideline;
private List<MedicationKnowledgeRegulatory>? _regulatory;
private MedicationKnowledgeDefinitional? _definitional;

		#endregion
		#region Public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public ReferenceType? Author
{
get { return _author; }
set {
_author= value;
OnPropertyChanged("author", value);
}
}

public List<CodeableConcept>? IntendedJurisdiction
{
get { return _intendedJurisdiction; }
set {
_intendedJurisdiction= value;
OnPropertyChanged("intendedJurisdiction", value);
}
}

public List<FhirString>? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<MedicationKnowledgeRelatedMedicationKnowledge>? RelatedMedicationKnowledge
{
get { return _relatedMedicationKnowledge; }
set {
_relatedMedicationKnowledge= value;
OnPropertyChanged("relatedMedicationKnowledge", value);
}
}

public List<ReferenceType>? AssociatedMedication
{
get { return _associatedMedication; }
set {
_associatedMedication= value;
OnPropertyChanged("associatedMedication", value);
}
}

public List<CodeableConcept>? ProductType
{
get { return _productType; }
set {
_productType= value;
OnPropertyChanged("productType", value);
}
}

public List<MedicationKnowledgeMonograph>? Monograph
{
get { return _monograph; }
set {
_monograph= value;
OnPropertyChanged("monograph", value);
}
}

public FhirMarkdown? PreparationInstruction
{
get { return _preparationInstruction; }
set {
_preparationInstruction= value;
OnPropertyChanged("preparationInstruction", value);
}
}

public List<MedicationKnowledgeCost>? Cost
{
get { return _cost; }
set {
_cost= value;
OnPropertyChanged("cost", value);
}
}

public List<MedicationKnowledgeMonitoringProgram>? MonitoringProgram
{
get { return _monitoringProgram; }
set {
_monitoringProgram= value;
OnPropertyChanged("monitoringProgram", value);
}
}

public List<MedicationKnowledgeIndicationGuideline>? IndicationGuideline
{
get { return _indicationGuideline; }
set {
_indicationGuideline= value;
OnPropertyChanged("indicationGuideline", value);
}
}

public List<MedicationKnowledgeMedicineClassification>? MedicineClassification
{
get { return _medicineClassification; }
set {
_medicineClassification= value;
OnPropertyChanged("medicineClassification", value);
}
}

public List<MedicationKnowledgePackaging>? Packaging
{
get { return _packaging; }
set {
_packaging= value;
OnPropertyChanged("packaging", value);
}
}

public List<ReferenceType>? ClinicalUseIssue
{
get { return _clinicalUseIssue; }
set {
_clinicalUseIssue= value;
OnPropertyChanged("clinicalUseIssue", value);
}
}

public List<MedicationKnowledgeStorageGuideline>? StorageGuideline
{
get { return _storageGuideline; }
set {
_storageGuideline= value;
OnPropertyChanged("storageGuideline", value);
}
}

public List<MedicationKnowledgeRegulatory>? Regulatory
{
get { return _regulatory; }
set {
_regulatory= value;
OnPropertyChanged("regulatory", value);
}
}

public MedicationKnowledgeDefinitional? Definitional
{
get { return _definitional; }
set {
_definitional= value;
OnPropertyChanged("definitional", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledge() { }
		public  MedicationKnowledge(string value) : base(value) { }
		public  MedicationKnowledge(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicationKnowledgeRelatedMedicationKnowledge : BackboneElementType<MedicationKnowledgeRelatedMedicationKnowledge>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<ReferenceType>? _reference;

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

public List<ReferenceType>? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeRelatedMedicationKnowledge() { }
		public  MedicationKnowledgeRelatedMedicationKnowledge(string value) : base(value) { }
		public  MedicationKnowledgeRelatedMedicationKnowledge(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeMonograph : BackboneElementType<MedicationKnowledgeMonograph>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ReferenceType? _source;

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

public ReferenceType? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeMonograph() { }
		public  MedicationKnowledgeMonograph(string value) : base(value) { }
		public  MedicationKnowledgeMonograph(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeCost : BackboneElementType<MedicationKnowledgeCost>, IBackboneElementType
	{

		#region Private Method
		private List<Period>? _effectiveDate;
private CodeableConcept? _type;
private FhirString? _source;
private MedicationKnowledgeCostCostChoice? _cost;

		#endregion
		#region public Method
		public List<Period>? EffectiveDate
{
get { return _effectiveDate; }
set {
_effectiveDate= value;
OnPropertyChanged("effectiveDate", value);
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

public FhirString? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public MedicationKnowledgeCostCostChoice? Cost
{
get { return _cost; }
set {
_cost= value;
OnPropertyChanged("cost", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeCost() { }
		public  MedicationKnowledgeCost(string value) : base(value) { }
		public  MedicationKnowledgeCost(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeMonitoringProgram : BackboneElementType<MedicationKnowledgeMonitoringProgram>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _name;

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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeMonitoringProgram() { }
		public  MedicationKnowledgeMonitoringProgram(string value) : base(value) { }
		public  MedicationKnowledgeMonitoringProgram(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage : BackboneElementType<MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<Dosage>? _dosage;

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

public List<Dosage>? Dosage
{
get { return _dosage; }
set {
_dosage= value;
OnPropertyChanged("dosage", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage() { }
		public  MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage(string value) : base(value) { }
		public  MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic : BackboneElementType<MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice? _value;

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

public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic() { }
		public  MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic(string value) : base(value) { }
		public  MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeIndicationGuidelineDosingGuideline : BackboneElementType<MedicationKnowledgeIndicationGuidelineDosingGuideline>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _treatmentIntent;
private List<MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage>? _dosage;
private CodeableConcept? _administrationTreatment;
private List<MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic>? _patientCharacteristic;

		#endregion
		#region public Method
		public CodeableConcept? TreatmentIntent
{
get { return _treatmentIntent; }
set {
_treatmentIntent= value;
OnPropertyChanged("treatmentIntent", value);
}
}

public List<MedicationKnowledgeIndicationGuidelineDosingGuidelineDosage>? Dosage
{
get { return _dosage; }
set {
_dosage= value;
OnPropertyChanged("dosage", value);
}
}

public CodeableConcept? AdministrationTreatment
{
get { return _administrationTreatment; }
set {
_administrationTreatment= value;
OnPropertyChanged("administrationTreatment", value);
}
}

public List<MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristic>? PatientCharacteristic
{
get { return _patientCharacteristic; }
set {
_patientCharacteristic= value;
OnPropertyChanged("patientCharacteristic", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeIndicationGuidelineDosingGuideline() { }
		public  MedicationKnowledgeIndicationGuidelineDosingGuideline(string value) : base(value) { }
		public  MedicationKnowledgeIndicationGuidelineDosingGuideline(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeIndicationGuideline : BackboneElementType<MedicationKnowledgeIndicationGuideline>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableReference>? _indication;
private List<MedicationKnowledgeIndicationGuidelineDosingGuideline>? _dosingGuideline;

		#endregion
		#region public Method
		public List<CodeableReference>? Indication
{
get { return _indication; }
set {
_indication= value;
OnPropertyChanged("indication", value);
}
}

public List<MedicationKnowledgeIndicationGuidelineDosingGuideline>? DosingGuideline
{
get { return _dosingGuideline; }
set {
_dosingGuideline= value;
OnPropertyChanged("dosingGuideline", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeIndicationGuideline() { }
		public  MedicationKnowledgeIndicationGuideline(string value) : base(value) { }
		public  MedicationKnowledgeIndicationGuideline(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeMedicineClassification : BackboneElementType<MedicationKnowledgeMedicineClassification>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private MedicationKnowledgeMedicineClassificationSourceChoice? _source;
private List<CodeableConcept>? _classification;

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

public MedicationKnowledgeMedicineClassificationSourceChoice? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}

public List<CodeableConcept>? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeMedicineClassification() { }
		public  MedicationKnowledgeMedicineClassification(string value) : base(value) { }
		public  MedicationKnowledgeMedicineClassification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgePackaging : BackboneElementType<MedicationKnowledgePackaging>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _packagedProduct;

		#endregion
		#region public Method
		public ReferenceType? PackagedProduct
{
get { return _packagedProduct; }
set {
_packagedProduct= value;
OnPropertyChanged("packagedProduct", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgePackaging() { }
		public  MedicationKnowledgePackaging(string value) : base(value) { }
		public  MedicationKnowledgePackaging(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeStorageGuidelineEnvironmentalSetting : BackboneElementType<MedicationKnowledgeStorageGuidelineEnvironmentalSetting>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice? _value;

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

public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeStorageGuidelineEnvironmentalSetting() { }
		public  MedicationKnowledgeStorageGuidelineEnvironmentalSetting(string value) : base(value) { }
		public  MedicationKnowledgeStorageGuidelineEnvironmentalSetting(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeStorageGuideline : BackboneElementType<MedicationKnowledgeStorageGuideline>, IBackboneElementType
	{

		#region Private Method
		private FhirUri? _reference;
private List<Annotation>? _note;
private Duration? _stabilityDuration;
private List<MedicationKnowledgeStorageGuidelineEnvironmentalSetting>? _environmentalSetting;

		#endregion
		#region public Method
		public FhirUri? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
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

public Duration? StabilityDuration
{
get { return _stabilityDuration; }
set {
_stabilityDuration= value;
OnPropertyChanged("stabilityDuration", value);
}
}

public List<MedicationKnowledgeStorageGuidelineEnvironmentalSetting>? EnvironmentalSetting
{
get { return _environmentalSetting; }
set {
_environmentalSetting= value;
OnPropertyChanged("environmentalSetting", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeStorageGuideline() { }
		public  MedicationKnowledgeStorageGuideline(string value) : base(value) { }
		public  MedicationKnowledgeStorageGuideline(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeRegulatorySubstitution : BackboneElementType<MedicationKnowledgeRegulatorySubstitution>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirBoolean? _allowed;

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

public FhirBoolean? Allowed
{
get { return _allowed; }
set {
_allowed= value;
OnPropertyChanged("allowed", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeRegulatorySubstitution() { }
		public  MedicationKnowledgeRegulatorySubstitution(string value) : base(value) { }
		public  MedicationKnowledgeRegulatorySubstitution(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeRegulatoryMaxDispense : BackboneElementType<MedicationKnowledgeRegulatoryMaxDispense>, IBackboneElementType
	{

		#region Private Method
		private Quantity? _quantity;
private Duration? _period;

		#endregion
		#region public Method
		public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public Duration? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeRegulatoryMaxDispense() { }
		public  MedicationKnowledgeRegulatoryMaxDispense(string value) : base(value) { }
		public  MedicationKnowledgeRegulatoryMaxDispense(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeRegulatory : BackboneElementType<MedicationKnowledgeRegulatory>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _regulatoryAuthority;
private List<MedicationKnowledgeRegulatorySubstitution>? _substitution;
private List<CodeableConcept>? _schedule;
private MedicationKnowledgeRegulatoryMaxDispense? _maxDispense;

		#endregion
		#region public Method
		public ReferenceType? RegulatoryAuthority
{
get { return _regulatoryAuthority; }
set {
_regulatoryAuthority= value;
OnPropertyChanged("regulatoryAuthority", value);
}
}

public List<MedicationKnowledgeRegulatorySubstitution>? Substitution
{
get { return _substitution; }
set {
_substitution= value;
OnPropertyChanged("substitution", value);
}
}

public List<CodeableConcept>? Schedule
{
get { return _schedule; }
set {
_schedule= value;
OnPropertyChanged("schedule", value);
}
}

public MedicationKnowledgeRegulatoryMaxDispense? MaxDispense
{
get { return _maxDispense; }
set {
_maxDispense= value;
OnPropertyChanged("maxDispense", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeRegulatory() { }
		public  MedicationKnowledgeRegulatory(string value) : base(value) { }
		public  MedicationKnowledgeRegulatory(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeDefinitionalIngredient : BackboneElementType<MedicationKnowledgeDefinitionalIngredient>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _item;
private CodeableConcept? _type;
private MedicationKnowledgeDefinitionalIngredientStrengthChoice? _strength;

		#endregion
		#region public Method
		public CodeableReference? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
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

public MedicationKnowledgeDefinitionalIngredientStrengthChoice? Strength
{
get { return _strength; }
set {
_strength= value;
OnPropertyChanged("strength", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeDefinitionalIngredient() { }
		public  MedicationKnowledgeDefinitionalIngredient(string value) : base(value) { }
		public  MedicationKnowledgeDefinitionalIngredient(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeDefinitionalDrugCharacteristic : BackboneElementType<MedicationKnowledgeDefinitionalDrugCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice? _value;

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

public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeDefinitionalDrugCharacteristic() { }
		public  MedicationKnowledgeDefinitionalDrugCharacteristic(string value) : base(value) { }
		public  MedicationKnowledgeDefinitionalDrugCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationKnowledgeDefinitional : BackboneElementType<MedicationKnowledgeDefinitional>, IBackboneElementType
	{

		#region Private Method
		private List<ReferenceType>? _definition;
private CodeableConcept? _doseForm;
private List<CodeableConcept>? _intendedRoute;
private List<MedicationKnowledgeDefinitionalIngredient>? _ingredient;
private List<MedicationKnowledgeDefinitionalDrugCharacteristic>? _drugCharacteristic;

		#endregion
		#region public Method
		public List<ReferenceType>? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public CodeableConcept? DoseForm
{
get { return _doseForm; }
set {
_doseForm= value;
OnPropertyChanged("doseForm", value);
}
}

public List<CodeableConcept>? IntendedRoute
{
get { return _intendedRoute; }
set {
_intendedRoute= value;
OnPropertyChanged("intendedRoute", value);
}
}

public List<MedicationKnowledgeDefinitionalIngredient>? Ingredient
{
get { return _ingredient; }
set {
_ingredient= value;
OnPropertyChanged("ingredient", value);
}
}

public List<MedicationKnowledgeDefinitionalDrugCharacteristic>? DrugCharacteristic
{
get { return _drugCharacteristic; }
set {
_drugCharacteristic= value;
OnPropertyChanged("drugCharacteristic", value);
}
}


		#endregion
		#region Constructor
		public  MedicationKnowledgeDefinitional() { }
		public  MedicationKnowledgeDefinitional(string value) : base(value) { }
		public  MedicationKnowledgeDefinitional(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MedicationKnowledgeCostCostChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Money","CodeableConcept"
        ];

        public MedicationKnowledgeCostCostChoice(JsonObject value) : base("cost", value, _supportType)
        {
        }
        public MedicationKnowledgeCostCostChoice(IComplexType? value) : base("cost", value)
        {
        }
        public MedicationKnowledgeCostCostChoice(IPrimitiveType? value) : base("cost", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"cost".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantityRange"
        ];

        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public MedicationKnowledgeIndicationGuidelineDosingGuidelinePatientCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MedicationKnowledgeMedicineClassificationSourceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","uri"
        ];

        public MedicationKnowledgeMedicineClassificationSourceChoice(JsonObject value) : base("source", value, _supportType)
        {
        }
        public MedicationKnowledgeMedicineClassificationSourceChoice(IComplexType? value) : base("source", value)
        {
        }
        public MedicationKnowledgeMedicineClassificationSourceChoice(IPrimitiveType? value) : base("source", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"source".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","RangeCodeableConcept"
        ];

        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public MedicationKnowledgeStorageGuidelineEnvironmentalSettingValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MedicationKnowledgeDefinitionalIngredientStrengthChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Ratio","CodeableConceptQuantity"
        ];

        public MedicationKnowledgeDefinitionalIngredientStrengthChoice(JsonObject value) : base("strength", value, _supportType)
        {
        }
        public MedicationKnowledgeDefinitionalIngredientStrengthChoice(IComplexType? value) : base("strength", value)
        {
        }
        public MedicationKnowledgeDefinitionalIngredientStrengthChoice(IPrimitiveType? value) : base("strength", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"strength".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","stringQuantity {SimpleQuantity}base64BinaryAttachment"
        ];

        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public MedicationKnowledgeDefinitionalDrugCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
