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
    /// FHIR R4 CodeSystem 資源
    /// 
    /// <para>
    /// The CodeSystem resource is used to declare the existence of and describe a code system or code system supplement and its key properties, and optionally define a part or all of its content.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var codesystem = new CodeSystem("codesystem-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 CodeSystem 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CodeSystem : ResourceBase<R4Version>
    {
        private FhirBoolean? _casesensitive;

        /// <summary>
        /// caseSensitive
        /// </summary>
        /// <remarks>
        /// <para>
        /// caseSensitive 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? caseSensitive
        {
            get => _casesensitive;
            set
            {
                _casesensitive = value;
                OnPropertyChanged(nameof(caseSensitive));
            }
        }

        private FhirBoolean? _compositional;

        /// <summary>
        /// compositional
        /// </summary>
        /// <remarks>
        /// <para>
        /// compositional 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? compositional
        {
            get => _compositional;
            set
            {
                _compositional = value;
                OnPropertyChanged(nameof(compositional));
            }
        }

        private List<BackboneElement>? _concept;

        /// <summary>
        /// concept
        /// </summary>
        /// <remarks>
        /// <para>
        /// concept 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? concept
        {
            get => _concept;
            set
            {
                _concept = value;
                OnPropertyChanged(nameof(concept));
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

        private FhirCode? _content;

        /// <summary>
        /// content
        /// </summary>
        /// <remarks>
        /// <para>
        /// content 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(content));
            }
        }

        private FhirMarkdown? _copyright;

        /// <summary>
        /// copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(copyright));
            }
        }

        private FhirUnsignedInt? _count;

        /// <summary>
        /// count
        /// </summary>
        /// <remarks>
        /// <para>
        /// count 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(count));
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

        private List<BackboneElement>? _filter;

        /// <summary>
        /// filter
        /// </summary>
        /// <remarks>
        /// <para>
        /// filter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? filter
        {
            get => _filter;
            set
            {
                _filter = value;
                OnPropertyChanged(nameof(filter));
            }
        }

        private FhirCode? _hierarchymeaning;

        /// <summary>
        /// hierarchyMeaning
        /// </summary>
        /// <remarks>
        /// <para>
        /// hierarchyMeaning 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? hierarchyMeaning
        {
            get => _hierarchymeaning;
            set
            {
                _hierarchymeaning = value;
                OnPropertyChanged(nameof(hierarchyMeaning));
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

        private List<BackboneElement>? _property;

        /// <summary>
        /// property
        /// </summary>
        /// <remarks>
        /// <para>
        /// property 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? property
        {
            get => _property;
            set
            {
                _property = value;
                OnPropertyChanged(nameof(property));
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

        private FhirCanonical? _supplements;

        /// <summary>
        /// supplements
        /// </summary>
        /// <remarks>
        /// <para>
        /// supplements 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? supplements
        {
            get => _supplements;
            set
            {
                _supplements = value;
                OnPropertyChanged(nameof(supplements));
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

        private FhirCanonical? _valueset;

        /// <summary>
        /// valueSet
        /// </summary>
        /// <remarks>
        /// <para>
        /// valueSet 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? valueSet
        {
            get => _valueset;
            set
            {
                _valueset = value;
                OnPropertyChanged(nameof(valueSet));
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

        private FhirBoolean? _versionneeded;

        /// <summary>
        /// versionNeeded
        /// </summary>
        /// <remarks>
        /// <para>
        /// versionNeeded 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? versionNeeded
        {
            get => _versionneeded;
            set
            {
                _versionneeded = value;
                OnPropertyChanged(nameof(versionNeeded));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CodeSystem";

        /// <summary>
        /// 建立新的 CodeSystem 資源實例
        /// </summary>
        public CodeSystem()
        {
        }

        /// <summary>
        /// 建立新的 CodeSystem 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CodeSystem(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CodeSystem(Id: {Id})";
        }
    }
}
