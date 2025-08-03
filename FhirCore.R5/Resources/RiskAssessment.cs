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
    /// FHIR R5 RiskAssessment 資源
    /// 
    /// <para>
    /// RiskAssessment 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var riskassessment = new RiskAssessment("riskassessment-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 RiskAssessment 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class RiskAssessment : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _basedon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _parent;
        private FhirCode? _status;
        private CodeableConcept? _method;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private RiskAssessmentOccurrenceChoice? _occurrence;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _condition;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _performer;
        private List<CodeableReference>? _reason;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basis;
        private List<RiskAssessmentPrediction>? _prediction;
        private FhirString? _mitigation;
        private List<Annotation>? _note;
        private CodeableConcept? _outcome;
        private RiskAssessmentPredictionProbabilityChoice? _probability;
        private CodeableConcept? _qualitativerisk;
        private FhirDecimal? _relativerisk;
        private RiskAssessmentPredictionWhenChoice? _when;
        private FhirString? _rationale;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "RiskAssessment";        /// <summary>
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
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parent 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(Parent));
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
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
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
        public RiskAssessmentOccurrenceChoice? Occurrence
        {
            get => _occurrence;
            set
            {
                _occurrence = value;
                OnPropertyChanged(nameof(Occurrence));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
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
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }        /// <summary>
        /// Prediction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prediction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<RiskAssessmentPrediction>? Prediction
        {
            get => _prediction;
            set
            {
                _prediction = value;
                OnPropertyChanged(nameof(Prediction));
            }
        }        /// <summary>
        /// Mitigation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mitigation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Mitigation
        {
            get => _mitigation;
            set
            {
                _mitigation = value;
                OnPropertyChanged(nameof(Mitigation));
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
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Probability
        /// </summary>
        /// <remarks>
        /// <para>
        /// Probability 的詳細描述。
        /// </para>
        /// </remarks>
        public RiskAssessmentPredictionProbabilityChoice? Probability
        {
            get => _probability;
            set
            {
                _probability = value;
                OnPropertyChanged(nameof(Probability));
            }
        }        /// <summary>
        /// Qualitativerisk
        /// </summary>
        /// <remarks>
        /// <para>
        /// Qualitativerisk 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Qualitativerisk
        {
            get => _qualitativerisk;
            set
            {
                _qualitativerisk = value;
                OnPropertyChanged(nameof(Qualitativerisk));
            }
        }        /// <summary>
        /// Relativerisk
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relativerisk 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Relativerisk
        {
            get => _relativerisk;
            set
            {
                _relativerisk = value;
                OnPropertyChanged(nameof(Relativerisk));
            }
        }        /// <summary>
        /// When
        /// </summary>
        /// <remarks>
        /// <para>
        /// When 的詳細描述。
        /// </para>
        /// </remarks>
        public RiskAssessmentPredictionWhenChoice? When
        {
            get => _when;
            set
            {
                _when = value;
                OnPropertyChanged(nameof(When));
            }
        }        /// <summary>
        /// Rationale
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rationale 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Rationale
        {
            get => _rationale;
            set
            {
                _rationale = value;
                OnPropertyChanged(nameof(Rationale));
            }
        }        /// <summary>
        /// 建立新的 RiskAssessment 資源實例
        /// </summary>
        public RiskAssessment()
        {
        }

        /// <summary>
        /// 建立新的 RiskAssessment 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public RiskAssessment(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"RiskAssessment(Id: {Id})";
        }
    }    /// <summary>
    /// RiskAssessmentPrediction 背骨元素
    /// </summary>
    public class RiskAssessmentPrediction
    {
        // TODO: 添加屬性實作
        
        public RiskAssessmentPrediction() { }
    }    /// <summary>
    /// RiskAssessmentOccurrenceChoice 選擇類型
    /// </summary>
    public class RiskAssessmentOccurrenceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RiskAssessmentOccurrenceChoice(JsonObject value) : base("riskassessmentoccurrence", value, _supportType) { }
        public RiskAssessmentOccurrenceChoice(IComplexType? value) : base("riskassessmentoccurrence", value) { }
        public RiskAssessmentOccurrenceChoice(IPrimitiveType? value) : base("riskassessmentoccurrence", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RiskAssessmentOccurrence" : "riskassessmentoccurrence";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// RiskAssessmentPredictionProbabilityChoice 選擇類型
    /// </summary>
    public class RiskAssessmentPredictionProbabilityChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RiskAssessmentPredictionProbabilityChoice(JsonObject value) : base("riskassessmentpredictionprobability", value, _supportType) { }
        public RiskAssessmentPredictionProbabilityChoice(IComplexType? value) : base("riskassessmentpredictionprobability", value) { }
        public RiskAssessmentPredictionProbabilityChoice(IPrimitiveType? value) : base("riskassessmentpredictionprobability", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RiskAssessmentPredictionProbability" : "riskassessmentpredictionprobability";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// RiskAssessmentPredictionWhenChoice 選擇類型
    /// </summary>
    public class RiskAssessmentPredictionWhenChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public RiskAssessmentPredictionWhenChoice(JsonObject value) : base("riskassessmentpredictionwhen", value, _supportType) { }
        public RiskAssessmentPredictionWhenChoice(IComplexType? value) : base("riskassessmentpredictionwhen", value) { }
        public RiskAssessmentPredictionWhenChoice(IPrimitiveType? value) : base("riskassessmentpredictionwhen", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "RiskAssessmentPredictionWhen" : "riskassessmentpredictionwhen";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
