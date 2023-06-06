
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.TestPlanSub.TestCaseSub.TestRunSub
{
    public class Script : BackboneElement<Script>
    {

        #region Property
        [Element("language", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Language {get; set;}
[Element("source", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Source {get; set;}

        #endregion
        #region Constructor
        public  Script() { }
        public  Script(string value) : base(value) { }
        public  Script(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Script";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
