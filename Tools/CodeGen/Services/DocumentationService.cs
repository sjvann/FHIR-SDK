using System.Text.Json;

namespace CodeGen.Services;

public interface IDocumentationService
{
    /// <summary>
    /// Loads documentation strings for selected resource types.
    /// Returns a map: ResourceType -> (Path -> DocText).
    /// For class-level summaries, the key is the resource type name itself (e.g., "Patient").
    /// For element properties, use full element path (e.g., "Patient.name", "Observation.value[x]").
    /// </summary>
    IReadOnlyDictionary<string, IReadOnlyDictionary<string, string>> Load(Stream profilesJsonStream, ISet<string> resourceTypes);
}

public sealed class DocumentationService : IDocumentationService
{
    public IReadOnlyDictionary<string, IReadOnlyDictionary<string, string>> Load(Stream profilesJsonStream, ISet<string> resourceTypes)
    {
        using var doc = JsonDocument.Parse(profilesJsonStream);
        var root = doc.RootElement;
        var map = new Dictionary<string, IReadOnlyDictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

        if (!root.TryGetProperty("entry", out var entries) || entries.ValueKind != JsonValueKind.Array)
            return map;

        foreach (var ent in entries.EnumerateArray())
        {
            if (!ent.TryGetProperty("resource", out var res)) continue;
            if (!res.TryGetProperty("resourceType", out var rt) || !string.Equals(rt.GetString(), "StructureDefinition", StringComparison.OrdinalIgnoreCase)) continue;
            if (!res.TryGetProperty("kind", out var kind) || !string.Equals(kind.GetString(), "resource", StringComparison.OrdinalIgnoreCase)) continue;
            if (!res.TryGetProperty("type", out var t)) continue;
            var type = t.GetString();
            if (string.IsNullOrWhiteSpace(type) || !resourceTypes.Contains(type!)) continue;

            var docs = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            // Class-level description
            if (res.TryGetProperty("description", out var descEl))
            {
                var txt = descEl.GetString();
                if (!string.IsNullOrWhiteSpace(txt)) docs[type!] = txt!;
            }

            // Element-level docs from snapshot.element[].short/definition/comment
            if (res.TryGetProperty("snapshot", out var snapshot) && snapshot.TryGetProperty("element", out var elements) && elements.ValueKind == JsonValueKind.Array)
            {
                foreach (var el in elements.EnumerateArray())
                {
                    var path = el.TryGetProperty("path", out var p) ? p.GetString() : null;
                    if (string.IsNullOrWhiteSpace(path)) continue;
                    string? txt = null;
                    if (el.TryGetProperty("short", out var s)) txt = s.GetString();
                    if (string.IsNullOrWhiteSpace(txt) && el.TryGetProperty("definition", out var d)) txt = d.GetString();
                    if (string.IsNullOrWhiteSpace(txt) && el.TryGetProperty("comment", out var c)) txt = c.GetString();
                    if (!string.IsNullOrWhiteSpace(txt)) docs[path!] = txt!;
                }
            }

            map[type!] = docs;
        }

        return map;
    }
}

