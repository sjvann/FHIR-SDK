
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.StructureMapSub
{
    public class Const : BackboneElement<Const>
    {

        #region Property
        [Element("name", typeof(FhirId), true, false, false, false)]
public FhirId Name {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}

        #endregion
        #region Constructor
        public  Const() { }
        public  Const(string value) : base(value) { }
        public  Const(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Const";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
