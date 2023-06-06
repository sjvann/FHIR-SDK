
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.StructureDefinitionSub
{
    public class Snapshot : BackboneElement<Snapshot>
    {

        #region Property
        [Element("element", typeof(ElementDefinition), false, true, false, false)]
public IEnumerable<ElementDefinition> Element {get; set;}

        #endregion
        #region Constructor
        public  Snapshot() { }
        public  Snapshot(string value) : base(value) { }
        public  Snapshot(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Snapshot";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
