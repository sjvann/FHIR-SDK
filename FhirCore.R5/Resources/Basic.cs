using System.ComponentModel.DataAnnotations;
using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Basic 資源
    /// 
    /// <para>
    /// Basic 是一個通用資源，通常用於記錄不在其他 FHIR 資源範圍內的資訊。
    /// 這是一個彈性的資源，主要用於儲存基本資料結構和資料物件資訊。
    /// </para>
    /// 
    /// <para>
    /// 主要用途：
    /// - 記錄通用的檔案資訊
    /// - 儲存不在標準資源結構範圍內的資料
    /// - 暫存性資訊的容器
    /// - 自訂義資源或擴充資料的基礎
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var basic = new Basic("basic-001")
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
    ///     Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType { Reference = "Patient/patient-001" },
    ///     Created = new FhirDateTime(DateTime.Now),
    ///     Author = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType { Reference = "Practitioner/practitioner-001" }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Basic 資源是 FHIR 架構中的彈性資源之一，提供了一個通用的結構來記錄
    /// 不在標準資源結構範圍內的各種資訊。這特別有用於處理特定或特殊的業務需求。
    /// </para>
    /// 
    /// <para>
    /// R5 版本的 Basic 資源相對於 R4 版本的主要變更：
    /// - 增強了驗證規則
    /// - 改進了關聯性檢查
    /// - 新增了更多支援欄位
    /// - 強化了 Code 屬性的描述性定義
    /// </para>
    /// 
    /// <para>
    /// 驗證規則：
    /// - Code 屬性必須包含有效的 CodeableConcept
    /// - Subject 屬性必須包含有效的 Reference
    /// - Created 不能是未來的時間
    /// - Author 必須是有效的 Practitioner 或 Organization 引用
    /// </para>
    /// 
    /// <para>
    /// 最佳實踐：
    /// - 使用標準化的內容標識符號表達 Code
    /// - 確保 Subject 引用是有效並且可查詢的
    /// - 建議添加 Created 與 Author 資訊用於審計
    /// - 在可能的情況下，盡量使用專門的 FHIR 資源而非 Basic
    /// </para>
    /// </remarks>
    public class Basic : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;

        /// <summary>
        /// 資源類型
        /// </summary>
        /// <value>確定為 "Basic"</value>
        public override string ResourceType => "Basic";

        /// <summary>
        /// 識別碼
        /// 
        /// <para>
        /// 用於識別該 Basic 資源的外部識別碼。這些識別碼通常由建立資源的系統或組織提供，
        /// 並用於在不同系統間追蹤或參照該資源。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Identifier = new List&lt;Identifier&gt;
        /// {
        ///     new Identifier
        ///     {
        ///         System = new FhirUri("http://hospital.example.com/identifiers"),
        ///         Value = new FhirString("BASIC-2024-001")
        ///     }
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// 識別碼用於在沒有固定系統唯一性的環境下確保資源的唯一識別。可以有多個識別碼，
        /// 每個識別碼來自不同的系統或用於不同的用途。
        /// </para>
        /// 
        /// <para>
        /// 常見的用途：
        /// - 醫院內部系統識別碼
        /// - 保險公司識別碼  
        /// - 研究案識別碼
        /// - 檔案序號
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
        /// 識別該 Basic 資源所記錄資訊類別的代碼。這是一個必填欄位，
        /// 用於區分和識別 Basic 資源的用途。
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
        ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/basic-resource-type"),
        ///             Code = new FhirCode("consent"),
        ///             Display = new FhirString("Consent")
        ///         }
        ///     },
        ///     Text = new FhirString("同意書")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 是 Basic 資源的核心屬性，用於定義該資源是儲存什麼類型的資訊。
        /// 建議使用標準化的代碼系統來確保語義的一致性。
        /// </para>
        /// 
        /// <para>
        /// 常用代碼系統：
        /// - http://terminology.hl7.org/CodeSystem/basic-resource-type
        /// - http://hl7.org/fhir/ValueSet/basic-resource-type
        /// - 組織特定的代碼系統
        /// </para>
        /// 
        /// <para>
        /// 驗證規則：
        /// - 必須包含至少一個有效的 Coding 或 Text
        /// - Coding 的 System 與 Code 都必須填寫
        /// - 建議包含 Display 用於人類閱讀
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
        /// 該 Basic 資源所記錄資訊的主體。通常是 Patient、Group 或其他資源的引用。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
        /// {
        ///     Reference = new FhirString("Patient/patient-001"),
        ///     Display = new FhirString("張三"),
        ///     Type = new FhirUri("Patient")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 定義了該 Basic 資源是關於誰或什麼的資訊。可以是個人、群體或其他實體。
        /// </para>
        /// 
        /// <para>
        /// 常見的主體資源類型：
        /// - Patient: 患者（最常見）
        /// - Group: 患者群體
        /// - Device: 裝置設備
        /// - Location: 位置場所
        /// - Organization: 組織
        /// </para>
        /// 
        /// <para>
        /// 驗證規則：
        /// - Reference 必須符合 FHIR 引用格式
        /// - 被引用的資源應該是存在的（若可進行查詢驗證）
        /// - Type 必須與引用的資源類型一致
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        /// <summary>
        /// 建立時間
        /// 
        /// <para>
        /// 該 Basic 資源是記錄資訊被建立或記錄的時間點。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Created = new FhirDateTime(DateTime.Now);
        /// // 或使用特定的日期
        /// basic.Created = new FhirDateTime("2024-01-15T14:30:00+08:00");
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 代表該 Basic 資源是記錄資訊被建立的時間點。
        /// 這個資訊的時間性與審計追蹤非常重要。
        /// </para>
        /// 
        /// <para>
        /// 驗證規則：
        /// - 不能是未來的時間（允許最多5分鐘的系統時間誤差）
        /// - 格式必須符合 FHIR DateTime 標準
        /// - 建議包含時區資訊
        /// </para>
        /// 
        /// <para>
        /// 最佳實踐：
        /// - 使用系統目前時間作為預設值
        /// - 確保時區資訊的正確
        /// - 考慮資料發生時間vs記錄時間的差別
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
        /// 建立或記錄該 Basic 資源資訊的個人或組織。
        /// </para>
        /// 
        /// <example>
        /// <code>
        /// basic.Author = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
        /// {
        ///     Reference = new FhirString("Practitioner/practitioner-001"),
        ///     Display = new FhirString("王醫師"),
        ///     Type = new FhirUri("Practitioner")
        /// };
        /// </code>
        /// </example>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 識別負責建立或記錄該 Basic 資源資訊的實體。
        /// 這對責任追蹤和審計追蹤非常重要。
        /// </para>
        /// 
        /// <para>
        /// 常見的作者資源類型：
        /// - Practitioner: 醫療人員
        /// - Organization: 組織機構
        /// - Patient: 患者本人（自我記錄）
        /// - RelatedPerson: 相關人員（如家屬）
        /// - Device: 自動記錄設備
        /// </para>
        /// 
        /// <para>
        /// 驗證規則：
        /// - Reference 必須指向有效的資源實例
        /// - 被引用的資源必須具有記錄該資訊的權限
        /// - Type 必須與引用的資源類型一致
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(Author));
            }
        }

        /// <summary>
        /// 建立新的 Basic 資源實例
        /// </summary>
        /// <remarks>
        /// <para>
        /// 建立一個空的 Basic 資源實例。所有屬性都初始化為 null。
        /// 建議在建立後立即設定必要的屬性（特別是 Code）。
        /// </para>
        /// </remarks>
        public Basic()
        {
        }

        /// <summary>
        /// 建立新的 Basic 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <remarks>
        /// <para>
        /// 建立一個具有指定 ID 的 Basic 資源實例。
        /// </para>
        /// </remarks>
        public Basic(string id)
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
        /// 建立一個包含基本資訊的 Basic 資源實例，並自動設定建立時間。
        /// </para>
        /// </remarks>
        public Basic(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            Id = id;
            Code = code;
            Subject = subject;
            Created = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// 建立新的 Basic 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="code">資源代碼</param>
        /// <param name="subject">主體引用</param>
        /// <param name="author">作者引用</param>
        /// <remarks>
        /// <para>
        /// 建立一個包含完整基本資訊的 Basic 資源實例。
        /// </para>
        /// </remarks>
        public Basic(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject, DataTypeServices.DataTypes.SpecialTypes.ReferenceType author)
        {
            Id = id;
            Code = code;
            Subject = subject;
            Author = author;
            Created = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// 驗證 Basic 資源
        /// </summary>
        /// <returns>驗證結果</returns>
        /// <remarks>
        /// <para>
        /// 驗證以下項目：
        /// - 基本資源驗證（來自 ResourceBase）
        /// - Code 屬性必須存在並有效
        /// - Created 不能是未來時間
        /// - Subject 與 Author 引用的有效性
        /// - R5 特定的驗證規則檢查
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
        /// 驗證 R5 特定規則
        /// </summary>
        /// <returns>驗證結果列表</returns>
        /// <remarks>
        /// <para>
        /// 執行 R5 版本特定的驗證規則：
        /// - Code 必須包含有效的 Coding 或 Text
        /// - Created 不能是未來時間
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
            else
            {
                bool hasValidCoding = Code.Coding?.Any(c => 
                    !string.IsNullOrEmpty(c.System?.Value) && 
                    !string.IsNullOrEmpty(c.Code?.Value)) == true;
                
                bool hasText = !string.IsNullOrEmpty(Code.Text?.Value);

                if (!hasValidCoding && !hasText)
                {
                    results.Add(new ValidationResult("Code 必須包含至少一個有效的 Coding 或 Text", new[] { nameof(Code) }));
                }
            }

            // 驗證 Created 日期
            if (Created != null)
            {
                var createdDate = Created.Value;
                if (createdDate > DateTime.Now.AddMinutes(5)) // 允許5分鐘的系統時間誤差
                {
                    results.Add(new ValidationResult("Created 不能是未來時間", new[] { nameof(Created) }));
                }
            }

            // 驗證 Subject 引用
            if (Subject != null)
            {
                if (string.IsNullOrEmpty(Subject.Reference?.Value))
                {
                    results.Add(new ValidationResult("Subject 引用不能為空", new[] { nameof(Subject) }));
                }
                else
                {
                    // 檢查引用格式
                    var validResourceTypes = new[] { "Patient", "Group", "Device", "Location", "Organization" };
                    var parts = Subject.Reference.Value.Split('/');
                    if (parts.Length >= 1)
                    {
                        var resourceType = parts[0];
                        if (!validResourceTypes.Contains(resourceType))
                        {
                            results.Add(new ValidationResult(
                                $"Subject 引用必須指向有效的資源類型: {string.Join(", ", validResourceTypes)}", 
                                new[] { nameof(Subject) }));
                        }
                    }
                }
            }

            // 驗證 Author 引用
            if (Author != null)
            {
                if (string.IsNullOrEmpty(Author.Reference?.Value))
                {
                    results.Add(new ValidationResult("Author 引用不能為空", new[] { nameof(Author) }));
                }
                else
                {
                    // 檢查引用格式
                    var validResourceTypes = new[] { "Practitioner", "Organization", "Patient", "RelatedPerson", "Device" };
                    var parts = Author.Reference.Value.Split('/');
                    if (parts.Length >= 1)
                    {
                        var resourceType = parts[0];
                        if (!validResourceTypes.Contains(resourceType))
                        {
                            results.Add(new ValidationResult(
                                $"Author 引用必須指向有效的資源類型: {string.Join(", ", validResourceTypes)}", 
                                new[] { nameof(Author) }));
                        }
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
        /// 建立該 Basic 資源的完整深層複製，包含所有屬性和集合。
        /// </para>
        /// </remarks>
        public new Basic Clone()
        {
            var clone = (Basic)base.Clone();
            
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
        /// 返回 Basic 資源的字串表示，包含 ID 與 Code 資訊。
        /// </para>
        /// </remarks>
        public override string ToString()
        {
            var codeDisplay = Code?.Text?.Value ?? 
                             Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                             Code?.Coding?.FirstOrDefault()?.Code?.Value ?? 
                             "未設定";
            
            return $"Basic(Id: {Id}, Code: {codeDisplay})";
        }
    }
}