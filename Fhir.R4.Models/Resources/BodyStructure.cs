// <auto-generated />
// FHIR R4 Resource: BodyStructure
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Record details about an anatomical structure.  This resource may be used when a coded concept does not provide the necessary detail needed for the use case.
/// </summary>
public class BodyStructure : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "BodyStructure";

    /// <summary>
    /// Bodystructure identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Whether this record is in active use
    /// </summary>
    [JsonPropertyName("active")]
    public FhirBoolean Active { get; set; }

    /// <summary>
    /// Kind of Structure
    /// </summary>
    [JsonPropertyName("morphology")]
    public CodeableConcept Morphology { get; set; }

    /// <summary>
    /// Body site
    /// </summary>
    [JsonPropertyName("location")]
    public CodeableConcept Location { get; set; }

    /// <summary>
    /// Body site modifier
    /// </summary>
    [JsonPropertyName("locationQualifier")]
    public List<CodeableConcept>? LocationQualifier { get; set; }

    /// <summary>
    /// Text description
    /// </summary>
    [JsonPropertyName("description")]
    public FhirString Description { get; set; }

    /// <summary>
    /// Attached images
    /// </summary>
    [JsonPropertyName("image")]
    public List<Attachment>? Image { get; set; }

    /// <summary>
    /// Who this is about
    /// </summary>
    [Required]
    [JsonPropertyName("patient")]
    public Reference Patient { get; set; }

    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // TODO: Add specific validation rules
    }

}
