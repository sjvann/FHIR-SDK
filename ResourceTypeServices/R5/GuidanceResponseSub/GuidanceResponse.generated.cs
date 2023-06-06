

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GuidanceResponseSub
{
    public class GuidanceResponse : DomainResource<GuidanceResponse>
    {
        #region Property
        [Element("requestIdentifier", typeof(Identifier), false, false, false, false)]
public Identifier RequestIdentifier {get; set;}
[Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("module", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Module {get; set;}
[Element("status", typeof(FhirCode), true, false, false, false)]
public FhirCode Status {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("encounter", typeof(Reference), false, false, false, false)]
public Reference Encounter {get; set;}
[Element("occurrenceDateTime", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime OccurrenceDateTime {get; set;}
[Element("performer", typeof(Reference), false, false, false, false)]
public Reference Performer {get; set;}
[Element("reason", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Reason {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("evaluationMessage", typeof(Reference), false, false, false, false)]
public Reference EvaluationMessage {get; set;}
[Element("outputParameters", typeof(Reference), false, false, false, false)]
public Reference OutputParameters {get; set;}
[Element("result", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Result {get; set;}
[Element("dataRequirement", typeof(DataRequirement), false, true, false, false)]
public IEnumerable<DataRequirement> DataRequirement {get; set;}

        #endregion
        #region Constructor
        public  GuidanceResponse() { }

        public  GuidanceResponse(string value) : base(value) { }
        public  GuidanceResponse(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "GuidanceResponse";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
