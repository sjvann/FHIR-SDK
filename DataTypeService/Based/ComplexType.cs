using System.Text.Json.Nodes;

namespace DataTypeService.Based
{
    public abstract class ComplexType : DataType, IComplexType
    {
        public IEnumerable<KeyValuePair<string, JsonNode?>>? GetProperties()
        {
            if (_Properties == null) SetProperties();
            return _Properties;
        }
        public virtual JsonNode? GetJsonNode()
        {
            if (_Properties == null) SetProperties();
            if (_Properties != null)
            {
                return new JsonObject(_Properties);
            }
            else if (_JsonNode != null)
            {
                return _JsonNode;
            }
            return null;

        }

        public abstract void SetProperties();
    }
}
