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
    /// FHIR R4 Invoice 資源
    /// 
    /// <para>
    /// Invoice containing collected ChargeItems from an Account with calculated individual and total price for Billing purpose.
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
    /// R4 版本的 Invoice 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Invoice : ResourceBase<R4Version>
    {
        private ReferenceType? _account;

        /// <summary>
        /// account
        /// </summary>
        /// <remarks>
        /// <para>
        /// account 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(account));
            }
        }

        private FhirString? _cancelledreason;

        /// <summary>
        /// cancelledReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// cancelledReason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? cancelledReason
        {
            get => _cancelledreason;
            set
            {
                _cancelledreason = value;
                OnPropertyChanged(nameof(cancelledReason));
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

        private FhirDateTime? _date;

        /// <summary>
        /// date
        /// </summary>
        /// <remarks>
        /// <para>
        /// date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(date));
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

        private ReferenceType? _issuer;

        /// <summary>
        /// issuer
        /// </summary>
        /// <remarks>
        /// <para>
        /// issuer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? issuer
        {
            get => _issuer;
            set
            {
                _issuer = value;
                OnPropertyChanged(nameof(issuer));
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

        private List<BackboneElement>? _lineitem;

        /// <summary>
        /// lineItem
        /// </summary>
        /// <remarks>
        /// <para>
        /// lineItem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? lineItem
        {
            get => _lineitem;
            set
            {
                _lineitem = value;
                OnPropertyChanged(nameof(lineItem));
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

        private List<Annotation>? _note;

        /// <summary>
        /// note
        /// </summary>
        /// <remarks>
        /// <para>
        /// note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(note));
            }
        }

        private List<BackboneElement>? _participant;

        /// <summary>
        /// participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(participant));
            }
        }

        private FhirMarkdown? _paymentterms;

        /// <summary>
        /// paymentTerms
        /// </summary>
        /// <remarks>
        /// <para>
        /// paymentTerms 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? paymentTerms
        {
            get => _paymentterms;
            set
            {
                _paymentterms = value;
                OnPropertyChanged(nameof(paymentTerms));
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

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
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

        private FhirString? _totalgross;

        /// <summary>
        /// totalGross
        /// </summary>
        /// <remarks>
        /// <para>
        /// totalGross 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? totalGross
        {
            get => _totalgross;
            set
            {
                _totalgross = value;
                OnPropertyChanged(nameof(totalGross));
            }
        }

        private FhirString? _totalnet;

        /// <summary>
        /// totalNet
        /// </summary>
        /// <remarks>
        /// <para>
        /// totalNet 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? totalNet
        {
            get => _totalnet;
            set
            {
                _totalnet = value;
                OnPropertyChanged(nameof(totalNet));
            }
        }

        private List<FhirString>? _totalpricecomponent;

        /// <summary>
        /// totalPriceComponent
        /// </summary>
        /// <remarks>
        /// <para>
        /// totalPriceComponent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? totalPriceComponent
        {
            get => _totalpricecomponent;
            set
            {
                _totalpricecomponent = value;
                OnPropertyChanged(nameof(totalPriceComponent));
            }
        }

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Invoice";

        /// <summary>
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
    }
}
