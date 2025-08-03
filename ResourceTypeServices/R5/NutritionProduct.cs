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
    public class NutritionProduct : ResourceType<NutritionProduct>
	{
		#region private Property
		private CodeableConcept? _code;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private List<ReferenceType>? _manufacturer;
private List<NutritionProductNutrient>? _nutrient;
private List<NutritionProductIngredient>? _ingredient;
private List<CodeableReference>? _knownAllergen;
private List<NutritionProductCharacteristic>? _characteristic;
private List<NutritionProductInstance>? _instance;
private List<Annotation>? _note;

		#endregion
		#region Public Method
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public List<NutritionProductNutrient>? Nutrient
{
get { return _nutrient; }
set {
_nutrient= value;
OnPropertyChanged("nutrient", value);
}
}

public List<NutritionProductIngredient>? Ingredient
{
get { return _ingredient; }
set {
_ingredient= value;
OnPropertyChanged("ingredient", value);
}
}

public List<CodeableReference>? KnownAllergen
{
get { return _knownAllergen; }
set {
_knownAllergen= value;
OnPropertyChanged("knownAllergen", value);
}
}

public List<NutritionProductCharacteristic>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}

public List<NutritionProductInstance>? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
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


		#endregion
		#region Constructor
		public  NutritionProduct() { }
		public  NutritionProduct(string value) : base(value) { }
		public  NutritionProduct(JsonNode? source) : base(source) { }
		#endregion
	}
		public class NutritionProductNutrient : BackboneElementType<NutritionProductNutrient>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _item;
private List<Ratio>? _amount;

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

public List<Ratio>? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}


		#endregion
		#region Constructor
		public  NutritionProductNutrient() { }
		public  NutritionProductNutrient(string value) : base(value) { }
		public  NutritionProductNutrient(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionProductIngredient : BackboneElementType<NutritionProductIngredient>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _item;
private List<Ratio>? _amount;

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

public List<Ratio>? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}


		#endregion
		#region Constructor
		public  NutritionProductIngredient() { }
		public  NutritionProductIngredient(string value) : base(value) { }
		public  NutritionProductIngredient(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionProductCharacteristic : BackboneElementType<NutritionProductCharacteristic>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private NutritionProductCharacteristicValueChoice? _value;

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

public NutritionProductCharacteristicValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  NutritionProductCharacteristic() { }
		public  NutritionProductCharacteristic(string value) : base(value) { }
		public  NutritionProductCharacteristic(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionProductInstance : BackboneElementType<NutritionProductInstance>, IBackboneElementType
	{

		#region Private Method
		private Quantity? _quantity;
private List<Identifier>? _identifier;
private FhirString? _name;
private FhirString? _lotNumber;
private FhirDateTime? _expiry;
private FhirDateTime? _useBy;
private Identifier? _biologicalSourceEvent;

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

public FhirDateTime? UseBy
{
get { return _useBy; }
set {
_useBy= value;
OnPropertyChanged("useBy", value);
}
}

public Identifier? BiologicalSourceEvent
{
get { return _biologicalSourceEvent; }
set {
_biologicalSourceEvent= value;
OnPropertyChanged("biologicalSourceEvent", value);
}
}


		#endregion
		#region Constructor
		public  NutritionProductInstance() { }
		public  NutritionProductInstance(string value) : base(value) { }
		public  NutritionProductInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class NutritionProductCharacteristicValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","stringQuantity {SimpleQuantity}base64BinaryAttachmentboolean"
        ];

        public NutritionProductCharacteristicValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public NutritionProductCharacteristicValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public NutritionProductCharacteristicValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
