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
    /// FHIR R5 PaymentReconciliation 資源
    /// 
    /// <para>
    /// PaymentReconciliation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var paymentreconciliation = new PaymentReconciliation("paymentreconciliation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 PaymentReconciliation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PaymentReconciliation : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private CodeableConcept? _type;
        private FhirCode? _status;
        private CodeableConcept? _kind;
        private Period? _period;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _enterer;
        private CodeableConcept? _issuertype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _paymentissuer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _request;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requestor;
        private FhirCode? _outcome;
        private FhirString? _disposition;
        private FhirDate? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private CodeableConcept? _method;
        private FhirString? _cardbrand;
        private FhirString? _accountnumber;
        private FhirDate? _expirationdate;
        private FhirString? _processor;
        private FhirString? _referencenumber;
        private FhirString? _authorization;
        private Money? _tenderedamount;
        private Money? _returnedamount;
        private Money? _amount;
        private Identifier? _paymentidentifier;
        private List<PaymentReconciliationAllocation>? _allocation;
        private CodeableConcept? _formcode;
        private List<PaymentReconciliationProcessNote>? _processnote;
        private Identifier? _identifier;
        private Identifier? _predecessor;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _target;
        private PaymentReconciliationAllocationTargetItemChoice? _targetitem;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _account;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _submitter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _response;
        private FhirDate? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _responsible;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _payee;
        private Money? _amount;
        private FhirCode? _type;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PaymentReconciliation";        /// <summary>
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
        public CodeableConcept? Kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(Kind));
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
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(Created));
            }
        }        /// <summary>
        /// Enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(Enterer));
            }
        }        /// <summary>
        /// Issuertype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issuertype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Issuertype
        {
            get => _issuertype;
            set
            {
                _issuertype = value;
                OnPropertyChanged(nameof(Issuertype));
            }
        }        /// <summary>
        /// Paymentissuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentissuer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Paymentissuer
        {
            get => _paymentissuer;
            set
            {
                _paymentissuer = value;
                OnPropertyChanged(nameof(Paymentissuer));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }        /// <summary>
        /// Requestor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Requestor
        {
            get => _requestor;
            set
            {
                _requestor = value;
                OnPropertyChanged(nameof(Requestor));
            }
        }        /// <summary>
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(Disposition));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
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
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }        /// <summary>
        /// Cardbrand
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cardbrand 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Cardbrand
        {
            get => _cardbrand;
            set
            {
                _cardbrand = value;
                OnPropertyChanged(nameof(Cardbrand));
            }
        }        /// <summary>
        /// Accountnumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Accountnumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Accountnumber
        {
            get => _accountnumber;
            set
            {
                _accountnumber = value;
                OnPropertyChanged(nameof(Accountnumber));
            }
        }        /// <summary>
        /// Expirationdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expirationdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Expirationdate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged(nameof(Expirationdate));
            }
        }        /// <summary>
        /// Processor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Processor
        {
            get => _processor;
            set
            {
                _processor = value;
                OnPropertyChanged(nameof(Processor));
            }
        }        /// <summary>
        /// Referencenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referencenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Referencenumber
        {
            get => _referencenumber;
            set
            {
                _referencenumber = value;
                OnPropertyChanged(nameof(Referencenumber));
            }
        }        /// <summary>
        /// Authorization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authorization 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Authorization
        {
            get => _authorization;
            set
            {
                _authorization = value;
                OnPropertyChanged(nameof(Authorization));
            }
        }        /// <summary>
        /// Tenderedamount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tenderedamount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tenderedamount
        {
            get => _tenderedamount;
            set
            {
                _tenderedamount = value;
                OnPropertyChanged(nameof(Tenderedamount));
            }
        }        /// <summary>
        /// Returnedamount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Returnedamount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Returnedamount
        {
            get => _returnedamount;
            set
            {
                _returnedamount = value;
                OnPropertyChanged(nameof(Returnedamount));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }        /// <summary>
        /// Paymentidentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentidentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Paymentidentifier
        {
            get => _paymentidentifier;
            set
            {
                _paymentidentifier = value;
                OnPropertyChanged(nameof(Paymentidentifier));
            }
        }        /// <summary>
        /// Allocation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Allocation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PaymentReconciliationAllocation>? Allocation
        {
            get => _allocation;
            set
            {
                _allocation = value;
                OnPropertyChanged(nameof(Allocation));
            }
        }        /// <summary>
        /// Formcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Formcode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Formcode
        {
            get => _formcode;
            set
            {
                _formcode = value;
                OnPropertyChanged(nameof(Formcode));
            }
        }        /// <summary>
        /// Processnote
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processnote 的詳細描述。
        /// </para>
        /// </remarks>
        public List<PaymentReconciliationProcessNote>? Processnote
        {
            get => _processnote;
            set
            {
                _processnote = value;
                OnPropertyChanged(nameof(Processnote));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Predecessor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Predecessor 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? Predecessor
        {
            get => _predecessor;
            set
            {
                _predecessor = value;
                OnPropertyChanged(nameof(Predecessor));
            }
        }        /// <summary>
        /// Target
        /// </summary>
        /// <remarks>
        /// <para>
        /// Target 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(Target));
            }
        }        /// <summary>
        /// Targetitem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetitem 的詳細描述。
        /// </para>
        /// </remarks>
        public PaymentReconciliationAllocationTargetItemChoice? Targetitem
        {
            get => _targetitem;
            set
            {
                _targetitem = value;
                OnPropertyChanged(nameof(Targetitem));
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
        /// Account
        /// </summary>
        /// <remarks>
        /// <para>
        /// Account 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
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
        /// Submitter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Submitter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Submitter
        {
            get => _submitter;
            set
            {
                _submitter = value;
                OnPropertyChanged(nameof(Submitter));
            }
        }        /// <summary>
        /// Response
        /// </summary>
        /// <remarks>
        /// <para>
        /// Response 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Response
        {
            get => _response;
            set
            {
                _response = value;
                OnPropertyChanged(nameof(Response));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Responsible
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsible 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Responsible
        {
            get => _responsible;
            set
            {
                _responsible = value;
                OnPropertyChanged(nameof(Responsible));
            }
        }        /// <summary>
        /// Payee
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payee 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Payee
        {
            get => _payee;
            set
            {
                _payee = value;
                OnPropertyChanged(nameof(Payee));
            }
        }        /// <summary>
        /// Amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// Amount 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
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
        /// 建立新的 PaymentReconciliation 資源實例
        /// </summary>
        public PaymentReconciliation()
        {
        }

        /// <summary>
        /// 建立新的 PaymentReconciliation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public PaymentReconciliation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"PaymentReconciliation(Id: {Id})";
        }
    }    /// <summary>
    /// PaymentReconciliationAllocation 背骨元素
    /// </summary>
    public class PaymentReconciliationAllocation
    {
        // TODO: 添加屬性實作
        
        public PaymentReconciliationAllocation() { }
    }    /// <summary>
    /// PaymentReconciliationProcessNote 背骨元素
    /// </summary>
    public class PaymentReconciliationProcessNote
    {
        // TODO: 添加屬性實作
        
        public PaymentReconciliationProcessNote() { }
    }    /// <summary>
    /// PaymentReconciliationAllocationTargetItemChoice 選擇類型
    /// </summary>
    public class PaymentReconciliationAllocationTargetItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public PaymentReconciliationAllocationTargetItemChoice(JsonObject value) : base("paymentreconciliationallocationtargetitem", value, _supportType) { }
        public PaymentReconciliationAllocationTargetItemChoice(IComplexType? value) : base("paymentreconciliationallocationtargetitem", value) { }
        public PaymentReconciliationAllocationTargetItemChoice(IPrimitiveType? value) : base("paymentreconciliationallocationtargetitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "PaymentReconciliationAllocationTargetItem" : "paymentreconciliationallocationtargetitem";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
