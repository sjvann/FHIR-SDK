using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.DataTypes;

/// <summary>
/// Human-readable summary of the resource (essential clinical and business information).
/// </summary>
/// <remarks>
/// FHIR R4 Narrative ComplexType
/// A human-readable summary of the resource conveying the essential clinical and business information for the resource.
/// </remarks>
public class Narrative : Element
{
    /// <summary>
    /// The status of the narrative - whether it's generated, extensions, unknown, empty or additional.
    /// FHIR Path: Narrative.status
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("status")]
    [Required]
    public FhirCode? Status { get; set; }

    /// <summary>
    /// Limited xhtml content.
    /// FHIR Path: Narrative.div
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("div")]
    [Required]
    public string? Div { get; set; }
}
