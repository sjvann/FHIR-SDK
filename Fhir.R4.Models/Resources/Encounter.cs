using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient.
/// </summary>
/// <remarks>
/// FHIR R4 Encounter DomainResource
/// An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s).
/// </remarks>
public class Encounter : DomainResource
{
    /// <summary>
    /// Identifier(s) by which this encounter is known.
    /// FHIR Path: Encounter.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    /// <summary>
    /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +.
    /// FHIR Path: Encounter.status
    /// Cardinality: 1..1
    /// Required: Yes
    /// Allowed values: planned, arrived, triaged, in-progress, onleave, finished, cancelled, entered-in-error, unknown
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;
    
    /// <summary>
    /// List of past encounter statuses.
    /// FHIR Path: Encounter.statusHistory
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("statusHistory")]
    public List<EncounterStatusHistory>? StatusHistory { get; set; }
    
    /// <summary>
    /// Concepts representing classification of patient encounter such as ambulatory (outpatient), inpatient, emergency, home health or others due to local variations.
    /// FHIR Path: Encounter.class
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("class")]
    public Coding Class { get; set; } = new Coding();
    
    /// <summary>
    /// List of past encounter classes.
    /// FHIR Path: Encounter.classHistory
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("classHistory")]
    public List<EncounterClassHistory>? ClassHistory { get; set; }
    
    /// <summary>
    /// Specific type of encounter (e.g. e-mail consultation, surgical day-care, skilled nursing, rehabilitation).
    /// FHIR Path: Encounter.type
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("type")]
    public List<CodeableConcept>? Type { get; set; }
    
    /// <summary>
    /// Broad categorization of the service that is to be provided (e.g. cardiology).
    /// FHIR Path: Encounter.serviceType
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("serviceType")]
    public CodeableConcept? ServiceType { get; set; }
    
    /// <summary>
    /// Indicates the urgency of the encounter.
    /// FHIR Path: Encounter.priority
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("priority")]
    public CodeableConcept? Priority { get; set; }
    
    /// <summary>
    /// The patient or group present at the encounter.
    /// FHIR Path: Encounter.subject
    /// Cardinality: 0..1
    /// Reference to: Patient, Group
    /// </summary>
    [JsonPropertyName("subject")]
    public Reference<Patient, Group>? Subject { get; set; }
    
    /// <summary>
    /// Where a specific encounter should be classified as a part of a specific episode(s) of care this field should be used.
    /// FHIR Path: Encounter.episodeOfCare
    /// Cardinality: 0..*
    /// Reference to: EpisodeOfCare
    /// </summary>
    [JsonPropertyName("episodeOfCare")]
    public List<Reference<EpisodeOfCare>>? EpisodeOfCare { get; set; }
    
    /// <summary>
    /// The request this encounter satisfies (e.g. incoming referral or procedure request).
    /// FHIR Path: Encounter.basedOn
    /// Cardinality: 0..*
    /// Reference to: ServiceRequest
    /// </summary>
    [JsonPropertyName("basedOn")]
    public List<Reference<ServiceRequest>>? BasedOn { get; set; }
    
    /// <summary>
    /// The list of people responsible for providing the service.
    /// FHIR Path: Encounter.participant
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("participant")]
    public List<EncounterParticipant>? Participant { get; set; }
    
    /// <summary>
    /// The appointment that scheduled this encounter.
    /// FHIR Path: Encounter.appointment
    /// Cardinality: 0..*
    /// Reference to: Appointment
    /// </summary>
    [JsonPropertyName("appointment")]
    public List<Reference<Appointment>>? Appointment { get; set; }
    
    /// <summary>
    /// The start and end time of the encounter.
    /// FHIR Path: Encounter.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }
    
    /// <summary>
    /// Quantity of time the encounter lasted.
    /// FHIR Path: Encounter.length
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("length")]
    public Duration? Length { get; set; }
    
    /// <summary>
    /// Reason the encounter takes place, expressed as a code.
    /// FHIR Path: Encounter.reasonCode
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("reasonCode")]
    public List<CodeableConcept>? ReasonCode { get; set; }
    
    /// <summary>
    /// Reason the encounter takes place, expressed as a reference.
    /// FHIR Path: Encounter.reasonReference
    /// Cardinality: 0..*
    /// Reference to: Condition, Procedure, Observation, ImmunizationRecommendation
    /// </summary>
    [JsonPropertyName("reasonReference")]
    public List<Reference<Condition, Procedure, Observation>>? ReasonReference { get; set; }
    
    /// <summary>
    /// The list of diagnosis relevant to this encounter.
    /// FHIR Path: Encounter.diagnosis
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("diagnosis")]
    public List<EncounterDiagnosis>? Diagnosis { get; set; }
    
    /// <summary>
    /// The set of accounts that may be used for billing for this Encounter.
    /// FHIR Path: Encounter.account
    /// Cardinality: 0..*
    /// Reference to: Account
    /// </summary>
    [JsonPropertyName("account")]
    public List<Reference<Account>>? Account { get; set; }
    
    /// <summary>
    /// Details about the admission to a healthcare service.
    /// FHIR Path: Encounter.hospitalization
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("hospitalization")]
    public EncounterHospitalization? Hospitalization { get; set; }
    
    /// <summary>
    /// List of locations where the patient has been during this encounter.
    /// FHIR Path: Encounter.location
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("location")]
    public List<EncounterLocation>? Location { get; set; }
    
    /// <summary>
    /// The organization that is primarily responsible for this Encounter's services.
    /// FHIR Path: Encounter.serviceProvider
    /// Cardinality: 0..1
    /// Reference to: Organization
    /// </summary>
    [JsonPropertyName("serviceProvider")]
    public Reference<Organization>? ServiceProvider { get; set; }
    
    /// <summary>
    /// Another Encounter of which this encounter is a part of (administratively or in time).
    /// FHIR Path: Encounter.partOf
    /// Cardinality: 0..1
    /// Reference to: Encounter
    /// </summary>
    [JsonPropertyName("partOf")]
    public Reference<Encounter>? PartOf { get; set; }
    
    /// <summary>
    /// Validates the Encounter according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // Status 是必要的
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("Encounter.status is required");
        }
        else
        {
            var validStatuses = new[] { "planned", "arrived", "triaged", "in-progress", "onleave", "finished", "cancelled", "entered-in-error", "unknown" };
            if (!validStatuses.Contains(Status))
            {
                yield return new ValidationResult($"Encounter.status '{Status}' is not valid. Must be one of: {string.Join(", ", validStatuses)}");
            }
        }
        
        // Class 是必要的
        if (Class == null)
        {
            yield return new ValidationResult("Encounter.class is required");
        }
        else
        {
            var classValidationContext = new ValidationContext(Class);
            foreach (var result in Class.Validate(classValidationContext))
                yield return result;
        }
        
        // 驗證子組件
        if (Identifier != null)
        {
            foreach (var identifier in Identifier)
            {
                var identifierValidationContext = new ValidationContext(identifier);
                foreach (var result in identifier.Validate(identifierValidationContext))
                    yield return result;
            }
        }
        
        if (StatusHistory != null)
        {
            foreach (var statusHistory in StatusHistory)
            {
                var statusHistoryValidationContext = new ValidationContext(statusHistory);
                foreach (var result in statusHistory.Validate(statusHistoryValidationContext))
                    yield return result;
            }
        }
        
        if (ClassHistory != null)
        {
            foreach (var classHistory in ClassHistory)
            {
                var classHistoryValidationContext = new ValidationContext(classHistory);
                foreach (var result in classHistory.Validate(classHistoryValidationContext))
                    yield return result;
            }
        }
        
        if (Type != null)
        {
            foreach (var type in Type)
            {
                var typeValidationContext = new ValidationContext(type);
                foreach (var result in type.Validate(typeValidationContext))
                    yield return result;
            }
        }
        
        // 其他子組件驗證會在完整實作中添加
    }
}

/// <summary>
/// List of past encounter statuses.
///
/// BackboneElement for Encounter.StatusHistory
/// </summary>
public class EncounterStatusHistory : BackboneElement
{
    /// <summary>
    /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +.
    /// FHIR Path: Encounter.statusHistory.status
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    /// <summary>
    /// The time that the episode was in the specified status.
    /// FHIR Path: Encounter.statusHistory.period
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("period")]
    public Period Period { get; set; } = new Period();

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Status 是必要的
        if (string.IsNullOrEmpty(Status))
        {
            yield return new ValidationResult("Encounter.statusHistory.status is required");
        }

        // Period 是必要的
        if (Period == null)
        {
            yield return new ValidationResult("Encounter.statusHistory.period is required");
        }
        else
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// List of past encounter classes.
///
/// BackboneElement for Encounter.ClassHistory
/// </summary>
public class EncounterClassHistory : BackboneElement
{
    /// <summary>
    /// inpatient | outpatient | ambulatory | emergency +.
    /// FHIR Path: Encounter.classHistory.class
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("class")]
    public Coding Class { get; set; } = new Coding();

    /// <summary>
    /// The time that the episode was in the specified class.
    /// FHIR Path: Encounter.classHistory.period
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("period")]
    public Period Period { get; set; } = new Period();

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Class 是必要的
        if (Class == null)
        {
            yield return new ValidationResult("Encounter.classHistory.class is required");
        }
        else
        {
            var classValidationContext = new ValidationContext(Class);
            foreach (var result in Class.Validate(classValidationContext))
                yield return result;
        }

        // Period 是必要的
        if (Period == null)
        {
            yield return new ValidationResult("Encounter.classHistory.period is required");
        }
        else
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// The list of people responsible for providing the service.
///
/// BackboneElement for Encounter.Participant
/// </summary>
public class EncounterParticipant : BackboneElement
{
    /// <summary>
    /// Role of participant in encounter.
    /// FHIR Path: Encounter.participant.type
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("type")]
    public List<CodeableConcept>? Type { get; set; }

    /// <summary>
    /// Period of time during the encounter that the participant participated.
    /// FHIR Path: Encounter.participant.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// Persons involved in the encounter other than the patient.
    /// FHIR Path: Encounter.participant.individual
    /// Cardinality: 0..1
    /// Reference to: Practitioner, PractitionerRole, RelatedPerson
    /// </summary>
    [JsonPropertyName("individual")]
    public Reference<Practitioner, PractitionerRole, RelatedPerson>? Individual { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證子組件
        if (Type != null)
        {
            foreach (var type in Type)
            {
                var typeValidationContext = new ValidationContext(type);
                foreach (var result in type.Validate(typeValidationContext))
                    yield return result;
            }
        }

        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }

        if (Individual != null)
        {
            var individualValidationContext = new ValidationContext(Individual);
            foreach (var result in Individual.Validate(individualValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// The list of diagnosis relevant to this encounter.
///
/// BackboneElement for Encounter.Diagnosis
/// </summary>
public class EncounterDiagnosis : BackboneElement
{
    /// <summary>
    /// Reason the encounter takes place, as specified using information from another resource.
    /// FHIR Path: Encounter.diagnosis.condition
    /// Cardinality: 1..1
    /// Required: Yes
    /// Reference to: Condition, Procedure
    /// </summary>
    [JsonPropertyName("condition")]
    public Reference<Condition, Procedure>? Condition { get; set; }

    /// <summary>
    /// Role that this diagnosis has within the encounter (e.g. admission, billing, discharge …).
    /// FHIR Path: Encounter.diagnosis.use
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("use")]
    public CodeableConcept? Use { get; set; }

    /// <summary>
    /// Ranking of the diagnosis (for each role type).
    /// FHIR Path: Encounter.diagnosis.rank
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Condition 是必要的
        if (Condition == null)
        {
            yield return new ValidationResult("Encounter.diagnosis.condition is required");
        }
        else
        {
            var conditionValidationContext = new ValidationContext(Condition);
            foreach (var result in Condition.Validate(conditionValidationContext))
                yield return result;
        }

        // 驗證 rank 值
        if (Rank.HasValue && Rank.Value < 1)
        {
            yield return new ValidationResult("Encounter.diagnosis.rank must be a positive integer");
        }

        // 驗證 use
        if (Use != null)
        {
            var useValidationContext = new ValidationContext(Use);
            foreach (var result in Use.Validate(useValidationContext))
                yield return result;
        }
    }
}

/// <summary>
/// Details about the admission to a healthcare service.
///
/// BackboneElement for Encounter.Hospitalization
/// </summary>
public class EncounterHospitalization : BackboneElement
{
    /// <summary>
    /// Pre-admission identifier.
    /// FHIR Path: Encounter.hospitalization.preAdmissionIdentifier
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("preAdmissionIdentifier")]
    public Identifier? PreAdmissionIdentifier { get; set; }

    /// <summary>
    /// The location/organization from which the patient came before admission.
    /// FHIR Path: Encounter.hospitalization.origin
    /// Cardinality: 0..1
    /// Reference to: Location, Organization
    /// </summary>
    [JsonPropertyName("origin")]
    public Reference<Location, Organization>? Origin { get; set; }

    /// <summary>
    /// From where patient was admitted (physician referral, transfer).
    /// FHIR Path: Encounter.hospitalization.admitSource
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("admitSource")]
    public CodeableConcept? AdmitSource { get; set; }

    /// <summary>
    /// The type of hospital re-admission that has occurred (if any).
    /// FHIR Path: Encounter.hospitalization.reAdmission
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("reAdmission")]
    public CodeableConcept? ReAdmission { get; set; }

    /// <summary>
    /// Diet preferences reported by the patient.
    /// FHIR Path: Encounter.hospitalization.dietPreference
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("dietPreference")]
    public List<CodeableConcept>? DietPreference { get; set; }

    /// <summary>
    /// Special courtesies (VIP, board member).
    /// FHIR Path: Encounter.hospitalization.specialCourtesy
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("specialCourtesy")]
    public List<CodeableConcept>? SpecialCourtesy { get; set; }

    /// <summary>
    /// Any special requests that have been made for this hospitalization encounter, such as the provision of specific equipment or other things.
    /// FHIR Path: Encounter.hospitalization.specialArrangement
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("specialArrangement")]
    public List<CodeableConcept>? SpecialArrangement { get; set; }

    /// <summary>
    /// Location/organization to which the patient is discharged.
    /// FHIR Path: Encounter.hospitalization.destination
    /// Cardinality: 0..1
    /// Reference to: Location, Organization
    /// </summary>
    [JsonPropertyName("destination")]
    public Reference<Location, Organization>? Destination { get; set; }

    /// <summary>
    /// Category or kind of location after discharge.
    /// FHIR Path: Encounter.hospitalization.dischargeDisposition
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("dischargeDisposition")]
    public CodeableConcept? DischargeDisposition { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證子組件
        if (PreAdmissionIdentifier != null)
        {
            var preAdmissionIdValidationContext = new ValidationContext(PreAdmissionIdentifier);
            foreach (var result in PreAdmissionIdentifier.Validate(preAdmissionIdValidationContext))
                yield return result;
        }

        if (Origin != null)
        {
            var originValidationContext = new ValidationContext(Origin);
            foreach (var result in Origin.Validate(originValidationContext))
                yield return result;
        }

        if (AdmitSource != null)
        {
            var admitSourceValidationContext = new ValidationContext(AdmitSource);
            foreach (var result in AdmitSource.Validate(admitSourceValidationContext))
                yield return result;
        }

        // 其他子組件驗證會在完整實作中添加
    }
}

/// <summary>
/// List of locations where the patient has been during this encounter.
///
/// BackboneElement for Encounter.Location
/// </summary>
public class EncounterLocation : BackboneElement
{
    /// <summary>
    /// Location the encounter takes place.
    /// FHIR Path: Encounter.location.location
    /// Cardinality: 1..1
    /// Required: Yes
    /// Reference to: Location
    /// </summary>
    [JsonPropertyName("location")]
    public Reference<Location>? Location { get; set; }

    /// <summary>
    /// The status of the participants' presence at the specified location during the period specified.
    /// FHIR Path: Encounter.location.status
    /// Cardinality: 0..1
    /// Allowed values: planned, active, reserved, completed
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// This will be used to specify the required levels (bed/ward/room/etc.) desired to be recorded to simplify either messaging or query.
    /// FHIR Path: Encounter.location.physicalType
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("physicalType")]
    public CodeableConcept? PhysicalType { get; set; }

    /// <summary>
    /// Time period during which the patient was present at the location.
    /// FHIR Path: Encounter.location.period
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // Location 是必要的
        if (Location == null)
        {
            yield return new ValidationResult("Encounter.location.location is required");
        }
        else
        {
            var locationValidationContext = new ValidationContext(Location);
            foreach (var result in Location.Validate(locationValidationContext))
                yield return result;
        }

        // 驗證 status 值
        if (!string.IsNullOrEmpty(Status))
        {
            var validStatuses = new[] { "planned", "active", "reserved", "completed" };
            if (!validStatuses.Contains(Status))
            {
                yield return new ValidationResult($"Encounter.location.status '{Status}' is not valid. Must be one of: {string.Join(", ", validStatuses)}");
            }
        }

        // 驗證其他子組件
        if (PhysicalType != null)
        {
            var physicalTypeValidationContext = new ValidationContext(PhysicalType);
            foreach (var result in PhysicalType.Validate(physicalTypeValidationContext))
                yield return result;
        }

        if (Period != null)
        {
            var periodValidationContext = new ValidationContext(Period);
            foreach (var result in Period.Validate(periodValidationContext))
                yield return result;
        }
    }
}
