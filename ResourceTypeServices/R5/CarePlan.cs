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
    public class CarePlan : ResourceType<CarePlan>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<FhirCanonical>? _instantiatesCanonical;
private List<FhirUri>? _instantiatesUri;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _replaces;
private List<ReferenceType>? _partOf;
private FhirCode? _status;
private FhirCode? _intent;
private List<CodeableConcept>? _category;
private FhirString? _title;
private FhirString? _description;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private Period? _period;
private FhirDateTime? _created;
private ReferenceType? _custodian;
private List<ReferenceType>? _contributor;
private List<ReferenceType>? _careTeam;
private List<CodeableReference>? _addresses;
private List<ReferenceType>? _supportingInfo;
private List<ReferenceType>? _goal;
private List<CarePlanActivity>? _activity;
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

public List<FhirCanonical>? InstantiatesCanonical
{
get { return _instantiatesCanonical; }
set {
_instantiatesCanonical= value;
OnPropertyChanged("instantiatesCanonical", value);
}
}

public List<FhirUri>? InstantiatesUri
{
get { return _instantiatesUri; }
set {
_instantiatesUri= value;
OnPropertyChanged("instantiatesUri", value);
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

public List<ReferenceType>? Replaces
{
get { return _replaces; }
set {
_replaces= value;
OnPropertyChanged("replaces", value);
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

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
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

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public FhirDateTime? Created
{
get { return _created; }
set {
_created= value;
OnPropertyChanged("created", value);
}
}

public ReferenceType? Custodian
{
get { return _custodian; }
set {
_custodian= value;
OnPropertyChanged("custodian", value);
}
}

public List<ReferenceType>? Contributor
{
get { return _contributor; }
set {
_contributor= value;
OnPropertyChanged("contributor", value);
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

public List<CodeableReference>? Addresses
{
get { return _addresses; }
set {
_addresses= value;
OnPropertyChanged("addresses", value);
}
}

public List<ReferenceType>? SupportingInfo
{
get { return _supportingInfo; }
set {
_supportingInfo= value;
OnPropertyChanged("supportingInfo", value);
}
}

public List<ReferenceType>? Goal
{
get { return _goal; }
set {
_goal= value;
OnPropertyChanged("goal", value);
}
}

public List<CarePlanActivity>? Activity
{
get { return _activity; }
set {
_activity= value;
OnPropertyChanged("activity", value);
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
		public  CarePlan() { }
		public  CarePlan(string value) : base(value) { }
		public  CarePlan(JsonNode? source) : base(source) { }
		#endregion
	}
		public class CarePlanActivity : BackboneElementType<CarePlanActivity>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableReference>? _performedActivity;
private List<Annotation>? _progress;
private ReferenceType? _plannedActivityReference;

		#endregion
		#region public Method
		public List<CodeableReference>? PerformedActivity
{
get { return _performedActivity; }
set {
_performedActivity= value;
OnPropertyChanged("performedActivity", value);
}
}

public List<Annotation>? Progress
{
get { return _progress; }
set {
_progress= value;
OnPropertyChanged("progress", value);
}
}

public ReferenceType? PlannedActivityReference
{
get { return _plannedActivityReference; }
set {
_plannedActivityReference= value;
OnPropertyChanged("plannedActivityReference", value);
}
}


		#endregion
		#region Constructor
		public  CarePlanActivity() { }
		public  CarePlanActivity(string value) : base(value) { }
		public  CarePlanActivity(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
