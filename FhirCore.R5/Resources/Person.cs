using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Person 資源
    /// 
    /// <para>
    /// Person 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var person = new Person("person-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Person 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Person : ResourceBase<R5Version>
    {
        private Property
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode<EnumAdministrativeGender>? _gender;
        private FhirDate? _birthdate;
        private PersonDeceasedChoice? _deceased;
        private List<Address>? _address;
        private CodeableConcept? _maritalstatus;
        private List<Attachment>? _photo;
        private List<PersonCommunication>? _communication;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingorganization;
        private List<PersonLink>? _link;
        private CodeableConcept? _language;
        private FhirBoolean? _preferred;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _target;
        private FhirCode? _assurance;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Person";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
        private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Active
        /// </summary>
        /// <remarks>
        /// <para>
        /// Active 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<HumanName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Telecom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Telecom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(Telecom));
            }
        }        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// <para>
        /// Gender 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode<EnumAdministrativeGender>? Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }        /// <summary>
        /// Birthdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Birthdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Birthdate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(Birthdate));
            }
        }        /// <summary>
        /// Deceased
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deceased 的詳細描述。
        /// </para>
        /// </remarks>
        public PersonDeceasedChoice? Deceased
        {
            get => _deceased;
            set
            {
                _deceased = value;
                OnPropertyChanged(nameof(Deceased));
            }
        }        /// <summary>
        /// Address
        /// </summary>
        /// <remarks>
        /// <para>
        /// Address 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Address>? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }        /// <summary>
        /// Maritalstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maritalstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Maritalstatus
        {
            get => _maritalstatus;
            set
            {
                _maritalstatus = value;
                OnPropertyChanged(nameof(Maritalstatus));
            }
        }        /// <summary>
        /// Photo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Photo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }        /// <summary>
        /// Communication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Communication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PersonCommunication>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }        /// <summary>
        /// Managingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Managingorganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(Managingorganization));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PersonLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Preferred
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preferred 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Preferred
        {
            get => _preferred;
            set
            {
                _preferred = value;
                OnPropertyChanged(nameof(Preferred));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Assurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assurance 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Assurance
        {
            get => _assurance;
            set
            {
                _assurance = value;
                OnPropertyChanged(nameof(Assurance));
            }
        }        /// <summary>
        /// 建立新的 Person 資源實例
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// 建立新的 Person 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Person(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Person(Id: {Id})";
        }
    }    /// <summary>
    /// PersonCommunication 背骨元素
    /// </summary>
    public class PersonCommunication
    {
        // TODO: 添加屬性實作
        
        public PersonCommunication() { }
    }    /// <summary>
    /// PersonLink 背骨元素
    /// </summary>
    public class PersonLink
    {
        // TODO: 添加屬性實作
        
        public PersonLink() { }
    }    /// <summary>
    /// PersonDeceasedChoice 選擇類型
    /// </summary>
    public class PersonDeceasedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PersonDeceasedChoice(JsonObject value) : base("persondeceased", value, _supportType) { }
        public PersonDeceasedChoice(IComplexType? value) : base("persondeceased", value) { }
        public PersonDeceasedChoice(IPrimitiveType? value) : base("persondeceased", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PersonDeceased" : "persondeceased";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
