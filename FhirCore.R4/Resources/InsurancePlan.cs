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
    /// FHIR R4 InsurancePlan 資源
    /// 
    /// <para>
    /// Details of a Health Insurance product/plan provided by an organization.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var insuranceplan = new InsurancePlan("insuranceplan-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 InsurancePlan 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class InsurancePlan : ResourceBase<R4Version>
    {
        private ReferenceType? _administeredby;

        /// <summary>
        /// administeredBy
        /// </summary>
        /// <remarks>
        /// <para>
        /// administeredBy 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? administeredBy
        {
            get => _administeredby;
            set
            {
                _administeredby = value;
                OnPropertyChanged(nameof(administeredBy));
            }
        }

        private List<FhirString>? _alias;

        /// <summary>
        /// alias
        /// </summary>
        /// <remarks>
        /// <para>
        /// alias 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? alias
        {
            get => _alias;
            set
            {
                _alias = value;
                OnPropertyChanged(nameof(alias));
            }
        }

        private List<BackboneElement>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(contact));
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

        private List<BackboneElement>? _coverage;

        /// <summary>
        /// coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(coverage));
            }
        }

        private List<ReferenceType>? _coveragearea;

        /// <summary>
        /// coverageArea
        /// </summary>
        /// <remarks>
        /// <para>
        /// coverageArea 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? coverageArea
        {
            get => _coveragearea;
            set
            {
                _coveragearea = value;
                OnPropertyChanged(nameof(coverageArea));
            }
        }

        private List<ReferenceType>? _endpoint;

        /// <summary>
        /// endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(endpoint));
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

        private FhirString? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
            }
        }

        private List<ReferenceType>? _network;

        /// <summary>
        /// network
        /// </summary>
        /// <remarks>
        /// <para>
        /// network 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? network
        {
            get => _network;
            set
            {
                _network = value;
                OnPropertyChanged(nameof(network));
            }
        }

        private ReferenceType? _ownedby;

        /// <summary>
        /// ownedBy
        /// </summary>
        /// <remarks>
        /// <para>
        /// ownedBy 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? ownedBy
        {
            get => _ownedby;
            set
            {
                _ownedby = value;
                OnPropertyChanged(nameof(ownedBy));
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

        private List<BackboneElement>? _plan;

        /// <summary>
        /// plan
        /// </summary>
        /// <remarks>
        /// <para>
        /// plan 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? plan
        {
            get => _plan;
            set
            {
                _plan = value;
                OnPropertyChanged(nameof(plan));
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

        private List<CodeableConcept>? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? type
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
        public override string ResourceType => "InsurancePlan";

        /// <summary>
        /// 建立新的 InsurancePlan 資源實例
        /// </summary>
        public InsurancePlan()
        {
        }

        /// <summary>
        /// 建立新的 InsurancePlan 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public InsurancePlan(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"InsurancePlan(Id: {Id})";
        }
    }
}
