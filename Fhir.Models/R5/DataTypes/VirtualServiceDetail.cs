// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// VirtualServiceDetail Type: Virtual Service Contact Details.
/// </summary>
public class VirtualServiceDetail : DataType
{
    /// <summary>
    /// Unique id for the element within a resource (for internal references). This may be any string value
    /// that does not contain spaces.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// element. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 11)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// The type of virtual service to connect to (i.e. Teams, Zoom, Specific VMR technology, WhatsApp).
    /// </summary>
    [FhirElement("channelType", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("channelType")]
    public Coding ChannelType { get; set; }

    /// <summary>
    /// What address or number needs to be used for a user to connect to the virtual service to join. The
    /// channelType informs as to which datatype is appropriate to use (requires knowledge of the specific
    /// type). (as url)
    /// </summary>
    [FhirElement("addressurlUnknown", Order = 13)]
    [Cardinality(0, 1)]
    [ChoiceType("addressurl", "unknown")]
    [JsonPropertyName("addressurlUnknown")]
    public FhirUrl? AddressUrl { get; set; }

    /// <summary>
    /// What address or number needs to be used for a user to connect to the virtual service to join. The
    /// channelType informs as to which datatype is appropriate to use (requires knowledge of the specific
    /// type). (as string)
    /// </summary>
    [FhirElement("addressString", Order = 14)]
    [Cardinality(0, 1)]
    [ChoiceType("address", "string")]
    [JsonPropertyName("addressString")]
    public FhirString? AddressString { get; set; }

    /// <summary>
    /// What address or number needs to be used for a user to connect to the virtual service to join. The
    /// channelType informs as to which datatype is appropriate to use (requires knowledge of the specific
    /// type). (as ContactPoint)
    /// </summary>
    [FhirElement("addressContactPoint", Order = 15)]
    [Cardinality(0, 1)]
    [ChoiceType("address", "contactPoint")]
    [JsonPropertyName("addressContactPoint")]
    public ContactPoint AddressContactPoint { get; set; }

    /// <summary>
    /// What address or number needs to be used for a user to connect to the virtual service to join. The
    /// channelType informs as to which datatype is appropriate to use (requires knowledge of the specific
    /// type). (as ExtendedContactDetail)
    /// </summary>
    [FhirElement("addressextendedcontactdetailUnknown", Order = 16)]
    [Cardinality(0, 1)]
    [ChoiceType("addressextendedcontactdetail", "unknown")]
    [JsonPropertyName("addressextendedcontactdetailUnknown")]
    public ExtendedContactDetail AddressExtendedContactDetail { get; set; }

    /// <summary>
    /// Address to see alternative connection details.
    /// </summary>
    [FhirElement("additionalInfo", Order = 17)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("additionalInfo")]
    public List<FhirUrl>? AdditionalInfo { get; set; }

    /// <summary>
    /// Maximum number of participants supported by the virtual service.
    /// </summary>
    [FhirElement("maxParticipants", Order = 18)]
    [Cardinality(0, 1)]
    [JsonPropertyName("maxParticipants")]
    public FhirPositiveInt? MaxParticipants { get; set; }

    /// <summary>
    /// Session Key required by the virtual service.
    /// </summary>
    [FhirElement("sessionKey", Order = 19)]
    [Cardinality(0, 1)]
    [JsonPropertyName("sessionKey")]
    public FhirString? SessionKey { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for addressurl[x]
        var addressurlProperties = new[] { nameof(AddressUrl) };
        var addressurlSetCount = addressurlProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (addressurlSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AddressUrl may be specified",
                new[] { nameof(AddressUrl) });
        }

        // Choice Type validation for address[x]
        var addressProperties = new[] { nameof(AddressString), nameof(AddressContactPoint) };
        var addressSetCount = addressProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (addressSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AddressString, AddressContactPoint may be specified",
                new[] { nameof(AddressString), nameof(AddressContactPoint) });
        }

        // Choice Type validation for addressextendedcontactdetail[x]
        var addressextendedcontactdetailProperties = new[] { nameof(AddressExtendedContactDetail) };
        var addressextendedcontactdetailSetCount = addressextendedcontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (addressextendedcontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of AddressExtendedContactDetail may be specified",
                new[] { nameof(AddressExtendedContactDetail) });
        }

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate VirtualServiceDetail cardinality
        var virtualservicedetailCount = VirtualServiceDetail?.Count ?? 0;
        if (virtualservicedetailCount < 0)
        {
            yield return new ValidationResult("Element 'VirtualServiceDetail' cardinality must be 0..*", new[] { nameof(VirtualServiceDetail) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'VirtualServiceDetail.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate AdditionalInfo cardinality
        var additionalinfoCount = AdditionalInfo?.Count ?? 0;
        if (additionalinfoCount < 0)
        {
            yield return new ValidationResult("Element 'VirtualServiceDetail.additionalInfo' cardinality must be 0..*", new[] { nameof(AdditionalInfo) });
        }

        // Constraint validation
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(VirtualServiceDetail) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Extension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(Extension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ChannelType) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Address) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AdditionalInfo) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(MaxParticipants) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(SessionKey) });
        // }
    }

}
