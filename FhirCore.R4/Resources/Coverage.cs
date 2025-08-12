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
    /// FHIR R4 Coverage 資源
    /// 
    /// <para>
    /// Financial instrument which may be used to reimburse or pay for health care products and services. Includes both insurance and self-payment.
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
    /// R4 版本的 Coverage 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Coverage : ResourceBase<R4Version>
    {
        private ReferenceType? _beneficiary;

        /// <summary>
        /// beneficiary
        /// </summary>
        /// <remarks>
        /// <para>
        /// beneficiary 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? beneficiary
        {
            get => _beneficiary;
            set
            {
                _beneficiary = value;
                OnPropertyChanged(nameof(beneficiary));
            }
        }

        private List<BackboneElement>? _class;

        /// <summary>
        /// class
        /// </summary>
        /// <remarks>
        /// <para>
        /// class 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(class));
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

        private List<ReferenceType>? _contract;

        /// <summary>
        /// contract
        /// </summary>
        /// <remarks>
        /// <para>
        /// contract 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? contract
        {
            get => _contract;
            set
            {
                _contract = value;
                OnPropertyChanged(nameof(contract));
            }
        }

        private List<BackboneElement>? _costtobeneficiary;

        /// <summary>
        /// costToBeneficiary
        /// </summary>
        /// <remarks>
        /// <para>
        /// costToBeneficiary 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? costToBeneficiary
        {
            get => _costtobeneficiary;
            set
            {
                _costtobeneficiary = value;
                OnPropertyChanged(nameof(costToBeneficiary));
            }
        }

        private FhirString? _dependent;

        /// <summary>
        /// dependent
        /// </summary>
        /// <remarks>
        /// <para>
        /// dependent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? dependent
        {
            get => _dependent;
            set
            {
                _dependent = value;
                OnPropertyChanged(nameof(dependent));
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

        private FhirString? _network;

        /// <summary>
        /// network
        /// </summary>
        /// <remarks>
        /// <para>
        /// network 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(network));
            }
        }

        private FhirPositiveInt? _order;

        /// <summary>
        /// order
        /// </summary>
        /// <remarks>
        /// <para>
        /// order 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirPositiveInt? order
        {
            get => _order;
            set
            {
                _order = value;
                OnPropertyChanged(nameof(order));
            }
        }

        private List<ReferenceType>? _payor;

        /// <summary>
        /// payor
        /// </summary>
        /// <remarks>
        /// <para>
        /// payor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? payor
        {
            get => _payor;
            set
            {
                _payor = value;
                OnPropertyChanged(nameof(payor));
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

        private ReferenceType? _policyholder;

        /// <summary>
        /// policyHolder
        /// </summary>
        /// <remarks>
        /// <para>
        /// policyHolder 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? policyHolder
        {
            get => _policyholder;
            set
            {
                _policyholder = value;
                OnPropertyChanged(nameof(policyHolder));
            }
        }

        private CodeableConcept? _relationship;

        /// <summary>
        /// relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(relationship));
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

        private FhirBoolean? _subrogation;

        /// <summary>
        /// subrogation
        /// </summary>
        /// <remarks>
        /// <para>
        /// subrogation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? subrogation
        {
            get => _subrogation;
            set
            {
                _subrogation = value;
                OnPropertyChanged(nameof(subrogation));
            }
        }

        private ReferenceType? _subscriber;

        /// <summary>
        /// subscriber
        /// </summary>
        /// <remarks>
        /// <para>
        /// subscriber 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subscriber
        {
            get => _subscriber;
            set
            {
                _subscriber = value;
                OnPropertyChanged(nameof(subscriber));
            }
        }

        private FhirString? _subscriberid;

        /// <summary>
        /// subscriberId
        /// </summary>
        /// <remarks>
        /// <para>
        /// subscriberId 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? subscriberId
        {
            get => _subscriberid;
            set
            {
                _subscriberid = value;
                OnPropertyChanged(nameof(subscriberId));
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
        public override string ResourceType => "Coverage";

        /// <summary>
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
    }
}
