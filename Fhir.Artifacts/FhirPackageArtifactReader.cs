using System.Formats.Tar;
using System.IO.Compression;
using System.Text.Json;

namespace Fhir.Artifacts;

/// <summary>只讀本機 <c>.tgz</c>，並列舉 conformance JSON。不做 HTTP Registry。</summary>
public static class FhirPackageArtifactReader
{
    private static readonly HashSet<string> ConformanceTypes = new(StringComparer.Ordinal)
    {
        "StructureDefinition", "ValueSet", "CodeSystem", "SearchParameter",
        "CapabilityStatement", "ImplementationGuide", "ConceptMap", "NamingSystem"
    };

    public static IReadOnlyList<ArtifactDocument> Read(string tgzPath)
    {
        using var stream = File.OpenRead(tgzPath);
        return Read(stream);
    }

    public static IReadOnlyList<ArtifactDocument> Read(Stream tgzStream)
    {
        var artifacts = new List<ArtifactDocument>();
        using var gzip = new GZipStream(tgzStream, CompressionMode.Decompress, leaveOpen: true);
        using var reader = new TarReader(gzip);

        while (reader.GetNextEntry() is { } entry)
        {
            if (entry.EntryType is not (TarEntryType.RegularFile or TarEntryType.V7RegularFile))
                continue;
            if (entry.DataStream is null)
                continue;

            var name = entry.Name.Replace('\\', '/');
            if (!name.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                continue;
            if (name.Contains("/example", StringComparison.OrdinalIgnoreCase)
                || name.Contains(".example.", StringComparison.OrdinalIgnoreCase))
                continue;

            using var ms = new MemoryStream();
            entry.DataStream.CopyTo(ms);
            var json = System.Text.Encoding.UTF8.GetString(ms.ToArray());
            if (!TryReadHeader(json, out var resourceType, out var canonical))
                continue;
            if (!ConformanceTypes.Contains(resourceType))
                continue;

            artifacts.Add(new ArtifactDocument(resourceType, canonical, json, Path.GetFileName(name)));
        }

        return artifacts;
    }

    internal static bool TryReadHeader(string json, out string resourceType, out string? canonical)
    {
        resourceType = "";
        canonical = null;
        try
        {
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            if (root.ValueKind != JsonValueKind.Object)
                return false;
            if (!root.TryGetProperty("resourceType", out var typeEl) || typeEl.ValueKind != JsonValueKind.String)
                return false;
            resourceType = typeEl.GetString() ?? "";
            if (root.TryGetProperty("url", out var urlEl) && urlEl.ValueKind == JsonValueKind.String)
                canonical = urlEl.GetString();
            return resourceType.Length > 0;
        }
        catch (JsonException)
        {
            return false;
        }
    }
}
