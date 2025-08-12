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
    public class NutritionIntake : ResourceType<NutritionIntake>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private List<CodeableConcept>? _statusReason;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private NutritionIntakeOccurrenceChoice? _occurrence;
private FhirDateTime? _recorded;
private NutritionIntakeReportedChoice? _reported;
private List<NutritionIntakeConsumedItem>? _consumedItem;
private List<NutritionIntakeIngredientLabel>? _ingredientLabel;
private List<NutritionIntakePerformer>? _performer;
private ReferenceType? _location;
private List<ReferenceType>? _derivedFrom;
private List<CodeableReference>? _reason;
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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public List<ReferenceType>? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
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

public List<CodeableConcept>? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public NutritionIntakeOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public FhirDateTime? Recorded
{
get { return _recorded; }
set {
_recorded= value;
OnPropertyChanged("recorded", value);
}
}

public NutritionIntakeReportedChoice? Reported
{
get { return _reported; }
set {
_reported= value;
OnPropertyChanged("reported", value);
}
}

public List<NutritionIntakeConsumedItem>? ConsumedItem
{
get { return _consumedItem; }
set {
_consumedItem= value;
OnPropertyChanged("consumedItem", value);
}
}

public List<NutritionIntakeIngredientLabel>? IngredientLabel
{
get { return _ingredientLabel; }
set {
_ingredientLabel= value;
OnPropertyChanged("ingredientLabel", value);
}
}

public List<NutritionIntakePerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
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

public List<ReferenceType>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
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
		public  NutritionIntake() { }
		public  NutritionIntake(string value) : base(value) { }
		public  NutritionIntake(JsonNode? source) : base(source) { }
		#endregion
	}
		public class NutritionIntakeConsumedItem : BackboneElementType<NutritionIntakeConsumedItem>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private CodeableReference? _nutritionProduct;
private Timing? _schedule;
private Quantity? _amount;
private Quantity? _rate;
private FhirBoolean? _notConsumed;
private CodeableConcept? _notConsumedReason;

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

public CodeableReference? NutritionProduct
{
get { return _nutritionProduct; }
set {
_nutritionProduct= value;
OnPropertyChanged("nutritionProduct", value);
}
}

public Timing? Schedule
{
get { return _schedule; }
set {
_schedule= value;
OnPropertyChanged("schedule", value);
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

public Quantity? Rate
{
get { return _rate; }
set {
_rate= value;
OnPropertyChanged("rate", value);
}
}

public FhirBoolean? NotConsumed
{
get { return _notConsumed; }
set {
_notConsumed= value;
OnPropertyChanged("notConsumed", value);
}
}

public CodeableConcept? NotConsumedReason
{
get { return _notConsumedReason; }
set {
_notConsumedReason= value;
OnPropertyChanged("notConsumedReason", value);
}
}


		#endregion
		#region Constructor
		public  NutritionIntakeConsumedItem() { }
		public  NutritionIntakeConsumedItem(string value) : base(value) { }
		public  NutritionIntakeConsumedItem(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionIntakeIngredientLabel : BackboneElementType<NutritionIntakeIngredientLabel>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _nutrient;
private Quantity? _amount;

		#endregion
		#region public Method
		public CodeableReference? Nutrient
{
get { return _nutrient; }
set {
_nutrient= value;
OnPropertyChanged("nutrient", value);
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
		public  NutritionIntakeIngredientLabel() { }
		public  NutritionIntakeIngredientLabel(string value) : base(value) { }
		public  NutritionIntakeIngredientLabel(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class NutritionIntakePerformer : BackboneElementType<NutritionIntakePerformer>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _function;
private ReferenceType? _actor;

		#endregion
		#region public Method
		public CodeableConcept? Function
{
get { return _function; }
set {
_function= value;
OnPropertyChanged("function", value);
}
}

public ReferenceType? Actor
{
get { return _actor; }
set {
_actor= value;
OnPropertyChanged("actor", value);
}
}


		#endregion
		#region Constructor
		public  NutritionIntakePerformer() { }
		public  NutritionIntakePerformer(string value) : base(value) { }
		public  NutritionIntakePerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class NutritionIntakeOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public NutritionIntakeOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public NutritionIntakeOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public NutritionIntakeOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class NutritionIntakeReportedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","Reference(Patient|RelatedPerson|Practitioner|PractitionerRole|Organization)"
        ];

        public NutritionIntakeReportedChoice(JsonObject value) : base("reported", value, _supportType)
        {
        }
        public NutritionIntakeReportedChoice(IComplexType? value) : base("reported", value)
        {
        }
        public NutritionIntakeReportedChoice(IPrimitiveType? value) : base("reported", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"reported".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
