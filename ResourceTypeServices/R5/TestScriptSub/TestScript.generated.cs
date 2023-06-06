

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class TestScript : DomainResource<TestScript>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("versionAlgorithm", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased VersionAlgorithm {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("publisher", typeof(FhirString), true, false, false, false)]
public FhirString Publisher {get; set;}
[Element("contact", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Contact {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("jurisdiction", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Jurisdiction {get; set;}
[Element("purpose", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Purpose {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("copyrightLabel", typeof(FhirString), true, false, false, false)]
public FhirString CopyrightLabel {get; set;}
[Element("origin", typeof(Origin), false, true, false, true)]
public IEnumerable<Origin> Origin {get; set;}
[Element("destination", typeof(Destination), false, true, false, true)]
public IEnumerable<Destination> Destination {get; set;}
[Element("metadata", typeof(Metadata), false, false, false, true)]
public Metadata Metadata {get; set;}
[Element("scope", typeof(Scope), false, true, false, true)]
public IEnumerable<Scope> Scope {get; set;}
[Element("fixture", typeof(Fixture), false, true, false, true)]
public IEnumerable<Fixture> Fixture {get; set;}
[Element("profile", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Profile {get; set;}
[Element("variable", typeof(Variable), false, true, false, true)]
public IEnumerable<Variable> Variable {get; set;}
[Element("setup", typeof(Setup), false, false, false, true)]
public Setup Setup {get; set;}
[Element("test", typeof(Test), false, true, false, true)]
public IEnumerable<Test> Test {get; set;}
[Element("teardown", typeof(Teardown), false, false, false, true)]
public Teardown Teardown {get; set;}

        #endregion
        #region Constructor
        public  TestScript() { }

        public  TestScript(string value) : base(value) { }
        public  TestScript(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "TestScript";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
