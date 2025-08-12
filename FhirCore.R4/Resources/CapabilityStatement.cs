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
    /// FHIR R4 CapabilityStatement 資源
    /// 
    /// <para>
    /// A Capability Statement documents a set of capabilities (behaviors) of a FHIR Server for a particular version of FHIR that may be used as a statement of actual server functionality or a statement of required or desired server implementation.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var capabilitystatement = new CapabilityStatement("capabilitystatement-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 CapabilityStatement 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CapabilityStatement : ResourceBase<R4Version>
    {
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

        private List<BackboneElement>? _document;

        /// <summary>
        /// document
        /// </summary>
        /// <remarks>
        /// <para>
        /// document 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? document
        {
            get => _document;
            set
            {
                _document = value;
                OnPropertyChanged(nameof(document));
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

        private List<FhirCode>? _format;

        /// <summary>
        /// format
        /// </summary>
        /// <remarks>
        /// <para>
        /// format 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? format
        {
            get => _format;
            set
            {
                _format = value;
                OnPropertyChanged(nameof(format));
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

        private BackboneElement? _implementation;

        /// <summary>
        /// implementation
        /// </summary>
        /// <remarks>
        /// <para>
        /// implementation 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? implementation
        {
            get => _implementation;
            set
            {
                _implementation = value;
                OnPropertyChanged(nameof(implementation));
            }
        }

        private List<FhirCanonical>? _implementationguide;

        /// <summary>
        /// implementationGuide
        /// </summary>
        /// <remarks>
        /// <para>
        /// implementationGuide 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? implementationGuide
        {
            get => _implementationguide;
            set
            {
                _implementationguide = value;
                OnPropertyChanged(nameof(implementationGuide));
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

        private List<FhirCanonical>? _imports;

        /// <summary>
        /// imports
        /// </summary>
        /// <remarks>
        /// <para>
        /// imports 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? imports
        {
            get => _imports;
            set
            {
                _imports = value;
                OnPropertyChanged(nameof(imports));
            }
        }

        private List<FhirCanonical>? _instantiates;

        /// <summary>
        /// instantiates
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiates 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(instantiates));
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

        private List<BackboneElement>? _messaging;

        /// <summary>
        /// messaging
        /// </summary>
        /// <remarks>
        /// <para>
        /// messaging 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? messaging
        {
            get => _messaging;
            set
            {
                _messaging = value;
                OnPropertyChanged(nameof(messaging));
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

        private List<FhirCode>? _patchformat;

        /// <summary>
        /// patchFormat
        /// </summary>
        /// <remarks>
        /// <para>
        /// patchFormat 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? patchFormat
        {
            get => _patchformat;
            set
            {
                _patchformat = value;
                OnPropertyChanged(nameof(patchFormat));
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

        private List<BackboneElement>? _rest;

        /// <summary>
        /// rest
        /// </summary>
        /// <remarks>
        /// <para>
        /// rest 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? rest
        {
            get => _rest;
            set
            {
                _rest = value;
                OnPropertyChanged(nameof(rest));
            }
        }

        private BackboneElement? _software;

        /// <summary>
        /// software
        /// </summary>
        /// <remarks>
        /// <para>
        /// software 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? software
        {
            get => _software;
            set
            {
                _software = value;
                OnPropertyChanged(nameof(software));
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
        public override string ResourceType => "CapabilityStatement";

        /// <summary>
        /// 建立新的 CapabilityStatement 資源實例
        /// </summary>
        public CapabilityStatement()
        {
        }

        /// <summary>
        /// 建立新的 CapabilityStatement 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CapabilityStatement(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CapabilityStatement(Id: {Id})";
        }
    }
}
