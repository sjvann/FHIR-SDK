using System.Text.Json;

namespace CodeGen.Services
{
    public interface ITypeInfoService
    {
        // Returns: ResourceType -> (elementPath -> list of FHIR type codes)
        IReadOnlyDictionary<string, IReadOnlyDictionary<string, IReadOnlyList<string>>> Load(Stream profilesJsonStream, ISet<string> resourceTypes);
    }

    public sealed class TypeInfoService : ITypeInfoService
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

                var dict = new Dictionary<string, IReadOnlyList<string>>(StringComparer.OrdinalIgnoreCase);
                foreach (var el in elements.EnumerateArray())
                {
                    var path = el.TryGetProperty("path", out var p) ? p.GetString() : null;
                    if (string.IsNullOrWhiteSpace(path)) continue;
                    var codes = new List<string>();
                    if (el.TryGetProperty("type", out var types) && types.ValueKind == JsonValueKind.Array)
                    {
                        foreach (var ty in types.EnumerateArray())
                        {
                            var code = ty.TryGetProperty("code", out var c) ? c.GetString() : null;
                            var norm = NormalizeTypeCode(code);
                            if (!string.IsNullOrWhiteSpace(norm)) codes.Add(norm!);
                        }
                    }
                    dict[path!] = codes;
                }

                map[type!] = dict;
            }

            return map;
        }

        private static string? NormalizeTypeCode(string? code)
        {
            if (string.IsNullOrWhiteSpace(code)) return code;
            const string hp = "http://hl7.org/fhirpath/System.";
            if (code!.StartsWith(hp, StringComparison.OrdinalIgnoreCase))
            {
                var name = code.Substring(hp.Length); // e.g., String, Boolean, Integer, Decimal, Date, Time, DateTime
                // Map to FHIR primitive codes (lower camel per FHIR)
                return name switch
                {
                    "String" => "string",
                    "Boolean" => "boolean",
                    "Integer" => "integer",
                    "Decimal" => "decimal",
                    "Date" => "date",
                    "Time" => "time",
                    "DateTime" => "dateTime",
                    _ => name
                };
            }
            return code;
        }
    }
}

