

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.LibrarySub
{
    public class Library : DomainResource<Library>
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
[Element("subtitle", typeof(FhirString), true, false, false, false)]
public FhirString Subtitle {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("experimental", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Experimental {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subject", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Subject {get; set;}
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
[Element("usage", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Usage {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("copyrightLabel", typeof(FhirString), true, false, false, false)]
public FhirString CopyrightLabel {get; set;}
[Element("approvalDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ApprovalDate {get; set;}
[Element("lastReviewDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LastReviewDate {get; set;}
[Element("effectivePeriod", typeof(Period), false, false, false, false)]
public Period EffectivePeriod {get; set;}
[Element("topic", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Topic {get; set;}
[Element("author", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Author {get; set;}
[Element("editor", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Editor {get; set;}
[Element("reviewer", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Reviewer {get; set;}
[Element("endorser", typeof(ContactDetail), false, true, false, false)]
public IEnumerable<ContactDetail> Endorser {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("parameter", typeof(ParameterDefinition), false, true, false, false)]
public IEnumerable<ParameterDefinition> Parameter {get; set;}
[Element("dataRequirement", typeof(DataRequirement), false, true, false, false)]
public IEnumerable<DataRequirement> DataRequirement {get; set;}
[Element("content", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> Content {get; set;}

        #endregion
        #region Constructor
        public  Library() { }

        public  Library(string value) : base(value) { }
        public  Library(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Library";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
