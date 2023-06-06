
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.PlanDefinitionSub.ActionSub;

namespace ResourceTypeServices.R5.PlanDefinitionSub
{
    public class Action : BackboneElement<Action>
    {

        #region Property
        [Element("linkId", typeof(FhirString), true, false, false, false)]
public FhirString LinkId {get; set;}
[Element("prefix", typeof(FhirString), true, false, false, false)]
public FhirString Prefix {get; set;}
[Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("textEquivalent", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown TextEquivalent {get; set;}
[Element("priority", typeof(FhirCode), true, false, false, false)]
public FhirCode Priority {get; set;}
[Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("reason", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Reason {get; set;}
[Element("documentation", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> Documentation {get; set;}
[Element("goalId", typeof(FhirId), true, true, false, false)]
public IEnumerable<FhirId> GoalId {get; set;}
[Element("subject", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Subject {get; set;}
[Element("trigger", typeof(TriggerDefinition), false, true, false, false)]
public IEnumerable<TriggerDefinition> Trigger {get; set;}
[Element("condition", typeof(Condition), false, true, false, true)]
public IEnumerable<Condition> Condition {get; set;}
[Element("input", typeof(Input), false, true, false, true)]
public IEnumerable<Input> Input {get; set;}
[Element("output", typeof(Output), false, true, false, true)]
public IEnumerable<Output> Output {get; set;}
[Element("relatedAction", typeof(RelatedAction), false, true, false, true)]
public IEnumerable<RelatedAction> RelatedAction {get; set;}
[Element("timing", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Timing {get; set;}
[Element("location", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Location {get; set;}
[Element("participant", typeof(Participant), false, true, false, true)]
public IEnumerable<Participant> Participant {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("groupingBehavior", typeof(FhirCode), true, false, false, false)]
public FhirCode GroupingBehavior {get; set;}
[Element("selectionBehavior", typeof(FhirCode), true, false, false, false)]
public FhirCode SelectionBehavior {get; set;}
[Element("requiredBehavior", typeof(FhirCode), true, false, false, false)]
public FhirCode RequiredBehavior {get; set;}
[Element("precheckBehavior", typeof(FhirCode), true, false, false, false)]
public FhirCode PrecheckBehavior {get; set;}
[Element("cardinalityBehavior", typeof(FhirCode), true, false, false, false)]
public FhirCode CardinalityBehavior {get; set;}
[Element("definition", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Definition {get; set;}
[Element("transform", typeof(FhirCanonical), true, false, false, false)]
public FhirCanonical Transform {get; set;}
[Element("dynamicValue", typeof(DynamicValue), false, true, false, true)]
public IEnumerable<DynamicValue> DynamicValue {get; set;}

        #endregion
        #region Constructor
        public  Action() { }
        public  Action(string value) : base(value) { }
        public  Action(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Action";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
