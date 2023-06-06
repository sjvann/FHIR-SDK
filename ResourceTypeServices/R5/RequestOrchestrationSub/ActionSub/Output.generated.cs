
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.RequestOrchestrationSub.ActionSub
{
    public class Output : BackboneElement<Output>
    {

        #region Property
        [Element("title", typeof(FhirString), true, false, false, false)]
public FhirString Title {get; set;}
[Element("requirement", typeof(DataRequirement), false, false, false, false)]
public DataRequirement Requirement {get; set;}
[Element("relatedData", typeof(FhirString), true, false, false, false)]
public FhirString RelatedData {get; set;}

        #endregion
        #region Constructor
        public  Output() { }
        public  Output(string value) : base(value) { }
        public  Output(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Output";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
