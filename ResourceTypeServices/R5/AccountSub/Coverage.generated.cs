
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AccountSub
{
    public class Coverage : BackboneElement<Coverage>
    {

        #region Property
        [Element("coverage", typeof(Reference), false, false, false, false)]
public Reference CoverageProp {get; set;}
[Element("priority", typeof(FhirPositiveInt), true, false, false, false)]
public FhirPositiveInt Priority {get; set;}

        #endregion
        #region Constructor
        public  Coverage() { }
        public  Coverage(string value) : base(value) { }
        public  Coverage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Coverage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
