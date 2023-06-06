
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.TestPlanSub.TestCaseSub
{
    public class TestData : BackboneElement<TestData>
    {

        #region Property
        [Element("type", typeof(Coding), false, false, false, false)]
public Coding Type {get; set;}
[Element("content", typeof(Reference), false, false, false, false)]
public Reference Content {get; set;}
[Element("source", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Source {get; set;}

        #endregion
        #region Constructor
        public  TestData() { }
        public  TestData(string value) : base(value) { }
        public  TestData(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TestData";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
