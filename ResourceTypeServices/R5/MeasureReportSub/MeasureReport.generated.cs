

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MeasureReportSub
{
    public class MeasureReport : DomainResource<MeasureReport>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("dataUpdateType", typeof(FhirCode), true, false, false, false)]
public FhirCode DataUpdateType {get; set;}
[Element("measure", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Measure {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("date", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime Date {get; set;}
[Element("reporter", typeof(Reference), false, false, false, false)]
public Reference Reporter {get; set;}
[Element("reportingVendor", typeof(Reference), false, false, false, false)]
public Reference ReportingVendor {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}
[Element("inputParameters", typeof(Reference), false, false, false, false)]
public Reference InputParameters {get; set;}
[Element("scoring", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Scoring {get; set;}
[Element("improvementNotation", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ImprovementNotation {get; set;}
[Element("group", typeof(Group), false, true, false, true)]
public IEnumerable<Group> Group {get; set;}
[Element("supplementalData", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> SupplementalData {get; set;}
[Element("evaluatedResource", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> EvaluatedResource {get; set;}

        #endregion
        #region Constructor
        public  MeasureReport() { }

        public  MeasureReport(string value) : base(value) { }
        public  MeasureReport(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "MeasureReport";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
