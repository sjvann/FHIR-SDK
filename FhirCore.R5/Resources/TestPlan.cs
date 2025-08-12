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
    /// FHIR R5 TestPlan 資源
    /// 
    /// <para>
    /// TestPlan 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var testplan = new TestPlan("testplan-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 TestPlan 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class TestPlan : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private TestPlanVersionAlgorithmChoice? _versionalgorithm;
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
        private List<CodeableConcept>? _category;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _scope;
        private FhirMarkdown? _testtools;
        private List<TestPlanDependency>? _dependency;
        private FhirMarkdown? _exitcriteria;
        private List<TestPlanTestCase>? _testcase;
        private FhirMarkdown? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _predecessor;
        private FhirMarkdown? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _predecessor;
        private CodeableConcept? _language;
        private TestPlanTestCaseTestRunScriptSourceChoice? _source;
        private FhirMarkdown? _narrative;
        private TestPlanTestCaseTestRunScript? _script;
        private Coding? _type;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _content;
        private TestPlanTestCaseTestDataSourceChoice? _source;
        private List<CodeableConcept>? _type;
        private List<CodeableReference>? _object;
        private List<CodeableReference>? _result;
        private FhirInteger? _sequence;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _scope;
        private List<TestPlanTestCaseDependency>? _dependency;
        private List<TestPlanTestCaseTestRun>? _testrun;
        private List<TestPlanTestCaseTestData>? _testdata;
        private List<TestPlanTestCaseAssertion>? _assertion;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "TestPlan";        /// <summary>
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
        public TestPlanVersionAlgorithmChoice? Versionalgorithm
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Testtools
        /// </summary>
        /// <remarks>
        /// <para>
        /// Testtools 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Testtools
        {
            get => _testtools;
            set
            {
                _testtools = value;
                OnPropertyChanged(nameof(Testtools));
            }
        }        /// <summary>
        /// Dependency
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dependency 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestPlanDependency>? Dependency
        {
            get => _dependency;
            set
            {
                _dependency = value;
                OnPropertyChanged(nameof(Dependency));
            }
        }        /// <summary>
        /// Exitcriteria
        /// </summary>
        /// <remarks>
        /// <para>
        /// Exitcriteria 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Exitcriteria
        {
            get => _exitcriteria;
            set
            {
                _exitcriteria = value;
                OnPropertyChanged(nameof(Exitcriteria));
            }
        }        /// <summary>
        /// Testcase
        /// </summary>
        /// <remarks>
        /// <para>
        /// Testcase 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestPlanTestCase>? Testcase
        {
            get => _testcase;
            set
            {
                _testcase = value;
                OnPropertyChanged(nameof(Testcase));
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
        /// Predecessor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Predecessor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Predecessor
        {
            get => _predecessor;
            set
            {
                _predecessor = value;
                OnPropertyChanged(nameof(Predecessor));
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
        /// Predecessor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Predecessor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Predecessor
        {
            get => _predecessor;
            set
            {
                _predecessor = value;
                OnPropertyChanged(nameof(Predecessor));
            }
        }        /// <summary>
        /// Language
        /// </summary>
        /// <remarks>
        /// <para>
        /// Language 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(Language));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public TestPlanTestCaseTestRunScriptSourceChoice? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Narrative
        /// </summary>
        /// <remarks>
        /// <para>
        /// Narrative 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Narrative
        {
            get => _narrative;
            set
            {
                _narrative = value;
                OnPropertyChanged(nameof(Narrative));
            }
        }        /// <summary>
        /// Script
        /// </summary>
        /// <remarks>
        /// <para>
        /// Script 的詳細描述。
        /// </para>
        /// </remarks>
        public TestPlanTestCaseTestRunScript? Script
        {
            get => _script;
            set
            {
                _script = value;
                OnPropertyChanged(nameof(Script));
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
        /// Content
        /// </summary>
        /// <remarks>
        /// <para>
        /// Content 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged(nameof(Content));
            }
        }        /// <summary>
        /// Source
        /// </summary>
        /// <remarks>
        /// <para>
        /// Source 的詳細描述。
        /// </para>
        /// </remarks>
        public TestPlanTestCaseTestDataSourceChoice? Source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(Source));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Object
        /// </summary>
        /// <remarks>
        /// <para>
        /// Object 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Object
        {
            get => _object;
            set
            {
                _object = value;
                OnPropertyChanged(nameof(Object));
            }
        }        /// <summary>
        /// Result
        /// </summary>
        /// <remarks>
        /// <para>
        /// Result 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }        /// <summary>
        /// Sequence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sequence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Sequence
        {
            get => _sequence;
            set
            {
                _sequence = value;
                OnPropertyChanged(nameof(Sequence));
            }
        }        /// <summary>
        /// Scope
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scope 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Scope
        {
            get => _scope;
            set
            {
                _scope = value;
                OnPropertyChanged(nameof(Scope));
            }
        }        /// <summary>
        /// Dependency
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dependency 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestPlanTestCaseDependency>? Dependency
        {
            get => _dependency;
            set
            {
                _dependency = value;
                OnPropertyChanged(nameof(Dependency));
            }
        }        /// <summary>
        /// Testrun
        /// </summary>
        /// <remarks>
        /// <para>
        /// Testrun 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestPlanTestCaseTestRun>? Testrun
        {
            get => _testrun;
            set
            {
                _testrun = value;
                OnPropertyChanged(nameof(Testrun));
            }
        }        /// <summary>
        /// Testdata
        /// </summary>
        /// <remarks>
        /// <para>
        /// Testdata 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestPlanTestCaseTestData>? Testdata
        {
            get => _testdata;
            set
            {
                _testdata = value;
                OnPropertyChanged(nameof(Testdata));
            }
        }        /// <summary>
        /// Assertion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assertion 的詳細描述。
        /// </para>
        /// </remarks>
        public List<TestPlanTestCaseAssertion>? Assertion
        {
            get => _assertion;
            set
            {
                _assertion = value;
                OnPropertyChanged(nameof(Assertion));
            }
        }        /// <summary>
        /// 建立新的 TestPlan 資源實例
        /// </summary>
        public TestPlan()
        {
        }

        /// <summary>
        /// 建立新的 TestPlan 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public TestPlan(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"TestPlan(Id: {Id})";
        }
    }    /// <summary>
    /// TestPlanDependency 背骨元素
    /// </summary>
    public class TestPlanDependency
    {
        // TODO: 添加屬性實作
        
        public TestPlanDependency() { }
    }    /// <summary>
    /// TestPlanTestCaseDependency 背骨元素
    /// </summary>
    public class TestPlanTestCaseDependency
    {
        // TODO: 添加屬性實作
        
        public TestPlanTestCaseDependency() { }
    }    /// <summary>
    /// TestPlanTestCaseTestRunScript 背骨元素
    /// </summary>
    public class TestPlanTestCaseTestRunScript
    {
        // TODO: 添加屬性實作
        
        public TestPlanTestCaseTestRunScript() { }
    }    /// <summary>
    /// TestPlanTestCaseTestRun 背骨元素
    /// </summary>
    public class TestPlanTestCaseTestRun
    {
        // TODO: 添加屬性實作
        
        public TestPlanTestCaseTestRun() { }
    }    /// <summary>
    /// TestPlanTestCaseTestData 背骨元素
    /// </summary>
    public class TestPlanTestCaseTestData
    {
        // TODO: 添加屬性實作
        
        public TestPlanTestCaseTestData() { }
    }    /// <summary>
    /// TestPlanTestCaseAssertion 背骨元素
    /// </summary>
    public class TestPlanTestCaseAssertion
    {
        // TODO: 添加屬性實作
        
        public TestPlanTestCaseAssertion() { }
    }    /// <summary>
    /// TestPlanTestCase 背骨元素
    /// </summary>
    public class TestPlanTestCase
    {
        // TODO: 添加屬性實作
        
        public TestPlanTestCase() { }
    }    /// <summary>
    /// TestPlanVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class TestPlanVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TestPlanVersionAlgorithmChoice(JsonObject value) : base("testplanversionalgorithm", value, _supportType) { }
        public TestPlanVersionAlgorithmChoice(IComplexType? value) : base("testplanversionalgorithm", value) { }
        public TestPlanVersionAlgorithmChoice(IPrimitiveType? value) : base("testplanversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TestPlanVersionAlgorithm" : "testplanversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// TestPlanTestCaseTestRunScriptSourceChoice 選擇類型
    /// </summary>
    public class TestPlanTestCaseTestRunScriptSourceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TestPlanTestCaseTestRunScriptSourceChoice(JsonObject value) : base("testplantestcasetestrunscriptsource", value, _supportType) { }
        public TestPlanTestCaseTestRunScriptSourceChoice(IComplexType? value) : base("testplantestcasetestrunscriptsource", value) { }
        public TestPlanTestCaseTestRunScriptSourceChoice(IPrimitiveType? value) : base("testplantestcasetestrunscriptsource", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TestPlanTestCaseTestRunScriptSource" : "testplantestcasetestrunscriptsource";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// TestPlanTestCaseTestDataSourceChoice 選擇類型
    /// </summary>
    public class TestPlanTestCaseTestDataSourceChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public TestPlanTestCaseTestDataSourceChoice(JsonObject value) : base("testplantestcasetestdatasource", value, _supportType) { }
        public TestPlanTestCaseTestDataSourceChoice(IComplexType? value) : base("testplantestcasetestdatasource", value) { }
        public TestPlanTestCaseTestDataSourceChoice(IPrimitiveType? value) : base("testplantestcasetestdatasource", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "TestPlanTestCaseTestDataSource" : "testplantestcasetestdatasource";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
