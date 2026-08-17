namespace Fhir.Packages.Registry;

/// <summary>Downloads and extracts FHIR NPM packages, including dependency tree.</summary>
public sealed class FhirPackageInstaller(FhirPackageDownloader downloader, FhirPackageInstallOptions options)
{
    readonly FhirPackageDownloader _downloader = downloader;
    readonly FhirPackageInstallOptions _options = options;

    public async Task<InstalledPackage> InstallAsync(
        PackageReferenceSpec package,
        CancellationToken ct = default)
    {
        var tree = await InstallTreeAsync(package, ct).ConfigureAwait(false);
        return tree.Root;
    }

    public async Task<InstalledPackageTree> InstallTreeAsync(
        PackageReferenceSpec root,
        CancellationToken ct = default)
    {
        var visited = new Dictionary<string, InstalledPackage>(StringComparer.OrdinalIgnoreCase);
        var rootPkg = await InstallSingleAsync(root.PackageId, root.Version, visited, ct).ConfigureAwait(false);

        var queue = new Queue<(string Id, string Version)>();
        EnqueueDependencies(rootPkg, queue);

        while (queue.Count > 0)
        {
            var (id, ver) = queue.Dequeue();
            var key = PackageKey(id, ver);
            if (visited.ContainsKey(key))
                continue;

            var installed = await InstallSingleAsync(id, ver, visited, ct).ConfigureAwait(false);
            EnqueueDependencies(installed, queue);
        }

        return new InstalledPackageTree(rootPkg, visited.Values.ToList());
    }

    async Task<InstalledPackage> InstallSingleAsync(
        string packageId,
        string version,
        Dictionary<string, InstalledPackage> visited,
        CancellationToken ct)
    {
        var key = PackageKey(packageId, version);
        if (visited.TryGetValue(key, out var existing))
            return existing;

        var cacheRoot = Path.Combine(_options.PackageCacheDirectory, SanitizePath(packageId), version);
        Directory.CreateDirectory(cacheRoot);
        var packageDir = Path.Combine(cacheRoot, "package");

        if (!Directory.Exists(packageDir))
        {
            string tgzPath;
            try
            {
                tgzPath = await _downloader.DownloadPackageTarballAsync(
                    _options.RegistryBaseUrl, packageId, version, cacheRoot, ct).ConfigureAwait(false);
            }
            catch
            {
                if (!string.IsNullOrEmpty(_options.RegistryFallbackUrl))
                {
                    tgzPath = await _downloader.DownloadPackageTarballAsync(
                        _options.RegistryFallbackUrl!, packageId, version, cacheRoot, ct).ConfigureAwait(false);
                }
                else
                    throw;
            }

            NpmPackageExtractor.ExtractTarGz(tgzPath, cacheRoot);
        }

        if (!Directory.Exists(packageDir))
            throw new InvalidOperationException($"Extracted package folder not found: {packageDir}");

        var manifest = FhirPackageJson.TryReadFromPackageDir(cacheRoot);
        var installed = new InstalledPackage(packageId, version, cacheRoot, packageDir, manifest);
        visited[key] = installed;
        return installed;
    }

    static void EnqueueDependencies(InstalledPackage pkg, Queue<(string Id, string Version)> queue)
    {
        if (pkg.Manifest?.Dependencies is null)
            return;

        foreach (var (id, ver) in pkg.Manifest.Dependencies)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(ver))
                continue;
            queue.Enqueue((id.Trim(), ver.Trim()));
        }
    }

    static string PackageKey(string packageId, string version) =>
        $"{packageId}@{version}";

    static string SanitizePath(string packageId) =>
        packageId.Replace('/', '-');
}

public sealed record InstalledPackageTree(InstalledPackage Root, IReadOnlyList<InstalledPackage> AllPackages);
