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
    /// FHIR R5 CapabilityStatement 資源
    /// 
    /// <para>
    /// CapabilityStatement 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
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
    /// R5 版本的 CapabilityStatement 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CapabilityStatement : ResourceBase<R5Version>
    {
        private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private CapabilityStatementVersionAlgorithmChoice? _versionalgorithm;
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
        private FhirCode? _kind;
        private List<FhirCanonical>? _instantiates;
        private List<FhirCanonical>? _imports;
        private CapabilityStatementSoftware? _software;
        private CapabilityStatementImplementation? _implementation;
        private FhirCode? _fhirversion;
        private List<FhirCode>? _format;
        private List<FhirCode>? _patchformat;
        private List<FhirCode>? _acceptlanguage;
        private List<FhirCanonical>? _implementationguide;
        private List<CapabilityStatementRest>? _rest;
        private List<CapabilityStatementMessaging>? _messaging;
        private List<CapabilityStatementDocument>? _document;
        private FhirString? _name;
        private FhirString? _version;
        private FhirDateTime? _releasedate;
        private FhirMarkdown? _description;
        private FhirUrl? _url;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _custodian;
        private FhirBoolean? _cors;
        private List<CodeableConcept>? _service;
        private FhirMarkdown? _description;
        private FhirCode? _code;
        private FhirMarkdown? _documentation;
        private FhirString? _name;
        private FhirCanonical? _definition;
        private FhirCode? _type;
        private FhirMarkdown? _documentation;
        private FhirString? _name;
        private FhirCanonical? _definition;
        private FhirMarkdown? _documentation;
        private FhirCode? _type;
        private FhirCanonical? _profile;
        private List<FhirCanonical>? _supportedprofile;
        private FhirMarkdown? _documentation;
        private List<CapabilityStatementRestResourceInteraction>? _interaction;
        private FhirCode? _versioning;
        private FhirBoolean? _readhistory;
        private FhirBoolean? _updatecreate;
        private FhirBoolean? _conditionalcreate;
        private FhirCode? _conditionalread;
        private FhirBoolean? _conditionalupdate;
        private FhirBoolean? _conditionalpatch;
        private FhirCode? _conditionaldelete;
        private List<FhirCode>? _referencepolicy;
        private List<FhirString>? _searchinclude;
        private List<FhirString>? _searchrevinclude;
        private List<CapabilityStatementRestSearchParam>? _searchparam;
        private List<CapabilityStatementRestOperation>? _operation;
        private FhirCode? _code;
        private FhirMarkdown? _documentation;
        private FhirCode? _mode;
        private FhirMarkdown? _documentation;
        private CapabilityStatementRestSecurity? _security;
        private List<CapabilityStatementRestResource>? _resource;
        private List<CapabilityStatementRestInteraction>? _interaction;
        private List<CapabilityStatementRestSearchParam>? _searchparam;
        private List<CapabilityStatementRestOperation>? _operation;
        private List<FhirCanonical>? _compartment;
        private Coding? _protocol;
        private FhirUrl? _address;
        private FhirCode? _mode;
        private FhirCanonical? _definition;
        private List<CapabilityStatementMessagingEndpoint>? _endpoint;
        private FhirUnsignedInt? _reliablecache;
        private FhirMarkdown? _documentation;
        private List<CapabilityStatementMessagingSupportedMessage>? _supportedmessage;
        private FhirCode? _mode;
        private FhirMarkdown? _documentation;
        private FhirCanonical? _profile;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CapabilityStatement";        /// <summary>
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
        public CapabilityStatementVersionAlgorithmChoice? Versionalgorithm
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
        /// Kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// Kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(Kind));
            }
        }        /// <summary>
        /// Instantiates
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiates 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(Instantiates));
            }
        }        /// <summary>
        /// Imports
        /// </summary>
        /// <remarks>
        /// <para>
        /// Imports 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Imports
        {
            get => _imports;
            set
            {
                _imports = value;
                OnPropertyChanged(nameof(Imports));
            }
        }        /// <summary>
        /// Software
        /// </summary>
        /// <remarks>
        /// <para>
        /// Software 的詳細描述。
        /// </para>
        /// </remarks>
        public CapabilityStatementSoftware? Software
        {
            get => _software;
            set
            {
                _software = value;
                OnPropertyChanged(nameof(Software));
            }
        }        /// <summary>
        /// Implementation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Implementation 的詳細描述。
        /// </para>
        /// </remarks>
        public CapabilityStatementImplementation? Implementation
        {
            get => _implementation;
            set
            {
                _implementation = value;
                OnPropertyChanged(nameof(Implementation));
            }
        }        /// <summary>
        /// Fhirversion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fhirversion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Fhirversion
        {
            get => _fhirversion;
            set
            {
                _fhirversion = value;
                OnPropertyChanged(nameof(Fhirversion));
            }
        }        /// <summary>
        /// Format
        /// </summary>
        /// <remarks>
        /// <para>
        /// Format 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Format
        {
            get => _format;
            set
            {
                _format = value;
                OnPropertyChanged(nameof(Format));
            }
        }        /// <summary>
        /// Patchformat
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patchformat 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Patchformat
        {
            get => _patchformat;
            set
            {
                _patchformat = value;
                OnPropertyChanged(nameof(Patchformat));
            }
        }        /// <summary>
        /// Acceptlanguage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Acceptlanguage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Acceptlanguage
        {
            get => _acceptlanguage;
            set
            {
                _acceptlanguage = value;
                OnPropertyChanged(nameof(Acceptlanguage));
            }
        }        /// <summary>
        /// Implementationguide
        /// </summary>
        /// <remarks>
        /// <para>
        /// Implementationguide 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Implementationguide
        {
            get => _implementationguide;
            set
            {
                _implementationguide = value;
                OnPropertyChanged(nameof(Implementationguide));
            }
        }        /// <summary>
        /// Rest
        /// </summary>
        /// <remarks>
        /// <para>
        /// Rest 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRest>? Rest
        {
            get => _rest;
            set
            {
                _rest = value;
                OnPropertyChanged(nameof(Rest));
            }
        }        /// <summary>
        /// Messaging
        /// </summary>
        /// <remarks>
        /// <para>
        /// Messaging 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementMessaging>? Messaging
        {
            get => _messaging;
            set
            {
                _messaging = value;
                OnPropertyChanged(nameof(Messaging));
            }
        }        /// <summary>
        /// Document
        /// </summary>
        /// <remarks>
        /// <para>
        /// Document 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementDocument>? Document
        {
            get => _document;
            set
            {
                _document = value;
                OnPropertyChanged(nameof(Document));
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
        /// Releasedate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Releasedate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Releasedate
        {
            get => _releasedate;
            set
            {
                _releasedate = value;
                OnPropertyChanged(nameof(Releasedate));
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
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Custodian
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custodian 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Custodian
        {
            get => _custodian;
            set
            {
                _custodian = value;
                OnPropertyChanged(nameof(Custodian));
            }
        }        /// <summary>
        /// Cors
        /// </summary>
        /// <remarks>
        /// <para>
        /// Cors 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Cors
        {
            get => _cors;
            set
            {
                _cors = value;
                OnPropertyChanged(nameof(Cors));
            }
        }        /// <summary>
        /// Service
        /// </summary>
        /// <remarks>
        /// <para>
        /// Service 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Service
        {
            get => _service;
            set
            {
                _service = value;
                OnPropertyChanged(nameof(Service));
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
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
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
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
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
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
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
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
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
        /// Supportedprofile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportedprofile 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Supportedprofile
        {
            get => _supportedprofile;
            set
            {
                _supportedprofile = value;
                OnPropertyChanged(nameof(Supportedprofile));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Interaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Interaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestResourceInteraction>? Interaction
        {
            get => _interaction;
            set
            {
                _interaction = value;
                OnPropertyChanged(nameof(Interaction));
            }
        }        /// <summary>
        /// Versioning
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versioning 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Versioning
        {
            get => _versioning;
            set
            {
                _versioning = value;
                OnPropertyChanged(nameof(Versioning));
            }
        }        /// <summary>
        /// Readhistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Readhistory 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Readhistory
        {
            get => _readhistory;
            set
            {
                _readhistory = value;
                OnPropertyChanged(nameof(Readhistory));
            }
        }        /// <summary>
        /// Updatecreate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Updatecreate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Updatecreate
        {
            get => _updatecreate;
            set
            {
                _updatecreate = value;
                OnPropertyChanged(nameof(Updatecreate));
            }
        }        /// <summary>
        /// Conditionalcreate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conditionalcreate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Conditionalcreate
        {
            get => _conditionalcreate;
            set
            {
                _conditionalcreate = value;
                OnPropertyChanged(nameof(Conditionalcreate));
            }
        }        /// <summary>
        /// Conditionalread
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conditionalread 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Conditionalread
        {
            get => _conditionalread;
            set
            {
                _conditionalread = value;
                OnPropertyChanged(nameof(Conditionalread));
            }
        }        /// <summary>
        /// Conditionalupdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conditionalupdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Conditionalupdate
        {
            get => _conditionalupdate;
            set
            {
                _conditionalupdate = value;
                OnPropertyChanged(nameof(Conditionalupdate));
            }
        }        /// <summary>
        /// Conditionalpatch
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conditionalpatch 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Conditionalpatch
        {
            get => _conditionalpatch;
            set
            {
                _conditionalpatch = value;
                OnPropertyChanged(nameof(Conditionalpatch));
            }
        }        /// <summary>
        /// Conditionaldelete
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conditionaldelete 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Conditionaldelete
        {
            get => _conditionaldelete;
            set
            {
                _conditionaldelete = value;
                OnPropertyChanged(nameof(Conditionaldelete));
            }
        }        /// <summary>
        /// Referencepolicy
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referencepolicy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Referencepolicy
        {
            get => _referencepolicy;
            set
            {
                _referencepolicy = value;
                OnPropertyChanged(nameof(Referencepolicy));
            }
        }        /// <summary>
        /// Searchinclude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Searchinclude 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Searchinclude
        {
            get => _searchinclude;
            set
            {
                _searchinclude = value;
                OnPropertyChanged(nameof(Searchinclude));
            }
        }        /// <summary>
        /// Searchrevinclude
        /// </summary>
        /// <remarks>
        /// <para>
        /// Searchrevinclude 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? Searchrevinclude
        {
            get => _searchrevinclude;
            set
            {
                _searchrevinclude = value;
                OnPropertyChanged(nameof(Searchrevinclude));
            }
        }        /// <summary>
        /// Searchparam
        /// </summary>
        /// <remarks>
        /// <para>
        /// Searchparam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestSearchParam>? Searchparam
        {
            get => _searchparam;
            set
            {
                _searchparam = value;
                OnPropertyChanged(nameof(Searchparam));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestOperation>? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
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
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Security
        /// </summary>
        /// <remarks>
        /// <para>
        /// Security 的詳細描述。
        /// </para>
        /// </remarks>
        public CapabilityStatementRestSecurity? Security
        {
            get => _security;
            set
            {
                _security = value;
                OnPropertyChanged(nameof(Security));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestResource>? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Interaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Interaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestInteraction>? Interaction
        {
            get => _interaction;
            set
            {
                _interaction = value;
                OnPropertyChanged(nameof(Interaction));
            }
        }        /// <summary>
        /// Searchparam
        /// </summary>
        /// <remarks>
        /// <para>
        /// Searchparam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestSearchParam>? Searchparam
        {
            get => _searchparam;
            set
            {
                _searchparam = value;
                OnPropertyChanged(nameof(Searchparam));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementRestOperation>? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// Compartment
        /// </summary>
        /// <remarks>
        /// <para>
        /// Compartment 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Compartment
        {
            get => _compartment;
            set
            {
                _compartment = value;
                OnPropertyChanged(nameof(Compartment));
            }
        }        /// <summary>
        /// Protocol
        /// </summary>
        /// <remarks>
        /// <para>
        /// Protocol 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Protocol
        {
            get => _protocol;
            set
            {
                _protocol = value;
                OnPropertyChanged(nameof(Protocol));
            }
        }        /// <summary>
        /// Address
        /// </summary>
        /// <remarks>
        /// <para>
        /// Address 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUrl? Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Endpoint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Endpoint 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementMessagingEndpoint>? Endpoint
        {
            get => _endpoint;
            set
            {
                _endpoint = value;
                OnPropertyChanged(nameof(Endpoint));
            }
        }        /// <summary>
        /// Reliablecache
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reliablecache 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUnsignedInt? Reliablecache
        {
            get => _reliablecache;
            set
            {
                _reliablecache = value;
                OnPropertyChanged(nameof(Reliablecache));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
            }
        }        /// <summary>
        /// Supportedmessage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportedmessage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CapabilityStatementMessagingSupportedMessage>? Supportedmessage
        {
            get => _supportedmessage;
            set
            {
                _supportedmessage = value;
                OnPropertyChanged(nameof(Supportedmessage));
            }
        }        /// <summary>
        /// Mode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Mode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }        /// <summary>
        /// Documentation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Documentation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Documentation
        {
            get => _documentation;
            set
            {
                _documentation = value;
                OnPropertyChanged(nameof(Documentation));
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
    }    /// <summary>
    /// CapabilityStatementSoftware 背骨元素
    /// </summary>
    public class CapabilityStatementSoftware
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementSoftware() { }
    }    /// <summary>
    /// CapabilityStatementImplementation 背骨元素
    /// </summary>
    public class CapabilityStatementImplementation
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementImplementation() { }
    }    /// <summary>
    /// CapabilityStatementRestSecurity 背骨元素
    /// </summary>
    public class CapabilityStatementRestSecurity
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRestSecurity() { }
    }    /// <summary>
    /// CapabilityStatementRestResourceInteraction 背骨元素
    /// </summary>
    public class CapabilityStatementRestResourceInteraction
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRestResourceInteraction() { }
    }    /// <summary>
    /// CapabilityStatementRestSearchParam 背骨元素
    /// </summary>
    public class CapabilityStatementRestSearchParam
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRestSearchParam() { }
    }    /// <summary>
    /// CapabilityStatementRestOperation 背骨元素
    /// </summary>
    public class CapabilityStatementRestOperation
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRestOperation() { }
    }    /// <summary>
    /// CapabilityStatementRestResource 背骨元素
    /// </summary>
    public class CapabilityStatementRestResource
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRestResource() { }
    }    /// <summary>
    /// CapabilityStatementRestInteraction 背骨元素
    /// </summary>
    public class CapabilityStatementRestInteraction
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRestInteraction() { }
    }    /// <summary>
    /// CapabilityStatementRest 背骨元素
    /// </summary>
    public class CapabilityStatementRest
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementRest() { }
    }    /// <summary>
    /// CapabilityStatementMessagingEndpoint 背骨元素
    /// </summary>
    public class CapabilityStatementMessagingEndpoint
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementMessagingEndpoint() { }
    }    /// <summary>
    /// CapabilityStatementMessagingSupportedMessage 背骨元素
    /// </summary>
    public class CapabilityStatementMessagingSupportedMessage
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementMessagingSupportedMessage() { }
    }    /// <summary>
    /// CapabilityStatementMessaging 背骨元素
    /// </summary>
    public class CapabilityStatementMessaging
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementMessaging() { }
    }    /// <summary>
    /// CapabilityStatementDocument 背骨元素
    /// </summary>
    public class CapabilityStatementDocument
    {
        // TODO: 添加屬性實作
        
        public CapabilityStatementDocument() { }
    }    /// <summary>
    /// CapabilityStatementVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class CapabilityStatementVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CapabilityStatementVersionAlgorithmChoice(JsonObject value) : base("capabilitystatementversionalgorithm", value, _supportType) { }
        public CapabilityStatementVersionAlgorithmChoice(IComplexType? value) : base("capabilitystatementversionalgorithm", value) { }
        public CapabilityStatementVersionAlgorithmChoice(IPrimitiveType? value) : base("capabilitystatementversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CapabilityStatementVersionAlgorithm" : "capabilitystatementversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
