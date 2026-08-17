namespace Fhir.Packages.Registry;

/// <summary>Parses <c>packageId@version</c> (FHIR CLI install syntax).</summary>
public sealed record PackageReferenceSpec(string PackageId, string Version)
{
    public static PackageReferenceSpec Parse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new ArgumentException("Package reference is required.", nameof(input));

        var s = input.Trim();
        var at = s.LastIndexOf('@');
        if (at <= 0 || at >= s.Length - 1)
            throw new FormatException($"Expected packageId@version, got: {input}");

        var id = s[..at].Trim();
        var ver = s[(at + 1)..].Trim();
        if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(ver))
            throw new FormatException($"Expected packageId@version, got: {input}");

        return new PackageReferenceSpec(id, ver);
    }

    public override string ToString() => $"{PackageId}@{Version}";
}
