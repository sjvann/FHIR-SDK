using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A reference to a code defined by a terminology system.
/// </summary>
/// <remarks>
/// FHIR R4 Coding DataType
/// A reference to a code defined by a terminology system.
/// </remarks>
public class Coding : DataType
{
    /// <summary>
    /// Identity of the terminology system.
    /// FHIR Path: Coding.system
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }
    
    /// <summary>
    /// Version of the system - if relevant.
    /// FHIR Path: Coding.version
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
    
    /// <summary>
    /// Symbol in syntax defined by the system.
    /// FHIR Path: Coding.code
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
    
    /// <summary>
    /// Representation defined by the system.
    /// FHIR Path: Coding.display
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }
    
    /// <summary>
    /// If this coding was chosen directly by the user.
    /// FHIR Path: Coding.userSelected
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("userSelected")]
    public bool? UserSelected { get; set; }
    
    /// <summary>
    /// Validates the Coding according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 如果有 system，通常也應該有 code
        if (!string.IsNullOrEmpty(System) && string.IsNullOrEmpty(Code))
        {
            yield return new ValidationResult("Coding with system should typically have a code");
        }
        
        // 驗證 system 是否為有效的 URI
        if (!string.IsNullOrEmpty(System) && !Uri.IsWellFormedUriString(System, UriKind.Absolute))
        {
            yield return new ValidationResult($"Coding.system '{System}' must be a valid URI");
        }
    }
}
