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
    public class PackagedProductDefinition : ResourceType<PackagedProductDefinition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirString? _name;
private CodeableConcept? _type;
private List<ReferenceType>? _packageFor;
private CodeableConcept? _status;
private FhirDateTime? _statusDate;
private List<Quantity>? _containedItemQuantity;
private FhirMarkdown? _description;
private List<PackagedProductDefinitionLegalStatusOfSupply>? _legalStatusOfSupply;
private List<MarketingStatus>? _marketingStatus;
private FhirBoolean? _copackagedIndicator;
private List<ReferenceType>? _manufacturer;
private List<ReferenceType>? _attachedDocument;
private PackagedProductDefinitionPackaging? _packaging;

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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
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

public List<ReferenceType>? PackageFor
{
get { return _packageFor; }
set {
_packageFor= value;
OnPropertyChanged("packageFor", value);
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

public List<Quantity>? ContainedItemQuantity
{
get { return _containedItemQuantity; }
set {
_containedItemQuantity= value;
OnPropertyChanged("containedItemQuantity", value);
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

public List<PackagedProductDefinitionLegalStatusOfSupply>? LegalStatusOfSupply
{
get { return _legalStatusOfSupply; }
set {
_legalStatusOfSupply= value;
OnPropertyChanged("legalStatusOfSupply", value);
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

public FhirBoolean? CopackagedIndicator
{
get { return _copackagedIndicator; }
set {
_copackagedIndicator= value;
OnPropertyChanged("copackagedIndicator", value);
}
}

public List<ReferenceType>? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
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

public PackagedProductDefinitionPackaging? Packaging
{
get { return _packaging; }
set {
_packaging= value;
OnPropertyChanged("packaging", value);
}
}


		#endregion
		#region Constructor
		public  PackagedProductDefinition() { }
		public  PackagedProductDefinition(string value) : base(value) { }
		public  PackagedProductDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class PackagedProductDefinitionLegalStatusOfSupply : BackboneElementType<PackagedProductDefinitionLegalStatusOfSupply>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private CodeableConcept? _jurisdiction;

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

public CodeableConcept? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}


		#endregion
		#region Constructor
		public  PackagedProductDefinitionLegalStatusOfSupply() { }
		public  PackagedProductDefinitionLegalStatusOfSupply(string value) : base(value) { }
		public  PackagedProductDefinitionLegalStatusOfSupply(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PackagedProductDefinitionPackagingProperty : BackboneElementType<PackagedProductDefinitionPackagingProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private PackagedProductDefinitionPackagingPropertyValueChoice? _value;

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

public PackagedProductDefinitionPackagingPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  PackagedProductDefinitionPackagingProperty() { }
		public  PackagedProductDefinitionPackagingProperty(string value) : base(value) { }
		public  PackagedProductDefinitionPackagingProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PackagedProductDefinitionPackagingContainedItem : BackboneElementType<PackagedProductDefinitionPackagingContainedItem>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _item;
private Quantity? _amount;

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

public Quantity? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}


		#endregion
		#region Constructor
		public  PackagedProductDefinitionPackagingContainedItem() { }
		public  PackagedProductDefinitionPackagingContainedItem(string value) : base(value) { }
		public  PackagedProductDefinitionPackagingContainedItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PackagedProductDefinitionPackaging : BackboneElementType<PackagedProductDefinitionPackaging>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private CodeableConcept? _type;
private FhirBoolean? _componentPart;
private FhirInteger? _quantity;
private List<CodeableConcept>? _material;
private List<CodeableConcept>? _alternateMaterial;
private List<ProductShelfLife>? _shelfLifeStorage;
private List<ReferenceType>? _manufacturer;
private List<PackagedProductDefinitionPackagingProperty>? _property;
private List<PackagedProductDefinitionPackagingContainedItem>? _containedItem;

		#endregion
		#region public Method
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

public FhirBoolean? ComponentPart
{
get { return _componentPart; }
set {
_componentPart= value;
OnPropertyChanged("componentPart", value);
}
}

public FhirInteger? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public List<CodeableConcept>? Material
{
get { return _material; }
set {
_material= value;
OnPropertyChanged("material", value);
}
}

public List<CodeableConcept>? AlternateMaterial
{
get { return _alternateMaterial; }
set {
_alternateMaterial= value;
OnPropertyChanged("alternateMaterial", value);
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

public List<ReferenceType>? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
}
}

public List<PackagedProductDefinitionPackagingProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<PackagedProductDefinitionPackagingContainedItem>? ContainedItem
{
get { return _containedItem; }
set {
_containedItem= value;
OnPropertyChanged("containedItem", value);
}
}


		#endregion
		#region Constructor
		public  PackagedProductDefinitionPackaging() { }
		public  PackagedProductDefinitionPackaging(string value) : base(value) { }
		public  PackagedProductDefinitionPackaging(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class PackagedProductDefinitionPackagingPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantitydatebooleanAttachment"
        ];

        public PackagedProductDefinitionPackagingPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public PackagedProductDefinitionPackagingPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public PackagedProductDefinitionPackagingPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
