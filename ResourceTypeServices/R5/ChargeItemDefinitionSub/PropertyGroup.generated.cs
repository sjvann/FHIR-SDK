
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ChargeItemDefinitionSub
{
    public class PropertyGroup : BackboneElement<PropertyGroup>
    {

        #region Property
        [Element("priceComponent", typeof(MonetaryComponent), false, true, false, false)]
public IEnumerable<MonetaryComponent> PriceComponent {get; set;}

        #endregion
        #region Constructor
        public  PropertyGroup() { }
        public  PropertyGroup(string value) : base(value) { }
        public  PropertyGroup(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "PropertyGroup";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
