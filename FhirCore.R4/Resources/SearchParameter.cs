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
    /// FHIR R4 SearchParameter 資源
    /// 
    /// <para>
    /// A search parameter that defines a named search item that can be used to search/filter on a resource.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var searchparameter = new SearchParameter("searchparameter-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SearchParameter 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SearchParameter : ResourceBase<R4Version>
    {
        private List<FhirCode>? _base;

        /// <summary>
        /// base
        /// </summary>
        /// <remarks>
        /// <para>
        /// base 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? base
        {
            get => _base;
            set
            {
                _base = value;
                OnPropertyChanged(nameof(base));
            }
        }

        private List<FhirString>? _chain;

        /// <summary>
        /// chain
        /// </summary>
        /// <remarks>
        /// <para>
        /// chain 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? chain
        {
            get => _chain;
            set
            {
                _chain = value;
                OnPropertyChanged(nameof(chain));
            }
        }

        private FhirCode? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
            }
        }

        private List<FhirCode>? _comparator;

        /// <summary>
        /// comparator
        /// </summary>
        /// <remarks>
        /// <para>
        /// comparator 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? comparator
        {
            get => _comparator;
            set
            {
                _comparator = value;
                OnPropertyChanged(nameof(comparator));
            }
        }

        private List<BackboneElement>? _component;

        /// <summary>
        /// component
        /// </summary>
        /// <remarks>
        /// <para>
        /// component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(component));
            }
        }

        private List<FhirString>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contact
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

        private FhirCanonical? _derivedfrom;

        /// <summary>
        /// derivedFrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// derivedFrom 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? derivedFrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(derivedFrom));
            }
        }

        private FhirMarkdown? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private FhirBoolean? _experimental;

        /// <summary>
        /// experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(experimental));
            }
        }

        private FhirString? _expression;

        /// <summary>
        /// expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// expression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(expression));
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

        private List<CodeableConcept>? _jurisdiction;

        /// <summary>
        /// jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(jurisdiction));
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

        private List<FhirCode>? _modifier;

        /// <summary>
        /// modifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                OnPropertyChanged(nameof(modifier));
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

        private FhirBoolean? _multipleand;

        /// <summary>
        /// multipleAnd
        /// </summary>
        /// <remarks>
        /// <para>
        /// multipleAnd 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? multipleAnd
        {
            get => _multipleand;
            set
            {
                _multipleand = value;
                OnPropertyChanged(nameof(multipleAnd));
            }
        }

        private FhirBoolean? _multipleor;

        /// <summary>
        /// multipleOr
        /// </summary>
        /// <remarks>
        /// <para>
        /// multipleOr 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? multipleOr
        {
            get => _multipleor;
            set
            {
                _multipleor = value;
                OnPropertyChanged(nameof(multipleOr));
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

        private FhirString? _publisher;

        /// <summary>
        /// publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(publisher));
            }
        }

        private FhirMarkdown? _purpose;

        /// <summary>
        /// purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(purpose));
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

        private List<FhirCode>? _target;

        /// <summary>
        /// target
        /// </summary>
        /// <remarks>
        /// <para>
        /// target 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? target
        {
            get => _target;
            set
            {
                _target = value;
                OnPropertyChanged(nameof(target));
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

        private FhirCode? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? type
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

        private List<FhirString>? _usecontext;

        /// <summary>
        /// useContext
        /// </summary>
        /// <remarks>
        /// <para>
        /// useContext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? useContext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(useContext));
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

        private FhirString? _xpath;

        /// <summary>
        /// xpath
        /// </summary>
        /// <remarks>
        /// <para>
        /// xpath 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? xpath
        {
            get => _xpath;
            set
            {
                _xpath = value;
                OnPropertyChanged(nameof(xpath));
            }
        }

        private FhirCode? _xpathusage;

        /// <summary>
        /// xpathUsage
        /// </summary>
        /// <remarks>
        /// <para>
        /// xpathUsage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? xpathUsage
        {
            get => _xpathusage;
            set
            {
                _xpathusage = value;
                OnPropertyChanged(nameof(xpathUsage));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SearchParameter";

        /// <summary>
        /// 建立新的 SearchParameter 資源實例
        /// </summary>
        public SearchParameter()
        {
        }

        /// <summary>
        /// 建立新的 SearchParameter 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SearchParameter(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SearchParameter(Id: {Id})";
        }
    }
}
