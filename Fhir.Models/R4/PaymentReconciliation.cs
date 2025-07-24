// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// This resource provides the details including amount of a payment and allocates the payment items being paid
/// </summary>
public class PaymentReconciliation : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for a payment reconciliation
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Period covered
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Party generating payment
    /// </summary>
    [JsonPropertyName("paymentIssuer")]
    public SimpleReference? PaymentIssuer { get; set; }

    /// <summary>
    /// Reference to requesting resource
    /// </summary>
    [JsonPropertyName("request")]
    public SimpleReference? Request { get; set; }

    /// <summary>
    /// Responsible practitioner
    /// </summary>
    [JsonPropertyName("requestor")]
    public SimpleReference? Requestor { get; set; }

    /// <summary>
    /// queued | complete | error | partial
    /// </summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>
    /// Disposition message
    /// </summary>
    [JsonPropertyName("disposition")]
    public string? Disposition { get; set; }

    /// <summary>
    /// When payment issued
    /// </summary>
    [JsonPropertyName("paymentDate")]
    public DateTime? PaymentDate { get; set; }

    /// <summary>
    /// Total amount of Payment
    /// </summary>
    [JsonPropertyName("paymentAmount")]
    public string? PaymentAmount { get; set; }

    /// <summary>
    /// Business identifier of the payment
    /// </summary>
    [JsonPropertyName("paymentIdentifier")]
    public SimpleIdentifier? PaymentIdentifier { get; set; }

    /// <summary>
    /// Settlement particulars
    /// </summary>
    [JsonPropertyName("detail")]
    public SimpleBackboneElement? Detail { get; set; }

    /// <summary>
    /// Printed form identifier
    /// </summary>
    [JsonPropertyName("formCode")]
    public SimpleCodeableConcept? FormCode { get; set; }

    /// <summary>
    /// Note concerning processing
    /// </summary>
    [JsonPropertyName("processNote")]
    public SimpleBackboneElement? ProcessNote { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "PaymentReconciliation";

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
