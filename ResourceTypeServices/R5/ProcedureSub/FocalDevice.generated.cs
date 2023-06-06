
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ProcedureSub
{
    public class FocalDevice : BackboneElement<FocalDevice>
    {

        #region Property
        [Element("action", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Action {get; set;}
[Element("manipulated", typeof(Reference), false, false, false, false)]
public Reference Manipulated {get; set;}

        #endregion
        #region Constructor
        public  FocalDevice() { }
        public  FocalDevice(string value) : base(value) { }
        public  FocalDevice(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "FocalDevice";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
