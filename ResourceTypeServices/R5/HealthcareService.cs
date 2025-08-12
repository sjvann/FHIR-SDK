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
    public class HealthcareService : ResourceType<HealthcareService>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private ReferenceType? _providedBy;
private List<ReferenceType>? _offeredIn;
private List<CodeableConcept>? _category;
private List<CodeableConcept>? _type;
private List<CodeableConcept>? _specialty;
private List<ReferenceType>? _location;
private FhirString? _name;
private FhirMarkdown? _comment;
private FhirMarkdown? _extraDetails;
private Attachment? _photo;
private List<ExtendedContactDetail>? _contact;
private List<ReferenceType>? _coverageArea;
private List<CodeableConcept>? _serviceProvisionCode;
private List<HealthcareServiceEligibility>? _eligibility;
private List<CodeableConcept>? _program;
private List<CodeableConcept>? _characteristic;
private List<CodeableConcept>? _communication;
private List<CodeableConcept>? _referralMethod;
private FhirBoolean? _appointmentRequired;
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

public ReferenceType? ProvidedBy
{
get { return _providedBy; }
set {
_providedBy= value;
OnPropertyChanged("providedBy", value);
}
}

public List<ReferenceType>? OfferedIn
{
get { return _offeredIn; }
set {
_offeredIn= value;
OnPropertyChanged("offeredIn", value);
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

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirMarkdown? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}

public FhirMarkdown? ExtraDetails
{
get { return _extraDetails; }
set {
_extraDetails= value;
OnPropertyChanged("extraDetails", value);
}
}

public Attachment? Photo
{
get { return _photo; }
set {
_photo= value;
OnPropertyChanged("photo", value);
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

public List<ReferenceType>? CoverageArea
{
get { return _coverageArea; }
set {
_coverageArea= value;
OnPropertyChanged("coverageArea", value);
}
}

public List<CodeableConcept>? ServiceProvisionCode
{
get { return _serviceProvisionCode; }
set {
_serviceProvisionCode= value;
OnPropertyChanged("serviceProvisionCode", value);
}
}

public List<HealthcareServiceEligibility>? Eligibility
{
get { return _eligibility; }
set {
_eligibility= value;
OnPropertyChanged("eligibility", value);
}
}

public List<CodeableConcept>? Program
{
get { return _program; }
set {
_program= value;
OnPropertyChanged("program", value);
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

public List<CodeableConcept>? ReferralMethod
{
get { return _referralMethod; }
set {
_referralMethod= value;
OnPropertyChanged("referralMethod", value);
}
}

public FhirBoolean? AppointmentRequired
{
get { return _appointmentRequired; }
set {
_appointmentRequired= value;
OnPropertyChanged("appointmentRequired", value);
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
		public  HealthcareService() { }
		public  HealthcareService(string value) : base(value) { }
		public  HealthcareService(JsonNode? source) : base(source) { }
		#endregion
	}
		public class HealthcareServiceEligibility : BackboneElementType<HealthcareServiceEligibility>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private FhirMarkdown? _comment;

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

public FhirMarkdown? Comment
{
get { return _comment; }
set {
_comment= value;
OnPropertyChanged("comment", value);
}
}


		#endregion
		#region Constructor
		public  HealthcareServiceEligibility() { }
		public  HealthcareServiceEligibility(string value) : base(value) { }
		public  HealthcareServiceEligibility(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
