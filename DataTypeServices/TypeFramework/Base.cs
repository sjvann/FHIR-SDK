using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.TypeFramework
{
    public abstract class Base : IBase
    {
        protected List<KeyValuePair<string, JsonNode?>>? _ElementProperties;
        protected List<KeyValuePair<string, JsonNode?>>? _Properties;

        public abstract string GetFhirTypeName(bool withCapital = true);

        public JsonNode? GetJsonNode()
        {
            JsonObject jsonObject = new ();

            if (_ElementProperties != null && _ElementProperties.Count > 0)
            {
                foreach (var item in _ElementProperties)
                {
                    jsonObject.Add(item.Key, item.Value);
                }
            }
            if (_Properties != null && _Properties.Count > 0)
            {
                {
                    foreach (var item in _Properties)
                    {
                        if (!jsonObject.ContainsKey(item.Key))
                        {
                            jsonObject.Add(item.Key, item.Value);
                        }
                    }
                }
            }
            return jsonObject;

        }
        public List<KeyValuePair<string, JsonNode?>>? GetPropertyValues() => _ElementProperties;

        public virtual string ToJsonString()
        {
            JsonObject? jObject = GetJsonNode() as JsonObject;
            return jObject?.SerializeCustom() ?? string.Empty;
        }

    }
}
