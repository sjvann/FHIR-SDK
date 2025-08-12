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
    public class Organization : ResourceType<Organization>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private List<CodeableConcept>? _type;
private FhirString? _name;
private List<FhirString>? _alias;
private FhirMarkdown? _description;
private List<ExtendedContactDetail>? _contact;
private ReferenceType? _partOf;
private List<ReferenceType>? _endpoint;
private List<OrganizationQualification>? _qualification;

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

public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
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

public List<ExtendedContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
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

public List<ReferenceType>? Endpoint
{
get { return _endpoint; }
set {
_endpoint= value;
OnPropertyChanged("endpoint", value);
}
}

public List<OrganizationQualification>? Qualification
{
get { return _qualification; }
set {
_qualification= value;
OnPropertyChanged("qualification", value);
}
}


		#endregion
		#region Constructor
		public  Organization() { }
		public  Organization(string value) : base(value) { }
		public  Organization(JsonNode? source) : base(source) { }
		#endregion
	}
		public class OrganizationQualification : BackboneElementType<OrganizationQualification>, IBackboneElementType
	{

		#region Private Method
		private List<Identifier>? _identifier;
private CodeableConcept? _code;
private Period? _period;
private ReferenceType? _issuer;

		#endregion
		#region public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
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

public ReferenceType? Issuer
{
get { return _issuer; }
set {
_issuer= value;
OnPropertyChanged("issuer", value);
}
}


		#endregion
		#region Constructor
		public  OrganizationQualification() { }
		public  OrganizationQualification(string value) : base(value) { }
		public  OrganizationQualification(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
