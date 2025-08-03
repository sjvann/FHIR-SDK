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
    public class ClinicalUseDefinition : ResourceType<ClinicalUseDefinition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _type;
private List<CodeableConcept>? _category;
private List<ReferenceType>? _subject;
private CodeableConcept? _status;
private ClinicalUseDefinitionContraindication? _contraindication;
private ClinicalUseDefinitionIndication? _indication;
private ClinicalUseDefinitionInteraction? _interaction;
private List<ReferenceType>? _population;
private List<FhirCanonical>? _library;
private ClinicalUseDefinitionUndesirableEffect? _undesirableEffect;
private ClinicalUseDefinitionWarning? _warning;

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

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public List<ReferenceType>? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
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

public ClinicalUseDefinitionContraindication? Contraindication
{
get { return _contraindication; }
set {
_contraindication= value;
OnPropertyChanged("contraindication", value);
}
}

public ClinicalUseDefinitionIndication? Indication
{
get { return _indication; }
set {
_indication= value;
OnPropertyChanged("indication", value);
}
}

public ClinicalUseDefinitionInteraction? Interaction
{
get { return _interaction; }
set {
_interaction= value;
OnPropertyChanged("interaction", value);
}
}

public List<ReferenceType>? Population
{
get { return _population; }
set {
_population= value;
OnPropertyChanged("population", value);
}
}

public List<FhirCanonical>? Library
{
get { return _library; }
set {
_library= value;
OnPropertyChanged("library", value);
}
}

public ClinicalUseDefinitionUndesirableEffect? UndesirableEffect
{
get { return _undesirableEffect; }
set {
_undesirableEffect= value;
OnPropertyChanged("undesirableEffect", value);
}
}

public ClinicalUseDefinitionWarning? Warning
{
get { return _warning; }
set {
_warning= value;
OnPropertyChanged("warning", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinition() { }
		public  ClinicalUseDefinition(string value) : base(value) { }
		public  ClinicalUseDefinition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ClinicalUseDefinitionContraindicationOtherTherapy : BackboneElementType<ClinicalUseDefinitionContraindicationOtherTherapy>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _relationshipType;
private CodeableReference? _treatment;

		#endregion
		#region public Method
		public CodeableConcept? RelationshipType
{
get { return _relationshipType; }
set {
_relationshipType= value;
OnPropertyChanged("relationshipType", value);
}
}

public CodeableReference? Treatment
{
get { return _treatment; }
set {
_treatment= value;
OnPropertyChanged("treatment", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionContraindicationOtherTherapy() { }
		public  ClinicalUseDefinitionContraindicationOtherTherapy(string value) : base(value) { }
		public  ClinicalUseDefinitionContraindicationOtherTherapy(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClinicalUseDefinitionContraindication : BackboneElementType<ClinicalUseDefinitionContraindication>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _diseaseSymptomProcedure;
private CodeableReference? _diseaseStatus;
private List<CodeableReference>? _comorbidity;
private List<ReferenceType>? _indication;
private ExpressionType? _applicability;
private List<ClinicalUseDefinitionContraindicationOtherTherapy>? _otherTherapy;

		#endregion
		#region public Method
		public CodeableReference? DiseaseSymptomProcedure
{
get { return _diseaseSymptomProcedure; }
set {
_diseaseSymptomProcedure= value;
OnPropertyChanged("diseaseSymptomProcedure", value);
}
}

public CodeableReference? DiseaseStatus
{
get { return _diseaseStatus; }
set {
_diseaseStatus= value;
OnPropertyChanged("diseaseStatus", value);
}
}

public List<CodeableReference>? Comorbidity
{
get { return _comorbidity; }
set {
_comorbidity= value;
OnPropertyChanged("comorbidity", value);
}
}

public List<ReferenceType>? Indication
{
get { return _indication; }
set {
_indication= value;
OnPropertyChanged("indication", value);
}
}

public ExpressionType? Applicability
{
get { return _applicability; }
set {
_applicability= value;
OnPropertyChanged("applicability", value);
}
}

public List<ClinicalUseDefinitionContraindicationOtherTherapy>? OtherTherapy
{
get { return _otherTherapy; }
set {
_otherTherapy= value;
OnPropertyChanged("otherTherapy", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionContraindication() { }
		public  ClinicalUseDefinitionContraindication(string value) : base(value) { }
		public  ClinicalUseDefinitionContraindication(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClinicalUseDefinitionIndication : BackboneElementType<ClinicalUseDefinitionIndication>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _diseaseSymptomProcedure;
private CodeableReference? _diseaseStatus;
private List<CodeableReference>? _comorbidity;
private CodeableReference? _intendedEffect;
private ClinicalUseDefinitionIndicationDurationChoice? _duration;
private List<ReferenceType>? _undesirableEffect;
private ExpressionType? _applicability;

		#endregion
		#region public Method
		public CodeableReference? DiseaseSymptomProcedure
{
get { return _diseaseSymptomProcedure; }
set {
_diseaseSymptomProcedure= value;
OnPropertyChanged("diseaseSymptomProcedure", value);
}
}

public CodeableReference? DiseaseStatus
{
get { return _diseaseStatus; }
set {
_diseaseStatus= value;
OnPropertyChanged("diseaseStatus", value);
}
}

public List<CodeableReference>? Comorbidity
{
get { return _comorbidity; }
set {
_comorbidity= value;
OnPropertyChanged("comorbidity", value);
}
}

public CodeableReference? IntendedEffect
{
get { return _intendedEffect; }
set {
_intendedEffect= value;
OnPropertyChanged("intendedEffect", value);
}
}

public ClinicalUseDefinitionIndicationDurationChoice? Duration
{
get { return _duration; }
set {
_duration= value;
OnPropertyChanged("duration", value);
}
}

public List<ReferenceType>? UndesirableEffect
{
get { return _undesirableEffect; }
set {
_undesirableEffect= value;
OnPropertyChanged("undesirableEffect", value);
}
}

public ExpressionType? Applicability
{
get { return _applicability; }
set {
_applicability= value;
OnPropertyChanged("applicability", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionIndication() { }
		public  ClinicalUseDefinitionIndication(string value) : base(value) { }
		public  ClinicalUseDefinitionIndication(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClinicalUseDefinitionInteractionInteractant : BackboneElementType<ClinicalUseDefinitionInteractionInteractant>, IBackboneElementType
	{

		#region Private Method
		private ClinicalUseDefinitionInteractionInteractantItemChoice? _item;

		#endregion
		#region public Method
		public ClinicalUseDefinitionInteractionInteractantItemChoice? Item
{
get { return _item; }
set {
_item= value;
OnPropertyChanged("item", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionInteractionInteractant() { }
		public  ClinicalUseDefinitionInteractionInteractant(string value) : base(value) { }
		public  ClinicalUseDefinitionInteractionInteractant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClinicalUseDefinitionInteraction : BackboneElementType<ClinicalUseDefinitionInteraction>, IBackboneElementType
	{

		#region Private Method
		private List<ClinicalUseDefinitionInteractionInteractant>? _interactant;
private CodeableConcept? _type;
private CodeableReference? _effect;
private CodeableConcept? _incidence;
private List<CodeableConcept>? _management;

		#endregion
		#region public Method
		public List<ClinicalUseDefinitionInteractionInteractant>? Interactant
{
get { return _interactant; }
set {
_interactant= value;
OnPropertyChanged("interactant", value);
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

public CodeableReference? Effect
{
get { return _effect; }
set {
_effect= value;
OnPropertyChanged("effect", value);
}
}

public CodeableConcept? Incidence
{
get { return _incidence; }
set {
_incidence= value;
OnPropertyChanged("incidence", value);
}
}

public List<CodeableConcept>? Management
{
get { return _management; }
set {
_management= value;
OnPropertyChanged("management", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionInteraction() { }
		public  ClinicalUseDefinitionInteraction(string value) : base(value) { }
		public  ClinicalUseDefinitionInteraction(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClinicalUseDefinitionUndesirableEffect : BackboneElementType<ClinicalUseDefinitionUndesirableEffect>, IBackboneElementType
	{

		#region Private Method
		private CodeableReference? _symptomConditionEffect;
private CodeableConcept? _classification;
private CodeableConcept? _frequencyOfOccurrence;

		#endregion
		#region public Method
		public CodeableReference? SymptomConditionEffect
{
get { return _symptomConditionEffect; }
set {
_symptomConditionEffect= value;
OnPropertyChanged("symptomConditionEffect", value);
}
}

public CodeableConcept? Classification
{
get { return _classification; }
set {
_classification= value;
OnPropertyChanged("classification", value);
}
}

public CodeableConcept? FrequencyOfOccurrence
{
get { return _frequencyOfOccurrence; }
set {
_frequencyOfOccurrence= value;
OnPropertyChanged("frequencyOfOccurrence", value);
}
}


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionUndesirableEffect() { }
		public  ClinicalUseDefinitionUndesirableEffect(string value) : base(value) { }
		public  ClinicalUseDefinitionUndesirableEffect(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ClinicalUseDefinitionWarning : BackboneElementType<ClinicalUseDefinitionWarning>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private CodeableConcept? _code;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
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


		#endregion
		#region Constructor
		public  ClinicalUseDefinitionWarning() { }
		public  ClinicalUseDefinitionWarning(string value) : base(value) { }
		public  ClinicalUseDefinitionWarning(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ClinicalUseDefinitionIndicationDurationChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Range","string"
        ];

        public ClinicalUseDefinitionIndicationDurationChoice(JsonObject value) : base("duration", value, _supportType)
        {
        }
        public ClinicalUseDefinitionIndicationDurationChoice(IComplexType? value) : base("duration", value)
        {
        }
        public ClinicalUseDefinitionIndicationDurationChoice(IPrimitiveType? value) : base("duration", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"duration".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ClinicalUseDefinitionInteractionInteractantItemChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Reference(MedicinalProductDefinition|Medication|Substance|NutritionProduct|BiologicallyDerivedProduct|ObservationDefinition)","CodeableConcept"
        ];

        public ClinicalUseDefinitionInteractionInteractantItemChoice(JsonObject value) : base("item", value, _supportType)
        {
        }
        public ClinicalUseDefinitionInteractionInteractantItemChoice(IComplexType? value) : base("item", value)
        {
        }
        public ClinicalUseDefinitionInteractionInteractantItemChoice(IPrimitiveType? value) : base("item", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"item".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
