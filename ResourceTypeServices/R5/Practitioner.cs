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
    public class Practitioner : ResourceType<Practitioner>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirBoolean? _active;
private List<HumanName>? _name;
private List<ContactPoint>? _telecom;
private FhirCode? _gender;
private FhirDate? _birthDate;
private PractitionerDeceasedChoice? _deceased;
private List<Address>? _address;
private List<Attachment>? _photo;
private List<PractitionerQualification>? _qualification;
private List<PractitionerCommunication>? _communication;

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

public PractitionerDeceasedChoice? Deceased
{
get { return _deceased; }
set {
_deceased= value;
OnPropertyChanged("deceased", value);
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

public List<PractitionerQualification>? Qualification
{
get { return _qualification; }
set {
_qualification= value;
OnPropertyChanged("qualification", value);
}
}

public List<PractitionerCommunication>? Communication
{
get { return _communication; }
set {
_communication= value;
OnPropertyChanged("communication", value);
}
}


		#endregion
		#region Constructor
		public  Practitioner() { }
		public  Practitioner(string value) : base(value) { }
		public  Practitioner(JsonNode? source) : base(source) { }
		#endregion
	}
		public class PractitionerQualification : BackboneElementType<PractitionerQualification>, IBackboneElementType
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
		public  PractitionerQualification() { }
		public  PractitionerQualification(string value) : base(value) { }
		public  PractitionerQualification(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class PractitionerCommunication : BackboneElementType<PractitionerCommunication>, IBackboneElementType
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
		public  PractitionerCommunication() { }
		public  PractitionerCommunication(string value) : base(value) { }
		public  PractitionerCommunication(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class PractitionerDeceasedChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "boolean","dateTime"
        ];

        public PractitionerDeceasedChoice(JsonObject value) : base("deceased", value, _supportType)
        {
        }
        public PractitionerDeceasedChoice(IComplexType? value) : base("deceased", value)
        {
        }
        public PractitionerDeceasedChoice(IPrimitiveType? value) : base("deceased", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"deceased".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
