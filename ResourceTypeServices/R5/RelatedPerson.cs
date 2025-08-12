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
    public class RelatedPerson : ResourceType<RelatedPerson>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private ReferenceType? _patient;
private List<CodeableConcept>? _relationship;
private List<HumanName>? _name;
private List<ContactPoint>? _telecom;
private FhirCode? _gender;
private FhirDate? _birthDate;
private List<Address>? _address;
private List<Attachment>? _photo;
private Period? _period;
private List<RelatedPersonCommunication>? _communication;

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

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
}
}

public List<CodeableConcept>? Relationship
{
get { return _relationship; }
set {
_relationship= value;
OnPropertyChanged("relationship", value);
}
}

public List<HumanName>? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public List<ContactPoint>? Telecom
{
get { return _telecom; }
set {
_telecom= value;
OnPropertyChanged("telecom", value);
}
}

public FhirCode? Gender
{
get { return _gender; }
set {
_gender= value;
OnPropertyChanged("gender", value);
}
}

public FhirDate? BirthDate
{
get { return _birthDate; }
set {
_birthDate= value;
OnPropertyChanged("birthDate", value);
}
}

public List<Address>? Address
{
get { return _address; }
set {
_address= value;
OnPropertyChanged("address", value);
}
}

public List<Attachment>? Photo
{
get { return _photo; }
set {
_photo= value;
OnPropertyChanged("photo", value);
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

public List<RelatedPersonCommunication>? Communication
{
get { return _communication; }
set {
_communication= value;
OnPropertyChanged("communication", value);
}
}


		#endregion
		#region Constructor
		public  RelatedPerson() { }
		public  RelatedPerson(string value) : base(value) { }
		public  RelatedPerson(JsonNode? source) : base(source) { }
		#endregion
	}
		public class RelatedPersonCommunication : BackboneElementType<RelatedPersonCommunication>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _language;
private FhirBoolean? _preferred;

		#endregion
		#region public Method
		public CodeableConcept? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public FhirBoolean? Preferred
{
get { return _preferred; }
set {
_preferred= value;
OnPropertyChanged("preferred", value);
}
}


		#endregion
		#region Constructor
		public  RelatedPersonCommunication() { }
		public  RelatedPersonCommunication(string value) : base(value) { }
		public  RelatedPersonCommunication(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		

}
