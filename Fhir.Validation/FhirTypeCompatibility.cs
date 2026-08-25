namespace Fhir.Validation;

/// <summary>
/// FHIR snapshot <c>type.code</c> 可能是 FHIR 型別名，或 FHIRPath System 型別。
/// JSON 反序列化也常把 <c>code</c>/<c>id</c> 收成 <c>string</c>。
/// </summary>
internal static class FhirTypeCompatibility
{
    private const string FhirPathSystemPrefix = "http://hl7.org/fhirpath/System.";

    private static readonly HashSet<string> StringPrimitives = new(StringComparer.OrdinalIgnoreCase)
    {
        "string", "id", "code", "uri", "url", "canonical", "oid", "uuid", "markdown", "base64binary", "xhtml"
    };

    private static readonly HashSet<string> IntegerPrimitives = new(StringComparer.OrdinalIgnoreCase)
    {
        "integer", "unsignedint", "positiveint"
    };

    private static readonly HashSet<string> DateTimePrimitives = new(StringComparer.OrdinalIgnoreCase)
    {
        "date", "datetime", "instant"
    };

    public static bool IsCompatible(string actual, IEnumerable<string> allowed)
    {
        foreach (var candidate in allowed)
        {
            if (IsCompatible(actual, candidate))
                return true;
        }

        return false;
    }

    public static bool IsCompatible(string actual, string allowed)
    {
        if (string.Equals(actual, allowed, StringComparison.OrdinalIgnoreCase))
            return true;

        var actualName = Normalize(actual);
        var allowedName = Normalize(allowed);
        if (string.Equals(actualName, allowedName, StringComparison.OrdinalIgnoreCase))
            return true;

        if (TrySystemKind(allowedName, out var allowedSystem) && MatchesSystem(actualName, allowedSystem))
            return true;
        if (TrySystemKind(actualName, out var actualSystem) && MatchesSystem(allowedName, actualSystem))
            return true;

        if (StringPrimitives.Contains(actualName) && StringPrimitives.Contains(allowedName))
            return true;
        if (IntegerPrimitives.Contains(actualName) && IntegerPrimitives.Contains(allowedName))
            return true;
        if (DateTimePrimitives.Contains(actualName) && DateTimePrimitives.Contains(allowedName))
            return true;

        return false;
    }

    private static string Normalize(string type)
    {
        var value = type.Trim();
        if (value.StartsWith(FhirPathSystemPrefix, StringComparison.OrdinalIgnoreCase))
            return "System." + value[FhirPathSystemPrefix.Length..];
        return value;
    }

    private static bool TrySystemKind(string name, out string kind)
    {
        const string prefix = "System.";
        if (name.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
        {
            kind = name[prefix.Length..];
            return true;
        }

        kind = "";
        return false;
    }

    private static bool MatchesSystem(string fhirType, string systemKind)
        => systemKind.ToLowerInvariant() switch
        {
            "string" => StringPrimitives.Contains(fhirType),
            "integer" => IntegerPrimitives.Contains(fhirType),
            "decimal" => fhirType.Equals("decimal", StringComparison.OrdinalIgnoreCase),
            "boolean" => fhirType.Equals("boolean", StringComparison.OrdinalIgnoreCase),
            "datetime" => DateTimePrimitives.Contains(fhirType),
            "time" => fhirType.Equals("time", StringComparison.OrdinalIgnoreCase),
            "quantity" => fhirType.Equals("quantity", StringComparison.OrdinalIgnoreCase),
            _ => false
        };
}
