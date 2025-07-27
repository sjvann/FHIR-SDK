// Auto-generated for FHIR R4 - Based on existing architecture
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A simple test resource for validation
/// </summary>
/// <remarks>
/// FHIR R4 TestResource DomainResource
/// A simple test resource for validation
/// </remarks>
public class TestResource : DomainResource
{
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "TestResource";

    /// <summary>
    /// Business identifier for the test resource
    /// FHIR Path: TestResource.identifier
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// Whether this test resource record is in active use
    /// FHIR Path: TestResource.active
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("active")]
    public FhirBoolean? Active { get; set; }

    /// <summary>
    /// A name for the test resource
    /// FHIR Path: TestResource.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }

    /// <summary>
    /// Category of the test resource
    /// FHIR Path: TestResource.category
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("category")]
    public FhirCode? Category { get; set; }

    /// <summary>
    /// When the test resource is effective
    /// FHIR Path: TestResource.effectiveDate
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("effectiveDate")]
    public FhirDate? EffectiveDate { get; set; }

}
