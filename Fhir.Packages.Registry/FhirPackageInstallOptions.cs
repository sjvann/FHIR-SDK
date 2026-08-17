namespace Fhir.Packages.Registry;

public sealed class FhirPackageInstallOptions
{
    public string RegistryBaseUrl { get; set; } = "https://packages.fhir.org";

    public string? RegistryFallbackUrl { get; set; } = "https://packages2.fhir.org";

    public string PackageCacheDirectory { get; set; } = "artifacts/fhir-packages";
}
