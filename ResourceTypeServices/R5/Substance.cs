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
    public class Substance : ResourceType<Substance>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _instance;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private CodeableReference? _code;
private FhirMarkdown? _description;
private FhirDateTime? _expiry;
private Quantity? _quantity;
private List<SubstanceIngredient>? _ingredient;

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

public FhirBoolean? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
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

public CodeableReference? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
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

public FhirDateTime? Expiry
{
get { return _expiry; }
set {
_expiry= value;
OnPropertyChanged("expiry", value);
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

public List<SubstanceIngredient>? Ingredient
{
get { return _ingredient; }
set {
_ingredient= value;
OnPropertyChanged("ingredient", value);
}
}


		#endregion
		#region Constructor
		public  Substance() { }
		public  Substance(string value) : base(value) { }
		public  Substance(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstanceIngredient : BackboneElementType<SubstanceIngredient>, IBackboneElementType
	{

		#region Private Method
		private Ratio? _quantity;
private SubstanceIngredientSubstanceChoice? _substance;

		#endregion
		#region public Method
		public Ratio? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public SubstanceIngredientSubstanceChoice? Substance
{
get { return _substance; }
set {
_substance= value;
OnPropertyChanged("substance", value);
}
}


		#endregion
		#region Constructor
		public  SubstanceIngredient() { }
		public  SubstanceIngredient(string value) : base(value) { }
		public  SubstanceIngredient(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class SubstanceIngredientSubstanceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","Reference(Substance)"
        ];

        public SubstanceIngredientSubstanceChoice(JsonObject value) : base("substance", value, _supportType)
        {
        }
        public SubstanceIngredientSubstanceChoice(IComplexType? value) : base("substance", value)
        {
        }
        public SubstanceIngredientSubstanceChoice(IPrimitiveType? value) : base("substance", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"substance".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
