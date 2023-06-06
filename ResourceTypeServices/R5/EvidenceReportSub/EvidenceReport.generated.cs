

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceReportSub
{
    public class EvidenceReport : DomainResource<EvidenceReport>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("relatedIdentifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> RelatedIdentifier {get; set;}
[Element("citeAs", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased CiteAs {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("subject", typeof(Subject), false, false, false, true)]
public Subject Subject {get; set;}
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
[Element("relatesTo", typeof(RelatesTo), false, true, false, true)]
public IEnumerable<RelatesTo> RelatesTo {get; set;}
[Element("section", typeof(Section), false, true, false, true)]
public IEnumerable<Section> Section {get; set;}

        #endregion
        #region Constructor
        public  EvidenceReport() { }

        public  EvidenceReport(string value) : base(value) { }
        public  EvidenceReport(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "EvidenceReport";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
