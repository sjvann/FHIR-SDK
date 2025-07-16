using System.ComponentModel;

namespace Core.Versioning;

/// <summary>
/// Supported FHIR versions for the SDK
/// </summary>
public enum FhirVersion
{
    /// <summary>
    /// FHIR R5 (Current stable version)
    /// </summary>
    [Description("5.0.0")]
    R5 = 5,
    
    /// <summary>
    /// FHIR R6 (Future version - placeholder)
    /// </summary>
    [Description("6.0.0")]
    R6 = 6
}

/// <summary>
/// Extension methods for FhirVersion enum
/// </summary>
public static class FhirVersionExtensions
{
    /// <summary>
    /// Gets the version string for the FHIR version
    /// </summary>
    /// <param name="version">The FHIR version</param>
    /// <returns>Version string</returns>
    public static string GetVersionString(this FhirVersion version)
    {
        var field = version.GetType().GetField(version.ToString());
        var attribute = field?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                              .FirstOrDefault() as DescriptionAttribute;
        return attribute?.Description ?? version.ToString();
    }
    
    /// <summary>
    /// Checks if this version is compatible with another version
    /// </summary>
    /// <param name="current">Current version</param>
    /// <param name="target">Target version to check compatibility with</param>
    /// <returns>True if compatible</returns>
    public static bool IsCompatibleWith(this FhirVersion current, FhirVersion target)
    {
        // Same version is always compatible
        if (current == target) return true;
        
        // Define compatibility rules - for now, R5 and R6 have limited compatibility
        return current switch
        {
            FhirVersion.R5 when target == FhirVersion.R6 => true, // Forward compatibility
            FhirVersion.R6 when target == FhirVersion.R5 => false, // No backward compatibility
            _ => false
        };
    }
}
