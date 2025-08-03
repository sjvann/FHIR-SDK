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
    public class DeviceMetric : ResourceType<DeviceMetric>
	{
		#region private Property
		private List<Identifier>? _identifier;
private CodeableConcept? _type;
private CodeableConcept? _unit;
private ReferenceType? _device;
private FhirCode? _operationalStatus;
private FhirCode? _color;
private FhirCode? _category;
private Quantity? _measurementFrequency;
private List<DeviceMetricCalibration>? _calibration;

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

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? Unit
{
get { return _unit; }
set {
_unit= value;
OnPropertyChanged("unit", value);
}
}

public ReferenceType? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public FhirCode? OperationalStatus
{
get { return _operationalStatus; }
set {
_operationalStatus= value;
OnPropertyChanged("operationalStatus", value);
}
}

public FhirCode? Color
{
get { return _color; }
set {
_color= value;
OnPropertyChanged("color", value);
}
}

public FhirCode? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public Quantity? MeasurementFrequency
{
get { return _measurementFrequency; }
set {
_measurementFrequency= value;
OnPropertyChanged("measurementFrequency", value);
}
}

public List<DeviceMetricCalibration>? Calibration
{
get { return _calibration; }
set {
_calibration= value;
OnPropertyChanged("calibration", value);
}
}


		#endregion
		#region Constructor
		public  DeviceMetric() { }
		public  DeviceMetric(string value) : base(value) { }
		public  DeviceMetric(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceMetricCalibration : BackboneElementType<DeviceMetricCalibration>, IBackboneElementType
	{

		#region Private Method
		private FhirCode? _type;
private FhirCode? _state;
private FhirInstant? _time;

		#endregion
		#region public Method
		public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCode? State
{
get { return _state; }
set {
_state= value;
OnPropertyChanged("state", value);
}
}

public FhirInstant? Time
{
get { return _time; }
set {
_time= value;
OnPropertyChanged("time", value);
}
}


		#endregion
		#region Constructor
		public  DeviceMetricCalibration() { }
		public  DeviceMetricCalibration(string value) : base(value) { }
		public  DeviceMetricCalibration(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
