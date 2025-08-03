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
    /// FHIR R5 Condition 資源
    /// 
    /// <para>
    /// 用於記錄患者的疾病、診斷、症狀或其他健康狀況。
    /// Condition 是臨床診斷的核心資源，描述患者的健康問題或關注點。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var condition = new Condition("condition-001")
    /// {
    ///     ClinicalStatus = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-clinical"),
    ///                 Code = new FhirCode("active"),
    ///                 Display = new FhirString("Active")
    ///             }
    ///         }
    ///     },
    ///     VerificationStatus = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/condition-ver-status"),
    ///                 Code = new FhirCode("confirmed"),
    ///                 Display = new FhirString("Confirmed")
    ///             }
    ///         }
    ///     },
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://snomed.info/sct"),
    ///                 Code = new FhirCode("73211009"),
    ///                 Display = new FhirString("Diabetes mellitus")
    ///             }
    ///         }
    ///     },
    ///     Subject = new DataTypeServices.DataTypes.SpecialTypes.ReferenceType
    ///     {
    ///         Reference = new FhirString("Patient/patient-001"),
    ///         Display = new FhirString("王小明")
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Condition 資源可以記錄各種類型的健康狀況：
    /// - 確診疾病（如糖尿病、高血壓）
    /// - 症狀（如頭痛、發燒）
    /// - 健康關注點（如過敏反應風險）
    /// - 診斷（主要診斷、次要診斷）
    /// - 問題列表項目
    /// </para>
    /// 
    /// <para>
    /// R5 版本的主要特點：
    /// - 增強的參與者管理
    /// - 改進的階段追蹤
    /// - 更靈活的發病和緩解時間記錄
    /// - 支援更詳細的證據記錄
    /// - 改善的身體部位描述
    /// </para>
    /// </remarks>
    public class Condition : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _clinicalStatus;
        private CodeableConcept? _verificationStatus;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _severity;
        private CodeableConcept? _code;
        private List<CodeableConcept>? _bodySite;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private ConditionOnsetChoice? _onset;
        private ConditionAbatementChoice? _abatement;
        private FhirDateTime? _recordedDate;
        private List<ConditionParticipant>? _participant;
        private List<ConditionStage>? _stage;
        private List<CodeableReference>? _evidence;
        private List<Annotation>? _note;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Condition";

        /// <summary>
        /// 識別碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件的外部識別碼，如診斷編號、問題列表編號等。
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
        /// 臨床狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件的臨床狀態，如 active、inactive、resolved 等。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "條件必須有臨床狀態")]
        public CodeableConcept? ClinicalStatus
        {
            get => _clinicalStatus;
            set
            {
                _clinicalStatus = value;
                OnPropertyChanged(nameof(ClinicalStatus));
            }
        }

        /// <summary>
        /// 驗證狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件診斷的確定程度，如 provisional、differential、confirmed 等。
        /// </para>
        /// </remarks>
        public CodeableConcept? VerificationStatus
        {
            get => _verificationStatus;
            set
            {
                _verificationStatus = value;
                OnPropertyChanged(nameof(VerificationStatus));
            }
        }

        /// <summary>
        /// 條件分類
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件的分類，如主要診斷、次要診斷、問題列表等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        /// <summary>
        /// 嚴重程度
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件的嚴重程度，如輕微、中等、嚴重等。
        /// </para>
        /// </remarks>
        public CodeableConcept? Severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(Severity));
            }
        }

        /// <summary>
        /// 條件代碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 識別條件、問題或診斷的代碼，通常使用 SNOMED CT、ICD-10 等標準代碼系統。
        /// </para>
        /// </remarks>
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
        /// 身體部位
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件影響的身體部位或系統。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? BodySite
        {
            get => _bodySite;
            set
            {
                _bodySite = value;
                OnPropertyChanged(nameof(BodySite));
            }
        }

        /// <summary>
        /// 條件主體
        /// </summary>
        /// <remarks>
        /// <para>
        /// 具有此條件的患者或群組。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "條件必須有主體")]
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
        /// 相關就診
        /// </summary>
        /// <remarks>
        /// <para>
        /// 診斷或記錄此條件的就診。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }

        /// <summary>
        /// 發病時間
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件開始或首次被識別的時間。
        /// </para>
        /// </remarks>
        public ConditionOnsetChoice? Onset
        {
            get => _onset;
            set
            {
                _onset = value;
                OnPropertyChanged(nameof(Onset));
            }
        }

        /// <summary>
        /// 緩解時間
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件結束、緩解或不再是關注點的時間。
        /// </para>
        /// </remarks>
        public ConditionAbatementChoice? Abatement
        {
            get => _abatement;
            set
            {
                _abatement = value;
                OnPropertyChanged(nameof(Abatement));
            }
        }

        /// <summary>
        /// 記錄日期
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件被記錄在系統中的日期。
        /// </para>
        /// </remarks>
        public FhirDateTime? RecordedDate
        {
            get => _recordedDate;
            set
            {
                _recordedDate = value;
                OnPropertyChanged(nameof(RecordedDate));
            }
        }

        /// <summary>
        /// 參與者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與診斷或治療此條件的人員。
        /// </para>
        /// </remarks>
        public List<ConditionParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }

        /// <summary>
        /// 階段
        /// </summary>
        /// <remarks>
        /// <para>
        /// 條件的臨床階段或等級。
        /// </para>
        /// </remarks>
        public List<ConditionStage>? Stage
        {
            get => _stage;
            set
            {
                _stage = value;
                OnPropertyChanged(nameof(Stage));
            }
        }

        /// <summary>
        /// 證據
        /// </summary>
        /// <remarks>
        /// <para>
        /// 支持條件存在或嚴重程度的證據。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Evidence
        {
            get => _evidence;
            set
            {
                _evidence = value;
                OnPropertyChanged(nameof(Evidence));
            }
        }

        /// <summary>
        /// 註解
        /// </summary>
        /// <remarks>
        /// <para>
        /// 關於條件的額外註解或說明。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }

        /// <summary>
        /// 建立新的 Condition 資源實例
        /// </summary>
        public Condition()
        {
        }

        /// <summary>
        /// 建立新的 Condition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Condition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Condition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="code">條件代碼</param>
        /// <param name="subject">條件主體</param>
        public Condition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject)
        {
            Id = id;
            Code = code;
            Subject = subject;
            RecordedDate = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// 建立新的 Condition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="code">條件代碼</param>
        /// <param name="subject">條件主體</param>
        /// <param name="clinicalStatus">臨床狀態</param>
        /// <param name="verificationStatus">驗證狀態</param>
        public Condition(string id, CodeableConcept code, DataTypeServices.DataTypes.SpecialTypes.ReferenceType subject, 
            CodeableConcept clinicalStatus, CodeableConcept? verificationStatus = null)
        {
            Id = id;
            Code = code;
            Subject = subject;
            ClinicalStatus = clinicalStatus;
            VerificationStatus = verificationStatus;
            RecordedDate = new FhirDateTime(DateTime.Now);
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            var codeDisplay = Code?.Text?.Value ?? 
                              Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                              "未知條件";

            var status = ClinicalStatus?.Coding?.FirstOrDefault()?.Code?.Value ?? "狀態未知";
            var subjectRef = Subject?.Reference?.Value ?? "主體未知";
            
            return $"Condition(Id: {Id}, Code: {codeDisplay}, Status: {status}, Subject: {subjectRef})";
        }
    }

    /// <summary>
    /// 條件參與者
    /// </summary>
    /// <remarks>
    /// <para>
    /// 描述參與診斷或治療此條件的人員。
    /// </para>
    /// </remarks>
    public class ConditionParticipant
    {
        /// <summary>
        /// 參與功能
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與者在此條件中的功能角色。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function { get; set; }

        /// <summary>
        /// 參與者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 參與者的引用，可以是醫療人員、患者或相關人員。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor { get; set; }

        public ConditionParticipant() { }

        public ConditionParticipant(DataTypeServices.DataTypes.SpecialTypes.ReferenceType actor, CodeableConcept? function = null)
        {
            Actor = actor;
            Function = function;
        }
    }

    /// <summary>
    /// 條件階段
    /// </summary>
    /// <remarks>
    /// <para>
    /// 描述條件的臨床階段或等級資訊。
    /// </para>
    /// </remarks>
    public class ConditionStage
    {
        /// <summary>
        /// 階段摘要
        /// </summary>
        /// <remarks>
        /// <para>
        /// 階段的簡要描述或分類。
        /// </para>
        /// </remarks>
        public CodeableConcept? Summary { get; set; }

        /// <summary>
        /// 評估
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於確定階段的正式記錄。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Assessment { get; set; }

        /// <summary>
        /// 階段類型
        /// </summary>
        /// <remarks>
        /// <para>
        /// 階段評估的類型，如病理、臨床等。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type { get; set; }

        public ConditionStage() { }

        public ConditionStage(CodeableConcept summary, CodeableConcept? type = null)
        {
            Summary = summary;
            Type = type;
        }
    }

    /// <summary>
    /// Condition 發病時間選擇類型
    /// </summary>
    public class ConditionOnsetChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "dateTime", "Age", "Period", "Range", "string" };

        public ConditionOnsetChoice(JsonObject value) : base("onset", value, _supportType) { }
        public ConditionOnsetChoice(IComplexType? value) : base("onset", value) { }
        public ConditionOnsetChoice(IPrimitiveType? value) : base("onset", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Onset" : "onset";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Condition 緩解時間選擇類型
    /// </summary>
    public class ConditionAbatementChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "dateTime", "Age", "Period", "Range", "string" };

        public ConditionAbatementChoice(JsonObject value) : base("abatement", value, _supportType) { }
        public ConditionAbatementChoice(IComplexType? value) : base("abatement", value) { }
        public ConditionAbatementChoice(IPrimitiveType? value) : base("abatement", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Abatement" : "abatement";

        public override List<string> SetSupportDataType() => _supportType;
    }
}