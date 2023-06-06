

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SearchParameterSub
{
    public class SearchParameter : DomainResource<SearchParameter>
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
[Element("derivedFrom", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical DerivedFrom {get; set;}
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
[Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("base", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Base {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("expression", typeof(FhirString), true, false, false, false)]
public FhirString Expression {get; set;}
[Element("processingMode", typeof(FhirCode), true, false, false, false)]
public FhirCode ProcessingMode {get; set;}
[Element("constraint", typeof(FhirString), true, false, false, false)]
public FhirString Constraint {get; set;}
[Element("target", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Target {get; set;}
[Element("multipleOr", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean MultipleOr {get; set;}
[Element("multipleAnd", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean MultipleAnd {get; set;}
[Element("comparator", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Comparator {get; set;}
[Element("modifier", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Modifier {get; set;}
[Element("chain", typeof(FhirString), true, true, false, false)]
public IEnumerable<FhirString> Chain {get; set;}
[Element("component", typeof(Component), false, true, false, true)]
public IEnumerable<Component> Component {get; set;}

        #endregion
        #region Constructor
        public  SearchParameter() { }

        public  SearchParameter(string value) : base(value) { }
        public  SearchParameter(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "SearchParameter";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
