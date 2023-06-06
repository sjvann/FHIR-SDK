
using System.Text.Json.Nodes;
using DataTypeService.BaseTypes;
using Core.Attribute;
using DataTypeService.Primitive;
using DataTypeService.Complex;
using System.Reflection;
using Core.ExtensionImp;

namespace ResourceTypeBased
{
    public class Resource : DomainResource<Resource>
    {
        public Resource() { }
        public Resource(string? value) : base(value) { }
        public Resource(JsonNode? source) : base(source) { }
      
        #region Public Method

        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
