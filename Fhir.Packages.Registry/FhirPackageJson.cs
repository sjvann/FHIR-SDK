using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fhir.Packages.Registry;

public sealed class FhirPackageJson
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("fhirVersions")]
    public List<string>? FhirVersions { get; set; }

    [JsonPropertyName("dependencies")]
    public Dictionary<string, string>? Dependencies { get; set; }

    public static FhirPackageJson? TryReadFromPackageDir(string packageDir)
    {
        var path = Path.Combine(packageDir, "package.json");
        if (!File.Exists(path))
            return null;

        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<FhirPackageJson>(json, JsonOptions);
    }

    static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        ReadCommentHandling = JsonCommentHandling.Skip,
        AllowTrailingCommas = true,
    };
}
