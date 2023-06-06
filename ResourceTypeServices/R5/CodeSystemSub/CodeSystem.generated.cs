

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CodeSystemSub
{
    public class CodeSystem : DomainResource<CodeSystem>
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
[Element("caseSensitive", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean CaseSensitive {get; set;}
[Element("valueSet", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical ValueSet {get; set;}
[Element("hierarchyMeaning", typeof(FhirCode), true, false, false, false)]
public FhirCode HierarchyMeaning {get; set;}
[Element("compositional", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Compositional {get; set;}
[Element("versionNeeded", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean VersionNeeded {get; set;}
[Element("content", typeof(FhirCode), true, false, false, false)]
public FhirCode Content {get; set;}
[Element("supplements", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Supplements {get; set;}
[Element("count", typeof(FhirUnsignedInt), true, false, false, false)]
public FhirUnsignedInt Count {get; set;}
[Element("filter", typeof(Filter), false, true, false, true)]
public IEnumerable<Filter> Filter {get; set;}
[Element("property", typeof(Property), false, true, false, true)]
public IEnumerable<Property> Property {get; set;}
[Element("concept", typeof(Concept), false, true, false, true)]
public IEnumerable<Concept> Concept {get; set;}

        #endregion
        #region Constructor
        public  CodeSystem() { }

        public  CodeSystem(string value) : base(value) { }
        public  CodeSystem(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "CodeSystem";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
