// Auto-generated for FHIR R5
namespace Fhir.R5.Models;

/// <summary>
/// Base Resource definition.
/// </summary>
public abstract class Resource : IValidatableObject
{
    /// <summary>
    /// Logical id of this artifact.
    /// </summary>
    public string? Id { get; set; }
    
    /// <summary>
    /// Metadata about the resource.
    /// </summary>
    public Meta? Meta { get; set; }
    
    /// <summary>
    /// A set of rules under which this content was created.
    /// </summary>
    public FhirUri? ImplicitRules { get; set; }
    
    /// <summary>
    /// Language of the resource content.
    /// </summary>
    public Code? Language { get; set; }
    
    /// <summary>
    /// Gets the resource type name.
    /// </summary>
    public abstract string ResourceType { get; }
    
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        
        // 基本驗證邏輯
        if (Meta != null)
        {
            Validator.TryValidateObject(Meta, new ValidationContext(Meta), results, true);
        }
        
        return results;
    }
}