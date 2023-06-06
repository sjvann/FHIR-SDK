
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.TestScriptSub.TestSub;

namespace ResourceTypeServices.R5.TestScriptSub
{
    public class Test : BackboneElement<Test>
    {

        #region Property
        [Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("action", typeof(ResourceTypeServices.R5.TestScriptSub.TestSub.Action), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.TestScriptSub.TestSub.Action> Action {get; set;}

        #endregion
        #region Constructor
        public  Test() { }
        public  Test(string value) : base(value) { }
        public  Test(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Test";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
