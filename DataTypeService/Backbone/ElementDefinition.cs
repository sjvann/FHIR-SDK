using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Backbone
{
    public class ElementDefinition : ComplexType<ElementDefinition>
    {

        #region Property

        #endregion
        #region Constructor
        public ElementDefinition() { }
  
        public ElementDefinition(string? value) : base(value) { }
        public ElementDefinition(JsonNode? source) : base(source) { }

        #endregion
        #region From Parent
        protected override string _TypeName => "ElementDefinition";

        #endregion

        #region Private Method
        public override JsonNode? GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
