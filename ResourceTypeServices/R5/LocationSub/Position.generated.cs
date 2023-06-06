
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.LocationSub
{
    public class Position : BackboneElement<Position>
    {

        #region Property
        [Element("longitude", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Longitude {get; set;}
[Element("latitude", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Latitude {get; set;}
[Element("altitude", typeof(FhirDecimal), true, false, false, false)]
public FhirDecimal Altitude {get; set;}

        #endregion
        #region Constructor
        public  Position() { }
        public  Position(string value) : base(value) { }
        public  Position(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Position";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
