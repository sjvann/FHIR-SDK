
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CodeSystemSub
{
    public class Filter : BackboneElement<Filter>
    {

        #region Property
        [Element("code", typeof(FhirCode), true, false, false, false)]
public FhirCode Code {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("operator", typeof(FhirCode), true, true, false, false)]
public IEnumerable<FhirCode> Operator {get; set;}
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
