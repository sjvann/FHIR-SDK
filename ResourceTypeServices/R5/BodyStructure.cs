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
    public class BodyStructure : ResourceType<BodyStructure>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private CodeableConcept? _morphology;
private List<BodyStructureIncludedStructure>? _includedStructure;
private FhirMarkdown? _description;
private List<Attachment>? _image;
private ReferenceType? _patient;

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

public FhirBoolean? Active
{
get { return _active; }
set {
_active= value;
OnPropertyChanged("active", value);
}
}

public CodeableConcept? Morphology
{
get { return _morphology; }
set {
_morphology= value;
OnPropertyChanged("morphology", value);
}
}

public List<BodyStructureIncludedStructure>? IncludedStructure
{
get { return _includedStructure; }
set {
_includedStructure= value;
OnPropertyChanged("includedStructure", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<Attachment>? Image
{
get { return _image; }
set {
_image= value;
OnPropertyChanged("image", value);
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


		#endregion
		#region Constructor
		public  BodyStructure() { }
		public  BodyStructure(string value) : base(value) { }
		public  BodyStructure(JsonNode? source) : base(source) { }
		#endregion
	}
		public class BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark : BackboneElementType<BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableReference>? _device;
private List<Quantity>? _value;

		#endregion
		#region public Method
		public List<CodeableReference>? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public List<Quantity>? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark() { }
		public  BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark(string value) : base(value) { }
		public  BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BodyStructureIncludedStructureBodyLandmarkOrientation : BackboneElementType<BodyStructureIncludedStructureBodyLandmarkOrientation>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _landmarkDescription;
private List<CodeableConcept>? _clockFacePosition;
private List<BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark>? _distanceFromLandmark;
private List<CodeableConcept>? _surfaceOrientation;

		#endregion
		#region public Method
		public List<CodeableConcept>? LandmarkDescription
{
get { return _landmarkDescription; }
set {
_landmarkDescription= value;
OnPropertyChanged("landmarkDescription", value);
}
}

public List<CodeableConcept>? ClockFacePosition
{
get { return _clockFacePosition; }
set {
_clockFacePosition= value;
OnPropertyChanged("clockFacePosition", value);
}
}

public List<BodyStructureIncludedStructureBodyLandmarkOrientationDistanceFromLandmark>? DistanceFromLandmark
{
get { return _distanceFromLandmark; }
set {
_distanceFromLandmark= value;
OnPropertyChanged("distanceFromLandmark", value);
}
}

public List<CodeableConcept>? SurfaceOrientation
{
get { return _surfaceOrientation; }
set {
_surfaceOrientation= value;
OnPropertyChanged("surfaceOrientation", value);
}
}


		#endregion
		#region Constructor
		public  BodyStructureIncludedStructureBodyLandmarkOrientation() { }
		public  BodyStructureIncludedStructureBodyLandmarkOrientation(string value) : base(value) { }
		public  BodyStructureIncludedStructureBodyLandmarkOrientation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class BodyStructureIncludedStructure : BackboneElementType<BodyStructureIncludedStructure>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _structure;
private CodeableConcept? _laterality;
private List<BodyStructureIncludedStructureBodyLandmarkOrientation>? _bodyLandmarkOrientation;
private List<ReferenceType>? _spatialReference;
private List<CodeableConcept>? _qualifier;

		#endregion
		#region public Method
		public CodeableConcept? Structure
{
get { return _structure; }
set {
_structure= value;
OnPropertyChanged("structure", value);
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

public List<BodyStructureIncludedStructureBodyLandmarkOrientation>? BodyLandmarkOrientation
{
get { return _bodyLandmarkOrientation; }
set {
_bodyLandmarkOrientation= value;
OnPropertyChanged("bodyLandmarkOrientation", value);
}
}

public List<ReferenceType>? SpatialReference
{
get { return _spatialReference; }
set {
_spatialReference= value;
OnPropertyChanged("spatialReference", value);
}
}

public List<CodeableConcept>? Qualifier
{
get { return _qualifier; }
set {
_qualifier= value;
OnPropertyChanged("qualifier", value);
}
}


		#endregion
		#region Constructor
		public  BodyStructureIncludedStructure() { }
		public  BodyStructureIncludedStructure(string value) : base(value) { }
		public  BodyStructureIncludedStructure(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
