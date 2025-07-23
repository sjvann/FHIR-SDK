// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Address Type: An address expressed using postal conventions (as opposed to GPS or other location
/// definition formats). This data type may be used to convey addresses for use in delivering mail as
/// well as for visiting locations which might not be valid for mail delivery. There are a variety of
/// postal address formats defined around the world. The ISO21090-codedString may be used to provide a
/// coded representation of the contents of strings in an Address.
/// </summary>
public class Address : DataType
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value
    /// that does not contain spaces.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// The purpose of this address.
    /// </summary>
    [FhirElement("use", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("use")]
    public FhirCode? Use { get; set; }

    /// <summary>
    /// Distinguishes between physical addresses (those you can visit) and mailing addresses (e.g. PO Boxes
    /// and care-of addresses). Most addresses are both.
    /// </summary>
    [FhirElement("type", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("type")]
    public FhirCode? Type { get; set; }

    /// <summary>
    /// Specifies the entire address as it should be displayed e.g. on a postal label. This may be provided
    /// instead of or as well as the specific parts.
    /// </summary>
    [FhirElement("text", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("text")]
    public FhirString? Text { get; set; }

    /// <summary>
    /// This component contains the house number, apartment number, street name, street direction, P.O. Box
    /// number, delivery hints, and similar address information.
    /// </summary>
    [FhirElement("line", Order = 15)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("line")]
    public List<FhirString>? Line { get; set; }

    /// <summary>
    /// The name of the city, town, suburb, village or other community or delivery center.
    /// </summary>
    [FhirElement("city", Order = 16)]
    [Cardinality(0, 1)]
    [JsonPropertyName("city")]
    public FhirString? City { get; set; }

    /// <summary>
    /// The name of the administrative area (county).
    /// </summary>
    [FhirElement("district", Order = 17)]
    [Cardinality(0, 1)]
    [JsonPropertyName("district")]
    public FhirString? District { get; set; }

    /// <summary>
    /// Sub-unit of a country with limited sovereignty in a federally organized country. A code may be used
    /// if codes are in common use (e.g. US 2 letter state codes).
    /// </summary>
    [FhirElement("state", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("state")]
    public FhirString? State { get; set; }

    /// <summary>
    /// A postal code designating a region defined by the postal service.
    /// </summary>
    [FhirElement("postalCode", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("postalCode")]
    public FhirString? PostalCode { get; set; }

    /// <summary>
    /// Country - a nation as commonly understood or generally accepted.
    /// </summary>
    [FhirElement("country", Order = 20)]
    [Cardinality(0, 1)]
    [JsonPropertyName("country")]
    public FhirString? Country { get; set; }

    /// <summary>
    /// Time period when address was/is in use.
    /// </summary>
    [FhirElement("period", Order = 21)]
    [Cardinality(0, 1)]
    [JsonPropertyName("period")]
    public Period Period { get; set; }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Address cardinality
        var addressCount = Address?.Count ?? 0;
        if (addressCount < 0)
        {
            yield return new ValidationResult("Element 'Address' cardinality must be 0..*", new[] { nameof(Address) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Address.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Line cardinality
        var lineCount = Line?.Count ?? 0;
        if (lineCount < 0)
        {
            yield return new ValidationResult("Element 'Address.line' cardinality must be 0..*", new[] { nameof(Line) });
        }

        // ValueSet binding validation
        // Validate Use ValueSet binding
        if (Use != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/address-use|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/address-type|5.0.0
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Address) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Use) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Text) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Line) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(City) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(District) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(State) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PostalCode) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Country) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Period) });
        // }
    }

}
