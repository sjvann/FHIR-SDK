using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using FhirCore.Base;
using FhirCore.Interfaces;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace ResourceTypeServices.R5
{
    /// <summary>
    /// FHIR R5 Basic 資源
    /// 
    /// <para>
    /// Basic 是用於記錄簡單資訊的資源，通常用於記錄不屬於其他標準 FHIR 資源的資訊。
    /// 這是一個低級別的資源，主要用於記錄基本的事實、事件或資訊。
    /// </para>
    /// 
    /// <para>
    /// 主要用途：
    /// - 記錄簡單的醫療資訊
    /// - 記錄不屬於標準資源的事件
    /// - 作為臨時資訊的容器
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var basic = new BasicR5("basic-001")
    /// {
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = "http://example.com/codes",
    ///                 Code = "patient-info",
    ///                 Display = "Patient Information"
    ///             }
    ///         }
    ///     },
    ///     Subject = new ReferenceType { Reference = "Patient/patient-001" },
    ///     Created = new FhirDateTime(DateTime.Now),
    ///     Author = new ReferenceType { Reference = "Practitioner/practitioner-001" }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Basic 資源是 FHIR 中最簡單的資源之一，主要用於記錄不屬於其他標準資源的資訊。
    /// 它提供了一個靈活的結構來記錄各種類型的資訊。
    /// </para>
    /// 
    /// <para>
    /// 驗證規則：
    /// - Code 屬性必須包含有效的 CodeableConcept
    /// - Subject 屬性必須包含有效的 Reference
    /// - Created 日期不能是未來日期
    /// - Author 必須是有效的 Practitioner 或 Organization 引用
    /// </para>
    /// 
    /// <para>
    /// 版本相容性：
    /// - R4: 支援基本屬性
    /// - R5: 增強了驗證規則和擴展支援
    /// </para>
    /// </remarks>
    public class BasicR5 : ResourceBase
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private ReferenceType? _subject;
        private FhirDateTime? _created;
        private ReferenceType? _author;

        /// <summary>
        /// 資源類型
        /// </summary>
        /// <value>固定值 "Basic"</value>
        public override string ResourceType => "Basic";

        /// <summary>
        /// 取得 FHIR 版本
        /// </summary>
        /// <returns>R5 版本號</returns>
        public override string GetFhirVersion() => "5.0.0";

        /// <summary>
        /// 識別碼
        /// 
        /// <para>
        /// 用於識別此 Basic 資源的業務識別碼。這些識別碼通常由創建資源的系統分配，
        /// 並用於在該系統內追蹤資源。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Identifier = new List&lt;Identifier&gt;
        /// {
        ///     new Identifier
        ///     {
        ///         System = "http://hospital.example.com/identifiers",
        ///         Value = "BASIC-2024-001"
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// 識別碼用於在特定系統或組織內唯一識別此資源。可以有多個識別碼，
    /// 每個識別碼代表不同的系統或用途。
    /// </para>
    /// 
    /// <para>
    /// 常見用途：
    /// - 醫院內部系統識別碼
    /// - 保險公司識別碼
    /// - 政府機構識別碼
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
    /// 代碼
    /// 
    /// <para>
    /// 表示此 Basic 資源所記錄資訊類型的代碼。這是一個必填欄位，
    /// 用於分類和識別 Basic 資源的用途。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// basic.Code = new CodeableConcept
    /// {
    ///     Coding = new List&lt;Coding&gt;
    ///     {
    ///         new Coding
    ///         {
    ///             System = "http://terminology.hl7.org/CodeSystem/basic-resource-type",
    ///             Code = "consent",
    ///             Display = "Consent"
    ///         }
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Code 是 Basic 資源的核心屬性，用於定義此資源記錄的資訊類型。
    /// 建議使用標準化的代碼系統來確保互操作性。
    /// </para>
    /// 
    /// <para>
    /// 常用代碼系統：
    /// - http://terminology.hl7.org/CodeSystem/basic-resource-type
    /// - http://hl7.org/fhir/ValueSet/basic-resource-type
    /// </para>
    /// </remarks>
    [Required(ErrorMessage = "Code 是必填欄位")]
    public CodeableConcept? Code
    {
        get => _code;
        set
        {
            _code = value;
            OnPropertyChanged(nameof(Code));
        }
    }

    /// <summary>
    /// 主體
    /// 
    /// <para>
    /// 此 Basic 資源所記錄資訊的主體。通常是 Patient、Group 或其他資源的引用。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// basic.Subject = new ReferenceType
    /// {
    ///     Reference = "Patient/patient-001",
    ///     Display = "張三"
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Subject 定義了此 Basic 資源記錄資訊的對象。可以是個人、群組或其他實體。
    /// </para>
    /// 
    /// <para>
    /// 常見的主體類型：
    /// - Patient: 患者
    /// - Group: 群組
    /// - Device: 設備
    /// - Location: 位置
    /// </para>
    /// </remarks>
    public ReferenceType? Subject
    {
        get => _subject;
        set
        {
            _subject = value;
            OnPropertyChanged(nameof(Subject));
        }
    }

    /// <summary>
    /// 創建日期
    /// 
    /// <para>
    /// 此 Basic 資源記錄的資訊被創建或記錄的日期時間。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// basic.Created = new FhirDateTime(DateTime.Now);
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Created 日期表示此 Basic 資源記錄的資訊被創建的時間點。
    /// 這對於追蹤資訊的時間線和審計目的很重要。
    /// </para>
    /// 
    /// <para>
    /// 驗證規則：
    /// - 不能是未來日期
    /// - 格式必須符合 FHIR DateTime 規範
    /// </para>
    /// </remarks>
    public FhirDateTime? Created
    {
        get => _created;
        set
        {
            _created = value;
            OnPropertyChanged(nameof(Created));
        }
    }

    /// <summary>
    /// 作者
    /// 
    /// <para>
    /// 創建或記錄此 Basic 資源資訊的個人或組織。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// basic.Author = new ReferenceType
    /// {
    ///     Reference = "Practitioner/practitioner-001",
    ///     Display = "李醫師"
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Author 表示負責創建或記錄此 Basic 資源資訊的實體。
    /// 這對於責任歸屬和審計追蹤很重要。
    /// </para>
    /// 
    /// <para>
    /// 常見的作者類型：
    /// - Practitioner: 醫護人員
    /// - Organization: 組織
    /// - Patient: 患者本人
    /// - RelatedPerson: 相關人員
    /// </para>
    /// </remarks>
    public ReferenceType? Author
    {
        get => _author;
        set
        {
            _author = value;
            OnPropertyChanged(nameof(Author));
        }
    }

    /// <summary>
    /// 驗證 Basic 資源
    /// </summary>
    /// <returns>驗證結果</returns>
    /// <remarks>
    /// <para>
    /// 執行以下驗證：
    /// - 基本資源驗證（繼承自 ResourceBase）
    /// - Code 屬性必須存在且有效
    /// - Created 日期不能是未來日期
    /// - Subject 和 Author 引用必須有效
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

        return results.Count == 0 ? ValidationResult.Success! : new ValidationResult("Basic 資源驗證失敗");
    }

    /// <summary>
    /// 建立新的 Basic 資源實例
    /// </summary>
    /// <remarks>
    /// <para>
    /// 創建一個空的 Basic 資源實例。所有屬性都初始化為 null。
    /// </para>
    /// </remarks>
    public BasicR5()
    {
    }

    /// <summary>
    /// 建立新的 Basic 資源實例
    /// </summary>
    /// <param name="id">資源的唯一識別碼</param>
    /// <remarks>
    /// <para>
    /// 創建一個具有指定 ID 的 Basic 資源實例。
    /// </para>
    /// </remarks>
    public BasicR5(string id)
    {
        Id = id;
    }

    /// <summary>
    /// 建立新的 Basic 資源實例
    /// </summary>
    /// <param name="id">資源的唯一識別碼</param>
    /// <param name="code">資源代碼</param>
    /// <param name="subject">主體引用</param>
    /// <remarks>
    /// <para>
    /// 創建一個具有基本屬性的 Basic 資源實例。
    /// </para>
    /// </remarks>
    public BasicR5(string id, CodeableConcept code, ReferenceType subject)
    {
        Id = id;
        Code = code;
        Subject = subject;
        Created = new FhirDateTime(DateTime.Now);
    }

    /// <summary>
    /// 驗證 R5 特定規則
    /// </summary>
    /// <returns>驗證結果列表</returns>
    /// <remarks>
    /// <para>
    /// 實作 R5 版本的特定驗證規則：
    /// - Code 必須包含有效的 Coding
    /// - Created 日期不能是未來日期
    /// - Subject 引用必須有效
    /// - Author 引用必須指向有效的資源類型
    /// </para>
    /// </remarks>
    private IEnumerable<ValidationResult> ValidateR5SpecificRules()
    {
        var results = new List<ValidationResult>();

        // 驗證 Code 屬性
        if (Code == null)
        {
            results.Add(new ValidationResult("Code 是必填欄位", new[] { nameof(Code) }));
        }
        else if (Code.Coding == null || Code.Coding.Count == 0)
        {
            results.Add(new ValidationResult("Code 必須包含至少一個 Coding", new[] { nameof(Code) }));
        }

        // 驗證 Created 日期
        if (Created != null)
        {
            var createdDate = Created.Value;
            if (createdDate > DateTime.Now)
            {
                results.Add(new ValidationResult("Created 日期不能是未來日期", new[] { nameof(Created) }));
            }
        }

        // 驗證 Subject 引用
        if (Subject != null)
        {
            if (string.IsNullOrEmpty(Subject.Reference))
            {
                results.Add(new ValidationResult("Subject 引用不能為空", new[] { nameof(Subject) }));
            }
            else
            {
                // 驗證引用格式
                var validResourceTypes = new[] { "Patient", "Group", "Device", "Location" };
                var resourceType = Subject.Reference.Split('/')[0];
                if (!validResourceTypes.Contains(resourceType))
                {
                    results.Add(new ValidationResult($"Subject 引用必須指向有效的資源類型: {string.Join(", ", validResourceTypes)}", new[] { nameof(Subject) }));
                }
            }
        }

        // 驗證 Author 引用
        if (Author != null)
        {
            if (string.IsNullOrEmpty(Author.Reference))
            {
                results.Add(new ValidationResult("Author 引用不能為空", new[] { nameof(Author) }));
            }
            else
            {
                // 驗證引用格式
                var validResourceTypes = new[] { "Practitioner", "Organization", "Patient", "RelatedPerson" };
                var resourceType = Author.Reference.Split('/')[0];
                if (!validResourceTypes.Contains(resourceType))
                {
                    results.Add(new ValidationResult($"Author 引用必須指向有效的資源類型: {string.Join(", ", validResourceTypes)}", new[] { nameof(Author) }));
                }
            }
        }

        return results;
    }

    /// <summary>
    /// 建立 Basic 資源的深層複製
    /// </summary>
    /// <returns>複製的 Basic 資源</returns>
    /// <remarks>
    /// <para>
    /// 創建此 Basic 資源的完整深層複製，包括所有屬性和集合。
    /// </para>
    /// </remarks>
    public new BasicR5 Clone()
    {
        var clone = (BasicR5)base.Clone();
        
        // 深層複製集合
        if (Identifier != null)
        {
            clone.Identifier = new List<Identifier>(Identifier.Select(i => new Identifier
            {
                System = i.System,
                Value = i.Value,
                Type = i.Type
            }));
        }

        return clone;
    }

    /// <summary>
    /// 轉換為字串表示
    /// </summary>
    /// <returns>字串表示</returns>
    /// <remarks>
    /// <para>
    /// 返回 Basic 資源的字串表示，格式為 "Basic(Id: {Id})"。
    /// </para>
    /// </remarks>
    public override string ToString()
    {
        return $"Basic(Id: {Id}, Code: {Code?.Coding?.FirstOrDefault()?.Display ?? "未設定"})";
    }
} 