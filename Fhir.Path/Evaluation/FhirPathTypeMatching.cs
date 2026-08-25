using Fhir.Path.Abstractions;
using Fhir.TypeFramework.Bases;

namespace Fhir.Path.Evaluation;

internal static class FhirPathTypeMatching
{
    private const string FhirPathSystemPrefix = "http://hl7.org/fhirpath/System.";

    public static bool Matches(IFhirNode node, string typeSpecifier)
    {
        var wanted = Normalize(typeSpecifier);
        if (wanted.Length == 0)
            return false;

        foreach (var candidate in CandidateNames(node))
        {
            if (string.Equals(Normalize(candidate), wanted, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        if (wanted.Equals("String", StringComparison.OrdinalIgnoreCase)
            || wanted.Equals("System.String", StringComparison.OrdinalIgnoreCase))
        {
            return CandidateNames(node).Any(n => IsStringPrimitive(Normalize(n)));
        }

        return false;
    }

    public static string TypeName(object? native)
    {
        if (native is null)
            return "";
        var name = native.GetType().Name;
        return name.StartsWith("Fhir", StringComparison.Ordinal) ? name[4..] : name;
    }

    private static IEnumerable<string> CandidateNames(IFhirNode node)
    {
        if (node.TypeName is { Length: > 0 } typeName)
            yield return typeName;
        if (node.Native is not null)
            yield return TypeName(node.Native);
        if (node.Native is PrimitiveType)
            yield return node.Native.GetType().Name;
    }

    private static string Normalize(string type)
    {
        var value = type.Trim();
        if (value.StartsWith(FhirPathSystemPrefix, StringComparison.OrdinalIgnoreCase))
            return "System." + value[FhirPathSystemPrefix.Length..];
        if (value.StartsWith("FHIR.", StringComparison.OrdinalIgnoreCase))
            return value["FHIR.".Length..];
        return value;
    }

    private static bool IsStringPrimitive(string name)
        => name.Equals("string", StringComparison.OrdinalIgnoreCase)
           || name.Equals("id", StringComparison.OrdinalIgnoreCase)
           || name.Equals("code", StringComparison.OrdinalIgnoreCase)
           || name.Equals("uri", StringComparison.OrdinalIgnoreCase)
           || name.Equals("url", StringComparison.OrdinalIgnoreCase)
           || name.Equals("canonical", StringComparison.OrdinalIgnoreCase)
           || name.Equals("oid", StringComparison.OrdinalIgnoreCase)
           || name.Equals("uuid", StringComparison.OrdinalIgnoreCase)
           || name.Equals("markdown", StringComparison.OrdinalIgnoreCase)
           || name.Equals("xhtml", StringComparison.OrdinalIgnoreCase)
           || name.Equals("base64binary", StringComparison.OrdinalIgnoreCase);
}
