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
    /// FHIR R5 Provenance 資源
    /// 
    /// <para>
    /// Provenance 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 Provenance 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Provenance : ResourceBase<R5Version>
    {
        private Property
		private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _target;
        private ProvenanceOccurredChoice? _occurred;
        private FhirInstant? _recorded;
        private List<FhirUri>? _policy;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private List<CodeableReference>? _authorization;
        private CodeableConcept? _activity;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<ProvenanceAgent>? _agent;
        private List<ProvenanceEntity>? _entity;
        private List<Signature>? _signature;
        private CodeableConcept? _type;
        private List<CodeableConcept>? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _who;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _onbehalfof;
        private FhirCode? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _what;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Provenance";        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Occurred
        /// </summary>
        /// <remarks>
        /// <para>
        /// Occurred 的詳細描述。
        /// </para>
        /// </remarks>
        public ProvenanceOccurredChoice? Occurred
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
        /// Authorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Authorization
        {
            get => _authorization;
            set
            {
                _authorization = value;
                OnPropertyChanged(nameof(Authorization));
            }
        }        /// <summary>
        /// Activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Activity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(Activity));
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
        public List<ProvenanceAgent>? Agent
        {
            get => _agent;
            set
            {
                _agent = value;
                OnPropertyChanged(nameof(Agent));
            }
        }        /// <summary>
        /// Entity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Entity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ProvenanceEntity>? Entity
        {
            get => _entity;
            set
            {
                _entity = value;
                OnPropertyChanged(nameof(Entity));
            }
        }        /// <summary>
        /// Signature
        /// </summary>
        /// <remarks>
        /// <para>
        /// Signature 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Signature>? Signature
        {
            get => _signature;
            set
            {
                _signature = value;
                OnPropertyChanged(nameof(Signature));
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
        /// Onbehalfof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onbehalfof 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Onbehalfof
        {
            get => _onbehalfof;
            set
            {
                _onbehalfof = value;
                OnPropertyChanged(nameof(Onbehalfof));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
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
    }    /// <summary>
    /// ProvenanceAgent 背骨元素
    /// </summary>
    public class ProvenanceAgent
    {
        // TODO: 添加屬性實作
        
        public ProvenanceAgent() { }
    }    /// <summary>
    /// ProvenanceEntity 背骨元素
    /// </summary>
    public class ProvenanceEntity
    {
        // TODO: 添加屬性實作
        
        public ProvenanceEntity() { }
    }    /// <summary>
    /// ProvenanceOccurredChoice 選擇類型
    /// </summary>
    public class ProvenanceOccurredChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ProvenanceOccurredChoice(JsonObject value) : base("provenanceoccurred", value, _supportType) { }
        public ProvenanceOccurredChoice(IComplexType? value) : base("provenanceoccurred", value) { }
        public ProvenanceOccurredChoice(IPrimitiveType? value) : base("provenanceoccurred", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ProvenanceOccurred" : "provenanceoccurred";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
