using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using FhirCore.Base;
using FhirCore.Interfaces;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;

namespace ResourceTypeServices.R4
{
    /// <summary>
    /// FHIR R4 Patient 資源
    /// 
    /// <para>
    /// Patient 資源涵蓋了從醫療保健角度獲得護理或其他健康相關服務的個人或動物的人口統計和其他管理資訊。
    /// 患者的數據通常包括（但不限於）姓名、聯絡資訊、性別、出生日期、地址、電話等。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var patient = new PatientR4("patient-001")
    /// {
    ///     Active = new FhirBoolean(true),
    ///     Name = new List&lt;HumanName&gt;
    ///     {
    ///         new HumanName
    ///         {
    ///             Use = new FhirCode("official"),
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
    /// R4 版本的 Patient 資源支援以下功能：
    /// - 基本人口統計資訊
    /// - 多重聯絡方式
    /// - 多重地址
    /// - 照片附件
    /// - 緊急聯絡人資訊
    /// - 醫療保健提供者參考
    /// - 與其他 Patient 資源的連結
    /// </para>
    /// 
    /// <para>
    /// 驗證規則：
    /// - 至少需要一個識別碼或姓名
    /// - 性別值必須是有效的 FHIR 代碼 (male, female, other, unknown)
    /// - 出生日期不能是未來日期
    /// - 聯絡方式必須有效
    /// - 地址格式必須正確
    /// </para>
    /// </remarks>
    public class PatientR4 : ResourceBase
    {
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private FhirBoolean? _deceased;
        private FhirDateTime? _deceasedDateTime;
        private List<Address>? _address;
        private CodeableConcept? _maritalStatus;
        private FhirBoolean? _multipleBirthBoolean;
        private FhirInteger? _multipleBirthInteger;
        private List<Attachment>? _photo;
        private List<PatientContactR4>? _contact;
        private List<PatientCommunicationR4>? _communication;
        private List<ReferenceType>? _generalPractitioner;
        private ReferenceType? _managingOrganization;
        private List<PatientLinkR4>? _link;

        /// <summary>
        /// 資源類型
        /// </summary>
        /// <value>固定值 "Patient"</value>
        public override string ResourceType => "Patient";

        /// <summary>
        /// 取得 FHIR 版本
        /// </summary>
        /// <returns>R4 版本號 "4.0.1"</returns>
        public override string GetFhirVersion() => "4.0.1";

        /// <summary>
        /// 識別碼
        /// 
        /// <para>
        /// 用於識別此患者的業務識別碼。這些識別碼通常由醫療保健系統分配，
        /// 如醫療記錄號碼、社會保險號碼等。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Identifier = new List&lt;Identifier&gt;
        /// {
        ///     new Identifier
        ///     {
        ///         Use = new FhirCode("usual"),
        ///         Type = new CodeableConcept
        ///         {
        ///             Coding = new List&lt;Coding&gt;
        ///             {
        ///                 new Coding
        ///                 {
        ///                     System = new FhirUri("http://terminology.hl7.org/CodeSystem/v2-0203"),
        ///                     Code = new FhirCode("MR"),
        ///                     Display = new FhirString("Medical Record Number")
        ///                 }
        ///             }
        ///         },
        ///         System = new FhirUri("http://hospital.example.com/patients"),
        ///         Value = new FhirString("12345")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 識別碼在醫療保健中非常重要，用於：
        /// - 唯一識別患者
        /// - 跨系統資料交換
        /// - 避免患者記錄重複
        /// - 支援醫療資訊的連結
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
        /// 
        /// <para>
        /// 指示此患者記錄是否處於活躍使用狀態。
        /// false 表示患者記錄不再使用，可能已合併到另一個記錄中。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Active = new FhirBoolean(true);  // 活躍患者
        /// patient.Active = new FhirBoolean(false); // 非活躍患者
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此欄位用於記錄管理：
        /// - true: 患者記錄處於活躍狀態
        /// - false: 患者記錄已停用或合併
        /// - null: 狀態未知
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
        /// 
        /// <para>
        /// 與患者相關的姓名。患者可能有多個姓名，包括官方姓名、暱稱、
        /// 舊姓名等不同用途的姓名。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Name = new List&lt;HumanName&gt;
        /// {
        ///     new HumanName
        ///     {
        ///         Use = new FhirCode("official"),
        ///         Family = new FhirString("王"),
        ///         Given = new List&lt;FhirString&gt; 
        ///         { 
        ///             new FhirString("小明"), 
        ///             new FhirString("志華") 
        ///         },
        ///         Prefix = new List&lt;FhirString&gt; { new FhirString("先生") }
        ///     },
        ///     new HumanName
        ///     {
        ///         Use = new FhirCode("nickname"),
        ///         Given = new List&lt;FhirString&gt; { new FhirString("小王") }
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 姓名的不同用途：
        /// - official: 官方正式姓名
        /// - usual: 常用姓名
        /// - nickname: 暱稱
        /// - old: 以前使用的姓名
        /// - maiden: 婚前姓名
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
        }

        /// <summary>
        /// 聯絡方式
        /// 
        /// <para>
        /// 聯絡患者的詳細資訊，包括電話號碼、電子郵件地址、傳真號碼等。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Telecom = new List&lt;ContactPoint&gt;
        /// {
        ///     new ContactPoint
        ///     {
        ///         System = new FhirCode("phone"),
        ///         Value = new FhirString("+886-2-12345678"),
        ///         Use = new FhirCode("home"),
        ///         Rank = new FhirPositiveInt(1)
        ///     },
        ///     new ContactPoint
        ///     {
        ///         System = new FhirCode("email"),
        ///         Value = new FhirString("patient@example.com"),
        ///         Use = new FhirCode("work")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 聯絡方式類型：
        /// - phone: 電話號碼
        /// - fax: 傳真號碼
        /// - email: 電子郵件
        /// - pager: 呼叫器
        /// - url: 網站地址
        /// - sms: 簡訊號碼
        /// - other: 其他方式
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
        /// 
        /// <para>
        /// 患者的行政性別。這是用於行政目的的性別，
        /// 可能不同於生理性別或性別認同。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Gender = new FhirCode("male");    // 男性
        /// patient.Gender = new FhirCode("female");  // 女性
        /// patient.Gender = new FhirCode("other");   // 其他
        /// patient.Gender = new FhirCode("unknown"); // 未知
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 有效的性別代碼：
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
        /// 
        /// <para>
        /// 患者的出生日期。可以是完整日期、僅年月或僅年份，
        /// 取決於已知資訊的精確程度。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.BirthDate = new FhirDate("1990-01-01");  // 完整日期
        /// patient.BirthDate = new FhirDate("1990-01");     // 年月
        /// patient.BirthDate = new FhirDate("1990");        // 僅年份
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 出生日期用於：
        /// - 計算年齡
        /// - 身份驗證
        /// - 年齡相關的醫療決策
        /// - 統計分析
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
        /// 是否已故（布林值）
        /// 
        /// <para>
        /// 指示患者是否已故。如果設為 true，表示患者已死亡，
        /// 但不提供具體的死亡時間。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Deceased = new FhirBoolean(false); // 在世
        /// patient.Deceased = new FhirBoolean(true);  // 已故
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 與 DeceasedDateTime 互斥，只能設定其中之一。
        /// </para>
        /// </remarks>
        public FhirBoolean? Deceased
        {
            get => _deceased;
            set
            {
                _deceased = value;
                OnPropertyChanged(nameof(Deceased));
            }
        }

        /// <summary>
        /// 死亡時間
        /// 
        /// <para>
        /// 如果患者已故，記錄具體的死亡日期和時間。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.DeceasedDateTime = new FhirDateTime("2023-12-01T14:30:00+08:00");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 與 Deceased 互斥，只能設定其中之一。
        /// 如果設定了 DeceasedDateTime，表示患者已故。
        /// </para>
        /// </remarks>
        public FhirDateTime? DeceasedDateTime
        {
            get => _deceasedDateTime;
            set
            {
                _deceasedDateTime = value;
                OnPropertyChanged(nameof(DeceasedDateTime));
            }
        }

        /// <summary>
        /// 地址
        /// 
        /// <para>
        /// 患者的地址資訊。患者可能有多個地址，包括住家地址、
        /// 工作地址、郵寄地址等。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Address = new List&lt;Address&gt;
        /// {
        ///     new Address
        ///     {
        ///         Use = new FhirCode("home"),
        ///         Type = new FhirCode("both"),
        ///         Line = new List&lt;FhirString&gt; { new FhirString("台北市信義區信義路五段7號") },
        ///         City = new FhirString("台北市"),
        ///         District = new FhirString("信義區"),
        ///         PostalCode = new FhirString("110"),
        ///         Country = new FhirString("台灣")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 地址用途類型：
        /// - home: 住家地址
        /// - work: 工作地址
        /// - temp: 臨時地址
        /// - old: 舊地址
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
        /// 
        /// <para>
        /// 患者的婚姻（民事）狀態。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.MaritalStatus = new CodeableConcept
        /// {
        ///     Coding = new List&lt;Coding&gt;
        ///     {
        ///         new Coding
        ///         {
        ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-MaritalStatus"),
        ///             Code = new FhirCode("M"),
        ///             Display = new FhirString("Married")
        ///         }
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常見的婚姻狀態代碼：
        /// - S: 單身 (Single)
        /// - M: 已婚 (Married)
        /// - D: 離婚 (Divorced)
        /// - W: 喪偶 (Widowed)
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
        /// 是否為多胞胎（布林值）
        /// 
        /// <para>
        /// 指示患者是否為多胞胎的一部分。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.MultipleBirthBoolean = new FhirBoolean(true); // 是多胞胎
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 與 MultipleBirthInteger 互斥，只能設定其中之一。
        /// </para>
        /// </remarks>
        public FhirBoolean? MultipleBirthBoolean
        {
            get => _multipleBirthBoolean;
            set
            {
                _multipleBirthBoolean = value;
                OnPropertyChanged(nameof(MultipleBirthBoolean));
            }
        }

        /// <summary>
        /// 多胞胎出生順序
        /// 
        /// <para>
        /// 如果患者是多胞胎的一部分，指示其出生順序。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.MultipleBirthInteger = new FhirInteger(2); // 第二個出生
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 與 MultipleBirthBoolean 互斥，只能設定其中之一。
        /// 數字 1 表示第一個出生，2 表示第二個，以此類推。
        /// </para>
        /// </remarks>
        public FhirInteger? MultipleBirthInteger
        {
            get => _multipleBirthInteger;
            set
            {
                _multipleBirthInteger = value;
                OnPropertyChanged(nameof(MultipleBirthInteger));
            }
        }

        /// <summary>
        /// 照片
        /// 
        /// <para>
        /// 患者的照片圖片。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Photo = new List&lt;Attachment&gt;
        /// {
        ///     new Attachment
        ///     {
        ///         ContentType = new FhirCode("image/jpeg"),
        ///         Data = new FhirBase64Binary("base64-encoded-image-data"),
        ///         Title = new FhirString("Patient Photo")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 照片用於：
        /// - 身份識別
        /// - 醫療記錄
        /// - 安全驗證
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
        /// 
        /// <para>
        /// 患者的聯絡人（如監護人、伴侶、朋友）。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Contact = new List&lt;PatientContactR4&gt;
        /// {
        ///     new PatientContactR4
        ///     {
        ///         Relationship = new List&lt;CodeableConcept&gt;
        ///         {
        ///             new CodeableConcept
        ///             {
        ///                 Coding = new List&lt;Coding&gt;
        ///                 {
        ///                     new Coding
        ///                     {
        ///                         System = new FhirUri("http://terminology.hl7.org/CodeSystem/v2-0131"),
        ///                         Code = new FhirCode("C"),
        ///                         Display = new FhirString("Emergency Contact")
        ///                     }
        ///                 }
        ///             }
        ///         },
        ///         Name = new HumanName
        ///         {
        ///             Family = new FhirString("李"),
        ///             Given = new List&lt;FhirString&gt; { new FhirString("小華") }
        ///         },
        ///         Telecom = new List&lt;ContactPoint&gt;
        ///         {
        ///             new ContactPoint
        ///             {
        ///                 System = new FhirCode("phone"),
        ///                 Value = new FhirString("+886-912345678"),
        ///                 Use = new FhirCode("mobile")
        ///             }
        ///         }
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 聯絡人關係類型：
        /// - C: 緊急聯絡人 (Emergency Contact)
        /// - F: 家人 (Family)
        /// - G: 監護人 (Guardian)
        /// - P: 伴侶 (Partner)
        /// </para>
        /// </remarks>
        public List<PatientContactR4>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }

        /// <summary>
        /// 溝通語言
        /// 
        /// <para>
        /// 可用於與患者溝通健康相關事務的語言。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Communication = new List&lt;PatientCommunicationR4&gt;
        /// {
        ///     new PatientCommunicationR4
        ///     {
        ///         Language = new CodeableConcept
        ///         {
        ///             Coding = new List&lt;Coding&gt;
        ///             {
        ///                 new Coding
        ///                 {
        ///                     System = new FhirUri("urn:ietf:bcp:47"),
        ///                     Code = new FhirCode("zh-TW"),
        ///                     Display = new FhirString("Chinese (Taiwan)")
        ///                 }
        ///             }
        ///         },
        ///         Preferred = new FhirBoolean(true)
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 語言偏好對於提供適當的醫療保健服務很重要。
        /// </para>
        /// </remarks>
        public List<PatientCommunicationR4>? Communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(Communication));
            }
        }

        /// <summary>
        /// 家庭醫師
        /// 
        /// <para>
        /// 患者指定的主要護理提供者。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.GeneralPractitioner = new List&lt;ReferenceType&gt;
        /// {
        ///     new ReferenceType
        ///     {
        ///         Reference = new FhirString("Practitioner/practitioner-001"),
        ///         Display = new FhirString("李醫師")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 可以引用 Practitioner、PractitionerRole 或 Organization 資源。
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
        /// 
        /// <para>
        /// 作為患者記錄保管者的組織。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.ManagingOrganization = new ReferenceType
        /// {
        ///     Reference = new FhirString("Organization/hospital-001"),
        ///     Display = new FhirString("台北醫院")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 通常是醫院、診所或其他醫療保健組織。
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
        /// 
        /// <para>
        /// 與涉及同一實際人員的另一個患者資源的連結。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// patient.Link = new List&lt;PatientLinkR4&gt;
        /// {
        ///     new PatientLinkR4
        ///     {
        ///         Other = new ReferenceType
        ///         {
        ///             Reference = new FhirString("Patient/patient-002")
        ///         },
        ///         Type = new FhirCode("replaced-by")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 連結類型：
        /// - replaced-by: 被取代
        /// - replaces: 取代
        /// - refer: 參考
        /// - seealso: 另見
        /// </para>
        /// </remarks>
        public List<PatientLinkR4>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }

        /// <summary>
        /// 初始化 PatientR4 類別的新執行個體
        /// </summary>
        public PatientR4() : base()
        {
        }

        /// <summary>
        /// 使用指定的 ID 初始化 PatientR4 類別的新執行個體
        /// </summary>
        /// <param name="id">患者的唯一識別碼</param>
        /// <exception cref="ArgumentException">當 ID 為空或 null 時擲出</exception>
        public PatientR4(string id) : this()
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("ID 不能為空", nameof(id));
            
            Id = id;
        }

        /// <summary>
        /// 執行 R4 特定的驗證
        /// </summary>
        /// <returns>驗證結果，如果驗證失敗則包含錯誤訊息</returns>
        /// <remarks>
        /// <para>
        /// R4 版本的驗證規則：
        /// - 至少需要一個識別碼或姓名
        /// - 性別值必須是有效值
        /// - 出生日期不能是未來日期
        /// - 死亡狀態邏輯檢查
        /// - 多胞胎資訊一致性檢查
        /// </para>
        /// </remarks>
        protected override System.ComponentModel.DataAnnotations.ValidationResult? ValidateVersionSpecific()
        {
            // 驗證患者必須有識別碼或姓名
            if ((Identifier == null || Identifier.Count == 0) && 
                (Name == null || Name.Count == 0))
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "Patient 至少需要一個識別碼或姓名");
            }

            // 驗證性別代碼
            if (Gender != null)
            {
                var validGenders = new[] { "male", "female", "other", "unknown" };
                if (!validGenders.Contains(Gender.Value))
                {
                    return new System.ComponentModel.DataAnnotations.ValidationResult(
                        $"性別代碼 '{Gender.Value}' 無效。有效值：{string.Join(", ", validGenders)}");
                }
            }

            // 驗證出生日期
            if (BirthDate?.Value != null)
            {
                if (BirthDate.Value > DateTime.Today)
                {
                    return new System.ComponentModel.DataAnnotations.ValidationResult(
                        "出生日期不能是未來日期");
                }
            }

            // 驗證死亡狀態
            if (Deceased?.Value == true && DeceasedDateTime?.Value != null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "Deceased 和 DeceasedDateTime 不能同時設定");
            }

            // 驗證多胞胎資訊
            if (MultipleBirthBoolean?.Value == true && MultipleBirthInteger?.Value != null)
            {
                return new System.ComponentModel.DataAnnotations.ValidationResult(
                    "MultipleBirthBoolean 和 MultipleBirthInteger 不能同時設定");
            }

            return null;
        }

        /// <summary>
        /// 建立患者的字串表示
        /// </summary>
        /// <returns>包含患者主要資訊的字串</returns>
        public override string ToString()
        {
            var name = Name?.FirstOrDefault()?.Family?.Value ?? "Unknown";
            var gender = Gender?.Value ?? "Unknown";
            var birthDate = BirthDate?.Value?.ToString("yyyy-MM-dd") ?? "Unknown";
            
            return $"PatientR4(Id: {Id}, Name: {name}, Gender: {gender}, BirthDate: {birthDate})";
        }
    }

    /// <summary>
    /// Patient 聯絡人（R4 版本）
    /// 
    /// <para>
    /// 表示患者的聯絡人資訊，如緊急聯絡人、監護人、家屬等。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的聯絡人支援完整的聯絡資訊和關係定義。
    /// </para>
    /// </remarks>
    public class PatientContactR4
    {
        /// <summary>
        /// 關係
        /// 
        /// <para>
        /// 聯絡人與患者的關係。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 常見關係：監護人、緊急聯絡人、家人、伴侶等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Relationship { get; set; }

        /// <summary>
        /// 姓名
        /// 
        /// <para>
        /// 與聯絡人相關的姓名。
        /// </para>
        /// </summary>
        public HumanName? Name { get; set; }

        /// <summary>
        /// 聯絡方式
        /// 
        /// <para>
        /// 聯絡人的聯絡詳細資訊。
        /// </para>
        /// </summary>
        public List<ContactPoint>? Telecom { get; set; }

        /// <summary>
        /// 地址
        /// 
        /// <para>
        /// 聯絡人的地址。
        /// </para>
        /// </summary>
        public Address? Address { get; set; }

        /// <summary>
        /// 性別
        /// 
        /// <para>
        /// 聯絡人的性別。
        /// </para>
        /// </summary>
        public FhirCode? Gender { get; set; }

        /// <summary>
        /// 組織
        /// 
        /// <para>
        /// 與聯絡人相關的組織。
        /// </para>
        /// </summary>
        public ReferenceType? Organization { get; set; }

        /// <summary>
        /// 期間
        /// 
        /// <para>
        /// 此聯絡人有效的期間。
        /// </para>
        /// </summary>
        public Period? Period { get; set; }
    }

    /// <summary>
    /// Patient 溝通語言（R4 版本）
    /// 
    /// <para>
    /// 表示可用於與患者溝通健康相關事務的語言。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本支援多語言偏好設定。
    /// </para>
    /// </remarks>
    public class PatientCommunicationR4
    {
        /// <summary>
        /// 語言
        /// 
        /// <para>
        /// ISO-639-1 alpha 2 代碼，結合可選的 ISO-3166-1 alpha 2 國家代碼。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 使用 BCP 47 語言標籤格式，如 "zh-TW"、"en-US" 等。
        /// </para>
        /// </remarks>
        [Required]
        public CodeableConcept? Language { get; set; }

        /// <summary>
        /// 偏好
        /// 
        /// <para>
        /// 表示此語言是否為患者的偏好語言。
        /// </para>
        /// </summary>
        public FhirBoolean? Preferred { get; set; }
    }

    /// <summary>
    /// Patient 連結（R4 版本）
    /// 
    /// <para>
    /// 表示與涉及同一實際人員的另一個患者資源的連結。
    /// </para>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的連結用於患者記錄合併和參考。
    /// </para>
    /// </remarks>
    public class PatientLinkR4
    {
        /// <summary>
        /// 其他資源
        /// 
        /// <para>
        /// 連結引用的其他患者或相關人員資源。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 必須引用 Patient 或 RelatedPerson 資源。
        /// </para>
        /// </remarks>
        [Required]
        public ReferenceType? Other { get; set; }

        /// <summary>
        /// 連結類型
        /// 
        /// <para>
        /// 此連結的類型。
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 有效值：replaced-by、replaces、refer、seealso。
        /// </para>
        /// </remarks>
        [Required]
        public FhirCode? Type { get; set; }
    }
}