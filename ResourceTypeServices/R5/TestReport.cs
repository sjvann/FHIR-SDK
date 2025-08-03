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
    public class TestReport : ResourceType<TestReport>
    {
        #region private Property
        private Identifier? _identifier;
        private FhirString? _name;
        private FhirCode? _status;
        private FhirCanonical? _testScript;
        private FhirCode? _result;
        private FhirDecimal? _score;
        private FhirString? _tester;
        private FhirDateTime? _issued;
        private List<TestReportParticipant>? _participant;
        private TestReportSetup? _setup;
        private List<TestReportTest>? _test;
        private TestReportTeardown? _teardown;

        #endregion
        #region Public Method
        public Identifier? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
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

        public FhirCode? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }

        public FhirCanonical? TestScript
        {
            get { return _testScript; }
            set
            {
                _testScript = value;
                OnPropertyChanged("testScript", value);
            }
        }

        public FhirCode? Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("result", value);
            }
        }

        public FhirDecimal? Score
        {
            get { return _score; }
            set
            {
                _score = value;
                OnPropertyChanged("score", value);
            }
        }

        public FhirString? Tester
        {
            get { return _tester; }
            set
            {
                _tester = value;
                OnPropertyChanged("tester", value);
            }
        }

        public FhirDateTime? Issued
        {
            get { return _issued; }
            set
            {
                _issued = value;
                OnPropertyChanged("issued", value);
            }
        }

        public List<TestReportParticipant>? Participant
        {
            get { return _participant; }
            set
            {
                _participant = value;
                OnPropertyChanged("participant", value);
            }
        }

        public TestReportSetup? Setup
        {
            get { return _setup; }
            set
            {
                _setup = value;
                OnPropertyChanged("setup", value);
            }
        }

        public List<TestReportTest>? Test
        {
            get { return _test; }
            set
            {
                _test = value;
                OnPropertyChanged("test", value);
            }
        }

        public TestReportTeardown? Teardown
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
        public TestReport() { }
        public TestReport(string value) : base(value) { }
        public TestReport(JsonNode? source) : base(source) { }
        #endregion
    }
    public class TestReportParticipant : BackboneElementType<TestReportParticipant>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _type;
        private FhirUri? _uri;
        private FhirString? _display;

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

        public FhirUri? Uri
        {
            get { return _uri; }
            set
            {
                _uri = value;
                OnPropertyChanged("uri", value);
            }
        }

        public FhirString? Display
        {
            get { return _display; }
            set
            {
                _display = value;
                OnPropertyChanged("display", value);
            }
        }


        #endregion
        #region Constructor
        public TestReportParticipant() { }
        public TestReportParticipant(string value) : base(value) { }
        public TestReportParticipant(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportSetupActionOperation : BackboneElementType<TestReportSetupActionOperation>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _result;
        private FhirMarkdown? _message;
        private FhirUri? _detail;

        #endregion
        #region public Method
        public FhirCode? Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("result", value);
            }
        }

        public FhirMarkdown? Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("message", value);
            }
        }

        public FhirUri? Detail
        {
            get { return _detail; }
            set
            {
                _detail = value;
                OnPropertyChanged("detail", value);
            }
        }


        #endregion
        #region Constructor
        public TestReportSetupActionOperation() { }
        public TestReportSetupActionOperation(string value) : base(value) { }
        public TestReportSetupActionOperation(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportSetupActionAssertRequirement : BackboneElementType<TestReportSetupActionAssertRequirement>, IBackboneElementType
    {

        #region Private Method
        private TestReportSetupActionAssertRequirementLinkChoice? _link;

        #endregion
        #region public Method
        public TestReportSetupActionAssertRequirementLinkChoice? Link
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
        public TestReportSetupActionAssertRequirement() { }
        public TestReportSetupActionAssertRequirement(string value) : base(value) { }
        public TestReportSetupActionAssertRequirement(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportSetupActionAssert : BackboneElementType<TestReportSetupActionAssert>, IBackboneElementType
    {

        #region Private Method
        private FhirCode? _result;
        private FhirMarkdown? _message;
        private FhirString? _detail;
        private List<TestReportSetupActionAssertRequirement>? _requirement;

        #endregion
        #region public Method
        public FhirCode? Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("result", value);
            }
        }

        public FhirMarkdown? Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("message", value);
            }
        }

        public FhirString? Detail
        {
            get { return _detail; }
            set
            {
                _detail = value;
                OnPropertyChanged("detail", value);
            }
        }

        public List<TestReportSetupActionAssertRequirement>? Requirement
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
        public TestReportSetupActionAssert() { }
        public TestReportSetupActionAssert(string value) : base(value) { }
        public TestReportSetupActionAssert(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportSetupAction : BackboneElementType<TestReportSetupAction>, IBackboneElementType
    {

        #region Private Method
        private TestReportSetupActionOperation? _operation;
        private TestReportSetupActionAssert? _assert;

        #endregion
        #region public Method
        public TestReportSetupActionOperation? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }

        public TestReportSetupActionAssert? Assert
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
        public TestReportSetupAction() { }
        public TestReportSetupAction(string value) : base(value) { }
        public TestReportSetupAction(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportSetup : BackboneElementType<TestReportSetup>, IBackboneElementType
    {

        #region Private Method
        private List<TestReportSetupAction>? _action;

        #endregion
        #region public Method
        public List<TestReportSetupAction>? Action
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
        public TestReportSetup() { }
        public TestReportSetup(string value) : base(value) { }
        public TestReportSetup(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportTest : BackboneElementType<TestReportTest>, IBackboneElementType
    {

        #region Private Method
        private FhirString? _name;
        private FhirString? _description;
        private List<TestReportTestAction>? _action;

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

        public List<TestReportTestAction>? Action
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
        public TestReportTest() { }
        public TestReportTest(string value) : base(value) { }
        public TestReportTest(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportTestAction : BackboneElementType<TestReportTestAction>, IBackboneElementType
    {
        private TestReportSetupActionOperation? _operation;
        private TestReportSetupActionAssert? _assert;

        public TestReportSetupActionOperation? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }
        public TestReportSetupActionAssert? Assert
        {
            get { return _assert; }
            set
            {
                _assert = value;
                OnPropertyChanged("assert", value);
            }
        }
        public TestReportTestAction() { }
        public TestReportTestAction(string value) : base(value) { }
        public TestReportTestAction(JsonObject? source) : base(source) { }

    }


    public class TestReportTeardown : BackboneElementType<TestReportTeardown>, IBackboneElementType
    {

        #region Private Method
        private List<TestReportTeardownAction>? _action;

        #endregion
        #region public Method
        public List<TestReportTeardownAction>? Action
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
        public TestReportTeardown() { }
        public TestReportTeardown(string value) : base(value) { }
        public TestReportTeardown(JsonObject? source) : base(source) { }
        #endregion
    }

    public class TestReportTeardownAction : BackboneElementType<TestReportTeardownAction>, IBackboneElementType
    {
        private TestReportSetupActionOperation? _operation;

        public TestReportSetupActionOperation? Operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                OnPropertyChanged("operation", value);
            }
        }

        public TestReportTeardownAction() { }
        public TestReportTeardownAction(string value) : base(value) { }
        public TestReportTeardownAction(JsonObject? source) : base(source) { }

    }

    public class TestReportSetupActionAssertRequirementLinkChoice : ChoiceType
    {

        private static readonly List<string> _supportType = [
        "uri","canonical(Requirements)"
        ];

        public TestReportSetupActionAssertRequirementLinkChoice(JsonObject value) : base("link", value, _supportType)
        {
        }
        public TestReportSetupActionAssertRequirementLinkChoice(IComplexType? value) : base("link", value)
        {
        }
        public TestReportSetupActionAssertRequirementLinkChoice(IPrimitiveType? value) : base("link", value) { }

        public override string GetPrefixName(bool withCapital = true) => "link".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }


}
