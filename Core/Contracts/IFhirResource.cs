using Core.Versioning;
using Core.Contracts;
using System.Text.Json;

namespace Core.Contracts;

/// <summary>
/// Base interface for all FHIR resources with version awareness
/// </summary>
public interface IFhirResource : IVersionAware
{
    /// <summary>
    /// Resource ID
    /// </summary>
    string? Id { get; set; }
    
    /// <summary>
    /// Resource type name
    /// </summary>
    string ResourceType { get; }
    
    /// <summary>
    /// Resource metadata
    /// </summary>
    IFhirMeta? Meta { get; set; }
    
    /// <summary>
    /// Converts the resource to JSON
    /// </summary>
    /// <returns>JSON representation</returns>
    string ToJson();
    
    /// <summary>
    /// Validates the resource
    /// </summary>
    /// <returns>Validation result</returns>
    IValidationResult Validate();
}

/// <summary>
/// Interface for FHIR resource metadata
/// </summary>
public interface IFhirMeta
{
    /// <summary>
    /// Resource version ID
    /// </summary>
    string? VersionId { get; set; }
    
    /// <summary>
    /// Last updated timestamp
    /// </summary>
    DateTimeOffset? LastUpdated { get; set; }
    
    /// <summary>
    /// Resource profiles
    /// </summary>
    string[]? Profile { get; set; }
    
    /// <summary>
    /// Security tags
    /// </summary>
    IFhirCoding[]? Security { get; set; }
    
    /// <summary>
    /// Resource tags
    /// </summary>
    IFhirCoding[]? Tag { get; set; }
}

/// <summary>
/// Interface for FHIR coding elements
/// </summary>
public interface IFhirCoding
{
    /// <summary>
    /// Code system URL
    /// </summary>
    string? System { get; set; }
    
    /// <summary>
    /// Code value
    /// </summary>
    string? Code { get; set; }
    
    /// <summary>
    /// Display name
    /// </summary>
    string? Display { get; set; }
    
    /// <summary>
    /// Code version
    /// </summary>
    string? Version { get; set; }
}

/// <summary>
/// Interface for validation results
/// </summary>
public interface IValidationResult
{
    /// <summary>
    /// Whether the validation passed
    /// </summary>
    bool IsValid { get; }
    
    /// <summary>
    /// Validation issues
    /// </summary>
    IValidationIssue[] Issues { get; }
    
    /// <summary>
    /// FHIR version used for validation
    /// </summary>
    FhirVersion FhirVersion { get; }
}

/// <summary>
/// Interface for individual validation issues
/// </summary>
public interface IValidationIssue
{
    /// <summary>
    /// Issue severity (error, warning, information)
    /// </summary>
    ValidationSeverity Severity { get; }
    
    /// <summary>
    /// Issue code
    /// </summary>
    string Code { get; }
    
    /// <summary>
    /// Human-readable details
    /// </summary>
    string Details { get; }
    
    /// <summary>
    /// Element path where the issue occurred
    /// </summary>
    string? Location { get; }
}

/// <summary>
/// Validation severity levels
/// </summary>
public enum ValidationSeverity
{
    /// <summary>
    /// Fatal error - processing cannot continue
    /// </summary>
    Fatal = 0,
    
    /// <summary>
    /// Error - processing can continue but resource is invalid
    /// </summary>
    Error = 1,
    
    /// <summary>
    /// Warning - processing can continue, but there are issues
    /// </summary>
    Warning = 2,
    
    /// <summary>
    /// Information - no processing issues
    /// </summary>
    Information = 3
}

/// <summary>
/// Repository interface for FHIR resources with version support
/// </summary>
/// <typeparam name="T">Resource type</typeparam>
public interface IFhirRepository<T> : IVersionAware where T : class, IFhirResource
{
    /// <summary>
    /// Gets a resource by ID
    /// </summary>
    /// <param name="id">Resource ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Resource or null if not found</returns>
    Task<T?> GetByIdAsync(string id, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Creates a new resource
    /// </summary>
    /// <param name="resource">Resource to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created resource with server-assigned ID</returns>
    Task<T> CreateAsync(T resource, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Updates an existing resource
    /// </summary>
    /// <param name="resource">Resource to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated resource</returns>
    Task<T> UpdateAsync(T resource, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Deletes a resource
    /// </summary>
    /// <param name="id">Resource ID to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task representing the async operation</returns>
    Task DeleteAsync(string id, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Searches for resources
    /// </summary>
    /// <param name="searchParameters">Search parameters</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Search results</returns>
    Task<IFhirSearchResult<T>> SearchAsync(IFhirSearchParameters searchParameters, CancellationToken cancellationToken = default);
}

/// <summary>
/// Interface for FHIR search parameters
/// </summary>
public interface IFhirSearchParameters
{
    /// <summary>
    /// Search parameters as key-value pairs
    /// </summary>
    Dictionary<string, string[]> Parameters { get; }
    
    /// <summary>
    /// Number of results to return
    /// </summary>
    int? Count { get; set; }
    
    /// <summary>
    /// Search offset for pagination
    /// </summary>
    int? Offset { get; set; }
}

/// <summary>
/// Interface for FHIR search results
/// </summary>
/// <typeparam name="T">Resource type</typeparam>
public interface IFhirSearchResult<T> where T : class, IFhirResource
{
    /// <summary>
    /// Search results
    /// </summary>
    T[] Resources { get; }
    
    /// <summary>
    /// Total number of matching resources
    /// </summary>
    int? Total { get; }
    
    /// <summary>
    /// Search execution timestamp
    /// </summary>
    DateTimeOffset Timestamp { get; }
    
    /// <summary>
    /// Next page URL for pagination
    /// </summary>
    string? NextPageUrl { get; }
    
    /// <summary>
    /// Previous page URL for pagination
    /// </summary>
    string? PreviousPageUrl { get; }
}
