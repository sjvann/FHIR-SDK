

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceSub
{
    public class Evidence : DomainResource<Evidence>
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
[Element("citeAs", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased CiteAs {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("approvalDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ApprovalDate {get; set;}
[Element("lastReviewDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LastReviewDate {get; set;}
[Element("publisher", typeof(FhirString), true, false, false, false)]
public FhirString Publisher {get; set;}
[Element("contact", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Contact {get; set;}
[Element("author", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Author {get; set;}
[Element("editor", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Editor {get; set;}
[Element("reviewer", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Reviewer {get; set;}
[Element("endorser", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Endorser {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("purpose", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Purpose {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("copyrightLabel", typeof(FhirString), true, false, false, false)]
public FhirString CopyrightLabel {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("assertion", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Assertion {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("variableDefinition", typeof(VariableDefinition), false, true, false, true)]
public IEnumerable<VariableDefinition> VariableDefinition {get; set;}
[Element("synthesisType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SynthesisType {get; set;}
[Element("studyDesign", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> StudyDesign {get; set;}
[Element("statistic", typeof(Statistic), false, true, false, true)]
public IEnumerable<Statistic> Statistic {get; set;}
[Element("certainty", typeof(Certainty), false, true, false, true)]
public IEnumerable<Certainty> Certainty {get; set;}

        #endregion
        #region Constructor
        public  Evidence() { }

        public  Evidence(string value) : base(value) { }
        public  Evidence(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Evidence";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
