using System;
using System.Text.Json.Nodes;

namespace FhirSDK.Resources.R5.Tests.Generic;

public static class JsonPointer
{
    // Very small JSON Pointer-ish selector supporting /a/b/0 style
    public static JsonNode? Select(JsonObject root, string path)
    {
        if (string.IsNullOrEmpty(path) || path == "/") return root;
        if (!path.StartsWith('/')) throw new ArgumentException("Path must start with '/'");
        JsonNode? current = root;
        var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        foreach (var raw in parts)
        {
            if (current is JsonObject obj)
            {
                current = obj[raw];
            }
            else if (current is JsonArray arr && int.TryParse(raw, out var idx))
            {
                current = idx >= 0 && idx < arr.Count ? arr[idx] : null;
            }
            else return null;
        }
        return current;
    }
}

