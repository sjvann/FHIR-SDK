

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DetectedIssueSub
{
    public class DetectedIssue : DomainResource<DetectedIssue>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("severity", typeof(FhirCode), true, false, false, false)]
public FhirCode Severity {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("identified", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Identified {get; set;}
[Element("author", typeof(Reference), false, false, false, false)]
public Reference Author {get; set;}
[Element("implicated", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Implicated {get; set;}
[Element("evidence", typeof(Evidence), false, true, false, true)]
public IEnumerable<Evidence> Evidence {get; set;}
[Element("detail", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Detail {get; set;}
[Element("reference", typeof(FhirUri), true, false, false, false)]
public FhirUri Reference {get; set;}
[Element("mitigation", typeof(Mitigation), false, true, false, true)]
public IEnumerable<Mitigation> Mitigation {get; set;}

        #endregion
        #region Constructor
        public  DetectedIssue() { }

        public  DetectedIssue(string value) : base(value) { }
        public  DetectedIssue(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DetectedIssue";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
