using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;

namespace ResourceTypeServices.R5
{
    public class BiologicallyDerivedProductDispense : ResourceType<BiologicallyDerivedProductDispense>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private CodeableConcept? _originRelationshipType;
private ReferenceType? _product;
private ReferenceType? _patient;
private CodeableConcept? _matchStatus;
private List<BiologicallyDerivedProductDispensePerformer>? _performer;
private ReferenceType? _location;
private Quantity? _quantity;
private FhirDateTime? _preparedDate;
private FhirDateTime? _whenHandedOver;
private ReferenceType? _destination;
private List<Annotation>? _note;
private FhirString? _usageInstruction;

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

public CodeableConcept? OriginRelationshipType
{
get { return _originRelationshipType; }
set {
_originRelationshipType= value;
OnPropertyChanged("originRelationshipType", value);
}
}

public ReferenceType? Product
{
get { return _product; }
set {
_product= value;
OnPropertyChanged("product", value);
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

public CodeableConcept? MatchStatus
{
get { return _matchStatus; }
set {
_matchStatus= value;
OnPropertyChanged("matchStatus", value);
}
}

public List<BiologicallyDerivedProductDispensePerformer>? Performer
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

public FhirString? UsageInstruction
{
get { return _usageInstruction; }
set {
_usageInstruction= value;
OnPropertyChanged("usageInstruction", value);
}
}


		#endregion
		#region Constructor
		public  BiologicallyDerivedProductDispense() { }
		public  BiologicallyDerivedProductDispense(string value) : base(value) { }
		public  BiologicallyDerivedProductDispense(JsonNode? source) : base(source) { }
		#endregion
	}
		public class BiologicallyDerivedProductDispensePerformer : BackboneElementType<BiologicallyDerivedProductDispensePerformer>, IBackboneElementType
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
		public  BiologicallyDerivedProductDispensePerformer() { }
		public  BiologicallyDerivedProductDispensePerformer(string value) : base(value) { }
		public  BiologicallyDerivedProductDispensePerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
