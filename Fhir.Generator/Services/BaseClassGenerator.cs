namespace Fhir.Generator.Services;

public class BaseClassGenerator
{
    public async Task GenerateAllBaseClassesAsync(string outputDir, string version)
    {
        var baseDir = Path.Combine(outputDir, "Base");
        Directory.CreateDirectory(baseDir);
        
        // 生成核心基礎類別
        await GenerateElementAsync(baseDir, version);
        await GenerateBackboneElementAsync(baseDir, version);
        await GenerateResourceAsync(baseDir, version);
        await GenerateDomainResourceAsync(baseDir, version);
        await GenerateDataTypeAsync(baseDir, version);
        await GeneratePrimitiveTypeAsync(baseDir, version);
    }
    
    private async Task GenerateElementAsync(string baseDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
using System.ComponentModel.DataAnnotations;

namespace Fhir.{version}.Models;

/// <summary>
/// Base definition for all elements in a resource.
/// </summary>
public abstract class Element : IValidatableObject
{{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// </summary>
    public string? Id {{ get; set; }}
    
    /// <summary>
    /// Additional content defined by implementations.
    /// </summary>
    public List<Extension>? Extension {{ get; set; }}
    
    /// <summary>
    /// Validates this element according to FHIR rules.
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = new List<ValidationResult>();
        
        // 驗證 Extension
        if (Extension != null)
        {{
            foreach (var ext in Extension)
            {{
                Validator.TryValidateObject(ext, new ValidationContext(ext), results, true);
            }}
        }}
        
        return results;
    }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(baseDir, "Element.cs"), content);
    }
    
    private async Task GenerateBackboneElementAsync(string baseDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// Base definition for all elements that are defined inside a resource - but not the root element.
/// </summary>
public abstract class BackboneElement : Element
{{
    /// <summary>
    /// Extensions that cannot be ignored even if unrecognized.
    /// </summary>
    public List<Extension>? ModifierExtension {{ get; set; }}
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();
        
        // 驗證 ModifierExtension
        if (ModifierExtension != null)
        {{
            foreach (var modExt in ModifierExtension)
            {{
                Validator.TryValidateObject(modExt, new ValidationContext(modExt), results, true);
            }}
        }}
        
        return results;
    }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(baseDir, "BackboneElement.cs"), content);
    }
    
    private async Task GenerateResourceAsync(string baseDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
using System.ComponentModel.DataAnnotations;

namespace Fhir.{version}.Models;

/// <summary>
/// Base Resource definition.
/// </summary>
public abstract class Resource : IValidatableObject
{{
    /// <summary>
    /// Logical id of this artifact.
    /// </summary>
    public virtual FhirString? Id {{ get; set; }}
    
    /// <summary>
    /// Metadata about the resource.
    /// </summary>
    public virtual Meta? Meta {{ get; set; }}
    
    /// <summary>
    /// A set of rules under which this content was created.
    /// </summary>
    public virtual FhirUri? ImplicitRules {{ get; set; }}
    
    /// <summary>
    /// Language of the resource content.
    /// </summary>
    public virtual FhirCode? Language {{ get; set; }}
    
    /// <summary>
    /// Gets the resource type name.
    /// </summary>
    public abstract string ResourceType {{ get; }}
    
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = new List<ValidationResult>();
        
        // 基本驗證邏輯
        if (Meta != null)
        {{
            Validator.TryValidateObject(Meta, new ValidationContext(Meta), results, true);
        }}
        
        return results;
    }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(baseDir, "Resource.cs"), content);
    }
    
    private async Task GenerateDomainResourceAsync(string baseDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
using System.ComponentModel.DataAnnotations;

namespace Fhir.{version}.Models;

/// <summary>
/// A resource that includes narrative, extensions, and contained resources.
/// </summary>
public abstract class DomainResource : Resource
{{
    /// <summary>
    /// Text summary of the resource, for human interpretation.
    /// </summary>
    public virtual Narrative? Text {{ get; set; }}
    
    /// <summary>
    /// Contained, inline Resources.
    /// </summary>
    public virtual List<Resource>? Contained {{ get; set; }}
    
    /// <summary>
    /// Additional content defined by implementations.
    /// </summary>
    public virtual List<Extension>? Extension {{ get; set; }}
    
    /// <summary>
    /// Extensions that cannot be ignored.
    /// </summary>
    public virtual List<Extension>? ModifierExtension {{ get; set; }}
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();
        
        // 驗證包含的資源
        if (Contained != null)
        {{
            foreach (var contained in Contained)
            {{
                Validator.TryValidateObject(contained, new ValidationContext(contained), results, true);
            }}
        }}
        
        return results;
    }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(baseDir, "DomainResource.cs"), content);
    }

    private async Task GenerateDataTypeAsync(string baseDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// Base definition for all data types.
/// </summary>
public abstract class DataType : Element
{{
}}";

        await File.WriteAllTextAsync(Path.Combine(baseDir, "DataType.cs"), content);
    }

    private async Task GeneratePrimitiveTypeAsync(string baseDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// Base definition for all primitive types.
/// </summary>
public abstract class PrimitiveType<T> : DataType
{{
    /// <summary>
    /// The actual value
    /// </summary>
    public T? Value {{ get; set; }}
}}";

        await File.WriteAllTextAsync(Path.Combine(baseDir, "PrimitiveType.cs"), content);
    }
}