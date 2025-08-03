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
    public class MedicationDispense : ResourceType<MedicationDispense>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private CodeableReference? _notPerformedReason;
private FhirDateTime? _statusChanged;
private List<CodeableConcept>? _category;
private CodeableReference? _medication;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private List<ReferenceType>? _supportingInformation;
private List<MedicationDispensePerformer>? _performer;
private ReferenceType? _location;
private List<ReferenceType>? _authorizingPrescription;
private CodeableConcept? _type;
private Quantity? _quantity;
private Quantity? _daysSupply;
private FhirDateTime? _recorded;
private FhirDateTime? _whenPrepared;
private FhirDateTime? _whenHandedOver;
private ReferenceType? _destination;
private List<ReferenceType>? _receiver;
private List<Annotation>? _note;
private FhirMarkdown? _renderedDosageInstruction;
private List<Dosage>? _dosageInstruction;
private MedicationDispenseSubstitution? _substitution;
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

public CodeableReference? NotPerformedReason
{
get { return _notPerformedReason; }
set {
_notPerformedReason= value;
OnPropertyChanged("notPerformedReason", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public List<MedicationDispensePerformer>? Performer
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

public List<ReferenceType>? AuthorizingPrescription
{
get { return _authorizingPrescription; }
set {
_authorizingPrescription= value;
OnPropertyChanged("authorizingPrescription", value);
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

public Quantity? Quantity
{
get { return _quantity; }
set {
_quantity= value;
OnPropertyChanged("quantity", value);
}
}

public Quantity? DaysSupply
{
get { return _daysSupply; }
set {
_daysSupply= value;
OnPropertyChanged("daysSupply", value);
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

public FhirDateTime? WhenPrepared
{
get { return _whenPrepared; }
set {
_whenPrepared= value;
OnPropertyChanged("whenPrepared", value);
}
}

public FhirDateTime? WhenHandedOver
{
get { return _whenHandedOver; }
set {
_whenHandedOver= value;
OnPropertyChanged("whenHandedOver", value);
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

public List<ReferenceType>? Receiver
{
get { return _receiver; }
set {
_receiver= value;
OnPropertyChanged("receiver", value);
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

public List<Dosage>? DosageInstruction
{
get { return _dosageInstruction; }
set {
_dosageInstruction= value;
OnPropertyChanged("dosageInstruction", value);
}
}

public MedicationDispenseSubstitution? Substitution
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
		public  MedicationDispense() { }
		public  MedicationDispense(string value) : base(value) { }
		public  MedicationDispense(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MedicationDispensePerformer : BackboneElementType<MedicationDispensePerformer>, IBackboneElementType
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
		public  MedicationDispensePerformer() { }
		public  MedicationDispensePerformer(string value) : base(value) { }
		public  MedicationDispensePerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MedicationDispenseSubstitution : BackboneElementType<MedicationDispenseSubstitution>, IBackboneElementType
	{

		#region Private Method
		private FhirBoolean? _wasSubstituted;
private CodeableConcept? _type;
private List<CodeableConcept>? _reason;
private ReferenceType? _responsibleParty;

		#endregion
		#region public Method
		public FhirBoolean? WasSubstituted
{
get { return _wasSubstituted; }
set {
_wasSubstituted= value;
OnPropertyChanged("wasSubstituted", value);
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

public List<CodeableConcept>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public ReferenceType? ResponsibleParty
{
get { return _responsibleParty; }
set {
_responsibleParty= value;
OnPropertyChanged("responsibleParty", value);
}
}


		#endregion
		#region Constructor
		public  MedicationDispenseSubstitution() { }
		public  MedicationDispenseSubstitution(string value) : base(value) { }
		public  MedicationDispenseSubstitution(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
