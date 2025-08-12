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
    /// FHIR R4 Consent 資源
    /// 
    /// <para>
    /// A record of a healthcare consumer’s  choices, which permits or denies identified recipient(s) or recipient role(s) to perform one or more actions within a given policy context, for specific purposes and periods of time.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var consent = new Consent("consent-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Consent 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Consent : ResourceBase<R4Version>
    {
        private List<CodeableConcept>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
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

        private FhirDateTime? _datetime;

        /// <summary>
        /// dateTime
        /// </summary>
        /// <remarks>
        /// <para>
        /// dateTime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? dateTime
        {
            get => _datetime;
            set
            {
                _datetime = value;
                OnPropertyChanged(nameof(dateTime));
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

        private List<ReferenceType>? _organization;

        /// <summary>
        /// organization
        /// </summary>
        /// <remarks>
        /// <para>
        /// organization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? organization
        {
            get => _organization;
            set
            {
                _organization = value;
                OnPropertyChanged(nameof(organization));
            }
        }

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private List<ReferenceType>? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private List<BackboneElement>? _policy;

        /// <summary>
        /// policy
        /// </summary>
        /// <remarks>
        /// <para>
        /// policy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? policy
        {
            get => _policy;
            set
            {
                _policy = value;
                OnPropertyChanged(nameof(policy));
            }
        }

        private CodeableConcept? _policyrule;

        /// <summary>
        /// policyRule
        /// </summary>
        /// <remarks>
        /// <para>
        /// policyRule 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? policyRule
        {
            get => _policyrule;
            set
            {
                _policyrule = value;
                OnPropertyChanged(nameof(policyRule));
            }
        }

        private BackboneElement? _provision;

        /// <summary>
        /// provision
        /// </summary>
        /// <remarks>
        /// <para>
        /// provision 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? provision
        {
            get => _provision;
            set
            {
                _provision = value;
                OnPropertyChanged(nameof(provision));
            }
        }

        private CodeableConcept? _scope;

        /// <summary>
        /// scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// scope 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(scope));
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

        private List<BackboneElement>? _verification;

        /// <summary>
        /// verification
        /// </summary>
        /// <remarks>
        /// <para>
        /// verification 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? verification
        {
            get => _verification;
            set
            {
                _verification = value;
                OnPropertyChanged(nameof(verification));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Consent";

        /// <summary>
        /// 建立新的 Consent 資源實例
        /// </summary>
        public Consent()
        {
        }

        /// <summary>
        /// 建立新的 Consent 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Consent(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Consent(Id: {Id})";
        }
    }
}
