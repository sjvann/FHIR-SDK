namespace Fhir.Validation;

/// <summary>以目錄內 ValueSet 的 compose.include.concept 做 in-expansion，不是完整 $expand。</summary>
public sealed class CatalogTerminologyService(ProfileCatalog catalog) : ITerminologyService
{
    public BindingValidationResult ValidateCode(string? system, string? code, string valueSetCanonical)
    {
        if (string.IsNullOrEmpty(code))
            return new BindingValidationResult(false, "Code is empty.");

        if (!catalog.TryGetValueSet(valueSetCanonical, out var vs))
            return new BindingValidationResult(false, $"ValueSet '{valueSetCanonical}' is not in the catalog.");

        var key = ProfileCatalog.Key(system, code);
        var codeOnly = ProfileCatalog.Key(null, code);
        if (vs.Codes.Contains(key) || vs.Codes.Contains(codeOnly)
            || vs.Codes.Any(c => c.EndsWith("|" + code, StringComparison.Ordinal)))
            return new BindingValidationResult(true, null);

        if (!vs.IsClosedEnumeration)
        {
            return new BindingValidationResult(
                true,
                $"ValueSet '{valueSetCanonical}' is not a closed concept list; binding was not fully checked.");
        }

        return new BindingValidationResult(false, $"Code '{system}|{code}' is not in ValueSet '{valueSetCanonical}'.");
    }
}
