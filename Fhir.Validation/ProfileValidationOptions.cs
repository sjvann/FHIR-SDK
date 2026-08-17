using Fhir.Path.Abstractions;

namespace Fhir.Validation;

public enum ProfileHandling
{
    Strict,
    Lenient
}

public sealed class ProfileValidationOptions
{
    public ProfileHandling Handling { get; init; } = ProfileHandling.Strict;

    /// <summary>可選。未提供時，binding 只查目錄內 ValueSet 的 compose.include.concept。</summary>
    public ITerminologyService? Terminology { get; init; }

    /// <summary>第二波 invariant 使用。未提供則略過 FHIRPath constraint。</summary>
    public IFhirPathEngine? PathEngine { get; init; }

    public bool EvaluateInvariants { get; init; } = true;

    public bool EvaluateSlicing { get; init; } = true;
}
