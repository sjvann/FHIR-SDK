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
    public class Ingredient : ResourceType<Ingredient>
	{
		#region private Property
		private Identifier? _identifier;
private FhirCode? _status;
private List<ReferenceType>? _for;
private CodeableConcept? _role;
private List<CodeableConcept>? _function;
private CodeableConcept? _group;
private FhirBoolean? _allergenicIndicator;
private FhirMarkdown? _comment;
private List<IngredientManufacturer>? _manufacturer;
private IngredientSubstance? _substance;

		#endregion
		#region Public Method
		public Identifier? Identifier
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

public List<ReferenceType>? For
{
get { return _for; }
set {
_for= value;
OnPropertyChanged("for", value);
}
}

public CodeableConcept? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
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

public CodeableConcept? Group
{
get { return _group; }
set {
_group= value;
OnPropertyChanged("group", value);
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

public FhirMarkdown? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}

public List<IngredientManufacturer>? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
}
}

public IngredientSubstance? Substance
{
get { return _substance; }
set {
_substance= value;
OnPropertyChanged("substance", value);
}
}


		#endregion
		#region Constructor
		public  Ingredient() { }
		public  Ingredient(string value) : base(value) { }
		public  Ingredient(JsonNode? source) : base(source) { }
		#endregion
	}
		public class IngredientManufacturer : BackboneElementType<IngredientManufacturer>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _role;
private ReferenceType? _manufacturer;

		#endregion
		#region public Method
		public FhirCode? Role
{
get { return _role; }
set {
_role= value;
OnPropertyChanged("role", value);
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


		#endregion
		#region Constructor
		public  IngredientManufacturer() { }
		public  IngredientManufacturer(string value) : base(value) { }
		public  IngredientManufacturer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class IngredientSubstanceStrengthReferenceStrength : BackboneElementType<IngredientSubstanceStrengthReferenceStrength>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _substance;
private IngredientSubstanceStrengthReferenceStrengthStrengthChoice? _strength;
private FhirString? _measurementPoint;
private List<CodeableConcept>? _country;

		#endregion
		#region public Method
		public CodeableReference? Substance
{
get { return _substance; }
set {
_substance= value;
OnPropertyChanged("substance", value);
}
}

public IngredientSubstanceStrengthReferenceStrengthStrengthChoice? Strength
{
get { return _strength; }
set {
_strength= value;
OnPropertyChanged("strength", value);
}
}

public FhirString? MeasurementPoint
{
get { return _measurementPoint; }
set {
_measurementPoint= value;
OnPropertyChanged("measurementPoint", value);
}
}

public List<CodeableConcept>? Country
{
get { return _country; }
set {
_country= value;
OnPropertyChanged("country", value);
}
}


		#endregion
		#region Constructor
		public  IngredientSubstanceStrengthReferenceStrength() { }
		public  IngredientSubstanceStrengthReferenceStrength(string value) : base(value) { }
		public  IngredientSubstanceStrengthReferenceStrength(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class IngredientSubstanceStrength : BackboneElementType<IngredientSubstanceStrength>, IBackboneElementType
	{

		#region Private Method
		private IngredientSubstanceStrengthPresentationChoice? _presentation;
private FhirString? _textPresentation;
private IngredientSubstanceStrengthConcentrationChoice? _concentration;
private FhirString? _textConcentration;
private CodeableConcept? _basis;
private FhirString? _measurementPoint;
private List<CodeableConcept>? _country;
private List<IngredientSubstanceStrengthReferenceStrength>? _referenceStrength;

		#endregion
		#region public Method
		public IngredientSubstanceStrengthPresentationChoice? Presentation
{
get { return _presentation; }
set {
_presentation= value;
OnPropertyChanged("presentation", value);
}
}

public FhirString? TextPresentation
{
get { return _textPresentation; }
set {
_textPresentation= value;
OnPropertyChanged("textPresentation", value);
}
}

public IngredientSubstanceStrengthConcentrationChoice? Concentration
{
get { return _concentration; }
set {
_concentration= value;
OnPropertyChanged("concentration", value);
}
}

public FhirString? TextConcentration
{
get { return _textConcentration; }
set {
_textConcentration= value;
OnPropertyChanged("textConcentration", value);
}
}

public CodeableConcept? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
}
}

public FhirString? MeasurementPoint
{
get { return _measurementPoint; }
set {
_measurementPoint= value;
OnPropertyChanged("measurementPoint", value);
}
}

public List<CodeableConcept>? Country
{
get { return _country; }
set {
_country= value;
OnPropertyChanged("country", value);
}
}

public List<IngredientSubstanceStrengthReferenceStrength>? ReferenceStrength
{
get { return _referenceStrength; }
set {
_referenceStrength= value;
OnPropertyChanged("referenceStrength", value);
}
}


		#endregion
		#region Constructor
		public  IngredientSubstanceStrength() { }
		public  IngredientSubstanceStrength(string value) : base(value) { }
		public  IngredientSubstanceStrength(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class IngredientSubstance : BackboneElementType<IngredientSubstance>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _code;
private List<IngredientSubstanceStrength>? _strength;

		#endregion
		#region public Method
		public CodeableReference? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<IngredientSubstanceStrength>? Strength
{
get { return _strength; }
set {
_strength= value;
OnPropertyChanged("strength", value);
}
}


		#endregion
		#region Constructor
		public  IngredientSubstance() { }
		public  IngredientSubstance(string value) : base(value) { }
		public  IngredientSubstance(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class IngredientSubstanceStrengthPresentationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Ratio","RatioRangeCodeableConceptQuantity"
        ];

        public IngredientSubstanceStrengthPresentationChoice(JsonObject value) : base("presentation", value, _supportType)
        {
        }
        public IngredientSubstanceStrengthPresentationChoice(IComplexType? value) : base("presentation", value)
        {
        }
        public IngredientSubstanceStrengthPresentationChoice(IPrimitiveType? value) : base("presentation", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"presentation".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class IngredientSubstanceStrengthConcentrationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Ratio","RatioRangeCodeableConceptQuantity"
        ];

        public IngredientSubstanceStrengthConcentrationChoice(JsonObject value) : base("concentration", value, _supportType)
        {
        }
        public IngredientSubstanceStrengthConcentrationChoice(IComplexType? value) : base("concentration", value)
        {
        }
        public IngredientSubstanceStrengthConcentrationChoice(IPrimitiveType? value) : base("concentration", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"concentration".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class IngredientSubstanceStrengthReferenceStrengthStrengthChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Ratio","RatioRangeQuantity"
        ];

        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice(JsonObject value) : base("strength", value, _supportType)
        {
        }
        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice(IComplexType? value) : base("strength", value)
        {
        }
        public IngredientSubstanceStrengthReferenceStrengthStrengthChoice(IPrimitiveType? value) : base("strength", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"strength".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
