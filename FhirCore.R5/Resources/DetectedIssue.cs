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
    /// FHIR R5 DetectedIssue 資源
    /// 
    /// <para>
    /// DetectedIssue 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var detectedissue = new DetectedIssue("detectedissue-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DetectedIssue 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DetectedIssue : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private FhirCode? _severity;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private DetectedIssueIdentifiedChoice? _identified;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _implicated;
        private List<DetectedIssueEvidence>? _evidence;
        private FhirMarkdown? _detail;
        private FhirUri? _reference;
        private List<DetectedIssueMitigation>? _mitigation;
        private List<CodeableConcept>? _code;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _detail;
        private CodeableConcept? _action;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _author;
        private List<Annotation>? _note;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DetectedIssue";        /// <summary>
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
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
        /// Severity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Severity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(Severity));
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
        /// Identified
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identified 的詳細描述。
        /// </para>
        /// </remarks>
        public DetectedIssueIdentifiedChoice? Identified
        {
            get => _identified;
            set
            {
                _identified = value;
                OnPropertyChanged(nameof(Identified));
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
        /// Implicated
        /// </summary>
        /// <remarks>
        /// <para>
        /// Implicated 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Implicated
        {
            get => _implicated;
            set
            {
                _implicated = value;
                OnPropertyChanged(nameof(Implicated));
            }
        }        /// <summary>
        /// Evidence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Evidence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DetectedIssueEvidence>? Evidence
        {
            get => _evidence;
            set
            {
                _evidence = value;
                OnPropertyChanged(nameof(Evidence));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Mitigation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mitigation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DetectedIssueMitigation>? Mitigation
        {
            get => _mitigation;
            set
            {
                _mitigation = value;
                OnPropertyChanged(nameof(Mitigation));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
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
        /// 建立新的 DetectedIssue 資源實例
        /// </summary>
        public DetectedIssue()
        {
        }

        /// <summary>
        /// 建立新的 DetectedIssue 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DetectedIssue(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DetectedIssue(Id: {Id})";
        }
    }    /// <summary>
    /// DetectedIssueEvidence 背骨元素
    /// </summary>
    public class DetectedIssueEvidence
    {
        // TODO: 添加屬性實作
        
        public DetectedIssueEvidence() { }
    }    /// <summary>
    /// DetectedIssueMitigation 背骨元素
    /// </summary>
    public class DetectedIssueMitigation
    {
        // TODO: 添加屬性實作
        
        public DetectedIssueMitigation() { }
    }    /// <summary>
    /// DetectedIssueIdentifiedChoice 選擇類型
    /// </summary>
    public class DetectedIssueIdentifiedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DetectedIssueIdentifiedChoice(JsonObject value) : base("detectedissueidentified", value, _supportType) { }
        public DetectedIssueIdentifiedChoice(IComplexType? value) : base("detectedissueidentified", value) { }
        public DetectedIssueIdentifiedChoice(IPrimitiveType? value) : base("detectedissueidentified", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DetectedIssueIdentified" : "detectedissueidentified";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
