using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class TestScript : ResourceType<TestScript>
    {
        #region private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private TestScriptVersionAlgorithmChoice? _versionAlgorithm;
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
        private List<TestScriptOrigin>? _origin;
        private List<TestScriptDestination>? _destination;
        private TestScriptMetadata? _metadata;
        private List<TestScriptScope>? _scope;
        private List<TestScriptFixture>? _fixture;
        private List<FhirCanonical>? _profile;
        private List<TestScriptVariable>? _variable;
        private TestScriptSetup? _setup;
        private List<TestScriptTest>? _test;
        private TestScriptTeardown? _teardown;

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

        public TestScriptVersionAlgorithmChoice? VersionAlgorithm
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

        public List<TestScriptOrigin>? Origin
        {
            get { return _origin; }
            set
            {
                _origin = value;
                OnPropertyChanged("origin", value);
            }
        }

        public List<TestScriptDestination>? Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
                OnPropertyChanged("destination", value);
            }
        }

        public TestScriptMetadata? Metadata
        {
            get { return _metadata; }
            set
            {
                _metadata = value;
                OnPropertyChanged("metadata", value);
            }
        }

        public List<TestScriptScope>? Scope
        {
            get { return _scope; }
            set
            {
                _scope = value;
                OnPropertyChanged("scope", value);
            }
        }

        public List<TestScriptFixture>? Fixture
        {
            get { return _fixture; }
            set
            {
                _fixture = value;
                OnPropertyChanged("fixture", value);
            }
        }

        public List<FhirCanonical>? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
            }
        }

        public List<TestScriptVariable>? Variable
        {
            get { return _variable; }
            set
            {
                _variable = value;
                OnPropertyChanged("variable", value);
            }
        }

        public TestScriptSetup? Setup
        {
            get { return _setup; }
            set
            {
                _setup = value;
                OnPropertyChanged("setup", value);
            }
        }

        public List<TestScriptTest>? Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("test", value);
            }
        }

        public TestScriptTeardown? Teardown
        {
            get { return _teardown; }
            set
            {
                _teardown = value;
                OnPropertyChanged("teardown", value);
            }
        }


        #endregion
        #region Constructor
        public TestScript() { }
        public TestScript(string value) : base(value) { }
        public TestScript(JsonNode? source) : base(source) { }
        #endregion
    }
    public class TestScriptOrigin : BackboneElementType<TestScriptOrigin>, IBackboneElementType
    {

        #region Private Method
        private FhirInteger? _index;
        private Coding? _profile;
        private FhirUrl? _url;

        #endregion
        #region public Method
        public FhirInteger? Index
        {
            get { return _index; }
            set
            {
                _index = value;
                OnPropertyChanged("index", value);
            }
        }

        public Coding? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
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


        #endregion
        #region Constructor
        public TestScriptOrigin() { }
        public TestScriptOrigin(string value) : base(value) { }
        public TestScriptOrigin(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptDestination : BackboneElementType<TestScriptDestination>, IBackboneElementType
    {

        #region Private Method
        private FhirInteger? _index;
        private Coding? _profile;
        private FhirUrl? _url;

        #endregion
        #region public Method
        public FhirInteger? Index
        {
            get { return _index; }
            set
            {
                _index = value;
                OnPropertyChanged("index", value);
            }
        }

        public Coding? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
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


        #endregion
        #region Constructor
        public TestScriptDestination() { }
        public TestScriptDestination(string value) : base(value) { }
        public TestScriptDestination(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptMetadataLink : BackboneElementType<TestScriptMetadataLink>, IBackboneElementType
    {

        #region Private Method
        private FhirUri? _url;
        private FhirString? _description;

        #endregion
        #region public Method
        public FhirUri? Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("url", value);
            }
        }

        public FhirString? Description
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
        public TestScriptMetadataLink() { }
        public TestScriptMetadataLink(string value) : base(value) { }
        public TestScriptMetadataLink(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptMetadataCapability : BackboneElementType<TestScriptMetadataCapability>, IBackboneElementType
    {

        #region Private Method
        private FhirBoolean? _required;
        private FhirBoolean? _validated;
        private FhirString? _description;
        private List<FhirInteger>? _origin;
        private FhirInteger? _destination;
        private List<FhirUri>? _link;
        private FhirCanonical? _capabilities;

        #endregion
        #region public Method
        public FhirBoolean? Required
        {
            get { return _required; }
            set
            {
                _required = value;
                OnPropertyChanged("required", value);
            }
        }

        public FhirBoolean? Validated
        {
            get { return _validated; }
            set
            {
                _validated = value;
                OnPropertyChanged("validated", value);
            }
        }

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public List<FhirInteger>? Origin
        {
            get { return _origin; }
            set
            {
                _origin = value;
                OnPropertyChanged("origin", value);
            }
        }

        public FhirInteger? Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
                OnPropertyChanged("destination", value);
            }
        }

        public List<FhirUri>? Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged("link", value);
            }
        }

        public FhirCanonical? Capabilities
        {
            get { return _capabilities; }
            set
            {
                _capabilities = value;
                OnPropertyChanged("capabilities", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptMetadataCapability() { }
        public TestScriptMetadataCapability(string value) : base(value) { }
        public TestScriptMetadataCapability(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptMetadata : BackboneElementType<TestScriptMetadata>, IBackboneElementType
    {

        #region Private Method
        private List<TestScriptMetadataLink>? _link;
        private List<TestScriptMetadataCapability>? _capability;

        #endregion
        #region public Method
        public List<TestScriptMetadataLink>? Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged("link", value);
            }
        }

        public List<TestScriptMetadataCapability>? Capability
        {
            get { return _capability; }
            set
            {
                _capability = value;
                OnPropertyChanged("capability", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptMetadata() { }
        public TestScriptMetadata(string value) : base(value) { }
        public TestScriptMetadata(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptScope : BackboneElementType<TestScriptScope>, IBackboneElementType
    {

        #region Private Method
        private FhirCanonical? _artifact;
        private CodeableConcept? _conformance;
        private CodeableConcept? _phase;

        #endregion
        #region public Method
        public FhirCanonical? Artifact
        {
            get { return _artifact; }
            set
            {
                _artifact = value;
                OnPropertyChanged("artifact", value);
            }
        }

        public CodeableConcept? Conformance
        {
            get { return _conformance; }
            set
            {
                _conformance = value;
                OnPropertyChanged("conformance", value);
            }
        }

        public CodeableConcept? Phase
        {
            get { return _phase; }
            set
            {
                _phase = value;
                OnPropertyChanged("phase", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptScope() { }
        public TestScriptScope(string value) : base(value) { }
        public TestScriptScope(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptFixture : BackboneElementType<TestScriptFixture>, IBackboneElementType
    {

        #region Private Method
        private FhirBoolean? _autocreate;
        private FhirBoolean? _autodelete;
        private ReferenceType? _resource;

        #endregion
        #region public Method
        public FhirBoolean? Autocreate
        {
            get { return _autocreate; }
            set
            {
                _autocreate = value;
                OnPropertyChanged("autocreate", value);
            }
        }

        public FhirBoolean? Autodelete
        {
            get { return _autodelete; }
            set
            {
                _autodelete = value;
                OnPropertyChanged("autodelete", value);
            }
        }

        public ReferenceType? Resource
        {
            get { return _resource; }
            set
            {
                _resource = value;
                OnPropertyChanged("resource", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptFixture() { }
        public TestScriptFixture(string value) : base(value) { }
        public TestScriptFixture(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptVariable : BackboneElementType<TestScriptVariable>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _name;
        private FhirString? _defaultValue;
        private FhirString? _description;
        private FhirString? _expression;
        private FhirString? _headerField;
        private FhirString? _hint;
        private FhirString? _path;
        private FhirId? _sourceId;

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

        public FhirString? DefaultValue
        {
            get { return _defaultValue; }
            set
            {
                _defaultValue = value;
                OnPropertyChanged("defaultValue", value);
            }
        }

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public FhirString? Expression
        {
            get { return _expression; }
            set
            {
                _expression = value;
                OnPropertyChanged("expression", value);
            }
        }

        public FhirString? HeaderField
        {
            get { return _headerField; }
            set
            {
                _headerField = value;
                OnPropertyChanged("headerField", value);
            }
        }

        public FhirString? Hint
        {
            get { return _hint; }
            set
            {
                _hint = value;
                OnPropertyChanged("hint", value);
            }
        }

        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }

        public FhirId? SourceId
        {
            get { return _sourceId; }
            set
            {
                _sourceId = value;
                OnPropertyChanged("sourceId", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptVariable() { }
        public TestScriptVariable(string value) : base(value) { }
        public TestScriptVariable(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptSetupActionOperationRequestHeader : BackboneElementType<TestScriptSetupActionOperationRequestHeader>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _field;
        private FhirString? _value;

        #endregion
        #region public Method
        public FhirString? Field
        {
            get { return _field; }
            set
            {
                _field = value;
                OnPropertyChanged("field", value);
            }
        }

        public FhirString? Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("value", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptSetupActionOperationRequestHeader() { }
        public TestScriptSetupActionOperationRequestHeader(string value) : base(value) { }
        public TestScriptSetupActionOperationRequestHeader(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptSetupActionOperation : BackboneElementType<TestScriptSetupActionOperation>, IBackboneElementType
    {

        #region Private Method
        private Coding? _type;
        private FhirUri? _resource;
        private FhirString? _label;
        private FhirString? _description;
        private FhirCode? _accept;
        private FhirCode? _contentType;
        private FhirInteger? _destination;
        private FhirBoolean? _encodeRequestUrl;
        private FhirCode? _method;
        private FhirInteger? _origin;
        private FhirString? _params;
        private List<TestScriptSetupActionOperationRequestHeader>? _requestHeader;
        private FhirId? _requestId;
        private FhirId? _responseId;
        private FhirId? _sourceId;
        private FhirId? _targetId;
        private FhirString? _url;

        #endregion
        #region public Method
        public Coding? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        public FhirUri? Resource
        {
            get { return _resource; }
            set
            {
                _resource = value;
                OnPropertyChanged("resource", value);
            }
        }

        public FhirString? Label
        {
            get { return _label; }
            set
            {
                _label = value;
                OnPropertyChanged("label", value);
            }
        }

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public FhirCode? Accept
        {
            get { return _accept; }
            set
            {
                _accept = value;
                OnPropertyChanged("accept", value);
            }
        }

        public FhirCode? ContentType
        {
            get { return _contentType; }
            set
            {
                _contentType = value;
                OnPropertyChanged("contentType", value);
            }
        }

        public FhirInteger? Destination
        {
            get { return _destination; }
            set
            {
                _destination = value;
                OnPropertyChanged("destination", value);
            }
        }

        public FhirBoolean? EncodeRequestUrl
        {
            get { return _encodeRequestUrl; }
            set
            {
                _encodeRequestUrl = value;
                OnPropertyChanged("encodeRequestUrl", value);
            }
        }

        public FhirCode? Method
        {
            get { return _method; }
            set
            {
                _method = value;
                OnPropertyChanged("method", value);
            }
        }

        public FhirInteger? Origin
        {
            get { return _origin; }
            set
            {
                _origin = value;
                OnPropertyChanged("origin", value);
            }
        }

        public FhirString? Params
        {
            get { return _params; }
            set
            {
                _params = value;
                OnPropertyChanged("params", value);
            }
        }

        public List<TestScriptSetupActionOperationRequestHeader>? RequestHeader
        {
            get { return _requestHeader; }
            set
            {
                _requestHeader = value;
                OnPropertyChanged("requestHeader", value);
            }
        }

        public FhirId? RequestId
        {
            get { return _requestId; }
            set
            {
                _requestId = value;
                OnPropertyChanged("requestId", value);
            }
        }

        public FhirId? ResponseId
        {
            get { return _responseId; }
            set
            {
                _responseId = value;
                OnPropertyChanged("responseId", value);
            }
        }

        public FhirId? SourceId
        {
            get { return _sourceId; }
            set
            {
                _sourceId = value;
                OnPropertyChanged("sourceId", value);
            }
        }

        public FhirId? TargetId
        {
            get { return _targetId; }
            set
            {
                _targetId = value;
                OnPropertyChanged("targetId", value);
            }
        }

        public FhirString? Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged("url", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptSetupActionOperation() { }
        public TestScriptSetupActionOperation(string value) : base(value) { }
        public TestScriptSetupActionOperation(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptSetupActionAssertRequirement : BackboneElementType<TestScriptSetupActionAssertRequirement>, IBackboneElementType
    {

        #region Private Method
        private TestScriptSetupActionAssertRequirementLinkChoice? _link;

        #endregion
        #region public Method
        public TestScriptSetupActionAssertRequirementLinkChoice? Link
        {
            get { return _link; }
            set
            {
                _link = value;
                OnPropertyChanged("link", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptSetupActionAssertRequirement() { }
        public TestScriptSetupActionAssertRequirement(string value) : base(value) { }
        public TestScriptSetupActionAssertRequirement(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptSetupActionAssert : BackboneElementType<TestScriptSetupActionAssert>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _label;
        private FhirString? _description;
        private FhirCode? _direction;
        private FhirString? _compareToSourceId;
        private FhirString? _compareToSourceExpression;
        private FhirString? _compareToSourcePath;
        private FhirCode? _contentType;
        private FhirCode? _defaultManualCompletion;
        private FhirString? _expression;
        private FhirString? _headerField;
        private FhirString? _minimumId;
        private FhirBoolean? _navigationLinks;
        private FhirCode? _operator;
        private FhirString? _path;
        private FhirCode? _requestMethod;
        private FhirString? _requestURL;
        private FhirUri? _resource;
        private FhirCode? _response;
        private FhirString? _responseCode;
        private FhirId? _sourceId;
        private FhirBoolean? _stopTestOnFail;
        private FhirId? _validateProfileId;
        private FhirString? _value;
        private FhirBoolean? _warningOnly;
        private List<TestScriptSetupActionAssertRequirement>? _requirement;

        #endregion
        #region public Method
        public FhirString? Label
        {
            get { return _label; }
            set
            {
                _label = value;
                OnPropertyChanged("label", value);
            }
        }

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public FhirCode? Direction
        {
            get { return _direction; }
            set
            {
                _direction = value;
                OnPropertyChanged("direction", value);
            }
        }

        public FhirString? CompareToSourceId
        {
            get { return _compareToSourceId; }
            set
            {
                _compareToSourceId = value;
                OnPropertyChanged("compareToSourceId", value);
            }
        }

        public FhirString? CompareToSourceExpression
        {
            get { return _compareToSourceExpression; }
            set
            {
                _compareToSourceExpression = value;
                OnPropertyChanged("compareToSourceExpression", value);
            }
        }

        public FhirString? CompareToSourcePath
        {
            get { return _compareToSourcePath; }
            set
            {
                _compareToSourcePath = value;
                OnPropertyChanged("compareToSourcePath", value);
            }
        }

        public FhirCode? ContentType
        {
            get { return _contentType; }
            set
            {
                _contentType = value;
                OnPropertyChanged("contentType", value);
            }
        }

        public FhirCode? DefaultManualCompletion
        {
            get { return _defaultManualCompletion; }
            set
            {
                _defaultManualCompletion = value;
                OnPropertyChanged("defaultManualCompletion", value);
            }
        }

        public FhirString? Expression
        {
            get { return _expression; }
            set
            {
                _expression = value;
                OnPropertyChanged("expression", value);
            }
        }

        public FhirString? HeaderField
        {
            get { return _headerField; }
            set
            {
                _headerField = value;
                OnPropertyChanged("headerField", value);
            }
        }

        public FhirString? MinimumId
        {
            get { return _minimumId; }
            set
            {
                _minimumId = value;
                OnPropertyChanged("minimumId", value);
            }
        }

        public FhirBoolean? NavigationLinks
        {
            get { return _navigationLinks; }
            set
            {
                _navigationLinks = value;
                OnPropertyChanged("navigationLinks", value);
            }
        }

        public FhirCode? Operator
        {
            get { return _operator; }
            set
            {
                _operator = value;
                OnPropertyChanged("operator", value);
            }
        }

        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }

        public FhirCode? RequestMethod
        {
            get { return _requestMethod; }
            set
            {
                _requestMethod = value;
                OnPropertyChanged("requestMethod", value);
            }
        }

        public FhirString? RequestURL
        {
            get { return _requestURL; }
            set
            {
                _requestURL = value;
                OnPropertyChanged("requestURL", value);
            }
        }

        public FhirUri? Resource
        {
            get { return _resource; }
            set
            {
                _resource = value;
                OnPropertyChanged("resource", value);
            }
        }

        public FhirCode? Response
        {
            get { return _response; }
            set
            {
                _response = value;
                OnPropertyChanged("response", value);
            }
        }

        public FhirString? ResponseCode
        {
            get { return _responseCode; }
            set
            {
                _responseCode = value;
                OnPropertyChanged("responseCode", value);
            }
        }

        public FhirId? SourceId
        {
            get { return _sourceId; }
            set
            {
                _sourceId = value;
                OnPropertyChanged("sourceId", value);
            }
        }

        public FhirBoolean? StopTestOnFail
        {
            get { return _stopTestOnFail; }
            set
            {
                _stopTestOnFail = value;
                OnPropertyChanged("stopTestOnFail", value);
            }
        }

        public FhirId? ValidateProfileId
        {
            get { return _validateProfileId; }
            set
            {
                _validateProfileId = value;
                OnPropertyChanged("validateProfileId", value);
            }
        }

        public FhirString? Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("value", value);
            }
        }

        public FhirBoolean? WarningOnly
        {
            get { return _warningOnly; }
            set
            {
                _warningOnly = value;
                OnPropertyChanged("warningOnly", value);
            }
        }

        public List<TestScriptSetupActionAssertRequirement>? Requirement
        {
            get { return _requirement; }
            set
            {
                _requirement = value;
                OnPropertyChanged("requirement", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptSetupActionAssert() { }
        public TestScriptSetupActionAssert(string value) : base(value) { }
        public TestScriptSetupActionAssert(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptSetupAction : BackboneElementType<TestScriptSetupAction>, IBackboneElementType
    {

        #region Private Method
        private TestScriptSetupActionOperation? _operation;
        private TestScriptSetupActionAssert? _assert;

        #endregion
        #region public Method
        public TestScriptSetupActionOperation? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }

        public TestScriptSetupActionAssert? Assert
        {
            get { return _assert; }
            set
            {
                _assert = value;
                OnPropertyChanged("assert", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptSetupAction() { }
        public TestScriptSetupAction(string value) : base(value) { }
        public TestScriptSetupAction(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptSetup : BackboneElementType<TestScriptSetup>, IBackboneElementType
    {

        #region Private Method
        private List<TestScriptSetupAction>? _action;

        #endregion
        #region public Method
        public List<TestScriptSetupAction>? Action
        {
            get { return _action; }
            set
            {
                _action = value;
                OnPropertyChanged("action", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptSetup() { }
        public TestScriptSetup(string value) : base(value) { }
        public TestScriptSetup(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptTest : BackboneElementType<TestScriptTest>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _name;
        private FhirString? _description;
        private List<TestScriptTestAction>? _action;

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

        public FhirString? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("description", value);
            }
        }

        public List<TestScriptTestAction>? Action
        {
            get { return _action; }
            set
            {
                _action = value;
                OnPropertyChanged("action", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptTest() { }
        public TestScriptTest(string value) : base(value) { }
        public TestScriptTest(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptTestAction : BackboneElementType<TestScriptTestAction>, IBackboneElementType
    {
        private TestScriptSetupActionOperation? _operation;
        private TestScriptSetupActionAssert? _assert;

        public TestScriptSetupActionOperation? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }
        public TestScriptSetupActionAssert? Assert
        {
            get { return _assert; }
            set
            {
                _assert = value;
                OnPropertyChanged("assert", value);
            }
        }
        public TestScriptTestAction() { }
        public TestScriptTestAction(string value) : base(value) { }
        public TestScriptTestAction(JsonObject? source) : base(source) { }
    }

    public class TestScriptTeardown : BackboneElementType<TestScriptTeardown>, IBackboneElementType
    {

        #region Private Method
        private List<TestScriptTeardownAction>? _action;

        #endregion
        #region public Method
        public List<TestScriptTeardownAction>? Action
        {
            get { return _action; }
            set
            {
                _action = value;
                OnPropertyChanged("action", value);
            }
        }


        #endregion
        #region Constructor
        public TestScriptTeardown() { }
        public TestScriptTeardown(string value) : base(value) { }
        public TestScriptTeardown(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestScriptTeardownAction: BackboneElementType<TestScriptTeardownAction>, IBackboneElementType
    {
        private TestScriptSetupActionOperation? _operation;
        public TestScriptSetupActionOperation? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }
        public TestScriptTeardownAction() { }
        public TestScriptTeardownAction(string value) : base(value) { }
        public TestScriptTeardownAction(JsonObject? source) : base(source) { }
    }

    public class TestScriptVersionAlgorithmChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public TestScriptVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public TestScriptVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public TestScriptVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => "versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
    public class TestScriptSetupActionAssertRequirementLinkChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "uri","canonical(Requirements)"
        ];

        public TestScriptSetupActionAssertRequirementLinkChoice(JsonObject value) : base("link", value, _supportType)
        {
        }
        public TestScriptSetupActionAssertRequirementLinkChoice(IComplexType? value) : base("link", value)
        {
        }
        public TestScriptSetupActionAssertRequirementLinkChoice(IPrimitiveType? value) : base("link", value) { }

        public override string GetPrefixName(bool withCapital = true) => "link".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }


}
