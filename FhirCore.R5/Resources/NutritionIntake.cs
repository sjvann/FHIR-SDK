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
    /// FHIR R5 NutritionIntake 資源
    /// 
    /// <para>
    /// NutritionIntake 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var nutritionintake = new NutritionIntake("nutritionintake-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 NutritionIntake 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class NutritionIntake : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private List<CodeableConcept>? _statusreason;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private NutritionIntakeOccurrenceChoice? _occurrence;
        private FhirDateTime? _recorded;
        private NutritionIntakeReportedChoice? _reported;
        private List<NutritionIntakeConsumedItem>? _consumeditem;
        private List<NutritionIntakeIngredientLabel>? _ingredientlabel;
        private List<NutritionIntakePerformer>? _performer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _derivedfrom;
        private List<CodeableReference>? _reason;
        private List<Annotation>? _note;
        private CodeableConcept? _type;
        private CodeableReference? _nutritionproduct;
        private Timing? _schedule;
        private Quantity? _amount;
        private Quantity? _rate;
        private FhirBoolean? _notconsumed;
        private CodeableConcept? _notconsumedreason;
        private CodeableReference? _nutrient;
        private Quantity? _amount;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "NutritionIntake";        /// <summary>
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
            }
        }        /// <summary>
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
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
        }        /// <summary>
        /// Statusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Statusreason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(Statusreason));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
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
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
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
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
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
        }        /// <summary>
        /// Occurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionIntakeOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Recorded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recorded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Recorded
        {
            get => _recorded;
            set
            {
                _recorded = value;
                OnPropertyChanged(nameof(Recorded));
            }
        }        /// <summary>
        /// Reported
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reported 的詳細描述。
        /// </para>
        /// </remarks>
        public NutritionIntakeReportedChoice? Reported
        {
            get => _reported;
            set
            {
                _reported = value;
                OnPropertyChanged(nameof(Reported));
            }
        }        /// <summary>
        /// Consumeditem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Consumeditem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionIntakeConsumedItem>? Consumeditem
        {
            get => _consumeditem;
            set
            {
                _consumeditem = value;
                OnPropertyChanged(nameof(Consumeditem));
            }
        }        /// <summary>
        /// Ingredientlabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ingredientlabel 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionIntakeIngredientLabel>? Ingredientlabel
        {
            get => _ingredientlabel;
            set
            {
                _ingredientlabel = value;
                OnPropertyChanged(nameof(Ingredientlabel));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<NutritionIntakePerformer>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
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
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Nutritionproduct
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nutritionproduct 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Nutritionproduct
        {
            get => _nutritionproduct;
            set
            {
                _nutritionproduct = value;
                OnPropertyChanged(nameof(Nutritionproduct));
            }
        }        /// <summary>
        /// Schedule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Schedule 的詳細描述。
        /// </para>
        /// </remarks>
        public Timing? Schedule
        {
            get => _schedule;
            set
            {
                _schedule = value;
                OnPropertyChanged(nameof(Schedule));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Rate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rate 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Rate
        {
            get => _rate;
            set
            {
                _rate = value;
                OnPropertyChanged(nameof(Rate));
            }
        }        /// <summary>
        /// Notconsumed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notconsumed 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Notconsumed
        {
            get => _notconsumed;
            set
            {
                _notconsumed = value;
                OnPropertyChanged(nameof(Notconsumed));
            }
        }        /// <summary>
        /// Notconsumedreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notconsumedreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Notconsumedreason
        {
            get => _notconsumedreason;
            set
            {
                _notconsumedreason = value;
                OnPropertyChanged(nameof(Notconsumedreason));
            }
        }        /// <summary>
        /// Nutrient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Nutrient 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Nutrient
        {
            get => _nutrient;
            set
            {
                _nutrient = value;
                OnPropertyChanged(nameof(Nutrient));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// 建立新的 NutritionIntake 資源實例
        /// </summary>
        public NutritionIntake()
        {
        }

        /// <summary>
        /// 建立新的 NutritionIntake 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public NutritionIntake(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"NutritionIntake(Id: {Id})";
        }
    }    /// <summary>
    /// NutritionIntakeConsumedItem 背骨元素
    /// </summary>
    public class NutritionIntakeConsumedItem
    {
        // TODO: 添加屬性實作
        
        public NutritionIntakeConsumedItem() { }
    }    /// <summary>
    /// NutritionIntakeIngredientLabel 背骨元素
    /// </summary>
    public class NutritionIntakeIngredientLabel
    {
        // TODO: 添加屬性實作
        
        public NutritionIntakeIngredientLabel() { }
    }    /// <summary>
    /// NutritionIntakePerformer 背骨元素
    /// </summary>
    public class NutritionIntakePerformer
    {
        // TODO: 添加屬性實作
        
        public NutritionIntakePerformer() { }
    }    /// <summary>
    /// NutritionIntakeOccurrenceChoice 選擇類型
    /// </summary>
    public class NutritionIntakeOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public NutritionIntakeOccurrenceChoice(JsonObject value) : base("nutritionintakeoccurrence", value, _supportType) { }
        public NutritionIntakeOccurrenceChoice(IComplexType? value) : base("nutritionintakeoccurrence", value) { }
        public NutritionIntakeOccurrenceChoice(IPrimitiveType? value) : base("nutritionintakeoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "NutritionIntakeOccurrence" : "nutritionintakeoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// NutritionIntakeReportedChoice 選擇類型
    /// </summary>
    public class NutritionIntakeReportedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public NutritionIntakeReportedChoice(JsonObject value) : base("nutritionintakereported", value, _supportType) { }
        public NutritionIntakeReportedChoice(IComplexType? value) : base("nutritionintakereported", value) { }
        public NutritionIntakeReportedChoice(IPrimitiveType? value) : base("nutritionintakereported", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "NutritionIntakeReported" : "nutritionintakereported";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
