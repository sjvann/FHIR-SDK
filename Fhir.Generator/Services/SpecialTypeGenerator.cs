namespace Fhir.Generator.Services;

public class SpecialTypeGenerator
{
    public async Task GenerateSpecialTypesAsync(string outputDir, string version)
    {
        var typesDir = Path.Combine(outputDir, "DataTypes");
        Directory.CreateDirectory(typesDir);
        
        await GenerateReferenceTypeAsync(typesDir, version);
        await GenerateCodeableConceptAsync(typesDir, version);
        await GenerateCodingAsync(typesDir, version);
        await GenerateQuantityAsync(typesDir, version);
        await GeneratePeriodAsync(typesDir, version);
        await GenerateRangeAsync(typesDir, version);
    }
    
    private async Task GenerateReferenceTypeAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// A reference from one resource to another.
/// </summary>
/// <typeparam name=""T"">The type of resource being referenced</typeparam>
public class Reference<T> : DataType where T : Resource
{{
    /// <summary>
    /// Literal reference, Relative, internal or absolute URL.
    /// </summary>
    public string? Reference {{ get; set; }}
    
    /// <summary>
    /// Type the reference refers to (e.g. ""Patient"").
    /// </summary>
    public FhirUri? Type {{ get; set; }}
    
    /// <summary>
    /// Logical reference, when literal reference is not known.
    /// </summary>
    public Identifier? Identifier {{ get; set; }}
    
    /// <summary>
    /// Text alternative for the resource.
    /// </summary>
    public string? Display {{ get; set; }}
    
    /// <summary>
    /// Gets the expected resource type.
    /// </summary>
    public string ExpectedResourceType => typeof(T).Name;
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();
        
        // 至少要有 Reference 或 Identifier
        if (string.IsNullOrEmpty(Reference) && Identifier == null)
        {{
            results.Add(new ValidationResult(
                ""Reference must have either a reference or an identifier"",
                new[] {{ nameof(Reference), nameof(Identifier) }}));
        }}
        
        return results;
    }}
}}

/// <summary>
/// Non-generic reference for cases where the target type is not known at compile time.
/// </summary>
public class Reference : DataType
{{
    public string? Reference {{ get; set; }}
    public FhirUri? Type {{ get; set; }}
    public Identifier? Identifier {{ get; set; }}
    public string? Display {{ get; set; }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(typesDir, "Reference.cs"), content);
    }
    
    private async Task GenerateCodeableConceptAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// A concept that may be defined by a formal reference to a terminology or ontology.
/// </summary>
public class CodeableConcept : DataType
{{
    /// <summary>
    /// Code defined by a terminology system.
    /// </summary>
    public List<Coding>? Coding {{ get; set; }}
    
    /// <summary>
    /// Plain text representation of the concept.
    /// </summary>
    public string? Text {{ get; set; }}
    
    /// <summary>
    /// Helper method to add a coding.
    /// </summary>
    public CodeableConcept AddCoding(string system, string code, string? display = null)
    {{
        Coding ??= new List<Coding>();
        Coding.Add(new Coding
        {{
            System = system,
            Code = code,
            Display = display
        }});
        return this;
    }}
    
    /// <summary>
    /// Checks if this concept contains a specific coding.
    /// </summary>
    public bool HasCoding(string system, string code)
    {{
        return Coding?.Any(c => c.System == system && c.Code == code) == true;
    }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(typesDir, "CodeableConcept.cs"), content);
    }
    
    private async Task GenerateCodingAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// A reference to a code defined by a terminology system.
/// </summary>
public class Coding : DataType
{{
    /// <summary>
    /// Identity of the terminology system.
    /// </summary>
    public FhirUri? System {{ get; set; }}
    
    /// <summary>
    /// Version of the system - if relevant.
    /// </summary>
    public string? Version {{ get; set; }}
    
    /// <summary>
    /// Symbol in syntax defined by the system.
    /// </summary>
    public Code? Code {{ get; set; }}
    
    /// <summary>
    /// Representation defined by the system.
    /// </summary>
    public string? Display {{ get; set; }}
    
    /// <summary>
    /// If this coding was chosen directly by the user.
    /// </summary>
    public bool? UserSelected {{ get; set; }}
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();
        
        // Code 需要 System
        if (!string.IsNullOrEmpty(Code?.Value) && string.IsNullOrEmpty(System?.Value))
        {{
            results.Add(new ValidationResult(
                ""If a code is provided, a system SHALL be provided"",
                new[] {{ nameof(System) }}));
        }}
        
        return results;
    }}
}}";
        
        await File.WriteAllTextAsync(Path.Combine(typesDir, "Coding.cs"), content);
    }

    private async Task GenerateQuantityAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// A measured amount (or an amount that can potentially be measured).
/// </summary>
public class Quantity : DataType
{{
    /// <summary>
    /// Numerical value (with implicit precision).
    /// </summary>
    public decimal? Value {{ get; set; }}

    /// <summary>
    /// < | <= | >= | > - how to understand the value.
    /// </summary>
    public Code? Comparator {{ get; set; }}

    /// <summary>
    /// Unit representation.
    /// </summary>
    public string? Unit {{ get; set; }}

    /// <summary>
    /// System that defines coded unit form.
    /// </summary>
    public FhirUri? System {{ get; set; }}

    /// <summary>
    /// Coded form of the unit.
    /// </summary>
    public Code? Code {{ get; set; }}
}}";

        await File.WriteAllTextAsync(Path.Combine(typesDir, "Quantity.cs"), content);
    }

    private async Task GeneratePeriodAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// Time range defined by start and end date/time.
/// </summary>
public class Period : DataType
{{
    /// <summary>
    /// Starting time with inclusive boundary.
    /// </summary>
    public FhirDateTime? Start {{ get; set; }}

    /// <summary>
    /// End time with inclusive boundary, if not ongoing.
    /// </summary>
    public FhirDateTime? End {{ get; set; }}

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();

        // Start should be before End
        if (Start?.Value != null && End?.Value != null && Start.Value > End.Value)
        {{
            results.Add(new ValidationResult(
                ""Period start must be before end"",
                new[] {{ nameof(Start), nameof(End) }}));
        }}

        return results;
    }}
}}";

        await File.WriteAllTextAsync(Path.Combine(typesDir, "Period.cs"), content);
    }

    private async Task GenerateRangeAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
namespace Fhir.{version}.Models;

/// <summary>
/// Set of values bounded by low and high.
/// </summary>
public class Range : DataType
{{
    /// <summary>
    /// Low limit.
    /// </summary>
    public Quantity? Low {{ get; set; }}

    /// <summary>
    /// High limit.
    /// </summary>
    public Quantity? High {{ get; set; }}

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();

        // Low should be less than High
        if (Low?.Value != null && High?.Value != null && Low.Value > High.Value)
        {{
            results.Add(new ValidationResult(
                ""Range low must be less than high"",
                new[] {{ nameof(Low), nameof(High) }}));
        }}

        return results;
    }}
}}";

        await File.WriteAllTextAsync(Path.Combine(typesDir, "Range.cs"), content);
    }
}