using Fhir.Path;
using Fhir.Path.Abstractions;
using Fhir.Path.Navigation;

namespace Fhir.Path.R4;

/// <summary>R5 資源 FHIRPath 擴充方法。</summary>
public static class FhirPathR4Extensions
{
    private static readonly FhirPathR4 Default = FhirPathR4.Create();

    public static FhirPathCollection FhirPath(this object resource, string expression, FhirPathEvaluationContext? ctx = null)
        => Default.Evaluate(expression, resource, ctx);

    public static object? FhirPathSingle(this object resource, string expression, FhirPathEvaluationContext? ctx = null)
        => resource.FhirPath(expression, ctx).SingleOrDefault();
}
