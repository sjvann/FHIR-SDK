// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// This resource provides the adjudication details from the processing of a Claim resource
/// </summary>
public class ClaimResponse : SimpleDomainResource
{
    /// <summary>
    /// Response number
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// More granular claim type
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// More granular claim type
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
    /// Response creation date
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Responsible practitioner
    /// </summary>
    [JsonPropertyName("insurer")]
    public SimpleReference? Insurer { get; set; }

    /// <summary>
    /// Party responsible for reimbursement
    /// </summary>
    [JsonPropertyName("requestor")]
    public SimpleReference? Requestor { get; set; }

    /// <summary>
    /// Id of resource triggering adjudication
    /// </summary>
    [JsonPropertyName("request")]
    public SimpleReference? Request { get; set; }

    /// <summary>
    /// queued | complete | error | partial
    /// </summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }

    /// <summary>
    /// Disposition Message
    /// </summary>
    [JsonPropertyName("disposition")]
    public string? Disposition { get; set; }

    /// <summary>
    /// Preauthorization reference
    /// </summary>
    [JsonPropertyName("preAuthRef")]
    public string? PreAuthRef { get; set; }

    /// <summary>
    /// Preauthorization reference effective period
    /// </summary>
    [JsonPropertyName("preAuthPeriod")]
    public SimplePeriod? PreAuthPeriod { get; set; }

    /// <summary>
    /// Party to be paid any benefits payable
    /// </summary>
    [JsonPropertyName("payeeType")]
    public SimpleCodeableConcept? PayeeType { get; set; }

    /// <summary>
    /// Adjudication for claim line items
    /// </summary>
    [JsonPropertyName("item")]
    public SimpleBackboneElement? Item { get; set; }

    /// <summary>
    /// Insurer added line items
    /// </summary>
    [JsonPropertyName("addItem")]
    public SimpleBackboneElement? AddItem { get; set; }

    /// <summary>
    /// Header-level adjudication
    /// </summary>
    [JsonPropertyName("adjudication")]
    public SimpleBackboneElement? Adjudication { get; set; }

    /// <summary>
    /// Adjudication totals
    /// </summary>
    [JsonPropertyName("total")]
    public SimpleBackboneElement? Total { get; set; }

    /// <summary>
    /// Payment Details
    /// </summary>
    [JsonPropertyName("payment")]
    public SimpleBackboneElement? Payment { get; set; }

    /// <summary>
    /// Printed form identifier
    /// </summary>
    [JsonPropertyName("formCode")]
    public SimpleCodeableConcept? FormCode { get; set; }

    /// <summary>
    /// Printed reference or actual form
    /// </summary>
    [JsonPropertyName("form")]
    public SimpleAttachment? Form { get; set; }

    /// <summary>
    /// Note concerning adjudication
    /// </summary>
    [JsonPropertyName("processNote")]
    public SimpleBackboneElement? ProcessNote { get; set; }

    /// <summary>
    /// Request for additional information
    /// </summary>
    [JsonPropertyName("communicationRequest")]
    public SimpleReference? CommunicationRequest { get; set; }

    /// <summary>
    /// Patient insurance information
    /// </summary>
    [JsonPropertyName("insurance")]
    public SimpleBackboneElement? Insurance { get; set; }

    /// <summary>
    /// Processing errors
    /// </summary>
    [JsonPropertyName("error")]
    public SimpleBackboneElement? Error { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ClaimResponse";

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
