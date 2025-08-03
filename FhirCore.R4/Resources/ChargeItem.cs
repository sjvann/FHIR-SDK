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
    /// FHIR R4 ChargeItem 資源
    /// 
    /// <para>
    /// The resource ChargeItem describes the provision of healthcare provider products for a certain patient, therefore referring not only to the product, but containing in addition details of the provision, like date, time, amounts and participating organizations and persons. Main Usage of the ChargeItem is to enable the billing process and internal cost allocation.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var chargeitem = new ChargeItem("chargeitem-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ChargeItem 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ChargeItem : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _account;

        /// <summary>
        /// account
        /// </summary>
        /// <remarks>
        /// <para>
        /// account 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(account));
            }
        }

        private List<CodeableConcept>? _bodysite;

        /// <summary>
        /// bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(bodysite));
            }
        }

        private CodeableConcept? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
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

        private ReferenceType? _context;

        /// <summary>
        /// context
        /// </summary>
        /// <remarks>
        /// <para>
        /// context 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(context));
            }
        }

        private ReferenceType? _costcenter;

        /// <summary>
        /// costCenter
        /// </summary>
        /// <remarks>
        /// <para>
        /// costCenter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? costCenter
        {
            get => _costcenter;
            set
            {
                _costcenter = value;
                OnPropertyChanged(nameof(costCenter));
            }
        }

        private List<FhirCanonical>? _definitioncanonical;

        /// <summary>
        /// definitionCanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// definitionCanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? definitionCanonical
        {
            get => _definitioncanonical;
            set
            {
                _definitioncanonical = value;
                OnPropertyChanged(nameof(definitionCanonical));
            }
        }

        private List<FhirUri>? _definitionuri;

        /// <summary>
        /// definitionUri
        /// </summary>
        /// <remarks>
        /// <para>
        /// definitionUri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? definitionUri
        {
            get => _definitionuri;
            set
            {
                _definitionuri = value;
                OnPropertyChanged(nameof(definitionUri));
            }
        }

        private FhirDateTime? _entereddate;

        /// <summary>
        /// enteredDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// enteredDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? enteredDate
        {
            get => _entereddate;
            set
            {
                _entereddate = value;
                OnPropertyChanged(nameof(enteredDate));
            }
        }

        private ReferenceType? _enterer;

        /// <summary>
        /// enterer
        /// </summary>
        /// <remarks>
        /// <para>
        /// enterer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? enterer
        {
            get => _enterer;
            set
            {
                _enterer = value;
                OnPropertyChanged(nameof(enterer));
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

        private FhirDecimal? _factoroverride;

        /// <summary>
        /// factorOverride
        /// </summary>
        /// <remarks>
        /// <para>
        /// factorOverride 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? factorOverride
        {
            get => _factoroverride;
            set
            {
                _factoroverride = value;
                OnPropertyChanged(nameof(factorOverride));
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

        private FhirString? _overridereason;

        /// <summary>
        /// overrideReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// overrideReason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? overrideReason
        {
            get => _overridereason;
            set
            {
                _overridereason = value;
                OnPropertyChanged(nameof(overrideReason));
            }
        }

        private List<ReferenceType>? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
            }
        }

        private List<BackboneElement>? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private ReferenceType? _performingorganization;

        /// <summary>
        /// performingOrganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// performingOrganization 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? performingOrganization
        {
            get => _performingorganization;
            set
            {
                _performingorganization = value;
                OnPropertyChanged(nameof(performingOrganization));
            }
        }

        private FhirString? _priceoverride;

        /// <summary>
        /// priceOverride
        /// </summary>
        /// <remarks>
        /// <para>
        /// priceOverride 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? priceOverride
        {
            get => _priceoverride;
            set
            {
                _priceoverride = value;
                OnPropertyChanged(nameof(priceOverride));
            }
        }

        private Quantity? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
            }
        }

        private List<CodeableConcept>? _reason;

        /// <summary>
        /// reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(reason));
            }
        }

        private ReferenceType? _requestingorganization;

        /// <summary>
        /// requestingOrganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// requestingOrganization 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? requestingOrganization
        {
            get => _requestingorganization;
            set
            {
                _requestingorganization = value;
                OnPropertyChanged(nameof(requestingOrganization));
            }
        }

        private List<ReferenceType>? _service;

        /// <summary>
        /// service
        /// </summary>
        /// <remarks>
        /// <para>
        /// service 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? service
        {
            get => _service;
            set
            {
                _service = value;
                OnPropertyChanged(nameof(service));
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

        private List<ReferenceType>? _supportinginformation;

        /// <summary>
        /// supportingInformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// supportingInformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? supportingInformation
        {
            get => _supportinginformation;
            set
            {
                _supportinginformation = value;
                OnPropertyChanged(nameof(supportingInformation));
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
        public override string ResourceType => "ChargeItem";

        /// <summary>
        /// 建立新的 ChargeItem 資源實例
        /// </summary>
        public ChargeItem()
        {
        }

        /// <summary>
        /// 建立新的 ChargeItem 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ChargeItem(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ChargeItem(Id: {Id})";
        }
    }
}
