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
    public class DeviceDefinition : ResourceType<DeviceDefinition>
	{
		#region private Property
		private FhirMarkdown? _description;
private List<Identifier>? _identifier;
private List<DeviceDefinitionUdiDeviceIdentifier>? _udiDeviceIdentifier;
private List<DeviceDefinitionRegulatoryIdentifier>? _regulatoryIdentifier;
private FhirString? _partNumber;
private ReferenceType? _manufacturer;
private List<DeviceDefinitionDeviceName>? _deviceName;
private FhirString? _modelNumber;
private List<DeviceDefinitionClassification>? _classification;
private List<DeviceDefinitionConformsTo>? _conformsTo;
private List<DeviceDefinitionHasPart>? _hasPart;
private List<DeviceDefinitionPackaging>? _packaging;
private List<DeviceDefinitionVersion>? _version;
private List<CodeableConcept>? _safety;
private List<ProductShelfLife>? _shelfLifeStorage;
private List<CodeableConcept>? _languageCode;
private List<DeviceDefinitionProperty>? _property;
private ReferenceType? _owner;
private List<ContactPoint>? _contact;
private List<DeviceDefinitionLink>? _link;
private List<Annotation>? _note;
private List<DeviceDefinitionMaterial>? _material;
private List<FhirCode>? _productionIdentifierInUDI;
private DeviceDefinitionGuideline? _guideline;
private DeviceDefinitionCorrectiveAction? _correctiveAction;
private List<DeviceDefinitionChargeItem>? _chargeItem;

		#endregion
		#region Public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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

public List<DeviceDefinitionUdiDeviceIdentifier>? UdiDeviceIdentifier
{
get { return _udiDeviceIdentifier; }
set {
_udiDeviceIdentifier= value;
OnPropertyChanged("udiDeviceIdentifier", value);
}
}

public List<DeviceDefinitionRegulatoryIdentifier>? RegulatoryIdentifier
{
get { return _regulatoryIdentifier; }
set {
_regulatoryIdentifier= value;
OnPropertyChanged("regulatoryIdentifier", value);
}
}

public FhirString? PartNumber
{
get { return _partNumber; }
set {
_partNumber= value;
OnPropertyChanged("partNumber", value);
}
}

public ReferenceType? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
}
}

public List<DeviceDefinitionDeviceName>? DeviceName
{
get { return _deviceName; }
set {
_deviceName= value;
OnPropertyChanged("deviceName", value);
}
}

public FhirString? ModelNumber
{
get { return _modelNumber; }
set {
_modelNumber= value;
OnPropertyChanged("modelNumber", value);
}
}

public List<DeviceDefinitionClassification>? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
}
}

public List<DeviceDefinitionConformsTo>? ConformsTo
{
get { return _conformsTo; }
set {
_conformsTo= value;
OnPropertyChanged("conformsTo", value);
}
}

public List<DeviceDefinitionHasPart>? HasPart
{
get { return _hasPart; }
set {
_hasPart= value;
OnPropertyChanged("hasPart", value);
}
}

public List<DeviceDefinitionPackaging>? Packaging
{
get { return _packaging; }
set {
_packaging= value;
OnPropertyChanged("packaging", value);
}
}

public List<DeviceDefinitionVersion>? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public List<CodeableConcept>? Safety
{
get { return _safety; }
set {
_safety= value;
OnPropertyChanged("safety", value);
}
}

public List<ProductShelfLife>? ShelfLifeStorage
{
get { return _shelfLifeStorage; }
set {
_shelfLifeStorage= value;
OnPropertyChanged("shelfLifeStorage", value);
}
}

public List<CodeableConcept>? LanguageCode
{
get { return _languageCode; }
set {
_languageCode= value;
OnPropertyChanged("languageCode", value);
}
}

public List<DeviceDefinitionProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public ReferenceType? Owner
{
get { return _owner; }
set {
_owner= value;
OnPropertyChanged("owner", value);
}
}

public List<ContactPoint>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public List<DeviceDefinitionLink>? Link
{
get { return _link; }
set {
_link= value;
OnPropertyChanged("link", value);
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

public List<DeviceDefinitionMaterial>? Material
{
get { return _material; }
set {
_material= value;
OnPropertyChanged("material", value);
}
}

public List<FhirCode>? ProductionIdentifierInUDI
{
get { return _productionIdentifierInUDI; }
set {
_productionIdentifierInUDI= value;
OnPropertyChanged("productionIdentifierInUDI", value);
}
}

public DeviceDefinitionGuideline? Guideline
{
get { return _guideline; }
set {
_guideline= value;
OnPropertyChanged("guideline", value);
}
}

public DeviceDefinitionCorrectiveAction? CorrectiveAction
{
get { return _correctiveAction; }
set {
_correctiveAction= value;
OnPropertyChanged("correctiveAction", value);
}
}

public List<DeviceDefinitionChargeItem>? ChargeItem
{
get { return _chargeItem; }
set {
_chargeItem= value;
OnPropertyChanged("chargeItem", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinition() { }
		public  DeviceDefinition(string value) : base(value) { }
		public  DeviceDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceDefinitionUdiDeviceIdentifierMarketDistribution : BackboneElementType<DeviceDefinitionUdiDeviceIdentifierMarketDistribution>, IBackboneElementType
	{

		#region Private Method
		private Period? _marketPeriod;
private FhirUri? _subJurisdiction;

		#endregion
		#region public Method
		public Period? MarketPeriod
{
get { return _marketPeriod; }
set {
_marketPeriod= value;
OnPropertyChanged("marketPeriod", value);
}
}

public FhirUri? SubJurisdiction
{
get { return _subJurisdiction; }
set {
_subJurisdiction= value;
OnPropertyChanged("subJurisdiction", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionUdiDeviceIdentifierMarketDistribution() { }
		public  DeviceDefinitionUdiDeviceIdentifierMarketDistribution(string value) : base(value) { }
		public  DeviceDefinitionUdiDeviceIdentifierMarketDistribution(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionUdiDeviceIdentifier : BackboneElementType<DeviceDefinitionUdiDeviceIdentifier>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _deviceIdentifier;
private FhirUri? _issuer;
private FhirUri? _jurisdiction;
private List<DeviceDefinitionUdiDeviceIdentifierMarketDistribution>? _marketDistribution;

		#endregion
		#region public Method
		public FhirString? DeviceIdentifier
{
get { return _deviceIdentifier; }
set {
_deviceIdentifier= value;
OnPropertyChanged("deviceIdentifier", value);
}
}

public FhirUri? Issuer
{
get { return _issuer; }
set {
_issuer= value;
OnPropertyChanged("issuer", value);
}
}

public FhirUri? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public List<DeviceDefinitionUdiDeviceIdentifierMarketDistribution>? MarketDistribution
{
get { return _marketDistribution; }
set {
_marketDistribution= value;
OnPropertyChanged("marketDistribution", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionUdiDeviceIdentifier() { }
		public  DeviceDefinitionUdiDeviceIdentifier(string value) : base(value) { }
		public  DeviceDefinitionUdiDeviceIdentifier(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionRegulatoryIdentifier : BackboneElementType<DeviceDefinitionRegulatoryIdentifier>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirString? _deviceIdentifier;
private FhirUri? _issuer;
private FhirUri? _jurisdiction;

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

public FhirString? DeviceIdentifier
{
get { return _deviceIdentifier; }
set {
_deviceIdentifier= value;
OnPropertyChanged("deviceIdentifier", value);
}
}

public FhirUri? Issuer
{
get { return _issuer; }
set {
_issuer= value;
OnPropertyChanged("issuer", value);
}
}

public FhirUri? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionRegulatoryIdentifier() { }
		public  DeviceDefinitionRegulatoryIdentifier(string value) : base(value) { }
		public  DeviceDefinitionRegulatoryIdentifier(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionDeviceName : BackboneElementType<DeviceDefinitionDeviceName>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private FhirCode? _type;

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
		public  DeviceDefinitionDeviceName() { }
		public  DeviceDefinitionDeviceName(string value) : base(value) { }
		public  DeviceDefinitionDeviceName(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionClassification : BackboneElementType<DeviceDefinitionClassification>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<RelatedArtifact>? _justification;

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

public List<RelatedArtifact>? Justification
{
get { return _justification; }
set {
_justification= value;
OnPropertyChanged("justification", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionClassification() { }
		public  DeviceDefinitionClassification(string value) : base(value) { }
		public  DeviceDefinitionClassification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionConformsTo : BackboneElementType<DeviceDefinitionConformsTo>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _specification;
private List<FhirString>? _version;
private List<RelatedArtifact>? _source;

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

public CodeableConcept? Specification
{
get { return _specification; }
set {
_specification= value;
OnPropertyChanged("specification", value);
}
}

public List<FhirString>? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public List<RelatedArtifact>? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionConformsTo() { }
		public  DeviceDefinitionConformsTo(string value) : base(value) { }
		public  DeviceDefinitionConformsTo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionHasPart : BackboneElementType<DeviceDefinitionHasPart>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _reference;
private FhirInteger? _count;

		#endregion
		#region public Method
		public ReferenceType? Reference
{
get { return _reference; }
set {
_reference= value;
OnPropertyChanged("reference", value);
}
}

public FhirInteger? Count
{
get { return _count; }
set {
_count= value;
OnPropertyChanged("count", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionHasPart() { }
		public  DeviceDefinitionHasPart(string value) : base(value) { }
		public  DeviceDefinitionHasPart(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionPackagingDistributor : BackboneElementType<DeviceDefinitionPackagingDistributor>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _name;
private List<ReferenceType>? _organizationReference;

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

public List<ReferenceType>? OrganizationReference
{
get { return _organizationReference; }
set {
_organizationReference= value;
OnPropertyChanged("organizationReference", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionPackagingDistributor() { }
		public  DeviceDefinitionPackagingDistributor(string value) : base(value) { }
		public  DeviceDefinitionPackagingDistributor(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionPackaging : BackboneElementType<DeviceDefinitionPackaging>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _identifier;
private CodeableConcept? _type;
private FhirInteger? _count;
private List<DeviceDefinitionPackagingDistributor>? _distributor;

		#endregion
		#region public Method
		public Identifier? Identifier
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

public FhirInteger? Count
{
get { return _count; }
set {
_count= value;
OnPropertyChanged("count", value);
}
}

public List<DeviceDefinitionPackagingDistributor>? Distributor
{
get { return _distributor; }
set {
_distributor= value;
OnPropertyChanged("distributor", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionPackaging() { }
		public  DeviceDefinitionPackaging(string value) : base(value) { }
		public  DeviceDefinitionPackaging(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionVersion : BackboneElementType<DeviceDefinitionVersion>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private Identifier? _component;
private FhirString? _value;

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

public Identifier? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
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
		public  DeviceDefinitionVersion() { }
		public  DeviceDefinitionVersion(string value) : base(value) { }
		public  DeviceDefinitionVersion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionProperty : BackboneElementType<DeviceDefinitionProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private DeviceDefinitionPropertyValueChoice? _value;

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

public DeviceDefinitionPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionProperty() { }
		public  DeviceDefinitionProperty(string value) : base(value) { }
		public  DeviceDefinitionProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionLink : BackboneElementType<DeviceDefinitionLink>, IBackboneElementType
	{

		#region Private Method
		private Coding? _relation;
private CodeableReference? _relatedDevice;

		#endregion
		#region public Method
		public Coding? Relation
{
get { return _relation; }
set {
_relation= value;
OnPropertyChanged("relation", value);
}
}

public CodeableReference? RelatedDevice
{
get { return _relatedDevice; }
set {
_relatedDevice= value;
OnPropertyChanged("relatedDevice", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionLink() { }
		public  DeviceDefinitionLink(string value) : base(value) { }
		public  DeviceDefinitionLink(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionMaterial : BackboneElementType<DeviceDefinitionMaterial>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _substance;
private FhirBoolean? _alternate;
private FhirBoolean? _allergenicIndicator;

		#endregion
		#region public Method
		public CodeableConcept? Substance
{
get { return _substance; }
set {
_substance= value;
OnPropertyChanged("substance", value);
}
}

public FhirBoolean? Alternate
{
get { return _alternate; }
set {
_alternate= value;
OnPropertyChanged("alternate", value);
}
}

public FhirBoolean? AllergenicIndicator
{
get { return _allergenicIndicator; }
set {
_allergenicIndicator= value;
OnPropertyChanged("allergenicIndicator", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionMaterial() { }
		public  DeviceDefinitionMaterial(string value) : base(value) { }
		public  DeviceDefinitionMaterial(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionGuideline : BackboneElementType<DeviceDefinitionGuideline>, IBackboneElementType
	{

		#region Private Method
		private List<UsageContext>? _useContext;
private FhirMarkdown? _usageInstruction;
private List<RelatedArtifact>? _relatedArtifact;
private List<CodeableConcept>? _indication;
private List<CodeableConcept>? _contraindication;
private List<CodeableConcept>? _warning;
private FhirString? _intendedUse;

		#endregion
		#region public Method
		public List<UsageContext>? UseContext
{
get { return _useContext; }
set {
_useContext= value;
OnPropertyChanged("useContext", value);
}
}

public FhirMarkdown? UsageInstruction
{
get { return _usageInstruction; }
set {
_usageInstruction= value;
OnPropertyChanged("usageInstruction", value);
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

public List<CodeableConcept>? Indication
{
get { return _indication; }
set {
_indication= value;
OnPropertyChanged("indication", value);
}
}

public List<CodeableConcept>? Contraindication
{
get { return _contraindication; }
set {
_contraindication= value;
OnPropertyChanged("contraindication", value);
}
}

public List<CodeableConcept>? Warning
{
get { return _warning; }
set {
_warning= value;
OnPropertyChanged("warning", value);
}
}

public FhirString? IntendedUse
{
get { return _intendedUse; }
set {
_intendedUse= value;
OnPropertyChanged("intendedUse", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionGuideline() { }
		public  DeviceDefinitionGuideline(string value) : base(value) { }
		public  DeviceDefinitionGuideline(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionCorrectiveAction : BackboneElementType<DeviceDefinitionCorrectiveAction>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _recall;
private FhirCode? _scope;
private Period? _period;

		#endregion
		#region public Method
		public FhirBoolean? Recall
{
get { return _recall; }
set {
_recall= value;
OnPropertyChanged("recall", value);
}
}

public FhirCode? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionCorrectiveAction() { }
		public  DeviceDefinitionCorrectiveAction(string value) : base(value) { }
		public  DeviceDefinitionCorrectiveAction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceDefinitionChargeItem : BackboneElementType<DeviceDefinitionChargeItem>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _chargeItemCode;
private Quantity? _count;
private Period? _effectivePeriod;
private List<UsageContext>? _useContext;

		#endregion
		#region public Method
		public CodeableReference? ChargeItemCode
{
get { return _chargeItemCode; }
set {
_chargeItemCode= value;
OnPropertyChanged("chargeItemCode", value);
}
}

public Quantity? Count
{
get { return _count; }
set {
_count= value;
OnPropertyChanged("count", value);
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

public List<UsageContext>? UseContext
{
get { return _useContext; }
set {
_useContext= value;
OnPropertyChanged("useContext", value);
}
}


		#endregion
		#region Constructor
		public  DeviceDefinitionChargeItem() { }
		public  DeviceDefinitionChargeItem(string value) : base(value) { }
		public  DeviceDefinitionChargeItem(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DeviceDefinitionPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","CodeableConceptstringbooleanintegerRangeAttachment"
        ];

        public DeviceDefinitionPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public DeviceDefinitionPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public DeviceDefinitionPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
