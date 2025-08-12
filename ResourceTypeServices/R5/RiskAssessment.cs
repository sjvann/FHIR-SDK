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
    public class RiskAssessment : ResourceType<RiskAssessment>
	{
		#region private Property
		private List<Identifier>? _identifier;
private ReferenceType? _basedOn;
private ReferenceType? _parent;
private FhirCode? _status;
private CodeableConcept? _method;
private CodeableConcept? _code;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private RiskAssessmentOccurrenceChoice? _occurrence;
private ReferenceType? _condition;
private ReferenceType? _performer;
private List<CodeableReference>? _reason;
private List<ReferenceType>? _basis;
private List<RiskAssessmentPrediction>? _prediction;
private FhirString? _mitigation;
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

public ReferenceType? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public ReferenceType? Parent
{
get { return _parent; }
set {
_parent= value;
OnPropertyChanged("parent", value);
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

public CodeableConcept? Method
{
get { return _method; }
set {
_method= value;
OnPropertyChanged("method", value);
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

public RiskAssessmentOccurrenceChoice? Occurrence
{
get { return _occurrence; }
set {
_occurrence= value;
OnPropertyChanged("occurrence", value);
}
}

public ReferenceType? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public ReferenceType? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
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

public List<ReferenceType>? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
}
}

public List<RiskAssessmentPrediction>? Prediction
{
get { return _prediction; }
set {
_prediction= value;
OnPropertyChanged("prediction", value);
}
}

public FhirString? Mitigation
{
get { return _mitigation; }
set {
_mitigation= value;
OnPropertyChanged("mitigation", value);
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
		public  RiskAssessment() { }
		public  RiskAssessment(string value) : base(value) { }
		public  RiskAssessment(JsonNode? source) : base(source) { }
		#endregion
	}
		public class RiskAssessmentPrediction : BackboneElementType<RiskAssessmentPrediction>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _outcome;
private RiskAssessmentPredictionProbabilityChoice? _probability;
private CodeableConcept? _qualitativeRisk;
private FhirDecimal? _relativeRisk;
private RiskAssessmentPredictionWhenChoice? _when;
private FhirString? _rationale;

		#endregion
		#region public Method
		public CodeableConcept? Outcome
{
get { return _outcome; }
set {
_outcome= value;
OnPropertyChanged("outcome", value);
}
}

public RiskAssessmentPredictionProbabilityChoice? Probability
{
get { return _probability; }
set {
_probability= value;
OnPropertyChanged("probability", value);
}
}

public CodeableConcept? QualitativeRisk
{
get { return _qualitativeRisk; }
set {
_qualitativeRisk= value;
OnPropertyChanged("qualitativeRisk", value);
}
}

public FhirDecimal? RelativeRisk
{
get { return _relativeRisk; }
set {
_relativeRisk= value;
OnPropertyChanged("relativeRisk", value);
}
}

public RiskAssessmentPredictionWhenChoice? When
{
get { return _when; }
set {
_when= value;
OnPropertyChanged("when", value);
}
}

public FhirString? Rationale
{
get { return _rationale; }
set {
_rationale= value;
OnPropertyChanged("rationale", value);
}
}


		#endregion
		#region Constructor
		public  RiskAssessmentPrediction() { }
		public  RiskAssessmentPrediction(string value) : base(value) { }
		public  RiskAssessmentPrediction(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class RiskAssessmentOccurrenceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","Period"
        ];

        public RiskAssessmentOccurrenceChoice(JsonObject value) : base("occurrence", value, _supportType)
        {
        }
        public RiskAssessmentOccurrenceChoice(IComplexType? value) : base("occurrence", value)
        {
        }
        public RiskAssessmentOccurrenceChoice(IPrimitiveType? value) : base("occurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"occurrence".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class RiskAssessmentPredictionProbabilityChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "decimal","Range"
        ];

        public RiskAssessmentPredictionProbabilityChoice(JsonObject value) : base("probability", value, _supportType)
        {
        }
        public RiskAssessmentPredictionProbabilityChoice(IComplexType? value) : base("probability", value)
        {
        }
        public RiskAssessmentPredictionProbabilityChoice(IPrimitiveType? value) : base("probability", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"probability".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class RiskAssessmentPredictionWhenChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Period","Range"
        ];

        public RiskAssessmentPredictionWhenChoice(JsonObject value) : base("when", value, _supportType)
        {
        }
        public RiskAssessmentPredictionWhenChoice(IComplexType? value) : base("when", value)
        {
        }
        public RiskAssessmentPredictionWhenChoice(IPrimitiveType? value) : base("when", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"when".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
