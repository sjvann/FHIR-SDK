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
    public class AllergyIntolerance : ResourceType<AllergyIntolerance>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _clinicalStatus;
private CodeableConcept? _verificationStatus;
private CodeableConcept? _type;
private List<FhirCode>? _category;
private FhirCode? _criticality;
private CodeableConcept? _code;
private ReferenceType? _patient;
private ReferenceType? _encounter;
private AllergyIntoleranceOnsetChoice? _onset;
private FhirDateTime? _recordedDate;
private List<AllergyIntoleranceParticipant>? _participant;
private FhirDateTime? _lastOccurrence;
private List<Annotation>? _note;
private List<AllergyIntoleranceReaction>? _reaction;

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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<FhirCode>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public FhirCode? Criticality
{
get { return _criticality; }
set {
_criticality= value;
OnPropertyChanged("criticality", value);
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

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
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

public AllergyIntoleranceOnsetChoice? Onset
{
get { return _onset; }
set {
_onset= value;
OnPropertyChanged("onset", value);
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

public List<AllergyIntoleranceParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public FhirDateTime? LastOccurrence
{
get { return _lastOccurrence; }
set {
_lastOccurrence= value;
OnPropertyChanged("lastOccurrence", value);
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

public List<AllergyIntoleranceReaction>? Reaction
{
get { return _reaction; }
set {
_reaction= value;
OnPropertyChanged("reaction", value);
}
}


		#endregion
		#region Constructor
		public  AllergyIntolerance() { }
		public  AllergyIntolerance(string value) : base(value) { }
		public  AllergyIntolerance(JsonNode? source) : base(source) { }
		#endregion
	}
		public class AllergyIntoleranceParticipant : BackboneElementType<AllergyIntoleranceParticipant>, IBackboneElementType
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
		public  AllergyIntoleranceParticipant() { }
		public  AllergyIntoleranceParticipant(string value) : base(value) { }
		public  AllergyIntoleranceParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class AllergyIntoleranceReaction : BackboneElementType<AllergyIntoleranceReaction>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _substance;
private List<CodeableReference>? _manifestation;
private FhirString? _description;
private FhirDateTime? _onset;
private FhirCode? _severity;
private CodeableConcept? _exposureRoute;
private List<Annotation>? _note;

		#endregion
		#region public Method
		public CodeableConcept? Substance
{
get { return _substance; }
set {
_substance= value;
OnPropertyChanged("substance", value);
}
}

public List<CodeableReference>? Manifestation
{
get { return _manifestation; }
set {
_manifestation= value;
OnPropertyChanged("manifestation", value);
}
}

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public FhirDateTime? Onset
{
get { return _onset; }
set {
_onset= value;
OnPropertyChanged("onset", value);
}
}

public FhirCode? Severity
{
get { return _severity; }
set {
_severity= value;
OnPropertyChanged("severity", value);
}
}

public CodeableConcept? ExposureRoute
{
get { return _exposureRoute; }
set {
_exposureRoute= value;
OnPropertyChanged("exposureRoute", value);
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
		public  AllergyIntoleranceReaction() { }
		public  AllergyIntoleranceReaction(string value) : base(value) { }
		public  AllergyIntoleranceReaction(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class AllergyIntoleranceOnsetChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "dateTime","AgePeriodRangestring"
        ];
         public AllergyIntoleranceOnsetChoice(string dataType, JsonValue? value) : base(dataType, value) { }
        public AllergyIntoleranceOnsetChoice(JsonObject value) : base("onset", value, _supportType)
        {
        }
        public AllergyIntoleranceOnsetChoice(IComplexType? value) : base("onset", value)
        {
        }
        public AllergyIntoleranceOnsetChoice(IPrimitiveType? value) : base("onset", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"onset".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
