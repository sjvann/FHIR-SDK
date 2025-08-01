// <auto-generated />
// FHIR R4 Resource: DeviceMetric
// This file is automatically generated. Do not edit manually.

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.TypeFramework.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Describes a measurement, calculation or setting capability of a medical device.
/// </summary>
public class DeviceMetric : DomainResource
{
    /// <summary>
    /// Resource type name
    /// </summary>
    [JsonPropertyName("resourceType")]
    public override string ResourceType => "DeviceMetric";

    /// <summary>
    /// Instance identifier
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? IdentifierValue { get; set; }

    /// <summary>
    /// Identity of metric, for example Heart Rate or PEEP Setting
    /// </summary>
    [Required]
    [JsonPropertyName("type")]
    public CodeableConcept Type { get; set; }

    /// <summary>
    /// Unit of Measure for the Metric
    /// </summary>
    [JsonPropertyName("unit")]
    public CodeableConcept Unit { get; set; }

    /// <summary>
    /// Describes the link to the source Device
    /// </summary>
    [JsonPropertyName("source")]
    public Reference Source { get; set; }

    /// <summary>
    /// Describes the link to the parent Device
    /// </summary>
    [JsonPropertyName("parent")]
    public Reference Parent { get; set; }

    /// <summary>
    /// on | off | standby | entered-in-error
    /// </summary>
    [JsonPropertyName("operationalStatus")]
    public FhirCode OperationalStatus { get; set; }

    /// <summary>
    /// black | red | green | yellow | blue | magenta | cyan | white
    /// </summary>
    [JsonPropertyName("color")]
    public FhirCode Color { get; set; }

    /// <summary>
    /// measurement | setting | calculation | unspecified
    /// </summary>
    [Required]
    [JsonPropertyName("category")]
    public FhirCode Category { get; set; }

    /// <summary>
    /// Describes the measurement repetition time
    /// </summary>
    [JsonPropertyName("measurementPeriod")]
    public Timing MeasurementPeriod { get; set; }

    /// <summary>
    /// Describes the calibrations that have been performed or that are required to be performed
    /// </summary>
    [JsonPropertyName("calibration")]
    public List<BackboneElement>? Calibration { get; set; }

    /// <summary>
    /// unspecified | offset | gain | two-point
    /// </summary>
    [JsonPropertyName("type")]
    public FhirCode Type { get; set; }

    /// <summary>
    /// not-calibrated | calibration-required | calibrated | unspecified
    /// </summary>
    [JsonPropertyName("state")]
    public FhirCode State { get; set; }

    /// <summary>
    /// Describes the time last calibration has been performed
    /// </summary>
    [JsonPropertyName("time")]
    public FhirInstant Time { get; set; }

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
