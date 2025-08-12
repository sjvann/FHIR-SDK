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
    public class TestPlan : ResourceType<TestPlan>
	{
		#region private Property
		private FhirUri? _url;
private List<Identifier>? _identifier;
private FhirString? _version;
private TestPlanVersionAlgorithmChoice? _versionAlgorithm;
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
private List<CodeableConcept>? _category;
private List<ReferenceType>? _scope;
private FhirMarkdown? _testTools;
private List<TestPlanDependency>? _dependency;
private FhirMarkdown? _exitCriteria;
private List<TestPlanTestCase>? _testCase;

		#endregion
		#region Public Method
		public FhirUri? Url
{
get { return _url; }
set {
_url= value;
OnPropertyChanged("url", value);
}
}

public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirString? Version
{
get { return _version; }
set {
_version= value;
OnPropertyChanged("version", value);
}
}

public TestPlanVersionAlgorithmChoice? VersionAlgorithm
{
get { return _versionAlgorithm; }
set {
_versionAlgorithm= value;
OnPropertyChanged("versionAlgorithm", value);
}
}

public FhirString? Name
{
get { return _name; }
set {
_name= value;
OnPropertyChanged("name", value);
}
}

public FhirString? Title
{
get { return _title; }
set {
_title= value;
OnPropertyChanged("title", value);
}
}

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirBoolean? Experimental
{
get { return _experimental; }
set {
_experimental= value;
OnPropertyChanged("experimental", value);
}
}

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public FhirString? Publisher
{
get { return _publisher; }
set {
_publisher= value;
OnPropertyChanged("publisher", value);
}
}

public List<ContactDetail>? Contact
{
get { return _contact; }
set {
_contact= value;
OnPropertyChanged("contact", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<UsageContext>? UseContext
{
get { return _useContext; }
set {
_useContext= value;
OnPropertyChanged("useContext", value);
}
}

public List<CodeableConcept>? Jurisdiction
{
get { return _jurisdiction; }
set {
_jurisdiction= value;
OnPropertyChanged("jurisdiction", value);
}
}

public FhirMarkdown? Purpose
{
get { return _purpose; }
set {
_purpose= value;
OnPropertyChanged("purpose", value);
}
}

public FhirMarkdown? Copyright
{
get { return _copyright; }
set {
_copyright= value;
OnPropertyChanged("copyright", value);
}
}

public FhirString? CopyrightLabel
{
get { return _copyrightLabel; }
set {
_copyrightLabel= value;
OnPropertyChanged("copyrightLabel", value);
}
}

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public List<ReferenceType>? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}

public FhirMarkdown? TestTools
{
get { return _testTools; }
set {
_testTools= value;
OnPropertyChanged("testTools", value);
}
}

public List<TestPlanDependency>? Dependency
{
get { return _dependency; }
set {
_dependency= value;
OnPropertyChanged("dependency", value);
}
}

public FhirMarkdown? ExitCriteria
{
get { return _exitCriteria; }
set {
_exitCriteria= value;
OnPropertyChanged("exitCriteria", value);
}
}

public List<TestPlanTestCase>? TestCase
{
get { return _testCase; }
set {
_testCase= value;
OnPropertyChanged("testCase", value);
}
}


		#endregion
		#region Constructor
		public  TestPlan() { }
		public  TestPlan(string value) : base(value) { }
		public  TestPlan(JsonNode? source) : base(source) { }
		#endregion
	}
		public class TestPlanDependency : BackboneElementType<TestPlanDependency>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private ReferenceType? _predecessor;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public ReferenceType? Predecessor
{
get { return _predecessor; }
set {
_predecessor= value;
OnPropertyChanged("predecessor", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanDependency() { }
		public  TestPlanDependency(string value) : base(value) { }
		public  TestPlanDependency(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TestPlanTestCaseDependency : BackboneElementType<TestPlanTestCaseDependency>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _description;
private ReferenceType? _predecessor;

		#endregion
		#region public Method
		public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public ReferenceType? Predecessor
{
get { return _predecessor; }
set {
_predecessor= value;
OnPropertyChanged("predecessor", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanTestCaseDependency() { }
		public  TestPlanTestCaseDependency(string value) : base(value) { }
		public  TestPlanTestCaseDependency(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TestPlanTestCaseTestRunScript : BackboneElementType<TestPlanTestCaseTestRunScript>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _language;
private TestPlanTestCaseTestRunScriptSourceChoice? _source;

		#endregion
		#region public Method
		public CodeableConcept? Language
{
get { return _language; }
set {
_language= value;
OnPropertyChanged("language", value);
}
}

public TestPlanTestCaseTestRunScriptSourceChoice? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanTestCaseTestRunScript() { }
		public  TestPlanTestCaseTestRunScript(string value) : base(value) { }
		public  TestPlanTestCaseTestRunScript(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TestPlanTestCaseTestRun : BackboneElementType<TestPlanTestCaseTestRun>, IBackboneElementType
	{

		#region Private Method
		private FhirMarkdown? _narrative;
private TestPlanTestCaseTestRunScript? _script;

		#endregion
		#region public Method
		public FhirMarkdown? Narrative
{
get { return _narrative; }
set {
_narrative= value;
OnPropertyChanged("narrative", value);
}
}

public TestPlanTestCaseTestRunScript? Script
{
get { return _script; }
set {
_script= value;
OnPropertyChanged("script", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanTestCaseTestRun() { }
		public  TestPlanTestCaseTestRun(string value) : base(value) { }
		public  TestPlanTestCaseTestRun(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TestPlanTestCaseTestData : BackboneElementType<TestPlanTestCaseTestData>, IBackboneElementType
	{

		#region Private Method
		private Coding? _type;
private ReferenceType? _content;
private TestPlanTestCaseTestDataSourceChoice? _source;

		#endregion
		#region public Method
		public Coding? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public ReferenceType? Content
{
get { return _content; }
set {
_content= value;
OnPropertyChanged("content", value);
}
}

public TestPlanTestCaseTestDataSourceChoice? Source
{
get { return _source; }
set {
_source= value;
OnPropertyChanged("source", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanTestCaseTestData() { }
		public  TestPlanTestCaseTestData(string value) : base(value) { }
		public  TestPlanTestCaseTestData(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TestPlanTestCaseAssertion : BackboneElementType<TestPlanTestCaseAssertion>, IBackboneElementType
	{

		#region Private Method
		private List<CodeableConcept>? _type;
private List<CodeableReference>? _object;
private List<CodeableReference>? _result;

		#endregion
		#region public Method
		public List<CodeableConcept>? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public List<CodeableReference>? Object
{
get { return _object; }
set {
_object= value;
OnPropertyChanged("object", value);
}
}

public List<CodeableReference>? Result
{
get { return _result; }
set {
_result= value;
OnPropertyChanged("result", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanTestCaseAssertion() { }
		public  TestPlanTestCaseAssertion(string value) : base(value) { }
		public  TestPlanTestCaseAssertion(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class TestPlanTestCase : BackboneElementType<TestPlanTestCase>, IBackboneElementType
	{

		#region Private Method
		private FhirInteger? _sequence;
private List<ReferenceType>? _scope;
private List<TestPlanTestCaseDependency>? _dependency;
private List<TestPlanTestCaseTestRun>? _testRun;
private List<TestPlanTestCaseTestData>? _testData;
private List<TestPlanTestCaseAssertion>? _assertion;

		#endregion
		#region public Method
		public FhirInteger? Sequence
{
get { return _sequence; }
set {
_sequence= value;
OnPropertyChanged("sequence", value);
}
}

public List<ReferenceType>? Scope
{
get { return _scope; }
set {
_scope= value;
OnPropertyChanged("scope", value);
}
}

public List<TestPlanTestCaseDependency>? Dependency
{
get { return _dependency; }
set {
_dependency= value;
OnPropertyChanged("dependency", value);
}
}

public List<TestPlanTestCaseTestRun>? TestRun
{
get { return _testRun; }
set {
_testRun= value;
OnPropertyChanged("testRun", value);
}
}

public List<TestPlanTestCaseTestData>? TestData
{
get { return _testData; }
set {
_testData= value;
OnPropertyChanged("testData", value);
}
}

public List<TestPlanTestCaseAssertion>? Assertion
{
get { return _assertion; }
set {
_assertion= value;
OnPropertyChanged("assertion", value);
}
}


		#endregion
		#region Constructor
		public  TestPlanTestCase() { }
		public  TestPlanTestCase(string value) : base(value) { }
		public  TestPlanTestCase(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class TestPlanVersionAlgorithmChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Coding"
        ];

        public TestPlanVersionAlgorithmChoice(JsonObject value) : base("versionAlgorithm", value, _supportType)
        {
        }
        public TestPlanVersionAlgorithmChoice(IComplexType? value) : base("versionAlgorithm", value)
        {
        }
        public TestPlanVersionAlgorithmChoice(IPrimitiveType? value) : base("versionAlgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"versionAlgorithm".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class TestPlanTestCaseTestRunScriptSourceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Reference"
        ];

        public TestPlanTestCaseTestRunScriptSourceChoice(JsonObject value) : base("source", value, _supportType)
        {
        }
        public TestPlanTestCaseTestRunScriptSourceChoice(IComplexType? value) : base("source", value)
        {
        }
        public TestPlanTestCaseTestRunScriptSourceChoice(IPrimitiveType? value) : base("source", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"source".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class TestPlanTestCaseTestDataSourceChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "string","Reference"
        ];

        public TestPlanTestCaseTestDataSourceChoice(JsonObject value) : base("source", value, _supportType)
        {
        }
        public TestPlanTestCaseTestDataSourceChoice(IComplexType? value) : base("source", value)
        {
        }
        public TestPlanTestCaseTestDataSourceChoice(IPrimitiveType? value) : base("source", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"source".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
