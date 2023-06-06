
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.PlanDefinitionSub.GoalSub;

namespace ResourceTypeServices.R5.PlanDefinitionSub
{
    public class Goal : BackboneElement<Goal>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("description", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Description {get; set;}
[Element("priority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Priority {get; set;}
[Element("start", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Start {get; set;}
[Element("addresses", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Addresses {get; set;}
[Element("documentation", typeof(RelatedArtifact), false, true, false, false)]
public IEnumerable<RelatedArtifact> Documentation {get; set;}
[Element("target", typeof(Target), false, true, false, true)]
public IEnumerable<Target> Target {get; set;}

        #endregion
        #region Constructor
        public  Goal() { }
        public  Goal(string value) : base(value) { }
        public  Goal(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Goal";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
