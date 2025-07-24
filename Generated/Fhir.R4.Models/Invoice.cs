// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// Invoice containing collected ChargeItems from an Account with calculated individual and total price for Billing purpose
/// </summary>
public class Invoice : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for item
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// draft | issued | balanced | cancelled | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Reason for cancellation of this Invoice
    /// </summary>
    [JsonPropertyName("cancelledReason")]
    public string? CancelledReason { get; set; }

    /// <summary>
    /// Type of Invoice
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// Subject of the invoice
    /// </summary>
    [JsonPropertyName("subject")]
    public SimpleReference? Subject { get; set; }

    /// <summary>
    /// Recipient of this invoice
    /// </summary>
    [JsonPropertyName("recipient")]
    public SimpleReference? Recipient { get; set; }

    /// <summary>
    /// Invoice date / posting date
    /// </summary>
    [JsonPropertyName("date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Participant in creation of this Invoice
    /// </summary>
    [JsonPropertyName("participant")]
    public SimpleBackboneElement? Participant { get; set; }

    /// <summary>
    /// Issuing Organization of the Invoice
    /// </summary>
    [JsonPropertyName("issuer")]
    public SimpleReference? Issuer { get; set; }

    /// <summary>
    /// Account that is being balanced
    /// </summary>
    [JsonPropertyName("account")]
    public SimpleReference? Account { get; set; }

    /// <summary>
    /// Line items of this Invoice
    /// </summary>
    [JsonPropertyName("lineItem")]
    public SimpleBackboneElement? LineItem { get; set; }

    /// <summary>
    /// Components of total line items
    /// </summary>
    [JsonPropertyName("totalPriceComponent")]
    public SimpleBackboneElement? TotalPriceComponent { get; set; }

    /// <summary>
    /// Net total of this Invoice
    /// </summary>
    [JsonPropertyName("totalNet")]
    public string? TotalNet { get; set; }

    /// <summary>
    /// Gross total of this Invoice
    /// </summary>
    [JsonPropertyName("totalGross")]
    public string? TotalGross { get; set; }

    /// <summary>
    /// Payment details such as due date, etc.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public string? PaymentTerms { get; set; }

    /// <summary>
    /// Comments made about the invoice
    /// </summary>
    [JsonPropertyName("note")]
    public SimpleAnnotation? Note { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Invoice";

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
