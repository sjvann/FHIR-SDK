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
    public class MedicinalProductDefinition : ResourceType<MedicinalProductDefinition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _type;
private CodeableConcept? _domain;
private FhirString? _version;
private CodeableConcept? _status;
private FhirDateTime? _statusDate;
private FhirMarkdown? _description;
private CodeableConcept? _combinedPharmaceuticalDoseForm;
private List<CodeableConcept>? _route;
private FhirMarkdown? _indication;
private CodeableConcept? _legalStatusOfSupply;
private CodeableConcept? _additionalMonitoringIndicator;
private List<CodeableConcept>? _specialMeasures;
private CodeableConcept? _pediatricUseIndicator;
private List<CodeableConcept>? _classification;
private List<MarketingStatus>? _marketingStatus;
private List<CodeableConcept>? _packagedMedicinalProduct;
private List<ReferenceType>? _comprisedOf;
private List<CodeableConcept>? _ingredient;
private List<CodeableReference>? _impurity;
private List<ReferenceType>? _attachedDocument;
private List<ReferenceType>? _masterFile;
private List<MedicinalProductDefinitionContact>? _contact;
private List<ReferenceType>? _clinicalTrial;
private List<Coding>? _code;
private List<MedicinalProductDefinitionName>? _name;
private List<MedicinalProductDefinitionCrossReference>? _crossReference;
private List<MedicinalProductDefinitionOperation>? _operation;
private List<MedicinalProductDefinitionCharacteristic>? _characteristic;

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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? Domain
{
get { return _domain; }
set {
_domain= value;
OnPropertyChanged("domain", value);
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

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirDateTime? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
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

public CodeableConcept? CombinedPharmaceuticalDoseForm
{
get { return _combinedPharmaceuticalDoseForm; }
set {
_combinedPharmaceuticalDoseForm= value;
OnPropertyChanged("combinedPharmaceuticalDoseForm", value);
}
}

public List<CodeableConcept>? Route
{
get { return _route; }
set {
_route= value;
OnPropertyChanged("route", value);
}
}

public FhirMarkdown? Indication
{
get { return _indication; }
set {
_indication= value;
OnPropertyChanged("indication", value);
}
}

public CodeableConcept? LegalStatusOfSupply
{
get { return _legalStatusOfSupply; }
set {
_legalStatusOfSupply= value;
OnPropertyChanged("legalStatusOfSupply", value);
}
}

public CodeableConcept? AdditionalMonitoringIndicator
{
get { return _additionalMonitoringIndicator; }
set {
_additionalMonitoringIndicator= value;
OnPropertyChanged("additionalMonitoringIndicator", value);
}
}

public List<CodeableConcept>? SpecialMeasures
{
get { return _specialMeasures; }
set {
_specialMeasures= value;
OnPropertyChanged("specialMeasures", value);
}
}

public CodeableConcept? PediatricUseIndicator
{
get { return _pediatricUseIndicator; }
set {
_pediatricUseIndicator= value;
OnPropertyChanged("pediatricUseIndicator", value);
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

public List<MarketingStatus>? MarketingStatus
{
get { return _marketingStatus; }
set {
_marketingStatus= value;
OnPropertyChanged("marketingStatus", value);
}
}

public List<CodeableConcept>? PackagedMedicinalProduct
{
get { return _packagedMedicinalProduct; }
set {
_packagedMedicinalProduct= value;
OnPropertyChanged("packagedMedicinalProduct", value);
}
}

public List<ReferenceType>? ComprisedOf
{
get { return _comprisedOf; }
set {
_comprisedOf= value;
OnPropertyChanged("comprisedOf", value);
}
}

public List<CodeableConcept>? Ingredient
{
get { return _ingredient; }
set {
_ingredient= value;
OnPropertyChanged("ingredient", value);
}
}

public List<CodeableReference>? Impurity
{
get { return _impurity; }
set {
_impurity= value;
OnPropertyChanged("impurity", value);
}
}

public List<ReferenceType>? AttachedDocument
{
get { return _attachedDocument; }
set {
_attachedDocument= value;
OnPropertyChanged("attachedDocument", value);
}
}

public List<ReferenceType>? MasterFile
{
get { return _masterFile; }
set {
_masterFile= value;
OnPropertyChanged("masterFile", value);
}
}

public List<MedicinalProductDefinitionContact>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public List<ReferenceType>? ClinicalTrial
{
get { return _clinicalTrial; }
set {
_clinicalTrial= value;
OnPropertyChanged("clinicalTrial", value);
}
}

public List<Coding>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<MedicinalProductDefinitionName>? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<MedicinalProductDefinitionCrossReference>? CrossReference
{
get { return _crossReference; }
set {
_crossReference= value;
OnPropertyChanged("crossReference", value);
}
}

public List<MedicinalProductDefinitionOperation>? Operation
{
get { return _operation; }
set {
_operation= value;
OnPropertyChanged("operation", value);
}
}

public List<MedicinalProductDefinitionCharacteristic>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}


		#endregion
		#region Constructor
		public  MedicinalProductDefinition() { }
		public  MedicinalProductDefinition(string value) : base(value) { }
		public  MedicinalProductDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicinalProductDefinitionContact : BackboneElementType<MedicinalProductDefinitionContact>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ReferenceType? _contact;

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

public ReferenceType? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionContact() { }
		public  MedicinalProductDefinitionContact(string value) : base(value) { }
		public  MedicinalProductDefinitionContact(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicinalProductDefinitionNamePart : BackboneElementType<MedicinalProductDefinitionNamePart>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _part;
private CodeableConcept? _type;

		#endregion
		#region public Method
		public FhirString? Part
{
get { return _part; }
set {
_part= value;
OnPropertyChanged("part", value);
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


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionNamePart() { }
		public  MedicinalProductDefinitionNamePart(string value) : base(value) { }
		public  MedicinalProductDefinitionNamePart(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicinalProductDefinitionNameUsage : BackboneElementType<MedicinalProductDefinitionNameUsage>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _country;
private CodeableConcept? _jurisdiction;
private CodeableConcept? _language;

		#endregion
		#region public Method
		public CodeableConcept? Country
{
get { return _country; }
set {
_country= value;
OnPropertyChanged("country", value);
}
}

public CodeableConcept? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public CodeableConcept? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionNameUsage() { }
		public  MedicinalProductDefinitionNameUsage(string value) : base(value) { }
		public  MedicinalProductDefinitionNameUsage(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicinalProductDefinitionName : BackboneElementType<MedicinalProductDefinitionName>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _productName;
private CodeableConcept? _type;
private List<MedicinalProductDefinitionNamePart>? _part;
private List<MedicinalProductDefinitionNameUsage>? _usage;

		#endregion
		#region public Method
		public FhirString? ProductName
{
get { return _productName; }
set {
_productName= value;
OnPropertyChanged("productName", value);
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

public List<MedicinalProductDefinitionNamePart>? Part
{
get { return _part; }
set {
_part= value;
OnPropertyChanged("part", value);
}
}

public List<MedicinalProductDefinitionNameUsage>? Usage
{
get { return _usage; }
set {
_usage= value;
OnPropertyChanged("usage", value);
}
}


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionName() { }
		public  MedicinalProductDefinitionName(string value) : base(value) { }
		public  MedicinalProductDefinitionName(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicinalProductDefinitionCrossReference : BackboneElementType<MedicinalProductDefinitionCrossReference>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _product;
private CodeableConcept? _type;

		#endregion
		#region public Method
		public CodeableReference? Product
{
get { return _product; }
set {
_product= value;
OnPropertyChanged("product", value);
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


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionCrossReference() { }
		public  MedicinalProductDefinitionCrossReference(string value) : base(value) { }
		public  MedicinalProductDefinitionCrossReference(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicinalProductDefinitionOperation : BackboneElementType<MedicinalProductDefinitionOperation>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _type;
private Period? _effectiveDate;
private List<ReferenceType>? _organization;
private CodeableConcept? _confidentialityIndicator;

		#endregion
		#region public Method
		public CodeableReference? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public Period? EffectiveDate
{
get { return _effectiveDate; }
set {
_effectiveDate= value;
OnPropertyChanged("effectiveDate", value);
}
}

public List<ReferenceType>? Organization
{
get { return _organization; }
set {
_organization= value;
OnPropertyChanged("organization", value);
}
}

public CodeableConcept? ConfidentialityIndicator
{
get { return _confidentialityIndicator; }
set {
_confidentialityIndicator= value;
OnPropertyChanged("confidentialityIndicator", value);
}
}


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionOperation() { }
		public  MedicinalProductDefinitionOperation(string value) : base(value) { }
		public  MedicinalProductDefinitionOperation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicinalProductDefinitionCharacteristic : BackboneElementType<MedicinalProductDefinitionCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private MedicinalProductDefinitionCharacteristicValueChoice? _value;

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

public MedicinalProductDefinitionCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  MedicinalProductDefinitionCharacteristic() { }
		public  MedicinalProductDefinitionCharacteristic(string value) : base(value) { }
		public  MedicinalProductDefinitionCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MedicinalProductDefinitionCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","markdownQuantityintegerdatebooleanAttachment"
        ];

        public MedicinalProductDefinitionCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public MedicinalProductDefinitionCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public MedicinalProductDefinitionCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
