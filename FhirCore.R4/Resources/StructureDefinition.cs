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
    /// FHIR R4 StructureDefinition 資源
    /// 
    /// <para>
    /// A definition of a FHIR structure. This resource is used to describe the underlying resources, data types defined in FHIR, and also for describing extensions and constraints on resources and data types.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var structuredefinition = new StructureDefinition("structuredefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 StructureDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class StructureDefinition : ResourceBase<R4Version>
    {
        private FhirBoolean? _abstract;

        /// <summary>
        /// abstract
        /// </summary>
        /// <remarks>
        /// <para>
        /// abstract 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? abstract
        {
            get => _abstract;
            set
            {
                _abstract = value;
                OnPropertyChanged(nameof(abstract));
            }
        }

        private FhirCanonical? _basedefinition;

        /// <summary>
        /// baseDefinition
        /// </summary>
        /// <remarks>
        /// <para>
        /// baseDefinition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? baseDefinition
        {
            get => _basedefinition;
            set
            {
                _basedefinition = value;
                OnPropertyChanged(nameof(baseDefinition));
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

        private List<BackboneElement>? _context;

        /// <summary>
        /// context
        /// </summary>
        /// <remarks>
        /// <para>
        /// context 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(context));
            }
        }

        private List<FhirString>? _contextinvariant;

        /// <summary>
        /// contextInvariant
        /// </summary>
        /// <remarks>
        /// <para>
        /// contextInvariant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contextInvariant
        {
            get => _contextinvariant;
            set
            {
                _contextinvariant = value;
                OnPropertyChanged(nameof(contextInvariant));
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

        private FhirCode? _derivation;

        /// <summary>
        /// derivation
        /// </summary>
        /// <remarks>
        /// <para>
        /// derivation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? derivation
        {
            get => _derivation;
            set
            {
                _derivation = value;
                OnPropertyChanged(nameof(derivation));
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

        private BackboneElement? _differential;

        /// <summary>
        /// differential
        /// </summary>
        /// <remarks>
        /// <para>
        /// differential 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? differential
        {
            get => _differential;
            set
            {
                _differential = value;
                OnPropertyChanged(nameof(differential));
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

        private FhirCode? _fhirversion;

        /// <summary>
        /// fhirVersion
        /// </summary>
        /// <remarks>
        /// <para>
        /// fhirVersion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? fhirVersion
        {
            get => _fhirversion;
            set
            {
                _fhirversion = value;
                OnPropertyChanged(nameof(fhirVersion));
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

        private List<Coding>? _keyword;

        /// <summary>
        /// keyword
        /// </summary>
        /// <remarks>
        /// <para>
        /// keyword 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? keyword
        {
            get => _keyword;
            set
            {
                _keyword = value;
                OnPropertyChanged(nameof(keyword));
            }
        }

        private FhirCode? _kind;

        /// <summary>
        /// kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(kind));
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

        private List<BackboneElement>? _mapping;

        /// <summary>
        /// mapping
        /// </summary>
        /// <remarks>
        /// <para>
        /// mapping 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? mapping
        {
            get => _mapping;
            set
            {
                _mapping = value;
                OnPropertyChanged(nameof(mapping));
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

        private BackboneElement? _snapshot;

        /// <summary>
        /// snapshot
        /// </summary>
        /// <remarks>
        /// <para>
        /// snapshot 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? snapshot
        {
            get => _snapshot;
            set
            {
                _snapshot = value;
                OnPropertyChanged(nameof(snapshot));
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

        private FhirUri? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? type
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "StructureDefinition";

        /// <summary>
        /// 建立新的 StructureDefinition 資源實例
        /// </summary>
        public StructureDefinition()
        {
        }

        /// <summary>
        /// 建立新的 StructureDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public StructureDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"StructureDefinition(Id: {Id})";
        }
    }
}
