// Auto-generated for FHIR R5
using System.ComponentModel.DataAnnotations;

namespace Fhir.R5.Models;

/// <summary>
/// Measurements and simple assertions made about a patient, device or other subject.
/// </summary>
public class Observation : DomainResource
{
    public override string ResourceType => "Observation";

    /// <summary>
    /// The logical id of the resource, as used in the URL for the resource. Once assigned, this value never
    /// changes.
    /// </summary>
    [FhirElement("id", Order = 10)]
    [Cardinality(0, 1)]
    [JsonPropertyName("id")]
    public FhirString? Id { get; set; }

    /// <summary>
    /// The metadata about the resource. This is content that is maintained by the infrastructure. Changes
    /// to the content might not always be associated with version changes to the resource.
    /// </summary>
    [FhirElement("meta", Order = 11)]
    [Cardinality(0, 1)]
    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    /// <summary>
    /// A reference to a set of rules that were followed when the resource was constructed, and which must
    /// be understood when processing the content. Often, this is a reference to an implementation guide
    /// that defines the special rules along with other profiles etc.
    /// </summary>
    [FhirElement("implicitRules", Order = 12)]
    [Cardinality(0, 1)]
    [JsonPropertyName("implicitRules")]
    public FhirUri? ImplicitRules { get; set; }

    /// <summary>
    /// The base language in which the resource is written.
    /// </summary>
    [FhirElement("language", Order = 13)]
    [Cardinality(0, 1)]
    [JsonPropertyName("language")]
    public FhirCode? Language { get; set; }

    /// <summary>
    /// A human-readable narrative that contains a summary of the resource and can be used to represent the
    /// content of the resource to a human. The narrative need not encode all the structured data, but is
    /// required to contain sufficient detail to make it &quot;clinically safe&quot; for a human to just
    /// read the narrative. Resource definitions may define what content should be represented in the
    /// narrative to ensure clinical safety.
    /// </summary>
    [FhirElement("text", Order = 14)]
    [Cardinality(0, 1)]
    [JsonPropertyName("text")]
    public Narrative Text { get; set; }

    /// <summary>
    /// These resources do not have an independent existence apart from the resource that contains them -
    /// they cannot be identified independently, nor can they have their own independent transaction scope.
    /// This is allowed to be a Parameters resource if and only if it is referenced by a resource that
    /// provides context/meaning.
    /// </summary>
    [FhirElement("contained", Order = 15)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("contained")]
    public List<Resource>? Contained { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// resource. To make the use of extensions safe and managable, there is a strict set of governance
    /// applied to the definition and use of extensions. Though any implementer can define an extension,
    /// there is a set of requirements that SHALL be met as part of the definition of the extension.
    /// </summary>
    [FhirElement("extension", Order = 16)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("extension")]
    public List<Extension>? Extension { get; set; }

    /// <summary>
    /// May be used to represent additional information that is not part of the basic definition of the
    /// resource and that modifies the understanding of the element that contains it and/or the
    /// understanding of the containing element&apos;s descendants. Usually modifier elements provide
    /// negation or qualification. To make the use of extensions safe and managable, there is a strict set
    /// of governance applied to the definition and use of extensions. Though any implementer is allowed to
    /// define an extension, there is a set of requirements that SHALL be met as part of the definition of
    /// the extension. Applications processing a resource are required to check for modifier extensions.
    /// Modifier extensions SHALL NOT change the meaning of any elements on Resource or DomainResource
    /// (including cannot change the meaning of modifierExtension itself).
    /// </summary>
    [FhirElement("modifierExtension", Order = 17)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("modifierExtension")]
    public List<Extension>? ModifierExtension { get; set; }

    /// <summary>
    /// A unique identifier assigned to this observation.
    /// </summary>
    [FhirElement("identifier", Order = 18)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }

    /// <summary>
    /// The reference to a FHIR ObservationDefinition resource that provides the definition that is adhered
    /// to in whole or in part by this Observation instance. (as canonical)
    /// </summary>
    [FhirElement("instantiatescanonicalUnknown", Order = 19)]
    [Cardinality(0, 1)]
    [ChoiceType("instantiatescanonical", "unknown")]
    [JsonPropertyName("instantiatescanonicalUnknown")]
    public FhirCanonical? InstantiatesCanonical { get; set; }

    /// <summary>
    /// The reference to a FHIR ObservationDefinition resource that provides the definition that is adhered
    /// to in whole or in part by this Observation instance. (as Reference)
    /// </summary>
    [FhirElement("instantiatesReference", Order = 20)]
    [Cardinality(0, 1)]
    [ChoiceType("instantiates", "reference")]
    [JsonPropertyName("instantiatesReference")]
    public Reference<ObservationDefinition> InstantiatesReference { get; set; }

    /// <summary>
    /// A plan, proposal or order that is fulfilled in whole or in part by this event. For example, a
    /// MedicationRequest may require a patient to have laboratory test performed before it is dispensed.
    /// </summary>
    [FhirElement("basedOn", Order = 21)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan>>? BasedOn { get; set; }

    /// <summary>
    /// Identifies the observation(s) that triggered the performance of this observation.
    /// </summary>
    [FhirElement("triggeredBy", Order = 22)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("triggeredBy")]
    public List<BackboneElement>? TriggeredBy { get; set; }

    /// <summary>
    /// A larger event of which this particular Observation is a component or step. For example, an
    /// observation as part of a procedure.
    /// </summary>
    [FhirElement("partOf", Order = 23)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("partOf")]
    public List<Reference<MedicationAdministration>>? PartOf { get; set; }

    /// <summary>
    /// The status of the result value.
    /// </summary>
    [FhirElement("status", Order = 24)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("status")]
    public FhirCode Status { get; set; }

    /// <summary>
    /// A code that classifies the general type of observation being made.
    /// </summary>
    [FhirElement("category", Order = 25)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }

    /// <summary>
    /// Describes what was observed. Sometimes this is called the observation &quot;name&quot;.
    /// </summary>
    [FhirElement("code", Order = 26)]
    [Cardinality(1, 1)]
    [Required]
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; }

    /// <summary>
    /// The patient, or group of patients, location, device, organization, procedure or practitioner this
    /// observation is about and into whose or what record the observation is placed. If the actual focus of
    /// the observation is different from the subject (or a sample of, part, or region of the subject), the
    /// `focus` element or the `code` itself specifies the actual focus of the observation.
    /// </summary>
    [FhirElement("subject", Order = 27)]
    [Cardinality(0, 1)]
    [JsonPropertyName("subject")]
    public Reference<Patient> Subject { get; set; }

    /// <summary>
    /// The actual focus of an observation when it is not the patient of record representing something or
    /// someone associated with the patient such as a spouse, parent, fetus, or donor. For example, fetus
    /// observations in a mother&apos;s record. The focus of an observation could also be an existing
    /// condition, an intervention, the subject&apos;s diet, another observation of the subject, or a body
    /// structure such as tumor or implanted device. An example use case would be using the Observation
    /// resource to capture whether the mother is trained to change her child&apos;s tracheostomy tube. In
    /// this example, the child is the patient of record and the mother is the focus.
    /// </summary>
    [FhirElement("focus", Order = 28)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("focus")]
    public List<Reference<Resource>>? Focus { get; set; }

    /// <summary>
    /// The healthcare event (e.g. a patient and healthcare provider interaction) during which this
    /// observation is made.
    /// </summary>
    [FhirElement("encounter", Order = 29)]
    [Cardinality(0, 1)]
    [JsonPropertyName("encounter")]
    public Reference<Encounter> Encounter { get; set; }

    /// <summary>
    /// The time or time-period the observed value is asserted as being true. For biological subjects - e.g.
    /// human patients - this is usually called the &quot;physiologically relevant time&quot;. This is
    /// usually either the time of the procedure or of specimen collection, but very often the source of the
    /// date/time is not known, only the date/time itself. (as dateTime)
    /// </summary>
    [FhirElement("effectiveDateTime", Order = 30)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "dateTime")]
    [JsonPropertyName("effectiveDateTime")]
    public FhirDateTime? EffectiveDateTime { get; set; }

    /// <summary>
    /// The time or time-period the observed value is asserted as being true. For biological subjects - e.g.
    /// human patients - this is usually called the &quot;physiologically relevant time&quot;. This is
    /// usually either the time of the procedure or of specimen collection, but very often the source of the
    /// date/time is not known, only the date/time itself. (as Period)
    /// </summary>
    [FhirElement("effectivePeriod", Order = 31)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "period")]
    [JsonPropertyName("effectivePeriod")]
    public Period EffectivePeriod { get; set; }

    /// <summary>
    /// The time or time-period the observed value is asserted as being true. For biological subjects - e.g.
    /// human patients - this is usually called the &quot;physiologically relevant time&quot;. This is
    /// usually either the time of the procedure or of specimen collection, but very often the source of the
    /// date/time is not known, only the date/time itself. (as Timing)
    /// </summary>
    [FhirElement("effectiveTiming", Order = 32)]
    [Cardinality(0, 1)]
    [ChoiceType("effective", "timing")]
    [JsonPropertyName("effectiveTiming")]
    public Timing EffectiveTiming { get; set; }

    /// <summary>
    /// The time or time-period the observed value is asserted as being true. For biological subjects - e.g.
    /// human patients - this is usually called the &quot;physiologically relevant time&quot;. This is
    /// usually either the time of the procedure or of specimen collection, but very often the source of the
    /// date/time is not known, only the date/time itself. (as instant)
    /// </summary>
    [FhirElement("effectiveinstantUnknown", Order = 33)]
    [Cardinality(0, 1)]
    [ChoiceType("effectiveinstant", "unknown")]
    [JsonPropertyName("effectiveinstantUnknown")]
    public FhirInstant? EffectiveInstant { get; set; }

    /// <summary>
    /// The date and time this version of the observation was made available to providers, typically after
    /// the results have been reviewed and verified.
    /// </summary>
    [FhirElement("issued", Order = 34)]
    [Cardinality(0, 1)]
    [JsonPropertyName("issued")]
    public FhirInstant? Issued { get; set; }

    /// <summary>
    /// Who was responsible for asserting the observed value as &quot;true&quot;.
    /// </summary>
    [FhirElement("performer", Order = 35)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("performer")]
    public List<Reference<Practitioner>>? Performer { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as Quantity)
    /// </summary>
    [FhirElement("valueQuantity", Order = 36)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "quantity")]
    [JsonPropertyName("valueQuantity")]
    public Quantity ValueQuantity { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as CodeableConcept)
    /// </summary>
    [FhirElement("valueCodeableConcept", Order = 37)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "codeableConcept")]
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept ValueCodeableConcept { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as string)
    /// </summary>
    [FhirElement("valueString", Order = 38)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "string")]
    [JsonPropertyName("valueString")]
    public FhirString? ValueString { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as boolean)
    /// </summary>
    [FhirElement("valueBoolean", Order = 39)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "boolean")]
    [JsonPropertyName("valueBoolean")]
    public FhirBoolean? ValueBoolean { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as integer)
    /// </summary>
    [FhirElement("valueInteger", Order = 40)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "integer")]
    [JsonPropertyName("valueInteger")]
    public FhirInteger? ValueInteger { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as Range)
    /// </summary>
    [FhirElement("valueRange", Order = 41)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "range")]
    [JsonPropertyName("valueRange")]
    public Range ValueRange { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as Ratio)
    /// </summary>
    [FhirElement("valueRatio", Order = 42)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "ratio")]
    [JsonPropertyName("valueRatio")]
    public Ratio ValueRatio { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as SampledData)
    /// </summary>
    [FhirElement("valuesampleddataUnknown", Order = 43)]
    [Cardinality(0, 1)]
    [ChoiceType("valuesampleddata", "unknown")]
    [JsonPropertyName("valuesampleddataUnknown")]
    public SampledData ValueSampledData { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as time)
    /// </summary>
    [FhirElement("valuetimeUnknown", Order = 44)]
    [Cardinality(0, 1)]
    [ChoiceType("valuetime", "unknown")]
    [JsonPropertyName("valuetimeUnknown")]
    public FhirTime? ValueTime { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as dateTime)
    /// </summary>
    [FhirElement("valueDateTime", Order = 45)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "dateTime")]
    [JsonPropertyName("valueDateTime")]
    public FhirDateTime? ValueDateTime { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as Period)
    /// </summary>
    [FhirElement("valuePeriod", Order = 46)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "period")]
    [JsonPropertyName("valuePeriod")]
    public Period ValuePeriod { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as Attachment)
    /// </summary>
    [FhirElement("valueAttachment", Order = 47)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "attachment")]
    [JsonPropertyName("valueAttachment")]
    public Attachment ValueAttachment { get; set; }

    /// <summary>
    /// The information determined as a result of making the observation, if the information has a simple
    /// value. (as Reference)
    /// </summary>
    [FhirElement("valueReference", Order = 48)]
    [Cardinality(0, 1)]
    [ChoiceType("value", "reference")]
    [JsonPropertyName("valueReference")]
    public Reference<MolecularSequence> ValueReference { get; set; }

    /// <summary>
    /// Provides a reason why the expected value in the element Observation.value[x] is missing.
    /// </summary>
    [FhirElement("dataAbsentReason", Order = 49)]
    [Cardinality(0, 1)]
    [JsonPropertyName("dataAbsentReason")]
    public CodeableConcept DataAbsentReason { get; set; }

    /// <summary>
    /// A categorical assessment of an observation value. For example, high, low, normal.
    /// </summary>
    [FhirElement("interpretation", Order = 50)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("interpretation")]
    public List<CodeableConcept>? Interpretation { get; set; }

    /// <summary>
    /// Comments about the observation or the results.
    /// </summary>
    [FhirElement("note", Order = 51)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }

    /// <summary>
    /// Indicates the site on the subject&apos;s body where the observation was made (i.e. the target site).
    /// </summary>
    [FhirElement("bodySite", Order = 52)]
    [Cardinality(0, 1)]
    [JsonPropertyName("bodySite")]
    public CodeableConcept BodySite { get; set; }

    /// <summary>
    /// Indicates the body structure on the subject&apos;s body where the observation was made (i.e. the
    /// target site).
    /// </summary>
    [FhirElement("bodyStructure", Order = 53)]
    [Cardinality(0, 1)]
    [JsonPropertyName("bodyStructure")]
    public Reference<BodyStructure> BodyStructure { get; set; }

    /// <summary>
    /// Indicates the mechanism used to perform the observation.
    /// </summary>
    [FhirElement("method", Order = 54)]
    [Cardinality(0, 1)]
    [JsonPropertyName("method")]
    public CodeableConcept Method { get; set; }

    /// <summary>
    /// The specimen that was used when this observation was made.
    /// </summary>
    [FhirElement("specimen", Order = 55)]
    [Cardinality(0, 1)]
    [JsonPropertyName("specimen")]
    public Reference<Specimen> Specimen { get; set; }

    /// <summary>
    /// A reference to the device that generates the measurements or the device settings for the device.
    /// </summary>
    [FhirElement("device", Order = 56)]
    [Cardinality(0, 1)]
    [JsonPropertyName("device")]
    public Reference<Device> Device { get; set; }

    /// <summary>
    /// Guidance on how to interpret the value by comparison to a normal or recommended range. Multiple
    /// reference ranges are interpreted as an &quot;OR&quot;. In other words, to represent two distinct
    /// target populations, two `referenceRange` elements would be used.
    /// </summary>
    [FhirElement("referenceRange", Order = 57)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("referenceRange")]
    public List<BackboneElement>? ReferenceRange { get; set; }

    /// <summary>
    /// This observation is a group observation (e.g. a battery, a panel of tests, a set of vital sign
    /// measurements) that includes the target as a member of the group.
    /// </summary>
    [FhirElement("hasMember", Order = 58)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("hasMember")]
    public List<Reference<Observation>>? HasMember { get; set; }

    /// <summary>
    /// The target resource that represents a measurement from which this observation value is derived. For
    /// example, a calculated anion gap or a fetal measurement based on an ultrasound image.
    /// </summary>
    [FhirElement("derivedFrom", Order = 59)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("derivedFrom")]
    public List<Reference<DocumentReference>>? DerivedFrom { get; set; }

    /// <summary>
    /// Some observations have multiple component observations. These component observations are expressed
    /// as separate code value pairs that share the same attributes. Examples include systolic and diastolic
    /// component observations for blood pressure measurement and multiple component observations for
    /// genetics observations.
    /// </summary>
    [FhirElement("component", Order = 60)]
    [Cardinality(0, int.MaxValue)]
    [JsonPropertyName("component")]
    public List<BackboneElement>? Component { get; set; }

    /// <summary>
    /// Validates choice type constraints
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Choice Type validation for instantiatescanonical[x]
        var instantiatescanonicalProperties = new[] { nameof(InstantiatesCanonical) };
        var instantiatescanonicalSetCount = instantiatescanonicalProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (instantiatescanonicalSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of InstantiatesCanonical may be specified",
                new[] { nameof(InstantiatesCanonical) });
        }

        // Choice Type validation for instantiates[x]
        var instantiatesProperties = new[] { nameof(InstantiatesReference) };
        var instantiatesSetCount = instantiatesProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (instantiatesSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of InstantiatesReference may be specified",
                new[] { nameof(InstantiatesReference) });
        }

        // Choice Type validation for effective[x]
        var effectiveProperties = new[] { nameof(EffectiveDateTime), nameof(EffectivePeriod), nameof(EffectiveTiming) };
        var effectiveSetCount = effectiveProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (effectiveSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of EffectiveDateTime, EffectivePeriod, EffectiveTiming may be specified",
                new[] { nameof(EffectiveDateTime), nameof(EffectivePeriod), nameof(EffectiveTiming) });
        }

        // Choice Type validation for effectiveinstant[x]
        var effectiveinstantProperties = new[] { nameof(EffectiveInstant) };
        var effectiveinstantSetCount = effectiveinstantProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (effectiveinstantSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of EffectiveInstant may be specified",
                new[] { nameof(EffectiveInstant) });
        }

        // Choice Type validation for value[x]
        var valueProperties = new[] { nameof(ValueQuantity), nameof(ValueCodeableConcept), nameof(ValueString), nameof(ValueBoolean), nameof(ValueInteger), nameof(ValueRange), nameof(ValueRatio), nameof(ValueDateTime), nameof(ValuePeriod), nameof(ValueAttachment), nameof(ValueReference) };
        var valueSetCount = valueProperties.Count(prop => 
            GetType().GetProperty(prop)?.GetValue(this) != null);

        if (valueSetCount > 1)
        {
            yield return new ValidationResult(
                "Only one of ValueQuantity, ValueCodeableConcept, ValueString, ValueBoolean, ValueInteger, ValueRange, ValueRatio, ValueDateTime, ValuePeriod, ValueAttachment, ValueReference may be specified",
                new[] { nameof(ValueQuantity), nameof(ValueCodeableConcept), nameof(ValueString), nameof(ValueBoolean), nameof(ValueInteger), nameof(ValueRange), nameof(ValueRatio), nameof(ValueDateTime), nameof(ValuePeriod), nameof(ValueAttachment), nameof(ValueReference) });
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

    }


    /// <summary>
    /// Validates this instance according to FHIR rules
    /// </summary>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Cardinality validation
        // Validate Observation cardinality
        var observationCount = Observation?.Count ?? 0;
        if (observationCount < 0)
        {
            yield return new ValidationResult("Element 'Observation' cardinality must be 0..*", new[] { nameof(Observation) });
        }
        // Validate Contained cardinality
        var containedCount = Contained?.Count ?? 0;
        if (containedCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.contained' cardinality must be 0..*", new[] { nameof(Contained) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate Identifier cardinality
        var identifierCount = Identifier?.Count ?? 0;
        if (identifierCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.identifier' cardinality must be 0..*", new[] { nameof(Identifier) });
        }
        // Validate BasedOn cardinality
        var basedonCount = BasedOn?.Count ?? 0;
        if (basedonCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.basedOn' cardinality must be 0..*", new[] { nameof(BasedOn) });
        }
        // Validate TriggeredBy cardinality
        var triggeredbyCount = TriggeredBy?.Count ?? 0;
        if (triggeredbyCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.triggeredBy' cardinality must be 0..*", new[] { nameof(TriggeredBy) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.triggeredBy.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.triggeredBy.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Observation == null)
        {
            yield return new ValidationResult("Element 'Observation.triggeredBy.observation' cardinality must be 1..1", new[] { nameof(Observation) });
        }
        if (Type == null)
        {
            yield return new ValidationResult("Element 'Observation.triggeredBy.type' cardinality must be 1..1", new[] { nameof(Type) });
        }
        // Validate PartOf cardinality
        var partofCount = PartOf?.Count ?? 0;
        if (partofCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.partOf' cardinality must be 0..*", new[] { nameof(PartOf) });
        }
        if (Status == null)
        {
            yield return new ValidationResult("Element 'Observation.status' cardinality must be 1..1", new[] { nameof(Status) });
        }
        // Validate Category cardinality
        var categoryCount = Category?.Count ?? 0;
        if (categoryCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.category' cardinality must be 0..*", new[] { nameof(Category) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'Observation.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Focus cardinality
        var focusCount = Focus?.Count ?? 0;
        if (focusCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.focus' cardinality must be 0..*", new[] { nameof(Focus) });
        }
        // Validate Performer cardinality
        var performerCount = Performer?.Count ?? 0;
        if (performerCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.performer' cardinality must be 0..*", new[] { nameof(Performer) });
        }
        // Validate Interpretation cardinality
        var interpretationCount = Interpretation?.Count ?? 0;
        if (interpretationCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.interpretation' cardinality must be 0..*", new[] { nameof(Interpretation) });
        }
        // Validate Note cardinality
        var noteCount = Note?.Count ?? 0;
        if (noteCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.note' cardinality must be 0..*", new[] { nameof(Note) });
        }
        // Validate ReferenceRange cardinality
        var referencerangeCount = ReferenceRange?.Count ?? 0;
        if (referencerangeCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.referenceRange' cardinality must be 0..*", new[] { nameof(ReferenceRange) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.referenceRange.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.referenceRange.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        // Validate AppliesTo cardinality
        var appliestoCount = AppliesTo?.Count ?? 0;
        if (appliestoCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.referenceRange.appliesTo' cardinality must be 0..*", new[] { nameof(AppliesTo) });
        }
        // Validate HasMember cardinality
        var hasmemberCount = HasMember?.Count ?? 0;
        if (hasmemberCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.hasMember' cardinality must be 0..*", new[] { nameof(HasMember) });
        }
        // Validate DerivedFrom cardinality
        var derivedfromCount = DerivedFrom?.Count ?? 0;
        if (derivedfromCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.derivedFrom' cardinality must be 0..*", new[] { nameof(DerivedFrom) });
        }
        // Validate Component cardinality
        var componentCount = Component?.Count ?? 0;
        if (componentCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.component' cardinality must be 0..*", new[] { nameof(Component) });
        }
        // Validate Extension cardinality
        var extensionCount = Extension?.Count ?? 0;
        if (extensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.component.extension' cardinality must be 0..*", new[] { nameof(Extension) });
        }
        // Validate ModifierExtension cardinality
        var modifierextensionCount = ModifierExtension?.Count ?? 0;
        if (modifierextensionCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.component.modifierExtension' cardinality must be 0..*", new[] { nameof(ModifierExtension) });
        }
        if (Code == null)
        {
            yield return new ValidationResult("Element 'Observation.component.code' cardinality must be 1..1", new[] { nameof(Code) });
        }
        // Validate Interpretation cardinality
        var interpretationCount = Interpretation?.Count ?? 0;
        if (interpretationCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.component.interpretation' cardinality must be 0..*", new[] { nameof(Interpretation) });
        }
        // Validate ReferenceRange cardinality
        var referencerangeCount = ReferenceRange?.Count ?? 0;
        if (referencerangeCount < 0)
        {
            yield return new ValidationResult("Element 'Observation.component.referenceRange' cardinality must be 0..*", new[] { nameof(ReferenceRange) });
        }

        // ValueSet binding validation
        // Validate Language ValueSet binding
        if (Language != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/all-languages|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Type ValueSet binding
        if (Type != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/observation-triggeredbytype|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Status ValueSet binding
        if (Status != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/observation-status|5.0.0
            // This requires a terminology service or local ValueSet cache
        }
        // Validate DataAbsentReason ValueSet binding
        if (DataAbsentReason != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/data-absent-reason
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Interpretation ValueSet binding
        if (Interpretation != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/observation-interpretation
            // This requires a terminology service or local ValueSet cache
        }
        // Validate NormalValue ValueSet binding
        if (NormalValue != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/observation-referencerange-normalvalue
            // This requires a terminology service or local ValueSet cache
        }
        // Validate DataAbsentReason ValueSet binding
        if (DataAbsentReason != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/data-absent-reason
            // This requires a terminology service or local ValueSet cache
        }
        // Validate Interpretation ValueSet binding
        if (Interpretation != null)
        {
            // TODO: Implement ValueSet validation for http://hl7.org/fhir/ValueSet/observation-interpretation
            // This requires a terminology service or local ValueSet cache
        }

        // Constraint validation
        // Constraint: dom-2
        // Expression: contained.contained.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.contained.empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL NOT contain nested Resources", new[] { nameof(Observation) });
        // }
        // Constraint: dom-3
        // Expression: contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.where((('#'+id in (%resource.descendants().reference | %resource.descendants().ofType(canonical) | %resource.descendants().ofType(uri) | %resource.descendants().ofType(url))) or descendants().where(reference = '#').exists() or descendants().where(ofType(canonical) = '#').exists() or descendants().where(ofType(canonical) = '#').exists()).not()).trace('unmatched', id).empty()"))
        // {
        //     yield return new ValidationResult("If the resource is contained in another resource, it SHALL be referred to from elsewhere in the resource or SHALL refer to the containing resource", new[] { nameof(Observation) });
        // }
        // Constraint: dom-4
        // Expression: contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.versionId.empty() and contained.meta.lastUpdated.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a meta.versionId or a meta.lastUpdated", new[] { nameof(Observation) });
        // }
        // Constraint: dom-5
        // Expression: contained.meta.security.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("contained.meta.security.empty()"))
        // {
        //     yield return new ValidationResult("If a resource is contained in another resource, it SHALL NOT have a security label", new[] { nameof(Observation) });
        // }
        // Constraint: dom-6
        // Expression: text.`div`.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("text.`div`.exists()"))
        // {
        //     yield return new ValidationResult("A resource should have narrative for robust management", new[] { nameof(Observation) });
        // }
        // Constraint: obs-6
        // Expression: dataAbsentReason.empty() or value.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("dataAbsentReason.empty() or value.empty()"))
        // {
        //     yield return new ValidationResult("dataAbsentReason SHALL only be present if Observation.value[x] is not present", new[] { nameof(Observation) });
        // }
        // Constraint: obs-7
        // Expression: value.empty() or component.code.where(coding.intersect(%resource.code.coding).exists()).empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("value.empty() or component.code.where(coding.intersect(%resource.code.coding).exists()).empty()"))
        // {
        //     yield return new ValidationResult("If Observation.component.code is the same as Observation.code, then Observation.value SHALL NOT be present (the Observation.component.value[x] holds the value).", new[] { nameof(Observation) });
        // }
        // Constraint: obs-8
        // Expression: bodySite.exists() implies bodyStructure.empty()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("bodySite.exists() implies bodyStructure.empty()"))
        // {
        //     yield return new ValidationResult("bodyStructure SHALL only be present if Observation.bodySite is not present", new[] { nameof(Observation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Meta) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ImplicitRules) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Language) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Text) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Identifier) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Instantiates) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BasedOn) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(TriggeredBy) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Observation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Reason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(PartOf) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Status) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Category) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Subject) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Focus) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Encounter) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Effective) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Issued) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Performer) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DataAbsentReason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Interpretation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Note) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BodySite) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(BodyStructure) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Method) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Specimen) });
        // }
        // Constraint: obs-9
        // Expression: (reference.resolve().exists() and reference.resolve() is Group) implies reference.resolve().member.entity.resolve().all($this is Specimen)
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("(reference.resolve().exists() and reference.resolve() is Group) implies reference.resolve().member.entity.resolve().all($this is Specimen)"))
        // {
        //     yield return new ValidationResult("If Observation.specimen is a reference to Group, the group can only have specimens", new[] { nameof(Specimen) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Device) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ReferenceRange) });
        // }
        // Constraint: obs-3
        // Expression: low.exists() or high.exists() or text.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("low.exists() or high.exists() or text.exists()"))
        // {
        //     yield return new ValidationResult("Must have at least a low or a high or text", new[] { nameof(ReferenceRange) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Low) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(High) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(NormalValue) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Type) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(AppliesTo) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Age) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Text) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(HasMember) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DerivedFrom) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Component) });
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
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ext-1
        // Expression: extension.exists() != value.exists()
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("extension.exists() != value.exists()"))
        // {
        //     yield return new ValidationResult("Must have either extensions or value[x], not both", new[] { nameof(ModifierExtension) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Code) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Value) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(DataAbsentReason) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(Interpretation) });
        // }
        // Constraint: ele-1
        // Expression: hasValue() or (children().count() > id.count())
        // TODO: Implement FHIRPath expression evaluation
        // if (!EvaluateFHIRPath("hasValue() or (children().count() > id.count())"))
        // {
        //     yield return new ValidationResult("All FHIR elements must have a @value or children", new[] { nameof(ReferenceRange) });
        // }
    }

}
