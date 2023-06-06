
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.ValueSetSub.ComposeSub.IncludeSub
{
    public class Filter : BackboneElement<Filter>
    {

        #region Property
        [Element("property", typeof(FhirCode), true, false, false, false)]
public FhirCode Property {get; set;}
[Element("op", typeof(FhirCode), true, false, false, false)]
public FhirCode Op {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  Filter() { }
        public  Filter(string value) : base(value) { }
        public  Filter(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Filter";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
