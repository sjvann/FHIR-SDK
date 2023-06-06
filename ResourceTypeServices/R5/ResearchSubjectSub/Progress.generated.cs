
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ResearchSubjectSub
{
    public class Progress : BackboneElement<Progress>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("subjectState", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept SubjectState {get; set;}
[Element("milestone", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Milestone {get; set;}
[Element("reason", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Reason {get; set;}
[Element("startDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime StartDate {get; set;}
[Element("endDate", typeof(FhirDateTime), true, false, false, false)]
public FhirDateTime EndDate {get; set;}

        #endregion
        #region Constructor
        public  Progress() { }
        public  Progress(string value) : base(value) { }
        public  Progress(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Progress";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
