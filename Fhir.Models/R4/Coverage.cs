// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Financial instrument which may be used to reimburse or pay for health care products and services
/// </summary>
public class Coverage : SimpleDomainResource
{
    /// <summary>
    /// The primary coverage ID
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Type of coverage such as medical or accident
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Owner of the policy
    /// </summary>
    [JsonPropertyName("policyHolder")]
    public SimpleReference? PolicyHolder { get; set; }

    /// <summary>
    /// Subscriber to the policy
    /// </summary>
    [JsonPropertyName("subscriber")]
    public SimpleReference? Subscriber { get; set; }

    /// <summary>
    /// ID assigned to the subscriber
    /// </summary>
    [JsonPropertyName("subscriberId")]
    public string? SubscriberId { get; set; }

    /// <summary>
    /// Plan beneficiary
    /// </summary>
    [JsonPropertyName("beneficiary")]
    public SimpleReference? Beneficiary { get; set; }

    /// <summary>
    /// Dependent number
    /// </summary>
    [JsonPropertyName("dependent")]
    public string? Dependent { get; set; }

    /// <summary>
    /// Coverage category such as medical or dental
    /// </summary>
    [JsonPropertyName("relationship")]
    public SimpleCodeableConcept? Relationship { get; set; }

    /// <summary>
    /// Coverage start and end dates
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Issuer of the policy
    /// </summary>
    [JsonPropertyName("payor")]
    public SimpleReference? Payor { get; set; }

    /// <summary>
    /// Additional coverage classifications
    /// </summary>
    [JsonPropertyName("class")]
    public SimpleBackboneElement? Class { get; set; }

    /// <summary>
    /// Relative order of the coverage
    /// </summary>
    [JsonPropertyName("order")]
    public uint? Order { get; set; }

    /// <summary>
    /// Insurer network
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// Patient payments for services/products
    /// </summary>
    [JsonPropertyName("costToBeneficiary")]
    public SimpleBackboneElement? CostToBeneficiary { get; set; }

    /// <summary>
    /// Reimbursement to insurer
    /// </summary>
    [JsonPropertyName("subrogation")]
    public bool? Subrogation { get; set; }

    /// <summary>
    /// Contract details
    /// </summary>
    [JsonPropertyName("contract")]
    public SimpleReference? Contract { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Coverage";

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
