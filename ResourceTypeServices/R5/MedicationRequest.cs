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
    public class MedicationRequest : ResourceType<MedicationRequest>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private ReferenceType? _priorPrescription;
private Identifier? _groupIdentifier;
private FhirCode? _status;
private CodeableConcept? _statusReason;
private FhirDateTime? _statusChanged;
private FhirCode? _intent;
private List<CodeableConcept>? _category;
private FhirCode? _priority;
private FhirBoolean? _doNotPerform;
private CodeableReference? _medication;
private ReferenceType? _subject;
private List<ReferenceType>? _informationSource;
private ReferenceType? _encounter;
private List<ReferenceType>? _supportingInformation;
private FhirDateTime? _authoredOn;
private ReferenceType? _requester;
private FhirBoolean? _reported;
private CodeableConcept? _performerType;
private List<ReferenceType>? _performer;
private List<CodeableReference>? _device;
private ReferenceType? _recorder;
private List<CodeableReference>? _reason;
private CodeableConcept? _courseOfTherapyType;
private List<ReferenceType>? _insurance;
private List<Annotation>? _note;
private FhirMarkdown? _renderedDosageInstruction;
private Period? _effectiveDosePeriod;
private List<Dosage>? _dosageInstruction;
private MedicationRequestDispenseRequest? _dispenseRequest;
private MedicationRequestSubstitution? _substitution;
private List<ReferenceType>? _eventHistory;

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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
}
}

public ReferenceType? PriorPrescription
{
get { return _priorPrescription; }
set {
_priorPrescription= value;
OnPropertyChanged("priorPrescription", value);
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

public CodeableConcept? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
}
}

public FhirDateTime? StatusChanged
{
get { return _statusChanged; }
set {
_statusChanged= value;
OnPropertyChanged("statusChanged", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public FhirBoolean? DoNotPerform
{
get { return _doNotPerform; }
set {
_doNotPerform= value;
OnPropertyChanged("doNotPerform", value);
}
}

public CodeableReference? Medication
{
get { return _medication; }
set {
_medication= value;
OnPropertyChanged("medication", value);
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

public List<ReferenceType>? InformationSource
{
get { return _informationSource; }
set {
_informationSource= value;
OnPropertyChanged("informationSource", value);
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

public FhirDateTime? AuthoredOn
{
get { return _authoredOn; }
set {
_authoredOn= value;
OnPropertyChanged("authoredOn", value);
}
}

public ReferenceType? Requester
{
get { return _requester; }
set {
_requester= value;
OnPropertyChanged("requester", value);
}
}

public FhirBoolean? Reported
{
get { return _reported; }
set {
_reported= value;
OnPropertyChanged("reported", value);
}
}

public CodeableConcept? PerformerType
{
get { return _performerType; }
set {
_performerType= value;
OnPropertyChanged("performerType", value);
}
}

public List<ReferenceType>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<CodeableReference>? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public ReferenceType? Recorder
{
get { return _recorder; }
set {
_recorder= value;
OnPropertyChanged("recorder", value);
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

public CodeableConcept? CourseOfTherapyType
{
get { return _courseOfTherapyType; }
set {
_courseOfTherapyType= value;
OnPropertyChanged("courseOfTherapyType", value);
}
}

public List<ReferenceType>? Insurance
{
get { return _insurance; }
set {
_insurance= value;
OnPropertyChanged("insurance", value);
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

public FhirMarkdown? RenderedDosageInstruction
{
get { return _renderedDosageInstruction; }
set {
_renderedDosageInstruction= value;
OnPropertyChanged("renderedDosageInstruction", value);
}
}

public Period? EffectiveDosePeriod
{
get { return _effectiveDosePeriod; }
set {
_effectiveDosePeriod= value;
OnPropertyChanged("effectiveDosePeriod", value);
}
}

public List<Dosage>? DosageInstruction
{
get { return _dosageInstruction; }
set {
_dosageInstruction= value;
OnPropertyChanged("dosageInstruction", value);
}
}

public MedicationRequestDispenseRequest? DispenseRequest
{
get { return _dispenseRequest; }
set {
_dispenseRequest= value;
OnPropertyChanged("dispenseRequest", value);
}
}

public MedicationRequestSubstitution? Substitution
{
get { return _substitution; }
set {
_substitution= value;
OnPropertyChanged("substitution", value);
}
}

public List<ReferenceType>? EventHistory
{
get { return _eventHistory; }
set {
_eventHistory= value;
OnPropertyChanged("eventHistory", value);
}
}


		#endregion
		#region Constructor
		public  MedicationRequest() { }
		public  MedicationRequest(string value) : base(value) { }
		public  MedicationRequest(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicationRequestDispenseRequestInitialFill : BackboneElementType<MedicationRequestDispenseRequestInitialFill>, IBackboneElementType
	{

		#region Private Method
		private Quantity? _quantity;
private Duration? _duration;

		#endregion
		#region public Method
		public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public Duration? Duration
{
get { return _duration; }
set {
_duration= value;
OnPropertyChanged("duration", value);
}
}


		#endregion
		#region Constructor
		public  MedicationRequestDispenseRequestInitialFill() { }
		public  MedicationRequestDispenseRequestInitialFill(string value) : base(value) { }
		public  MedicationRequestDispenseRequestInitialFill(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationRequestDispenseRequest : BackboneElementType<MedicationRequestDispenseRequest>, IBackboneElementType
	{

		#region Private Method
		private MedicationRequestDispenseRequestInitialFill? _initialFill;
private Duration? _dispenseInterval;
private Period? _validityPeriod;
private FhirUnsignedInt? _numberOfRepeatsAllowed;
private Quantity? _quantity;
private Duration? _expectedSupplyDuration;
private ReferenceType? _dispenser;
private List<Annotation>? _dispenserInstruction;
private CodeableConcept? _doseAdministrationAid;

		#endregion
		#region public Method
		public MedicationRequestDispenseRequestInitialFill? InitialFill
{
get { return _initialFill; }
set {
_initialFill= value;
OnPropertyChanged("initialFill", value);
}
}

public Duration? DispenseInterval
{
get { return _dispenseInterval; }
set {
_dispenseInterval= value;
OnPropertyChanged("dispenseInterval", value);
}
}

public Period? ValidityPeriod
{
get { return _validityPeriod; }
set {
_validityPeriod= value;
OnPropertyChanged("validityPeriod", value);
}
}

public FhirUnsignedInt? NumberOfRepeatsAllowed
{
get { return _numberOfRepeatsAllowed; }
set {
_numberOfRepeatsAllowed= value;
OnPropertyChanged("numberOfRepeatsAllowed", value);
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

public Duration? ExpectedSupplyDuration
{
get { return _expectedSupplyDuration; }
set {
_expectedSupplyDuration= value;
OnPropertyChanged("expectedSupplyDuration", value);
}
}

public ReferenceType? Dispenser
{
get { return _dispenser; }
set {
_dispenser= value;
OnPropertyChanged("dispenser", value);
}
}

public List<Annotation>? DispenserInstruction
{
get { return _dispenserInstruction; }
set {
_dispenserInstruction= value;
OnPropertyChanged("dispenserInstruction", value);
}
}

public CodeableConcept? DoseAdministrationAid
{
get { return _doseAdministrationAid; }
set {
_doseAdministrationAid= value;
OnPropertyChanged("doseAdministrationAid", value);
}
}


		#endregion
		#region Constructor
		public  MedicationRequestDispenseRequest() { }
		public  MedicationRequestDispenseRequest(string value) : base(value) { }
		public  MedicationRequestDispenseRequest(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationRequestSubstitution : BackboneElementType<MedicationRequestSubstitution>, IBackboneElementType
	{

		#region Private Method
		private MedicationRequestSubstitutionAllowedChoice? _allowed;
private CodeableConcept? _reason;

		#endregion
		#region public Method
		public MedicationRequestSubstitutionAllowedChoice? Allowed
{
get { return _allowed; }
set {
_allowed= value;
OnPropertyChanged("allowed", value);
}
}

public CodeableConcept? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}


		#endregion
		#region Constructor
		public  MedicationRequestSubstitution() { }
		public  MedicationRequestSubstitution(string value) : base(value) { }
		public  MedicationRequestSubstitution(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MedicationRequestSubstitutionAllowedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","CodeableConcept"
        ];

        public MedicationRequestSubstitutionAllowedChoice(JsonObject value) : base("allowed", value, _supportType)
        {
        }
        public MedicationRequestSubstitutionAllowedChoice(IComplexType? value) : base("allowed", value)
        {
        }
        public MedicationRequestSubstitutionAllowedChoice(IPrimitiveType? value) : base("allowed", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"allowed".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
