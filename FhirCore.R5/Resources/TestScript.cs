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
    /// FHIR R5 TestScript 資源
    /// 
    /// <para>
    /// TestScript 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var testscript = new TestScript("testscript-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 TestScript 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class TestScript : ResourceBase<R5Version>
    {
        private Property
        private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private TestScriptVersionAlgorithmChoice? _versionalgorithm;
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
        private FhirInteger? _index;
        private Coding? _profile;
        private FhirUrl? _url;
        private FhirInteger? _index;
        private Coding? _profile;
        private FhirUrl? _url;
        private FhirUri? _url;
        private FhirString? _description;
        private FhirBoolean? _required;
        private FhirBoolean? _validated;
        private FhirString? _description;
        private List<FhirInteger>? _origin;
        private FhirInteger? _destination;
        private List<FhirUri>? _link;
        private FhirCanonical? _capabilities;
        private List<TestScriptMetadataLink>? _link;
        private List<TestScriptMetadataCapability>? _capability;
        private FhirCanonical? _artifact;
        private CodeableConcept? _conformance;
        private CodeableConcept? _phase;
        private FhirBoolean? _autocreate;
        private FhirBoolean? _autodelete;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _resource;
        private FhirString? _name;
        private FhirString? _defaultvalue;
        private FhirString? _description;
        private FhirString? _expression;
        private FhirString? _headerfield;
        private FhirString? _hint;
        private FhirString? _path;
        private FhirId? _sourceid;
        private FhirString? _field;
        private FhirString? _value;
        private Coding? _type;
        private FhirUri? _resource;
        private FhirString? _label;
        private FhirString? _description;
        private FhirCode? _accept;
        private FhirCode? _contenttype;
        private FhirInteger? _destination;
        private FhirBoolean? _encoderequesturl;
        private FhirCode? _method;
        private FhirInteger? _origin;
        private FhirString? _params;
        private List<TestScriptSetupActionOperationRequestHeader>? _requestheader;
        private FhirId? _requestid;
        private FhirId? _responseid;
        private FhirId? _sourceid;
        private FhirId? _targetid;
        private FhirString? _url;
        private TestScriptSetupActionAssertRequirementLinkChoice? _link;
        private FhirString? _label;
        private FhirString? _description;
        private FhirCode? _direction;
        private FhirString? _comparetosourceid;
        private FhirString? _comparetosourceexpression;
        private FhirString? _comparetosourcepath;
        private FhirCode? _contenttype;
        private FhirCode? _defaultmanualcompletion;
        private FhirString? _expression;
        private FhirString? _headerfield;
        private FhirString? _minimumid;
        private FhirBoolean? _navigationlinks;
        private FhirCode? _operator;
        private FhirString? _path;
        private FhirCode? _requestmethod;
        private FhirString? _requesturl;
        private FhirUri? _resource;
        private FhirCode? _response;
        private FhirString? _responsecode;
        private FhirId? _sourceid;
        private FhirBoolean? _stoptestonfail;
        private FhirId? _validateprofileid;
        private FhirString? _value;
        private FhirBoolean? _warningonly;
        private List<TestScriptSetupActionAssertRequirement>? _requirement;
        private TestScriptSetupActionOperation? _operation;
        private TestScriptSetupActionAssert? _assert;
        private List<TestScriptSetupAction>? _action;
        private FhirString? _name;
        private FhirString? _description;
        private List<TestScriptTestAction>? _action;
        private TestScriptSetupActionOperation? _operation;
        private TestScriptSetupActionAssert? _assert;
        private List<TestScriptTeardownAction>? _action;
        private TestScriptSetupActionOperation? _operation;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "TestScript";        /// <summary>
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
        public TestScriptVersionAlgorithmChoice? Versionalgorithm
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
        /// Origin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Origin 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptOrigin>? Origin
        {
            get => _origin;
            set
            {
                _origin = value;
                OnPropertyChanged(nameof(Origin));
            }
        }        /// <summary>
        /// Destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Destination 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptDestination>? Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }        /// <summary>
        /// Metadata
        /// </summary>
        /// <remarks>
        /// <para>
        /// Metadata 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptMetadata? Metadata
        {
            get => _metadata;
            set
            {
                _metadata = value;
                OnPropertyChanged(nameof(Metadata));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptScope>? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Fixture
        /// </summary>
        /// <remarks>
        /// <para>
        /// Fixture 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptFixture>? Fixture
        {
            get => _fixture;
            set
            {
                _fixture = value;
                OnPropertyChanged(nameof(Fixture));
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
        /// Variable
        /// </summary>
        /// <remarks>
        /// <para>
        /// Variable 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptVariable>? Variable
        {
            get => _variable;
            set
            {
                _variable = value;
                OnPropertyChanged(nameof(Variable));
            }
        }        /// <summary>
        /// Setup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Setup 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetup? Setup
        {
            get => _setup;
            set
            {
                _setup = value;
                OnPropertyChanged(nameof(Setup));
            }
        }        /// <summary>
        /// Test
        /// </summary>
        /// <remarks>
        /// <para>
        /// Test 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptTest>? Test
        {
            get => _test;
            set
            {
                _test = value;
                OnPropertyChanged(nameof(Test));
            }
        }        /// <summary>
        /// Teardown
        /// </summary>
        /// <remarks>
        /// <para>
        /// Teardown 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptTeardown? Teardown
        {
            get => _teardown;
            set
            {
                _teardown = value;
                OnPropertyChanged(nameof(Teardown));
            }
        }        /// <summary>
        /// Index
        /// </summary>
        /// <remarks>
        /// <para>
        /// Index 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Index
        {
            get => _index;
            set
            {
                _index = value;
                OnPropertyChanged(nameof(Index));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
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
        /// Index
        /// </summary>
        /// <remarks>
        /// <para>
        /// Index 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Index
        {
            get => _index;
            set
            {
                _index = value;
                OnPropertyChanged(nameof(Index));
            }
        }        /// <summary>
        /// Profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// Profile 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(Profile));
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
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Required
        /// </summary>
        /// <remarks>
        /// <para>
        /// Required 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Required
        {
            get => _required;
            set
            {
                _required = value;
                OnPropertyChanged(nameof(Required));
            }
        }        /// <summary>
        /// Validated
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validated 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Validated
        {
            get => _validated;
            set
            {
                _validated = value;
                OnPropertyChanged(nameof(Validated));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Origin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Origin 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirInteger>? Origin
        {
            get => _origin;
            set
            {
                _origin = value;
                OnPropertyChanged(nameof(Origin));
            }
        }        /// <summary>
        /// Destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Destination 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// Capabilities
        /// </summary>
        /// <remarks>
        /// <para>
        /// Capabilities 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Capabilities
        {
            get => _capabilities;
            set
            {
                _capabilities = value;
                OnPropertyChanged(nameof(Capabilities));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptMetadataLink>? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// Capability
        /// </summary>
        /// <remarks>
        /// <para>
        /// Capability 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptMetadataCapability>? Capability
        {
            get => _capability;
            set
            {
                _capability = value;
                OnPropertyChanged(nameof(Capability));
            }
        }        /// <summary>
        /// Artifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Artifact 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Artifact
        {
            get => _artifact;
            set
            {
                _artifact = value;
                OnPropertyChanged(nameof(Artifact));
            }
        }        /// <summary>
        /// Conformance
        /// </summary>
        /// <remarks>
        /// <para>
        /// Conformance 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Conformance
        {
            get => _conformance;
            set
            {
                _conformance = value;
                OnPropertyChanged(nameof(Conformance));
            }
        }        /// <summary>
        /// Phase
        /// </summary>
        /// <remarks>
        /// <para>
        /// Phase 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Phase
        {
            get => _phase;
            set
            {
                _phase = value;
                OnPropertyChanged(nameof(Phase));
            }
        }        /// <summary>
        /// Autocreate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Autocreate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Autocreate
        {
            get => _autocreate;
            set
            {
                _autocreate = value;
                OnPropertyChanged(nameof(Autocreate));
            }
        }        /// <summary>
        /// Autodelete
        /// </summary>
        /// <remarks>
        /// <para>
        /// Autodelete 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Autodelete
        {
            get => _autodelete;
            set
            {
                _autodelete = value;
                OnPropertyChanged(nameof(Autodelete));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
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
        /// Defaultvalue
        /// </summary>
        /// <remarks>
        /// <para>
        /// Defaultvalue 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Defaultvalue
        {
            get => _defaultvalue;
            set
            {
                _defaultvalue = value;
                OnPropertyChanged(nameof(Defaultvalue));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Headerfield
        /// </summary>
        /// <remarks>
        /// <para>
        /// Headerfield 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Headerfield
        {
            get => _headerfield;
            set
            {
                _headerfield = value;
                OnPropertyChanged(nameof(Headerfield));
            }
        }        /// <summary>
        /// Hint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hint 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Hint
        {
            get => _hint;
            set
            {
                _hint = value;
                OnPropertyChanged(nameof(Hint));
            }
        }        /// <summary>
        /// Path
        /// </summary>
        /// <remarks>
        /// <para>
        /// Path 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }        /// <summary>
        /// Sourceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Sourceid
        {
            get => _sourceid;
            set
            {
                _sourceid = value;
                OnPropertyChanged(nameof(Sourceid));
            }
        }        /// <summary>
        /// Field
        /// </summary>
        /// <remarks>
        /// <para>
        /// Field 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Field
        {
            get => _field;
            set
            {
                _field = value;
                OnPropertyChanged(nameof(Field));
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
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public Coding? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Label
        /// </summary>
        /// <remarks>
        /// <para>
        /// Label 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Accept
        /// </summary>
        /// <remarks>
        /// <para>
        /// Accept 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Accept
        {
            get => _accept;
            set
            {
                _accept = value;
                OnPropertyChanged(nameof(Accept));
            }
        }        /// <summary>
        /// Contenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Contenttype
        {
            get => _contenttype;
            set
            {
                _contenttype = value;
                OnPropertyChanged(nameof(Contenttype));
            }
        }        /// <summary>
        /// Destination
        /// </summary>
        /// <remarks>
        /// <para>
        /// Destination 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Destination
        {
            get => _destination;
            set
            {
                _destination = value;
                OnPropertyChanged(nameof(Destination));
            }
        }        /// <summary>
        /// Encoderequesturl
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encoderequesturl 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Encoderequesturl
        {
            get => _encoderequesturl;
            set
            {
                _encoderequesturl = value;
                OnPropertyChanged(nameof(Encoderequesturl));
            }
        }        /// <summary>
        /// Method
        /// </summary>
        /// <remarks>
        /// <para>
        /// Method 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(Method));
            }
        }        /// <summary>
        /// Origin
        /// </summary>
        /// <remarks>
        /// <para>
        /// Origin 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Origin
        {
            get => _origin;
            set
            {
                _origin = value;
                OnPropertyChanged(nameof(Origin));
            }
        }        /// <summary>
        /// Params
        /// </summary>
        /// <remarks>
        /// <para>
        /// Params 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Params
        {
            get => _params;
            set
            {
                _params = value;
                OnPropertyChanged(nameof(Params));
            }
        }        /// <summary>
        /// Requestheader
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestheader 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptSetupActionOperationRequestHeader>? Requestheader
        {
            get => _requestheader;
            set
            {
                _requestheader = value;
                OnPropertyChanged(nameof(Requestheader));
            }
        }        /// <summary>
        /// Requestid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Requestid
        {
            get => _requestid;
            set
            {
                _requestid = value;
                OnPropertyChanged(nameof(Requestid));
            }
        }        /// <summary>
        /// Responseid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responseid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Responseid
        {
            get => _responseid;
            set
            {
                _responseid = value;
                OnPropertyChanged(nameof(Responseid));
            }
        }        /// <summary>
        /// Sourceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Sourceid
        {
            get => _sourceid;
            set
            {
                _sourceid = value;
                OnPropertyChanged(nameof(Sourceid));
            }
        }        /// <summary>
        /// Targetid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Targetid
        {
            get => _targetid;
            set
            {
                _targetid = value;
                OnPropertyChanged(nameof(Targetid));
            }
        }        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetupActionAssertRequirementLinkChoice? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// Label
        /// </summary>
        /// <remarks>
        /// <para>
        /// Label 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged(nameof(Label));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Direction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Direction 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Direction
        {
            get => _direction;
            set
            {
                _direction = value;
                OnPropertyChanged(nameof(Direction));
            }
        }        /// <summary>
        /// Comparetosourceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparetosourceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comparetosourceid
        {
            get => _comparetosourceid;
            set
            {
                _comparetosourceid = value;
                OnPropertyChanged(nameof(Comparetosourceid));
            }
        }        /// <summary>
        /// Comparetosourceexpression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparetosourceexpression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comparetosourceexpression
        {
            get => _comparetosourceexpression;
            set
            {
                _comparetosourceexpression = value;
                OnPropertyChanged(nameof(Comparetosourceexpression));
            }
        }        /// <summary>
        /// Comparetosourcepath
        /// </summary>
        /// <remarks>
        /// <para>
        /// Comparetosourcepath 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Comparetosourcepath
        {
            get => _comparetosourcepath;
            set
            {
                _comparetosourcepath = value;
                OnPropertyChanged(nameof(Comparetosourcepath));
            }
        }        /// <summary>
        /// Contenttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contenttype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Contenttype
        {
            get => _contenttype;
            set
            {
                _contenttype = value;
                OnPropertyChanged(nameof(Contenttype));
            }
        }        /// <summary>
        /// Defaultmanualcompletion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Defaultmanualcompletion 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Defaultmanualcompletion
        {
            get => _defaultmanualcompletion;
            set
            {
                _defaultmanualcompletion = value;
                OnPropertyChanged(nameof(Defaultmanualcompletion));
            }
        }        /// <summary>
        /// Expression
        /// </summary>
        /// <remarks>
        /// <para>
        /// Expression 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Expression
        {
            get => _expression;
            set
            {
                _expression = value;
                OnPropertyChanged(nameof(Expression));
            }
        }        /// <summary>
        /// Headerfield
        /// </summary>
        /// <remarks>
        /// <para>
        /// Headerfield 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Headerfield
        {
            get => _headerfield;
            set
            {
                _headerfield = value;
                OnPropertyChanged(nameof(Headerfield));
            }
        }        /// <summary>
        /// Minimumid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Minimumid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Minimumid
        {
            get => _minimumid;
            set
            {
                _minimumid = value;
                OnPropertyChanged(nameof(Minimumid));
            }
        }        /// <summary>
        /// Navigationlinks
        /// </summary>
        /// <remarks>
        /// <para>
        /// Navigationlinks 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Navigationlinks
        {
            get => _navigationlinks;
            set
            {
                _navigationlinks = value;
                OnPropertyChanged(nameof(Navigationlinks));
            }
        }        /// <summary>
        /// Operator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Operator
        {
            get => _operator;
            set
            {
                _operator = value;
                OnPropertyChanged(nameof(Operator));
            }
        }        /// <summary>
        /// Path
        /// </summary>
        /// <remarks>
        /// <para>
        /// Path 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Path
        {
            get => _path;
            set
            {
                _path = value;
                OnPropertyChanged(nameof(Path));
            }
        }        /// <summary>
        /// Requestmethod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requestmethod 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Requestmethod
        {
            get => _requestmethod;
            set
            {
                _requestmethod = value;
                OnPropertyChanged(nameof(Requestmethod));
            }
        }        /// <summary>
        /// Requesturl
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requesturl 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Requesturl
        {
            get => _requesturl;
            set
            {
                _requesturl = value;
                OnPropertyChanged(nameof(Requesturl));
            }
        }        /// <summary>
        /// Resource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Resource 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Resource
        {
            get => _resource;
            set
            {
                _resource = value;
                OnPropertyChanged(nameof(Resource));
            }
        }        /// <summary>
        /// Response
        /// </summary>
        /// <remarks>
        /// <para>
        /// Response 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Response
        {
            get => _response;
            set
            {
                _response = value;
                OnPropertyChanged(nameof(Response));
            }
        }        /// <summary>
        /// Responsecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Responsecode 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Responsecode
        {
            get => _responsecode;
            set
            {
                _responsecode = value;
                OnPropertyChanged(nameof(Responsecode));
            }
        }        /// <summary>
        /// Sourceid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sourceid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Sourceid
        {
            get => _sourceid;
            set
            {
                _sourceid = value;
                OnPropertyChanged(nameof(Sourceid));
            }
        }        /// <summary>
        /// Stoptestonfail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stoptestonfail 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Stoptestonfail
        {
            get => _stoptestonfail;
            set
            {
                _stoptestonfail = value;
                OnPropertyChanged(nameof(Stoptestonfail));
            }
        }        /// <summary>
        /// Validateprofileid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Validateprofileid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Validateprofileid
        {
            get => _validateprofileid;
            set
            {
                _validateprofileid = value;
                OnPropertyChanged(nameof(Validateprofileid));
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
        /// Warningonly
        /// </summary>
        /// <remarks>
        /// <para>
        /// Warningonly 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Warningonly
        {
            get => _warningonly;
            set
            {
                _warningonly = value;
                OnPropertyChanged(nameof(Warningonly));
            }
        }        /// <summary>
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptSetupActionAssertRequirement>? Requirement
        {
            get => _requirement;
            set
            {
                _requirement = value;
                OnPropertyChanged(nameof(Requirement));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetupActionOperation? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// Assert
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assert 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetupActionAssert? Assert
        {
            get => _assert;
            set
            {
                _assert = value;
                OnPropertyChanged(nameof(Assert));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptSetupAction>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
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
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptTestAction>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetupActionOperation? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// Assert
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assert 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetupActionAssert? Assert
        {
            get => _assert;
            set
            {
                _assert = value;
                OnPropertyChanged(nameof(Assert));
            }
        }        /// <summary>
        /// Action
        /// </summary>
        /// <remarks>
        /// <para>
        /// Action 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestScriptTeardownAction>? Action
        {
            get => _action;
            set
            {
                _action = value;
                OnPropertyChanged(nameof(Action));
            }
        }        /// <summary>
        /// Operation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operation 的詳細描述。
        /// </para>
        /// </remarks>
        public TestScriptSetupActionOperation? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// 建立新的 TestScript 資源實例
        /// </summary>
        public TestScript()
        {
        }

        /// <summary>
        /// 建立新的 TestScript 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public TestScript(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"TestScript(Id: {Id})";
        }
    }    /// <summary>
    /// TestScriptOrigin 背骨元素
    /// </summary>
    public class TestScriptOrigin
    {
        // TODO: 添加屬性實作
        
        public TestScriptOrigin() { }
    }    /// <summary>
    /// TestScriptDestination 背骨元素
    /// </summary>
    public class TestScriptDestination
    {
        // TODO: 添加屬性實作
        
        public TestScriptDestination() { }
    }    /// <summary>
    /// TestScriptMetadataLink 背骨元素
    /// </summary>
    public class TestScriptMetadataLink
    {
        // TODO: 添加屬性實作
        
        public TestScriptMetadataLink() { }
    }    /// <summary>
    /// TestScriptMetadataCapability 背骨元素
    /// </summary>
    public class TestScriptMetadataCapability
    {
        // TODO: 添加屬性實作
        
        public TestScriptMetadataCapability() { }
    }    /// <summary>
    /// TestScriptMetadata 背骨元素
    /// </summary>
    public class TestScriptMetadata
    {
        // TODO: 添加屬性實作
        
        public TestScriptMetadata() { }
    }    /// <summary>
    /// TestScriptScope 背骨元素
    /// </summary>
    public class TestScriptScope
    {
        // TODO: 添加屬性實作
        
        public TestScriptScope() { }
    }    /// <summary>
    /// TestScriptFixture 背骨元素
    /// </summary>
    public class TestScriptFixture
    {
        // TODO: 添加屬性實作
        
        public TestScriptFixture() { }
    }    /// <summary>
    /// TestScriptVariable 背骨元素
    /// </summary>
    public class TestScriptVariable
    {
        // TODO: 添加屬性實作
        
        public TestScriptVariable() { }
    }    /// <summary>
    /// TestScriptSetupActionOperationRequestHeader 背骨元素
    /// </summary>
    public class TestScriptSetupActionOperationRequestHeader
    {
        // TODO: 添加屬性實作
        
        public TestScriptSetupActionOperationRequestHeader() { }
    }    /// <summary>
    /// TestScriptSetupActionOperation 背骨元素
    /// </summary>
    public class TestScriptSetupActionOperation
    {
        // TODO: 添加屬性實作
        
        public TestScriptSetupActionOperation() { }
    }    /// <summary>
    /// TestScriptSetupActionAssertRequirement 背骨元素
    /// </summary>
    public class TestScriptSetupActionAssertRequirement
    {
        // TODO: 添加屬性實作
        
        public TestScriptSetupActionAssertRequirement() { }
    }    /// <summary>
    /// TestScriptSetupActionAssert 背骨元素
    /// </summary>
    public class TestScriptSetupActionAssert
    {
        // TODO: 添加屬性實作
        
        public TestScriptSetupActionAssert() { }
    }    /// <summary>
    /// TestScriptSetupAction 背骨元素
    /// </summary>
    public class TestScriptSetupAction
    {
        // TODO: 添加屬性實作
        
        public TestScriptSetupAction() { }
    }    /// <summary>
    /// TestScriptSetup 背骨元素
    /// </summary>
    public class TestScriptSetup
    {
        // TODO: 添加屬性實作
        
        public TestScriptSetup() { }
    }    /// <summary>
    /// TestScriptTest 背骨元素
    /// </summary>
    public class TestScriptTest
    {
        // TODO: 添加屬性實作
        
        public TestScriptTest() { }
    }    /// <summary>
    /// TestScriptTestAction 背骨元素
    /// </summary>
    public class TestScriptTestAction
    {
        // TODO: 添加屬性實作
        
        public TestScriptTestAction() { }
    }    /// <summary>
    /// TestScriptTeardown 背骨元素
    /// </summary>
    public class TestScriptTeardown
    {
        // TODO: 添加屬性實作
        
        public TestScriptTeardown() { }
    }    /// <summary>
    /// TestScriptVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class TestScriptVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TestScriptVersionAlgorithmChoice(JsonObject value) : base("testscriptversionalgorithm", value, _supportType) { }
        public TestScriptVersionAlgorithmChoice(IComplexType? value) : base("testscriptversionalgorithm", value) { }
        public TestScriptVersionAlgorithmChoice(IPrimitiveType? value) : base("testscriptversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TestScriptVersionAlgorithm" : "testscriptversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// TestScriptSetupActionAssertRequirementLinkChoice 選擇類型
    /// </summary>
    public class TestScriptSetupActionAssertRequirementLinkChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TestScriptSetupActionAssertRequirementLinkChoice(JsonObject value) : base("testscriptsetupactionassertrequirementlink", value, _supportType) { }
        public TestScriptSetupActionAssertRequirementLinkChoice(IComplexType? value) : base("testscriptsetupactionassertrequirementlink", value) { }
        public TestScriptSetupActionAssertRequirementLinkChoice(IPrimitiveType? value) : base("testscriptsetupactionassertrequirementlink", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TestScriptSetupActionAssertRequirementLink" : "testscriptsetupactionassertrequirementlink";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
