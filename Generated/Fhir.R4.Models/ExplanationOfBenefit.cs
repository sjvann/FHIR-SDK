// Auto-generated for FHIR R4
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.Support.Base;

namespace Fhir.Models.R4;

/// <summary>
/// This resource provides the adjudication details from the processing of a Claim resource
/// </summary>
public class ExplanationOfBenefit : SimpleDomainResource
{
    /// <summary>
    /// Business Identifier for the resource
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// active | cancelled | draft | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// Category of the claim
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
    /// Creation date
    /// </summary>
    [JsonPropertyName("created")]
    public DateTime? Created { get; set; }

    /// <summary>
    /// Author of the claim
    /// </summary>
    [JsonPropertyName("enterer")]
    public SimpleReference? Enterer { get; set; }

    /// <summary>
    /// Party responsible for reimbursement
    /// </summary>
    [JsonPropertyName("insurer")]
    public SimpleReference? Insurer { get; set; }

    /// <summary>
    /// Provider of the products and services
    /// </summary>
    [JsonPropertyName("provider")]
    public SimpleReference? Provider { get; set; }

    /// <summary>
    /// Preauthorization reference
    /// </summary>
    [JsonPropertyName("preAuthRef")]
    public string? PreAuthRef { get; set; }

    /// <summary>
    /// Preauthorization in-effect period
    /// </summary>
    [JsonPropertyName("preAuthRefPeriod")]
    public SimplePeriod? PreAuthRefPeriod { get; set; }

    /// <summary>
    /// Care Team members
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
    /// Precedence (primary, secondary, etc.)
    /// </summary>
    [JsonPropertyName("precedence")]
    public uint? Precedence { get; set; }

    /// <summary>
    /// Insurance information
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
    /// Processing notes
    /// </summary>
    [JsonPropertyName("processNote")]
    public SimpleBackboneElement? ProcessNote { get; set; }

    /// <summary>
    /// Balance by Benefit Category
    /// </summary>
    [JsonPropertyName("benefitBalance")]
    public SimpleBackboneElement? BenefitBalance { get; set; }

    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "ExplanationOfBenefit";

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
