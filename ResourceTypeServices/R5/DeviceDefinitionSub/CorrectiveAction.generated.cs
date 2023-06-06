
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class CorrectiveAction : BackboneElement<CorrectiveAction>
    {

        #region Property
        [Element("recall", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Recall {get; set;}
[Element("scope", typeof(FhirCode), true, false, false, false)]
public FhirCode Scope {get; set;}
[Element("period", typeof(Period), false, false, false, false)]
public Period Period {get; set;}

        #endregion
        #region Constructor
        public  CorrectiveAction() { }
        public  CorrectiveAction(string value) : base(value) { }
        public  CorrectiveAction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CorrectiveAction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
