// <auto-generated />
// FHIR R4 Resource: CoverageEligibilityResponse
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// This resource provides eligibility and plan details from the processing of an CoverageEligibilityRequest resource.
/// </summary>
public class CoverageEligibilityResponse : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "CoverageEligibilityResponse";

    /// <summary>
    /// Business Identifier for coverage eligiblity request
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// auth-requirements | benefits | discovery | validation
    /// </summary>
    [Required]
    [JsonPropertyName("purpose")]
    public List<FhirCode> Purpose { get; set; }

    /// <summary>
    /// Intended recipient of products and services
    /// </summary>
    [Required]
    [JsonPropertyName("patient")]
    public Reference Patient { get; set; }

    /// <summary>
    /// Response creation date
    /// </summary>
    [Required]
    [JsonPropertyName("created")]
    public FhirDateTime Created { get; set; }

    /// <summary>
    /// Party responsible for the request
    /// </summary>
    [JsonPropertyName("requestor")]
    public Reference Requestor { get; set; }

    /// <summary>
    /// Eligibility request reference
    /// </summary>
    [Required]
    [JsonPropertyName("request")]
    public Reference Request { get; set; }

    /// <summary>
    /// queued | complete | error | partial
    /// </summary>
    [Required]
    [JsonPropertyName("outcome")]
    public FhirCode Outcome { get; set; }

    /// <summary>
    /// Disposition Message
    /// </summary>
    [JsonPropertyName("disposition")]
    public FhirString Disposition { get; set; }

    /// <summary>
    /// Coverage issuer
    /// </summary>
    [Required]
    [JsonPropertyName("insurer")]
    public Reference Insurer { get; set; }

    /// <summary>
    /// Patient insurance information
    /// </summary>
    [JsonPropertyName("insurance")]
    public List<BackboneElement>? Insurance { get; set; }

    /// <summary>
    /// Preauthorization reference
    /// </summary>
    [JsonPropertyName("preAuthRef")]
    public FhirString PreAuthRef { get; set; }

    /// <summary>
    /// Printed form identifier
    /// </summary>
    [JsonPropertyName("form")]
    public CodeableConcept Form { get; set; }

    /// <summary>
    /// Processing errors
    /// </summary>
    [JsonPropertyName("error")]
    public List<BackboneElement>? Error { get; set; }

    /// <summary>
    /// Error code detailing processing issues
    /// </summary>
    [Required]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

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
