namespace Fhir.Artifacts;

/// <summary>以 <see cref="FhirPackageArtifactReader"/> 讀取本機 <c>.tgz</c> 後作為 <see cref="IArtifactResolver"/>。</summary>
public sealed class PackageArtifactSource : IArtifactResolver
{
    private readonly Dictionary<string, ArtifactDocument> _byCanonical = new(StringComparer.Ordinal);
    private readonly List<ArtifactDocument> _all;

    public PackageArtifactSource(string tgzPath)
        : this(FhirPackageArtifactReader.Read(tgzPath))
    {
    }

    public PackageArtifactSource(Stream tgzStream)
        : this(FhirPackageArtifactReader.Read(tgzStream))
    {
    }

    public PackageArtifactSource(IReadOnlyList<ArtifactDocument> artifacts)
    {
        _all = artifacts.ToList();
        foreach (var doc in _all)
        {
            if (string.IsNullOrEmpty(doc.Canonical))
                continue;
            _byCanonical[StripVersion(doc.Canonical)] = doc;
        }
    }

    public bool TryResolve(string canonical, out ArtifactDocument document)
        => _byCanonical.TryGetValue(StripVersion(canonical), out document!)
           || _byCanonical.TryGetValue(canonical, out document!);

    public IEnumerable<ArtifactDocument> Enumerate() => _all;

    private static string StripVersion(string canonical)
    {
        var pipe = canonical.IndexOf('|');
        return pipe < 0 ? canonical : canonical[..pipe];
    }
}
