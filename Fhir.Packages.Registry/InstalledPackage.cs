namespace Fhir.Packages.Registry;

/// <summary>A resolved and extracted FHIR NPM package on disk.</summary>
public sealed record InstalledPackage(
    string PackageId,
    string Version,
    string CacheRoot,
    string PackageContentDirectory,
    FhirPackageJson? Manifest)
{
    public string PackageDir => PackageContentDirectory;
}
