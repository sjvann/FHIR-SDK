using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.Resources;

/// <summary>
/// 前向宣告，避免循環依賴
/// 這些是基本的 Resource 宣告，完整實作會在各自的檔案中
/// </summary>

// Organization 已在 Organization.cs 中完整實作

// Practitioner 已在 Practitioner.cs 中完整實作

/// <summary>
/// A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time.
/// </summary>
/// <remarks>
/// FHIR R4 PractitionerRole DomainResource
/// Forward declaration - full implementation in PractitionerRole.cs
/// </remarks>
public class PractitionerRole : DomainResource
{
    // 基本實作，完整版本會在 PractitionerRole.cs 中
}

/// <summary>
/// Information about a person that is involved in the care for a patient, but who is not the target of healthcare, nor has a formal responsibility in the care process.
/// </summary>
/// <remarks>
/// FHIR R4 RelatedPerson DomainResource
/// Forward declaration - full implementation in RelatedPerson.cs
/// </remarks>
public class RelatedPerson : DomainResource
{
    // 基本實作，完整版本會在 RelatedPerson.cs 中
}

/// <summary>
/// The technical details of an endpoint that can be used for electronic services.
/// </summary>
/// <remarks>
/// FHIR R4 Endpoint DomainResource
/// Forward declaration - full implementation in Endpoint.cs
/// </remarks>
public class Endpoint : DomainResource
{
    // 基本實作，完整版本會在 Endpoint.cs 中
}

// 更多 Resources 的前向宣告

public class CarePlan : DomainResource { }
public class DeviceRequest : DomainResource { }
public class ImmunizationRecommendation : DomainResource { }
public class MedicationRequest : DomainResource { }
public class NutritionOrder : DomainResource { }
public class ServiceRequest : DomainResource { }
public class MedicationAdministration : DomainResource { }
public class MedicationDispense : DomainResource { }
public class MedicationStatement : DomainResource { }
public class Procedure : DomainResource { }
public class Immunization : DomainResource { }
public class ImagingStudy : DomainResource { }
public class Group : DomainResource { }
public class Device : DomainResource { }
// Location 已在 Location.cs 中完整實作
// Encounter 已在 Encounter.cs 中完整實作
public class CareTeam : DomainResource { }
public class Specimen : DomainResource { }
public class DeviceMetric : DomainResource { }
public class QuestionnaireResponse : DomainResource { }
public class MolecularSequence : DomainResource { }
public class DocumentReference : DomainResource { }
public class Media : DomainResource { }

// 更多 Resources 的前向宣告
public class EpisodeOfCare : DomainResource { }
public class Appointment : DomainResource { }
public class Condition : DomainResource { }
public class Account : DomainResource { }
// PractitionerRole 已在上面定義
