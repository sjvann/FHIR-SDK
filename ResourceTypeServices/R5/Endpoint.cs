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
    public class Endpoint : ResourceType<Endpoint>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private List<CodeableConcept>? _connectionType;
private FhirString? _name;
private FhirString? _description;
private List<CodeableConcept>? _environmentType;
private ReferenceType? _managingOrganization;
private List<ContactPoint>? _contact;
private Period? _period;
private List<EndpointPayload>? _payload;
private FhirUrl? _address;
private List<FhirString>? _header;

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

public List<CodeableConcept>? ConnectionType
{
get { return _connectionType; }
set {
_connectionType= value;
OnPropertyChanged("connectionType", value);
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

public FhirString? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<CodeableConcept>? EnvironmentType
{
get { return _environmentType; }
set {
_environmentType= value;
OnPropertyChanged("environmentType", value);
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

public List<ContactPoint>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
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

public List<EndpointPayload>? Payload
{
get { return _payload; }
set {
_payload= value;
OnPropertyChanged("payload", value);
}
}

public FhirUrl? Address
{
get { return _address; }
set {
_address= value;
OnPropertyChanged("address", value);
}
}

public List<FhirString>? Header
{
get { return _header; }
set {
_header= value;
OnPropertyChanged("header", value);
}
}


		#endregion
		#region Constructor
		public  Endpoint() { }
		public  Endpoint(string value) : base(value) { }
		public  Endpoint(JsonNode? source) : base(source) { }
		#endregion
	}
		public class EndpointPayload : BackboneElementType<EndpointPayload>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _type;
private List<FhirCode>? _mimeType;

		#endregion
		#region public Method
		public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<FhirCode>? MimeType
{
get { return _mimeType; }
set {
_mimeType= value;
OnPropertyChanged("mimeType", value);
}
}


		#endregion
		#region Constructor
		public  EndpointPayload() { }
		public  EndpointPayload(string value) : base(value) { }
		public  EndpointPayload(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
