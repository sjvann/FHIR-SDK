

using Core.Attribute;
using DataTypeService.BaseTypes;
using ResourceTypeBased;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ScheduleSub
{
    public class Schedule : DomainResource<Schedule>
    {
        #region Property
        [Element("identifier", typeof(Identifier), false, true, false, false)]
public IEnumerable<Identifier> Identifier {get; set;}
[Element("active", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Active {get; set;}
[Element("serviceCategory", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ServiceCategory {get; set;}
[Element("serviceType", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> ServiceType {get; set;}
[Element("specialty", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Specialty {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("actor", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Actor {get; set;}
[Element("planningHorizon", typeof(Period), false, false, false, false)]
public Period PlanningHorizon {get; set;}
[Element("comment", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Comment {get; set;}

        #endregion
        #region Constructor
        public  Schedule() { }

        public  Schedule(string value) : base(value) { }
        public  Schedule(JsonNode source) : base(source) { }
       
        #endregion
        #region From Parent
        protected override string _TypeName => "Schedule";
        #endregion

        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
