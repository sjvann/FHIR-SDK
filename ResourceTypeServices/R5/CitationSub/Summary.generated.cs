
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.CitationSub
{
    public class Summary : BackboneElement<Summary>
    {

        #region Property
        [Element("style", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Style {get; set;}

        #endregion
        #region Constructor
        public  Summary() { }
        public  Summary(string value) : base(value) { }
        public  Summary(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Summary";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
