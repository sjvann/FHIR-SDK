
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.AuditEventSub.EntitySub
{
    public class Detail : BackboneElement<Detail>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}

        #endregion
        #region Constructor
        public  Detail() { }
        public  Detail(string value) : base(value) { }
        public  Detail(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Detail";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
