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
    /// FHIR R5 Invoice 資源
    /// 
    /// <para>
    /// Invoice 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var invoice = new Invoice("invoice-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Invoice 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Invoice : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirString? _cancelledreason;
        private CodeableConcept? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _recipient;
        private FhirDateTime? _date;
        private FhirDateTime? _creation;
        private InvoicePeriodChoice? _period;
        private List<InvoiceParticipant>? _participant;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _issuer;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _account;
        private List<InvoiceLineItem>? _lineitem;
        private List<MonetaryComponent>? _totalpricecomponent;
        private Money? _totalnet;
        private Money? _totalgross;
        private FhirMarkdown? _paymentterms;
        private List<Annotation>? _note;
        private CodeableConcept? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private FhirPositiveInt? _sequence;
        private InvoiceLineItemServicedChoice? _serviced;
        private InvoiceLineItemChargeItemChoice? _chargeitem;
        private List<MonetaryComponent>? _pricecomponent;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Invoice";        /// <summary>
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
        /// Cancelledreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cancelledreason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Cancelledreason
        {
            get => _cancelledreason;
            set
            {
                _cancelledreason = value;
                OnPropertyChanged(nameof(Cancelledreason));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Recipient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recipient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Recipient
        {
            get => _recipient;
            set
            {
                _recipient = value;
                OnPropertyChanged(nameof(Recipient));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Creation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Creation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Creation
        {
            get => _creation;
            set
            {
                _creation = value;
                OnPropertyChanged(nameof(Creation));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public InvoicePeriodChoice? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InvoiceParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }        /// <summary>
        /// Issuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issuer 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
                OnPropertyChanged(nameof(Issuer));
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
        /// Lineitem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lineitem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<InvoiceLineItem>? Lineitem
        {
            get => _lineitem;
            set
            {
                _lineitem = value;
                OnPropertyChanged(nameof(Lineitem));
            }
        }        /// <summary>
        /// Totalpricecomponent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Totalpricecomponent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MonetaryComponent>? Totalpricecomponent
        {
            get => _totalpricecomponent;
            set
            {
                _totalpricecomponent = value;
                OnPropertyChanged(nameof(Totalpricecomponent));
            }
        }        /// <summary>
        /// Totalnet
        /// </summary>
        /// <remarks>
        /// <para>
        /// Totalnet 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Totalnet
        {
            get => _totalnet;
            set
            {
                _totalnet = value;
                OnPropertyChanged(nameof(Totalnet));
            }
        }        /// <summary>
        /// Totalgross
        /// </summary>
        /// <remarks>
        /// <para>
        /// Totalgross 的詳細描述。
        /// </para>
        /// </remarks>
        public Money? Totalgross
        {
            get => _totalgross;
            set
            {
                _totalgross = value;
                OnPropertyChanged(nameof(Totalgross));
            }
        }        /// <summary>
        /// Paymentterms
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentterms 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Paymentterms
        {
            get => _paymentterms;
            set
            {
                _paymentterms = value;
                OnPropertyChanged(nameof(Paymentterms));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
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
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
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
        /// Serviced
        /// </summary>
        /// <remarks>
        /// <para>
        /// Serviced 的詳細描述。
        /// </para>
        /// </remarks>
        public InvoiceLineItemServicedChoice? Serviced
        {
            get => _serviced;
            set
            {
                _serviced = value;
                OnPropertyChanged(nameof(Serviced));
            }
        }        /// <summary>
        /// Chargeitem
        /// </summary>
        /// <remarks>
        /// <para>
        /// Chargeitem 的詳細描述。
        /// </para>
        /// </remarks>
        public InvoiceLineItemChargeItemChoice? Chargeitem
        {
            get => _chargeitem;
            set
            {
                _chargeitem = value;
                OnPropertyChanged(nameof(Chargeitem));
            }
        }        /// <summary>
        /// Pricecomponent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Pricecomponent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MonetaryComponent>? Pricecomponent
        {
            get => _pricecomponent;
            set
            {
                _pricecomponent = value;
                OnPropertyChanged(nameof(Pricecomponent));
            }
        }        /// <summary>
        /// 建立新的 Invoice 資源實例
        /// </summary>
        public Invoice()
        {
        }

        /// <summary>
        /// 建立新的 Invoice 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Invoice(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Invoice(Id: {Id})";
        }
    }    /// <summary>
    /// InvoiceParticipant 背骨元素
    /// </summary>
    public class InvoiceParticipant
    {
        // TODO: 添加屬性實作
        
        public InvoiceParticipant() { }
    }    /// <summary>
    /// InvoiceLineItem 背骨元素
    /// </summary>
    public class InvoiceLineItem
    {
        // TODO: 添加屬性實作
        
        public InvoiceLineItem() { }
    }    /// <summary>
    /// InvoicePeriodChoice 選擇類型
    /// </summary>
    public class InvoicePeriodChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public InvoicePeriodChoice(JsonObject value) : base("invoiceperiod", value, _supportType) { }
        public InvoicePeriodChoice(IComplexType? value) : base("invoiceperiod", value) { }
        public InvoicePeriodChoice(IPrimitiveType? value) : base("invoiceperiod", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "InvoicePeriod" : "invoiceperiod";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// InvoiceLineItemServicedChoice 選擇類型
    /// </summary>
    public class InvoiceLineItemServicedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public InvoiceLineItemServicedChoice(JsonObject value) : base("invoicelineitemserviced", value, _supportType) { }
        public InvoiceLineItemServicedChoice(IComplexType? value) : base("invoicelineitemserviced", value) { }
        public InvoiceLineItemServicedChoice(IPrimitiveType? value) : base("invoicelineitemserviced", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "InvoiceLineItemServiced" : "invoicelineitemserviced";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// InvoiceLineItemChargeItemChoice 選擇類型
    /// </summary>
    public class InvoiceLineItemChargeItemChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public InvoiceLineItemChargeItemChoice(JsonObject value) : base("invoicelineitemchargeitem", value, _supportType) { }
        public InvoiceLineItemChargeItemChoice(IComplexType? value) : base("invoicelineitemchargeitem", value) { }
        public InvoiceLineItemChargeItemChoice(IPrimitiveType? value) : base("invoicelineitemchargeitem", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "InvoiceLineItemChargeItem" : "invoicelineitemchargeitem";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
