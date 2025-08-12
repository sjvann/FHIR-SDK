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
    /// FHIR R5 Permission 資源
    /// 
    /// <para>
    /// Permission 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var permission = new Permission("permission-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Permission 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Permission : ResourceBase<R5Version>
    {
        private Property
		private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _asserter;
        private List<FhirDateTime>? _date;
        private Period? _validity;
        private PermissionJustification? _justification;
        private FhirCode? _combining;
        private List<PermissionRule>? _rule;
        private List<CodeableConcept>? _basis;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _evidence;
        private FhirCode? _meaning;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private List<PermissionRuleDataResource>? _resource;
        private List<Coding>? _security;
        private List<Period>? _period;
        private ExpressionType? _expression;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _actor;
        private List<CodeableConcept>? _action;
        private List<CodeableConcept>? _purpose;
        private FhirCode? _type;
        private List<PermissionRuleData>? _data;
        private List<PermissionRuleActivity>? _activity;
        private List<CodeableConcept>? _limit;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Permission";        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Asserter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Asserter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Asserter
        {
            get => _asserter;
            set
            {
                _asserter = value;
                OnPropertyChanged(nameof(Asserter));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirDateTime>? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Validity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validity 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Validity
        {
            get => _validity;
            set
            {
                _validity = value;
                OnPropertyChanged(nameof(Validity));
            }
        }        /// <summary>
        /// Justification
        /// </summary>
        /// <remarks>
        /// <para>
        /// Justification 的詳細描述。
        /// </para>
        /// </remarks>
        public PermissionJustification? Justification
        {
            get => _justification;
            set
            {
                _justification = value;
                OnPropertyChanged(nameof(Justification));
            }
        }        /// <summary>
        /// Combining
        /// </summary>
        /// <remarks>
        /// <para>
        /// Combining 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Combining
        {
            get => _combining;
            set
            {
                _combining = value;
                OnPropertyChanged(nameof(Combining));
            }
        }        /// <summary>
        /// Rule
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rule 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PermissionRule>? Rule
        {
            get => _rule;
            set
            {
                _rule = value;
                OnPropertyChanged(nameof(Rule));
            }
        }        /// <summary>
        /// Basis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Basis
        {
            get => _basis;
            set
            {
                _basis = value;
                OnPropertyChanged(nameof(Basis));
            }
        }        /// <summary>
        /// Evidence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Evidence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Evidence
        {
            get => _evidence;
            set
            {
                _evidence = value;
                OnPropertyChanged(nameof(Evidence));
            }
        }        /// <summary>
        /// Meaning
        /// </summary>
        /// <remarks>
        /// <para>
        /// Meaning 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Meaning
        {
            get => _meaning;
            set
            {
                _meaning = value;
                OnPropertyChanged(nameof(Meaning));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PermissionRuleDataResource>? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Security
        /// </summary>
        /// <remarks>
        /// <para>
        /// Security 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Security
        {
            get => _security;
            set
            {
                _security = value;
                OnPropertyChanged(nameof(Security));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Period>? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public ExpressionType? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Data
        /// </summary>
        /// <remarks>
        /// <para>
        /// Data 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PermissionRuleData>? Data
        {
            get => _data;
            set
            {
                _data = value;
                OnPropertyChanged(nameof(Data));
            }
        }        /// <summary>
        /// Activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Activity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PermissionRuleActivity>? Activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(Activity));
            }
        }        /// <summary>
        /// Limit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Limit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Limit
        {
            get => _limit;
            set
            {
                _limit = value;
                OnPropertyChanged(nameof(Limit));
            }
        }        /// <summary>
        /// 建立新的 Permission 資源實例
        /// </summary>
        public Permission()
        {
        }

        /// <summary>
        /// 建立新的 Permission 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Permission(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Permission(Id: {Id})";
        }
    }    /// <summary>
    /// PermissionJustification 背骨元素
    /// </summary>
    public class PermissionJustification
    {
        // TODO: 添加屬性實作
        
        public PermissionJustification() { }
    }    /// <summary>
    /// PermissionRuleDataResource 背骨元素
    /// </summary>
    public class PermissionRuleDataResource
    {
        // TODO: 添加屬性實作
        
        public PermissionRuleDataResource() { }
    }    /// <summary>
    /// PermissionRuleData 背骨元素
    /// </summary>
    public class PermissionRuleData
    {
        // TODO: 添加屬性實作
        
        public PermissionRuleData() { }
    }    /// <summary>
    /// PermissionRuleActivity 背骨元素
    /// </summary>
    public class PermissionRuleActivity
    {
        // TODO: 添加屬性實作
        
        public PermissionRuleActivity() { }
    }    /// <summary>
    /// PermissionRule 背骨元素
    /// </summary>
    public class PermissionRule
    {
        // TODO: 添加屬性實作
        
        public PermissionRule() { }
    }
}
