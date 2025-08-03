using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 Observation 資源
    /// 
    /// <para>
    /// 用於記錄患者的觀察值、測量結果、檢驗報告等臨床數據。
    /// 是 FHIR 中最重要的臨床資源之一，支援各種類型的測量和觀察。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var observation = new Observation("obs-001")
    /// {
    ///     Status = new FhirCode("final"),
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://loinc.org"),
    ///                 Code = new FhirCode("8302-2"),
    ///                 Display = new FhirString("Body height")
    ///             }
    ///         }
    ///     },
    ///     Subject = new ReferenceType
    ///     {
    ///         Reference = new FhirString("Patient/patient-001")
    ///     },
    ///     Value = new ObservationValueChoice(new Quantity
    ///     {
    ///         Value = new FhirDecimal(175),
    ///         Unit = new FhirString("cm"),
    ///         System = new FhirUri("http://unitsofmeasure.org"),
    ///         Code = new FhirCode("cm")
    ///     })
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Observation 資源可以記錄各種類型的臨床數據：
    /// - 生命體徵（血壓、心率、體溫等）
    /// - 實驗室檢驗結果（血糖、血紅蛋白等）
    /// - 影像檢查結果
    /// - 問診資料
    /// - 評估量表分數
    /// </para>
    /// 
    /// <para>
    /// R5 版本的主要特點：
    /// - 增強的觸發機制支援
    /// - 改進的組合觀察值處理
    /// - 更靈活的有效時間設定
    /// - 支援更多的數值類型
    /// </para>
    /// </remarks>
    public class Observation : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private ObservationInstantiatesChoice? _instantiates;
        private List<ReferenceType>? _basedOn;
        private List<ObservationTriggeredBy>? _triggeredBy;
        private List<ReferenceType>? _partOf;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private ReferenceType? _subject;
        private List<ReferenceType>? _focus;
        private ReferenceType? _encounter;
        private ObservationEffectiveChoice? _effective;
        private FhirInstant? _issued;
        private List<ReferenceType>? _performer;
        private ObservationValueChoice? _value;
        private CodeableConcept? _dataAbsentReason;
        private List<CodeableConcept>? _interpretation;
        private List<Annotation>? _note;
        private CodeableConcept? _bodySite;
        private ReferenceType? _bodyStructure;
        private CodeableConcept? _method;
        private ReferenceType? _specimen;
        private ReferenceType? _device;
        private List<ObservationReferenceRange>? _referenceRange;
        private List<ReferenceType>? _hasMember;
        private List<ReferenceType>? _derivedFrom;
        private List<ObservationComponent>? _component;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Observation";

        /// <summary>
        /// 識別碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的唯一識別碼，如檢驗報告編號、觀察記錄號等。
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
        /// 實例化定義
        /// </summary>
        /// <remarks>
        /// <para>
        /// 指向定義此觀察值的 ObservationDefinition。
        /// </para>
        /// </remarks>
        public ObservationInstantiatesChoice? Instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(Instantiates));
            }
        }

        /// <summary>
        /// 基於的請求
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此觀察值基於的醫療請求，如檢驗申請單。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? BasedOn
        {
            get => _basedOn;
            set
            {
                _basedOn = value;
                OnPropertyChanged(nameof(BasedOn));
            }
        }

        /// <summary>
        /// 觸發來源
        /// </summary>
        /// <remarks>
        /// <para>
        /// 描述什麼觸發了此觀察值的產生。
        /// </para>
        /// </remarks>
        public List<ObservationTriggeredBy>? TriggeredBy
        {
            get => _triggeredBy;
            set
            {
                _triggeredBy = value;
                OnPropertyChanged(nameof(TriggeredBy));
            }
        }

        /// <summary>
        /// 所屬的組合
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此觀察值是較大組合的一部分。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? PartOf
        {
            get => _partOf;
            set
            {
                _partOf = value;
                OnPropertyChanged(nameof(PartOf));
            }
        }

        /// <summary>
        /// 觀察值狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的狀態，如 registered、preliminary、final、amended 等。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "觀察值必須有狀態")]
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        /// <summary>
        /// 觀察值分類
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的分類，如 vital-signs、laboratory、imaging 等。
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
        /// 觀察值代碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 描述觀察值類型的代碼，通常使用 LOINC 代碼。
        /// 這是必填欄位。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "觀察值必須有代碼")]
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
        /// 觀察主體
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的主體，通常是患者，也可以是設備、位置等。
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
        /// 關注焦點
        /// </summary>
        /// <remarks>
        /// <para>
        /// 當觀察值主體不是患者時，真正關注的對象。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? Focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(Focus));
            }
        }

        /// <summary>
        /// 相關就診
        /// </summary>
        /// <remarks>
        /// <para>
        /// 產生此觀察值的就診記錄。
        /// </para>
        /// </remarks>
        public ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }

        /// <summary>
        /// 有效時間
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的有效時間，可以是時間點、時間段或定時安排。
        /// </para>
        /// </remarks>
        public ObservationEffectiveChoice? Effective
        {
            get => _effective;
            set
            {
                _effective = value;
                OnPropertyChanged(nameof(Effective));
            }
        }

        /// <summary>
        /// 發布時間
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值發布的時間。
        /// </para>
        /// </remarks>
        public FhirInstant? Issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(Issued));
            }
        }

        /// <summary>
        /// 執行者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 負責執行觀察的人員或組織。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }

        /// <summary>
        /// 觀察值
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察的結果值，可以是數量、代碼、字串等多種類型。
        /// </para>
        /// </remarks>
        public ObservationValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        /// <summary>
        /// 數據缺失原因
        /// </summary>
        /// <remarks>
        /// <para>
        /// 當觀察值缺失時，說明缺失的原因。
        /// </para>
        /// </remarks>
        public CodeableConcept? DataAbsentReason
        {
            get => _dataAbsentReason;
            set
            {
                _dataAbsentReason = value;
                OnPropertyChanged(nameof(DataAbsentReason));
            }
        }

        /// <summary>
        /// 結果解釋
        /// </summary>
        /// <remarks>
        /// <para>
        /// 對觀察值的臨床解釋，如正常、異常、偏高、偏低等。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Interpretation
        {
            get => _interpretation;
            set
            {
                _interpretation = value;
                OnPropertyChanged(nameof(Interpretation));
            }
        }

        /// <summary>
        /// 註解
        /// </summary>
        /// <remarks>
        /// <para>
        /// 對觀察值的額外註解或說明。
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
        /// 身體部位
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察的身體部位。
        /// </para>
        /// </remarks>
        public CodeableConcept? BodySite
        {
            get => _bodySite;
            set
            {
                _bodySite = value;
                OnPropertyChanged(nameof(BodySite));
            }
        }

        /// <summary>
        /// 身體結構
        /// </summary>
        /// <remarks>
        /// <para>
        /// 相關的身體結構資源引用。
        /// </para>
        /// </remarks>
        public ReferenceType? BodyStructure
        {
            get => _bodyStructure;
            set
            {
                _bodyStructure = value;
                OnPropertyChanged(nameof(BodyStructure));
            }
        }

        /// <summary>
        /// 觀察方法
        /// </summary>
        /// <remarks>
        /// <para>
        /// 執行觀察使用的方法或技術。
        /// </para>
        /// </remarks>
        public CodeableConcept? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }

        /// <summary>
        /// 檢體
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於觀察的檢體。
        /// </para>
        /// </remarks>
        public ReferenceType? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }

        /// <summary>
        /// 使用設備
        /// </summary>
        /// <remarks>
        /// <para>
        /// 用於觀察的設備。
        /// </para>
        /// </remarks>
        public ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }

        /// <summary>
        /// 參考範圍
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的正常參考範圍。
        /// </para>
        /// </remarks>
        public List<ObservationReferenceRange>? ReferenceRange
        {
            get => _referenceRange;
            set
            {
                _referenceRange = value;
                OnPropertyChanged(nameof(ReferenceRange));
            }
        }

        /// <summary>
        /// 包含成員
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此觀察值包含的子觀察值，用於組合觀察值。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? HasMember
        {
            get => _hasMember;
            set
            {
                _hasMember = value;
                OnPropertyChanged(nameof(HasMember));
            }
        }

        /// <summary>
        /// 衍生來源
        /// </summary>
        /// <remarks>
        /// <para>
        /// 此觀察值衍生自的其他觀察值或媒體。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? DerivedFrom
        {
            get => _derivedFrom;
            set
            {
                _derivedFrom = value;
                OnPropertyChanged(nameof(DerivedFrom));
            }
        }

        /// <summary>
        /// 組件
        /// </summary>
        /// <remarks>
        /// <para>
        /// 觀察值的組件，用於多組件觀察值。
        /// </para>
        /// </remarks>
        public List<ObservationComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }

        /// <summary>
        /// 建立新的 Observation 資源實例
        /// </summary>
        public Observation()
        {
        }

        /// <summary>
        /// 建立新的 Observation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Observation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Observation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="status">觀察值狀態</param>
        /// <param name="code">觀察值代碼</param>
        /// <param name="subject">觀察主體</param>
        public Observation(string id, string status, CodeableConcept code, ReferenceType subject)
        {
            Id = id;
            Status = new FhirCode(status);
            Code = code;
            Subject = subject;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            var displayName = Code?.Text?.Value ?? 
                              Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                              "未命名觀察值";

            var status = Status?.Value ?? "狀態未知";
            var subjectRef = Subject?.Reference?.Value ?? "主體未知";
            
            return $"Observation(Id: {Id}, Code: {displayName}, Status: {status}, Subject: {subjectRef})";
        }
    }

    /// <summary>
    /// 觀察值觸發來源
    /// </summary>
    /// <remarks>
    /// <para>
    /// 描述觸發此觀察值產生的來源和原因。
    /// </para>
    /// </remarks>
    public class ObservationTriggeredBy
    {
        /// <summary>
        /// 觸發觀察值
        /// </summary>
        public ReferenceType? Observation { get; set; }

        /// <summary>
        /// 觸發類型
        /// </summary>
        public FhirCode? Type { get; set; }

        /// <summary>
        /// 觸發原因
        /// </summary>
        public FhirString? Reason { get; set; }

        public ObservationTriggeredBy() { }

        public ObservationTriggeredBy(ReferenceType observation, string type)
        {
            Observation = observation;
            Type = new FhirCode(type);
        }
    }

    /// <summary>
    /// 觀察值參考範圍
    /// </summary>
    /// <remarks>
    /// <para>
    /// 定義觀察值的正常參考範圍和適用條件。
    /// </para>
    /// </remarks>
    public class ObservationReferenceRange
    {
        /// <summary>
        /// 下限值
        /// </summary>
        public Quantity? Low { get; set; }

        /// <summary>
        /// 上限值
        /// </summary>
        public Quantity? High { get; set; }

        /// <summary>
        /// 正常值
        /// </summary>
        public CodeableConcept? NormalValue { get; set; }

        /// <summary>
        /// 範圍類型
        /// </summary>
        public CodeableConcept? Type { get; set; }

        /// <summary>
        /// 適用對象
        /// </summary>
        public List<CodeableConcept>? AppliesTo { get; set; }

        /// <summary>
        /// 適用年齡
        /// </summary>
        public Range? Age { get; set; }

        public ObservationReferenceRange() { }

        public ObservationReferenceRange(Quantity? low, Quantity? high)
        {
            Low = low;
            High = high;
        }
    }

    /// <summary>
    /// 觀察值組件
    /// </summary>
    /// <remarks>
    /// <para>
    /// 用於多組件觀察值，如血壓包含收縮壓和舒張壓兩個組件。
    /// </para>
    /// </remarks>
    public class ObservationComponent
    {
        /// <summary>
        /// 組件代碼
        /// </summary>
        [Required(ErrorMessage = "觀察值組件必須有代碼")]
        public CodeableConcept? Code { get; set; }

        /// <summary>
        /// 組件值
        /// </summary>
        public ObservationComponentValueChoice? Value { get; set; }

        /// <summary>
        /// 數據缺失原因
        /// </summary>
        public CodeableConcept? DataAbsentReason { get; set; }

        /// <summary>
        /// 結果解釋
        /// </summary>
        public List<CodeableConcept>? Interpretation { get; set; }

        public ObservationComponent() { }

        public ObservationComponent(CodeableConcept code)
        {
            Code = code;
        }
    }

    /// <summary>
    /// Observation 實例化選擇類型
    /// </summary>
    public class ObservationInstantiatesChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "canonical", "Reference" };

        public ObservationInstantiatesChoice(JsonObject value) : base("instantiates", value, _supportType) { }
        public ObservationInstantiatesChoice(IComplexType? value) : base("instantiates", value) { }
        public ObservationInstantiatesChoice(IPrimitiveType? value) : base("instantiates", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Instantiates" : "instantiates";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Observation 有效時間選擇類型
    /// </summary>
    public class ObservationEffectiveChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "dateTime", "Period", "Timing", "instant" };

        public ObservationEffectiveChoice(JsonObject value) : base("effective", value, _supportType) { }
        public ObservationEffectiveChoice(IComplexType? value) : base("effective", value) { }
        public ObservationEffectiveChoice(IPrimitiveType? value) : base("effective", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Effective" : "effective";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Observation 值選擇類型
    /// </summary>
    public class ObservationValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() 
        { 
            "Quantity", "CodeableConcept", "string", "boolean", "integer", 
            "Range", "Ratio", "SampledData", "time", "dateTime", "Period", 
            "Attachment", "Reference" 
        };

        public ObservationValueChoice(JsonObject value) : base("value", value, _supportType) { }
        public ObservationValueChoice(IComplexType? value) : base("value", value) { }
        public ObservationValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Value" : "value";

        public override List<string> SetSupportDataType() => _supportType;
    }

    /// <summary>
    /// Observation 組件值選擇類型
    /// </summary>
    public class ObservationComponentValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() 
        { 
            "Quantity", "CodeableConcept", "string", "boolean", "integer", 
            "Range", "Ratio", "SampledData", "time", "dateTime", "Period", 
            "Attachment", "Reference" 
        };

        public ObservationComponentValueChoice(JsonObject value) : base("value", value, _supportType) { }
        public ObservationComponentValueChoice(IComplexType? value) : base("value", value) { }
        public ObservationComponentValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Value" : "value";

        public override List<string> SetSupportDataType() => _supportType;
    }
}