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
	public class PractitionerRole : ResourceType<PractitionerRole>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private Period? _period;
private ReferenceType? _practitioner;
private ReferenceType? _organization;
private List<CodeableConcept>? _code;
private List<CodeableConcept>? _specialty;
private List<ReferenceType>? _location;
private List<ReferenceType>? _healthcareService;
private List<ExtendedContactDetail>? _contact;
private List<CodeableConcept>? _characteristic;
private List<CodeableConcept>? _communication;
private List<Availability>? _availability;
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

public ReferenceType? Practitioner
{
get { return _practitioner; }
set {
_practitioner= value;
OnPropertyChanged("practitioner", value);
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

public List<CodeableConcept>? Characteristic
{
get { return _characteristic; }
set {
_characteristic= value;
OnPropertyChanged("characteristic", value);
}
}

public List<CodeableConcept>? Communication
{
get { return _communication; }
set {
_communication= value;
OnPropertyChanged("communication", value);
}
}

public List<Availability>? Availability
{
get { return _availability; }
set {
_availability= value;
OnPropertyChanged("availability", value);
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
		public  PractitionerRole() { }
		public  PractitionerRole(string value) : base(value) { }
		public  PractitionerRole(JsonNode? source) : base(source) { }
		#endregion
	}
	

		

}
