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
    public class DeviceDispense : ResourceType<DeviceDispense>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private CodeableReference? _statusReason;
private List<CodeableConcept>? _category;
private CodeableReference? _device;
private ReferenceType? _subject;
private ReferenceType? _receiver;
private ReferenceType? _encounter;
private List<ReferenceType>? _supportingInformation;
private List<DeviceDispensePerformer>? _performer;
private ReferenceType? _location;
private CodeableConcept? _type;
private Quantity? _quantity;
private FhirDateTime? _preparedDate;
private FhirDateTime? _whenHandedOver;
private ReferenceType? _destination;
private List<Annotation>? _note;
private FhirMarkdown? _usageInstruction;
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

public CodeableReference? StatusReason
{
get { return _statusReason; }
set {
_statusReason= value;
OnPropertyChanged("statusReason", value);
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

public CodeableReference? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
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

public ReferenceType? Receiver
{
get { return _receiver; }
set {
_receiver= value;
OnPropertyChanged("receiver", value);
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

public List<DeviceDispensePerformer>? Performer
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

public FhirDateTime? PreparedDate
{
get { return _preparedDate; }
set {
_preparedDate= value;
OnPropertyChanged("preparedDate", value);
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

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}

public FhirMarkdown? UsageInstruction
{
get { return _usageInstruction; }
set {
_usageInstruction= value;
OnPropertyChanged("usageInstruction", value);
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
		public  DeviceDispense() { }
		public  DeviceDispense(string value) : base(value) { }
		public  DeviceDispense(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceDispensePerformer : BackboneElementType<DeviceDispensePerformer>, IBackboneElementType
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
		public  DeviceDispensePerformer() { }
		public  DeviceDispensePerformer(string value) : base(value) { }
		public  DeviceDispensePerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
