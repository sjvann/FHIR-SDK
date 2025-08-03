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
    public class ManufacturedItemDefinition : ResourceType<ManufacturedItemDefinition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirString? _name;
private CodeableConcept? _manufacturedDoseForm;
private CodeableConcept? _unitOfPresentation;
private List<ReferenceType>? _manufacturer;
private List<MarketingStatus>? _marketingStatus;
private List<CodeableConcept>? _ingredient;
private List<ManufacturedItemDefinitionProperty>? _property;
private List<ManufacturedItemDefinitionComponent>? _component;

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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public CodeableConcept? ManufacturedDoseForm
{
get { return _manufacturedDoseForm; }
set {
_manufacturedDoseForm= value;
OnPropertyChanged("manufacturedDoseForm", value);
}
}

public CodeableConcept? UnitOfPresentation
{
get { return _unitOfPresentation; }
set {
_unitOfPresentation= value;
OnPropertyChanged("unitOfPresentation", value);
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

public List<MarketingStatus>? MarketingStatus
{
get { return _marketingStatus; }
set {
_marketingStatus= value;
OnPropertyChanged("marketingStatus", value);
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

public List<ManufacturedItemDefinitionProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public List<ManufacturedItemDefinitionComponent>? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}


		#endregion
		#region Constructor
		public  ManufacturedItemDefinition() { }
		public  ManufacturedItemDefinition(string value) : base(value) { }
		public  ManufacturedItemDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ManufacturedItemDefinitionProperty : BackboneElementType<ManufacturedItemDefinitionProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private ManufacturedItemDefinitionPropertyValueChoice? _value;

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

public ManufacturedItemDefinitionPropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  ManufacturedItemDefinitionProperty() { }
		public  ManufacturedItemDefinitionProperty(string value) : base(value) { }
		public  ManufacturedItemDefinitionProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ManufacturedItemDefinitionComponentConstituent : BackboneElementType<ManufacturedItemDefinitionComponentConstituent>, IBackboneElementType
	{

		#region Private Method
		private List<Quantity>? _amount;
private List<CodeableConcept>? _location;
private List<CodeableConcept>? _function;
private List<CodeableReference>? _hasIngredient;

		#endregion
		#region public Method
		public List<Quantity>? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public List<CodeableConcept>? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public List<CodeableConcept>? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public List<CodeableReference>? HasIngredient
{
get { return _hasIngredient; }
set {
_hasIngredient= value;
OnPropertyChanged("hasIngredient", value);
}
}


		#endregion
		#region Constructor
		public  ManufacturedItemDefinitionComponentConstituent() { }
		public  ManufacturedItemDefinitionComponentConstituent(string value) : base(value) { }
		public  ManufacturedItemDefinitionComponentConstituent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ManufacturedItemDefinitionComponent : BackboneElementType<ManufacturedItemDefinitionComponent>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private List<CodeableConcept>? _function;
private List<Quantity>? _amount;
private List<ManufacturedItemDefinitionComponentConstituent>? _constituent;

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

public List<CodeableConcept>? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public List<Quantity>? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public List<ManufacturedItemDefinitionComponentConstituent>? Constituent
{
get { return _constituent; }
set {
_constituent= value;
OnPropertyChanged("constituent", value);
}
}


		#endregion
		#region Constructor
		public  ManufacturedItemDefinitionComponent() { }
		public  ManufacturedItemDefinitionComponent(string value) : base(value) { }
		public  ManufacturedItemDefinitionComponent(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ManufacturedItemDefinitionPropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","QuantitydatebooleanmarkdownAttachmentReference(Binary)"
        ];

        public ManufacturedItemDefinitionPropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public ManufacturedItemDefinitionPropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public ManufacturedItemDefinitionPropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
