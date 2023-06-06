
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationRequestSub.DispenseRequestSub
{
    public class InitialFill : BackboneElement<InitialFill>
    {

        #region Property
        [Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("duration", typeof(Duration), false, false, false, false)]
public Duration Duration {get; set;}

        #endregion
        #region Constructor
        public  InitialFill() { }
        public  InitialFill(string value) : base(value) { }
        public  InitialFill(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "InitialFill";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
