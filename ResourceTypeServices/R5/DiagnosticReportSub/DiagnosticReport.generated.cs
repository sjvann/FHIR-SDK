

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DiagnosticReportSub
{
    public class DiagnosticReport : DomainResource<DiagnosticReport>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("basedOn", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> BasedOn {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("effective", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Effective {get; set;}
[Element("issued", typeof(FhirInstant), true, false, false, false)]
public FhirInstant Issued {get; set;}
[Element("performer", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Performer {get; set;}
[Element("resultsInterpreter", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> ResultsInterpreter {get; set;}
[Element("specimen", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Specimen {get; set;}
[Element("result", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Result {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("study", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Study {get; set;}
[Element("supportingInfo", typeof(SupportingInfo), false, true, false, true)]
public IEnumerable<SupportingInfo> SupportingInfo {get; set;}
[Element("media", typeof(Media), false, true, false, true)]
public IEnumerable<Media> Media {get; set;}
[Element("composition", typeof(Reference), false, false, false, false)]
public Reference Composition {get; set;}
[Element("conclusion", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Conclusion {get; set;}
[Element("conclusionCode", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ConclusionCode {get; set;}
[Element("presentedForm", typeof(Attachment), false, true, false, false)]
public IEnumerable<Attachment> PresentedForm {get; set;}

        #endregion
        #region Constructor
        public  DiagnosticReport() { }

        public  DiagnosticReport(string value) : base(value) { }
        public  DiagnosticReport(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "DiagnosticReport";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
