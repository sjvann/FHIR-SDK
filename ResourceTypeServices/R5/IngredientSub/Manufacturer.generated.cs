
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.IngredientSub
{
    public class Manufacturer : BackboneElement<Manufacturer>
    {

        #region Property
        [Element("role", typeof(FhirCode), true, false, false, false)]
public FhirCode Role {get; set;}
[Element("manufacturer", typeof(Reference), false, false, false, false)]
public Reference ManufacturerProp {get; set;}

        #endregion
        #region Constructor
        public  Manufacturer() { }
        public  Manufacturer(string value) : base(value) { }
        public  Manufacturer(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Manufacturer";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
