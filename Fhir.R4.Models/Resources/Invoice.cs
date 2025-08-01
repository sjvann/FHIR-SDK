// <auto-generated />
// FHIR R4 Resource: Invoice
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Invoice containing collected ChargeItems from an Account with calculated individual and total price for Billing purpose.
/// </summary>
public class Invoice : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Invoice";

    /// <summary>
    /// Business Identifier for item
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// draft | issued | balanced | cancelled | entered-in-error
    /// </summary>
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Reason for cancellation of this Invoice
    /// </summary>
    [JsonPropertyName("cancelledReason")]
    public FhirString CancelledReason { get; set; }

    /// <summary>
    /// Type of Invoice
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Recipient(s) of goods and services
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// Recipient of this invoice
    /// </summary>
    [JsonPropertyName("recipient")]
    public Reference Recipient { get; set; }

    /// <summary>
    /// Invoice date / posting date
    /// </summary>
    [JsonPropertyName("date")]
    public FhirDateTime Date { get; set; }

    /// <summary>
    /// Participant in creation of this Invoice
    /// </summary>
    [JsonPropertyName("participant")]
    public List<BackboneElement>? Participant { get; set; }

    /// <summary>
    /// Issuing Organization of Invoice
    /// </summary>
    [JsonPropertyName("issuer")]
    public Reference Issuer { get; set; }

    /// <summary>
    /// Account that is being balanced
    /// </summary>
    [JsonPropertyName("account")]
    public Reference Account { get; set; }

    /// <summary>
    /// Line items of this Invoice
    /// </summary>
    [JsonPropertyName("lineItem")]
    public List<BackboneElement>? LineItem { get; set; }

    /// <summary>
    /// Sequence number of line item
    /// </summary>
    [JsonPropertyName("sequence")]
    public FhirPositiveInt Sequence { get; set; }

    /// <summary>
    /// Components of total line item price
    /// </summary>
    [JsonPropertyName("priceComponent")]
    public List<BackboneElement>? PriceComponent { get; set; }

    /// <summary>
    /// Components of Invoice total
    /// </summary>
    [JsonPropertyName("totalPriceComponent")]
    public List<>? TotalPriceComponent { get; set; }

    /// <summary>
    /// Net total of this Invoice
    /// </summary>
    [JsonPropertyName("totalNet")]
    public Money TotalNet { get; set; }

    /// <summary>
    /// Gross total of this Invoice
    /// </summary>
    [JsonPropertyName("totalGross")]
    public Money TotalGross { get; set; }

    /// <summary>
    /// Payment details
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public FhirMarkdown PaymentTerms { get; set; }

    /// <summary>
    /// Comments made about the invoice
    /// </summary>
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

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
