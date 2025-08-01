// <auto-generated />
// FHIR R4 Resource: EnrollmentRequest
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// This resource provides the insurance enrollment details to the insurer regarding a specified coverage.
/// </summary>
public class EnrollmentRequest : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "EnrollmentRequest";

    /// <summary>
    /// Business Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    [JsonPropertyName("created")]
    public FhirDateTime Created { get; set; }

    /// <summary>
    /// Target
    /// </summary>
    [JsonPropertyName("insurer")]
    public Reference Insurer { get; set; }

    /// <summary>
    /// Responsible practitioner
    /// </summary>
    [JsonPropertyName("provider")]
    public Reference Provider { get; set; }

    /// <summary>
    /// The subject to be enrolled
    /// </summary>
    [JsonPropertyName("candidate")]
    public Reference Candidate { get; set; }

    /// <summary>
    /// Insurance information
    /// </summary>
    [JsonPropertyName("coverage")]
    public Reference Coverage { get; set; }

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
