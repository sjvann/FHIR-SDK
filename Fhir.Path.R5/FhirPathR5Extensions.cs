using Fhir.Path;
using Fhir.Path.Abstractions;
using Fhir.Path.Navigation;

namespace Fhir.Path.R5;

/// <summary>R5 資源 FHIRPath 擴充方法。</summary>
public static class FhirPathR5Extensions
{
    private static readonly FhirPathR5 Default = FhirPathR5.Create();

    public static FhirPathCollection FhirPath(this object resource, string expression, FhirPathEvaluationContext? ctx = null)
        => Default.Evaluate(expression, resource, ctx);

    public static object? FhirPathSingle(this object resource, string expression, FhirPathEvaluationContext? ctx = null)
        => resource.FhirPath(expression, ctx).SingleOrDefault();
}
