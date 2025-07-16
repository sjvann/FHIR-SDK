using Core.Versioning;
using Core.Contracts;

namespace Core.Fhirs;

/// <summary>
/// Enhanced interface for FHIR server operations with version support
/// </summary>
public interface IFhirServer : IVersionAware
{
    /// <summary>
    /// Gets the base URL of the FHIR server
    /// </summary>
    /// <returns>Base URL</returns>
    string GetBasedUrl();
    
    /// <summary>
    /// Gets the access token for authentication
    /// </summary>
    /// <returns>Access token</returns>
    string GetAccessToken();
    
    /// <summary>
    /// Checks if the current token is expired
    /// </summary>
    /// <returns>True if expired</returns>
    bool IsExpired();
    
    /// <summary>
    /// Gets server capabilities
    /// </summary>
    /// <returns>Capability statement</returns>
    Task<string> GetCapabilitiesAsync();
    
    /// <summary>
    /// Gets the server's supported FHIR versions
    /// </summary>
    /// <returns>Array of supported versions</returns>
    FhirVersion[] GetSupportedFhirVersions();
    
    /// <summary>
    /// Refreshes the authentication token
    /// </summary>
    /// <returns>Task representing the async operation</returns>
    Task RefreshTokenAsync();
}

/// <summary>
/// Configuration options for FHIR server
/// </summary>
public class FhirServerOptions
{
    /// <summary>
    /// Base URL of the FHIR server
    /// </summary>
    public string BaseUrl { get; set; } = string.Empty;
    
    /// <summary>
    /// Authentication settings
    /// </summary>
    public FhirAuthOptions? Authentication { get; set; }
    
    /// <summary>
    /// Preferred FHIR version
    /// </summary>
    public FhirVersion PreferredVersion { get; set; } = FhirVersion.R5;
    
    /// <summary>
    /// Timeout for HTTP requests in seconds
    /// </summary>
    public int TimeoutSeconds { get; set; } = 30;
    
    /// <summary>
    /// Maximum retry attempts for failed requests
    /// </summary>
    public int MaxRetryAttempts { get; set; } = 3;
}

/// <summary>
/// Authentication options for FHIR server
/// </summary>
public class FhirAuthOptions
{
    /// <summary>
    /// Authentication type (Bearer, OAuth2, etc.)
    /// </summary>
    public string AuthType { get; set; } = "Bearer";
    
    /// <summary>
    /// Client ID for OAuth2
    /// </summary>
    public string? ClientId { get; set; }
    
    /// <summary>
    /// Client secret for OAuth2
    /// </summary>
    public string? ClientSecret { get; set; }
    
    /// <summary>
    /// Token endpoint URL
    /// </summary>
    public string? TokenEndpoint { get; set; }
    
    /// <summary>
    /// Scopes to request
    /// </summary>
    public string[]? Scopes { get; set; }
}