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
    /// FHIR R5 DiagnosticReport 資源
    /// 
    /// <para>
    /// DiagnosticReport 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var diagnosticreport = new DiagnosticReport("diagnosticreport-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DiagnosticReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DiagnosticReport : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private DiagnosticReportEffectiveChoice? _effective;
        private FhirInstant? _issued;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _performer;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _resultsinterpreter;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _specimen;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _result;
        private List<Annotation>? _note;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _study;
        private List<DiagnosticReportSupportingInfo>? _supportinginfo;
        private List<DiagnosticReportMedia>? _media;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _composition;
        private FhirMarkdown? _conclusion;
        private List<CodeableConcept>? _conclusioncode;
        private List<Attachment>? _presentedform;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private FhirString? _comment;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _link;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DiagnosticReport";        /// <summary>
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
        /// Effective
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effective 的詳細描述。
        /// </para>
        /// </remarks>
        public DiagnosticReportEffectiveChoice? Effective
        {
            get => _effective;
            set
            {
                _effective = value;
                OnPropertyChanged(nameof(Effective));
            }
        }        /// <summary>
        /// Issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issued 的詳細描述。
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
        }        /// <summary>
        /// Performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(Performer));
            }
        }        /// <summary>
        /// Resultsinterpreter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resultsinterpreter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Resultsinterpreter
        {
            get => _resultsinterpreter;
            set
            {
                _resultsinterpreter = value;
                OnPropertyChanged(nameof(Resultsinterpreter));
            }
        }        /// <summary>
        /// Specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(Specimen));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
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
        /// Study
        /// </summary>
        /// <remarks>
        /// <para>
        /// Study 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Study
        {
            get => _study;
            set
            {
                _study = value;
                OnPropertyChanged(nameof(Study));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DiagnosticReportSupportingInfo>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Media
        /// </summary>
        /// <remarks>
        /// <para>
        /// Media 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DiagnosticReportMedia>? Media
        {
            get => _media;
            set
            {
                _media = value;
                OnPropertyChanged(nameof(Media));
            }
        }        /// <summary>
        /// Composition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Composition 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Composition
        {
            get => _composition;
            set
            {
                _composition = value;
                OnPropertyChanged(nameof(Composition));
            }
        }        /// <summary>
        /// Conclusion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conclusion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Conclusion
        {
            get => _conclusion;
            set
            {
                _conclusion = value;
                OnPropertyChanged(nameof(Conclusion));
            }
        }        /// <summary>
        /// Conclusioncode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conclusioncode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Conclusioncode
        {
            get => _conclusioncode;
            set
            {
                _conclusioncode = value;
                OnPropertyChanged(nameof(Conclusioncode));
            }
        }        /// <summary>
        /// Presentedform
        /// </summary>
        /// <remarks>
        /// <para>
        /// Presentedform 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? Presentedform
        {
            get => _presentedform;
            set
            {
                _presentedform = value;
                OnPropertyChanged(nameof(Presentedform));
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
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// 建立新的 DiagnosticReport 資源實例
        /// </summary>
        public DiagnosticReport()
        {
        }

        /// <summary>
        /// 建立新的 DiagnosticReport 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DiagnosticReport(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DiagnosticReport(Id: {Id})";
        }
    }    /// <summary>
    /// DiagnosticReportSupportingInfo 背骨元素
    /// </summary>
    public class DiagnosticReportSupportingInfo
    {
        // TODO: 添加屬性實作
        
        public DiagnosticReportSupportingInfo() { }
    }    /// <summary>
    /// DiagnosticReportMedia 背骨元素
    /// </summary>
    public class DiagnosticReportMedia
    {
        // TODO: 添加屬性實作
        
        public DiagnosticReportMedia() { }
    }    /// <summary>
    /// DiagnosticReportEffectiveChoice 選擇類型
    /// </summary>
    public class DiagnosticReportEffectiveChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DiagnosticReportEffectiveChoice(JsonObject value) : base("diagnosticreporteffective", value, _supportType) { }
        public DiagnosticReportEffectiveChoice(IComplexType? value) : base("diagnosticreporteffective", value) { }
        public DiagnosticReportEffectiveChoice(IPrimitiveType? value) : base("diagnosticreporteffective", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DiagnosticReportEffective" : "diagnosticreporteffective";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
