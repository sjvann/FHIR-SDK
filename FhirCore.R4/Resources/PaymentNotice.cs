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
    /// FHIR R4 PaymentNotice 資源
    /// 
    /// <para>
    /// This resource provides the status of the payment for goods and services rendered, and the request and response resource references.
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
    /// R4 版本的 PaymentNotice 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PaymentNotice : ResourceBase<R4Version>
    {
        private FhirString? _amount;

        /// <summary>
        /// amount
        /// </summary>
        /// <remarks>
        /// <para>
        /// amount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(amount));
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

        private FhirDateTime? _created;

        /// <summary>
        /// created
        /// </summary>
        /// <remarks>
        /// <para>
        /// created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(created));
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

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
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

        private ReferenceType? _payee;

        /// <summary>
        /// payee
        /// </summary>
        /// <remarks>
        /// <para>
        /// payee 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? payee
        {
            get => _payee;
            set
            {
                _payee = value;
                OnPropertyChanged(nameof(payee));
            }
        }

        private ReferenceType? _payment;

        /// <summary>
        /// payment
        /// </summary>
        /// <remarks>
        /// <para>
        /// payment 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(payment));
            }
        }

        private FhirDate? _paymentdate;

        /// <summary>
        /// paymentDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// paymentDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? paymentDate
        {
            get => _paymentdate;
            set
            {
                _paymentdate = value;
                OnPropertyChanged(nameof(paymentDate));
            }
        }

        private CodeableConcept? _paymentstatus;

        /// <summary>
        /// paymentStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// paymentStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? paymentStatus
        {
            get => _paymentstatus;
            set
            {
                _paymentstatus = value;
                OnPropertyChanged(nameof(paymentStatus));
            }
        }

        private ReferenceType? _provider;

        /// <summary>
        /// provider
        /// </summary>
        /// <remarks>
        /// <para>
        /// provider 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? provider
        {
            get => _provider;
            set
            {
                _provider = value;
                OnPropertyChanged(nameof(provider));
            }
        }

        private ReferenceType? _recipient;

        /// <summary>
        /// recipient
        /// </summary>
        /// <remarks>
        /// <para>
        /// recipient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? recipient
        {
            get => _recipient;
            set
            {
                _recipient = value;
                OnPropertyChanged(nameof(recipient));
            }
        }

        private ReferenceType? _request;

        /// <summary>
        /// request
        /// </summary>
        /// <remarks>
        /// <para>
        /// request 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? request
        {
            get => _request;
            set
            {
                _request = value;
                OnPropertyChanged(nameof(request));
            }
        }

        private ReferenceType? _response;

        /// <summary>
        /// response
        /// </summary>
        /// <remarks>
        /// <para>
        /// response 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? response
        {
            get => _response;
            set
            {
                _response = value;
                OnPropertyChanged(nameof(response));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "PaymentNotice";

        /// <summary>
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
