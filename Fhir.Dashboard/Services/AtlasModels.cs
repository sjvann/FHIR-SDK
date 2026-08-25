namespace Fhir.Dashboard.Services;

public enum TypeKind
{
    Primitive,
    Complex
}

public enum TranslationSource
{
    Glossary,
    OfficialEnglish,
    Pending
}

public sealed record TypeEntry(
    string FhirName,
    string CsharpName,
    string Namespace,
    TypeKind Kind,
    string? Summary,
    IReadOnlyList<MemberEntry> Members);

public sealed record ResourceEntry(
    string ResourceType,
    string CsharpName,
    IReadOnlyList<string> Lines,
    IReadOnlyDictionary<string, IReadOnlyList<MemberEntry>> MembersByLine);

public sealed record MemberEntry(
    string JsonName,
    string CsharpName,
    string TypeName,
    bool IsCollection);

public sealed record TranslatedText(
    string Label,
    string? Summary,
    TranslationSource Source);

public interface ISpecTranslator
{
    TranslatedText Resolve(string fhirName, string locale);
    bool HasGlossary(string fhirName);
}

internal static class Aria
{
    public static string Bool(bool value) => value ? "true" : "false";
}
