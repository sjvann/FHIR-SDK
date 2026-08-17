namespace FhirResourceCreator.Configuration;

/// <summary>由 <c>Fhir.Resources.{Line}</c> 專案名稱解析 FHIR 線別標籤（如 R5、R4B）。</summary>
public static class FhirLineLabels
{
    public const string ResourcesPrefix = "Fhir.Resources.";

    public static bool TryParseFromResourcesProject(string outputProjectName, out string lineLabel)
    {
        lineLabel = "";
        if (!outputProjectName.StartsWith(ResourcesPrefix, StringComparison.Ordinal))
            return false;
        lineLabel = outputProjectName[ResourcesPrefix.Length..];
        return lineLabel.Length > 0;
    }

    public static string PathProjectName(string lineLabel) => $"Fhir.Path.{lineLabel}";

    public static string SdkProjectName(string lineLabel) => $"Fhir.Sdk.{lineLabel}";

    public static string ResourcesNamespace(string lineLabel) => $"{ResourcesPrefix}{lineLabel}";
}
