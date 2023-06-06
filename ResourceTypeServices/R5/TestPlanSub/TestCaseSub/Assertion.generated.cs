
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.TestPlanSub.TestCaseSub
{
    public class Assertion : BackboneElement<Assertion>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Type {get; set;}
[Element("object", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Object {get; set;}
[Element("result", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> Result {get; set;}

        #endregion
        #region Constructor
        public  Assertion() { }
        public  Assertion(string value) : base(value) { }
        public  Assertion(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Assertion";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
