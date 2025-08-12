using System.Text.Json.Nodes;
using System.Collections.Generic;
using DataTypeServices.DataTypes.SpecialTypes;

namespace DataTypeServices.TypeFramework
{
    public static class ExtensionListJsonExtensions
    {
        public static JsonNode? GetJsonValue(this List<Extension> extensions)
        {
            if (extensions == null || extensions.Count == 0) return null;
            var arr = new JsonArray();
            foreach (var ext in extensions)
            {
                var obj = ext.GetJsonObject();
                if (obj != null) arr.Add(obj);
            }
            return arr;
        }
    }
}

