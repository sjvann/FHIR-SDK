namespace Fhir.Artifacts;

/// <summary>套件或目錄中的單一 conformance／資源 JSON。</summary>
public sealed record ArtifactDocument(
    string ResourceType,
    string? Canonical,
    string Json,
    string? FileName = null);

/// <summary>依 canonical 解析 StructureDefinition／ValueSet／CodeSystem 等。</summary>
public interface IArtifactResolver
{
    bool TryResolve(string canonical, out ArtifactDocument document);

    IEnumerable<ArtifactDocument> Enumerate();
}
