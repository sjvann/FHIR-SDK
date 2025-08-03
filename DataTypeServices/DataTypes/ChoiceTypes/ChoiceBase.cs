using FhirCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeServices.DataTypes.ChoiceTypes
{
    public abstract class ChoiceBase
    {
        private readonly string? _propertyName;
        private readonly JsonNode? _propertyValue;
        protected ChoiceBase() { }
        protected ChoiceBase(KeyValuePair<string, JsonNode?> value)
        {
            _propertyName = value.Key;
            _propertyValue = value.Value;
        }
        protected ChoiceBase(string propertyName, JsonNode? propertyValue)
        {
            _propertyName = propertyName;
            _propertyValue = propertyValue;
        }
        protected ChoiceBase(string prefix, IComplexType value)
        {
            _propertyName = $"{prefix}{value.GetFhirTypeName()}";
            _propertyValue = value.GetJsonObject();
        }
        protected ChoiceBase(string prefix, IPrimitiveType value)
        {
            _propertyName = $"{prefix}{value.GetFhirTypeName()}";
            _propertyValue = value.GetJsonValue();
        }
        public KeyValuePair<string, JsonNode?> GetProperty()
        {
            if (string.IsNullOrEmpty(_propertyName))
            {
                return new KeyValuePair<string, JsonNode?>("value", _propertyValue);
            }
            else
            {
                return new KeyValuePair<string, JsonNode?>(_propertyName, _propertyValue);
            }
        }
        public JsonNode? GetJsonNode()
        {
            JsonObject result = new();
            result.Add(GetProperty());
            return result;
        }

    }
}
