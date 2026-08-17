using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;
using Fhir.TypeFramework.Extensions;

namespace Fhir.TypeFramework.Interop;

/// <summary>強型別 Extension 建立擴充。</summary>
public static class ExtensionInteropExtensions
{
    public static IExtension CreateExtension(this IExtensibleTypeFramework extensible, string url, FhirString value)
        => extensible.CreateExtension(url, (object?)value);

    public static IExtension CreateExtension(this IExtensibleTypeFramework extensible, string url, FhirBoolean value)
        => extensible.CreateExtension(url, (object?)value);

    public static IExtension CreateExtension(this IExtensibleTypeFramework extensible, string url, FhirCode value)
        => extensible.CreateExtension(url, (object?)value);

    public static IExtension CreateExtension(this IExtensibleTypeFramework extensible, string url, Coding value)
        => extensible.CreateExtension(url, (object?)value);

    public static IExtension CreateExtension(this IExtensibleTypeFramework extensible, string url, Reference value)
        => extensible.CreateExtension(url, (object?)value);
}
