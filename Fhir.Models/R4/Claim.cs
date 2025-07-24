// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// A provider's list of professional services and products which have been provided, or are to be provided, to a patient which is sent to an insurer for reimbursement
/// </summary>
public class Claim : SimpleDomainResource
{
    /// <summary>
    /// The business identifier for the instance
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The category of claim
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// A finer grained suite of claim type codes
    /// </summary>
    [JsonPropertyName("subType")]
    public SimpleCodeableConcept? SubType { get; set; }

    /// <summary>
    /// claim | preauthorization | predetermination
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// The recipient of the products and services
    /// </summary>
    [JsonPropertyName("patient")]
    public SimpleReference? Patient { get; set; }

    /// <summary>
    /// Relevant time frame for the claim
    /// </summary>
    [JsonPropertyName("billablePeriod")]
    public SimplePeriod? BillablePeriod { get; set; }

    /// <summary>
    /// Resource creation date
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Author of the claim
    /// </summary>
    [JsonPropertyName("enterer")]
    public SimpleReference? Enterer { get; set; }

    /// <summary>
    /// Target
    /// </summary>
    [JsonPropertyName("insurer")]
    public SimpleReference? Insurer { get; set; }

    /// <summary>
    /// Provider of the products and services
    /// </summary>
    [JsonPropertyName("provider")]
    public SimpleReference? Provider { get; set; }

    /// <summary>
    /// Desired processing priority
    /// </summary>
    [JsonPropertyName("priority")]
    public SimpleCodeableConcept? Priority { get; set; }

    /// <summary>
    /// For whom to reserve funds
    /// </summary>
    [JsonPropertyName("fundsReserve")]
    public SimpleCodeableConcept? FundsReserve { get; set; }

    /// <summary>
    /// Other claims
    /// </summary>
    [JsonPropertyName("related")]
    public SimpleBackboneElement? Related { get; set; }

    /// <summary>
    /// Prescription authorizing services and products
    /// </summary>
    [JsonPropertyName("prescription")]
    public SimpleReference? Prescription { get; set; }

    /// <summary>
    /// Original prescription if superceded by fulfiller
    /// </summary>
    [JsonPropertyName("originalPrescription")]
    public SimpleReference? OriginalPrescription { get; set; }

    /// <summary>
    /// Recipient of benefits payable
    /// </summary>
    [JsonPropertyName("payee")]
    public SimpleBackboneElement? Payee { get; set; }

    /// <summary>
    /// Treatment referral
    /// </summary>
    [JsonPropertyName("referral")]
    public SimpleReference? Referral { get; set; }

    /// <summary>
    /// Servicing facility
    /// </summary>
    [JsonPropertyName("facility")]
    public SimpleReference? Facility { get; set; }

    /// <summary>
    /// Members of the care team
    /// </summary>
    [JsonPropertyName("careTeam")]
    public SimpleBackboneElement? CareTeam { get; set; }

    /// <summary>
    /// Supporting information
    /// </summary>
    [JsonPropertyName("supportingInfo")]
    public SimpleBackboneElement? SupportingInfo { get; set; }

    /// <summary>
    /// Pertinent diagnosis information
    /// </summary>
    [JsonPropertyName("diagnosis")]
    public SimpleBackboneElement? Diagnosis { get; set; }

    /// <summary>
    /// Clinical procedures performed
    /// </summary>
    [JsonPropertyName("procedure")]
    public SimpleBackboneElement? Procedure { get; set; }

    /// <summary>
    /// Patient insurance information
    /// </summary>
    [JsonPropertyName("insurance")]
    public SimpleBackboneElement? Insurance { get; set; }

    /// <summary>
    /// Details of the event
    /// </summary>
    [JsonPropertyName("accident")]
    public SimpleBackboneElement? Accident { get; set; }

    /// <summary>
    /// Product or service provided
    /// </summary>
    [JsonPropertyName("item")]
    public SimpleBackboneElement? Item { get; set; }

    /// <summary>
    /// Total claim cost
    /// </summary>
    [JsonPropertyName("total")]
    public string? Total { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Claim";

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
