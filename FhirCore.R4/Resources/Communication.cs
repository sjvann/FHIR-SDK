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
    /// FHIR R4 Communication 資源
    /// 
    /// <para>
    /// An occurrence of information being transmitted; e.g. an alert that was sent to a responsible provider, a public health agency that was notified about a reportable condition.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var communication = new Communication("communication-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Communication 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Communication : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _about;

        /// <summary>
        /// about
        /// </summary>
        /// <remarks>
        /// <para>
        /// about 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? about
        {
            get => _about;
            set
            {
                _about = value;
                OnPropertyChanged(nameof(about));
            }
        }

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

        private List<ReferenceType>? _inresponseto;

        /// <summary>
        /// inResponseTo
        /// </summary>
        /// <remarks>
        /// <para>
        /// inResponseTo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? inResponseTo
        {
            get => _inresponseto;
            set
            {
                _inresponseto = value;
                OnPropertyChanged(nameof(inResponseTo));
            }
        }

        private List<FhirCanonical>? _instantiatescanonical;

        /// <summary>
        /// instantiatesCanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesCanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? instantiatesCanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(instantiatesCanonical));
            }
        }

        private List<FhirUri>? _instantiatesuri;

        /// <summary>
        /// instantiatesUri
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesUri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? instantiatesUri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(instantiatesUri));
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

        private List<CodeableConcept>? _medium;

        /// <summary>
        /// medium
        /// </summary>
        /// <remarks>
        /// <para>
        /// medium 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? medium
        {
            get => _medium;
            set
            {
                _medium = value;
                OnPropertyChanged(nameof(medium));
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

        private List<ReferenceType>? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
            }
        }

        private List<BackboneElement>? _payload;

        /// <summary>
        /// payload
        /// </summary>
        /// <remarks>
        /// <para>
        /// payload 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? payload
        {
            get => _payload;
            set
            {
                _payload = value;
                OnPropertyChanged(nameof(payload));
            }
        }

        private FhirCode? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
            }
        }

        private List<CodeableConcept>? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private List<ReferenceType>? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private FhirDateTime? _received;

        /// <summary>
        /// received
        /// </summary>
        /// <remarks>
        /// <para>
        /// received 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? received
        {
            get => _received;
            set
            {
                _received = value;
                OnPropertyChanged(nameof(received));
            }
        }

        private List<ReferenceType>? _recipient;

        /// <summary>
        /// recipient
        /// </summary>
        /// <remarks>
        /// <para>
        /// recipient 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? recipient
        {
            get => _recipient;
            set
            {
                _recipient = value;
                OnPropertyChanged(nameof(recipient));
            }
        }

        private ReferenceType? _sender;

        /// <summary>
        /// sender
        /// </summary>
        /// <remarks>
        /// <para>
        /// sender 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? sender
        {
            get => _sender;
            set
            {
                _sender = value;
                OnPropertyChanged(nameof(sender));
            }
        }

        private FhirDateTime? _sent;

        /// <summary>
        /// sent
        /// </summary>
        /// <remarks>
        /// <para>
        /// sent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? sent
        {
            get => _sent;
            set
            {
                _sent = value;
                OnPropertyChanged(nameof(sent));
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

        private CodeableConcept? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? statusReason
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

        private CodeableConcept? _topic;

        /// <summary>
        /// topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// topic 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(topic));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Communication";

        /// <summary>
        /// 建立新的 Communication 資源實例
        /// </summary>
        public Communication()
        {
        }

        /// <summary>
        /// 建立新的 Communication 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Communication(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Communication(Id: {Id})";
        }
    }
}
