
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TestPlanSub.TestCaseSub
{
    public class Dependency : BackboneElement<Dependency>
    {

        #region Property
        [Element("description", typeof(FhirMarkdown), true, false, false, false)]
public FhirMarkdown Description {get; set;}
[Element("predecessor", typeof(Reference), false, false, false, false)]
public Reference Predecessor {get; set;}

        #endregion
        #region Constructor
        public  Dependency() { }
        public  Dependency(string value) : base(value) { }
        public  Dependency(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Dependency";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
