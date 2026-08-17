namespace Fhir.Validation;

public sealed record BindingValidationResult(bool Ok, string? Diagnostics);

/// <summary>
/// 術語服務抽象。本庫不實作 Terminology Server／完整 $expand。
/// </summary>
public interface ITerminologyService
{
    BindingValidationResult ValidateCode(string? system, string? code, string valueSetCanonical);
}
