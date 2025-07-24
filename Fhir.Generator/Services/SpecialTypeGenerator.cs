namespace Fhir.Generator.Services;

public class SpecialTypeGenerator
{
    public async Task GenerateSpecialTypesAsync(string outputDir, string version)
    {
        var typesDir = Path.Combine(outputDir, "DataTypes");
        Directory.CreateDirectory(typesDir);
        
        await GenerateReferenceAsync(typesDir, version);
        await GenerateCodeableConceptAsync(typesDir, version);
        await GenerateCodingAsync(typesDir, version);
        await GenerateQuantityAsync(typesDir, version);
        await GeneratePeriodAsync(typesDir, version);
        await GenerateRangeAsync(typesDir, version);
    }
    
    private async Task GenerateReferenceAsync(string typesDir, string version)
    {
        var content = $@"// Auto-generated for FHIR {version}
using System.ComponentModel.DataAnnotations;

namespace Fhir.{version}.Models;

/// <summary>
/// Reference Type: A reference from one resource to another.
/// This is the base non-generic Reference type used in FHIR resources.
/// </summary>
public class Reference : DataType
{{
    /// <summary>
    /// Unique id for the element within a resource (for internal references).
    /// </summary>
    [FhirElement(""id"", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName(""id"")]
    public virtual FhirString? Id {{ get; set; }}

    /// <summary>
    /// Additional content defined by implementations.
    /// </summary>
    [FhirElement(""extension"", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName(""extension"")]
    public virtual List<Extension>? Extension {{ get; set; }}

    /// <summary>
    /// A reference to a location at which the other resource is found.
    /// </summary>
    [FhirElement(""reference"", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName(""reference"")]
    public virtual FhirString? ReferenceValue {{ get; set; }}

    /// <summary>
    /// The expected type of the target of the reference.
    /// </summary>
    [FhirElement(""type"", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName(""type"")]
    public virtual FhirUri? Type {{ get; set; }}

    /// <summary>
    /// An identifier for the target resource.
    /// </summary>
    [FhirElement(""identifier"", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName(""identifier"")]
    public virtual Identifier? Identifier {{ get; set; }}

    /// <summary>
    /// Plain text narrative that identifies the resource.
    /// </summary>
    [FhirElement(""display"", Order = 15)]
    [Cardinality(0, 1)]
    [JsonPropertyName(""display"")]
    public virtual FhirString? Display {{ get; set; }}

    /// <summary>
    /// Validates this reference according to FHIR rules.
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = new List<ValidationResult>();

        // Reference 必須有 reference 或 identifier 至少其中一個
        if (string.IsNullOrEmpty(ReferenceValue?.Value) && Identifier == null)
        {{
            results.Add(new ValidationResult(
                ""Reference must have either a reference or an identifier"",
                new[] {{ nameof(ReferenceValue), nameof(Identifier) }}));
        }}

        // 驗證巢狀物件
        if (Identifier != null)
        {{
            Validator.TryValidateObject(Identifier, new ValidationContext(Identifier), results, true);
        }}

        return results;
    }}
}}

/// <summary>
/// Generic Reference Type: A strongly-typed reference to a specific type of resource.
/// This provides compile-time type checking and enhanced validation.
/// </summary>
/// <typeparam name=""T"">The expected resource type</typeparam>
public class Reference<T> : Reference where T : Resource
{{
    /// <summary>
    /// Gets the expected resource type name.
    /// </summary>
    public string ExpectedResourceType => typeof(T).Name;

    /// <summary>
    /// Creates a reference to a specific resource instance.
    /// </summary>
    /// <param name=""resource"">The resource to reference</param>
    /// <returns>A new reference pointing to the resource</returns>
    public static Reference<T> CreateFor(T resource)
    {{
        if (resource == null) throw new ArgumentNullException(nameof(resource));
        
        return new Reference<T>
        {{
            ReferenceValue = new FhirString($""{{typeof(T).Name}}/{{resource.Id?.Value}}""),
            Type = new FhirUri($""http://hl7.org/fhir/StructureDefinition/{{typeof(T).Name}}""),
            Display = resource.ToString() // 或其他適當的顯示邏輯
        }};
    }}

    /// <summary>
    /// Creates a reference using just an ID.
    /// </summary>
    /// <param name=""id"">The resource ID</param>
    /// <returns>A new reference pointing to the resource</returns>
    public static Reference<T> CreateFor(string id)
    {{
        if (string.IsNullOrEmpty(id)) throw new ArgumentException(""ID cannot be null or empty"", nameof(id));
        
        return new Reference<T>
        {{
            ReferenceValue = new FhirString($""{{typeof(T).Name}}/{{id}}""),
            Type = new FhirUri($""http://hl7.org/fhir/StructureDefinition/{{typeof(T).Name}}"")
        }};
    }}

    /// <summary>
    /// Enhanced validation that includes type checking.
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {{
        var results = base.Validate(validationContext).ToList();

        // 檢查類型一致性
        if (!string.IsNullOrEmpty(Type?.Value))
        {{
            var expectedCanonical = $""http://hl7.org/fhir/StructureDefinition/{{ExpectedResourceType}}"";
            var expectedShort = ExpectedResourceType;
            
            if (!string.Equals(Type.Value, expectedCanonical, StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(Type.Value, expectedShort, StringComparison.OrdinalIgnoreCase))
            {{
                results.Add(new ValidationResult(
                    $""Reference type '{{Type.Value}}' does not match expected type '{{ExpectedResourceType}}'"",
                    new[] {{ nameof(Type) }}));
            }}
        }}

        // 檢查 reference 字串中的資源類型
        if (!string.IsNullOrEmpty(ReferenceValue?.Value) && 
            !ReferenceValue.Value.StartsWith(""#"") && // 不是內含資源參考
            !Uri.IsWellFormedUriString(ReferenceValue.Value, UriKind.Absolute)) // 不是絕對 URL
        {{
            // 假設是相對參考，檢查格式 ResourceType/id
            var parts = ReferenceValue.Value.Split('/');
            if (parts.Length >= 2 && 
                !string.Equals(parts[0], ExpectedResourceType, StringComparison.OrdinalIgnoreCase))
            {{
                results.Add(new ValidationResult(
                    $""Reference '{{ReferenceValue.Value}}' does not match expected resource type '{{ExpectedResourceType}}'"",
                    new[] {{ nameof(ReferenceValue) }}));
            }}
        }}

        return results;
    }}
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