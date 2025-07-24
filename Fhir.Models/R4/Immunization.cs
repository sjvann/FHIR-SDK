// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Describes the event of a patient being administered a vaccine or a record of an immunization as reported by a patient, a clinician or another party
/// </summary>
public class Immunization : SimpleDomainResource
{
    /// <summary>
    /// Business identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// completed | entered-in-error | not-done
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reason not done
    /// </summary>
    [JsonPropertyName("statusReason")]
    public SimpleCodeableConcept? StatusReason { get; set; }

    /// <summary>
    /// Vaccine product administered
    /// </summary>
    [JsonPropertyName("vaccineCode")]
    public SimpleCodeableConcept? VaccineCode { get; set; }

    /// <summary>
    /// Who was immunized
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Encounter immunization was part of
    /// </summary>
    [JsonPropertyName("encounter")]
    public SimpleReference? Encounter { get; set; }

    /// <summary>
    /// Vaccination administration date
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// Vaccination administration date
    /// </summary>
    [JsonPropertyName("occurrenceString")]
    public string? OccurrenceString { get; set; }

    /// <summary>
    /// When the immunization was first captured in the subject's record
    /// </summary>
    [JsonPropertyName("recorded")]
    public DateTime? Recorded { get; set; }

    /// <summary>
    /// Indicates context the data was recorded in
    /// </summary>
    [JsonPropertyName("primarySource")]
    public bool? PrimarySource { get; set; }

    /// <summary>
    /// Indicates the source of a secondarily reported record
    /// </summary>
    [JsonPropertyName("reportOrigin")]
    public SimpleCodeableConcept? ReportOrigin { get; set; }

    /// <summary>
    /// Where immunization occurred
    /// </summary>
    [JsonPropertyName("location")]
    public SimpleReference? Location { get; set; }

    /// <summary>
    /// Vaccine manufacturer
    /// </summary>
    [JsonPropertyName("manufacturer")]
    public SimpleReference? Manufacturer { get; set; }

    /// <summary>
    /// Vaccine lot number
    /// </summary>
    [JsonPropertyName("lotNumber")]
    public string? LotNumber { get; set; }

    /// <summary>
    /// Vaccine expiration date
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Body site vaccine was given
    /// </summary>
    [JsonPropertyName("site")]
    public SimpleCodeableConcept? Site { get; set; }

    /// <summary>
    /// How vaccine entered body
    /// </summary>
    [JsonPropertyName("route")]
    public SimpleCodeableConcept? Route { get; set; }

    /// <summary>
    /// Amount of vaccine administered
    /// </summary>
    [JsonPropertyName("doseQuantity")]
    public SimpleQuantity? DoseQuantity { get; set; }

    /// <summary>
    /// Who performed event
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleBackboneElement? Performer { get; set; }

    /// <summary>
    /// Additional immunization notes
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Why immunization occurred
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public SimpleCodeableConcept? ReasonCode { get; set; }

    /// <summary>
    /// Why immunization occurred
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public SimpleReference? ReasonReference { get; set; }

    /// <summary>
    /// Dose potency
    /// </summary>
    [JsonPropertyName("isSubpotent")]
    public bool? IsSubpotent { get; set; }

    /// <summary>
    /// Reason for being subpotent
    /// </summary>
    [JsonPropertyName("subpotentReason")]
    public SimpleCodeableConcept? SubpotentReason { get; set; }

    /// <summary>
    /// Educational material presented to patient
    /// </summary>
    [JsonPropertyName("education")]
    public SimpleBackboneElement? Education { get; set; }

    /// <summary>
    /// Patient eligibility for a vaccination program
    /// </summary>
    [JsonPropertyName("programEligibility")]
    public SimpleCodeableConcept? ProgramEligibility { get; set; }

    /// <summary>
    /// Funding source for the vaccine
    /// </summary>
    [JsonPropertyName("fundingSource")]
    public SimpleCodeableConcept? FundingSource { get; set; }

    /// <summary>
    /// Details of a reaction that follows immunization
    /// </summary>
    [JsonPropertyName("reaction")]
    public SimpleBackboneElement? Reaction { get; set; }

    /// <summary>
    /// Protocol followed by the provider
    /// </summary>
    [JsonPropertyName("protocolApplied")]
    public SimpleBackboneElement? ProtocolApplied { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Immunization";

    /// <summary>
    /// 驗證此實例
    /// </summary>
    /// <param name="validationContext">驗證上下文</param>
    /// <returns>驗證結果</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 自訂驗證邏輯
        // 子類別可以覆寫此方法來添加特定的驗證邏輯
    }
}
