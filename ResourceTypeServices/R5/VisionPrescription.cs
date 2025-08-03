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
    public class VisionPrescription : ResourceType<VisionPrescription>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirDateTime? _created;
private ReferenceType? _patient;
private ReferenceType? _encounter;
private FhirDateTime? _dateWritten;
private ReferenceType? _prescriber;
private List<VisionPrescriptionLensSpecification>? _lensSpecification;

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

public FhirDateTime? Created
{
get { return _created; }
set {
_created= value;
OnPropertyChanged("created", value);
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

public FhirDateTime? DateWritten
{
get { return _dateWritten; }
set {
_dateWritten= value;
OnPropertyChanged("dateWritten", value);
}
}

public ReferenceType? Prescriber
{
get { return _prescriber; }
set {
_prescriber= value;
OnPropertyChanged("prescriber", value);
}
}

public List<VisionPrescriptionLensSpecification>? LensSpecification
{
get { return _lensSpecification; }
set {
_lensSpecification= value;
OnPropertyChanged("lensSpecification", value);
}
}


		#endregion
		#region Constructor
		public  VisionPrescription() { }
		public  VisionPrescription(string value) : base(value) { }
		public  VisionPrescription(JsonNode? source) : base(source) { }
		#endregion
	}
		public class VisionPrescriptionLensSpecificationPrism : BackboneElementType<VisionPrescriptionLensSpecificationPrism>, IBackboneElementType
	{

		#region Private Method
		private FhirDecimal? _amount;
private FhirCode? _base;

		#endregion
		#region public Method
		public FhirDecimal? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public FhirCode? Base
{
get { return _base; }
set {
_base= value;
OnPropertyChanged("base", value);
}
}


		#endregion
		#region Constructor
		public  VisionPrescriptionLensSpecificationPrism() { }
		public  VisionPrescriptionLensSpecificationPrism(string value) : base(value) { }
		public  VisionPrescriptionLensSpecificationPrism(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class VisionPrescriptionLensSpecification : BackboneElementType<VisionPrescriptionLensSpecification>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _product;
private FhirCode? _eye;
private FhirDecimal? _sphere;
private FhirDecimal? _cylinder;
private FhirInteger? _axis;
private List<VisionPrescriptionLensSpecificationPrism>? _prism;
private FhirDecimal? _add;
private FhirDecimal? _power;
private FhirDecimal? _backCurve;
private FhirDecimal? _diameter;
private Quantity? _duration;
private FhirString? _color;
private FhirString? _brand;
private List<Annotation>? _note;

		#endregion
		#region public Method
		public CodeableConcept? Product
{
get { return _product; }
set {
_product= value;
OnPropertyChanged("product", value);
}
}

public FhirCode? Eye
{
get { return _eye; }
set {
_eye= value;
OnPropertyChanged("eye", value);
}
}

public FhirDecimal? Sphere
{
get { return _sphere; }
set {
_sphere= value;
OnPropertyChanged("sphere", value);
}
}

public FhirDecimal? Cylinder
{
get { return _cylinder; }
set {
_cylinder= value;
OnPropertyChanged("cylinder", value);
}
}

public FhirInteger? Axis
{
get { return _axis; }
set {
_axis= value;
OnPropertyChanged("axis", value);
}
}

public List<VisionPrescriptionLensSpecificationPrism>? Prism
{
get { return _prism; }
set {
_prism= value;
OnPropertyChanged("prism", value);
}
}

public FhirDecimal? Add
{
get { return _add; }
set {
_add= value;
OnPropertyChanged("add", value);
}
}

public FhirDecimal? Power
{
get { return _power; }
set {
_power= value;
OnPropertyChanged("power", value);
}
}

public FhirDecimal? BackCurve
{
get { return _backCurve; }
set {
_backCurve= value;
OnPropertyChanged("backCurve", value);
}
}

public FhirDecimal? Diameter
{
get { return _diameter; }
set {
_diameter= value;
OnPropertyChanged("diameter", value);
}
}

public Quantity? Duration
{
get { return _duration; }
set {
_duration= value;
OnPropertyChanged("duration", value);
}
}

public FhirString? Color
{
get { return _color; }
set {
_color= value;
OnPropertyChanged("color", value);
}
}

public FhirString? Brand
{
get { return _brand; }
set {
_brand= value;
OnPropertyChanged("brand", value);
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
		public  VisionPrescriptionLensSpecification() { }
		public  VisionPrescriptionLensSpecification(string value) : base(value) { }
		public  VisionPrescriptionLensSpecification(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
