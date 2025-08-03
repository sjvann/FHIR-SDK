using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class Device : ResourceType<Device>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirString? _displayName;
private CodeableReference? _definition;
private List<DeviceUdiCarrier>? _udiCarrier;
private FhirCode? _status;
private CodeableConcept? _availabilityStatus;
private Identifier? _biologicalSourceEvent;
private FhirString? _manufacturer;
private FhirDateTime? _manufactureDate;
private FhirDateTime? _expirationDate;
private FhirString? _lotNumber;
private FhirString? _serialNumber;
private List<DeviceName>? _name;
private FhirString? _modelNumber;
private FhirString? _partNumber;
private List<CodeableConcept>? _category;
private List<CodeableConcept>? _type;
private List<DeviceVersion>? _version;
private List<DeviceConformsTo>? _conformsTo;
private List<DeviceProperty>? _property;
private CodeableConcept? _mode;
private Count? _cycle;
private Duration? _duration;
private ReferenceType? _owner;
private List<ContactPoint>? _contact;
private ReferenceType? _location;
private FhirUri? _url;
private List<ReferenceType>? _endpoint;
private List<CodeableReference>? _gateway;
private List<Annotation>? _note;
private List<CodeableConcept>? _safety;
private ReferenceType? _parent;

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

public FhirString? DisplayName
{
get { return _displayName; }
set {
_displayName= value;
OnPropertyChanged("displayName", value);
}
}

public CodeableReference? Definition
{
get { return _definition; }
set {
_definition= value;
OnPropertyChanged("definition", value);
}
}

public List<DeviceUdiCarrier>? UdiCarrier
{
get { return _udiCarrier; }
set {
_udiCarrier= value;
OnPropertyChanged("udiCarrier", value);
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

public CodeableConcept? AvailabilityStatus
{
get { return _availabilityStatus; }
set {
_availabilityStatus= value;
OnPropertyChanged("availabilityStatus", value);
}
}

public Identifier? BiologicalSourceEvent
{
get { return _biologicalSourceEvent; }
set {
_biologicalSourceEvent= value;
OnPropertyChanged("biologicalSourceEvent", value);
}
}

public FhirString? Manufacturer
{
get { return _manufacturer; }
set {
_manufacturer= value;
OnPropertyChanged("manufacturer", value);
}
}

public FhirDateTime? ManufactureDate
{
get { return _manufactureDate; }
set {
_manufactureDate= value;
OnPropertyChanged("manufactureDate", value);
}
}

public FhirDateTime? ExpirationDate
{
get { return _expirationDate; }
set {
_expirationDate= value;
OnPropertyChanged("expirationDate", value);
}
}

public FhirString? LotNumber
{
get { return _lotNumber; }
set {
_lotNumber= value;
OnPropertyChanged("lotNumber", value);
}
}

public FhirString? SerialNumber
{
get { return _serialNumber; }
set {
_serialNumber= value;
OnPropertyChanged("serialNumber", value);
}
}

public List<DeviceName>? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? ModelNumber
{
get { return _modelNumber; }
set {
_modelNumber= value;
OnPropertyChanged("modelNumber", value);
}
}

public FhirString? PartNumber
{
get { return _partNumber; }
set {
_partNumber= value;
OnPropertyChanged("partNumber", value);
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

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<DeviceVersion>? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public List<DeviceConformsTo>? ConformsTo
{
get { return _conformsTo; }
set {
_conformsTo= value;
OnPropertyChanged("conformsTo", value);
}
}

public List<DeviceProperty>? Property
{
get { return _property; }
set {
_property= value;
OnPropertyChanged("property", value);
}
}

public CodeableConcept? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
}
}

public Count? Cycle
{
get { return _cycle; }
set {
_cycle= value;
OnPropertyChanged("cycle", value);
}
}

public Duration? Duration
{
get { return _duration; }
set {
_duration= value;
OnPropertyChanged("duration", value);
}
}

public ReferenceType? Owner
{
get { return _owner; }
set {
_owner= value;
OnPropertyChanged("owner", value);
}
}

public List<ContactPoint>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
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

public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
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

public List<CodeableReference>? Gateway
{
get { return _gateway; }
set {
_gateway= value;
OnPropertyChanged("gateway", value);
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

public List<CodeableConcept>? Safety
{
get { return _safety; }
set {
_safety= value;
OnPropertyChanged("safety", value);
}
}

public ReferenceType? Parent
{
get { return _parent; }
set {
_parent= value;
OnPropertyChanged("parent", value);
}
}


		#endregion
		#region Constructor
		public  Device() { }
		public  Device(string value) : base(value) { }
		public  Device(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceUdiCarrier : BackboneElementType<DeviceUdiCarrier>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _deviceIdentifier;
private FhirUri? _issuer;
private FhirUri? _jurisdiction;
private FhirBase64Binary? _carrierAIDC;
private FhirString? _carrierHRF;
private FhirCode? _entryType;

		#endregion
		#region public Method
		public FhirString? DeviceIdentifier
{
get { return _deviceIdentifier; }
set {
_deviceIdentifier= value;
OnPropertyChanged("deviceIdentifier", value);
}
}

public FhirUri? Issuer
{
get { return _issuer; }
set {
_issuer= value;
OnPropertyChanged("issuer", value);
}
}

public FhirUri? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public FhirBase64Binary? CarrierAIDC
{
get { return _carrierAIDC; }
set {
_carrierAIDC= value;
OnPropertyChanged("carrierAIDC", value);
}
}

public FhirString? CarrierHRF
{
get { return _carrierHRF; }
set {
_carrierHRF= value;
OnPropertyChanged("carrierHRF", value);
}
}

public FhirCode? EntryType
{
get { return _entryType; }
set {
_entryType= value;
OnPropertyChanged("entryType", value);
}
}


		#endregion
		#region Constructor
		public  DeviceUdiCarrier() { }
		public  DeviceUdiCarrier(string value) : base(value) { }
		public  DeviceUdiCarrier(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceName : BackboneElementType<DeviceName>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _value;
private FhirCode? _type;
private FhirBoolean? _display;

		#endregion
		#region public Method
		public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirBoolean? Display
{
get { return _display; }
set {
_display= value;
OnPropertyChanged("display", value);
}
}


		#endregion
		#region Constructor
		public  DeviceName() { }
		public  DeviceName(string value) : base(value) { }
		public  DeviceName(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceVersion : BackboneElementType<DeviceVersion>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private Identifier? _component;
private FhirDateTime? _installDate;
private FhirString? _value;

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

public Identifier? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}

public FhirDateTime? InstallDate
{
get { return _installDate; }
set {
_installDate= value;
OnPropertyChanged("installDate", value);
}
}

public FhirString? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  DeviceVersion() { }
		public  DeviceVersion(string value) : base(value) { }
		public  DeviceVersion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceConformsTo : BackboneElementType<DeviceConformsTo>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _category;
private CodeableConcept? _specification;
private FhirString? _version;

		#endregion
		#region public Method
		public CodeableConcept? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public CodeableConcept? Specification
{
get { return _specification; }
set {
_specification= value;
OnPropertyChanged("specification", value);
}
}

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}


		#endregion
		#region Constructor
		public  DeviceConformsTo() { }
		public  DeviceConformsTo(string value) : base(value) { }
		public  DeviceConformsTo(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class DeviceProperty : BackboneElementType<DeviceProperty>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _type;
private DevicePropertyValueChoice? _value;

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

public DevicePropertyValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  DeviceProperty() { }
		public  DeviceProperty(string value) : base(value) { }
		public  DeviceProperty(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DevicePropertyValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","CodeableConceptstringbooleanintegerRangeAttachment"
        ];

        public DevicePropertyValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public DevicePropertyValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public DevicePropertyValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
