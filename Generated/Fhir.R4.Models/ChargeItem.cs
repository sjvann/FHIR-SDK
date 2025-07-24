// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// The resource ChargeItem describes the provision of healthcare provider products for a certain patient
/// </summary>
public class ChargeItem : SimpleDomainResource
{
    /// <summary>
    /// Identifiers assigned to this event performer or other systems
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// Defining information about the code of this charge item
    /// </summary>
    [JsonPropertyName("definitionUri")]
    public string? DefinitionUri { get; set; }

    /// <summary>
    /// Defining information about the code of this charge item
    /// </summary>
    [JsonPropertyName("definitionCanonical")]
    public string? DefinitionCanonical { get; set; }

    /// <summary>
    /// planned | billable | not-billable | aborted | billed | entered-in-error | unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Part of referenced ChargeItem
    /// </summary>
    [JsonPropertyName("partOf")]
    public SimpleReference? PartOf { get; set; }

    /// <summary>
    /// A code that identifies the charge, like a billing code
    /// </summary>
    [JsonPropertyName("code")]
    public SimpleCodeableConcept? Code { get; set; }

    /// <summary>
    /// Individual service was done for/to
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Encounter / Episode associated with event
    /// </summary>
    [JsonPropertyName("context")]
    public SimpleReference? Context { get; set; }

    /// <summary>
    /// When the charged service was applied
    /// </summary>
    [JsonPropertyName("occurrenceDateTime")]
    public DateTime? OccurrenceDateTime { get; set; }

    /// <summary>
    /// When the charged service was applied
    /// </summary>
    [JsonPropertyName("occurrencePeriod")]
    public SimplePeriod? OccurrencePeriod { get; set; }

    /// <summary>
    /// When the charged service was applied
    /// </summary>
    [JsonPropertyName("occurrenceTiming")]
    public string? OccurrenceTiming { get; set; }

    /// <summary>
    /// Who performed charged service
    /// </summary>
    [JsonPropertyName("performer")]
    public SimpleBackboneElement? Performer { get; set; }

    /// <summary>
    /// Organization providing the charged service
    /// </summary>
    [JsonPropertyName("performingOrganization")]
    public SimpleReference? PerformingOrganization { get; set; }

    /// <summary>
    /// Organization requesting the charged service
    /// </summary>
    [JsonPropertyName("requestingOrganization")]
    public SimpleReference? RequestingOrganization { get; set; }

    /// <summary>
    /// Organization that has ownership of the (potential) revenue
    /// </summary>
    [JsonPropertyName("costCenter")]
    public SimpleReference? CostCenter { get; set; }

    /// <summary>
    /// Quantity of which the charge item has been serviced
    /// </summary>
    [JsonPropertyName("quantity")]
    public SimpleQuantity? Quantity { get; set; }

    /// <summary>
    /// Anatomical location, if relevant
    /// </summary>
    [JsonPropertyName("bodysite")]
    public SimpleCodeableConcept? Bodysite { get; set; }

    /// <summary>
    /// Factor overriding the associated rules
    /// </summary>
    [JsonPropertyName("factorOverride")]
    public decimal? FactorOverride { get; set; }

    /// <summary>
    /// Total price of the charge overriding the list price
    /// </summary>
    [JsonPropertyName("priceOverride")]
    public string? PriceOverride { get; set; }

    /// <summary>
    /// Reason for overriding the list price/factor
    /// </summary>
    [JsonPropertyName("overrideReason")]
    public string? OverrideReason { get; set; }

    /// <summary>
    /// Individual who was entering
    /// </summary>
    [JsonPropertyName("enterer")]
    public SimpleReference? Enterer { get; set; }

    /// <summary>
    /// Date the charge item was entered
    /// </summary>
    [JsonPropertyName("enteredDate")]
    public DateTime? EnteredDate { get; set; }

    /// <summary>
    /// Why was the charged service rendered?
    /// </summary>
    [JsonPropertyName("reason")]
    public SimpleCodeableConcept? Reason { get; set; }

    /// <summary>
    /// Which rendered service is being charged?
    /// </summary>
    [JsonPropertyName("service")]
    public SimpleReference? Service { get; set; }

    /// <summary>
    /// Product charged
    /// </summary>
    [JsonPropertyName("productReference")]
    public SimpleReference? ProductReference { get; set; }

    /// <summary>
    /// Product charged
    /// </summary>
    [JsonPropertyName("productCodeableConcept")]
    public SimpleCodeableConcept? ProductCodeableConcept { get; set; }

    /// <summary>
    /// Account to place this charge
    /// </summary>
    [JsonPropertyName("account")]
    public SimpleReference? Account { get; set; }

    /// <summary>
    /// Comments made about the ChargeItem
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// Further information supporting this charge
    /// </summary>
    [JsonPropertyName("supportingInformation")]
    public SimpleReference? SupportingInformation { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ChargeItem";

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
