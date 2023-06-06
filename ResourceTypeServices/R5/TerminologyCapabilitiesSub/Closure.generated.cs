
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.TerminologyCapabilitiesSub
{
    public class Closure : BackboneElement<Closure>
    {

        #region Property
        [Element("translation", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Translation {get; set;}

        #endregion
        #region Constructor
        public  Closure() { }
        public  Closure(string value) : base(value) { }
        public  Closure(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Closure";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
