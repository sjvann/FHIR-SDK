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
    /// FHIR R5 Coverage 資源
    /// 
    /// <para>
    /// Coverage 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var coverage = new Coverage("coverage-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Coverage 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Coverage : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirCode? _kind;
        private List<CoveragePaymentBy>? _paymentby;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _policyholder;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subscriber;
        private List<Identifier>? _subscriberid;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _beneficiary;
        private FhirString? _dependent;
        private CodeableConcept? _relationship;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _insurer;
        private List<CoverageClass>? _class;
        private FhirPositiveInt? _order;
        private FhirString? _network;
        private List<CoverageCostToBeneficiary>? _costtobeneficiary;
        private FhirBoolean? _subrogation;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _contract;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _insuranceplan;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _party;
        private FhirString? _responsibility;
        private CodeableConcept? _type;
        private Identifier? _value;
        private FhirString? _name;
        private CodeableConcept? _type;
        private Period? _period;
        private CodeableConcept? _type;
        private CodeableConcept? _category;
        private CodeableConcept? _network;
        private CodeableConcept? _unit;
        private CodeableConcept? _term;
        private CoverageCostToBeneficiaryValueChoice? _value;
        private List<CoverageCostToBeneficiaryException>? _exception;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Coverage";        /// <summary>
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
        /// Kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// Kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(Kind));
            }
        }        /// <summary>
        /// Paymentby
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentby 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoveragePaymentBy>? Paymentby
        {
            get => _paymentby;
            set
            {
                _paymentby = value;
                OnPropertyChanged(nameof(Paymentby));
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
        /// Policyholder
        /// </summary>
        /// <remarks>
        /// <para>
        /// Policyholder 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Policyholder
        {
            get => _policyholder;
            set
            {
                _policyholder = value;
                OnPropertyChanged(nameof(Policyholder));
            }
        }        /// <summary>
        /// Subscriber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subscriber 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subscriber
        {
            get => _subscriber;
            set
            {
                _subscriber = value;
                OnPropertyChanged(nameof(Subscriber));
            }
        }        /// <summary>
        /// Subscriberid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subscriberid 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Subscriberid
        {
            get => _subscriberid;
            set
            {
                _subscriberid = value;
                OnPropertyChanged(nameof(Subscriberid));
            }
        }        /// <summary>
        /// Beneficiary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Beneficiary 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Beneficiary
        {
            get => _beneficiary;
            set
            {
                _beneficiary = value;
                OnPropertyChanged(nameof(Beneficiary));
            }
        }        /// <summary>
        /// Dependent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dependent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Dependent
        {
            get => _dependent;
            set
            {
                _dependent = value;
                OnPropertyChanged(nameof(Dependent));
            }
        }        /// <summary>
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
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
        /// Insurer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Insurer
        {
            get => _insurer;
            set
            {
                _insurer = value;
                OnPropertyChanged(nameof(Insurer));
            }
        }        /// <summary>
        /// Class
        /// </summary>
        /// <remarks>
        /// <para>
        /// Class 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageClass>? Class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            }
        }        /// <summary>
        /// Order
        /// </summary>
        /// <remarks>
        /// <para>
        /// Order 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Order
        {
            get => _order;
            set
            {
                _order = value;
                OnPropertyChanged(nameof(Order));
            }
        }        /// <summary>
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Costtobeneficiary
        /// </summary>
        /// <remarks>
        /// <para>
        /// Costtobeneficiary 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageCostToBeneficiary>? Costtobeneficiary
        {
            get => _costtobeneficiary;
            set
            {
                _costtobeneficiary = value;
                OnPropertyChanged(nameof(Costtobeneficiary));
            }
        }        /// <summary>
        /// Subrogation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subrogation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Subrogation
        {
            get => _subrogation;
            set
            {
                _subrogation = value;
                OnPropertyChanged(nameof(Subrogation));
            }
        }        /// <summary>
        /// Contract
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contract 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Contract
        {
            get => _contract;
            set
            {
                _contract = value;
                OnPropertyChanged(nameof(Contract));
            }
        }        /// <summary>
        /// Insuranceplan
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insuranceplan 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Insuranceplan
        {
            get => _insuranceplan;
            set
            {
                _insuranceplan = value;
                OnPropertyChanged(nameof(Insuranceplan));
            }
        }        /// <summary>
        /// Party
        /// </summary>
        /// <remarks>
        /// <para>
        /// Party 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Party
        {
            get => _party;
            set
            {
                _party = value;
                OnPropertyChanged(nameof(Party));
            }
        }        /// <summary>
        /// Responsibility
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsibility 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Responsibility
        {
            get => _responsibility;
            set
            {
                _responsibility = value;
                OnPropertyChanged(nameof(Responsibility));
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
        public Identifier? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
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
        /// Network
        /// </summary>
        /// <remarks>
        /// <para>
        /// Network 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(Network));
            }
        }        /// <summary>
        /// Unit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }        /// <summary>
        /// Term
        /// </summary>
        /// <remarks>
        /// <para>
        /// Term 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Term
        {
            get => _term;
            set
            {
                _term = value;
                OnPropertyChanged(nameof(Term));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public CoverageCostToBeneficiaryValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Exception
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exception 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CoverageCostToBeneficiaryException>? Exception
        {
            get => _exception;
            set
            {
                _exception = value;
                OnPropertyChanged(nameof(Exception));
            }
        }        /// <summary>
        /// 建立新的 Coverage 資源實例
        /// </summary>
        public Coverage()
        {
        }

        /// <summary>
        /// 建立新的 Coverage 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Coverage(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Coverage(Id: {Id})";
        }
    }    /// <summary>
    /// CoveragePaymentBy 背骨元素
    /// </summary>
    public class CoveragePaymentBy
    {
        // TODO: 添加屬性實作
        
        public CoveragePaymentBy() { }
    }    /// <summary>
    /// CoverageClass 背骨元素
    /// </summary>
    public class CoverageClass
    {
        // TODO: 添加屬性實作
        
        public CoverageClass() { }
    }    /// <summary>
    /// CoverageCostToBeneficiaryException 背骨元素
    /// </summary>
    public class CoverageCostToBeneficiaryException
    {
        // TODO: 添加屬性實作
        
        public CoverageCostToBeneficiaryException() { }
    }    /// <summary>
    /// CoverageCostToBeneficiary 背骨元素
    /// </summary>
    public class CoverageCostToBeneficiary
    {
        // TODO: 添加屬性實作
        
        public CoverageCostToBeneficiary() { }
    }    /// <summary>
    /// CoverageCostToBeneficiaryValueChoice 選擇類型
    /// </summary>
    public class CoverageCostToBeneficiaryValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CoverageCostToBeneficiaryValueChoice(JsonObject value) : base("coveragecosttobeneficiaryvalue", value, _supportType) { }
        public CoverageCostToBeneficiaryValueChoice(IComplexType? value) : base("coveragecosttobeneficiaryvalue", value) { }
        public CoverageCostToBeneficiaryValueChoice(IPrimitiveType? value) : base("coveragecosttobeneficiaryvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CoverageCostToBeneficiaryValue" : "coveragecosttobeneficiaryvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
