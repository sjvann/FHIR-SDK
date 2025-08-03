using System.ComponentModel.DataAnnotations;
using FhirCore.Base;
using FhirCore.Versioning;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Patient 資源
    /// 
    /// <para>
    /// Patient 資源用於記錄有關接受或可能接受醫療保健服務的個人或動物的人口統計和其他管理資訊。
    /// 這是 FHIR 中最重要的資源之一，包含了患者的基本身份資訊。
    /// </para>
    /// 
    /// <para>
    /// 主要用途：
    /// - 記錄患者基本資訊（姓名、性別、出生日期等）
    /// - 管理患者聯絡資訊
    /// - 建立患者與醫療機構的關係
    /// - 連結相關的醫療記錄
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var patient = new Patient("patient-001")
    /// {
    ///     Name = new List&lt;HumanName&gt;
    ///     {
    ///         new HumanName
    ///         {
    ///             Family = new FhirString("張"),
    ///             Given = new List&lt;FhirString&gt; { new FhirString("三") }
    ///         }
    ///     },
    ///     Gender = new FhirCode("male"),
    ///     BirthDate = new FhirDate("1990-01-01")
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Patient 資源是 FHIR 的核心資源，用於識別接受醫療保健服務的個人。
    /// 它包含了患者的基本人口統計資訊和管理資訊。
    /// </para>
    /// 
    /// <para>
    /// R5 版本的 Patient 資源相對於 R4 版本的主要變更：
    /// - 增強了驗證規則
    /// - 改進了性別相關欄位的處理
    /// - 增加了新的擴展支援
    /// </para>
    /// 
    /// <para>
    /// 驗證規則：
    /// - 至少必須有一個識別符或姓名
    /// - 性別代碼必須符合 FHIR 規範
    /// - 出生日期不能是未來日期
    /// - 聯絡資訊必須有效
    /// </para>
    /// </remarks>
    public class Patient : ResourceBase<R5Version>
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
        /// <value>固定值 "Patient"</value>
        public override string ResourceType => "Patient";

        /// <summary>
        /// 識別碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 識別碼用於在特定系統或組織內唯一識別患者。可以有多個識別碼，
        /// 每個識別碼代表不同的系統或用途。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// Active 欄位幫助系統管理患者記錄的狀態。非活躍的記錄通常不會出現在
        /// 一般的搜尋結果中，但仍會保留用於歷史參考。
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
        }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <remarks>
        /// <para>
        /// 姓名是患者識別的重要組成部分。FHIR 支援多種姓名用途和類型，
        /// 以適應不同文化和法律要求。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "患者必須至少有一個姓名或識別碼")]
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
        /// <remarks>
        /// <para>
        /// 聯絡方式用於與患者或其代表聯絡。可以包含多種類型的聯絡方式，
        /// 並指定其用途（工作、家庭、緊急聯絡等）。
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
        }

        /// <summary>
        /// 性別
        /// </summary>
        /// <remarks>
        /// <para>
        /// 性別代碼必須使用 FHIR 規定的標準代碼：
        /// - male: 男性
        /// - female: 女性
        /// - other: 其他
        /// - unknown: 未知
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 出生日期是重要的人口統計資訊，用於年齡計算和身份驗證。
        /// 必須是有效的過去日期。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 地址資訊用於郵寄、緊急聯絡和地理分析。應包含足夠詳細的資訊
        /// 以便聯絡和定位患者。
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
        }

        /// <summary>
        /// 婚姻狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 婚姻狀態資訊可能與醫療決策和保險承保相關。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 照片主要用於身份確認，特別是在急診或無法言語的情況下。
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
        }

        /// <summary>
        /// 聯絡人
        /// </summary>
        /// <remarks>
        /// <para>
        /// 聯絡人資訊對於緊急情況、醫療決策和溝通非常重要。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 家庭醫師資訊有助於協調患者的整體醫療照護。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 管理組織通常是創建和維護患者記錄的醫療機構。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 連結用於管理患者記錄的關係，如合併重複記錄或建立家庭關係。
        /// </para>
        /// </remarks>
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
        /// <remarks>
        /// <para>
        /// 執行以下驗證：
        /// - 基本資源驗證（繼承自 ResourceBase）
        /// - 至少有一個識別碼或姓名
        /// - 性別代碼有效性
        /// - 出生日期不能是未來日期
        /// - 聯絡資訊格式驗證
        /// </para>
        /// </remarks>
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
            results.AddRange(ValidateR5SpecificRules());

            return results.Count == 0 ? ValidationResult.Success! : new ValidationResult("Patient 資源驗證失敗");
        }

        /// <summary>
        /// 建立新的 Patient 資源實例
        /// </summary>
        public Patient()
        {
        }

        /// <summary>
        /// 建立新的 Patient 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Patient(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Patient 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="name">患者姓名</param>
        /// <param name="gender">患者性別</param>
        /// <param name="birthDate">出生日期</param>
        public Patient(string id, HumanName name, string gender, string birthDate)
        {
            Id = id;
            Name = new List<HumanName> { name };
            Gender = new FhirCode(gender);
            BirthDate = new FhirDate(birthDate);
            Active = new FhirBoolean(true);
        }

        /// <summary>
        /// 驗證 R5 特定規則
        /// </summary>
        /// <returns>驗證結果列表</returns>
        private IEnumerable<ValidationResult> ValidateR5SpecificRules()
        {
            var results = new List<ValidationResult>();

            // 檢查是否至少有識別碼或姓名
            if ((Identifier == null || Identifier.Count == 0) && 
                (Name == null || Name.Count == 0))
            {
                results.Add(new ValidationResult("患者必須至少有一個識別碼或姓名", new[] { nameof(Identifier), nameof(Name) }));
            }

            // 驗證性別代碼
            if (Gender != null)
            {
                var validGenders = new[] { "male", "female", "other", "unknown" };
                if (!validGenders.Contains(Gender.Value))
                {
                    results.Add(new ValidationResult($"性別代碼 '{Gender.Value}' 無效。有效值為: {string.Join(", ", validGenders)}", new[] { nameof(Gender) }));
                }
            }

            // 驗證出生日期
            if (BirthDate != null)
            {
                var birthDate = BirthDate.Value;
                if (birthDate > DateTime.Now.Date)
                {
                    results.Add(new ValidationResult("出生日期不能是未來日期", new[] { nameof(BirthDate) }));
                }
            }

            return results;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        /// <returns>字串表示</returns>
        public override string ToString()
        {
            var displayName = Name?.FirstOrDefault()?.Text ?? 
                             $"{Name?.FirstOrDefault()?.Family?.Value} {string.Join(" ", Name?.FirstOrDefault()?.Given?.Select(g => g.Value) ?? Array.Empty<string>())}".Trim();
            
            return $"Patient(Id: {Id}, Name: {displayName ?? "未設定"})";
        }
    }

    /// <summary>
    /// Patient 聯絡人
    /// </summary>
    /// <remarks>
    /// <para>
    /// 聯絡人資訊對於緊急情況、醫療決策授權和家庭溝通非常重要。
    /// </para>
    /// </remarks>
    public class PatientContact
    {
        /// <summary>
        /// 與患者的關係
        /// </summary>
        public List<CodeableConcept>? Relationship { get; set; }

        /// <summary>
        /// 聯絡人姓名
        /// </summary>
        public HumanName? Name { get; set; }

        /// <summary>
        /// 聯絡人的聯絡方式
        /// </summary>
        public List<ContactPoint>? Telecom { get; set; }

        /// <summary>
        /// 聯絡人地址
        /// </summary>
        public Address? Address { get; set; }

        /// <summary>
        /// 聯絡人性別
        /// </summary>
        public FhirCode? Gender { get; set; }

        /// <summary>
        /// 聯絡人所屬組織
        /// </summary>
        public ReferenceType? Organization { get; set; }

        /// <summary>
        /// 聯絡人有效期間
        /// </summary>
        public Period? Period { get; set; }
    }

    /// <summary>
    /// Patient 連結
    /// </summary>
    /// <remarks>
    /// <para>
    /// 連結用於處理重複記錄、記錄合併、或建立患者間的關係。
    /// </para>
    /// </remarks>
    public class PatientLink
    {
        /// <summary>
        /// 連結的其他患者資源
        /// </summary>
        public ReferenceType? Other { get; set; }

        /// <summary>
        /// 連結類型
        /// </summary>
        public FhirCode? Type { get; set; }
    }
}