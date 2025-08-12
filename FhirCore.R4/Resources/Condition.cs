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
    /// FHIR R4 Condition 資源
    /// 
    /// <para>
    /// A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var condition = new Condition("condition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Condition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Condition : ResourceBase<R4Version>
    {
        private ReferenceType? _asserter;

        /// <summary>
        /// asserter
        /// </summary>
        /// <remarks>
        /// <para>
        /// asserter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? asserter
        {
            get => _asserter;
            set
            {
                _asserter = value;
                OnPropertyChanged(nameof(asserter));
            }
        }

        private List<CodeableConcept>? _bodysite;

        /// <summary>
        /// bodySite
        /// </summary>
        /// <remarks>
        /// <para>
        /// bodySite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? bodySite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(bodySite));
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

        private CodeableConcept? _clinicalstatus;

        /// <summary>
        /// clinicalStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// clinicalStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? clinicalStatus
        {
            get => _clinicalstatus;
            set
            {
                _clinicalstatus = value;
                OnPropertyChanged(nameof(clinicalStatus));
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

        private List<Annotation>? _note;

        /// <summary>
        /// note
        /// </summary>
        /// <remarks>
        /// <para>
        /// note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(note));
            }
        }

        private FhirDateTime? _recordeddate;

        /// <summary>
        /// recordedDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// recordedDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? recordedDate
        {
            get => _recordeddate;
            set
            {
                _recordeddate = value;
                OnPropertyChanged(nameof(recordedDate));
            }
        }

        private ReferenceType? _recorder;

        /// <summary>
        /// recorder
        /// </summary>
        /// <remarks>
        /// <para>
        /// recorder 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? recorder
        {
            get => _recorder;
            set
            {
                _recorder = value;
                OnPropertyChanged(nameof(recorder));
            }
        }

        private CodeableConcept? _severity;

        /// <summary>
        /// severity
        /// </summary>
        /// <remarks>
        /// <para>
        /// severity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(severity));
            }
        }

        private List<BackboneElement>? _stage;

        /// <summary>
        /// stage
        /// </summary>
        /// <remarks>
        /// <para>
        /// stage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? stage
        {
            get => _stage;
            set
            {
                _stage = value;
                OnPropertyChanged(nameof(stage));
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

        private CodeableConcept? _verificationstatus;

        /// <summary>
        /// verificationStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// verificationStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? verificationStatus
        {
            get => _verificationstatus;
            set
            {
                _verificationstatus = value;
                OnPropertyChanged(nameof(verificationStatus));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Condition";

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
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Condition(Id: {Id})";
        }
    }
}
