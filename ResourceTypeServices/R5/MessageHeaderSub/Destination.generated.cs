
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MessageHeaderSub
{
    public class Destination : BackboneElement<Destination>
    {

        #region Property
        [Element("endpoint", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Endpoint {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("target", typeof(Reference), false, false, false, false)]
public Reference Target {get; set;}
[Element("receiver", typeof(Reference), false, false, false, false)]
public Reference Receiver {get; set;}

        #endregion
        #region Constructor
        public  Destination() { }
        public  Destination(string value) : base(value) { }
        public  Destination(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Destination";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
