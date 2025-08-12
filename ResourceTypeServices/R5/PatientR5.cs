using System.Collections.ObjectModel;
using FhirCore.Base;
using FhirCore.Interfaces;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace ResourceTypeServices.R5
{
    /// <summary>
    /// FHIR R5 Patient 資源
    /// 實作 R5 版本的 Patient 資源
    /// </summary>
    public class PatientR5 : ResourceBase
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private List<Address>? _address;
        private CodeableConcept? _maritalStatus;
        private List<Attachment>? _photo;
        private List<PatientContact>? _contact;
        private List<ReferenceType>? _generalPractitioner;
        private ReferenceType? _managingOrganization;
        private List<PatientLink>? _link;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Patient";

        /// <summary>
        /// 取得 FHIR 版本
        /// </summary>
        /// <returns>R5 版本</returns>
        public override string GetFhirVersion() => "5.0.0";

        /// <summary>
        /// 識別碼
        /// </summary>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }

        /// <summary>
        /// 是否為活躍狀態
        /// </summary>
        public FhirBoolean? Active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(Active));
            }
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public List<HumanName>? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// 聯絡方式
        /// </summary>
        public List<ContactPoint>? Telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(Telecom));
            }
        }

        /// <summary>
        /// 性別
        /// </summary>
        public FhirCode? Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        /// <summary>
        /// 出生日期
        /// </summary>
        public FhirDate? BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public List<Address>? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        /// <summary>
        /// 婚姻狀態
        /// </summary>
        public CodeableConcept? MaritalStatus
        {
            get => _maritalStatus;
            set
            {
                _maritalStatus = value;
                OnPropertyChanged(nameof(MaritalStatus));
            }
        }

        /// <summary>
        /// 照片
        /// </summary>
        public List<Attachment>? Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }

        /// <summary>
        /// 聯絡人
        /// </summary>
        public List<PatientContact>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// 家庭醫師
        /// </summary>
        public List<ReferenceType>? GeneralPractitioner
        {
            get => _generalPractitioner;
            set
            {
                _generalPractitioner = value;
                OnPropertyChanged(nameof(GeneralPractitioner));
            }
        }

        /// <summary>
        /// 管理組織
        /// </summary>
        public ReferenceType? ManagingOrganization
        {
            get => _managingOrganization;
            set
            {
                _managingOrganization = value;
                OnPropertyChanged(nameof(ManagingOrganization));
            }
        }

        /// <summary>
        /// 連結
        /// </summary>
        public List<PatientLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }

        /// <summary>
        /// 驗證 Patient 資源
        /// </summary>
        /// <returns>驗證結果</returns>
        public override ValidationResult Validate()
        {
            var results = new List<ValidationResult>();

            // 基本驗證
            var baseResult = base.Validate();
            if (baseResult != ValidationResult.Success)
            {
                results.Add(baseResult);
            }

            // R5 特定驗證
            if (Name != null && Name.Count > 0)
            {
                foreach (var name in Name)
                {
                    if (string.IsNullOrEmpty(name.Family))
                    {
                        results.Add(new ValidationResult("Patient 姓名必須包含姓氏"));
                    }
                }
            }

            // 驗證性別代碼
            if (Gender != null)
            {
                var validGenders = new[] { "male", "female", "other", "unknown" };
                if (!validGenders.Contains(Gender.Value))
                {
                    results.Add(new ValidationResult("性別代碼必須是有效的 FHIR 代碼"));
                }
            }

            return results.Count == 0 ? ValidationResult.Success! : new ValidationResult("Patient 資源驗證失敗");
        }

        /// <summary>
        /// 建立新的 Patient 實例
        /// </summary>
        public PatientR5()
        {
        }

        /// <summary>
        /// 建立新的 Patient 實例
        /// </summary>
        /// <param name="id">資源 ID</param>
        public PatientR5(string id)
        {
            Id = id;
        }
    }

    /// <summary>
    /// Patient 聯絡人
    /// </summary>
    public class PatientContact
    {
        /// <summary>
        /// 關係
        /// </summary>
        public List<CodeableConcept>? Relationship { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public HumanName? Name { get; set; }

        /// <summary>
        /// 聯絡方式
        /// </summary>
        public List<ContactPoint>? Telecom { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public Address? Address { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public FhirCode? Gender { get; set; }

        /// <summary>
        /// 組織
        /// </summary>
        public ReferenceType? Organization { get; set; }

        /// <summary>
        /// 期間
        /// </summary>
        public Period? Period { get; set; }
    }

    /// <summary>
    /// Patient 連結
    /// </summary>
    public class PatientLink
    {
        /// <summary>
        /// 其他資源
        /// </summary>
        public ReferenceType? Other { get; set; }

        /// <summary>
        /// 連結類型
        /// </summary>
        public FhirCode? Type { get; set; }
    }
} 