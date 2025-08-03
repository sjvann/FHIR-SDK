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
using FhirCore.Base;

namespace ResourceTypeServices.R5
{
    /// <summary>
    /// FHIR R5 Patient 資源
    /// </summary>
    public class Patient : ResourceBase
    {
        #region private Property
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private PatientDeceasedChoice? _deceased;
        private List<Address>? _address;
        private CodeableConcept? _maritalStatus;
        private PatientMultipleBirthChoice? _multipleBirth;
        private List<Attachment>? _photo;
        private List<PatientContact>? _contact;
        private List<PatientCommunication>? _communication;
        private List<ReferenceType>? _generalPractitioner;
        private ReferenceType? _managingOrganization;
        private List<PatientLink>? _link;
        #endregion

        #region Public Properties
        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier");
            }
        }
        public FhirBoolean? Active
        {
            get { return _active; }
            set
            {
                _active = value;
                OnPropertyChanged("active");
            }
        }
        public List<HumanName>? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name");
            }
        }
        public List<ContactPoint>? Telecom
        {
            get { return _telecom; }
            set
            {
                _telecom = value;
                OnPropertyChanged("telecom");
            }
        }
        public FhirCode? Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged("gender");
            }
        }
        public FhirDate? BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                OnPropertyChanged("birthDate");
            }
        }
        public PatientDeceasedChoice? Deceased
        {
            get { return _deceased; }
            set
            {
                _deceased = value;
                OnPropertyChanged("deceased");
            }
        }
        public List<Address>? Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("address");
            }
        }
        public CodeableConcept? MaritalStatus
        {
            get { return _maritalStatus; }
            set
            {
                _maritalStatus = value;
                OnPropertyChanged("maritalStatus");
            }
        }
        public PatientMultipleBirthChoice? MultipleBirth
        {
            get { return _multipleBirth; }
            set
            {
                _multipleBirth = value;
                OnPropertyChanged("multipleBirth");
            }
        }
        public List<Attachment>? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("photo");
            }
        }
        public List<PatientContact>? Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged("contact");
            }
        }
        public List<PatientCommunication>? Communication
        {
            get { return _communication; }
            set
            {
                _communication = value;
                OnPropertyChanged("communication");
            }
        }
        public List<ReferenceType>? GeneralPractitioner
        {
            get { return _generalPractitioner; }
            set
            {
                _generalPractitioner = value;
                OnPropertyChanged("generalPractitioner");
            }
        }
        public ReferenceType? ManagingOrganization
        {
            get { return _managingOrganization; }
            set
            {
                _managingOrganization = value;
                OnPropertyChanged("managingOrganization");
            }
        }
        public List<PatientLink>? Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged("link");
            }
        }
        #endregion

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Patient";

        /// <summary>
        /// 取得 FHIR 版本
        /// </summary>
        /// <returns>R5 版本</returns>
        public override string GetFhirVersion() => "R5";

        public Patient() { }
        public Patient(string value) : base() { }
        public Patient(JsonNode? source) : base() { }

        #region PatientContact
        public class PatientContact : BackboneElementType<PatientContact>, IBackboneElementType
        {
            #region private Property
            private List<CodeableConcept>? _relationship;
            private HumanName? _name;
            private List<ContactPoint>? _telecom;
            private Address? _address;
            private FhirCode? _gender;
            private ReferenceType? _organization;
            private Period? _period;
            #endregion

            #region Public Properties
            public List<CodeableConcept>? Relationship
            {
                get { return _relationship; }
                set
                {
                    _relationship = value;
                    OnPropertyChanged("relationship");
                }
            }
            public HumanName? Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    OnPropertyChanged("name");
                }
            }
            public List<ContactPoint>? Telecom
            {
                get { return _telecom; }
                set
                {
                    _telecom = value;
                    OnPropertyChanged("telecom");
                }
            }
            public Address? Address
            {
                get { return _address; }
                set
                {
                    _address = value;
                    OnPropertyChanged("address");
                }
            }
            public FhirCode? Gender
            {
                get { return _gender; }
                set
                {
                    _gender = value;
                    OnPropertyChanged("gender");
                }
            }
            public ReferenceType? Organization
            {
                get { return _organization; }
                set
                {
                    _organization = value;
                    OnPropertyChanged("organization");
                }
            }
            public Period? Period
            {
                get { return _period; }
                set
                {
                    _period = value;
                    OnPropertyChanged("period");
                }
            }
            #endregion

            public PatientContact() { }
            public PatientContact(string value) : base(value) { }
            public PatientContact(JsonObject? source) : base(source) { }
        }
        #endregion

        #region PatientCommunication
        public class PatientCommunication : BackboneElementType<PatientCommunication>, IBackboneElementType
        {
            #region private Property
            private CodeableConcept? _language;
            private FhirBoolean? _preferred;
            #endregion

            #region Public Properties
            public CodeableConcept? Language
            {
                get { return _language; }
                set
                {
                    _language = value;
                    OnPropertyChanged("language");
                }
            }
            public FhirBoolean? Preferred
            {
                get { return _preferred; }
                set
                {
                    _preferred = value;
                    OnPropertyChanged("preferred");
                }
            }
            #endregion

            public PatientCommunication() { }
            public PatientCommunication(string value) : base(value) { }
            public PatientCommunication(JsonObject? source) : base(source) { }
        }
        #endregion

        #region PatientLink
        public class PatientLink : BackboneElementType<PatientLink>, IBackboneElementType
        {
            #region private Property
            private ReferenceType? _other;
            private FhirCode? _type;
            #endregion

            #region Public Properties
            public ReferenceType? Other
            {
                get { return _other; }
                set
                {
                    _other = value;
                    OnPropertyChanged("other");
                }
            }
            public FhirCode? Type
            {
                get { return _type; }
                set
                {
                    _type = value;
                    OnPropertyChanged("type");
                }
            }
            #endregion

            public PatientLink() { }
            public PatientLink(string value) : base(value) { }
            public PatientLink(JsonObject? source) : base(source) { }
        }
        #endregion

        #region PatientDeceasedChoice
        public class PatientDeceasedChoice : ChoiceType
        {
            private static readonly List<string> _supportType = [
                "boolean",
                "dateTime"
            ];

            public PatientDeceasedChoice(JsonObject value) : base("deceased", value, _supportType) { }
            public PatientDeceasedChoice(IComplexType? value) : base("deceased", value) { }
            public PatientDeceasedChoice(IPrimitiveType? value) : base("deceased", value) { }
            public override string GetPrefixName(bool withCapital = true) => "deceased".ToTitleCase(withCapital);
            public override List<string> SetSupportDataType()
            {
                return _supportType;
            }
        }
        #endregion

        #region PatientMultipleBirthChoice
        public class PatientMultipleBirthChoice : ChoiceType
        {
            private static readonly List<string> _supportType = [
                "boolean",
                "integer"
            ];

            public PatientMultipleBirthChoice(JsonObject value) : base("multipleBirth", value, _supportType)
            {
            }
            public PatientMultipleBirthChoice(IComplexType? value) : base("multipleBirth", value)
            {
            }
            public PatientMultipleBirthChoice(IPrimitiveType? value) : base("multipleBirth", value) { }
            public override string GetPrefixName(bool withCapital = true) => "multipleBirth".ToTitleCase(withCapital);
            public override List<string> SetSupportDataType()
            {
                return _supportType;
            }
        }
        #endregion
    }
}
