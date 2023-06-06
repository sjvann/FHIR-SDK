
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.StructureDefinitionSub
{
    public class Differential : BackboneElement<Differential>
    {

        #region Property
        [Element("element", typeof(ElementDefinition), false, true, false, false)]
public IEnumerable<ElementDefinition> Element {get; set;}

        #endregion
        #region Constructor
        public  Differential() { }
        public  Differential(string value) : base(value) { }
        public  Differential(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Differential";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
