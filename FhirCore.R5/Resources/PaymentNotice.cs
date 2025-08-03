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
    /// FHIR R5 PaymentNotice 資源
    /// 
    /// <para>
    /// PaymentNotice 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var paymentnotice = new PaymentNotice("paymentnotice-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 PaymentNotice 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PaymentNotice : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _request;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _response;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reporter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _payment;
        private FhirDate? _paymentdate;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _payee;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _recipient;
        private Money? _amount;
        private CodeableConcept? _paymentstatus;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PaymentNotice";        /// <summary>
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
        /// Reporter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reporter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reporter
        {
            get => _reporter;
            set
            {
                _reporter = value;
                OnPropertyChanged(nameof(Reporter));
            }
        }        /// <summary>
        /// Payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Payment 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }        /// <summary>
        /// Paymentdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Paymentdate
        {
            get => _paymentdate;
            set
            {
                _paymentdate = value;
                OnPropertyChanged(nameof(Paymentdate));
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
        /// Paymentstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Paymentstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Paymentstatus
        {
            get => _paymentstatus;
            set
            {
                _paymentstatus = value;
                OnPropertyChanged(nameof(Paymentstatus));
            }
        }        /// <summary>
        /// 建立新的 PaymentNotice 資源實例
        /// </summary>
        public PaymentNotice()
        {
        }

        /// <summary>
        /// 建立新的 PaymentNotice 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public PaymentNotice(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"PaymentNotice(Id: {Id})";
        }
    }
}
