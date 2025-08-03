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
    /// FHIR R5 QuestionnaireResponse 資源
    /// 
    /// <para>
    /// QuestionnaireResponse 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var questionnaireresponse = new QuestionnaireResponse("questionnaireresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 QuestionnaireResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class QuestionnaireResponse : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCanonical? _questionnaire;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private FhirDateTime? _authored;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _source;
        private List<QuestionnaireResponseItem>? _item;
        private QuestionnaireResponseItemAnswerValueChoice? _value;
        private FhirString? _linkid;
        private FhirUri? _definition;
        private List<QuestionnaireResponseItemAnswer>? _answer;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "QuestionnaireResponse";        /// <summary>
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
        /// Questionnaire
        /// </summary>
        /// <remarks>
        /// <para>
        /// Questionnaire 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Questionnaire
        {
            get => _questionnaire;
            set
            {
                _questionnaire = value;
                OnPropertyChanged(nameof(Questionnaire));
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
        /// Authored
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authored 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Authored
        {
            get => _authored;
            set
            {
                _authored = value;
                OnPropertyChanged(nameof(Authored));
            }
        }        /// <summary>
        /// Author
        /// </summary>
        /// <remarks>
        /// <para>
        /// Author 的詳細描述。
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
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<QuestionnaireResponseItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public QuestionnaireResponseItemAnswerValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Answer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Answer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<QuestionnaireResponseItemAnswer>? Answer
        {
            get => _answer;
            set
            {
                _answer = value;
                OnPropertyChanged(nameof(Answer));
            }
        }        /// <summary>
        /// 建立新的 QuestionnaireResponse 資源實例
        /// </summary>
        public QuestionnaireResponse()
        {
        }

        /// <summary>
        /// 建立新的 QuestionnaireResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public QuestionnaireResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"QuestionnaireResponse(Id: {Id})";
        }
    }    /// <summary>
    /// QuestionnaireResponseItemAnswer 背骨元素
    /// </summary>
    public class QuestionnaireResponseItemAnswer
    {
        // TODO: 添加屬性實作
        
        public QuestionnaireResponseItemAnswer() { }
    }    /// <summary>
    /// QuestionnaireResponseItem 背骨元素
    /// </summary>
    public class QuestionnaireResponseItem
    {
        // TODO: 添加屬性實作
        
        public QuestionnaireResponseItem() { }
    }    /// <summary>
    /// QuestionnaireResponseItemAnswerValueChoice 選擇類型
    /// </summary>
    public class QuestionnaireResponseItemAnswerValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public QuestionnaireResponseItemAnswerValueChoice(JsonObject value) : base("questionnaireresponseitemanswervalue", value, _supportType) { }
        public QuestionnaireResponseItemAnswerValueChoice(IComplexType? value) : base("questionnaireresponseitemanswervalue", value) { }
        public QuestionnaireResponseItemAnswerValueChoice(IPrimitiveType? value) : base("questionnaireresponseitemanswervalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "QuestionnaireResponseItemAnswerValue" : "questionnaireresponseitemanswervalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
