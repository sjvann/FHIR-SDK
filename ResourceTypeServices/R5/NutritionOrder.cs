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
    public class NutritionOrder : ResourceType<NutritionOrder>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<FhirUri>? _instantiates;
private List<ReferenceType>? _basedOn;
private Identifier? _groupIdentifier;
private FhirCode? _status;
private FhirCode? _intent;
private FhirCode? _priority;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private List<ReferenceType>? _supportingInformation;
private FhirDateTime? _dateTime;
private ReferenceType? _orderer;
private List<CodeableReference>? _performer;
private List<ReferenceType>? _allergyIntolerance;
private List<CodeableConcept>? _foodPreferenceModifier;
private List<CodeableConcept>? _excludeFoodModifier;
private FhirBoolean? _outsideFoodAllowed;
private NutritionOrderOralDiet? _oralDiet;
private List<NutritionOrderSupplement>? _supplement;
private NutritionOrderEnteralFormula? _enteralFormula;
private List<Annotation>? _note;

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

public List<FhirCanonical>? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public List<FhirUri>? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
}
}

public List<FhirUri>? Instantiates
{
get { return _instantiates; }
set {
_instantiates= value;
OnPropertyChanged("instantiates", value);
}
}

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public Identifier? GroupIdentifier
{
get { return _groupIdentifier; }
set {
_groupIdentifier= value;
OnPropertyChanged("groupIdentifier", value);
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

public FhirCode? Intent
{
get { return _intent; }
set {
_intent= value;
OnPropertyChanged("intent", value);
}
}

public FhirCode? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
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

public ReferenceType? Encounter
{
get { return _encounter; }
set {
_encounter= value;
OnPropertyChanged("encounter", value);
}
}

public List<ReferenceType>? SupportingInformation
{
get { return _supportingInformation; }
set {
_supportingInformation= value;
OnPropertyChanged("supportingInformation", value);
}
}

public FhirDateTime? DateTime
{
get { return _dateTime; }
set {
_dateTime= value;
OnPropertyChanged("dateTime", value);
}
}

public ReferenceType? Orderer
{
get { return _orderer; }
set {
_orderer= value;
OnPropertyChanged("orderer", value);
}
}

public List<CodeableReference>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<ReferenceType>? AllergyIntolerance
{
get { return _allergyIntolerance; }
set {
_allergyIntolerance= value;
OnPropertyChanged("allergyIntolerance", value);
}
}

public List<CodeableConcept>? FoodPreferenceModifier
{
get { return _foodPreferenceModifier; }
set {
_foodPreferenceModifier= value;
OnPropertyChanged("foodPreferenceModifier", value);
}
}

public List<CodeableConcept>? ExcludeFoodModifier
{
get { return _excludeFoodModifier; }
set {
_excludeFoodModifier= value;
OnPropertyChanged("excludeFoodModifier", value);
}
}

public FhirBoolean? OutsideFoodAllowed
{
get { return _outsideFoodAllowed; }
set {
_outsideFoodAllowed= value;
OnPropertyChanged("outsideFoodAllowed", value);
}
}

public NutritionOrderOralDiet? OralDiet
{
get { return _oralDiet; }
set {
_oralDiet= value;
OnPropertyChanged("oralDiet", value);
}
}

public List<NutritionOrderSupplement>? Supplement
{
get { return _supplement; }
set {
_supplement= value;
OnPropertyChanged("supplement", value);
}
}

public NutritionOrderEnteralFormula? EnteralFormula
{
get { return _enteralFormula; }
set {
_enteralFormula= value;
OnPropertyChanged("enteralFormula", value);
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
		public  NutritionOrder() { }
		public  NutritionOrder(string value) : base(value) { }
		public  NutritionOrder(JsonNode? source) : base(source) { }
		#endregion
	}
		public class NutritionOrderOralDietSchedule : BackboneElementType<NutritionOrderOralDietSchedule>, IBackboneElementType
	{

		#region Private Method
		private List<Timing>? _timing;
private FhirBoolean? _asNeeded;
private CodeableConcept? _asNeededFor;

		#endregion
		#region public Method
		public List<Timing>? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public FhirBoolean? AsNeeded
{
get { return _asNeeded; }
set {
_asNeeded= value;
OnPropertyChanged("asNeeded", value);
}
}

public CodeableConcept? AsNeededFor
{
get { return _asNeededFor; }
set {
_asNeededFor= value;
OnPropertyChanged("asNeededFor", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderOralDietSchedule() { }
		public  NutritionOrderOralDietSchedule(string value) : base(value) { }
		public  NutritionOrderOralDietSchedule(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderOralDietNutrient : BackboneElementType<NutritionOrderOralDietNutrient>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _modifier;
private Quantity? _amount;

		#endregion
		#region public Method
		public CodeableConcept? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
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
		public  NutritionOrderOralDietNutrient() { }
		public  NutritionOrderOralDietNutrient(string value) : base(value) { }
		public  NutritionOrderOralDietNutrient(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderOralDietTexture : BackboneElementType<NutritionOrderOralDietTexture>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _modifier;
private CodeableConcept? _foodType;

		#endregion
		#region public Method
		public CodeableConcept? Modifier
{
get { return _modifier; }
set {
_modifier= value;
OnPropertyChanged("modifier", value);
}
}

public CodeableConcept? FoodType
{
get { return _foodType; }
set {
_foodType= value;
OnPropertyChanged("foodType", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderOralDietTexture() { }
		public  NutritionOrderOralDietTexture(string value) : base(value) { }
		public  NutritionOrderOralDietTexture(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderOralDiet : BackboneElementType<NutritionOrderOralDiet>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _type;
private NutritionOrderOralDietSchedule? _schedule;
private List<NutritionOrderOralDietNutrient>? _nutrient;
private List<NutritionOrderOralDietTexture>? _texture;
private List<CodeableConcept>? _fluidConsistencyType;
private FhirString? _instruction;

		#endregion
		#region public Method
		public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public NutritionOrderOralDietSchedule? Schedule
{
get { return _schedule; }
set {
_schedule= value;
OnPropertyChanged("schedule", value);
}
}

public List<NutritionOrderOralDietNutrient>? Nutrient
{
get { return _nutrient; }
set {
_nutrient= value;
OnPropertyChanged("nutrient", value);
}
}

public List<NutritionOrderOralDietTexture>? Texture
{
get { return _texture; }
set {
_texture= value;
OnPropertyChanged("texture", value);
}
}

public List<CodeableConcept>? FluidConsistencyType
{
get { return _fluidConsistencyType; }
set {
_fluidConsistencyType= value;
OnPropertyChanged("fluidConsistencyType", value);
}
}

public FhirString? Instruction
{
get { return _instruction; }
set {
_instruction= value;
OnPropertyChanged("instruction", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderOralDiet() { }
		public  NutritionOrderOralDiet(string value) : base(value) { }
		public  NutritionOrderOralDiet(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderSupplementSchedule : BackboneElementType<NutritionOrderSupplementSchedule>, IBackboneElementType
	{

		#region Private Method
		private List<Timing>? _timing;
private FhirBoolean? _asNeeded;
private CodeableConcept? _asNeededFor;

		#endregion
		#region public Method
		public List<Timing>? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public FhirBoolean? AsNeeded
{
get { return _asNeeded; }
set {
_asNeeded= value;
OnPropertyChanged("asNeeded", value);
}
}

public CodeableConcept? AsNeededFor
{
get { return _asNeededFor; }
set {
_asNeededFor= value;
OnPropertyChanged("asNeededFor", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderSupplementSchedule() { }
		public  NutritionOrderSupplementSchedule(string value) : base(value) { }
		public  NutritionOrderSupplementSchedule(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderSupplement : BackboneElementType<NutritionOrderSupplement>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _type;
private FhirString? _productName;
private NutritionOrderSupplementSchedule? _schedule;
private Quantity? _quantity;
private FhirString? _instruction;

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

public FhirString? ProductName
{
get { return _productName; }
set {
_productName= value;
OnPropertyChanged("productName", value);
}
}

public NutritionOrderSupplementSchedule? Schedule
{
get { return _schedule; }
set {
_schedule= value;
OnPropertyChanged("schedule", value);
}
}

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public FhirString? Instruction
{
get { return _instruction; }
set {
_instruction= value;
OnPropertyChanged("instruction", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderSupplement() { }
		public  NutritionOrderSupplement(string value) : base(value) { }
		public  NutritionOrderSupplement(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderEnteralFormulaAdditive : BackboneElementType<NutritionOrderEnteralFormulaAdditive>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _type;
private FhirString? _productName;
private Quantity? _quantity;

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

public FhirString? ProductName
{
get { return _productName; }
set {
_productName= value;
OnPropertyChanged("productName", value);
}
}

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderEnteralFormulaAdditive() { }
		public  NutritionOrderEnteralFormulaAdditive(string value) : base(value) { }
		public  NutritionOrderEnteralFormulaAdditive(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderEnteralFormulaAdministrationSchedule : BackboneElementType<NutritionOrderEnteralFormulaAdministrationSchedule>, IBackboneElementType
	{

		#region Private Method
		private List<Timing>? _timing;
private FhirBoolean? _asNeeded;
private CodeableConcept? _asNeededFor;

		#endregion
		#region public Method
		public List<Timing>? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public FhirBoolean? AsNeeded
{
get { return _asNeeded; }
set {
_asNeeded= value;
OnPropertyChanged("asNeeded", value);
}
}

public CodeableConcept? AsNeededFor
{
get { return _asNeededFor; }
set {
_asNeededFor= value;
OnPropertyChanged("asNeededFor", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderEnteralFormulaAdministrationSchedule() { }
		public  NutritionOrderEnteralFormulaAdministrationSchedule(string value) : base(value) { }
		public  NutritionOrderEnteralFormulaAdministrationSchedule(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderEnteralFormulaAdministration : BackboneElementType<NutritionOrderEnteralFormulaAdministration>, IBackboneElementType
	{

		#region Private Method
		private NutritionOrderEnteralFormulaAdministrationSchedule? _schedule;
private Quantity? _quantity;
private NutritionOrderEnteralFormulaAdministrationRateChoice? _rate;

		#endregion
		#region public Method
		public NutritionOrderEnteralFormulaAdministrationSchedule? Schedule
{
get { return _schedule; }
set {
_schedule= value;
OnPropertyChanged("schedule", value);
}
}

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public NutritionOrderEnteralFormulaAdministrationRateChoice? Rate
{
get { return _rate; }
set {
_rate= value;
OnPropertyChanged("rate", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderEnteralFormulaAdministration() { }
		public  NutritionOrderEnteralFormulaAdministration(string value) : base(value) { }
		public  NutritionOrderEnteralFormulaAdministration(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionOrderEnteralFormula : BackboneElementType<NutritionOrderEnteralFormula>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _baseFormulaType;
private FhirString? _baseFormulaProductName;
private List<CodeableReference>? _deliveryDevice;
private List<NutritionOrderEnteralFormulaAdditive>? _additive;
private Quantity? _caloricDensity;
private CodeableConcept? _routeOfAdministration;
private List<NutritionOrderEnteralFormulaAdministration>? _administration;
private Quantity? _maxVolumeToDeliver;
private FhirMarkdown? _administrationInstruction;

		#endregion
		#region public Method
		public CodeableReference? BaseFormulaType
{
get { return _baseFormulaType; }
set {
_baseFormulaType= value;
OnPropertyChanged("baseFormulaType", value);
}
}

public FhirString? BaseFormulaProductName
{
get { return _baseFormulaProductName; }
set {
_baseFormulaProductName= value;
OnPropertyChanged("baseFormulaProductName", value);
}
}

public List<CodeableReference>? DeliveryDevice
{
get { return _deliveryDevice; }
set {
_deliveryDevice= value;
OnPropertyChanged("deliveryDevice", value);
}
}

public List<NutritionOrderEnteralFormulaAdditive>? Additive
{
get { return _additive; }
set {
_additive= value;
OnPropertyChanged("additive", value);
}
}

public Quantity? CaloricDensity
{
get { return _caloricDensity; }
set {
_caloricDensity= value;
OnPropertyChanged("caloricDensity", value);
}
}

public CodeableConcept? RouteOfAdministration
{
get { return _routeOfAdministration; }
set {
_routeOfAdministration= value;
OnPropertyChanged("routeOfAdministration", value);
}
}

public List<NutritionOrderEnteralFormulaAdministration>? Administration
{
get { return _administration; }
set {
_administration= value;
OnPropertyChanged("administration", value);
}
}

public Quantity? MaxVolumeToDeliver
{
get { return _maxVolumeToDeliver; }
set {
_maxVolumeToDeliver= value;
OnPropertyChanged("maxVolumeToDeliver", value);
}
}

public FhirMarkdown? AdministrationInstruction
{
get { return _administrationInstruction; }
set {
_administrationInstruction= value;
OnPropertyChanged("administrationInstruction", value);
}
}


		#endregion
		#region Constructor
		public  NutritionOrderEnteralFormula() { }
		public  NutritionOrderEnteralFormula(string value) : base(value) { }
		public  NutritionOrderEnteralFormula(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class NutritionOrderEnteralFormulaAdministrationRateChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity {SimpleQuantity}","Ratio"
        ];

        public NutritionOrderEnteralFormulaAdministrationRateChoice(JsonObject value) : base("rate", value, _supportType)
        {
        }
        public NutritionOrderEnteralFormulaAdministrationRateChoice(IComplexType? value) : base("rate", value)
        {
        }
        public NutritionOrderEnteralFormulaAdministrationRateChoice(IPrimitiveType? value) : base("rate", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"rate".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
