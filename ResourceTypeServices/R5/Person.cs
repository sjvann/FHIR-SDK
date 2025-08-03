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
    public class Person : ResourceType<Person>
    {
        #region private Property
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode<EnumAdministrativeGender>? _gender;
        private FhirDate? _birthDate;
        private PersonDeceasedChoice? _deceased;
        private List<Address>? _address;
        private CodeableConcept? _maritalStatus;
        private List<Attachment>? _photo;
        private List<PersonCommunication>? _communication;
        private ReferenceType? _managingOrganization;
        private List<PersonLink>? _link;

        #endregion
        #region Public Method
        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        public FhirBoolean? Active
        {
            get { return _active; }
            set
            {
                _active = value;
                OnPropertyChanged("active", value);
            }
        }

        public List<HumanName>? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        public List<ContactPoint>? Telecom
        {
            get { return _telecom; }
            set
            {
                _telecom = value;
                OnPropertyChanged("telecom", value);
            }
        }

        public FhirCode<EnumAdministrativeGender>? Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged("gender", value);
            }
        }

        public FhirDate? BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                OnPropertyChanged("birthDate", value);
            }
        }

        public PersonDeceasedChoice? Deceased
        {
            get { return _deceased; }
            set
            {
                _deceased = value;
                OnPropertyChanged("deceased", value);
            }
        }

        public List<Address>? Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("address", value);
            }
        }

        public CodeableConcept? MaritalStatus
        {
            get { return _maritalStatus; }
            set
            {
                _maritalStatus = value;
                OnPropertyChanged("maritalStatus", value);
            }
        }

        public List<Attachment>? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("photo", value);
            }
        }

        public List<PersonCommunication>? Communication
        {
            get { return _communication; }
            set
            {
                _communication = value;
                OnPropertyChanged("communication", value);
            }
        }

        public ReferenceType? ManagingOrganization
        {
            get { return _managingOrganization; }
            set
            {
                _managingOrganization = value;
                OnPropertyChanged("managingOrganization", value);
            }
        }

        public List<PersonLink>? Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged("link", value);
            }
        }


        #endregion
        #region Constructor
        public Person() { }
        public Person(string value) : base(value) { }
        public Person(JsonNode? source) : base(source) { }
        #endregion
    }
    public class PersonCommunication : BackboneElementType<PersonCommunication>, IBackboneElementType
    {

        #region Private Method
        private CodeableConcept? _language;
        private FhirBoolean? _preferred;

        #endregion
        #region public Method
        public CodeableConcept? Language
        {
            get { return _language; }
            set
            {
                _language = value;
                OnPropertyChanged("language", value);
            }
        }

        public FhirBoolean? Preferred
        {
            get { return _preferred; }
            set
            {
                _preferred = value;
                OnPropertyChanged("preferred", value);
            }
        }


        #endregion
        #region Constructor
        public PersonCommunication() { }
        public PersonCommunication(string value) : base(value) { }
        public PersonCommunication(JsonObject? source) : base(source) { }
        #endregion
    }

    public class PersonLink : BackboneElementType<PersonLink>, IBackboneElementType
    {

        #region Private Method
        private ReferenceType? _target;
        private FhirCode? _assurance;

        #endregion
        #region public Method
        public ReferenceType? Target
        {
            get { return _target; }
            set
            {
                _target = value;
                OnPropertyChanged("target", value);
            }
        }

        public FhirCode? Assurance
        {
            get { return _assurance; }
            set
            {
                _assurance = value;
                OnPropertyChanged("assurance", value);
            }
        }


        #endregion
        #region Constructor
        public PersonLink() { }
        public PersonLink(string value) : base(value) { }
        public PersonLink(JsonObject? source) : base(source) { }
        #endregion
    }



    public class PersonDeceasedChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "boolean","dateTime"
        ];

        public PersonDeceasedChoice(JsonObject value) : base("deceased", value, _supportType)
        {
        }
        public PersonDeceasedChoice(IComplexType? value) : base("deceased", value)
        {
        }
        public PersonDeceasedChoice(IPrimitiveType? value) : base("deceased", value) { }

        public override string GetPrefixName(bool withCapital = true) => "deceased".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }


}
