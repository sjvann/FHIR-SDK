
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class ChargeItem : BackboneElement<ChargeItem>
    {

        #region Property
        [Element("chargeItemCode", typeof(CodeableReference), false, false, false, false)]
public CodeableReference ChargeItemCode {get; set;}
[Element("count", typeof(Quantity), false, false, false, false)]
public Quantity Count {get; set;}
[Element("effectivePeriod", typeof(Period), false, false, false, false)]
public Period EffectivePeriod {get; set;}
[Element("useContext", typeof(UsageContext), false, true, false, false)]
public IEnumerable<UsageContext> UseContext {get; set;}

        #endregion
        #region Constructor
        public  ChargeItem() { }
        public  ChargeItem(string value) : base(value) { }
        public  ChargeItem(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ChargeItem";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
