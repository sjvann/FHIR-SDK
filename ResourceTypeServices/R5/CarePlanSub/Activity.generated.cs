
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CarePlanSub
{
    public class Activity : BackboneElement<Activity>
    {

        #region Property
        [Element("performedActivity", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> PerformedActivity {get; set;}
[Element("progress", typeof(Annotation), false, true, false, false)]
public IEnumerable<Annotation> Progress {get; set;}
[Element("plannedActivityReference", typeof(Reference), false, false, false, false)]
public Reference PlannedActivityReference {get; set;}

        #endregion
        #region Constructor
        public  Activity() { }
        public  Activity(string value) : base(value) { }
        public  Activity(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Activity";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
