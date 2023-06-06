

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchStudySub
{
    public class ResearchStudy : DomainResource<ResearchStudy>
    {
        #region Property
        [Element("url", typeof(FhirUri), true, false, false, false)]
public FhirUri Url {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("label", typeof(Label), false, true, false, true)]
public IEnumerable<Label> Label {get; set;}
[Element("protocol", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Protocol {get; set;}
[Element("partOf", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> PartOf {get; set;}
[Element("relatedArtifact", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> RelatedArtifact {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("primaryPurposeType", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept PrimaryPurposeType {get; set;}
[Element("phase", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Phase {get; set;}
[Element("studyDesign", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> StudyDesign {get; set;}
[Element("focus", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Focus {get; set;}
[Element("condition", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Condition {get; set;}
[Element("keyword", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Keyword {get; set;}
[Element("region", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Region {get; set;}
[Element("descriptionSummary", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown DescriptionSummary {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("site", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Site {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("classifier", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classifier {get; set;}
[Element("associatedParty", typeof(AssociatedParty), false, true, false, true)]
public IEnumerable<AssociatedParty> AssociatedParty {get; set;}
[Element("progressStatus", typeof(ProgressStatus), false, true, false, true)]
public IEnumerable<ProgressStatus> ProgressStatus {get; set;}
[Element("whyStopped", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept WhyStopped {get; set;}
[Element("recruitment", typeof(Recruitment), false, false, false, true)]
public Recruitment Recruitment {get; set;}
[Element("comparisonGroup", typeof(ComparisonGroup), false, true, false, true)]
public IEnumerable<ComparisonGroup> ComparisonGroup {get; set;}
[Element("objective", typeof(Objective), false, true, false, true)]
public IEnumerable<Objective> Objective {get; set;}
[Element("outcomeMeasure", typeof(OutcomeMeasure), false, true, false, true)]
public IEnumerable<OutcomeMeasure> OutcomeMeasure {get; set;}
[Element("result", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Result {get; set;}

        #endregion
        #region Constructor
        public  ResearchStudy() { }

        public  ResearchStudy(string value) : base(value) { }
        public  ResearchStudy(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ResearchStudy";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
