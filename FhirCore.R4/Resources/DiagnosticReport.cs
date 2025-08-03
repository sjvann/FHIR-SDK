using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 DiagnosticReport 資源
    /// 
    /// <para>
    /// The findings and interpretation of diagnostic  tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these. The report includes clinical context such as requesting and provider information, and some mix of atomic results, images, textual and coded interpretations, and formatted representation of diagnostic reports.
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
    /// R4 版本的 DiagnosticReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DiagnosticReport : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _basedon;

        /// <summary>
        /// basedOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// basedOn 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? basedOn
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(basedOn));
            }
        }

        private List<CodeableConcept>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
            }
        }

        private CodeableConcept? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
            }
        }

        private FhirString? _conclusion;

        /// <summary>
        /// conclusion
        /// </summary>
        /// <remarks>
        /// <para>
        /// conclusion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? conclusion
        {
            get => _conclusion;
            set
            {
                _conclusion = value;
                OnPropertyChanged(nameof(conclusion));
            }
        }

        private List<CodeableConcept>? _conclusioncode;

        /// <summary>
        /// conclusionCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// conclusionCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? conclusionCode
        {
            get => _conclusioncode;
            set
            {
                _conclusioncode = value;
                OnPropertyChanged(nameof(conclusionCode));
            }
        }

        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private ReferenceType? _encounter;

        /// <summary>
        /// encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(encounter));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
            }
        }

        private List<ReferenceType>? _imagingstudy;

        /// <summary>
        /// imagingStudy
        /// </summary>
        /// <remarks>
        /// <para>
        /// imagingStudy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? imagingStudy
        {
            get => _imagingstudy;
            set
            {
                _imagingstudy = value;
                OnPropertyChanged(nameof(imagingStudy));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private FhirInstant? _issued;

        /// <summary>
        /// issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(issued));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private List<BackboneElement>? _media;

        /// <summary>
        /// media
        /// </summary>
        /// <remarks>
        /// <para>
        /// media 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? media
        {
            get => _media;
            set
            {
                _media = value;
                OnPropertyChanged(nameof(media));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private List<ReferenceType>? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private List<Attachment>? _presentedform;

        /// <summary>
        /// presentedForm
        /// </summary>
        /// <remarks>
        /// <para>
        /// presentedForm 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? presentedForm
        {
            get => _presentedform;
            set
            {
                _presentedform = value;
                OnPropertyChanged(nameof(presentedForm));
            }
        }

        private List<ReferenceType>? _result;

        /// <summary>
        /// result
        /// </summary>
        /// <remarks>
        /// <para>
        /// result 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(result));
            }
        }

        private List<ReferenceType>? _resultsinterpreter;

        /// <summary>
        /// resultsInterpreter
        /// </summary>
        /// <remarks>
        /// <para>
        /// resultsInterpreter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? resultsInterpreter
        {
            get => _resultsinterpreter;
            set
            {
                _resultsinterpreter = value;
                OnPropertyChanged(nameof(resultsInterpreter));
            }
        }

        private List<ReferenceType>? _specimen;

        /// <summary>
        /// specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(specimen));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DiagnosticReport";

        /// <summary>
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
    }
}
