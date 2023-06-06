
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ObservationSub
{
    public class TriggeredBy : BackboneElement<TriggeredBy>
    {

        #region Property
        [Element("observation", typeof(Reference), false, false, false, false)]
public Reference Observation {get; set;}
[Element("type", typeof(FhirCode), true, false, false, false)]
public FhirCode Type {get; set;}
[Element("reason", typeof(FhirString), true, false, false, false)]
public FhirString Reason {get; set;}

        #endregion
        #region Constructor
        public  TriggeredBy() { }
        public  TriggeredBy(string value) : base(value) { }
        public  TriggeredBy(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "TriggeredBy";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
