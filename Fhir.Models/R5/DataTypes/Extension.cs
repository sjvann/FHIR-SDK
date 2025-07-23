// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Extension Type: Optional Extension Element - found in all resources.
/// </summary>
public class Extension : DataType
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
    /// Source of the definition for the extension code - a logical name or a URL.
    /// </summary>
    [FhirElement("url", Order = 12)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("url")]
    public FhirString Url { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as base64Binary)
    /// </summary>
    [FhirElement("valuebase64binaryUnknown", Order = 13)]
    [Cardinality(0, 1)]
    [ChoiceType("valuebase64binary", "unknown")]
    [JsonPropertyName("valuebase64binaryUnknown")]
    public FhirBase64Binary? ValueBase64Binary { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as boolean)
    /// </summary>
    [FhirElement("valueBoolean", Order = 14)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "boolean")]
    [JsonPropertyName("valueBoolean")]
    public FhirBoolean? ValueBoolean { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as canonical)
    /// </summary>
    [FhirElement("valuecanonicalUnknown", Order = 15)]
    [Cardinality(0, 1)]
    [ChoiceType("valuecanonical", "unknown")]
    [JsonPropertyName("valuecanonicalUnknown")]
    public FhirCanonical? ValueCanonical { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as code)
    /// </summary>
    [FhirElement("valueCode", Order = 16)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "code")]
    [JsonPropertyName("valueCode")]
    public FhirCode? ValueCode { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as date)
    /// </summary>
    [FhirElement("valuedateUnknown", Order = 17)]
    [Cardinality(0, 1)]
    [ChoiceType("valuedate", "unknown")]
    [JsonPropertyName("valuedateUnknown")]
    public FhirDate? ValueDate { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as dateTime)
    /// </summary>
    [FhirElement("valueDateTime", Order = 18)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "dateTime")]
    [JsonPropertyName("valueDateTime")]
    public FhirDateTime? ValueDateTime { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as decimal)
    /// </summary>
    [FhirElement("valueDecimal", Order = 19)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "decimal")]
    [JsonPropertyName("valueDecimal")]
    public FhirDecimal? ValueDecimal { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as id)
    /// </summary>
    [FhirElement("valueidUnknown", Order = 20)]
    [Cardinality(0, 1)]
    [ChoiceType("valueid", "unknown")]
    [JsonPropertyName("valueidUnknown")]
    public FhirId? ValueId { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as instant)
    /// </summary>
    [FhirElement("valueinstantUnknown", Order = 21)]
    [Cardinality(0, 1)]
    [ChoiceType("valueinstant", "unknown")]
    [JsonPropertyName("valueinstantUnknown")]
    public FhirInstant? ValueInstant { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as integer)
    /// </summary>
    [FhirElement("valueInteger", Order = 22)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "integer")]
    [JsonPropertyName("valueInteger")]
    public FhirInteger? ValueInteger { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as integer64)
    /// </summary>
    [FhirElement("valueinteger64Unknown", Order = 23)]
    [Cardinality(0, 1)]
    [ChoiceType("valueinteger64", "unknown")]
    [JsonPropertyName("valueinteger64Unknown")]
    public FhirInteger64? ValueInteger64 { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as markdown)
    /// </summary>
    [FhirElement("valuemarkdownUnknown", Order = 24)]
    [Cardinality(0, 1)]
    [ChoiceType("valuemarkdown", "unknown")]
    [JsonPropertyName("valuemarkdownUnknown")]
    public FhirMarkdown? ValueMarkdown { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as oid)
    /// </summary>
    [FhirElement("valueoidUnknown", Order = 25)]
    [Cardinality(0, 1)]
    [ChoiceType("valueoid", "unknown")]
    [JsonPropertyName("valueoidUnknown")]
    public FhirOid? ValueOid { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as positiveInt)
    /// </summary>
    [FhirElement("valuepositiveintUnknown", Order = 26)]
    [Cardinality(0, 1)]
    [ChoiceType("valuepositiveint", "unknown")]
    [JsonPropertyName("valuepositiveintUnknown")]
    public FhirPositiveInt? ValuePositiveInt { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as string)
    /// </summary>
    [FhirElement("valueString", Order = 27)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "string")]
    [JsonPropertyName("valueString")]
    public FhirString? ValueString { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as time)
    /// </summary>
    [FhirElement("valuetimeUnknown", Order = 28)]
    [Cardinality(0, 1)]
    [ChoiceType("valuetime", "unknown")]
    [JsonPropertyName("valuetimeUnknown")]
    public FhirTime? ValueTime { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as unsignedInt)
    /// </summary>
    [FhirElement("valueunsignedintUnknown", Order = 29)]
    [Cardinality(0, 1)]
    [ChoiceType("valueunsignedint", "unknown")]
    [JsonPropertyName("valueunsignedintUnknown")]
    public FhirUnsignedInt? ValueUnsignedInt { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as uri)
    /// </summary>
    [FhirElement("valueUri", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "uri")]
    [JsonPropertyName("valueUri")]
    public FhirUri? ValueUri { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as url)
    /// </summary>
    [FhirElement("valueurlUnknown", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("valueurl", "unknown")]
    [JsonPropertyName("valueurlUnknown")]
    public FhirUrl? ValueUrl { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as uuid)
    /// </summary>
    [FhirElement("valueuuidUnknown", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("valueuuid", "unknown")]
    [JsonPropertyName("valueuuidUnknown")]
    public FhirUuid? ValueUuid { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Address)
    /// </summary>
    [FhirElement("valueAddress", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "address")]
    [JsonPropertyName("valueAddress")]
    public Address ValueAddress { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Age)
    /// </summary>
    [FhirElement("valueageUnknown", Order = 34)]
    [Cardinality(0, 1)]
    [ChoiceType("valueage", "unknown")]
    [JsonPropertyName("valueageUnknown")]
    public Age ValueAge { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Annotation)
    /// </summary>
    [FhirElement("valueAnnotation", Order = 35)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "annotation")]
    [JsonPropertyName("valueAnnotation")]
    public Annotation ValueAnnotation { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Attachment)
    /// </summary>
    [FhirElement("valueAttachment", Order = 36)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "attachment")]
    [JsonPropertyName("valueAttachment")]
    public Attachment ValueAttachment { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as CodeableConcept)
    /// </summary>
    [FhirElement("valueCodeableConcept", Order = 37)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "codeableConcept")]
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept ValueCodeableConcept { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as CodeableReference)
    /// </summary>
    [FhirElement("valueCodeableReference", Order = 38)]
    [Cardinality(0, 1)]
    [ChoiceType("valueCodeable", "reference")]
    [JsonPropertyName("valueCodeableReference")]
    public CodeableReference ValueCodeableReference { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Coding)
    /// </summary>
    [FhirElement("valueCoding", Order = 39)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "coding")]
    [JsonPropertyName("valueCoding")]
    public Coding ValueCoding { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as ContactPoint)
    /// </summary>
    [FhirElement("valueContactPoint", Order = 40)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "contactPoint")]
    [JsonPropertyName("valueContactPoint")]
    public ContactPoint ValueContactPoint { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Count)
    /// </summary>
    [FhirElement("valuecountUnknown", Order = 41)]
    [Cardinality(0, 1)]
    [ChoiceType("valuecount", "unknown")]
    [JsonPropertyName("valuecountUnknown")]
    public Count ValueCount { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Distance)
    /// </summary>
    [FhirElement("valuedistanceUnknown", Order = 42)]
    [Cardinality(0, 1)]
    [ChoiceType("valuedistance", "unknown")]
    [JsonPropertyName("valuedistanceUnknown")]
    public Distance ValueDistance { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Duration)
    /// </summary>
    [FhirElement("valuedurationUnknown", Order = 43)]
    [Cardinality(0, 1)]
    [ChoiceType("valueduration", "unknown")]
    [JsonPropertyName("valuedurationUnknown")]
    public Duration ValueDuration { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as HumanName)
    /// </summary>
    [FhirElement("valueHumanName", Order = 44)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "humanName")]
    [JsonPropertyName("valueHumanName")]
    public HumanName ValueHumanName { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Identifier)
    /// </summary>
    [FhirElement("valueIdentifier", Order = 45)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "identifier")]
    [JsonPropertyName("valueIdentifier")]
    public Identifier ValueIdentifier { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Money)
    /// </summary>
    [FhirElement("valuemoneyUnknown", Order = 46)]
    [Cardinality(0, 1)]
    [ChoiceType("valuemoney", "unknown")]
    [JsonPropertyName("valuemoneyUnknown")]
    public Money ValueMoney { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Period)
    /// </summary>
    [FhirElement("valuePeriod", Order = 47)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "period")]
    [JsonPropertyName("valuePeriod")]
    public Period ValuePeriod { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Quantity)
    /// </summary>
    [FhirElement("valueQuantity", Order = 48)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "quantity")]
    [JsonPropertyName("valueQuantity")]
    public Quantity ValueQuantity { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Range)
    /// </summary>
    [FhirElement("valueRange", Order = 49)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "range")]
    [JsonPropertyName("valueRange")]
    public Range ValueRange { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Ratio)
    /// </summary>
    [FhirElement("valueRatio", Order = 50)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "ratio")]
    [JsonPropertyName("valueRatio")]
    public Ratio ValueRatio { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as RatioRange)
    /// </summary>
    [FhirElement("valueRatioRange", Order = 51)]
    [Cardinality(0, 1)]
    [ChoiceType("valueRatio", "range")]
    [JsonPropertyName("valueRatioRange")]
    public RatioRange ValueRatioRange { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Reference)
    /// </summary>
    [FhirElement("valueReference", Order = 52)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "reference")]
    [JsonPropertyName("valueReference")]
    public Reference ValueReference { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as SampledData)
    /// </summary>
    [FhirElement("valuesampleddataUnknown", Order = 53)]
    [Cardinality(0, 1)]
    [ChoiceType("valuesampleddata", "unknown")]
    [JsonPropertyName("valuesampleddataUnknown")]
    public SampledData ValueSampledData { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Signature)
    /// </summary>
    [FhirElement("valueSignature", Order = 54)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "signature")]
    [JsonPropertyName("valueSignature")]
    public Signature ValueSignature { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Timing)
    /// </summary>
    [FhirElement("valueTiming", Order = 55)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "timing")]
    [JsonPropertyName("valueTiming")]
    public Timing ValueTiming { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as ContactDetail)
    /// </summary>
    [FhirElement("valuecontactdetailUnknown", Order = 56)]
    [Cardinality(0, 1)]
    [ChoiceType("valuecontactdetail", "unknown")]
    [JsonPropertyName("valuecontactdetailUnknown")]
    public ContactDetail ValueContactDetail { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as DataRequirement)
    /// </summary>
    [FhirElement("valuedatarequirementUnknown", Order = 57)]
    [Cardinality(0, 1)]
    [ChoiceType("valuedatarequirement", "unknown")]
    [JsonPropertyName("valuedatarequirementUnknown")]
    public DataRequirement ValueDataRequirement { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Expression)
    /// </summary>
    [FhirElement("valueexpressionUnknown", Order = 58)]
    [Cardinality(0, 1)]
    [ChoiceType("valueexpression", "unknown")]
    [JsonPropertyName("valueexpressionUnknown")]
    public Expression ValueExpression { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as ParameterDefinition)
    /// </summary>
    [FhirElement("valueparameterdefinitionUnknown", Order = 59)]
    [Cardinality(0, 1)]
    [ChoiceType("valueparameterdefinition", "unknown")]
    [JsonPropertyName("valueparameterdefinitionUnknown")]
    public ParameterDefinition ValueParameterDefinition { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as RelatedArtifact)
    /// </summary>
    [FhirElement("valuerelatedartifactUnknown", Order = 60)]
    [Cardinality(0, 1)]
    [ChoiceType("valuerelatedartifact", "unknown")]
    [JsonPropertyName("valuerelatedartifactUnknown")]
    public RelatedArtifact ValueRelatedArtifact { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as TriggerDefinition)
    /// </summary>
    [FhirElement("valuetriggerdefinitionUnknown", Order = 61)]
    [Cardinality(0, 1)]
    [ChoiceType("valuetriggerdefinition", "unknown")]
    [JsonPropertyName("valuetriggerdefinitionUnknown")]
    public TriggerDefinition ValueTriggerDefinition { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as UsageContext)
    /// </summary>
    [FhirElement("valueusagecontextUnknown", Order = 62)]
    [Cardinality(0, 1)]
    [ChoiceType("valueusagecontext", "unknown")]
    [JsonPropertyName("valueusagecontextUnknown")]
    public UsageContext ValueUsageContext { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Availability)
    /// </summary>
    [FhirElement("valueavailabilityUnknown", Order = 63)]
    [Cardinality(0, 1)]
    [ChoiceType("valueavailability", "unknown")]
    [JsonPropertyName("valueavailabilityUnknown")]
    public Availability ValueAvailability { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as ExtendedContactDetail)
    /// </summary>
    [FhirElement("valueextendedcontactdetailUnknown", Order = 64)]
    [Cardinality(0, 1)]
    [ChoiceType("valueextendedcontactdetail", "unknown")]
    [JsonPropertyName("valueextendedcontactdetailUnknown")]
    public ExtendedContactDetail ValueExtendedContactDetail { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Dosage)
    /// </summary>
    [FhirElement("valuedosageUnknown", Order = 65)]
    [Cardinality(0, 1)]
    [ChoiceType("valuedosage", "unknown")]
    [JsonPropertyName("valuedosageUnknown")]
    public Dosage ValueDosage { get; set; }

    /// <summary>
    /// Value of extension - must be one of a constrained set of the data types (see
    /// [Extensibility](extensibility.html) for a list). (as Meta)
    /// </summary>
    [FhirElement("valuemetaUnknown", Order = 66)]
    [Cardinality(0, 1)]
    [ChoiceType("valuemeta", "unknown")]
    [JsonPropertyName("valuemetaUnknown")]
    public Meta ValueMeta { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for valuebase64binary[x]
        var valuebase64binaryProperties = new[] { nameof(ValueBase64Binary) };
        var valuebase64binarySetCount = valuebase64binaryProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuebase64binarySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueBase64Binary may be specified",
                new[] { nameof(ValueBase64Binary) });
        }

        // Choice Type validation for value[x]
        var valueProperties = new[] { nameof(ValueBoolean), nameof(ValueCode), nameof(ValueDateTime), nameof(ValueDecimal), nameof(ValueInteger), nameof(ValueString), nameof(ValueUri), nameof(ValueAddress), nameof(ValueAnnotation), nameof(ValueAttachment), nameof(ValueCodeableConcept), nameof(ValueCoding), nameof(ValueContactPoint), nameof(ValueHumanName), nameof(ValueIdentifier), nameof(ValuePeriod), nameof(ValueQuantity), nameof(ValueRange), nameof(ValueRatio), nameof(ValueReference), nameof(ValueSignature), nameof(ValueTiming) };
        var valueSetCount = valueProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueBoolean, ValueCode, ValueDateTime, ValueDecimal, ValueInteger, ValueString, ValueUri, ValueAddress, ValueAnnotation, ValueAttachment, ValueCodeableConcept, ValueCoding, ValueContactPoint, ValueHumanName, ValueIdentifier, ValuePeriod, ValueQuantity, ValueRange, ValueRatio, ValueReference, ValueSignature, ValueTiming may be specified",
                new[] { nameof(ValueBoolean), nameof(ValueCode), nameof(ValueDateTime), nameof(ValueDecimal), nameof(ValueInteger), nameof(ValueString), nameof(ValueUri), nameof(ValueAddress), nameof(ValueAnnotation), nameof(ValueAttachment), nameof(ValueCodeableConcept), nameof(ValueCoding), nameof(ValueContactPoint), nameof(ValueHumanName), nameof(ValueIdentifier), nameof(ValuePeriod), nameof(ValueQuantity), nameof(ValueRange), nameof(ValueRatio), nameof(ValueReference), nameof(ValueSignature), nameof(ValueTiming) });
        }

        // Choice Type validation for valuecanonical[x]
        var valuecanonicalProperties = new[] { nameof(ValueCanonical) };
        var valuecanonicalSetCount = valuecanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuecanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueCanonical may be specified",
                new[] { nameof(ValueCanonical) });
        }

        // Choice Type validation for valuedate[x]
        var valuedateProperties = new[] { nameof(ValueDate) };
        var valuedateSetCount = valuedateProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuedateSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueDate may be specified",
                new[] { nameof(ValueDate) });
        }

        // Choice Type validation for valueid[x]
        var valueidProperties = new[] { nameof(ValueId) };
        var valueidSetCount = valueidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueId may be specified",
                new[] { nameof(ValueId) });
        }

        // Choice Type validation for valueinstant[x]
        var valueinstantProperties = new[] { nameof(ValueInstant) };
        var valueinstantSetCount = valueinstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueinstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueInstant may be specified",
                new[] { nameof(ValueInstant) });
        }

        // Choice Type validation for valueinteger64[x]
        var valueinteger64Properties = new[] { nameof(ValueInteger64) };
        var valueinteger64SetCount = valueinteger64Properties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueinteger64SetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueInteger64 may be specified",
                new[] { nameof(ValueInteger64) });
        }

        // Choice Type validation for valuemarkdown[x]
        var valuemarkdownProperties = new[] { nameof(ValueMarkdown) };
        var valuemarkdownSetCount = valuemarkdownProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuemarkdownSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueMarkdown may be specified",
                new[] { nameof(ValueMarkdown) });
        }

        // Choice Type validation for valueoid[x]
        var valueoidProperties = new[] { nameof(ValueOid) };
        var valueoidSetCount = valueoidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueoidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueOid may be specified",
                new[] { nameof(ValueOid) });
        }

        // Choice Type validation for valuepositiveint[x]
        var valuepositiveintProperties = new[] { nameof(ValuePositiveInt) };
        var valuepositiveintSetCount = valuepositiveintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuepositiveintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValuePositiveInt may be specified",
                new[] { nameof(ValuePositiveInt) });
        }

        // Choice Type validation for valuetime[x]
        var valuetimeProperties = new[] { nameof(ValueTime) };
        var valuetimeSetCount = valuetimeProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuetimeSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueTime may be specified",
                new[] { nameof(ValueTime) });
        }

        // Choice Type validation for valueunsignedint[x]
        var valueunsignedintProperties = new[] { nameof(ValueUnsignedInt) };
        var valueunsignedintSetCount = valueunsignedintProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueunsignedintSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueUnsignedInt may be specified",
                new[] { nameof(ValueUnsignedInt) });
        }

        // Choice Type validation for valueurl[x]
        var valueurlProperties = new[] { nameof(ValueUrl) };
        var valueurlSetCount = valueurlProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueurlSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueUrl may be specified",
                new[] { nameof(ValueUrl) });
        }

        // Choice Type validation for valueuuid[x]
        var valueuuidProperties = new[] { nameof(ValueUuid) };
        var valueuuidSetCount = valueuuidProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueuuidSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueUuid may be specified",
                new[] { nameof(ValueUuid) });
        }

        // Choice Type validation for valueage[x]
        var valueageProperties = new[] { nameof(ValueAge) };
        var valueageSetCount = valueageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueAge may be specified",
                new[] { nameof(ValueAge) });
        }

        // Choice Type validation for valueCodeable[x]
        var valueCodeableProperties = new[] { nameof(ValueCodeableReference) };
        var valueCodeableSetCount = valueCodeableProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueCodeableSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueCodeableReference may be specified",
                new[] { nameof(ValueCodeableReference) });
        }

        // Choice Type validation for valuecount[x]
        var valuecountProperties = new[] { nameof(ValueCount) };
        var valuecountSetCount = valuecountProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuecountSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueCount may be specified",
                new[] { nameof(ValueCount) });
        }

        // Choice Type validation for valuedistance[x]
        var valuedistanceProperties = new[] { nameof(ValueDistance) };
        var valuedistanceSetCount = valuedistanceProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuedistanceSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueDistance may be specified",
                new[] { nameof(ValueDistance) });
        }

        // Choice Type validation for valueduration[x]
        var valuedurationProperties = new[] { nameof(ValueDuration) };
        var valuedurationSetCount = valuedurationProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuedurationSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueDuration may be specified",
                new[] { nameof(ValueDuration) });
        }

        // Choice Type validation for valuemoney[x]
        var valuemoneyProperties = new[] { nameof(ValueMoney) };
        var valuemoneySetCount = valuemoneyProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuemoneySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueMoney may be specified",
                new[] { nameof(ValueMoney) });
        }

        // Choice Type validation for valueRatio[x]
        var valueRatioProperties = new[] { nameof(ValueRatioRange) };
        var valueRatioSetCount = valueRatioProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueRatioSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueRatioRange may be specified",
                new[] { nameof(ValueRatioRange) });
        }

        // Choice Type validation for valuesampleddata[x]
        var valuesampleddataProperties = new[] { nameof(ValueSampledData) };
        var valuesampleddataSetCount = valuesampleddataProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuesampleddataSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueSampledData may be specified",
                new[] { nameof(ValueSampledData) });
        }

        // Choice Type validation for valuecontactdetail[x]
        var valuecontactdetailProperties = new[] { nameof(ValueContactDetail) };
        var valuecontactdetailSetCount = valuecontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuecontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueContactDetail may be specified",
                new[] { nameof(ValueContactDetail) });
        }

        // Choice Type validation for valuedatarequirement[x]
        var valuedatarequirementProperties = new[] { nameof(ValueDataRequirement) };
        var valuedatarequirementSetCount = valuedatarequirementProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuedatarequirementSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueDataRequirement may be specified",
                new[] { nameof(ValueDataRequirement) });
        }

        // Choice Type validation for valueexpression[x]
        var valueexpressionProperties = new[] { nameof(ValueExpression) };
        var valueexpressionSetCount = valueexpressionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueexpressionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueExpression may be specified",
                new[] { nameof(ValueExpression) });
        }

        // Choice Type validation for valueparameterdefinition[x]
        var valueparameterdefinitionProperties = new[] { nameof(ValueParameterDefinition) };
        var valueparameterdefinitionSetCount = valueparameterdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueparameterdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueParameterDefinition may be specified",
                new[] { nameof(ValueParameterDefinition) });
        }

        // Choice Type validation for valuerelatedartifact[x]
        var valuerelatedartifactProperties = new[] { nameof(ValueRelatedArtifact) };
        var valuerelatedartifactSetCount = valuerelatedartifactProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuerelatedartifactSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueRelatedArtifact may be specified",
                new[] { nameof(ValueRelatedArtifact) });
        }

        // Choice Type validation for valuetriggerdefinition[x]
        var valuetriggerdefinitionProperties = new[] { nameof(ValueTriggerDefinition) };
        var valuetriggerdefinitionSetCount = valuetriggerdefinitionProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuetriggerdefinitionSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueTriggerDefinition may be specified",
                new[] { nameof(ValueTriggerDefinition) });
        }

        // Choice Type validation for valueusagecontext[x]
        var valueusagecontextProperties = new[] { nameof(ValueUsageContext) };
        var valueusagecontextSetCount = valueusagecontextProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueusagecontextSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueUsageContext may be specified",
                new[] { nameof(ValueUsageContext) });
        }

        // Choice Type validation for valueavailability[x]
        var valueavailabilityProperties = new[] { nameof(ValueAvailability) };
        var valueavailabilitySetCount = valueavailabilityProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueavailabilitySetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueAvailability may be specified",
                new[] { nameof(ValueAvailability) });
        }

        // Choice Type validation for valueextendedcontactdetail[x]
        var valueextendedcontactdetailProperties = new[] { nameof(ValueExtendedContactDetail) };
        var valueextendedcontactdetailSetCount = valueextendedcontactdetailProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueextendedcontactdetailSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueExtendedContactDetail may be specified",
                new[] { nameof(ValueExtendedContactDetail) });
        }

        // Choice Type validation for valuedosage[x]
        var valuedosageProperties = new[] { nameof(ValueDosage) };
        var valuedosageSetCount = valuedosageProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuedosageSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueDosage may be specified",
                new[] { nameof(ValueDosage) });
        }

        // Choice Type validation for valuemeta[x]
        var valuemetaProperties = new[] { nameof(ValueMeta) };
        var valuemetaSetCount = valuemetaProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valuemetaSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueMeta may be specified",
                new[] { nameof(ValueMeta) });
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
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Extension.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        if (Url == null)
        {
            yield return new ValidationResult("Element 'Extension.url' cardinality must be 1..1", new[] { nameof(Url) });
        }

        // Constraint validation
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
    }

}
