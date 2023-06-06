
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.RegulatorySub
{
    public class MaxDispense : BackboneElement<MaxDispense>
    {

        #region Property
        [Element("quantity", typeof(Quantity), false, false, false, false)]
public Quantity Quantity {get; set;}
[Element("period", typeof(Duration), false, false, false, false)]
public Duration Period {get; set;}

        #endregion
        #region Constructor
        public  MaxDispense() { }
        public  MaxDispense(string value) : base(value) { }
        public  MaxDispense(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MaxDispense";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
