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
    /// FHIR R5 AuditEvent 資源
    /// 
    /// <para>
    /// AuditEvent 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 AuditEvent 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AuditEvent : ResourceBase<R5Version>
    {
        private Property
		private List<CodeableConcept>? _category;
        private CodeableConcept? _code;
        private FhirCode? _action;
        private FhirCode? _severity;
        private AuditEventOccurredChoice? _occurred;
        private FhirInstant? _recorded;
        private AuditEventOutcome? _outcome;
        private List<CodeableConcept>? _authorization;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<AuditEventAgent>? _agent;
        private AuditEventSource? _source;
        private List<AuditEventEntity>? _entity;
        private Coding? _code;
        private List<CodeableConcept>? _detail;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _who;
        private FhirBoolean? _requestor;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<FhirUri>? _policy;
        private AuditEventAgentNetworkChoice? _network;
        private List<CodeableConcept>? _authorization;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _site;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _observer;
        private List<CodeableConcept>? _type;
        private CodeableConcept? _type;
        private AuditEventEntityDetailValueChoice? _value;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _what;
        private CodeableConcept? _role;
        private List<CodeableConcept>? _securitylabel;
        private FhirBase64Binary? _query;
        private List<AuditEventEntityDetail>? _detail;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AuditEvent";        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<CodeableConcept>? Category
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
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
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
        /// Occurred
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurred 的詳細描述。
        /// </para>
        /// </remarks>
        public AuditEventOccurredChoice? Occurred
        {
            get => _occurred;
            set
            {
                _occurred = value;
                OnPropertyChanged(nameof(Occurred));
            }
        }        /// <summary>
        /// Recorded
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recorded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Recorded
        {
            get => _recorded;
            set
            {
                _recorded = value;
                OnPropertyChanged(nameof(Recorded));
            }
        }        /// <summary>
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public AuditEventOutcome? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Authorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Authorization
        {
            get => _authorization;
            set
            {
                _authorization = value;
                OnPropertyChanged(nameof(Authorization));
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
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
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
        /// Agent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Agent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AuditEventAgent>? Agent
        {
            get => _agent;
            set
            {
                _agent = value;
                OnPropertyChanged(nameof(Agent));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public AuditEventSource? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Entity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AuditEventEntity>? Entity
        {
            get => _entity;
            set
            {
                _entity = value;
                OnPropertyChanged(nameof(Entity));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Code
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
        public List<CodeableConcept>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
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
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Who
        /// </summary>
        /// <remarks>
        /// <para>
        /// Who 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Who
        {
            get => _who;
            set
            {
                _who = value;
                OnPropertyChanged(nameof(Who));
            }
        }        /// <summary>
        /// Requestor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Requestor
        {
            get => _requestor;
            set
            {
                _requestor = value;
                OnPropertyChanged(nameof(Requestor));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Policy
        /// </summary>
        /// <remarks>
        /// <para>
        /// Policy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Policy
        {
            get => _policy;
            set
            {
                _policy = value;
                OnPropertyChanged(nameof(Policy));
            }
        }        /// <summary>
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public AuditEventAgentNetworkChoice? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Authorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Authorization
        {
            get => _authorization;
            set
            {
                _authorization = value;
                OnPropertyChanged(nameof(Authorization));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
            }
        }        /// <summary>
        /// Observer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Observer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Observer
        {
            get => _observer;
            set
            {
                _observer = value;
                OnPropertyChanged(nameof(Observer));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public AuditEventEntityDetailValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// What
        /// </summary>
        /// <remarks>
        /// <para>
        /// What 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? What
        {
            get => _what;
            set
            {
                _what = value;
                OnPropertyChanged(nameof(What));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Securitylabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Securitylabel 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Securitylabel
        {
            get => _securitylabel;
            set
            {
                _securitylabel = value;
                OnPropertyChanged(nameof(Securitylabel));
            }
        }        /// <summary>
        /// Query
        /// </summary>
        /// <remarks>
        /// <para>
        /// Query 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBase64Binary? Query
        {
            get => _query;
            set
            {
                _query = value;
                OnPropertyChanged(nameof(Query));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<AuditEventEntityDetail>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
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
    }    /// <summary>
    /// AuditEventOutcome 背骨元素
    /// </summary>
    public class AuditEventOutcome
    {
        // TODO: 添加屬性實作
        
        public AuditEventOutcome() { }
    }    /// <summary>
    /// AuditEventAgent 背骨元素
    /// </summary>
    public class AuditEventAgent
    {
        // TODO: 添加屬性實作
        
        public AuditEventAgent() { }
    }    /// <summary>
    /// AuditEventSource 背骨元素
    /// </summary>
    public class AuditEventSource
    {
        // TODO: 添加屬性實作
        
        public AuditEventSource() { }
    }    /// <summary>
    /// AuditEventEntityDetail 背骨元素
    /// </summary>
    public class AuditEventEntityDetail
    {
        // TODO: 添加屬性實作
        
        public AuditEventEntityDetail() { }
    }    /// <summary>
    /// AuditEventEntity 背骨元素
    /// </summary>
    public class AuditEventEntity
    {
        // TODO: 添加屬性實作
        
        public AuditEventEntity() { }
    }    /// <summary>
    /// AuditEventOccurredChoice 選擇類型
    /// </summary>
    public class AuditEventOccurredChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AuditEventOccurredChoice(JsonObject value) : base("auditeventoccurred", value, _supportType) { }
        public AuditEventOccurredChoice(IComplexType? value) : base("auditeventoccurred", value) { }
        public AuditEventOccurredChoice(IPrimitiveType? value) : base("auditeventoccurred", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AuditEventOccurred" : "auditeventoccurred";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AuditEventAgentNetworkChoice 選擇類型
    /// </summary>
    public class AuditEventAgentNetworkChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AuditEventAgentNetworkChoice(JsonObject value) : base("auditeventagentnetwork", value, _supportType) { }
        public AuditEventAgentNetworkChoice(IComplexType? value) : base("auditeventagentnetwork", value) { }
        public AuditEventAgentNetworkChoice(IPrimitiveType? value) : base("auditeventagentnetwork", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AuditEventAgentNetwork" : "auditeventagentnetwork";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// AuditEventEntityDetailValueChoice 選擇類型
    /// </summary>
    public class AuditEventEntityDetailValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public AuditEventEntityDetailValueChoice(JsonObject value) : base("auditevententitydetailvalue", value, _supportType) { }
        public AuditEventEntityDetailValueChoice(IComplexType? value) : base("auditevententitydetailvalue", value) { }
        public AuditEventEntityDetailValueChoice(IPrimitiveType? value) : base("auditevententitydetailvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "AuditEventEntityDetailValue" : "auditevententitydetailvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
