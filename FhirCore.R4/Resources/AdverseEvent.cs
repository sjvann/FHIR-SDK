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
    /// FHIR R4 AdverseEvent 資源
    /// 
    /// <para>
    /// Actual or  potential/avoided event causing unintended physical injury resulting from or contributed to by medical care, a research study or other healthcare setting factors that requires additional monitoring, treatment, or hospitalization, or that results in death.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var adverseevent = new AdverseEvent("adverseevent-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 AdverseEvent 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AdverseEvent : ResourceBase<R4Version>
    {
        private FhirCode? _actuality;

        /// <summary>
        /// actuality
        /// </summary>
        /// <remarks>
        /// <para>
        /// actuality 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? actuality
        {
            get => _actuality;
            set
            {
                _actuality = value;
                OnPropertyChanged(nameof(actuality));
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

        private List<ReferenceType>? _contributor;

        /// <summary>
        /// contributor
        /// </summary>
        /// <remarks>
        /// <para>
        /// contributor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? contributor
        {
            get => _contributor;
            set
            {
                _contributor = value;
                OnPropertyChanged(nameof(contributor));
            }
        }

        private FhirDateTime? _date;

        /// <summary>
        /// date
        /// </summary>
        /// <remarks>
        /// <para>
        /// date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(date));
            }
        }

        private FhirDateTime? _detected;

        /// <summary>
        /// detected
        /// </summary>
        /// <remarks>
        /// <para>
        /// detected 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? detected
        {
            get => _detected;
            set
            {
                _detected = value;
                OnPropertyChanged(nameof(detected));
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

        private CodeableConcept? _event;

        /// <summary>
        /// event
        /// </summary>
        /// <remarks>
        /// <para>
        /// event 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(event));
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

        private Identifier? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? identifier
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

        private ReferenceType? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(location));
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

        private CodeableConcept? _outcome;

        /// <summary>
        /// outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(outcome));
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

        private List<ReferenceType>? _referencedocument;

        /// <summary>
        /// referenceDocument
        /// </summary>
        /// <remarks>
        /// <para>
        /// referenceDocument 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? referenceDocument
        {
            get => _referencedocument;
            set
            {
                _referencedocument = value;
                OnPropertyChanged(nameof(referenceDocument));
            }
        }

        private List<ReferenceType>? _resultingcondition;

        /// <summary>
        /// resultingCondition
        /// </summary>
        /// <remarks>
        /// <para>
        /// resultingCondition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? resultingCondition
        {
            get => _resultingcondition;
            set
            {
                _resultingcondition = value;
                OnPropertyChanged(nameof(resultingCondition));
            }
        }

        private CodeableConcept? _seriousness;

        /// <summary>
        /// seriousness
        /// </summary>
        /// <remarks>
        /// <para>
        /// seriousness 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? seriousness
        {
            get => _seriousness;
            set
            {
                _seriousness = value;
                OnPropertyChanged(nameof(seriousness));
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

        private List<ReferenceType>? _study;

        /// <summary>
        /// study
        /// </summary>
        /// <remarks>
        /// <para>
        /// study 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? study
        {
            get => _study;
            set
            {
                _study = value;
                OnPropertyChanged(nameof(study));
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

        private List<ReferenceType>? _subjectmedicalhistory;

        /// <summary>
        /// subjectMedicalHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// subjectMedicalHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? subjectMedicalHistory
        {
            get => _subjectmedicalhistory;
            set
            {
                _subjectmedicalhistory = value;
                OnPropertyChanged(nameof(subjectMedicalHistory));
            }
        }

        private List<BackboneElement>? _suspectentity;

        /// <summary>
        /// suspectEntity
        /// </summary>
        /// <remarks>
        /// <para>
        /// suspectEntity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? suspectEntity
        {
            get => _suspectentity;
            set
            {
                _suspectentity = value;
                OnPropertyChanged(nameof(suspectEntity));
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
        public override string ResourceType => "AdverseEvent";

        /// <summary>
        /// 建立新的 AdverseEvent 資源實例
        /// </summary>
        public AdverseEvent()
        {
        }

        /// <summary>
        /// 建立新的 AdverseEvent 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AdverseEvent(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AdverseEvent(Id: {Id})";
        }
    }
}
