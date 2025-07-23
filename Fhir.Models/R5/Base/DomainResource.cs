// Auto-generated for FHIR R5
namespace Fhir.R5.Models;

/// <summary>
/// A resource that includes narrative, extensions, and contained resources.
/// </summary>
public abstract class DomainResource : Resource
{
    /// <summary>
    /// Text summary of the resource, for human interpretation.
    /// </summary>
    public Narrative? Text { get; set; }
    
    /// <summary>
    /// Contained, inline Resources.
    /// </summary>
    public List<Resource>? Contained { get; set; }
    
    /// <summary>
    /// Additional content defined by implementations.
    /// </summary>
    public List<Extension>? Extension { get; set; }
    
    /// <summary>
    /// Extensions that cannot be ignored.
    /// </summary>
    public List<Extension>? ModifierExtension { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = base.Validate(validationContext).ToList();
        
        // 驗證包含的資源
        if (Contained != null)
        {
            foreach (var contained in Contained)
            {
                Validator.TryValidateObject(contained, new ValidationContext(contained), results, true);
            }
        }
        
        return results;
    }
}