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
    /// FHIR R5 InsurancePlan 資源
    /// 
    /// <para>
    /// InsurancePlan 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var insuranceplan = new InsurancePlan("insuranceplan-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 InsurancePlan 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class InsurancePlan : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _type;
        private FhirString? _name;
        private List<FhirString>? _alias;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _ownedby;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _administeredby;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _coveragearea;
        private List<ExtendedContactDetail>? _contact;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _endpoint;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _network;
        private List<InsurancePlanCoverage>? _coverage;
        private List<InsurancePlanPlan>? _plan;
        private Quantity? _value;
        private CodeableConcept? _code;
        private CodeableConcept? _type;
        private FhirString? _requirement;
        private List<InsurancePlanCoverageBenefitLimit>? _limit;
        private CodeableConcept? _type;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _network;
        private List<InsurancePlanCoverageBenefit>? _benefit;
        private CodeableConcept? _type;
        private FhirPositiveInt? _groupsize;
        private Money? _cost;
        private FhirString? _comment;
        private CodeableConcept? _type;
        private CodeableConcept? _applicability;
        private List<CodeableConcept>? _qualifiers;
        private Quantity? _value;
        private CodeableConcept? _type;
        private List<InsurancePlanPlanSpecificCostBenefitCost>? _cost;
        private CodeableConcept? _category;
        private List<InsurancePlanPlanSpecificCostBenefit>? _benefit;
        private List<Identifier>? _identifier;
        private CodeableConcept? _type;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _coveragearea;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _network;
        private List<InsurancePlanPlanGeneralCost>? _generalcost;
        private List<InsurancePlanPlanSpecificCost>? _specificcost;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "InsurancePlan";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
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
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Alias
        /// </summary>
        /// <remarks>
        /// <para>
        /// Alias 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(Alias));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Ownedby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Ownedby 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Ownedby
        {
            get => _ownedby;
            set
            {
                _ownedby = value;
                OnPropertyChanged(nameof(Ownedby));
            }
        }        /// <summary>
        /// Administeredby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Administeredby 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Administeredby
        {
            get => _administeredby;
            set
            {
                _administeredby = value;
                OnPropertyChanged(nameof(Administeredby));
            }
        }        /// <summary>
        /// Coveragearea
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coveragearea 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Coveragearea
        {
            get => _coveragearea;
            set
            {
                _coveragearea = value;
                OnPropertyChanged(nameof(Coveragearea));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ExtendedContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }        /// <summary>
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanCoverage>? Coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(Coverage));
            }
        }        /// <summary>
        /// Plan
        /// </summary>
        /// <remarks>
        /// <para>
        /// Plan 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanPlan>? Plan
        {
            get => _plan;
            set
            {
                _plan = value;
                OnPropertyChanged(nameof(Plan));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Requirement
        {
            get => _requirement;
            set
            {
                _requirement = value;
                OnPropertyChanged(nameof(Requirement));
            }
        }        /// <summary>
        /// Limit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Limit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanCoverageBenefitLimit>? Limit
        {
            get => _limit;
            set
            {
                _limit = value;
                OnPropertyChanged(nameof(Limit));
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
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Benefit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Benefit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanCoverageBenefit>? Benefit
        {
            get => _benefit;
            set
            {
                _benefit = value;
                OnPropertyChanged(nameof(Benefit));
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
        /// Groupsize
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupsize 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Groupsize
        {
            get => _groupsize;
            set
            {
                _groupsize = value;
                OnPropertyChanged(nameof(Groupsize));
            }
        }        /// <summary>
        /// Cost
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cost 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));
            }
        }        /// <summary>
        /// Comment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged(nameof(Comment));
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
        /// Applicability
        /// </summary>
        /// <remarks>
        /// <para>
        /// Applicability 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Applicability
        {
            get => _applicability;
            set
            {
                _applicability = value;
                OnPropertyChanged(nameof(Applicability));
            }
        }        /// <summary>
        /// Qualifiers
        /// </summary>
        /// <remarks>
        /// <para>
        /// Qualifiers 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Qualifiers
        {
            get => _qualifiers;
            set
            {
                _qualifiers = value;
                OnPropertyChanged(nameof(Qualifiers));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Cost
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cost 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanPlanSpecificCostBenefitCost>? Cost
        {
            get => _cost;
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Benefit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Benefit 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanPlanSpecificCostBenefit>? Benefit
        {
            get => _benefit;
            set
            {
                _benefit = value;
                OnPropertyChanged(nameof(Benefit));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
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
        /// Coveragearea
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coveragearea 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Coveragearea
        {
            get => _coveragearea;
            set
            {
                _coveragearea = value;
                OnPropertyChanged(nameof(Coveragearea));
            }
        }        /// <summary>
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Generalcost
        /// </summary>
        /// <remarks>
        /// <para>
        /// Generalcost 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanPlanGeneralCost>? Generalcost
        {
            get => _generalcost;
            set
            {
                _generalcost = value;
                OnPropertyChanged(nameof(Generalcost));
            }
        }        /// <summary>
        /// Specificcost
        /// </summary>
        /// <remarks>
        /// <para>
        /// Specificcost 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InsurancePlanPlanSpecificCost>? Specificcost
        {
            get => _specificcost;
            set
            {
                _specificcost = value;
                OnPropertyChanged(nameof(Specificcost));
            }
        }        /// <summary>
        /// 建立新的 InsurancePlan 資源實例
        /// </summary>
        public InsurancePlan()
        {
        }

        /// <summary>
        /// 建立新的 InsurancePlan 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public InsurancePlan(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"InsurancePlan(Id: {Id})";
        }
    }    /// <summary>
    /// InsurancePlanCoverageBenefitLimit 背骨元素
    /// </summary>
    public class InsurancePlanCoverageBenefitLimit
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanCoverageBenefitLimit() { }
    }    /// <summary>
    /// InsurancePlanCoverageBenefit 背骨元素
    /// </summary>
    public class InsurancePlanCoverageBenefit
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanCoverageBenefit() { }
    }    /// <summary>
    /// InsurancePlanCoverage 背骨元素
    /// </summary>
    public class InsurancePlanCoverage
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanCoverage() { }
    }    /// <summary>
    /// InsurancePlanPlanGeneralCost 背骨元素
    /// </summary>
    public class InsurancePlanPlanGeneralCost
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanPlanGeneralCost() { }
    }    /// <summary>
    /// InsurancePlanPlanSpecificCostBenefitCost 背骨元素
    /// </summary>
    public class InsurancePlanPlanSpecificCostBenefitCost
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanPlanSpecificCostBenefitCost() { }
    }    /// <summary>
    /// InsurancePlanPlanSpecificCostBenefit 背骨元素
    /// </summary>
    public class InsurancePlanPlanSpecificCostBenefit
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanPlanSpecificCostBenefit() { }
    }    /// <summary>
    /// InsurancePlanPlanSpecificCost 背骨元素
    /// </summary>
    public class InsurancePlanPlanSpecificCost
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanPlanSpecificCost() { }
    }    /// <summary>
    /// InsurancePlanPlan 背骨元素
    /// </summary>
    public class InsurancePlanPlan
    {
        // TODO: 添加屬性實作
        
        public InsurancePlanPlan() { }
    }
}
