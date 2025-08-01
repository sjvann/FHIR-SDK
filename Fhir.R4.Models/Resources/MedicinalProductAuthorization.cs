// <auto-generated />
// FHIR R4 Resource: MedicinalProductAuthorization
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// The regulatory authorization of a medicinal product.
/// </summary>
public class MedicinalProductAuthorization : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "MedicinalProductAuthorization";

    /// <summary>
    /// Business identifier for the marketing authorization, as assigned by a regulator
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// The medicinal product that is being authorized
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// The country in which the marketing authorization has been granted
    /// </summary>
    [JsonPropertyName("country")]
    public List<CodeableConcept>? Country { get; set; }

    /// <summary>
    /// Jurisdiction within a country
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// The status of the marketing authorization
    /// </summary>
    [JsonPropertyName("status")]
    public CodeableConcept Status { get; set; }

    /// <summary>
    /// The date at which the given status has become applicable
    /// </summary>
    [JsonPropertyName("statusDate")]
    public FhirDateTime StatusDate { get; set; }

    /// <summary>
    /// The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored
    /// </summary>
    [JsonPropertyName("restoreDate")]
    public FhirDateTime RestoreDate { get; set; }

    /// <summary>
    /// The beginning of the time period in which the marketing authorization is in the specific status shall be specified A complete date consisting of day, month and year shall be specified using the ISO 8601 date format
    /// </summary>
    [JsonPropertyName("validityPeriod")]
    public Period ValidityPeriod { get; set; }

    /// <summary>
    /// A period of time after authorization before generic product applicatiosn can be submitted
    /// </summary>
    [JsonPropertyName("dataExclusivityPeriod")]
    public Period DataExclusivityPeriod { get; set; }

    /// <summary>
    /// The date when the first authorization was granted by a Medicines Regulatory Agency
    /// </summary>
    [JsonPropertyName("dateOfFirstAuthorization")]
    public FhirDateTime DateOfFirstAuthorization { get; set; }

    /// <summary>
    /// Date of first marketing authorization for a company&apos;s new medicinal product in any country in the World
    /// </summary>
    [JsonPropertyName("internationalBirthDate")]
    public FhirDateTime InternationalBirthDate { get; set; }

    /// <summary>
    /// The legal framework against which this authorization is granted
    /// </summary>
    [JsonPropertyName("legalBasis")]
    public CodeableConcept LegalBasis { get; set; }

    /// <summary>
    /// Authorization in areas within a country
    /// </summary>
    [JsonPropertyName("jurisdictionalAuthorization")]
    public List<BackboneElement>? JurisdictionalAuthorization { get; set; }

    /// <summary>
    /// The assigned number for the marketing authorization
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Country of authorization
    /// </summary>
    [JsonPropertyName("country")]
    public CodeableConcept Country { get; set; }

    /// <summary>
    /// Jurisdiction within a country
    /// </summary>
    [JsonPropertyName("jurisdiction")]
    public List<CodeableConcept>? Jurisdiction { get; set; }

    /// <summary>
    /// The legal status of supply in a jurisdiction or region
    /// </summary>
    [JsonPropertyName("legalStatusOfSupply")]
    public CodeableConcept LegalStatusOfSupply { get; set; }

    /// <summary>
    /// The start and expected end date of the authorization
    /// </summary>
    [JsonPropertyName("validityPeriod")]
    public Period ValidityPeriod { get; set; }

    /// <summary>
    /// Marketing Authorization Holder
    /// </summary>
    [JsonPropertyName("holder")]
    public Reference Holder { get; set; }

    /// <summary>
    /// Medicines Regulatory Agency
    /// </summary>
    [JsonPropertyName("regulator")]
    public Reference Regulator { get; set; }

    /// <summary>
    /// The regulatory procedure for granting or amending a marketing authorization
    /// </summary>
    [JsonPropertyName("procedure")]
    public BackboneElement Procedure { get; set; }

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
