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
	public class OrganizationAffiliation : ResourceType<OrganizationAffiliation>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private Period? _period;
private ReferenceType? _organization;
private ReferenceType? _participatingOrganization;
private List<ReferenceType>? _network;
private List<CodeableConcept>? _code;
private List<CodeableConcept>? _specialty;
private List<ReferenceType>? _location;
private List<ReferenceType>? _healthcareService;
private List<ExtendedContactDetail>? _contact;
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

public FhirBoolean? Active
{
get { return _active; }
set {
_active= value;
OnPropertyChanged("active", value);
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

public ReferenceType? Organization
{
get { return _organization; }
set {
_organization= value;
OnPropertyChanged("organization", value);
}
}

public ReferenceType? ParticipatingOrganization
{
get { return _participatingOrganization; }
set {
_participatingOrganization= value;
OnPropertyChanged("participatingOrganization", value);
}
}

public List<ReferenceType>? Network
{
get { return _network; }
set {
_network= value;
OnPropertyChanged("network", value);
}
}

public List<CodeableConcept>? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<CodeableConcept>? Specialty
{
get { return _specialty; }
set {
_specialty= value;
OnPropertyChanged("specialty", value);
}
}

public List<ReferenceType>? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public List<ReferenceType>? HealthcareService
{
get { return _healthcareService; }
set {
_healthcareService= value;
OnPropertyChanged("healthcareService", value);
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
		public  OrganizationAffiliation() { }
		public  OrganizationAffiliation(string value) : base(value) { }
		public  OrganizationAffiliation(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
