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
    /// FHIR R4 Goal 資源
    /// 
    /// <para>
    /// Describes the intended objective(s) for a patient, group or organization care, for example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var goal = new Goal("goal-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Goal 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Goal : ResourceBase<R4Version>
    {
        private CodeableConcept? _achievementstatus;

        /// <summary>
        /// achievementStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// achievementStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? achievementStatus
        {
            get => _achievementstatus;
            set
            {
                _achievementstatus = value;
                OnPropertyChanged(nameof(achievementStatus));
            }
        }

        private List<ReferenceType>? _addresses;

        /// <summary>
        /// addresses
        /// </summary>
        /// <remarks>
        /// <para>
        /// addresses 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? addresses
        {
            get => _addresses;
            set
            {
                _addresses = value;
                OnPropertyChanged(nameof(addresses));
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

        private CodeableConcept? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private ReferenceType? _expressedby;

        /// <summary>
        /// expressedBy
        /// </summary>
        /// <remarks>
        /// <para>
        /// expressedBy 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? expressedBy
        {
            get => _expressedby;
            set
            {
                _expressedby = value;
                OnPropertyChanged(nameof(expressedBy));
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

        private FhirCode? _lifecyclestatus;

        /// <summary>
        /// lifecycleStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// lifecycleStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? lifecycleStatus
        {
            get => _lifecyclestatus;
            set
            {
                _lifecyclestatus = value;
                OnPropertyChanged(nameof(lifecycleStatus));
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

        private List<CodeableConcept>? _outcomecode;

        /// <summary>
        /// outcomeCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcomeCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? outcomeCode
        {
            get => _outcomecode;
            set
            {
                _outcomecode = value;
                OnPropertyChanged(nameof(outcomeCode));
            }
        }

        private List<ReferenceType>? _outcomereference;

        /// <summary>
        /// outcomeReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcomeReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? outcomeReference
        {
            get => _outcomereference;
            set
            {
                _outcomereference = value;
                OnPropertyChanged(nameof(outcomeReference));
            }
        }

        private CodeableConcept? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
            }
        }

        private FhirDate? _statusdate;

        /// <summary>
        /// statusDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? statusDate
        {
            get => _statusdate;
            set
            {
                _statusdate = value;
                OnPropertyChanged(nameof(statusDate));
            }
        }

        private FhirString? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? statusReason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(statusReason));
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

        private List<BackboneElement>? _target;

        /// <summary>
        /// target
        /// </summary>
        /// <remarks>
        /// <para>
        /// target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(target));
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
        public override string ResourceType => "Goal";

        /// <summary>
        /// 建立新的 Goal 資源實例
        /// </summary>
        public Goal()
        {
        }

        /// <summary>
        /// 建立新的 Goal 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Goal(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Goal(Id: {Id})";
        }
    }
}
