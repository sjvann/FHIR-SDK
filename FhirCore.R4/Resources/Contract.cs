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
    /// FHIR R4 Contract 資源
    /// 
    /// <para>
    /// Legally enforceable, formally recorded unilateral or bilateral directive i.e., a policy or agreement.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var contract = new Contract("contract-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Contract 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Contract : ResourceBase<R4Version>
    {
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

        private Period? _applies;

        /// <summary>
        /// applies
        /// </summary>
        /// <remarks>
        /// <para>
        /// applies 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? applies
        {
            get => _applies;
            set
            {
                _applies = value;
                OnPropertyChanged(nameof(applies));
            }
        }

        private ReferenceType? _author;

        /// <summary>
        /// author
        /// </summary>
        /// <remarks>
        /// <para>
        /// author 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(author));
            }
        }

        private List<ReferenceType>? _authority;

        /// <summary>
        /// authority
        /// </summary>
        /// <remarks>
        /// <para>
        /// authority 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? authority
        {
            get => _authority;
            set
            {
                _authority = value;
                OnPropertyChanged(nameof(authority));
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

        private BackboneElement? _contentdefinition;

        /// <summary>
        /// contentDefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// contentDefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? contentDefinition
        {
            get => _contentdefinition;
            set
            {
                _contentdefinition = value;
                OnPropertyChanged(nameof(contentDefinition));
            }
        }

        private CodeableConcept? _contentderivative;

        /// <summary>
        /// contentDerivative
        /// </summary>
        /// <remarks>
        /// <para>
        /// contentDerivative 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? contentDerivative
        {
            get => _contentderivative;
            set
            {
                _contentderivative = value;
                OnPropertyChanged(nameof(contentDerivative));
            }
        }

        private List<ReferenceType>? _domain;

        /// <summary>
        /// domain
        /// </summary>
        /// <remarks>
        /// <para>
        /// domain 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? domain
        {
            get => _domain;
            set
            {
                _domain = value;
                OnPropertyChanged(nameof(domain));
            }
        }

        private CodeableConcept? _expirationtype;

        /// <summary>
        /// expirationType
        /// </summary>
        /// <remarks>
        /// <para>
        /// expirationType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? expirationType
        {
            get => _expirationtype;
            set
            {
                _expirationtype = value;
                OnPropertyChanged(nameof(expirationType));
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

        private List<BackboneElement>? _friendly;

        /// <summary>
        /// friendly
        /// </summary>
        /// <remarks>
        /// <para>
        /// friendly 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? friendly
        {
            get => _friendly;
            set
            {
                _friendly = value;
                OnPropertyChanged(nameof(friendly));
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

        private ReferenceType? _instantiatescanonical;

        /// <summary>
        /// instantiatesCanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesCanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? instantiatesCanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(instantiatesCanonical));
            }
        }

        private FhirUri? _instantiatesuri;

        /// <summary>
        /// instantiatesUri
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesUri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? instantiatesUri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(instantiatesUri));
            }
        }

        private FhirDateTime? _issued;

        /// <summary>
        /// issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(issued));
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

        private List<BackboneElement>? _legal;

        /// <summary>
        /// legal
        /// </summary>
        /// <remarks>
        /// <para>
        /// legal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? legal
        {
            get => _legal;
            set
            {
                _legal = value;
                OnPropertyChanged(nameof(legal));
            }
        }

        private CodeableConcept? _legalstate;

        /// <summary>
        /// legalState
        /// </summary>
        /// <remarks>
        /// <para>
        /// legalState 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? legalState
        {
            get => _legalstate;
            set
            {
                _legalstate = value;
                OnPropertyChanged(nameof(legalState));
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

        private List<ReferenceType>? _relevanthistory;

        /// <summary>
        /// relevantHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// relevantHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? relevantHistory
        {
            get => _relevanthistory;
            set
            {
                _relevanthistory = value;
                OnPropertyChanged(nameof(relevantHistory));
            }
        }

        private List<BackboneElement>? _rule;

        /// <summary>
        /// rule
        /// </summary>
        /// <remarks>
        /// <para>
        /// rule 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? rule
        {
            get => _rule;
            set
            {
                _rule = value;
                OnPropertyChanged(nameof(rule));
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

        private List<BackboneElement>? _signer;

        /// <summary>
        /// signer
        /// </summary>
        /// <remarks>
        /// <para>
        /// signer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? signer
        {
            get => _signer;
            set
            {
                _signer = value;
                OnPropertyChanged(nameof(signer));
            }
        }

        private List<ReferenceType>? _site;

        /// <summary>
        /// site
        /// </summary>
        /// <remarks>
        /// <para>
        /// site 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(site));
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

        private List<ReferenceType>? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
            }
        }

        private FhirString? _subtitle;

        /// <summary>
        /// subtitle
        /// </summary>
        /// <remarks>
        /// <para>
        /// subtitle 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? subtitle
        {
            get => _subtitle;
            set
            {
                _subtitle = value;
                OnPropertyChanged(nameof(subtitle));
            }
        }

        private List<CodeableConcept>? _subtype;

        /// <summary>
        /// subType
        /// </summary>
        /// <remarks>
        /// <para>
        /// subType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? subType
        {
            get => _subtype;
            set
            {
                _subtype = value;
                OnPropertyChanged(nameof(subType));
            }
        }

        private List<ReferenceType>? _supportinginfo;

        /// <summary>
        /// supportingInfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// supportingInfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? supportingInfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(supportingInfo));
            }
        }

        private List<BackboneElement>? _term;

        /// <summary>
        /// term
        /// </summary>
        /// <remarks>
        /// <para>
        /// term 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? term
        {
            get => _term;
            set
            {
                _term = value;
                OnPropertyChanged(nameof(term));
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

        private FhirString? _title;

        /// <summary>
        /// title
        /// </summary>
        /// <remarks>
        /// <para>
        /// title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(title));
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

        private FhirUri? _url;

        /// <summary>
        /// url
        /// </summary>
        /// <remarks>
        /// <para>
        /// url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(url));
            }
        }

        private FhirString? _version;

        /// <summary>
        /// version
        /// </summary>
        /// <remarks>
        /// <para>
        /// version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(version));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Contract";

        /// <summary>
        /// 建立新的 Contract 資源實例
        /// </summary>
        public Contract()
        {
        }

        /// <summary>
        /// 建立新的 Contract 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Contract(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Contract(Id: {Id})";
        }
    }
}
