// <auto-generated />
// FHIR R4 Resource: Specimen
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// A sample to be used for analysis.
/// </summary>
public class Specimen : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "Specimen";

    /// <summary>
    /// External Identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Identifier assigned by the lab
    /// </summary>
    [JsonPropertyName("accessionIdentifier")]
    public Identifier AccessionIdentifier { get; set; }

    /// <summary>
    /// available | unavailable | unsatisfactory | entered-in-error
    /// </summary>
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// Kind of material that forms the specimen
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Where the specimen came from. This may be from patient(s), from a location (e.g., the source of an environmental sample), or a sampling of a substance or a device
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference Subject { get; set; }

    /// <summary>
    /// The time when specimen was received for processing
    /// </summary>
    [JsonPropertyName("receivedTime")]
    public FhirDateTime ReceivedTime { get; set; }

    /// <summary>
    /// Specimen from which this specimen originated
    /// </summary>
    [JsonPropertyName("parent")]
    public List<Reference>? Parent { get; set; }

    /// <summary>
    /// Why the specimen was collected
    /// </summary>
    [JsonPropertyName("request")]
    public List<Reference>? Request { get; set; }

    /// <summary>
    /// Collection details
    /// </summary>
    [JsonPropertyName("collection")]
    public BackboneElement Collection { get; set; }

    /// <summary>
    /// Who collected the specimen
    /// </summary>
    [JsonPropertyName("collector")]
    public Reference Collector { get; set; }

    /// <summary>
    /// How long it took to collect specimen
    /// </summary>
    [JsonPropertyName("duration")]
    public Duration DurationValue { get; set; }

    /// <summary>
    /// The quantity of specimen collected
    /// </summary>
    [JsonPropertyName("quantity")]
    public Quantity QuantityValue { get; set; }

    /// <summary>
    /// Technique used to perform collection
    /// </summary>
    [JsonPropertyName("method")]
    public CodeableConcept Method { get; set; }

    /// <summary>
    /// Anatomical collection site
    /// </summary>
    [JsonPropertyName("bodySite")]
    public CodeableConcept BodySite { get; set; }

    /// <summary>
    /// Processing and processing step details
    /// </summary>
    [JsonPropertyName("processing")]
    public List<BackboneElement>? Processing { get; set; }

    /// <summary>
    /// Textual description of procedure
    /// </summary>
    [JsonPropertyName("description")]
    public FhirString Description { get; set; }

    /// <summary>
    /// Indicates the treatment step  applied to the specimen
    /// </summary>
    [JsonPropertyName("procedure")]
    public CodeableConcept Procedure { get; set; }

    /// <summary>
    /// Material used in the processing step
    /// </summary>
    [JsonPropertyName("additive")]
    public List<Reference>? Additive { get; set; }

    /// <summary>
    /// Direct container of specimen (tube/slide, etc.)
    /// </summary>
    [JsonPropertyName("container")]
    public List<BackboneElement>? Container { get; set; }

    /// <summary>
    /// Id for the container
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Textual description of the container
    /// </summary>
    [JsonPropertyName("description")]
    public FhirString Description { get; set; }

    /// <summary>
    /// Kind of container directly associated with specimen
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Container volume or size
    /// </summary>
    [JsonPropertyName("capacity")]
    public Quantity Capacity { get; set; }

    /// <summary>
    /// Quantity of specimen within container
    /// </summary>
    [JsonPropertyName("specimenQuantity")]
    public Quantity SpecimenQuantity { get; set; }

    /// <summary>
    /// State of the specimen
    /// </summary>
    [JsonPropertyName("condition")]
    public List<CodeableConcept>? Condition { get; set; }

    /// <summary>
    /// Comments
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
