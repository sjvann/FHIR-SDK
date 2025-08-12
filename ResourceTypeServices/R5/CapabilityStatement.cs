using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class CapabilityStatement : ResourceType<CapabilityStatement>
    {
        #region private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private CapabilityStatementVersionAlgorithmChoice? _versionAlgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _useContext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightLabel;
        private FhirCode? _kind;
        private List<FhirCanonical>? _instantiates;
        private List<FhirCanonical>? _imports;
        private CapabilityStatementSoftware? _software;
        private CapabilityStatementImplementation? _implementation;
        private FhirCode? _fhirVersion;
        private List<FhirCode>? _format;
        private List<FhirCode>? _patchFormat;
        private List<FhirCode>? _acceptLanguage;
        private List<FhirCanonical>? _implementationGuide;
        private List<CapabilityStatementRest>? _rest;
        private List<CapabilityStatementMessaging>? _messaging;
        private List<CapabilityStatementDocument>? _document;

        #endregion
        #region Public Method
        public FhirUri? Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("url", value);
            }
        }

        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        public FhirString? Version
        {
            get { return _version; }
            set
            {
                _version = value;
                OnPropertyChanged("version", value);
            }
        }

        public CapabilityStatementVersionAlgorithmChoice? VersionAlgorithm
        {
            get { return _versionAlgorithm; }
            set
            {
                _versionAlgorithm = value;
                OnPropertyChanged("versionAlgorithm", value);
            }
        }

        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        public FhirString? Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged("title", value);
            }
        }

        public FhirCode? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }

        public FhirBoolean? Experimental
        {
            get { return _experimental; }
            set
            {
                _experimental = value;
                OnPropertyChanged("experimental", value);
            }
        }

        public FhirDateTime? Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("date", value);
            }
        }

        public FhirString? Publisher
        {
            get { return _publisher; }
            set
            {
                _publisher = value;
                OnPropertyChanged("publisher", value);
            }
        }

        public List<ContactDetail>? Contact
        {
            get { return _contact; }
            set
            {
                _contact = value;
                OnPropertyChanged("contact", value);
            }
        }

        public FhirMarkdown? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public List<UsageContext>? UseContext
        {
            get { return _useContext; }
            set
            {
                _useContext = value;
                OnPropertyChanged("useContext", value);
            }
        }

        public List<CodeableConcept>? Jurisdiction
        {
            get { return _jurisdiction; }
            set
            {
                _jurisdiction = value;
                OnPropertyChanged("jurisdiction", value);
            }
        }

        public FhirMarkdown? Purpose
        {
            get { return _purpose; }
            set
            {
                _purpose = value;
                OnPropertyChanged("purpose", value);
            }
        }

        public FhirMarkdown? Copyright
        {
            get { return _copyright; }
            set
            {
                _copyright = value;
                OnPropertyChanged("copyright", value);
            }
        }

        public FhirString? CopyrightLabel
        {
            get { return _copyrightLabel; }
            set
            {
                _copyrightLabel = value;
                OnPropertyChanged("copyrightLabel", value);
            }
        }

        public FhirCode? Kind
        {
            get { return _kind; }
            set
            {
                _kind = value;
                OnPropertyChanged("kind", value);
            }
        }

        public List<FhirCanonical>? Instantiates
        {
            get { return _instantiates; }
            set
            {
                _instantiates = value;
                OnPropertyChanged("instantiates", value);
            }
        }

        public List<FhirCanonical>? Imports
        {
            get { return _imports; }
            set
            {
                _imports = value;
                OnPropertyChanged("imports", value);
            }
        }

        public CapabilityStatementSoftware? Software
        {
            get { return _software; }
            set
            {
                _software = value;
                OnPropertyChanged("software", value);
            }
        }

        public CapabilityStatementImplementation? Implementation
        {
            get { return _implementation; }
            set
            {
                _implementation = value;
                OnPropertyChanged("implementation", value);
            }
        }

        public FhirCode? FhirVersion
        {
            get { return _fhirVersion; }
            set
            {
                _fhirVersion = value;
                OnPropertyChanged("fhirVersion", value);
            }
        }

        public List<FhirCode>? Format
        {
            get { return _format; }
            set
            {
                _format = value;
                OnPropertyChanged("format", value);
            }
        }

        public List<FhirCode>? PatchFormat
        {
            get { return _patchFormat; }
            set
            {
                _patchFormat = value;
                OnPropertyChanged("patchFormat", value);
            }
        }

        public List<FhirCode>? AcceptLanguage
        {
            get { return _acceptLanguage; }
            set
            {
                _acceptLanguage = value;
                OnPropertyChanged("acceptLanguage", value);
            }
        }

        public List<FhirCanonical>? ImplementationGuide
        {
            get { return _implementationGuide; }
            set
            {
                _implementationGuide = value;
                OnPropertyChanged("implementationGuide", value);
            }
        }

        public List<CapabilityStatementRest>? Rest
        {
            get { return _rest; }
            set
            {
                _rest = value;
                OnPropertyChanged("rest", value);
            }
        }

        public List<CapabilityStatementMessaging>? Messaging
        {
            get { return _messaging; }
            set
            {
                _messaging = value;
                OnPropertyChanged("messaging", value);
            }
        }

        public List<CapabilityStatementDocument>? Document
        {
            get { return _document; }
            set
            {
                _document = value;
                OnPropertyChanged("document", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatement() { }
        public CapabilityStatement(string value) : base(value) { }
        public CapabilityStatement(JsonNode? source) : base(source) { }
        #endregion
    }
    public class CapabilityStatementSoftware : BackboneElementType<CapabilityStatementSoftware>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _name;
        private FhirString? _version;
        private FhirDateTime? _releaseDate;

        #endregion
        #region public Method
        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        public FhirString? Version
        {
            get { return _version; }
            set
            {
                _version = value;
                OnPropertyChanged("version", value);
            }
        }

        public FhirDateTime? ReleaseDate
        {
            get { return _releaseDate; }
            set
            {
                _releaseDate = value;
                OnPropertyChanged("releaseDate", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementSoftware() { }
        public CapabilityStatementSoftware(string value) : base(value) { }
        public CapabilityStatementSoftware(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementImplementation : BackboneElementType<CapabilityStatementImplementation>, IBackboneElementType
    {

        #region Private Method
        private FhirMarkdown? _description;
        private FhirUrl? _url;
        private ReferenceType? _custodian;

        #endregion
        #region public Method
        public FhirMarkdown? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public FhirUrl? Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("url", value);
            }
        }

        public ReferenceType? Custodian
        {
            get { return _custodian; }
            set
            {
                _custodian = value;
                OnPropertyChanged("custodian", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementImplementation() { }
        public CapabilityStatementImplementation(string value) : base(value) { }
        public CapabilityStatementImplementation(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRestSecurity : BackboneElementType<CapabilityStatementRestSecurity>, IBackboneElementType
    {

        #region Private Method
        private FhirBoolean? _cors;
        private List<CodeableConcept>? _service;
        private FhirMarkdown? _description;

        #endregion
        #region public Method
        public FhirBoolean? Cors
        {
            get { return _cors; }
            set
            {
                _cors = value;
                OnPropertyChanged("cors", value);
            }
        }

        public List<CodeableConcept>? Service
        {
            get { return _service; }
            set
            {
                _service = value;
                OnPropertyChanged("service", value);
            }
        }

        public FhirMarkdown? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRestSecurity() { }
        public CapabilityStatementRestSecurity(string value) : base(value) { }
        public CapabilityStatementRestSecurity(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRestResourceInteraction : BackboneElementType<CapabilityStatementRestResourceInteraction>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _code;
        private FhirMarkdown? _documentation;

        #endregion
        #region public Method
        public FhirCode? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRestResourceInteraction() { }
        public CapabilityStatementRestResourceInteraction(string value) : base(value) { }
        public CapabilityStatementRestResourceInteraction(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRestSearchParam : BackboneElementType<CapabilityStatementRestSearchParam>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _name;
        private FhirCanonical? _definition;
        private FhirCode? _type;
        private FhirMarkdown? _documentation;

        #endregion
        #region public Method
        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        public FhirCanonical? Definition
        {
            get { return _definition; }
            set
            {
                _definition = value;
                OnPropertyChanged("definition", value);
            }
        }

        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRestSearchParam() { }
        public CapabilityStatementRestSearchParam(string value) : base(value) { }
        public CapabilityStatementRestSearchParam(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRestOperation : BackboneElementType<CapabilityStatementRestOperation>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _name;
        private FhirCanonical? _definition;
        private FhirMarkdown? _documentation;

        #endregion
        #region public Method
        public FhirString? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        public FhirCanonical? Definition
        {
            get { return _definition; }
            set
            {
                _definition = value;
                OnPropertyChanged("definition", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRestOperation() { }
        public CapabilityStatementRestOperation(string value) : base(value) { }
        public CapabilityStatementRestOperation(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRestResource : BackboneElementType<CapabilityStatementRestResource>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _type;
        private FhirCanonical? _profile;
        private List<FhirCanonical>? _supportedProfile;
        private FhirMarkdown? _documentation;
        private List<CapabilityStatementRestResourceInteraction>? _interaction;
        private FhirCode? _versioning;
        private FhirBoolean? _readHistory;
        private FhirBoolean? _updateCreate;
        private FhirBoolean? _conditionalCreate;
        private FhirCode? _conditionalRead;
        private FhirBoolean? _conditionalUpdate;
        private FhirBoolean? _conditionalPatch;
        private FhirCode? _conditionalDelete;
        private List<FhirCode>? _referencePolicy;
        private List<FhirString>? _searchInclude;
        private List<FhirString>? _searchRevInclude;
        private List<CapabilityStatementRestSearchParam>? _searchParam;
        private List<CapabilityStatementRestOperation>? _operation;

        #endregion
        #region public Method
        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        public FhirCanonical? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
            }
        }

        public List<FhirCanonical>? SupportedProfile
        {
            get { return _supportedProfile; }
            set
            {
                _supportedProfile = value;
                OnPropertyChanged("supportedProfile", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }

        public List<CapabilityStatementRestResourceInteraction>? Interaction
        {
            get { return _interaction; }
            set
            {
                _interaction = value;
                OnPropertyChanged("interaction", value);
            }
        }

        public FhirCode? Versioning
        {
            get { return _versioning; }
            set
            {
                _versioning = value;
                OnPropertyChanged("versioning", value);
            }
        }

        public FhirBoolean? ReadHistory
        {
            get { return _readHistory; }
            set
            {
                _readHistory = value;
                OnPropertyChanged("readHistory", value);
            }
        }

        public FhirBoolean? UpdateCreate
        {
            get { return _updateCreate; }
            set
            {
                _updateCreate = value;
                OnPropertyChanged("updateCreate", value);
            }
        }

        public FhirBoolean? ConditionalCreate
        {
            get { return _conditionalCreate; }
            set
            {
                _conditionalCreate = value;
                OnPropertyChanged("conditionalCreate", value);
            }
        }

        public FhirCode? ConditionalRead
        {
            get { return _conditionalRead; }
            set
            {
                _conditionalRead = value;
                OnPropertyChanged("conditionalRead", value);
            }
        }

        public FhirBoolean? ConditionalUpdate
        {
            get { return _conditionalUpdate; }
            set
            {
                _conditionalUpdate = value;
                OnPropertyChanged("conditionalUpdate", value);
            }
        }

        public FhirBoolean? ConditionalPatch
        {
            get { return _conditionalPatch; }
            set
            {
                _conditionalPatch = value;
                OnPropertyChanged("conditionalPatch", value);
            }
        }

        public FhirCode? ConditionalDelete
        {
            get { return _conditionalDelete; }
            set
            {
                _conditionalDelete = value;
                OnPropertyChanged("conditionalDelete", value);
            }
        }

        public List<FhirCode>? ReferencePolicy
        {
            get { return _referencePolicy; }
            set
            {
                _referencePolicy = value;
                OnPropertyChanged("referencePolicy", value);
            }
        }

        public List<FhirString>? SearchInclude
        {
            get { return _searchInclude; }
            set
            {
                _searchInclude = value;
                OnPropertyChanged("searchInclude", value);
            }
        }

        public List<FhirString>? SearchRevInclude
        {
            get { return _searchRevInclude; }
            set
            {
                _searchRevInclude = value;
                OnPropertyChanged("searchRevInclude", value);
            }
        }

        public List<CapabilityStatementRestSearchParam>? SearchParam
        {
            get { return _searchParam; }
            set
            {
                _searchParam = value;
                OnPropertyChanged("searchParam", value);
            }
        }

        public List<CapabilityStatementRestOperation>? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRestResource() { }
        public CapabilityStatementRestResource(string value) : base(value) { }
        public CapabilityStatementRestResource(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRestInteraction : BackboneElementType<CapabilityStatementRestInteraction>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _code;
        private FhirMarkdown? _documentation;

        #endregion
        #region public Method
        public FhirCode? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRestInteraction() { }
        public CapabilityStatementRestInteraction(string value) : base(value) { }
        public CapabilityStatementRestInteraction(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementRest : BackboneElementType<CapabilityStatementRest>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _mode;
        private FhirMarkdown? _documentation;
        private CapabilityStatementRestSecurity? _security;
        private List<CapabilityStatementRestResource>? _resource;
        private List<CapabilityStatementRestInteraction>? _interaction;
        private List<CapabilityStatementRestSearchParam>? _searchParam;
        private List<CapabilityStatementRestOperation>? _operation;
        private List<FhirCanonical>? _compartment;

        #endregion
        #region public Method
        public FhirCode? Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                OnPropertyChanged("mode", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }

        public CapabilityStatementRestSecurity? Security
        {
            get { return _security; }
            set
            {
                _security = value;
                OnPropertyChanged("security", value);
            }
        }

        public List<CapabilityStatementRestResource>? Resource
        {
            get { return _resource; }
            set
            {
                _resource = value;
                OnPropertyChanged("resource", value);
            }
        }

        public List<CapabilityStatementRestInteraction>? Interaction
        {
            get { return _interaction; }
            set
            {
                _interaction = value;
                OnPropertyChanged("interaction", value);
            }
        }
        public List<CapabilityStatementRestSearchParam>? SearchParam
        {
            get { return _searchParam; }
            set
            {
                _searchParam = value;
                OnPropertyChanged("searchParam", value);
            }
        }
        public List<CapabilityStatementRestOperation>? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }
        public List<FhirCanonical>? Compartment
        {
            get { return _compartment; }
            set
            {
                _compartment = value;
                OnPropertyChanged("compartment", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementRest() { }
        public CapabilityStatementRest(string value) : base(value) { }
        public CapabilityStatementRest(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementMessagingEndpoint : BackboneElementType<CapabilityStatementMessagingEndpoint>, IBackboneElementType
    {

        #region Private Method
        private Coding? _protocol;
        private FhirUrl? _address;

        #endregion
        #region public Method
        public Coding? Protocol
        {
            get { return _protocol; }
            set
            {
                _protocol = value;
                OnPropertyChanged("protocol", value);
            }
        }

        public FhirUrl? Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("address", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementMessagingEndpoint() { }
        public CapabilityStatementMessagingEndpoint(string value) : base(value) { }
        public CapabilityStatementMessagingEndpoint(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementMessagingSupportedMessage : BackboneElementType<CapabilityStatementMessagingSupportedMessage>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _mode;
        private FhirCanonical? _definition;

        #endregion
        #region public Method
        public FhirCode? Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                OnPropertyChanged("mode", value);
            }
        }

        public FhirCanonical? Definition
        {
            get { return _definition; }
            set
            {
                _definition = value;
                OnPropertyChanged("definition", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementMessagingSupportedMessage() { }
        public CapabilityStatementMessagingSupportedMessage(string value) : base(value) { }
        public CapabilityStatementMessagingSupportedMessage(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementMessaging : BackboneElementType<CapabilityStatementMessaging>, IBackboneElementType
    {

        #region Private Method
        private List<CapabilityStatementMessagingEndpoint>? _endpoint;
        private FhirUnsignedInt? _reliableCache;
        private FhirMarkdown? _documentation;
        private List<CapabilityStatementMessagingSupportedMessage>? _supportedMessage;

        #endregion
        #region public Method
        public List<CapabilityStatementMessagingEndpoint>? Endpoint
        {
            get { return _endpoint; }
            set
            {
                _endpoint = value;
                OnPropertyChanged("endpoint", value);
            }
        }

        public FhirUnsignedInt? ReliableCache
        {
            get { return _reliableCache; }
            set
            {
                _reliableCache = value;
                OnPropertyChanged("reliableCache", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }

        public List<CapabilityStatementMessagingSupportedMessage>? SupportedMessage
        {
            get { return _supportedMessage; }
            set
            {
                _supportedMessage = value;
                OnPropertyChanged("supportedMessage", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementMessaging() { }
        public CapabilityStatementMessaging(string value) : base(value) { }
        public CapabilityStatementMessaging(JsonObject? source) : base(source) { }
        #endregion
    }

    public class CapabilityStatementDocument : BackboneElementType<CapabilityStatementDocument>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _mode;
        private FhirMarkdown? _documentation;
        private FhirCanonical? _profile;

        #endregion
        #region public Method
        public FhirCode? Mode
        {
            get { return _mode; }
            set
            {
                _mode = value;
                OnPropertyChanged("mode", value);
            }
        }

        public FhirMarkdown? Documentation
        {
            get { return _documentation; }
            set
            {
                _documentation = value;
                OnPropertyChanged("documentation", value);
            }
        }

        public FhirCanonical? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
            }
        }


        #endregion
        #region Constructor
        public CapabilityStatementDocument() { }
        public CapabilityStatementDocument(string value) : base(value) { }
        public CapabilityStatementDocument(JsonObject? source) : base(source) { }
        #endregion
    }



    public class CapabilityStatementVersionAlgorithmChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public CapabilityStatementVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public CapabilityStatementVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public CapabilityStatementVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => "versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }


}
