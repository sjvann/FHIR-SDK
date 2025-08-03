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
    /// FHIR R5 TestReport 資源
    /// 
    /// <para>
    /// TestReport 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var testreport = new TestReport("testreport-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 TestReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class TestReport : ResourceBase<R5Version>
    {
        private Property
        private Identifier? _identifier;
        private FhirString? _name;
        private FhirCode? _status;
        private FhirCanonical? _testscript;
        private FhirCode? _result;
        private FhirDecimal? _score;
        private FhirString? _tester;
        private FhirDateTime? _issued;
        private List<TestReportParticipant>? _participant;
        private TestReportSetup? _setup;
        private List<TestReportTest>? _test;
        private TestReportTeardown? _teardown;
        private FhirCode? _type;
        private FhirUri? _uri;
        private FhirString? _display;
        private FhirCode? _result;
        private FhirMarkdown? _message;
        private FhirUri? _detail;
        private TestReportSetupActionAssertRequirementLinkChoice? _link;
        private FhirCode? _result;
        private FhirMarkdown? _message;
        private FhirString? _detail;
        private List<TestReportSetupActionAssertRequirement>? _requirement;
        private TestReportSetupActionOperation? _operation;
        private TestReportSetupActionAssert? _assert;
        private List<TestReportSetupAction>? _action;
        private FhirString? _name;
        private FhirString? _description;
        private List<TestReportTestAction>? _action;
        private TestReportSetupActionOperation? _operation;
        private TestReportSetupActionAssert? _assert;
        private List<TestReportTeardownAction>? _action;
        private TestReportSetupActionOperation? _operation;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "TestReport";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
        private Identifier? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
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
        /// Testscript
        /// </summary>
        /// <remarks>
        /// <para>
        /// Testscript 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Testscript
        {
            get => _testscript;
            set
            {
                _testscript = value;
                OnPropertyChanged(nameof(Testscript));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }        /// <summary>
        /// Score
        /// </summary>
        /// <remarks>
        /// <para>
        /// Score 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDecimal? Score
        {
            get => _score;
            set
            {
                _score = value;
                OnPropertyChanged(nameof(Score));
            }
        }        /// <summary>
        /// Tester
        /// </summary>
        /// <remarks>
        /// <para>
        /// Tester 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Tester
        {
            get => _tester;
            set
            {
                _tester = value;
                OnPropertyChanged(nameof(Tester));
            }
        }        /// <summary>
        /// Issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// Issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(Issued));
            }
        }        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestReportParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
            }
        }        /// <summary>
        /// Setup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Setup 的詳細描述。
        /// </para>
        /// </remarks>
        public TestReportSetup? Setup
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
        public List<TestReportTest>? Test
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
        public TestReportTeardown? Teardown
        {
            get => _teardown;
            set
            {
                _teardown = value;
                OnPropertyChanged(nameof(Teardown));
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
        /// Uri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Uri
        {
            get => _uri;
            set
            {
                _uri = value;
                OnPropertyChanged(nameof(Uri));
            }
        }        /// <summary>
        /// Display
        /// </summary>
        /// <remarks>
        /// <para>
        /// Display 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Display
        {
            get => _display;
            set
            {
                _display = value;
                OnPropertyChanged(nameof(Display));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }        /// <summary>
        /// Message
        /// </summary>
        /// <remarks>
        /// <para>
        /// Message 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Link
        /// </summary>
        /// <remarks>
        /// <para>
        /// Link 的詳細描述。
        /// </para>
        /// </remarks>
        public TestReportSetupActionAssertRequirementLinkChoice? Link
        {
            get => _link;
            set
            {
                _link = value;
                OnPropertyChanged(nameof(Link));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }        /// <summary>
        /// Message
        /// </summary>
        /// <remarks>
        /// <para>
        /// Message 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }        /// <summary>
        /// Detail
        /// </summary>
        /// <remarks>
        /// <para>
        /// Detail 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Detail
        {
            get => _detail;
            set
            {
                _detail = value;
                OnPropertyChanged(nameof(Detail));
            }
        }        /// <summary>
        /// Requirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// Requirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestReportSetupActionAssertRequirement>? Requirement
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
        public TestReportSetupActionOperation? Operation
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
        public TestReportSetupActionAssert? Assert
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
        public List<TestReportSetupAction>? Action
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
        public List<TestReportTestAction>? Action
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
        public TestReportSetupActionOperation? Operation
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
        public TestReportSetupActionAssert? Assert
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
        public List<TestReportTeardownAction>? Action
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
        public TestReportSetupActionOperation? Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }        /// <summary>
        /// 建立新的 TestReport 資源實例
        /// </summary>
        public TestReport()
        {
        }

        /// <summary>
        /// 建立新的 TestReport 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public TestReport(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"TestReport(Id: {Id})";
        }
    }    /// <summary>
    /// TestReportParticipant 背骨元素
    /// </summary>
    public class TestReportParticipant
    {
        // TODO: 添加屬性實作
        
        public TestReportParticipant() { }
    }    /// <summary>
    /// TestReportSetupActionOperation 背骨元素
    /// </summary>
    public class TestReportSetupActionOperation
    {
        // TODO: 添加屬性實作
        
        public TestReportSetupActionOperation() { }
    }    /// <summary>
    /// TestReportSetupActionAssertRequirement 背骨元素
    /// </summary>
    public class TestReportSetupActionAssertRequirement
    {
        // TODO: 添加屬性實作
        
        public TestReportSetupActionAssertRequirement() { }
    }    /// <summary>
    /// TestReportSetupActionAssert 背骨元素
    /// </summary>
    public class TestReportSetupActionAssert
    {
        // TODO: 添加屬性實作
        
        public TestReportSetupActionAssert() { }
    }    /// <summary>
    /// TestReportSetupAction 背骨元素
    /// </summary>
    public class TestReportSetupAction
    {
        // TODO: 添加屬性實作
        
        public TestReportSetupAction() { }
    }    /// <summary>
    /// TestReportSetup 背骨元素
    /// </summary>
    public class TestReportSetup
    {
        // TODO: 添加屬性實作
        
        public TestReportSetup() { }
    }    /// <summary>
    /// TestReportTest 背骨元素
    /// </summary>
    public class TestReportTest
    {
        // TODO: 添加屬性實作
        
        public TestReportTest() { }
    }    /// <summary>
    /// TestReportTestAction 背骨元素
    /// </summary>
    public class TestReportTestAction
    {
        // TODO: 添加屬性實作
        
        public TestReportTestAction() { }
    }    /// <summary>
    /// TestReportTeardown 背骨元素
    /// </summary>
    public class TestReportTeardown
    {
        // TODO: 添加屬性實作
        
        public TestReportTeardown() { }
    }    /// <summary>
    /// TestReportTeardownAction 背骨元素
    /// </summary>
    public class TestReportTeardownAction
    {
        // TODO: 添加屬性實作
        
        public TestReportTeardownAction() { }
    }    /// <summary>
    /// TestReportSetupActionAssertRequirementLinkChoice 選擇類型
    /// </summary>
    public class TestReportSetupActionAssertRequirementLinkChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TestReportSetupActionAssertRequirementLinkChoice(JsonObject value) : base("testreportsetupactionassertrequirementlink", value, _supportType) { }
        public TestReportSetupActionAssertRequirementLinkChoice(IComplexType? value) : base("testreportsetupactionassertrequirementlink", value) { }
        public TestReportSetupActionAssertRequirementLinkChoice(IPrimitiveType? value) : base("testreportsetupactionassertrequirementlink", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TestReportSetupActionAssertRequirementLink" : "testreportsetupactionassertrequirementlink";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
