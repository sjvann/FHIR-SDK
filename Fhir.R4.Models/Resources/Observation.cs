using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Measurements and simple assertions made about a patient, device or other subject.
/// </summary>
/// <remarks>
/// FHIR R4 Observation DomainResource
/// Measurements and simple assertions made about a patient, device or other subject.
/// </remarks>
public class Observation : DomainResource
{
    /// <summary>
    /// A unique identifier assigned to this observation.
    /// FHIR Path: Observation.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    /// <summary>
    /// A plan, proposal or order that is fulfilled in whole or in part by this event.
    /// FHIR Path: Observation.basedOn
    /// Cardinality: 0..*
    /// Reference to: CarePlan, DeviceRequest, ImmunizationRecommendation, MedicationRequest, NutritionOrder, ServiceRequest
    /// </summary>
    [JsonPropertyName("basedOn")]
    public List<Reference<CarePlan, DeviceRequest, ImmunizationRecommendation>>? BasedOn { get; set; }
    
    /// <summary>
    /// A larger event of which this particular Observation is a component or step.
    /// FHIR Path: Observation.partOf
    /// Cardinality: 0..*
    /// Reference to: MedicationAdministration, MedicationDispense, MedicationStatement, Procedure, Immunization, ImagingStudy
    /// </summary>
    [JsonPropertyName("partOf")]
    public List<Reference<MedicationAdministration, MedicationDispense, MedicationStatement>>? PartOf { get; set; }
    
    /// <summary>
    /// The status of the result value.
    /// FHIR Path: Observation.status
    /// Cardinality: 1..1
    /// Required: Yes
    /// Allowed values: registered, preliminary, final, amended, corrected, cancelled, entered-in-error, unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
    
    /// <summary>
    /// A code that classifies the general type of observation being made.
    /// FHIR Path: Observation.category
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("category")]
    public List<CodeableConcept>? Category { get; set; }
    
    /// <summary>
    /// Describes what was observed. Sometimes this is called the observation "name".
    /// FHIR Path: Observation.code
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; } = new CodeableConcept();
    
    /// <summary>
    /// The patient, or group of patients, location, or device this observation is about.
    /// FHIR Path: Observation.subject
    /// Cardinality: 0..1
    /// Reference to: Patient, Group, Device, Location
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference<Patient, Group, Device, Location>? Subject { get; set; }
    
    /// <summary>
    /// The healthcare event during which this observation is made.
    /// FHIR Path: Observation.encounter
    /// Cardinality: 0..1
    /// Reference to: Encounter
    /// </summary>
    [JsonPropertyName("encounter")]
    public Reference<Encounter>? Encounter { get; set; }
    
    /// <summary>
    /// The time or time-period the observed value is asserted as being true.
    /// 
    /// Choice Type: effective[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - dateTime
    ///   - Period
    ///   - Timing
    ///   - instant
    /// </summary>
    [JsonIgnore]
    public ChoiceType<FhirDateTime, Period, Timing, FhirInstant>? EffectiveChoice { get; set; }
    
    // JSON 序列化屬性 for effective[x]
    [JsonPropertyName("effectiveDateTime")]
    public string? EffectiveDateTime 
    { 
        get => EffectiveChoice?.AsT1()?.Value;
        set => EffectiveChoice = value != null ? new FhirDateTime(value) : null;
    }
    
    [JsonPropertyName("effectivePeriod")]
    public Period? EffectivePeriod 
    { 
        get => EffectiveChoice?.AsT2();
        set => EffectiveChoice = value;
    }
    
    [JsonPropertyName("effectiveTiming")]
    public Timing? EffectiveTiming 
    { 
        get => EffectiveChoice?.AsT3();
        set => EffectiveChoice = value;
    }
    
    [JsonPropertyName("effectiveInstant")]
    public string? EffectiveInstant 
    { 
        get => EffectiveChoice?.AsT4()?.Value;
        set => EffectiveChoice = value != null ? new FhirInstant(value) : null;
    }
    
    /// <summary>
    /// The date and time this version of the observation was made available to providers.
    /// FHIR Path: Observation.issued
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("issued")]
    public string? Issued { get; set; }
    
    /// <summary>
    /// Who was responsible for asserting the observed value as "true".
    /// FHIR Path: Observation.performer
    /// Cardinality: 0..*
    /// Reference to: Practitioner, PractitionerRole, Organization, CareTeam, Patient, RelatedPerson
    /// </summary>
    [JsonPropertyName("performer")]
    public List<Reference<Practitioner, PractitionerRole, Organization>>? Performer { get; set; }
    
    /// <summary>
    /// The information determined as a result of making the observation.
    /// 
    /// Choice Type: value[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - Quantity
    ///   - CodeableConcept
    ///   - string
    ///   - boolean
    ///   - integer
    ///   - Range
    ///   - Ratio
    ///   - SampledData
    ///   - time
    ///   - dateTime
    ///   - Period
    /// </summary>
    [JsonIgnore]
    public ChoiceType<Quantity, CodeableConcept, FhirString, FhirBoolean>? ValueChoice { get; set; }
    
    // JSON 序列化屬性 for value[x] - 只實作常用的型別
    [JsonPropertyName("valueQuantity")]
    public Quantity? ValueQuantity 
    { 
        get => ValueChoice?.AsT1();
        set => ValueChoice = value;
    }
    
    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept? ValueCodeableConcept 
    { 
        get => ValueChoice?.AsT2();
        set => ValueChoice = value;
    }
    
    [JsonPropertyName("valueString")]
    public string? ValueString 
    { 
        get => ValueChoice?.AsT3()?.Value;
        set => ValueChoice = value != null ? new FhirString(value) : null;
    }
    
    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean 
    { 
        get => ValueChoice?.AsT4()?.Value;
        set => ValueChoice = value != null ? new FhirBoolean(value) : null;
    }
    
    /// <summary>
    /// Provides a reason why the expected value in the element Observation.value[x] is missing.
    /// FHIR Path: Observation.dataAbsentReason
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("dataAbsentReason")]
    public CodeableConcept? DataAbsentReason { get; set; }
    
    /// <summary>
    /// A categorical assessment of an observation value.
    /// FHIR Path: Observation.interpretation
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("interpretation")]
    public List<CodeableConcept>? Interpretation { get; set; }
    
    /// <summary>
    /// Comments about the observation or the results.
    /// FHIR Path: Observation.note
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("note")]
    public List<Annotation>? Note { get; set; }
    
    /// <summary>
    /// Indicates the site on the subject's body where the observation was made.
    /// FHIR Path: Observation.bodySite
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("bodySite")]
    public CodeableConcept? BodySite { get; set; }
    
    /// <summary>
    /// Indicates the mechanism used to perform the observation.
    /// FHIR Path: Observation.method
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("method")]
    public CodeableConcept? Method { get; set; }
    
    /// <summary>
    /// The specimen that was used when this observation was made.
    /// FHIR Path: Observation.specimen
    /// Cardinality: 0..1
    /// Reference to: Specimen
    /// </summary>
    [JsonPropertyName("specimen")]
    public Reference<Specimen>? Specimen { get; set; }
    
    /// <summary>
    /// The device used to generate the observation data.
    /// FHIR Path: Observation.device
    /// Cardinality: 0..1
    /// Reference to: Device, DeviceMetric
    /// </summary>
    [JsonPropertyName("device")]
    public Reference<Device, DeviceMetric>? Device { get; set; }
    
    /// <summary>
    /// Guidance on how to interpret the value by comparison to a normal or recommended range.
    /// FHIR Path: Observation.referenceRange
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("referenceRange")]
    public List<ObservationReferenceRange>? ReferenceRange { get; set; }
    
    /// <summary>
    /// This observation is a group observation (e.g. a battery, a panel of tests, a set of vital sign measurements) that includes the target as a member of the group.
    /// FHIR Path: Observation.hasMember
    /// Cardinality: 0..*
    /// Reference to: Observation, QuestionnaireResponse, MolecularSequence
    /// </summary>
    [JsonPropertyName("hasMember")]
    public List<Reference<Observation, QuestionnaireResponse, MolecularSequence>>? HasMember { get; set; }
    
    /// <summary>
    /// The target resource that represents a measurement from which this observation value is derived.
    /// FHIR Path: Observation.derivedFrom
    /// Cardinality: 0..*
    /// Reference to: DocumentReference, ImagingStudy, Media, QuestionnaireResponse, Observation, MolecularSequence
    /// </summary>
    [JsonPropertyName("derivedFrom")]
    public List<Reference<DocumentReference, ImagingStudy, Media>>? DerivedFrom { get; set; }
    
    /// <summary>
    /// Some observations have multiple component observations.
    /// FHIR Path: Observation.component
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("component")]
    public List<ObservationComponent>? Component { get; set; }
    
    /// <summary>
    /// 便利屬性：取得或設定 Observation 的值
    /// 自動處理不同型別的 value[x] 屬性
    /// </summary>
    [JsonIgnore]
    public object? Value
    {
        get => ValueChoice?.Value;
        set 
        {
            if (ValueChoice == null)
                ValueChoice = new ChoiceType<Quantity, CodeableConcept, FhirString, FhirBoolean>();
            ValueChoice.Value = value;
        }
    }
    
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Status 是必要的
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("Observation.status is required");
        }
        else
        {
            var validStatuses = new[] { "registered", "preliminary", "final", "amended", "corrected", "cancelled", "entered-in-error", "unknown" };
            if (!validStatuses.Contains(Status))
            {
                yield return new ValidationResult($"Observation.status '{Status}' is not valid. Must be one of: {string.Join(", ", validStatuses)}");
            }
        }
        
        // Code 是必要的
        if (Code == null)
        {
            yield return new ValidationResult("Observation.code is required");
        }
        else
        {
            var codeValidationContext = new ValidationContext(Code);
            foreach (var result in Code.Validate(codeValidationContext))
                yield return result;
        }
        
        // 驗證 Choice Types
        if (EffectiveChoice != null)
        {
            var effectiveValidationContext = new ValidationContext(EffectiveChoice);
            foreach (var result in EffectiveChoice.Validate(effectiveValidationContext))
                yield return result;
        }
        
        if (ValueChoice != null)
        {
            var valueValidationContext = new ValidationContext(ValueChoice);
            foreach (var result in ValueChoice.Validate(valueValidationContext))
                yield return result;
        }
        
        // 驗證其他子組件（簡化版本）
        if (Identifier != null)
        {
            foreach (var identifier in Identifier)
            {
                var identifierValidationContext = new ValidationContext(identifier);
                foreach (var result in identifier.Validate(identifierValidationContext))
                    yield return result;
            }
        }
        
        if (Category != null)
        {
            foreach (var category in Category)
            {
                var categoryValidationContext = new ValidationContext(category);
                foreach (var result in category.Validate(categoryValidationContext))
                    yield return result;
            }
        }
        
        // 其他驗證會在完整實作中添加
    }
}

/// <summary>
/// Guidance on how to interpret the value by comparison to a normal or recommended range.
///
/// BackboneElement for Observation.ReferenceRange
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class ObservationReferenceRange : BackboneElement
{
    /// <summary>
    /// Low Range, if relevant.
    /// FHIR Path: Observation.referenceRange.low
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("low")]
    public Quantity? Low { get; set; }

    /// <summary>
    /// High Range, if relevant.
    /// FHIR Path: Observation.referenceRange.high
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("high")]
    public Quantity? High { get; set; }

    /// <summary>
    /// Indicates the meaning/use of this range of this range.
    /// FHIR Path: Observation.referenceRange.type
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("type")]
    public CodeableConcept? Type { get; set; }

    /// <summary>
    /// Applicable population for the range.
    /// FHIR Path: Observation.referenceRange.appliesTo
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("appliesTo")]
    public List<CodeableConcept>? AppliesTo { get; set; }

    /// <summary>
    /// Applicable age range, if relevant.
    /// FHIR Path: Observation.referenceRange.age
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("age")]
    public DataTypes.Range? Age { get; set; }

    /// <summary>
    /// Text based reference range in an observation.
    /// FHIR Path: Observation.referenceRange.text
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證子組件
        if (Low != null)
        {
            var lowValidationContext = new ValidationContext(Low);
            foreach (var result in Low.Validate(lowValidationContext))
                yield return result;
        }

        if (High != null)
        {
            var highValidationContext = new ValidationContext(High);
            foreach (var result in High.Validate(highValidationContext))
                yield return result;
        }

        if (Type != null)
        {
            var typeValidationContext = new ValidationContext(Type);
            foreach (var result in Type.Validate(typeValidationContext))
                yield return result;
        }

        if (AppliesTo != null)
        {
            foreach (var appliesTo in AppliesTo)
            {
                var appliesToValidationContext = new ValidationContext(appliesTo);
                foreach (var result in appliesTo.Validate(appliesToValidationContext))
                    yield return result;
            }
        }

        if (Age != null)
        {
            var ageValidationContext = new ValidationContext(Age);
            foreach (var result in Age.Validate(ageValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// Some observations have multiple component observations.
///
/// BackboneElement for Observation.Component
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class ObservationComponent : BackboneElement
{
    /// <summary>
    /// Describes what was observed. Sometimes this is called the observation "code".
    /// FHIR Path: Observation.component.code
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("code")]
    public CodeableConcept Code { get; set; } = new CodeableConcept();

    /// <summary>
    /// The information determined as a result of making the observation.
    ///
    /// Choice Type: value[x]
    /// This is a choice element - only one of the following types may be present:
    ///   - Quantity
    ///   - CodeableConcept
    ///   - string
    ///   - boolean
    ///   - integer
    ///   - Range
    ///   - Ratio
    ///   - SampledData
    ///   - time
    ///   - dateTime
    ///   - Period
    /// </summary>
    [JsonIgnore]
    public ChoiceType<Quantity, CodeableConcept, FhirString, FhirBoolean>? ValueChoice { get; set; }

    // JSON 序列化屬性 for value[x]
    [JsonPropertyName("valueQuantity")]
    public Quantity? ValueQuantity
    {
        get => ValueChoice?.AsT1();
        set => ValueChoice = value;
    }

    [JsonPropertyName("valueCodeableConcept")]
    public CodeableConcept? ValueCodeableConcept
    {
        get => ValueChoice?.AsT2();
        set => ValueChoice = value;
    }

    [JsonPropertyName("valueString")]
    public string? ValueString
    {
        get => ValueChoice?.AsT3()?.Value;
        set => ValueChoice = value != null ? new FhirString(value) : null;
    }

    [JsonPropertyName("valueBoolean")]
    public bool? ValueBoolean
    {
        get => ValueChoice?.AsT4()?.Value;
        set => ValueChoice = value != null ? new FhirBoolean(value) : null;
    }

    /// <summary>
    /// Provides a reason why the expected value in the element Observation.component.value[x] is missing.
    /// FHIR Path: Observation.component.dataAbsentReason
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("dataAbsentReason")]
    public CodeableConcept? DataAbsentReason { get; set; }

    /// <summary>
    /// A categorical assessment of an observation value.
    /// FHIR Path: Observation.component.interpretation
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("interpretation")]
    public List<CodeableConcept>? Interpretation { get; set; }

    /// <summary>
    /// Guidance on how to interpret the value by comparison to a normal or recommended range.
    /// FHIR Path: Observation.component.referenceRange
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("referenceRange")]
    public List<ObservationReferenceRange>? ReferenceRange { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Code 是必要的
        if (Code == null)
        {
            yield return new ValidationResult("Observation.component.code is required");
        }
        else
        {
            var codeValidationContext = new ValidationContext(Code);
            foreach (var result in Code.Validate(codeValidationContext))
                yield return result;
        }

        // 驗證 Choice Type
        if (ValueChoice != null)
        {
            var valueValidationContext = new ValidationContext(ValueChoice);
            foreach (var result in ValueChoice.Validate(valueValidationContext))
                yield return result;
        }

        // 驗證其他子組件
        if (DataAbsentReason != null)
        {
            var dataAbsentReasonValidationContext = new ValidationContext(DataAbsentReason);
            foreach (var result in DataAbsentReason.Validate(dataAbsentReasonValidationContext))
                yield return result;
        }

        if (Interpretation != null)
        {
            foreach (var interpretation in Interpretation)
            {
                var interpretationValidationContext = new ValidationContext(interpretation);
                foreach (var result in interpretation.Validate(interpretationValidationContext))
                    yield return result;
            }
        }

        if (ReferenceRange != null)
        {
            foreach (var referenceRange in ReferenceRange)
            {
                var referenceRangeValidationContext = new ValidationContext(referenceRange);
                foreach (var result in referenceRange.Validate(referenceRangeValidationContext))
                    yield return result;
            }
        }
    }
}
