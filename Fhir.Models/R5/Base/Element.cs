// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Base definition for all elements in a resource.
/// </summary>
public abstract class Element : IValidatableObject
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// </summary>
    public string? Id { get; set; }
    
    /// <summary>
    /// Additional content defined by implementations.
    /// </summary>
    public List<Extension>? Extension { get; set; }
    
    /// <summary>
    /// Validates this element according to FHIR rules.
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        
        // 驗證 Extension
        if (Extension != null)
        {
            foreach (var ext in Extension)
            {
                Validator.TryValidateObject(ext, new ValidationContext(ext), results, true);
            }
        }
        
        return results;
    }
}