using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 ImplementationGuide 資源
    /// 
    /// <para>
    /// ImplementationGuide 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var implementationguide = new ImplementationGuide("implementationguide-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ImplementationGuide 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImplementationGuide : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ImplementationGuideVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private FhirId? _packageid;
        private FhirCode? _license;
        private List<FhirCode>? _fhirversion;
        private List<ImplementationGuideDependsOn>? _dependson;
        private List<ImplementationGuideGlobal>? _global;
        private ImplementationGuideDefinition? _definition;
        private ImplementationGuideManifest? _manifest;
        private FhirCanonical? _uri;
        private FhirId? _packageid;
        private FhirString? _version;
        private FhirMarkdown? _reason;
        private FhirCode? _type;
        private FhirCanonical? _profile;
        private FhirString? _name;
        private FhirMarkdown? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private List<FhirCode>? _fhirversion;
        private FhirString? _name;
        private FhirMarkdown? _description;
        private FhirBoolean? _isexample;
        private List<FhirCanonical>? _profile;
        private FhirId? _groupingid;
        private ImplementationGuideDefinitionPageSourceChoice? _source;
        private FhirUrl? _name;
        private FhirString? _title;
        private FhirCode? _generation;
        private Coding? _code;
        private FhirString? _value;
        private FhirCode? _code;
        private FhirString? _source;
        private FhirString? _scope;
        private List<ImplementationGuideDefinitionGrouping>? _grouping;
        private List<ImplementationGuideDefinitionResource>? _resource;
        private ImplementationGuideDefinitionPage? _page;
        private List<ImplementationGuideDefinitionParameter>? _parameter;
        private List<ImplementationGuideDefinitionTemplate>? _template;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private FhirBoolean? _isexample;
        private List<FhirCanonical>? _profile;
        private FhirUrl? _relativepath;
        private FhirString? _name;
        private FhirString? _title;
        private List<FhirString>? _anchor;
        private FhirUrl? _rendering;
        private List<ImplementationGuideManifestResource>? _resource;
        private List<ImplementationGuideManifestPage>? _page;
        private List<FhirString>? _image;
        private List<FhirString>? _other;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImplementationGuide";        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Versionalgorithm
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionalgorithm 的詳細描述。
        /// </para>
        /// </remarks>
        public ImplementationGuideVersionAlgorithmChoice? Versionalgorithm
        {
            get => _versionalgorithm;
            set
            {
                _versionalgorithm = value;
                OnPropertyChanged(nameof(Versionalgorithm));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// Experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(Experimental));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Usecontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usecontext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<UsageContext>? Usecontext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(Usecontext));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Copyrightlabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyrightlabel 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Copyrightlabel
        {
            get => _copyrightlabel;
            set
            {
                _copyrightlabel = value;
                OnPropertyChanged(nameof(Copyrightlabel));
            }
        }        /// <summary>
        /// Packageid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packageid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Packageid
        {
            get => _packageid;
            set
            {
                _packageid = value;
                OnPropertyChanged(nameof(Packageid));
            }
        }        /// <summary>
        /// License
        /// </summary>
        /// <remarks>
        /// <para>
        /// License 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? License
        {
            get => _license;
            set
            {
                _license = value;
                OnPropertyChanged(nameof(License));
            }
        }        /// <summary>
        /// Fhirversion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fhirversion 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Fhirversion
        {
            get => _fhirversion;
            set
            {
                _fhirversion = value;
                OnPropertyChanged(nameof(Fhirversion));
            }
        }        /// <summary>
        /// Dependson
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dependson 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideDependsOn>? Dependson
        {
            get => _dependson;
            set
            {
                _dependson = value;
                OnPropertyChanged(nameof(Dependson));
            }
        }        /// <summary>
        /// Global
        /// </summary>
        /// <remarks>
        /// <para>
        /// Global 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideGlobal>? Global
        {
            get => _global;
            set
            {
                _global = value;
                OnPropertyChanged(nameof(Global));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public ImplementationGuideDefinition? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Manifest
        /// </summary>
        /// <remarks>
        /// <para>
        /// Manifest 的詳細描述。
        /// </para>
        /// </remarks>
        public ImplementationGuideManifest? Manifest
        {
            get => _manifest;
            set
            {
                _manifest = value;
                OnPropertyChanged(nameof(Manifest));
            }
        }        /// <summary>
        /// Uri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged(nameof(Uri));
            }
        }        /// <summary>
        /// Packageid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Packageid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Packageid
        {
            get => _packageid;
            set
            {
                _packageid = value;
                OnPropertyChanged(nameof(Packageid));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Fhirversion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fhirversion 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Fhirversion
        {
            get => _fhirversion;
            set
            {
                _fhirversion = value;
                OnPropertyChanged(nameof(Fhirversion));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Isexample
        /// </summary>
        /// <remarks>
        /// <para>
        /// Isexample 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Isexample
        {
            get => _isexample;
            set
            {
                _isexample = value;
                OnPropertyChanged(nameof(Isexample));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
            }
        }        /// <summary>
        /// Groupingid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Groupingid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Groupingid
        {
            get => _groupingid;
            set
            {
                _groupingid = value;
                OnPropertyChanged(nameof(Groupingid));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public ImplementationGuideDefinitionPageSourceChoice? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Generation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Generation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Generation
        {
            get => _generation;
            set
            {
                _generation = value;
                OnPropertyChanged(nameof(Generation));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Grouping
        /// </summary>
        /// <remarks>
        /// <para>
        /// Grouping 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideDefinitionGrouping>? Grouping
        {
            get => _grouping;
            set
            {
                _grouping = value;
                OnPropertyChanged(nameof(Grouping));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideDefinitionResource>? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Page
        /// </summary>
        /// <remarks>
        /// <para>
        /// Page 的詳細描述。
        /// </para>
        /// </remarks>
        public ImplementationGuideDefinitionPage? Page
        {
            get => _page;
            set
            {
                _page = value;
                OnPropertyChanged(nameof(Page));
            }
        }        /// <summary>
        /// Parameter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Parameter 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideDefinitionParameter>? Parameter
        {
            get => _parameter;
            set
            {
                _parameter = value;
                OnPropertyChanged(nameof(Parameter));
            }
        }        /// <summary>
        /// Template
        /// </summary>
        /// <remarks>
        /// <para>
        /// Template 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideDefinitionTemplate>? Template
        {
            get => _template;
            set
            {
                _template = value;
                OnPropertyChanged(nameof(Template));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Isexample
        /// </summary>
        /// <remarks>
        /// <para>
        /// Isexample 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Isexample
        {
            get => _isexample;
            set
            {
                _isexample = value;
                OnPropertyChanged(nameof(Isexample));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
            }
        }        /// <summary>
        /// Relativepath
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relativepath 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Relativepath
        {
            get => _relativepath;
            set
            {
                _relativepath = value;
                OnPropertyChanged(nameof(Relativepath));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Anchor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Anchor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Anchor
        {
            get => _anchor;
            set
            {
                _anchor = value;
                OnPropertyChanged(nameof(Anchor));
            }
        }        /// <summary>
        /// Rendering
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rendering 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Rendering
        {
            get => _rendering;
            set
            {
                _rendering = value;
                OnPropertyChanged(nameof(Rendering));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideManifestResource>? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Page
        /// </summary>
        /// <remarks>
        /// <para>
        /// Page 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImplementationGuideManifestPage>? Page
        {
            get => _page;
            set
            {
                _page = value;
                OnPropertyChanged(nameof(Page));
            }
        }        /// <summary>
        /// Image
        /// </summary>
        /// <remarks>
        /// <para>
        /// Image 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Image
        {
            get => _image;
            set
            {
                _image = value;
                OnPropertyChanged(nameof(Image));
            }
        }        /// <summary>
        /// Other
        /// </summary>
        /// <remarks>
        /// <para>
        /// Other 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Other
        {
            get => _other;
            set
            {
                _other = value;
                OnPropertyChanged(nameof(Other));
            }
        }        /// <summary>
        /// 建立新的 ImplementationGuide 資源實例
        /// </summary>
        public ImplementationGuide()
        {
        }

        /// <summary>
        /// 建立新的 ImplementationGuide 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ImplementationGuide(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ImplementationGuide(Id: {Id})";
        }
    }    /// <summary>
    /// ImplementationGuideDependsOn 背骨元素
    /// </summary>
    public class ImplementationGuideDependsOn
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDependsOn() { }
    }    /// <summary>
    /// ImplementationGuideGlobal 背骨元素
    /// </summary>
    public class ImplementationGuideGlobal
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideGlobal() { }
    }    /// <summary>
    /// ImplementationGuideDefinitionGrouping 背骨元素
    /// </summary>
    public class ImplementationGuideDefinitionGrouping
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDefinitionGrouping() { }
    }    /// <summary>
    /// ImplementationGuideDefinitionResource 背骨元素
    /// </summary>
    public class ImplementationGuideDefinitionResource
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDefinitionResource() { }
    }    /// <summary>
    /// ImplementationGuideDefinitionPage 背骨元素
    /// </summary>
    public class ImplementationGuideDefinitionPage
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDefinitionPage() { }
    }    /// <summary>
    /// ImplementationGuideDefinitionParameter 背骨元素
    /// </summary>
    public class ImplementationGuideDefinitionParameter
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDefinitionParameter() { }
    }    /// <summary>
    /// ImplementationGuideDefinitionTemplate 背骨元素
    /// </summary>
    public class ImplementationGuideDefinitionTemplate
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDefinitionTemplate() { }
    }    /// <summary>
    /// ImplementationGuideDefinition 背骨元素
    /// </summary>
    public class ImplementationGuideDefinition
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideDefinition() { }
    }    /// <summary>
    /// ImplementationGuideManifestResource 背骨元素
    /// </summary>
    public class ImplementationGuideManifestResource
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideManifestResource() { }
    }    /// <summary>
    /// ImplementationGuideManifestPage 背骨元素
    /// </summary>
    public class ImplementationGuideManifestPage
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideManifestPage() { }
    }    /// <summary>
    /// ImplementationGuideManifest 背骨元素
    /// </summary>
    public class ImplementationGuideManifest
    {
        // TODO: 添加屬性實作
        
        public ImplementationGuideManifest() { }
    }    /// <summary>
    /// ImplementationGuideVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ImplementationGuideVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ImplementationGuideVersionAlgorithmChoice(JsonObject value) : base("implementationguideversionalgorithm", value, _supportType) { }
        public ImplementationGuideVersionAlgorithmChoice(IComplexType? value) : base("implementationguideversionalgorithm", value) { }
        public ImplementationGuideVersionAlgorithmChoice(IPrimitiveType? value) : base("implementationguideversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ImplementationGuideVersionAlgorithm" : "implementationguideversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ImplementationGuideDefinitionPageSourceChoice 選擇類型
    /// </summary>
    public class ImplementationGuideDefinitionPageSourceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ImplementationGuideDefinitionPageSourceChoice(JsonObject value) : base("implementationguidedefinitionpagesource", value, _supportType) { }
        public ImplementationGuideDefinitionPageSourceChoice(IComplexType? value) : base("implementationguidedefinitionpagesource", value) { }
        public ImplementationGuideDefinitionPageSourceChoice(IPrimitiveType? value) : base("implementationguidedefinitionpagesource", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ImplementationGuideDefinitionPageSource" : "implementationguidedefinitionpagesource";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
