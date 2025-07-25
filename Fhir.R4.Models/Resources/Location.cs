using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;
using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated.
/// </summary>
/// <remarks>
/// FHIR R4 Location DomainResource
/// Details and position information for a physical place where services are provided.
/// </remarks>
public class Location : DomainResource
{
    /// <summary>
    /// Unique code or number identifying the location to its users.
    /// FHIR Path: Location.identifier
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("identifier")]
    public List<Identifier>? Identifier { get; set; }
    
    /// <summary>
    /// The status property covers the general availability of the resource, not the current value which may be covered by the operationStatus, or by a schedule/slots if they are configured for the location.
    /// FHIR Path: Location.status
    /// Cardinality: 0..1
    /// Allowed values: active, suspended, inactive
    /// </summary>
    [JsonPropertyName("status")]
    public FhirCode? Status { get; set; }
    
    /// <summary>
    /// The operational status covers operation values most relevant to beds (but can also apply to rooms/units/chairs/etc. such as an isolation unit/dialysis chair).
    /// FHIR Path: Location.operationalStatus
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("operationalStatus")]
    public Coding? OperationalStatus { get; set; }
    
    /// <summary>
    /// Name of the location as used by humans.
    /// FHIR Path: Location.name
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("name")]
    public FhirString? Name { get; set; }
    
    /// <summary>
    /// A list of alternate names that the location is known as, or was known as, in the past.
    /// FHIR Path: Location.alias
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("alias")]
    public List<FhirString>? Alias { get; set; }
    
    /// <summary>
    /// Description of the Location, which helps in finding or referencing the place.
    /// FHIR Path: Location.description
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("description")]
    public FhirString? Description { get; set; }
    
    /// <summary>
    /// Indicates the type of function performed at the location.
    /// FHIR Path: Location.mode
    /// Cardinality: 0..1
    /// Allowed values: instance, kind
    /// </summary>
    [JsonPropertyName("mode")]
    public FhirCode? Mode { get; set; }
    
    /// <summary>
    /// Indicates the type of function performed at the location.
    /// FHIR Path: Location.type
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("type")]
    public List<CodeableConcept>? Type { get; set; }
    
    /// <summary>
    /// The contact details of communication devices available at the location.
    /// FHIR Path: Location.telecom
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("telecom")]
    public List<ContactPoint>? Telecom { get; set; }
    
    /// <summary>
    /// Physical location.
    /// FHIR Path: Location.address
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("address")]
    public Address? Address { get; set; }
    
    /// <summary>
    /// Physical form of the location, e.g. building, room, vehicle, road.
    /// FHIR Path: Location.physicalType
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("physicalType")]
    public CodeableConcept? PhysicalType { get; set; }
    
    /// <summary>
    /// The absolute geographic location of the Location, expressed using the WGS84 datum.
    /// FHIR Path: Location.position
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("position")]
    public LocationPosition? Position { get; set; }
    
    /// <summary>
    /// The organization responsible for the provisioning and upkeep of the location.
    /// FHIR Path: Location.managingOrganization
    /// Cardinality: 0..1
    /// Reference to: Organization
    /// </summary>
    [JsonPropertyName("managingOrganization")]
    public Reference<Organization>? ManagingOrganization { get; set; }
    
    /// <summary>
    /// Another Location of which this Location is physically a part of.
    /// FHIR Path: Location.partOf
    /// Cardinality: 0..1
    /// Reference to: Location
    /// </summary>
    [JsonPropertyName("partOf")]
    public Reference<Location>? PartOf { get; set; }
    
    /// <summary>
    /// What days/times during a week is this location usually open.
    /// FHIR Path: Location.hoursOfOperation
    /// Cardinality: 0..*
    /// </summary>
    [JsonPropertyName("hoursOfOperation")]
    public List<LocationHoursOfOperation>? HoursOfOperation { get; set; }
    
    /// <summary>
    /// A description of when the locations opening ours are different to normal, e.g. public holiday availability.
    /// FHIR Path: Location.availabilityExceptions
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("availabilityExceptions")]
    public FhirString? AvailabilityExceptions { get; set; }
    
    /// <summary>
    /// Technical endpoints providing access to services operated for the location.
    /// FHIR Path: Location.endpoint
    /// Cardinality: 0..*
    /// Reference to: Endpoint
    /// </summary>
    [JsonPropertyName("endpoint")]
    public List<Reference<Endpoint>>? Endpoint { get; set; }
    
    /// <summary>
    /// Validates the Location according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;
            
        // 驗證 status 值
        if (Status?.Value != null)
        {
            var validStatuses = new[] { "active", "suspended", "inactive" };
            if (!validStatuses.Contains(Status.Value))
            {
                yield return new ValidationResult($"Location.status '{Status.Value}' is not valid. Must be one of: {string.Join(", ", validStatuses)}");
            }
        }
        
        // 驗證 mode 值
        if (Mode?.Value != null)
        {
            var validModes = new[] { "instance", "kind" };
            if (!validModes.Contains(Mode.Value))
            {
                yield return new ValidationResult($"Location.mode '{Mode.Value}' is not valid. Must be one of: {string.Join(", ", validModes)}");
            }
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
        
        if (OperationalStatus != null)
        {
            var operationalStatusValidationContext = new ValidationContext(OperationalStatus);
            foreach (var result in OperationalStatus.Validate(operationalStatusValidationContext))
                yield return result;
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
        
        if (Telecom != null)
        {
            foreach (var telecom in Telecom)
            {
                var telecomValidationContext = new ValidationContext(telecom);
                foreach (var result in telecom.Validate(telecomValidationContext))
                    yield return result;
            }
        }
        
        if (Address != null)
        {
            var addressValidationContext = new ValidationContext(Address);
            foreach (var result in Address.Validate(addressValidationContext))
                yield return result;
        }
        
        if (PhysicalType != null)
        {
            var physicalTypeValidationContext = new ValidationContext(PhysicalType);
            foreach (var result in PhysicalType.Validate(physicalTypeValidationContext))
                yield return result;
        }
        
        if (Position != null)
        {
            var positionValidationContext = new ValidationContext(Position);
            foreach (var result in Position.Validate(positionValidationContext))
                yield return result;
        }
        
        if (ManagingOrganization != null)
        {
            var managingOrgValidationContext = new ValidationContext(ManagingOrganization);
            foreach (var result in ManagingOrganization.Validate(managingOrgValidationContext))
                yield return result;
        }
        
        if (PartOf != null)
        {
            var partOfValidationContext = new ValidationContext(PartOf);
            foreach (var result in PartOf.Validate(partOfValidationContext))
                yield return result;
        }
        
        if (HoursOfOperation != null)
        {
            foreach (var hours in HoursOfOperation)
            {
                var hoursValidationContext = new ValidationContext(hours);
                foreach (var result in hours.Validate(hoursValidationContext))
                    yield return result;
            }
        }
        
        if (Endpoint != null)
        {
            foreach (var endpoint in Endpoint)
            {
                var endpointValidationContext = new ValidationContext(endpoint);
                foreach (var result in endpoint.Validate(endpointValidationContext))
                    yield return result;
            }
        }
    }
}

/// <summary>
/// The absolute geographic location of the Location, expressed using the WGS84 datum.
///
/// BackboneElement for Location.Position
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class LocationPosition : BackboneElement
{
    /// <summary>
    /// Longitude with WGS84 datum.
    /// FHIR Path: Location.position.longitude
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("longitude")]
    public decimal Longitude { get; set; }

    /// <summary>
    /// Latitude with WGS84 datum.
    /// FHIR Path: Location.position.latitude
    /// Cardinality: 1..1
    /// Required: Yes
    /// </summary>
    [JsonPropertyName("latitude")]
    public decimal Latitude { get; set; }

    /// <summary>
    /// Altitude with WGS84 datum.
    /// FHIR Path: Location.position.altitude
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("altitude")]
    public decimal? Altitude { get; set; }

    /// <summary>
    /// Validates the LocationPosition according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證經緯度範圍
        if (Longitude < -180 || Longitude > 180)
        {
            yield return new ValidationResult("Location.position.longitude must be between -180 and 180");
        }

        if (Latitude < -90 || Latitude > 90)
        {
            yield return new ValidationResult("Location.position.latitude must be between -90 and 90");
        }
    }
}

/// <summary>
/// What days/times during a week is this location usually open.
///
/// BackboneElement for Location.HoursOfOperation
/// This element is defined within the resource and contains additional
/// structured information that is part of the resource definition.
/// </summary>
public class LocationHoursOfOperation : BackboneElement
{
    /// <summary>
    /// Indicates which days of the week are available between the start and end Times.
    /// FHIR Path: Location.hoursOfOperation.daysOfWeek
    /// Cardinality: 0..*
    /// Allowed values: mon, tue, wed, thu, fri, sat, sun
    /// </summary>
    [JsonPropertyName("daysOfWeek")]
    public List<FhirCode>? DaysOfWeek { get; set; }

    /// <summary>
    /// The Location is open all day.
    /// FHIR Path: Location.hoursOfOperation.allDay
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("allDay")]
    public bool? AllDay { get; set; }

    /// <summary>
    /// Time that the Location opens.
    /// FHIR Path: Location.hoursOfOperation.openingTime
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("openingTime")]
    public FhirTime? OpeningTime { get; set; }

    /// <summary>
    /// Time that the Location closes.
    /// FHIR Path: Location.hoursOfOperation.closingTime
    /// Cardinality: 0..1
    /// </summary>
    [JsonPropertyName("closingTime")]
    public FhirTime? ClosingTime { get; set; }

    /// <summary>
    /// Validates the LocationHoursOfOperation according to FHIR R4 rules.
    /// </summary>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>A collection of validation results.</returns>
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        foreach (var result in base.Validate(validationContext))
            yield return result;

        // 驗證 daysOfWeek 值
        if (DaysOfWeek != null)
        {
            var validDays = new[] { "mon", "tue", "wed", "thu", "fri", "sat", "sun" };
            foreach (var day in DaysOfWeek)
            {
                if (day?.Value != null && !validDays.Contains(day.Value))
                {
                    yield return new ValidationResult($"Location.hoursOfOperation.daysOfWeek '{day.Value}' is not valid. Must be one of: {string.Join(", ", validDays)}");
                }
            }
        }

        // 驗證時間格式（簡化版本）
        if (OpeningTime?.Value != null && !IsValidTime(OpeningTime.Value))
        {
            yield return new ValidationResult($"Location.hoursOfOperation.openingTime '{OpeningTime.Value}' is not a valid time format");
        }

        if (ClosingTime?.Value != null && !IsValidTime(ClosingTime.Value))
        {
            yield return new ValidationResult($"Location.hoursOfOperation.closingTime '{ClosingTime.Value}' is not a valid time format");
        }

        // 如果有開始和結束時間，結束時間應該在開始時間之後
        if (OpeningTime?.Value != null && ClosingTime?.Value != null)
        {
            if (TimeSpan.TryParse(OpeningTime.Value, out var openTime) && TimeSpan.TryParse(ClosingTime.Value, out var closeTime))
            {
                if (closeTime <= openTime)
                {
                    yield return new ValidationResult("Location.hoursOfOperation.closingTime must be after openingTime");
                }
            }
        }
    }

    /// <summary>
    /// Validates the time format (simplified version).
    /// </summary>
    /// <param name="time">The time string to validate.</param>
    /// <returns>True if the time format is valid; otherwise, false.</returns>
    private bool IsValidTime(string time)
    {
        return TimeSpan.TryParse(time, out _);
    }
}
