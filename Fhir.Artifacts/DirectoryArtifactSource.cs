namespace Fhir.Artifacts;

/// <summary>掃描目錄內 JSON，建立 canonical → 文件對照。</summary>
public sealed class DirectoryArtifactSource : IArtifactResolver
{
    private readonly Dictionary<string, ArtifactDocument> _byCanonical = new(StringComparer.Ordinal);

    public DirectoryArtifactSource(string directory)
    {
        if (!Directory.Exists(directory))
            return;

        foreach (var file in Directory.EnumerateFiles(directory, "*.json", SearchOption.AllDirectories))
        {
            string json;
            try
            {
                json = File.ReadAllText(file);
            }
            catch
            {
                continue;
            }

            if (!FhirPackageArtifactReader.TryReadHeader(json, out var resourceType, out var canonical))
                continue;

            var doc = new ArtifactDocument(resourceType, canonical, json, Path.GetFileName(file));
            if (!string.IsNullOrEmpty(canonical))
                _byCanonical[StripVersion(canonical)] = doc;
        }
    }

    public bool TryResolve(string canonical, out ArtifactDocument document)
        => _byCanonical.TryGetValue(StripVersion(canonical), out document!)
           || _byCanonical.TryGetValue(canonical, out document!);

    public IEnumerable<ArtifactDocument> Enumerate() => _byCanonical.Values;

    private static string StripVersion(string canonical)
    {
        var pipe = canonical.IndexOf('|');
        return pipe < 0 ? canonical : canonical[..pipe];
    }
}
