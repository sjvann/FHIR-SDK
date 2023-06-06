

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub
{
    public class CapabilityStatement : DomainResource<CapabilityStatement>
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
[Element("kind", typeof(FhirCode), true, false, false, false)]
public FhirCode Kind {get; set;}
[Element("instantiates", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Instantiates {get; set;}
[Element("imports", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Imports {get; set;}
[Element("software", typeof(Software), false, false, false, true)]
public Software Software {get; set;}
[Element("implementation", typeof(Implementation), false, false, false, true)]
public Implementation Implementation {get; set;}
[Element("fhirVersion", typeof(FhirCode), true, false, false, false)]
public FhirCode FhirVersion {get; set;}
[Element("format", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Format {get; set;}
[Element("patchFormat", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> PatchFormat {get; set;}
[Element("acceptLanguage", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> AcceptLanguage {get; set;}
[Element("implementationGuide", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> ImplementationGuide {get; set;}
[Element("rest", typeof(Rest), false, true, false, true)]
public IEnumerable<Rest> Rest {get; set;}
[Element("messaging", typeof(Messaging), false, true, false, true)]
public IEnumerable<Messaging> Messaging {get; set;}
[Element("document", typeof(Document), false, true, false, true)]
public IEnumerable<Document> Document {get; set;}

        #endregion
        #region Constructor
        public  CapabilityStatement() { }

        public  CapabilityStatement(string value) : base(value) { }
        public  CapabilityStatement(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "CapabilityStatement";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
