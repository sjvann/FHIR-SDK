using Fhir.Path.Abstractions;

namespace Fhir.Path;

/// <summary><see cref="IFhirPathEngine.Capabilities"/> 輔助方法。</summary>
public static class FhirPathCapabilitiesExtensions
{
    public static bool SupportsFunction(this FhirPathCapabilities capabilities, string functionName)
        => capabilities.SupportedFunctions.Contains(functionName, StringComparer.OrdinalIgnoreCase);

    public static bool SupportsOperator(this FhirPathCapabilities capabilities, string op)
        => capabilities.SupportedOperators.Contains(op, StringComparer.OrdinalIgnoreCase);

    public static void EnsureFunctionSupported(this FhirPathCapabilities capabilities, string functionName)
    {
        if (!capabilities.SupportsFunction(functionName))
            throw new Exceptions.FhirPathException($"Function '{functionName}' is not supported in {capabilities.Version}.");
    }
}
