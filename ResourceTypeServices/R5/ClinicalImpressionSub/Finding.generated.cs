
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ClinicalImpressionSub
{
    public class Finding : BackboneElement<Finding>
    {

        #region Property
        [Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("basis", typeof(FhirString), true, false, false, false)]
public FhirString Basis {get; set;}

        #endregion
        #region Constructor
        public  Finding() { }
        public  Finding(string value) : base(value) { }
        public  Finding(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Finding";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
