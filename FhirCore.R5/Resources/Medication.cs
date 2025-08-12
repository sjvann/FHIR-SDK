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
    /// FHIR R5 Medication 資源
    /// 
    /// <para>
    /// 用於記錄藥物的基本資訊，包括藥物代碼、劑型、成分、批次等重要資料。
    /// 主要用於處方、配藥、用藥記錄等臨床工作流程。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medication = new Medication("med-001")
    /// {
    ///     Code = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://www.nlm.nih.gov/research/umls/rxnorm"),
    ///                 Code = new FhirCode("313782"),
    ///                 Display = new FhirString("Acetaminophen 325 MG Oral Tablet")
    ///             }
    ///         }
    ///     },
    ///     Status = new FhirCode("active"),
    ///     DoseForm = new CodeableConcept
    ///     {
    ///         Text = new FhirString("Tablet")
    ///     }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Medication 資源是 FHIR 中用於描述藥物的核心資源，
    /// 可以用於處方開立、藥物配發、用藥記錄等多種臨床情境。
    /// </para>
    /// 
    /// <para>
    /// R5 版本的主要特點：
    /// - 支援更詳細的藥物成分描述
    /// - 增強的批次管理功能
    /// - 改進的藥物狀態追蹤
    /// - 支援複雜的劑型描述
    /// </para>
    /// </remarks>
    public class Medication : ResourceBase<R5Version>
    {
        private List<Identifier>? _identifier;
        private CodeableConcept? _code;
        private FhirCode? _status;
        private ReferenceType? _marketingAuthorizationHolder;
        private CodeableConcept? _doseForm;
        private Quantity? _totalVolume;
        private List<MedicationIngredient>? _ingredient;
        private MedicationBatch? _batch;
        private ReferenceType? _definition;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Medication";

        /// <summary>
        /// 識別碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 藥物的各種識別碼，如藥品許可證號碼、院內藥碼等。
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
        /// 藥物代碼
        /// </summary>
        /// <remarks>
        /// <para>
        /// 使用標準藥物代碼系統（如 RxNorm、ATC 等）來描述藥物。
        /// 這是藥物識別的主要依據。
        /// </para>
        /// </remarks>
        [Required(ErrorMessage = "藥物必須包含代碼")]
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
        /// 藥物狀態
        /// </summary>
        /// <remarks>
        /// <para>
        /// 描述藥物的當前狀態，如 active（活躍）、inactive（非活躍）、
        /// entered-in-error（錯誤輸入）等。
        /// </para>
        /// </remarks>
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
        /// 藥品許可證持有者
        /// </summary>
        /// <remarks>
        /// <para>
        /// 引用負責藥物上市許可的組織，通常是製藥公司。
        /// </para>
        /// </remarks>
        public ReferenceType? MarketingAuthorizationHolder
        {
            get => _marketingAuthorizationHolder;
            set
            {
                _marketingAuthorizationHolder = value;
                OnPropertyChanged(nameof(MarketingAuthorizationHolder));
            }
        }

        /// <summary>
        /// 劑型
        /// </summary>
        /// <remarks>
        /// <para>
        /// 藥物的劑型，如片劑、膠囊、注射劑等。
        /// </para>
        /// </remarks>
        public CodeableConcept? DoseForm
        {
            get => _doseForm;
            set
            {
                _doseForm = value;
                OnPropertyChanged(nameof(DoseForm));
            }
        }

        /// <summary>
        /// 總體積
        /// </summary>
        /// <remarks>
        /// <para>
        /// 當藥物為液體時，描述其總體積。
        /// </para>
        /// </remarks>
        public Quantity? TotalVolume
        {
            get => _totalVolume;
            set
            {
                _totalVolume = value;
                OnPropertyChanged(nameof(TotalVolume));
            }
        }

        /// <summary>
        /// 成分
        /// </summary>
        /// <remarks>
        /// <para>
        /// 藥物的活性成分和非活性成分列表。
        /// </para>
        /// </remarks>
        public List<MedicationIngredient>? Ingredient
        {
            get => _ingredient;
            set
            {
                _ingredient = value;
                OnPropertyChanged(nameof(Ingredient));
            }
        }

        /// <summary>
        /// 批次資訊
        /// </summary>
        /// <remarks>
        /// <para>
        /// 特定批次的藥物資訊，如批號、有效期限等。
        /// </para>
        /// </remarks>
        public MedicationBatch? Batch
        {
            get => _batch;
            set
            {
                _batch = value;
                OnPropertyChanged(nameof(Batch));
            }
        }

        /// <summary>
        /// 藥物定義引用
        /// </summary>
        /// <remarks>
        /// <para>
        /// 引用更詳細的藥物定義資源（MedicationKnowledge）。
        /// </para>
        /// </remarks>
        public ReferenceType? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }

        /// <summary>
        /// 建立新的 Medication 資源實例
        /// </summary>
        public Medication()
        {
        }

        /// <summary>
        /// 建立新的 Medication 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Medication(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 建立新的 Medication 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        /// <param name="code">藥物代碼</param>
        public Medication(string id, CodeableConcept code)
        {
            Id = id;
            Code = code;
            Status = new FhirCode("active");
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            var displayName = Code?.Text?.Value ?? 
                              Code?.Coding?.FirstOrDefault()?.Display?.Value ?? 
                              "未命名藥物";

            var status = Status?.Value ?? "狀態未知";
            return $"Medication(Id: {Id}, Name: {displayName}, Status: {status})";
        }
    }

    /// <summary>
    /// 藥物成分
    /// </summary>
    /// <remarks>
    /// <para>
    /// 描述藥物中的各種成分，包括活性成分和非活性成分。
    /// </para>
    /// </remarks>
    public class MedicationIngredient
    {
        /// <summary>
        /// 成分項目
        /// </summary>
        /// <remarks>
        /// <para>
        /// 可以是代碼或對其他資源的引用。
        /// </para>
        /// </remarks>
        public CodeableReference? Item { get; set; }

        /// <summary>
        /// 是否為活性成分
        /// </summary>
        /// <remarks>
        /// <para>
        /// true 表示活性成分，false 表示非活性成分（如賦形劑）。
        /// </para>
        /// </remarks>
        public FhirBoolean? IsActive { get; set; }

        /// <summary>
        /// 成分強度
        /// </summary>
        /// <remarks>
        /// <para>
        /// 可以用比例、代碼概念或數量來表示成分的強度。
        /// </para>
        /// </remarks>
        public MedicationIngredientStrengthChoice? Strength { get; set; }

        public MedicationIngredient() { }

        public MedicationIngredient(CodeableReference item, bool isActive = true)
        {
            Item = item;
            IsActive = new FhirBoolean(isActive);
        }
    }

    /// <summary>
    /// 藥物批次資訊
    /// </summary>
    /// <remarks>
    /// <para>
    /// 記錄特定批次藥物的批號和有效期限等資訊。
    /// </para>
    /// </remarks>
    public class MedicationBatch
    {
        /// <summary>
        /// 批號
        /// </summary>
        public FhirString? LotNumber { get; set; }

        /// <summary>
        /// 有效期限
        /// </summary>
        public FhirDateTime? ExpirationDate { get; set; }

        public MedicationBatch() { }

        public MedicationBatch(string lotNumber, DateTime? expirationDate = null)
        {
            LotNumber = new FhirString(lotNumber);
            if (expirationDate.HasValue)
            {
                ExpirationDate = new FhirDateTime(expirationDate.Value);
            }
        }
    }

    /// <summary>
    /// 藥物成分強度選擇類型
    /// </summary>
    /// <remarks>
    /// <para>
    /// 可以使用比例、代碼概念或數量來表示成分強度。
    /// </para>
    /// </remarks>
    public class MedicationIngredientStrengthChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "Ratio", "CodeableConcept", "Quantity" };

        public MedicationIngredientStrengthChoice(JsonObject value) : base("strength", value, _supportType) { }
        public MedicationIngredientStrengthChoice(IComplexType? value) : base("strength", value) { }
        public MedicationIngredientStrengthChoice(IPrimitiveType? value) : base("strength", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "Strength" : "strength";

        public override List<string> SetSupportDataType() => _supportType;
    }
}