// Auto-generated for FHIR R5
namespace Fhir.R5.Models;

/// <summary>
/// Base definition for all elements that are defined inside a resource - but not the root element.
/// </summary>
public abstract class BackboneElement : Element
{
    /// <summary>
    /// Extensions that cannot be ignored even if unrecognized.
    /// </summary>
    public List<Extension>? ModifierExtension { get; set; }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = base.Validate(validationContext).ToList();
        
        // 驗證 ModifierExtension
        if (ModifierExtension != null)
        {
            foreach (var modExt in ModifierExtension)
            {
                Validator.TryValidateObject(modExt, new ValidationContext(modExt), results, true);
            }
        }
        
        return results;
    }
}