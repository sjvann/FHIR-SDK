
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SupplyRequestSub
{
    public class Parameter : BackboneElement<Parameter>
    {

        #region Property
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Code {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Parameter() { }
        public  Parameter(string value) : base(value) { }
        public  Parameter(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Parameter";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
