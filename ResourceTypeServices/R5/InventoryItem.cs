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
    public class InventoryItem : ResourceType<InventoryItem>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private List<CodeableConcept>? _code;
private List<InventoryItemName>? _name;
private List<InventoryItemResponsibleOrganization>? _responsibleOrganization;
private InventoryItemDescription? _description;
private List<CodeableConcept>? _inventoryStatus;
private CodeableConcept? _baseUnit;
private Quantity? _netContent;
private List<InventoryItemAssociation>? _association;
private List<InventoryItemCharacteristic>? _characteristic;
private InventoryItemInstance? _instance;
private ReferenceType? _productReference;

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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
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

public List<CodeableConcept>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<InventoryItemName>? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<InventoryItemResponsibleOrganization>? ResponsibleOrganization
{
get { return _responsibleOrganization; }
set {
_responsibleOrganization= value;
OnPropertyChanged("responsibleOrganization", value);
}
}

public InventoryItemDescription? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<CodeableConcept>? InventoryStatus
{
get { return _inventoryStatus; }
set {
_inventoryStatus= value;
OnPropertyChanged("inventoryStatus", value);
}
}

public CodeableConcept? BaseUnit
{
get { return _baseUnit; }
set {
_baseUnit= value;
OnPropertyChanged("baseUnit", value);
}
}

public Quantity? NetContent
{
get { return _netContent; }
set {
_netContent= value;
OnPropertyChanged("netContent", value);
}
}

public List<InventoryItemAssociation>? Association
{
get { return _association; }
set {
_association= value;
OnPropertyChanged("association", value);
}
}

public List<InventoryItemCharacteristic>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}

public InventoryItemInstance? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}

public ReferenceType? ProductReference
{
get { return _productReference; }
set {
_productReference= value;
OnPropertyChanged("productReference", value);
}
}


		#endregion
		#region Constructor
		public  InventoryItem() { }
		public  InventoryItem(string value) : base(value) { }
		public  InventoryItem(JsonNode? source) : base(source) { }
		#endregion
	}
		public class InventoryItemName : BackboneElementType<InventoryItemName>, IBackboneElementType
	{

		#region Private Method
		private Coding? _nameType;
private FhirCode? _language;
private FhirString? _name;

		#endregion
		#region public Method
		public Coding? NameType
{
get { return _nameType; }
set {
_nameType= value;
OnPropertyChanged("nameType", value);
}
}

public FhirCode? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
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
		public  InventoryItemName() { }
		public  InventoryItemName(string value) : base(value) { }
		public  InventoryItemName(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InventoryItemResponsibleOrganization : BackboneElementType<InventoryItemResponsibleOrganization>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _role;
private ReferenceType? _organization;

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

public ReferenceType? Organization
{
get { return _organization; }
set {
_organization= value;
OnPropertyChanged("organization", value);
}
}


		#endregion
		#region Constructor
		public  InventoryItemResponsibleOrganization() { }
		public  InventoryItemResponsibleOrganization(string value) : base(value) { }
		public  InventoryItemResponsibleOrganization(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InventoryItemDescription : BackboneElementType<InventoryItemDescription>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _language;
private FhirString? _description;

		#endregion
		#region public Method
		public FhirCode? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}


		#endregion
		#region Constructor
		public  InventoryItemDescription() { }
		public  InventoryItemDescription(string value) : base(value) { }
		public  InventoryItemDescription(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InventoryItemAssociation : BackboneElementType<InventoryItemAssociation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _associationType;
private ReferenceType? _relatedItem;
private Ratio? _quantity;

		#endregion
		#region public Method
		public CodeableConcept? AssociationType
{
get { return _associationType; }
set {
_associationType= value;
OnPropertyChanged("associationType", value);
}
}

public ReferenceType? RelatedItem
{
get { return _relatedItem; }
set {
_relatedItem= value;
OnPropertyChanged("relatedItem", value);
}
}

public Ratio? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}


		#endregion
		#region Constructor
		public  InventoryItemAssociation() { }
		public  InventoryItemAssociation(string value) : base(value) { }
		public  InventoryItemAssociation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InventoryItemCharacteristic : BackboneElementType<InventoryItemCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _characteristicType;
private InventoryItemCharacteristicValueChoice? _value;

		#endregion
		#region public Method
		public CodeableConcept? CharacteristicType
{
get { return _characteristicType; }
set {
_characteristicType= value;
OnPropertyChanged("characteristicType", value);
}
}

public InventoryItemCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  InventoryItemCharacteristic() { }
		public  InventoryItemCharacteristic(string value) : base(value) { }
		public  InventoryItemCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class InventoryItemInstance : BackboneElementType<InventoryItemInstance>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private FhirString? _lotNumber;
private FhirDateTime? _expiry;
private ReferenceType? _subject;
private ReferenceType? _location;

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

public FhirString? LotNumber
{
get { return _lotNumber; }
set {
_lotNumber= value;
OnPropertyChanged("lotNumber", value);
}
}

public FhirDateTime? Expiry
{
get { return _expiry; }
set {
_expiry= value;
OnPropertyChanged("expiry", value);
}
}

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}


		#endregion
		#region Constructor
		public  InventoryItemInstance() { }
		public  InventoryItemInstance(string value) : base(value) { }
		public  InventoryItemInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class InventoryItemCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","integerdecimalbooleanurldateTimeQuantityRangeRatioAnnotationAddressDurationCodeableConcept"
        ];

        public InventoryItemCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public InventoryItemCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public InventoryItemCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
