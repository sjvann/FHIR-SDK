namespace Fhir.Path.R5.Patch;

/// <summary>FHIRPath Patch 單一操作。</summary>
public sealed class PatchOperation
{
    public required string Type { get; init; }
    public string? Path { get; init; }
    public string? Name { get; init; }
    public object? Value { get; init; }
    public int? Index { get; init; }
    public int? Source { get; init; }
    public int? Destination { get; init; }
}
