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
    /// FHIR R4 Provenance 資源
    /// 
    /// <para>
    /// Provenance of a resource is a record that describes entities and processes involved in producing and delivering or otherwise influencing that resource. Provenance provides a critical foundation for assessing authenticity, enabling trust, and allowing reproducibility. Provenance assertions are a form of contextual metadata and can themselves become important records with their own provenance. Provenance statement indicates clinical significance in terms of confidence in authenticity, reliability, and trustworthiness, integrity, and stage in lifecycle (e.g. Document Completion - has the artifact been legally authenticated), all of which may impact security, privacy, and trust policies.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var provenance = new Provenance("provenance-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Provenance 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Provenance : ResourceBase<R4Version>
    {
        private CodeableConcept? _activity;

        /// <summary>
        /// activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// activity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(activity));
            }
        }

        private List<BackboneElement>? _agent;

        /// <summary>
        /// agent
        /// </summary>
        /// <remarks>
        /// <para>
        /// agent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? agent
        {
            get => _agent;
            set
            {
                _agent = value;
                OnPropertyChanged(nameof(agent));
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

        private List<BackboneElement>? _entity;

        /// <summary>
        /// entity
        /// </summary>
        /// <remarks>
        /// <para>
        /// entity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? entity
        {
            get => _entity;
            set
            {
                _entity = value;
                OnPropertyChanged(nameof(entity));
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

        private List<FhirUri>? _policy;

        /// <summary>
        /// policy
        /// </summary>
        /// <remarks>
        /// <para>
        /// policy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? policy
        {
            get => _policy;
            set
            {
                _policy = value;
                OnPropertyChanged(nameof(policy));
            }
        }

        private List<CodeableConcept>? _reason;

        /// <summary>
        /// reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(reason));
            }
        }

        private FhirInstant? _recorded;

        /// <summary>
        /// recorded
        /// </summary>
        /// <remarks>
        /// <para>
        /// recorded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? recorded
        {
            get => _recorded;
            set
            {
                _recorded = value;
                OnPropertyChanged(nameof(recorded));
            }
        }

        private List<Signature>? _signature;

        /// <summary>
        /// signature
        /// </summary>
        /// <remarks>
        /// <para>
        /// signature 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Signature>? signature
        {
            get => _signature;
            set
            {
                _signature = value;
                OnPropertyChanged(nameof(signature));
            }
        }

        private List<ReferenceType>? _target;

        /// <summary>
        /// target
        /// </summary>
        /// <remarks>
        /// <para>
        /// target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? target
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
        public override string ResourceType => "Provenance";

        /// <summary>
        /// 建立新的 Provenance 資源實例
        /// </summary>
        public Provenance()
        {
        }

        /// <summary>
        /// 建立新的 Provenance 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Provenance(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Provenance(Id: {Id})";
        }
    }
}
