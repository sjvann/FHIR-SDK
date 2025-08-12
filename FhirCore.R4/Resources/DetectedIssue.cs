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
    /// FHIR R4 DetectedIssue 資源
    /// 
    /// <para>
    /// Indicates an actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient; e.g. Drug-drug interaction, Ineffective treatment frequency, Procedure-condition conflict, etc.
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
    /// R4 版本的 DetectedIssue 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DetectedIssue : ResourceBase<R4Version>
    {
        private ReferenceType? _author;

        /// <summary>
        /// author
        /// </summary>
        /// <remarks>
        /// <para>
        /// author 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(author));
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

        private FhirString? _detail;

        /// <summary>
        /// detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// detail 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(detail));
            }
        }

        private List<BackboneElement>? _evidence;

        /// <summary>
        /// evidence
        /// </summary>
        /// <remarks>
        /// <para>
        /// evidence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? evidence
        {
            get => _evidence;
            set
            {
                _evidence = value;
                OnPropertyChanged(nameof(evidence));
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

        private List<ReferenceType>? _implicated;

        /// <summary>
        /// implicated
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicated 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? implicated
        {
            get => _implicated;
            set
            {
                _implicated = value;
                OnPropertyChanged(nameof(implicated));
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

        private List<BackboneElement>? _mitigation;

        /// <summary>
        /// mitigation
        /// </summary>
        /// <remarks>
        /// <para>
        /// mitigation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? mitigation
        {
            get => _mitigation;
            set
            {
                _mitigation = value;
                OnPropertyChanged(nameof(mitigation));
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

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private FhirUri? _reference;

        /// <summary>
        /// reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reference 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(reference));
            }
        }

        private FhirCode? _severity;

        /// <summary>
        /// severity
        /// </summary>
        /// <remarks>
        /// <para>
        /// severity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(severity));
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
        public override string ResourceType => "DetectedIssue";

        /// <summary>
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
    }
}
