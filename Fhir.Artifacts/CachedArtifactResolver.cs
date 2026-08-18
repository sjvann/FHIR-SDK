namespace Fhir.Artifacts;

/// <summary>快取 <see cref="IArtifactResolver.TryResolve"/> 結果。</summary>
public sealed class CachedArtifactResolver : IArtifactResolver
{
    private readonly IArtifactResolver _inner;
    private readonly Dictionary<string, ArtifactDocument?> _cache = new(StringComparer.Ordinal);

    public CachedArtifactResolver(IArtifactResolver inner) => _inner = inner;

    public bool TryResolve(string canonical, out ArtifactDocument document)
    {
        if (_cache.TryGetValue(canonical, out var cached))
        {
            document = cached!;
            return cached is not null;
        }

        if (_inner.TryResolve(canonical, out document))
        {
            _cache[canonical] = document;
            return true;
        }

        _cache[canonical] = null;
        document = null!;
        return false;
    }

    public IEnumerable<ArtifactDocument> Enumerate() => _inner.Enumerate();
}

/// <summary>依序查詢多個來源。</summary>
public sealed class CompositeArtifactResolver : IArtifactResolver
{
    private readonly IReadOnlyList<IArtifactResolver> _resolvers;

    public CompositeArtifactResolver(params IArtifactResolver[] resolvers)
        => _resolvers = resolvers;

    public bool TryResolve(string canonical, out ArtifactDocument document)
    {
        foreach (var resolver in _resolvers)
        {
            if (resolver.TryResolve(canonical, out document))
                return true;
        }

        document = null!;
        return false;
    }

    public IEnumerable<ArtifactDocument> Enumerate()
        => _resolvers.SelectMany(r => r.Enumerate());
}
