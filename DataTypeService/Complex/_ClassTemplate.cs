using Core.Extension;
using DataTypeService.Based;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class ClassTemplate : ComplexType
    {

        #region Property

        #endregion
        #region Constructor
        public ClassTemplate() { }
        public ClassTemplate(string? value) : this(value.Parse()) { }
        public ClassTemplate(JsonNode? source)
        {
            _JsonNode = source;
           
        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ClassTemplate";

        #endregion

        #region public Method
        public override void SetProperties()
        {
            List<KeyValuePair<string, JsonNode?>> result = new();
            _Properties = result;
        }



        #endregion
    }
}
