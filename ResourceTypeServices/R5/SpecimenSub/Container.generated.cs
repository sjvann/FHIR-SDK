
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SpecimenSub
{
    public class Container : BackboneElement<Container>
    {

        #region Property
        [Element("device", typeof(Reference), false, false, false, false)]
public Reference Device {get; set;}
[Element("location", typeof(Reference), false, false, false, false)]
public Reference Location {get; set;}
[Element("specimenQuantity", typeof(Quantity), false, false, false, false)]
public Quantity SpecimenQuantity {get; set;}

        #endregion
        #region Constructor
        public  Container() { }
        public  Container(string value) : base(value) { }
        public  Container(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Container";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
