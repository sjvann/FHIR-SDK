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
    /// FHIR R4 PaymentReconciliation 資源
    /// 
    /// <para>
    /// This resource provides the details including amount of a payment and allocates the payment items being paid.
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
    /// R4 版本的 PaymentReconciliation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class PaymentReconciliation : ResourceBase<R4Version>
    {
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

        private List<BackboneElement>? _detail;

        /// <summary>
        /// detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// detail 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(detail));
            }
        }

        private FhirString? _disposition;

        /// <summary>
        /// disposition
        /// </summary>
        /// <remarks>
        /// <para>
        /// disposition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? disposition
        {
            get => _disposition;
            set
            {
                _disposition = value;
                OnPropertyChanged(nameof(disposition));
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

        private CodeableConcept? _formcode;

        /// <summary>
        /// formCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// formCode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? formCode
        {
            get => _formcode;
            set
            {
                _formcode = value;
                OnPropertyChanged(nameof(formCode));
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

        private FhirCode? _outcome;

        /// <summary>
        /// outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(outcome));
            }
        }

        private FhirString? _paymentamount;

        /// <summary>
        /// paymentAmount
        /// </summary>
        /// <remarks>
        /// <para>
        /// paymentAmount 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? paymentAmount
        {
            get => _paymentamount;
            set
            {
                _paymentamount = value;
                OnPropertyChanged(nameof(paymentAmount));
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

        private Identifier? _paymentidentifier;

        /// <summary>
        /// paymentIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// paymentIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? paymentIdentifier
        {
            get => _paymentidentifier;
            set
            {
                _paymentidentifier = value;
                OnPropertyChanged(nameof(paymentIdentifier));
            }
        }

        private ReferenceType? _paymentissuer;

        /// <summary>
        /// paymentIssuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// paymentIssuer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? paymentIssuer
        {
            get => _paymentissuer;
            set
            {
                _paymentissuer = value;
                OnPropertyChanged(nameof(paymentIssuer));
            }
        }

        private Period? _period;

        /// <summary>
        /// period
        /// </summary>
        /// <remarks>
        /// <para>
        /// period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(period));
            }
        }

        private List<BackboneElement>? _processnote;

        /// <summary>
        /// processNote
        /// </summary>
        /// <remarks>
        /// <para>
        /// processNote 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? processNote
        {
            get => _processnote;
            set
            {
                _processnote = value;
                OnPropertyChanged(nameof(processNote));
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

        private ReferenceType? _requestor;

        /// <summary>
        /// requestor
        /// </summary>
        /// <remarks>
        /// <para>
        /// requestor 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? requestor
        {
            get => _requestor;
            set
            {
                _requestor = value;
                OnPropertyChanged(nameof(requestor));
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
        public override string ResourceType => "PaymentReconciliation";

        /// <summary>
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
    }
}
