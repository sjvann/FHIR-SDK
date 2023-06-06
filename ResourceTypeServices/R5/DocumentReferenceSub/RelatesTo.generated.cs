
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DocumentReferenceSub
{
    public class RelatesTo : BackboneElement<RelatesTo>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("target", typeof(Reference), false, false, false, false)]
public Reference Target {get; set;}

        #endregion
        #region Constructor
        public  RelatesTo() { }
        public  RelatesTo(string value) : base(value) { }
        public  RelatesTo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatesTo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
