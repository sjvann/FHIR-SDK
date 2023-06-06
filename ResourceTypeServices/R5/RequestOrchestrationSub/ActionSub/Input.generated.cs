
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RequestOrchestrationSub.ActionSub
{
    public class Input : BackboneElement<Input>
    {

        #region Property
        [Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("requirement", typeof(DataRequirement), false, false, false, false)]
public DataRequirement Requirement {get; set;}
[Element("relatedData", typeof(FhirId), true, false, false, false)]
public FhirId RelatedData {get; set;}

        #endregion
        #region Constructor
        public  Input() { }
        public  Input(string value) : base(value) { }
        public  Input(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Input";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
