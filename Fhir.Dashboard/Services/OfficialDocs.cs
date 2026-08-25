namespace Fhir.Dashboard.Services;

public static class OfficialDocs
{
    public static readonly string[] Lines = ["R4", "R4B", "R5"];

    public static string ResourcePage(string line, string resourceType)
        => $"https://hl7.org/fhir/{line}/{resourceType.ToLowerInvariant()}.html";

    public static string PrimitivePage(string line, string fhirName)
        => $"https://hl7.org/fhir/{line}/datatypes.html#{fhirName}";

    public static string ComplexPage(string line, string fhirName)
        => $"https://hl7.org/fhir/{line}/{fhirName.ToLowerInvariant()}.html";

    public static string Canonical(string fhirName)
        => $"http://hl7.org/fhir/StructureDefinition/{fhirName}";

    public static string ForType(TypeKind kind, string line, string fhirName)
        => kind == TypeKind.Primitive
            ? PrimitivePage(line, fhirName)
            : ComplexPage(line, fhirName);
}
