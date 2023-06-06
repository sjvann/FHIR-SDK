
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.PermissionSub.RuleSub
{
    public class Activity : BackboneElement<Activity>
    {

        #region Property
        [Element("actor", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Actor {get; set;}
[Element("action", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Action {get; set;}
[Element("purpose", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Purpose {get; set;}

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
