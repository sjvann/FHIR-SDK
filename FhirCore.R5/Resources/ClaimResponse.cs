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
    /// FHIR R5 ClaimResponse 資源
    /// 
    /// <para>
    /// ClaimResponse 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var claimresponse = new ClaimResponse("claimresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ClaimResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ClaimResponse : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<Identifier>? _tracenumber;
        private FhirCode? _status;
        private CodeableConcept? _type;
        private CodeableConcept? _subtype;
        private FhirCode? _use;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _insurer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _requestor;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _request;
        private FhirCode? _outcome;
        private CodeableConcept? _decision;
        private FhirString? _disposition;
        private FhirString? _preauthref;
        private Period? _preauthperiod;
        private List<ClaimResponseEvent>? _event;
        private CodeableConcept? _payeetype;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _encounter;
        private CodeableConcept? _diagnosisrelatedgroup;
        private List<ClaimResponseItem>? _item;
        private List<ClaimResponseAddItem>? _additem;
        private List<ClaimResponseTotal>? _total;
        private ClaimResponsePayment? _payment;
        private CodeableConcept? _fundsreserve;
        private CodeableConcept? _formcode;
        private Attachment? _form;
        private List<ClaimResponseProcessNote>? _processnote;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _communicationrequest;
        private List<ClaimResponseInsurance>? _insurance;
        private List<ClaimResponseError>? _error;
        private CodeableConcept? _type;
        private ClaimResponseEventWhenChoice? _when;
        private CodeableConcept? _decision;
        private List<CodeableConcept>? _reason;
        private FhirString? _preauthref;
        private Period? _preauthperiod;
        private CodeableConcept? _category;
        private CodeableConcept? _reason;
        private Money? _amount;
        private Quantity? _quantity;
        private FhirPositiveInt? _subdetailsequence;
        private List<Identifier>? _tracenumber;
        private List<FhirPositiveInt>? _notenumber;
        private FhirPositiveInt? _detailsequence;
        private List<Identifier>? _tracenumber;
        private List<FhirPositiveInt>? _notenumber;
        private List<ClaimResponseItemDetailSubDetail>? _subdetail;
        private FhirPositiveInt? _itemsequence;
        private List<Identifier>? _tracenumber;
        private List<FhirPositiveInt>? _notenumber;
        private ClaimResponseItemReviewOutcome? _reviewoutcome;
        private List<ClaimResponseItemAdjudication>? _adjudication;
        private List<ClaimResponseItemDetail>? _detail;
        private List<CodeableReference>? _site;
        private List<CodeableConcept>? _subsite;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<CodeableConcept>? _modifier;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<FhirPositiveInt>? _notenumber;
        private List<Identifier>? _tracenumber;
        private CodeableConcept? _revenue;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<CodeableConcept>? _modifier;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<FhirPositiveInt>? _notenumber;
        private List<ClaimResponseAddItemDetailSubDetail>? _subdetail;
        private List<FhirPositiveInt>? _itemsequence;
        private List<FhirPositiveInt>? _detailsequence;
        private List<FhirPositiveInt>? _subdetailsequence;
        private List<Identifier>? _tracenumber;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _provider;
        private CodeableConcept? _revenue;
        private CodeableConcept? _productorservice;
        private CodeableConcept? _productorserviceend;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _request;
        private List<CodeableConcept>? _modifier;
        private List<CodeableConcept>? _programcode;
        private ClaimResponseAddItemServicedChoice? _serviced;
        private ClaimResponseAddItemLocationChoice? _location;
        private Quantity? _quantity;
        private Money? _unitprice;
        private FhirDecimal? _factor;
        private Money? _tax;
        private Money? _net;
        private List<ClaimResponseAddItemBodySite>? _bodysite;
        private List<FhirPositiveInt>? _notenumber;
        private List<ClaimResponseAddItemDetail>? _detail;
        private CodeableConcept? _category;
        private Money? _amount;
        private CodeableConcept? _type;
        private Money? _adjustment;
        private CodeableConcept? _adjustmentreason;
        private FhirDate? _date;
        private Money? _amount;
        private Identifier? _identifier;
        private FhirPositiveInt? _number;
        private CodeableConcept? _type;
        private CodeableConcept? _language;
        private FhirPositiveInt? _sequence;
        private FhirBoolean? _focal;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _coverage;
        private FhirString? _businessarrangement;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _claimresponse;
        private FhirPositiveInt? _itemsequence;
        private FhirPositiveInt? _detailsequence;
        private FhirPositiveInt? _subdetailsequence;
        private CodeableConcept? _code;
        private List<FhirString>? _expression;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ClaimResponse";        /// <summary>
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
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
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
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Subtype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subtype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Subtype
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(Subtype));
            }
        }        /// <summary>
        /// Use
        /// </summary>
        /// <remarks>
        /// <para>
        /// Use 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(Use));
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
        /// Decision
        /// </summary>
        /// <remarks>
        /// <para>
        /// Decision 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Decision
        {
            get => _decision;
            set
            {
                _decision = value;
                OnPropertyChanged(nameof(Decision));
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
        /// Preauthref
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthref 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Preauthref
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(Preauthref));
            }
        }        /// <summary>
        /// Preauthperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Preauthperiod
        {
            get => _preauthperiod;
            set
            {
                _preauthperiod = value;
                OnPropertyChanged(nameof(Preauthperiod));
            }
        }        /// <summary>
        /// Event
        /// </summary>
        /// <remarks>
        /// <para>
        /// Event 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseEvent>? Event
        {
            get => _event;
            set
            {
                _event = value;
                OnPropertyChanged(nameof(Event));
            }
        }        /// <summary>
        /// Payeetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payeetype 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Payeetype
        {
            get => _payeetype;
            set
            {
                _payeetype = value;
                OnPropertyChanged(nameof(Payeetype));
            }
        }        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Diagnosisrelatedgroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosisrelatedgroup 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Diagnosisrelatedgroup
        {
            get => _diagnosisrelatedgroup;
            set
            {
                _diagnosisrelatedgroup = value;
                OnPropertyChanged(nameof(Diagnosisrelatedgroup));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Additem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Additem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseAddItem>? Additem
        {
            get => _additem;
            set
            {
                _additem = value;
                OnPropertyChanged(nameof(Additem));
            }
        }        /// <summary>
        /// Total
        /// </summary>
        /// <remarks>
        /// <para>
        /// Total 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseTotal>? Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged(nameof(Total));
            }
        }        /// <summary>
        /// Payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payment 的詳細描述。
        /// </para>
        /// </remarks>
        public ClaimResponsePayment? Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }        /// <summary>
        /// Fundsreserve
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fundsreserve 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Fundsreserve
        {
            get => _fundsreserve;
            set
            {
                _fundsreserve = value;
                OnPropertyChanged(nameof(Fundsreserve));
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
        /// Form
        /// </summary>
        /// <remarks>
        /// <para>
        /// Form 的詳細描述。
        /// </para>
        /// </remarks>
        public Attachment? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }        /// <summary>
        /// Processnote
        /// </summary>
        /// <remarks>
        /// <para>
        /// Processnote 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseProcessNote>? Processnote
        {
            get => _processnote;
            set
            {
                _processnote = value;
                OnPropertyChanged(nameof(Processnote));
            }
        }        /// <summary>
        /// Communicationrequest
        /// </summary>
        /// <remarks>
        /// <para>
        /// Communicationrequest 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Communicationrequest
        {
            get => _communicationrequest;
            set
            {
                _communicationrequest = value;
                OnPropertyChanged(nameof(Communicationrequest));
            }
        }        /// <summary>
        /// Insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseInsurance>? Insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(Insurance));
            }
        }        /// <summary>
        /// Error
        /// </summary>
        /// <remarks>
        /// <para>
        /// Error 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseError>? Error
        {
            get => _error;
            set
            {
                _error = value;
                OnPropertyChanged(nameof(Error));
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
        /// When
        /// </summary>
        /// <remarks>
        /// <para>
        /// When 的詳細描述。
        /// </para>
        /// </remarks>
        public ClaimResponseEventWhenChoice? When
        {
            get => _when;
            set
            {
                _when = value;
                OnPropertyChanged(nameof(When));
            }
        }        /// <summary>
        /// Decision
        /// </summary>
        /// <remarks>
        /// <para>
        /// Decision 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Decision
        {
            get => _decision;
            set
            {
                _decision = value;
                OnPropertyChanged(nameof(Decision));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Preauthref
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthref 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Preauthref
        {
            get => _preauthref;
            set
            {
                _preauthref = value;
                OnPropertyChanged(nameof(Preauthref));
            }
        }        /// <summary>
        /// Preauthperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Preauthperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Preauthperiod
        {
            get => _preauthperiod;
            set
            {
                _preauthperiod = value;
                OnPropertyChanged(nameof(Preauthperiod));
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
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
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
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Subdetailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Subdetailsequence
        {
            get => _subdetailsequence;
            set
            {
                _subdetailsequence = value;
                OnPropertyChanged(nameof(Subdetailsequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Detailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Detailsequence
        {
            get => _detailsequence;
            set
            {
                _detailsequence = value;
                OnPropertyChanged(nameof(Detailsequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Subdetail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseItemDetailSubDetail>? Subdetail
        {
            get => _subdetail;
            set
            {
                _subdetail = value;
                OnPropertyChanged(nameof(Subdetail));
            }
        }        /// <summary>
        /// Itemsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Itemsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Itemsequence
        {
            get => _itemsequence;
            set
            {
                _itemsequence = value;
                OnPropertyChanged(nameof(Itemsequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Reviewoutcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reviewoutcome 的詳細描述。
        /// </para>
        /// </remarks>
        public ClaimResponseItemReviewOutcome? Reviewoutcome
        {
            get => _reviewoutcome;
            set
            {
                _reviewoutcome = value;
                OnPropertyChanged(nameof(Reviewoutcome));
            }
        }        /// <summary>
        /// Adjudication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adjudication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseItemAdjudication>? Adjudication
        {
            get => _adjudication;
            set
            {
                _adjudication = value;
                OnPropertyChanged(nameof(Adjudication));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseItemDetail>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Site
        /// </summary>
        /// <remarks>
        /// <para>
        /// Site 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(Site));
            }
        }        /// <summary>
        /// Subsite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subsite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Subsite
        {
            get => _subsite;
            set
            {
                _subsite = value;
                OnPropertyChanged(nameof(Subsite));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Subdetail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseAddItemDetailSubDetail>? Subdetail
        {
            get => _subdetail;
            set
            {
                _subdetail = value;
                OnPropertyChanged(nameof(Subdetail));
            }
        }        /// <summary>
        /// Itemsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Itemsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Itemsequence
        {
            get => _itemsequence;
            set
            {
                _itemsequence = value;
                OnPropertyChanged(nameof(Itemsequence));
            }
        }        /// <summary>
        /// Detailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Detailsequence
        {
            get => _detailsequence;
            set
            {
                _detailsequence = value;
                OnPropertyChanged(nameof(Detailsequence));
            }
        }        /// <summary>
        /// Subdetailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Subdetailsequence
        {
            get => _subdetailsequence;
            set
            {
                _subdetailsequence = value;
                OnPropertyChanged(nameof(Subdetailsequence));
            }
        }        /// <summary>
        /// Tracenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tracenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Tracenumber
        {
            get => _tracenumber;
            set
            {
                _tracenumber = value;
                OnPropertyChanged(nameof(Tracenumber));
            }
        }        /// <summary>
        /// Provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// Provider 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(Provider));
            }
        }        /// <summary>
        /// Revenue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Revenue 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Revenue
        {
            get => _revenue;
            set
            {
                _revenue = value;
                OnPropertyChanged(nameof(Revenue));
            }
        }        /// <summary>
        /// Productorservice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorservice 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorservice
        {
            get => _productorservice;
            set
            {
                _productorservice = value;
                OnPropertyChanged(nameof(Productorservice));
            }
        }        /// <summary>
        /// Productorserviceend
        /// </summary>
        /// <remarks>
        /// <para>
        /// Productorserviceend 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Productorserviceend
        {
            get => _productorserviceend;
            set
            {
                _productorserviceend = value;
                OnPropertyChanged(nameof(Productorserviceend));
            }
        }        /// <summary>
        /// Request
        /// </summary>
        /// <remarks>
        /// <para>
        /// Request 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }        /// <summary>
        /// Modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(Modifier));
            }
        }        /// <summary>
        /// Programcode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Programcode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Programcode
        {
            get => _programcode;
            set
            {
                _programcode = value;
                OnPropertyChanged(nameof(Programcode));
            }
        }        /// <summary>
        /// Serviced
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviced 的詳細描述。
        /// </para>
        /// </remarks>
        public ClaimResponseAddItemServicedChoice? Serviced
        {
            get => _serviced;
            set
            {
                _serviced = value;
                OnPropertyChanged(nameof(Serviced));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public ClaimResponseAddItemLocationChoice? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }        /// <summary>
        /// Unitprice
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unitprice 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Unitprice
        {
            get => _unitprice;
            set
            {
                _unitprice = value;
                OnPropertyChanged(nameof(Unitprice));
            }
        }        /// <summary>
        /// Factor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Factor 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _factor;
            set
            {
                _factor = value;
                OnPropertyChanged(nameof(Factor));
            }
        }        /// <summary>
        /// Tax
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tax 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Tax
        {
            get => _tax;
            set
            {
                _tax = value;
                OnPropertyChanged(nameof(Tax));
            }
        }        /// <summary>
        /// Net
        /// </summary>
        /// <remarks>
        /// <para>
        /// Net 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Net
        {
            get => _net;
            set
            {
                _net = value;
                OnPropertyChanged(nameof(Net));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseAddItemBodySite>? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Notenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Notenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirPositiveInt>? Notenumber
        {
            get => _notenumber;
            set
            {
                _notenumber = value;
                OnPropertyChanged(nameof(Notenumber));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ClaimResponseAddItemDetail>? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
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
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Adjustment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adjustment 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Adjustment
        {
            get => _adjustment;
            set
            {
                _adjustment = value;
                OnPropertyChanged(nameof(Adjustment));
            }
        }        /// <summary>
        /// Adjustmentreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adjustmentreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Adjustmentreason
        {
            get => _adjustmentreason;
            set
            {
                _adjustmentreason = value;
                OnPropertyChanged(nameof(Adjustmentreason));
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
        /// Number
        /// </summary>
        /// <remarks>
        /// <para>
        /// Number 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
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
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Focal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Focal 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Focal
        {
            get => _focal;
            set
            {
                _focal = value;
                OnPropertyChanged(nameof(Focal));
            }
        }        /// <summary>
        /// Coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(Coverage));
            }
        }        /// <summary>
        /// Businessarrangement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Businessarrangement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Businessarrangement
        {
            get => _businessarrangement;
            set
            {
                _businessarrangement = value;
                OnPropertyChanged(nameof(Businessarrangement));
            }
        }        /// <summary>
        /// Claimresponse
        /// </summary>
        /// <remarks>
        /// <para>
        /// Claimresponse 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Claimresponse
        {
            get => _claimresponse;
            set
            {
                _claimresponse = value;
                OnPropertyChanged(nameof(Claimresponse));
            }
        }        /// <summary>
        /// Itemsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Itemsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Itemsequence
        {
            get => _itemsequence;
            set
            {
                _itemsequence = value;
                OnPropertyChanged(nameof(Itemsequence));
            }
        }        /// <summary>
        /// Detailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Detailsequence
        {
            get => _detailsequence;
            set
            {
                _detailsequence = value;
                OnPropertyChanged(nameof(Detailsequence));
            }
        }        /// <summary>
        /// Subdetailsequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subdetailsequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? Subdetailsequence
        {
            get => _subdetailsequence;
            set
            {
                _subdetailsequence = value;
                OnPropertyChanged(nameof(Subdetailsequence));
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
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// 建立新的 ClaimResponse 資源實例
        /// </summary>
        public ClaimResponse()
        {
        }

        /// <summary>
        /// 建立新的 ClaimResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ClaimResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ClaimResponse(Id: {Id})";
        }
    }    /// <summary>
    /// ClaimResponseEvent 背骨元素
    /// </summary>
    public class ClaimResponseEvent
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseEvent() { }
    }    /// <summary>
    /// ClaimResponseItemReviewOutcome 背骨元素
    /// </summary>
    public class ClaimResponseItemReviewOutcome
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseItemReviewOutcome() { }
    }    /// <summary>
    /// ClaimResponseItemAdjudication 背骨元素
    /// </summary>
    public class ClaimResponseItemAdjudication
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseItemAdjudication() { }
    }    /// <summary>
    /// ClaimResponseItemDetailSubDetail 背骨元素
    /// </summary>
    public class ClaimResponseItemDetailSubDetail
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseItemDetailSubDetail() { }
    }    /// <summary>
    /// ClaimResponseItemDetail 背骨元素
    /// </summary>
    public class ClaimResponseItemDetail
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseItemDetail() { }
    }    /// <summary>
    /// ClaimResponseItem 背骨元素
    /// </summary>
    public class ClaimResponseItem
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseItem() { }
    }    /// <summary>
    /// ClaimResponseAddItemBodySite 背骨元素
    /// </summary>
    public class ClaimResponseAddItemBodySite
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseAddItemBodySite() { }
    }    /// <summary>
    /// ClaimResponseAddItemDetailSubDetail 背骨元素
    /// </summary>
    public class ClaimResponseAddItemDetailSubDetail
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseAddItemDetailSubDetail() { }
    }    /// <summary>
    /// ClaimResponseAddItemDetail 背骨元素
    /// </summary>
    public class ClaimResponseAddItemDetail
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseAddItemDetail() { }
    }    /// <summary>
    /// ClaimResponseAddItem 背骨元素
    /// </summary>
    public class ClaimResponseAddItem
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseAddItem() { }
    }    /// <summary>
    /// ClaimResponseTotal 背骨元素
    /// </summary>
    public class ClaimResponseTotal
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseTotal() { }
    }    /// <summary>
    /// ClaimResponsePayment 背骨元素
    /// </summary>
    public class ClaimResponsePayment
    {
        // TODO: 添加屬性實作
        
        public ClaimResponsePayment() { }
    }    /// <summary>
    /// ClaimResponseProcessNote 背骨元素
    /// </summary>
    public class ClaimResponseProcessNote
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseProcessNote() { }
    }    /// <summary>
    /// ClaimResponseInsurance 背骨元素
    /// </summary>
    public class ClaimResponseInsurance
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseInsurance() { }
    }    /// <summary>
    /// ClaimResponseError 背骨元素
    /// </summary>
    public class ClaimResponseError
    {
        // TODO: 添加屬性實作
        
        public ClaimResponseError() { }
    }    /// <summary>
    /// ClaimResponseEventWhenChoice 選擇類型
    /// </summary>
    public class ClaimResponseEventWhenChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimResponseEventWhenChoice(JsonObject value) : base("claimresponseeventwhen", value, _supportType) { }
        public ClaimResponseEventWhenChoice(IComplexType? value) : base("claimresponseeventwhen", value) { }
        public ClaimResponseEventWhenChoice(IPrimitiveType? value) : base("claimresponseeventwhen", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimResponseEventWhen" : "claimresponseeventwhen";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimResponseAddItemServicedChoice 選擇類型
    /// </summary>
    public class ClaimResponseAddItemServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimResponseAddItemServicedChoice(JsonObject value) : base("claimresponseadditemserviced", value, _supportType) { }
        public ClaimResponseAddItemServicedChoice(IComplexType? value) : base("claimresponseadditemserviced", value) { }
        public ClaimResponseAddItemServicedChoice(IPrimitiveType? value) : base("claimresponseadditemserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimResponseAddItemServiced" : "claimresponseadditemserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ClaimResponseAddItemLocationChoice 選擇類型
    /// </summary>
    public class ClaimResponseAddItemLocationChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ClaimResponseAddItemLocationChoice(JsonObject value) : base("claimresponseadditemlocation", value, _supportType) { }
        public ClaimResponseAddItemLocationChoice(IComplexType? value) : base("claimresponseadditemlocation", value) { }
        public ClaimResponseAddItemLocationChoice(IPrimitiveType? value) : base("claimresponseadditemlocation", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ClaimResponseAddItemLocation" : "claimresponseadditemlocation";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
