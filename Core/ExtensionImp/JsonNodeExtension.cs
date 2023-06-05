using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Core.ExtensionImp
{
    public static class JsonNodeExtension
    {
        public static object? ParseToResource(this JsonNode node)
        {
            if (node == null) return null;
            var typeName = node["resourceType"]?.ToString();
            if (typeName == null) return null;
            Type? type = Type.GetType(typeName);

            return type == null ? null : Activator.CreateInstance(type, node);
        }
    }
}
