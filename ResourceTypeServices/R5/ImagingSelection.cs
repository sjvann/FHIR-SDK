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
    public class ImagingSelection : ResourceType<ImagingSelection>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private ReferenceType? _subject;
private FhirInstant? _issued;
private List<ImagingSelectionPerformer>? _performer;
private List<ReferenceType>? _basedOn;
private List<CodeableConcept>? _category;
private CodeableConcept? _code;
private FhirId? _studyUid;
private List<ReferenceType>? _derivedFrom;
private List<ReferenceType>? _endpoint;
private FhirId? _seriesUid;
private FhirUnsignedInt? _seriesNumber;
private FhirId? _frameOfReferenceUid;
private CodeableReference? _bodySite;
private List<ReferenceType>? _focus;
private List<ImagingSelectionInstance>? _instance;

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

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public FhirInstant? Issued
{
get { return _issued; }
set {
_issued= value;
OnPropertyChanged("issued", value);
}
}

public List<ImagingSelectionPerformer>? Performer
{
get { return _performer; }
set {
_performer= value;
OnPropertyChanged("performer", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
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

public FhirId? StudyUid
{
get { return _studyUid; }
set {
_studyUid= value;
OnPropertyChanged("studyUid", value);
}
}

public List<ReferenceType>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
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

public FhirId? SeriesUid
{
get { return _seriesUid; }
set {
_seriesUid= value;
OnPropertyChanged("seriesUid", value);
}
}

public FhirUnsignedInt? SeriesNumber
{
get { return _seriesNumber; }
set {
_seriesNumber= value;
OnPropertyChanged("seriesNumber", value);
}
}

public FhirId? FrameOfReferenceUid
{
get { return _frameOfReferenceUid; }
set {
_frameOfReferenceUid= value;
OnPropertyChanged("frameOfReferenceUid", value);
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

public List<ReferenceType>? Focus
{
get { return _focus; }
set {
_focus= value;
OnPropertyChanged("focus", value);
}
}

public List<ImagingSelectionInstance>? Instance
{
get { return _instance; }
set {
_instance= value;
OnPropertyChanged("instance", value);
}
}


		#endregion
		#region Constructor
		public  ImagingSelection() { }
		public  ImagingSelection(string value) : base(value) { }
		public  ImagingSelection(JsonNode? source) : base(source) { }
		#endregion
	}
		public class ImagingSelectionPerformer : BackboneElementType<ImagingSelectionPerformer>, IBackboneElementType
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
		public  ImagingSelectionPerformer() { }
		public  ImagingSelectionPerformer(string value) : base(value) { }
		public  ImagingSelectionPerformer(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImagingSelectionInstanceImageRegion2D : BackboneElementType<ImagingSelectionInstanceImageRegion2D>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _regionType;
private List<FhirDecimal>? _coordinate;

		#endregion
		#region public Method
		public FhirCode? RegionType
{
get { return _regionType; }
set {
_regionType= value;
OnPropertyChanged("regionType", value);
}
}

public List<FhirDecimal>? Coordinate
{
get { return _coordinate; }
set {
_coordinate= value;
OnPropertyChanged("coordinate", value);
}
}


		#endregion
		#region Constructor
		public  ImagingSelectionInstanceImageRegion2D() { }
		public  ImagingSelectionInstanceImageRegion2D(string value) : base(value) { }
		public  ImagingSelectionInstanceImageRegion2D(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImagingSelectionInstanceImageRegion3D : BackboneElementType<ImagingSelectionInstanceImageRegion3D>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _regionType;
private List<FhirDecimal>? _coordinate;

		#endregion
		#region public Method
		public FhirCode? RegionType
{
get { return _regionType; }
set {
_regionType= value;
OnPropertyChanged("regionType", value);
}
}

public List<FhirDecimal>? Coordinate
{
get { return _coordinate; }
set {
_coordinate= value;
OnPropertyChanged("coordinate", value);
}
}


		#endregion
		#region Constructor
		public  ImagingSelectionInstanceImageRegion3D() { }
		public  ImagingSelectionInstanceImageRegion3D(string value) : base(value) { }
		public  ImagingSelectionInstanceImageRegion3D(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class ImagingSelectionInstance : BackboneElementType<ImagingSelectionInstance>, IBackboneElementType
	{

		#region Private Method
		private FhirId? _uid;
private FhirUnsignedInt? _number;
private Coding? _sopClass;
private List<FhirString>? _subset;
private List<ImagingSelectionInstanceImageRegion2D>? _imageRegion2D;
private List<ImagingSelectionInstanceImageRegion3D>? _imageRegion3D;

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

public Coding? SopClass
{
get { return _sopClass; }
set {
_sopClass= value;
OnPropertyChanged("sopClass", value);
}
}

public List<FhirString>? Subset
{
get { return _subset; }
set {
_subset= value;
OnPropertyChanged("subset", value);
}
}

public List<ImagingSelectionInstanceImageRegion2D>? ImageRegion2D
{
get { return _imageRegion2D; }
set {
_imageRegion2D= value;
OnPropertyChanged("imageRegion2D", value);
}
}

public List<ImagingSelectionInstanceImageRegion3D>? ImageRegion3D
{
get { return _imageRegion3D; }
set {
_imageRegion3D= value;
OnPropertyChanged("imageRegion3D", value);
}
}


		#endregion
		#region Constructor
		public  ImagingSelectionInstance() { }
		public  ImagingSelectionInstance(string value) : base(value) { }
		public  ImagingSelectionInstance(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
