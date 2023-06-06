
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.MeasureSub.GroupSub;

namespace ResourceTypeServices.R5.MeasureSub
{
    public class Group : BackboneElement<Group>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("subject", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Subject {get; set;}
[Element("basis", typeof(FhirCode), true, false, false, false)]
public FhirCode Basis {get; set;}
[Element("scoring", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Scoring {get; set;}
[Element("scoringUnit", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ScoringUnit {get; set;}
[Element("rateAggregation", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown RateAggregation {get; set;}
[Element("improvementNotation", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept ImprovementNotation {get; set;}
[Element("library", typeof(FhirCanonical), true, true, false, false)]
public IEnumerable<FhirCanonical> Library {get; set;}
[Element("population", typeof(Population), false, true, false, true)]
public IEnumerable<Population> Population {get; set;}
[Element("stratifier", typeof(Stratifier), false, true, false, true)]
public IEnumerable<Stratifier> Stratifier {get; set;}

        #endregion
        #region Constructor
        public  Group() { }
        public  Group(string value) : base(value) { }
        public  Group(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Group";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
