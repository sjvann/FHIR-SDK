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
    public class ImagingStudy : ResourceType<ImagingStudy>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _modality;
private ReferenceType? _subject;
private ReferenceType? _encounter;
private FhirDateTime? _started;
private List<ReferenceType>? _basedOn;
private List<ReferenceType>? _partOf;
private ReferenceType? _referrer;
private List<ReferenceType>? _endpoint;
private FhirUnsignedInt? _numberOfSeries;
private FhirUnsignedInt? _numberOfInstances;
private List<CodeableReference>? _procedure;
private ReferenceType? _location;
private List<CodeableReference>? _reason;
private List<Annotation>? _note;
private FhirString? _description;
private List<ImagingStudySeries>? _series;

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

public List<CodeableConcept>? Modality
{
get { return _modality; }
set {
_modality= value;
OnPropertyChanged("modality", value);
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

public FhirDateTime? Started
{
get { return _started; }
set {
_started= value;
OnPropertyChanged("started", value);
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

public ReferenceType? Referrer
{
get { return _referrer; }
set {
_referrer= value;
OnPropertyChanged("referrer", value);
}
}

public List<ReferenceType>? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
}
}

public FhirUnsignedInt? NumberOfSeries
{
get { return _numberOfSeries; }
set {
_numberOfSeries= value;
OnPropertyChanged("numberOfSeries", value);
}
}

public FhirUnsignedInt? NumberOfInstances
{
get { return _numberOfInstances; }
set {
_numberOfInstances= value;
OnPropertyChanged("numberOfInstances", value);
}
}

public List<CodeableReference>? Procedure
{
get { return _procedure; }
set {
_procedure= value;
OnPropertyChanged("procedure", value);
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

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
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

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<ImagingStudySeries>? Series
{
get { return _series; }
set {
_series= value;
OnPropertyChanged("series", value);
}
}


		#endregion
		#region Constructor
		public  ImagingStudy() { }
		public  ImagingStudy(string value) : base(value) { }
		public  ImagingStudy(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ImagingStudySeriesPerformer : BackboneElementType<ImagingStudySeriesPerformer>, IBackboneElementType
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
		public  ImagingStudySeriesPerformer() { }
		public  ImagingStudySeriesPerformer(string value) : base(value) { }
		public  ImagingStudySeriesPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImagingStudySeriesInstance : BackboneElementType<ImagingStudySeriesInstance>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _uid;
private Coding? _sopClass;
private FhirUnsignedInt? _number;
private FhirString? _title;

		#endregion
		#region public Method
		public FhirId? Uid
{
get { return _uid; }
set {
_uid= value;
OnPropertyChanged("uid", value);
}
}

public Coding? SopClass
{
get { return _sopClass; }
set {
_sopClass= value;
OnPropertyChanged("sopClass", value);
}
}

public FhirUnsignedInt? Number
{
get { return _number; }
set {
_number= value;
OnPropertyChanged("number", value);
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


		#endregion
		#region Constructor
		public  ImagingStudySeriesInstance() { }
		public  ImagingStudySeriesInstance(string value) : base(value) { }
		public  ImagingStudySeriesInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImagingStudySeries : BackboneElementType<ImagingStudySeries>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _uid;
private FhirUnsignedInt? _number;
private CodeableConcept? _modality;
private FhirString? _description;
private FhirUnsignedInt? _numberOfInstances;
private List<ReferenceType>? _endpoint;
private CodeableReference? _bodySite;
private CodeableConcept? _laterality;
private List<ReferenceType>? _specimen;
private FhirDateTime? _started;
private List<ImagingStudySeriesPerformer>? _performer;
private List<ImagingStudySeriesInstance>? _instance;

		#endregion
		#region public Method
		public FhirId? Uid
{
get { return _uid; }
set {
_uid= value;
OnPropertyChanged("uid", value);
}
}

public FhirUnsignedInt? Number
{
get { return _number; }
set {
_number= value;
OnPropertyChanged("number", value);
}
}

public CodeableConcept? Modality
{
get { return _modality; }
set {
_modality= value;
OnPropertyChanged("modality", value);
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

public FhirUnsignedInt? NumberOfInstances
{
get { return _numberOfInstances; }
set {
_numberOfInstances= value;
OnPropertyChanged("numberOfInstances", value);
}
}

public List<ReferenceType>? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
}
}

public CodeableReference? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public CodeableConcept? Laterality
{
get { return _laterality; }
set {
_laterality= value;
OnPropertyChanged("laterality", value);
}
}

public List<ReferenceType>? Specimen
{
get { return _specimen; }
set {
_specimen= value;
OnPropertyChanged("specimen", value);
}
}

public FhirDateTime? Started
{
get { return _started; }
set {
_started= value;
OnPropertyChanged("started", value);
}
}

public List<ImagingStudySeriesPerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
}
}

public List<ImagingStudySeriesInstance>? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}


		#endregion
		#region Constructor
		public  ImagingStudySeries() { }
		public  ImagingStudySeries(string value) : base(value) { }
		public  ImagingStudySeries(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
