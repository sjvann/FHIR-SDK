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
    public class SubstancePolymer : ResourceType<SubstancePolymer>
	{
		#region private Property
		private Identifier? _identifier;
private CodeableConcept? _class;
private CodeableConcept? _geometry;
private List<CodeableConcept>? _copolymerConnectivity;
private FhirString? _modification;
private List<SubstancePolymerMonomerSet>? _monomerSet;
private List<SubstancePolymerRepeat>? _repeat;

		#endregion
		#region Public Method
		public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public CodeableConcept? Class
{
get { return _class; }
set {
_class= value;
OnPropertyChanged("class", value);
}
}

public CodeableConcept? Geometry
{
get { return _geometry; }
set {
_geometry= value;
OnPropertyChanged("geometry", value);
}
}

public List<CodeableConcept>? CopolymerConnectivity
{
get { return _copolymerConnectivity; }
set {
_copolymerConnectivity= value;
OnPropertyChanged("copolymerConnectivity", value);
}
}

public FhirString? Modification
{
get { return _modification; }
set {
_modification= value;
OnPropertyChanged("modification", value);
}
}

public List<SubstancePolymerMonomerSet>? MonomerSet
{
get { return _monomerSet; }
set {
_monomerSet= value;
OnPropertyChanged("monomerSet", value);
}
}

public List<SubstancePolymerRepeat>? Repeat
{
get { return _repeat; }
set {
_repeat= value;
OnPropertyChanged("repeat", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymer() { }
		public  SubstancePolymer(string value) : base(value) { }
		public  SubstancePolymer(JsonNode? source) : base(source) { }
		#endregion
	}
		public class SubstancePolymerMonomerSetStartingMaterial : BackboneElementType<SubstancePolymerMonomerSetStartingMaterial>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private CodeableConcept? _category;
private FhirBoolean? _isDefining;
private Quantity? _amount;

		#endregion
		#region public Method
		public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public FhirBoolean? IsDefining
{
get { return _isDefining; }
set {
_isDefining= value;
OnPropertyChanged("isDefining", value);
}
}

public Quantity? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymerMonomerSetStartingMaterial() { }
		public  SubstancePolymerMonomerSetStartingMaterial(string value) : base(value) { }
		public  SubstancePolymerMonomerSetStartingMaterial(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstancePolymerMonomerSet : BackboneElementType<SubstancePolymerMonomerSet>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _ratioType;
private List<SubstancePolymerMonomerSetStartingMaterial>? _startingMaterial;

		#endregion
		#region public Method
		public CodeableConcept? RatioType
{
get { return _ratioType; }
set {
_ratioType= value;
OnPropertyChanged("ratioType", value);
}
}

public List<SubstancePolymerMonomerSetStartingMaterial>? StartingMaterial
{
get { return _startingMaterial; }
set {
_startingMaterial= value;
OnPropertyChanged("startingMaterial", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymerMonomerSet() { }
		public  SubstancePolymerMonomerSet(string value) : base(value) { }
		public  SubstancePolymerMonomerSet(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation : BackboneElementType<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirInteger? _average;
private FhirInteger? _low;
private FhirInteger? _high;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirInteger? Average
{
get { return _average; }
set {
_average= value;
OnPropertyChanged("average", value);
}
}

public FhirInteger? Low
{
get { return _low; }
set {
_low= value;
OnPropertyChanged("low", value);
}
}

public FhirInteger? High
{
get { return _high; }
set {
_high= value;
OnPropertyChanged("high", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation() { }
		public  SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation(string value) : base(value) { }
		public  SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstancePolymerRepeatRepeatUnitStructuralRepresentation : BackboneElementType<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private FhirString? _representation;
private CodeableConcept? _format;
private Attachment? _attachment;

		#endregion
		#region public Method
		public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirString? Representation
{
get { return _representation; }
set {
_representation= value;
OnPropertyChanged("representation", value);
}
}

public CodeableConcept? Format
{
get { return _format; }
set {
_format= value;
OnPropertyChanged("format", value);
}
}

public Attachment? Attachment
{
get { return _attachment; }
set {
_attachment= value;
OnPropertyChanged("attachment", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymerRepeatRepeatUnitStructuralRepresentation() { }
		public  SubstancePolymerRepeatRepeatUnitStructuralRepresentation(string value) : base(value) { }
		public  SubstancePolymerRepeatRepeatUnitStructuralRepresentation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstancePolymerRepeatRepeatUnit : BackboneElementType<SubstancePolymerRepeatRepeatUnit>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _unit;
private CodeableConcept? _orientation;
private FhirInteger? _amount;
private List<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>? _degreeOfPolymerisation;
private List<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>? _structuralRepresentation;

		#endregion
		#region public Method
		public FhirString? Unit
{
get { return _unit; }
set {
_unit= value;
OnPropertyChanged("unit", value);
}
}

public CodeableConcept? Orientation
{
get { return _orientation; }
set {
_orientation= value;
OnPropertyChanged("orientation", value);
}
}

public FhirInteger? Amount
{
get { return _amount; }
set {
_amount= value;
OnPropertyChanged("amount", value);
}
}

public List<SubstancePolymerRepeatRepeatUnitDegreeOfPolymerisation>? DegreeOfPolymerisation
{
get { return _degreeOfPolymerisation; }
set {
_degreeOfPolymerisation= value;
OnPropertyChanged("degreeOfPolymerisation", value);
}
}

public List<SubstancePolymerRepeatRepeatUnitStructuralRepresentation>? StructuralRepresentation
{
get { return _structuralRepresentation; }
set {
_structuralRepresentation= value;
OnPropertyChanged("structuralRepresentation", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymerRepeatRepeatUnit() { }
		public  SubstancePolymerRepeatRepeatUnit(string value) : base(value) { }
		public  SubstancePolymerRepeatRepeatUnit(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class SubstancePolymerRepeat : BackboneElementType<SubstancePolymerRepeat>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _averageMolecularFormula;
private CodeableConcept? _repeatUnitAmountType;
private List<SubstancePolymerRepeatRepeatUnit>? _repeatUnit;

		#endregion
		#region public Method
		public FhirString? AverageMolecularFormula
{
get { return _averageMolecularFormula; }
set {
_averageMolecularFormula= value;
OnPropertyChanged("averageMolecularFormula", value);
}
}

public CodeableConcept? RepeatUnitAmountType
{
get { return _repeatUnitAmountType; }
set {
_repeatUnitAmountType= value;
OnPropertyChanged("repeatUnitAmountType", value);
}
}

public List<SubstancePolymerRepeatRepeatUnit>? RepeatUnit
{
get { return _repeatUnit; }
set {
_repeatUnit= value;
OnPropertyChanged("repeatUnit", value);
}
}


		#endregion
		#region Constructor
		public  SubstancePolymerRepeat() { }
		public  SubstancePolymerRepeat(string value) : base(value) { }
		public  SubstancePolymerRepeat(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
