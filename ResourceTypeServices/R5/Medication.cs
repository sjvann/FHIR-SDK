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
    public class Medication : ResourceType<Medication>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _code;
private FhirCode? _status;
private ReferenceType? _marketingAuthorizationHolder;
private CodeableConcept? _doseForm;
private Quantity? _totalVolume;
private List<MedicationIngredient>? _ingredient;
private MedicationBatch? _batch;
private ReferenceType? _definition;

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

public ReferenceType? MarketingAuthorizationHolder
{
get { return _marketingAuthorizationHolder; }
set {
_marketingAuthorizationHolder= value;
OnPropertyChanged("marketingAuthorizationHolder", value);
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

public Quantity? TotalVolume
{
get { return _totalVolume; }
set {
_totalVolume= value;
OnPropertyChanged("totalVolume", value);
}
}

public List<MedicationIngredient>? Ingredient
{
get { return _ingredient; }
set {
_ingredient= value;
OnPropertyChanged("ingredient", value);
}
}

public MedicationBatch? Batch
{
get { return _batch; }
set {
_batch= value;
OnPropertyChanged("batch", value);
}
}

public ReferenceType? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}


		#endregion
		#region Constructor
		public  Medication() { }
		public  Medication(string value) : base(value) { }
		public  Medication(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicationIngredient : BackboneElementType<MedicationIngredient>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _item;
private FhirBoolean? _isActive;
private MedicationIngredientStrengthChoice? _strength;

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

public FhirBoolean? IsActive
{
get { return _isActive; }
set {
_isActive= value;
OnPropertyChanged("isActive", value);
}
}

public MedicationIngredientStrengthChoice? Strength
{
get { return _strength; }
set {
_strength= value;
OnPropertyChanged("strength", value);
}
}


		#endregion
		#region Constructor
		public  MedicationIngredient() { }
		public  MedicationIngredient(string value) : base(value) { }
		public  MedicationIngredient(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationBatch : BackboneElementType<MedicationBatch>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _lotNumber;
private FhirDateTime? _expirationDate;

		#endregion
		#region public Method
		public FhirString? LotNumber
{
get { return _lotNumber; }
set {
_lotNumber= value;
OnPropertyChanged("lotNumber", value);
}
}

public FhirDateTime? ExpirationDate
{
get { return _expirationDate; }
set {
_expirationDate= value;
OnPropertyChanged("expirationDate", value);
}
}


		#endregion
		#region Constructor
		public  MedicationBatch() { }
		public  MedicationBatch(string value) : base(value) { }
		public  MedicationBatch(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MedicationIngredientStrengthChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Ratio","CodeableConceptQuantity"
        ];

        public MedicationIngredientStrengthChoice(JsonObject value) : base("strength", value, _supportType)
        {
        }
        public MedicationIngredientStrengthChoice(IComplexType? value) : base("strength", value)
        {
        }
        public MedicationIngredientStrengthChoice(IPrimitiveType? value) : base("strength", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"strength".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
