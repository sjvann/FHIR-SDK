using System.Text.Json;
using CodeGen.Models;

namespace CodeGen.Services;

public interface ICardinalityService
{
    /// <summary>
    /// For each resource type, returns a map from element path (e.g., "Patient.name", "Observation.value[x]") to its cardinality.
    /// </summary>
    IReadOnlyDictionary<string, IReadOnlyDictionary<string, Cardinality>> Load(Stream profilesJsonStream, ISet<string> resourceTypes);
}

public sealed class CardinalityService : ICardinalityService
{
    public IReadOnlyDictionary<string, IReadOnlyDictionary<string, Cardinality>> Load(Stream profilesJsonStream, ISet<string> resourceTypes)
    {
        using var doc = JsonDocument.Parse(profilesJsonStream);
        var root = doc.RootElement;
        var map = new Dictionary<string, IReadOnlyDictionary<string, Cardinality>>(StringComparer.OrdinalIgnoreCase);

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

            if (!res.TryGetProperty("snapshot", out var snapshot) || !snapshot.TryGetProperty("element", out var elements) || elements.ValueKind != JsonValueKind.Array)
                continue;

            var card = new Dictionary<string, Cardinality>(StringComparer.OrdinalIgnoreCase);
            foreach (var el in elements.EnumerateArray())
            {
                var path = el.TryGetProperty("path", out var p) ? p.GetString() : null;
                if (string.IsNullOrWhiteSpace(path)) continue;
                int min = el.TryGetProperty("min", out var minEl) && minEl.TryGetInt32(out var mi) ? mi : 0;
                string max = el.TryGetProperty("max", out var maxEl) ? (maxEl.GetString() ?? "1") : "1";
                card[path!] = new Cardinality(min, max);
            }

            map[type!] = card;
        }

        return map;
    }
}
