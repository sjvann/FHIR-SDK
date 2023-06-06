

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.GoalSub
{
    public class Goal : DomainResource<Goal>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("lifecycleStatus", typeof(FhirCode), true, false, false, false)]
public FhirCode LifecycleStatus {get; set;}
[Element("achievementStatus", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AchievementStatus {get; set;}
[Element("category", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Category {get; set;}
[Element("continuous", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Continuous {get; set;}
[Element("priority", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Priority {get; set;}
[Element("description", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Description {get; set;}
[Element("subject", typeof(Reference), false, false, false, false)]
public Reference Subject {get; set;}
[Element("start", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Start {get; set;}
[Element("target", typeof(Target), false, true, false, true)]
public IEnumerable<Target> Target {get; set;}
[Element("statusDate", typeof(FhirDate), true, false, false, false)]
public FhirDate StatusDate {get; set;}
[Element("statusReason", typeof(FhirString), true, false, false, false)]
public FhirString StatusReason {get; set;}
[Element("source", typeof(Reference), false, false, false, false)]
public Reference Source {get; set;}
[Element("addresses", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Addresses {get; set;}
[Element("note", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Note {get; set;}
[Element("outcome", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Outcome {get; set;}

        #endregion
        #region Constructor
        public  Goal() { }

        public  Goal(string value) : base(value) { }
        public  Goal(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Goal";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
