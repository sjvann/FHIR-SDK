
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CapabilityStatementSub.MessagingSub
{
    public class Endpoint : BackboneElement<Endpoint>
    {

        #region Property
        [Element("protocol", typeof(Coding), false, false, false, false)]
public Coding Protocol {get; set;}
[Element("address", typeof(FhirUrl), true, false, false, false)]
public FhirUrl Address {get; set;}

        #endregion
        #region Constructor
        public  Endpoint() { }
        public  Endpoint(string value) : base(value) { }
        public  Endpoint(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Endpoint";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
