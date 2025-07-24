// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// This resource provides the status of the payment for goods and services rendered
/// </summary>
public class PaymentNotice : SimpleDomainResource
{
    /// <summary>
    /// Unique identifier for the payment
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reference of payment for which this is being paid
    /// </summary>
    [JsonPropertyName("request")]
    public SimpleReference? Request { get; set; }

    /// <summary>
    /// Reference of response to this payment
    /// </summary>
    [JsonPropertyName("response")]
    public SimpleReference? Response { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Responsible practitioner
    /// </summary>
    [JsonPropertyName("provider")]
    public SimpleReference? Provider { get; set; }

    /// <summary>
    /// Payment reference
    /// </summary>
    [JsonPropertyName("payment")]
    public SimpleReference? Payment { get; set; }

    /// <summary>
    /// Payment or clearing date
    /// </summary>
    [JsonPropertyName("paymentDate")]
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Party being paid
    /// </summary>
    [JsonPropertyName("payee")]
    public SimpleReference? Payee { get; set; }

    /// <summary>
    /// Party being notified
    /// </summary>
    [JsonPropertyName("recipient")]
    public SimpleReference? Recipient { get; set; }

    /// <summary>
    /// Monetary amount of the payment
    /// </summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <summary>
    /// Issued or cleared Status of the payment
    /// </summary>
    [JsonPropertyName("paymentStatus")]
    public SimpleCodeableConcept? PaymentStatus { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "PaymentNotice";

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
