namespace Fhir.TypeFramework.Metadata;

/// <summary>單一 FHIR 元素的產生式／反射 metadata。</summary>
public sealed record ModelElementMetadata(
    string ElementName,
    string? TypeName,
    bool IsCollection,
    bool IsChoice,
    IReadOnlyList<string>? ChoiceTypes = null,
    int Min = 0,
    string Max = "*");

/// <summary>單一 FHIR 型別（資源或 datatype）的元素表。</summary>
public sealed record ModelTypeMetadata(
    string TypeName,
    Type? ClrType,
    IReadOnlyList<ModelElementMetadata> Elements)
{
    public IReadOnlyDictionary<string, ModelElementMetadata> ElementMap { get; } =
        Elements.ToDictionary(e => e.ElementName, StringComparer.Ordinal);
}

/// <summary>序列化、FHIRPath、驗證、CLI 共用的 metadata 來源。</summary>
public interface IModelMetadataProvider
{
    bool TryGet(Type clrType, out ModelTypeMetadata metadata);

    bool TryGet(string typeName, out ModelTypeMetadata metadata);
}

/// <summary>可組合的 metadata 目錄：先查已註冊的產生物，再回落反射。</summary>
public sealed class CompositeModelMetadataProvider : IModelMetadataProvider
{
    private readonly IReadOnlyList<IModelMetadataProvider> _providers;

    public CompositeModelMetadataProvider(params IModelMetadataProvider[] providers)
        => _providers = providers;

    public bool TryGet(Type clrType, out ModelTypeMetadata metadata)
    {
        foreach (var provider in _providers)
        {
            if (provider.TryGet(clrType, out metadata))
                return true;
        }

        metadata = null!;
        return false;
    }

    public bool TryGet(string typeName, out ModelTypeMetadata metadata)
    {
        foreach (var provider in _providers)
        {
            if (provider.TryGet(typeName, out metadata))
                return true;
        }

        metadata = null!;
        return false;
    }
}
