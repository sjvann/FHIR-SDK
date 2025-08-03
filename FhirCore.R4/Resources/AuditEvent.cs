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
    /// FHIR R4 AuditEvent 資源
    /// 
    /// <para>
    /// A record of an event made for purposes of maintaining a security log. Typical uses include detection of intrusion attempts and monitoring for inappropriate usage.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var auditevent = new AuditEvent("auditevent-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 AuditEvent 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AuditEvent : ResourceBase<R4Version>
    {
        private FhirCode? _action;

        /// <summary>
        /// action
        /// </summary>
        /// <remarks>
        /// <para>
        /// action 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(action));
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

        private FhirCode? _outcome;

        /// <summary>
        /// outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(outcome));
            }
        }

        private FhirString? _outcomedesc;

        /// <summary>
        /// outcomeDesc
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcomeDesc 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? outcomeDesc
        {
            get => _outcomedesc;
            set
            {
                _outcomedesc = value;
                OnPropertyChanged(nameof(outcomeDesc));
            }
        }

        private Period? _period;

        /// <summary>
        /// period
        /// </summary>
        /// <remarks>
        /// <para>
        /// period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(period));
            }
        }

        private List<CodeableConcept>? _purposeofevent;

        /// <summary>
        /// purposeOfEvent
        /// </summary>
        /// <remarks>
        /// <para>
        /// purposeOfEvent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? purposeOfEvent
        {
            get => _purposeofevent;
            set
            {
                _purposeofevent = value;
                OnPropertyChanged(nameof(purposeOfEvent));
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

        private BackboneElement? _source;

        /// <summary>
        /// source
        /// </summary>
        /// <remarks>
        /// <para>
        /// source 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(source));
            }
        }

        private List<Coding>? _subtype;

        /// <summary>
        /// subtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// subtype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? subtype
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(subtype));
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

        private Coding? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AuditEvent";

        /// <summary>
        /// 建立新的 AuditEvent 資源實例
        /// </summary>
        public AuditEvent()
        {
        }

        /// <summary>
        /// 建立新的 AuditEvent 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AuditEvent(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AuditEvent(Id: {Id})";
        }
    }
}
