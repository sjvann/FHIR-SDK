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
    public class Condition : ResourceType<Condition>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _clinicalStatus;
private CodeableConcept? _verificationStatus;
private List<CodeableConcept>? _category;
private CodeableConcept? _severity;
private CodeableConcept? _code;
private List<CodeableConcept>? _bodySite;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private ConditionOnsetChoice? _onset;
private ConditionAbatementChoice? _abatement;
private FhirDateTime? _recordedDate;
private List<ConditionParticipant>? _participant;
private List<ConditionStage>? _stage;
private List<CodeableReference>? _evidence;
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

public CodeableConcept? ClinicalStatus
{
get { return _clinicalStatus; }
set {
_clinicalStatus= value;
OnPropertyChanged("clinicalStatus", value);
}
}

public CodeableConcept? VerificationStatus
{
get { return _verificationStatus; }
set {
_verificationStatus= value;
OnPropertyChanged("verificationStatus", value);
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

public CodeableConcept? Severity
{
get { return _severity; }
set {
_severity= value;
OnPropertyChanged("severity", value);
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

public List<CodeableConcept>? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
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

public ConditionOnsetChoice? Onset
{
get { return _onset; }
set {
_onset= value;
OnPropertyChanged("onset", value);
}
}

public ConditionAbatementChoice? Abatement
{
get { return _abatement; }
set {
_abatement= value;
OnPropertyChanged("abatement", value);
}
}

public FhirDateTime? RecordedDate
{
get { return _recordedDate; }
set {
_recordedDate= value;
OnPropertyChanged("recordedDate", value);
}
}

public List<ConditionParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public List<ConditionStage>? Stage
{
get { return _stage; }
set {
_stage= value;
OnPropertyChanged("stage", value);
}
}

public List<CodeableReference>? Evidence
{
get { return _evidence; }
set {
_evidence= value;
OnPropertyChanged("evidence", value);
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
		public  Condition() { }
		public  Condition(string value) : base(value) { }
		public  Condition(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ConditionParticipant : BackboneElementType<ConditionParticipant>, IBackboneElementType
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
		public  ConditionParticipant() { }
		public  ConditionParticipant(string value) : base(value) { }
		public  ConditionParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ConditionStage : BackboneElementType<ConditionStage>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _summary;
private List<ReferenceType>? _assessment;
private CodeableConcept? _type;

		#endregion
		#region public Method
		public CodeableConcept? Summary
{
get { return _summary; }
set {
_summary= value;
OnPropertyChanged("summary", value);
}
}

public List<ReferenceType>? Assessment
{
get { return _assessment; }
set {
_assessment= value;
OnPropertyChanged("assessment", value);
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


		#endregion
		#region Constructor
		public  ConditionStage() { }
		public  ConditionStage(string value) : base(value) { }
		public  ConditionStage(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class ConditionOnsetChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","AgePeriodRangestring"
        ];

        public ConditionOnsetChoice(JsonObject value) : base("onset", value, _supportType)
        {
        }
        public ConditionOnsetChoice(IComplexType? value) : base("onset", value)
        {
        }
        public ConditionOnsetChoice(IPrimitiveType? value) : base("onset", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"onset".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class ConditionAbatementChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","AgePeriodRangestring"
        ];

        public ConditionAbatementChoice(JsonObject value) : base("abatement", value, _supportType)
        {
        }
        public ConditionAbatementChoice(IComplexType? value) : base("abatement", value)
        {
        }
        public ConditionAbatementChoice(IPrimitiveType? value) : base("abatement", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"abatement".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
