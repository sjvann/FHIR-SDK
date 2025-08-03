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
    public class Location : ResourceType<Location>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private Coding? _operationalStatus;
private FhirString? _name;
private List<FhirString>? _alias;
private FhirMarkdown? _description;
private FhirCode? _mode;
private List<CodeableConcept>? _type;
private List<ExtendedContactDetail>? _contact;
private Address? _address;
private CodeableConcept? _form;
private LocationPosition? _position;
private ReferenceType? _managingOrganization;
private ReferenceType? _partOf;
private List<CodeableConcept>? _characteristic;
private List<Availability>? _hoursOfOperation;
private List<VirtualServiceDetail>? _virtualService;
private List<ReferenceType>? _endpoint;

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

public Coding? OperationalStatus
{
get { return _operationalStatus; }
set {
_operationalStatus= value;
OnPropertyChanged("operationalStatus", value);
}
}

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<FhirString>? Alias
{
get { return _alias; }
set {
_alias= value;
OnPropertyChanged("alias", value);
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

public FhirCode? Mode
{
get { return _mode; }
set {
_mode= value;
OnPropertyChanged("mode", value);
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

public List<ExtendedContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public Address? Address
{
get { return _address; }
set {
_address= value;
OnPropertyChanged("address", value);
}
}

public CodeableConcept? Form
{
get { return _form; }
set {
_form= value;
OnPropertyChanged("form", value);
}
}

public LocationPosition? Position
{
get { return _position; }
set {
_position= value;
OnPropertyChanged("position", value);
}
}

public ReferenceType? ManagingOrganization
{
get { return _managingOrganization; }
set {
_managingOrganization= value;
OnPropertyChanged("managingOrganization", value);
}
}

public ReferenceType? PartOf
{
get { return _partOf; }
set {
_partOf= value;
OnPropertyChanged("partOf", value);
}
}

public List<CodeableConcept>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}

public List<Availability>? HoursOfOperation
{
get { return _hoursOfOperation; }
set {
_hoursOfOperation= value;
OnPropertyChanged("hoursOfOperation", value);
}
}

public List<VirtualServiceDetail>? VirtualService
{
get { return _virtualService; }
set {
_virtualService= value;
OnPropertyChanged("virtualService", value);
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


		#endregion
		#region Constructor
		public  Location() { }
		public  Location(string value) : base(value) { }
		public  Location(JsonNode? source) : base(source) { }
		#endregion
	}
		public class LocationPosition : BackboneElementType<LocationPosition>, IBackboneElementType
	{

		#region Private Method
		private FhirDecimal? _longitude;
private FhirDecimal? _latitude;
private FhirDecimal? _altitude;

		#endregion
		#region public Method
		public FhirDecimal? Longitude
{
get { return _longitude; }
set {
_longitude= value;
OnPropertyChanged("longitude", value);
}
}

public FhirDecimal? Latitude
{
get { return _latitude; }
set {
_latitude= value;
OnPropertyChanged("latitude", value);
}
}

public FhirDecimal? Altitude
{
get { return _altitude; }
set {
_altitude= value;
OnPropertyChanged("altitude", value);
}
}


		#endregion
		#region Constructor
		public  LocationPosition() { }
		public  LocationPosition(string value) : base(value) { }
		public  LocationPosition(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
