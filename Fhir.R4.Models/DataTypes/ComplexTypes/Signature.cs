using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// A digital signature along with supporting context.
/// </summary>
/// <remarks>
/// FHIR R4 Signature DataType
/// A digital signature along with supporting context. The signature may be a digital signature that is cryptographic in nature, or an electronic signature.
/// </remarks>
public class Signature : ComplexType<Signature>
{
    /// <summary>
    /// An indication of the reason that the entity signed this document.
    /// FHIR Path: Signature.type
    /// Cardinality: 1..*
    /// </summary>
    [JsonPropertyName("type")]
    public List<Coding>? Type { get; set; }

    /// <summary>
    /// When the digital signature was signed.
    /// FHIR Path: Signature.when
    /// Cardinality: 1..1
    /// </summary>
    [JsonPropertyName("when")]
    public FhirInstant When { get; set; } = null!;

    /// <summary>
    /// A reference to an application-usable description of the identity that signed.
    /// FHIR Path: Signature.who
    /// Cardinality: 1..1
    /// </summary>
    [JsonPropertyName("who")]
    public Reference<Resource> Who { get; set; } = null!;

    /// <summary>
    /// A reference to an application-usable description of the identity that is represented by the signature.
    /// FHIR Path: Signature.onBehalfOf
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("onBehalfOf")]
    public Reference<Resource>? OnBehalfOf { get; set; }

    /// <summary>
    /// A mime type that indicates the technical format of the target resources signed by the signature.
    /// FHIR Path: Signature.targetFormat
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("targetFormat")]
    public FhirCode? TargetFormat { get; set; }

    /// <summary>
    /// A mime type that indicates the technical format of the signature.
    /// FHIR Path: Signature.sigFormat
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("sigFormat")]
    public FhirCode? SigFormat { get; set; }

    /// <summary>
    /// The base64 encoding of the Signature content.
    /// FHIR Path: Signature.data
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("data")]
    public FhirBase64Binary? Data { get; set; }

    /// <summary>
    /// Initializes a new instance of the Signature class.
    /// </summary>
    public Signature() { }

    /// <summary>
    /// Initializes a new instance of the Signature class with required fields.
    /// </summary>
    /// <param name="type">The signature type.</param>
    /// <param name="when">When the signature was created.</param>
    /// <param name="who">Who signed.</param>
    public Signature(List<Coding> type, FhirInstant when, Reference<Resource> who)
    {
        Type = type;
        When = when;
        Who = who;
    }

    /// <summary>
    /// Creates a basic signature with a single type.
    /// </summary>
    /// <param name="typeCode">The signature type code.</param>
    /// <param name="typeSystem">The signature type system.</param>
    /// <param name="when">When the signature was created.</param>
    /// <param name="who">Who signed.</param>
    /// <returns>A new Signature instance.</returns>
    public static Signature Create(string typeCode, string typeSystem, FhirInstant when, Reference<Resource> who)
    {
        return new Signature(
            new List<Coding> { new Coding { Code = typeCode, System = typeSystem } },
            when,
            who
        );
    }

    /// <summary>
    /// Creates a signature for author verification.
    /// </summary>
    /// <param name="when">When the signature was created.</param>
    /// <param name="who">Who signed.</param>
    /// <returns>A new Signature instance.</returns>
    public static Signature CreateAuthorSignature(FhirInstant when, Reference<Resource> who)
    {
        return Create("1.2.840.10065.1.12.1.1", "urn:iso-astm:E1762-95:2013", when, who);
    }

    /// <summary>
    /// Creates a signature for verification.
    /// </summary>
    /// <param name="when">When the signature was created.</param>
    /// <param name="who">Who signed.</param>
    /// <returns>A new Signature instance.</returns>
    public static Signature CreateVerificationSignature(FhirInstant when, Reference<Resource> who)
    {
        return Create("1.2.840.10065.1.12.1.5", "urn:iso-astm:E1762-95:2013", when, who);
    }

    /// <summary>
    /// Sets the signature data.
    /// </summary>
    /// <param name="data">The signature data as base64 string.</param>
    /// <param name="format">The signature format (e.g., "application/signature+xml").</param>
    /// <returns>This Signature instance for method chaining.</returns>
    public Signature WithData(string data, string format)
    {
        Data = new FhirBase64Binary(data);
        SigFormat = new FhirCode(format);
        return this;
    }

    /// <summary>
    /// Sets the target format.
    /// </summary>
    /// <param name="format">The target format (e.g., "application/fhir+xml").</param>
    /// <returns>This Signature instance for method chaining.</returns>
    public Signature WithTargetFormat(string format)
    {
        TargetFormat = new FhirCode(format);
        return this;
    }

    /// <summary>
    /// Sets the on behalf of reference.
    /// </summary>
    /// <param name="onBehalfOf">The on behalf of reference.</param>
    /// <returns>This Signature instance for method chaining.</returns>
    public Signature OnBehalfOfReference(Reference<Resource> onBehalfOf)
    {
        OnBehalfOf = onBehalfOf;
        return this;
    }

    /// <summary>
    /// Validates the Signature according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    protected override IEnumerable<ValidationResult> ValidateComplexType(ValidationContext validationContext)
    {
        // Required fields validation
        if (Type == null || Type.Count == 0)
        {
            yield return new ValidationResult(
                "Signature type is required",
                new[] { nameof(Type) });
        }

        if (When == null)
        {
            yield return new ValidationResult(
                "Signature when is required",
                new[] { nameof(When) });
        }

        if (Who == null)
        {
            yield return new ValidationResult(
                "Signature who is required",
                new[] { nameof(Who) });
        }
    }

    protected override string? GetComplexTypeString()
    {
        var typeStr = Type?.FirstOrDefault()?.Code ?? "unknown";
        var whenStr = When?.Value ?? "unknown";
        var whoStr = Who?.Display ?? Who?.ReferenceValue ?? "unknown";
        return $"Signature: {typeStr} by {whoStr} at {whenStr}";
    }
}
