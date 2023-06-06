

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ArtifactAssessmentSub
{
    public class ArtifactAssessment : DomainResource<ArtifactAssessment>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("citeAs", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased CiteAs {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("copyright", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Copyright {get; set;}
[Element("approvalDate", typeof(FhirDate), true, false, false, false)]
public FhirDate ApprovalDate {get; set;}
[Element("lastReviewDate", typeof(FhirDate), true, false, false, false)]
public FhirDate LastReviewDate {get; set;}
[Element("artifact", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Artifact {get; set;}
[Element("content", typeof(Content), false, true, false, true)]
public IEnumerable<Content> Content {get; set;}
[Element("workflowStatus", typeof(FhirCode), true, false, false, false)]
public FhirCode WorkflowStatus {get; set;}
[Element("disposition", typeof(FhirCode), true, false, false, false)]
public FhirCode Disposition {get; set;}

        #endregion
        #region Constructor
        public  ArtifactAssessment() { }

        public  ArtifactAssessment(string value) : base(value) { }
        public  ArtifactAssessment(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "ArtifactAssessment";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
