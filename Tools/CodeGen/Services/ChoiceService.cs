using System.Text.Json;

namespace CodeGen.Services
{
    public interface IChoiceService
    {
        // Returns: ResourceType -> (baseElementPath e.g. "Observation.value[x]" -> list of FHIR type codes e.g. ["CodeableConcept","Quantity",...])
        IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>> Load(Stream profilesJsonStream, ISet<string> resourceTypes);
    }

    public sealed class ChoiceService : IChoiceService
    {
        public IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>> Load(Stream profilesJsonStream, ISet<string> resourceTypes)
        {
            using var doc = JsonDocument.Parse(profilesJsonStream);
            var root = doc.RootElement;
            var map = new Dictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>>(StringComparer.OrdinalIgnoreCase);

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

                var choices = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase);
                foreach (var el in elements.EnumerateArray())
                {
                    var path = el.TryGetProperty("path", out var p) ? p.GetString() : null;
                    if (string.IsNullOrWhiteSpace(path)) continue;
                    if (!path!.Contains("[x]", StringComparison.Ordinal)) continue;
                    if (!el.TryGetProperty("type", out var types) || types.ValueKind != JsonValueKind.Array) continue;

                    var codes = new List<string>();
                    foreach (var ty in types.EnumerateArray())
                    {
                        var code = ty.TryGetProperty("code", out var c) ? c.GetString() : null;
                        if (!string.IsNullOrWhiteSpace(code)) codes.Add(code!);
                    }
                    if (codes.Count > 0)
                        choices[path] = codes;
                }

                if (choices.Count > 0)
                    map[type!] = choices;
            }

            return map;
        }
    }
}

