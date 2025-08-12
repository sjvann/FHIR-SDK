using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;

namespace ResourceTypeServices.R5
{
    public class Encounter : ResourceType<Encounter>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _class;
private CodeableConcept? _priority;
private List<CodeableConcept>? _type;
private List<CodeableReference>? _serviceType;
private ReferenceType? _subject;
private CodeableConcept? _subjectStatus;
private List<ReferenceType>? _episodeOfCare;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _careTeam;
private ReferenceType? _partOf;
private ReferenceType? _serviceProvider;
private List<EncounterParticipant>? _participant;
private List<ReferenceType>? _appointment;
private List<VirtualServiceDetail>? _virtualService;
private Period? _actualPeriod;
private FhirDateTime? _plannedStartDate;
private FhirDateTime? _plannedEndDate;
private Duration? _length;
private List<EncounterReason>? _reason;
private List<EncounterDiagnosis>? _diagnosis;
private List<ReferenceType>? _account;
private List<CodeableConcept>? _dietPreference;
private List<CodeableConcept>? _specialArrangement;
private List<CodeableConcept>? _specialCourtesy;
private EncounterAdmission? _admission;
private List<EncounterLocation>? _location;

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

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public List<CodeableConcept>? Class
{
get { return _class; }
set {
_class= value;
OnPropertyChanged("class", value);
}
}

public CodeableConcept? Priority
{
get { return _priority; }
set {
_priority= value;
OnPropertyChanged("priority", value);
}
}

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<CodeableReference>? ServiceType
{
get { return _serviceType; }
set {
_serviceType= value;
OnPropertyChanged("serviceType", value);
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

public CodeableConcept? SubjectStatus
{
get { return _subjectStatus; }
set {
_subjectStatus= value;
OnPropertyChanged("subjectStatus", value);
}
}

public List<ReferenceType>? EpisodeOfCare
{
get { return _episodeOfCare; }
set {
_episodeOfCare= value;
OnPropertyChanged("episodeOfCare", value);
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

public List<ReferenceType>? CareTeam
{
get { return _careTeam; }
set {
_careTeam= value;
OnPropertyChanged("careTeam", value);
}
}

public ReferenceType? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
}
}

public ReferenceType? ServiceProvider
{
get { return _serviceProvider; }
set {
_serviceProvider= value;
OnPropertyChanged("serviceProvider", value);
}
}

public List<EncounterParticipant>? Participant
{
get { return _participant; }
set {
_participant= value;
OnPropertyChanged("participant", value);
}
}

public List<ReferenceType>? Appointment
{
get { return _appointment; }
set {
_appointment= value;
OnPropertyChanged("appointment", value);
}
}

public List<VirtualServiceDetail>? VirtualService
{
get { return _virtualService; }
set {
_virtualService= value;
OnPropertyChanged("virtualService", value);
}
}

public Period? ActualPeriod
{
get { return _actualPeriod; }
set {
_actualPeriod= value;
OnPropertyChanged("actualPeriod", value);
}
}

public FhirDateTime? PlannedStartDate
{
get { return _plannedStartDate; }
set {
_plannedStartDate= value;
OnPropertyChanged("plannedStartDate", value);
}
}

public FhirDateTime? PlannedEndDate
{
get { return _plannedEndDate; }
set {
_plannedEndDate= value;
OnPropertyChanged("plannedEndDate", value);
}
}

public Duration? Length
{
get { return _length; }
set {
_length= value;
OnPropertyChanged("length", value);
}
}

public List<EncounterReason>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public List<EncounterDiagnosis>? Diagnosis
{
get { return _diagnosis; }
set {
_diagnosis= value;
OnPropertyChanged("diagnosis", value);
}
}

public List<ReferenceType>? Account
{
get { return _account; }
set {
_account= value;
OnPropertyChanged("account", value);
}
}

public List<CodeableConcept>? DietPreference
{
get { return _dietPreference; }
set {
_dietPreference= value;
OnPropertyChanged("dietPreference", value);
}
}

public List<CodeableConcept>? SpecialArrangement
{
get { return _specialArrangement; }
set {
_specialArrangement= value;
OnPropertyChanged("specialArrangement", value);
}
}

public List<CodeableConcept>? SpecialCourtesy
{
get { return _specialCourtesy; }
set {
_specialCourtesy= value;
OnPropertyChanged("specialCourtesy", value);
}
}

public EncounterAdmission? Admission
{
get { return _admission; }
set {
_admission= value;
OnPropertyChanged("admission", value);
}
}

public List<EncounterLocation>? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}


		#endregion
		#region Constructor
		public  Encounter() { }
		public  Encounter(string value) : base(value) { }
		public  Encounter(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EncounterParticipant : BackboneElementType<EncounterParticipant>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _type;
private Period? _period;
private ReferenceType? _actor;

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

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
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
		public  EncounterParticipant() { }
		public  EncounterParticipant(string value) : base(value) { }
		public  EncounterParticipant(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EncounterReason : BackboneElementType<EncounterReason>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _use;
private List<CodeableReference>? _value;

		#endregion
		#region public Method
		public List<CodeableConcept>? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}

public List<CodeableReference>? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  EncounterReason() { }
		public  EncounterReason(string value) : base(value) { }
		public  EncounterReason(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EncounterDiagnosis : BackboneElementType<EncounterDiagnosis>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableReference>? _condition;
private List<CodeableConcept>? _use;

		#endregion
		#region public Method
		public List<CodeableReference>? Condition
{
get { return _condition; }
set {
_condition= value;
OnPropertyChanged("condition", value);
}
}

public List<CodeableConcept>? Use
{
get { return _use; }
set {
_use= value;
OnPropertyChanged("use", value);
}
}


		#endregion
		#region Constructor
		public  EncounterDiagnosis() { }
		public  EncounterDiagnosis(string value) : base(value) { }
		public  EncounterDiagnosis(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EncounterAdmission : BackboneElementType<EncounterAdmission>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _preAdmissionIdentifier;
private ReferenceType? _origin;
private CodeableConcept? _admitSource;
private CodeableConcept? _reAdmission;
private ReferenceType? _destination;
private CodeableConcept? _dischargeDisposition;

		#endregion
		#region public Method
		public Identifier? PreAdmissionIdentifier
{
get { return _preAdmissionIdentifier; }
set {
_preAdmissionIdentifier= value;
OnPropertyChanged("preAdmissionIdentifier", value);
}
}

public ReferenceType? Origin
{
get { return _origin; }
set {
_origin= value;
OnPropertyChanged("origin", value);
}
}

public CodeableConcept? AdmitSource
{
get { return _admitSource; }
set {
_admitSource= value;
OnPropertyChanged("admitSource", value);
}
}

public CodeableConcept? ReAdmission
{
get { return _reAdmission; }
set {
_reAdmission= value;
OnPropertyChanged("reAdmission", value);
}
}

public ReferenceType? Destination
{
get { return _destination; }
set {
_destination= value;
OnPropertyChanged("destination", value);
}
}

public CodeableConcept? DischargeDisposition
{
get { return _dischargeDisposition; }
set {
_dischargeDisposition= value;
OnPropertyChanged("dischargeDisposition", value);
}
}


		#endregion
		#region Constructor
		public  EncounterAdmission() { }
		public  EncounterAdmission(string value) : base(value) { }
		public  EncounterAdmission(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class EncounterLocation : BackboneElementType<EncounterLocation>, IBackboneElementType
	{

		#region Private Method
		private ReferenceType? _location;
private FhirCode? _status;
private CodeableConcept? _form;
private Period? _period;

		#endregion
		#region public Method
		public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
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

public CodeableConcept? Form
{
get { return _form; }
set {
_form= value;
OnPropertyChanged("form", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}


		#endregion
		#region Constructor
		public  EncounterLocation() { }
		public  EncounterLocation(string value) : base(value) { }
		public  EncounterLocation(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
