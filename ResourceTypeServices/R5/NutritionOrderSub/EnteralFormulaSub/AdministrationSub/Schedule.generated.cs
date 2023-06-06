
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.NutritionOrderSub.EnteralFormulaSub.AdministrationSub
{
    public class Schedule : BackboneElement<Schedule>
    {

        #region Property
        [Element("timing", typeof(Timing), false, true, false, false)]
public IEnumerable<Timing> Timing {get; set;}
[Element("asNeeded", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AsNeeded {get; set;}
[Element("asNeededFor", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept AsNeededFor {get; set;}

        #endregion
        #region Constructor
        public  Schedule() { }
        public  Schedule(string value) : base(value) { }
        public  Schedule(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Schedule";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
