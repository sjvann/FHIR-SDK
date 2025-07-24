namespace Fhir.Generator.Models;

/// <summary>
/// 原始型別資訊
/// </summary>
public class PrimitiveTypeInfo
{
    public string ClassName { get; set; } = string.Empty;
    public string NativeType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

/// <summary>
/// 資料型別資訊
/// </summary>
public class DataTypeInfo
{
    public string ClassName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<PropertyDefinition> Properties { get; set; } = new();
}

/// <summary>
/// 資源資訊
/// </summary>
public class ResourceInfo
{
    public string ClassName { get; set; } = string.Empty;
    public string ResourceType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<PropertyDefinition> Properties { get; set; } = new();
}

/// <summary>
/// 簡化的型別映射器
/// </summary>
public class SimpleTypeMapper
{
    private readonly Dictionary<string, string> _fhirToCSharpMap;

    public SimpleTypeMapper()
    {
        _fhirToCSharpMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // 原始型別
            { "string", "string" },
            { "integer", "int" },
            { "decimal", "decimal" },
            { "boolean", "bool" },
            { "dateTime", "DateTime" },
            { "date", "DateTime" },
            { "time", "string" },
            { "instant", "DateTime" },
            { "uri", "string" },
            { "url", "string" },
            { "canonical", "string" },
            { "code", "string" },
            { "id", "string" },
            { "oid", "string" },
            { "uuid", "string" },
            { "markdown", "string" },
            { "unsignedInt", "uint" },
            { "positiveInt", "uint" },
            { "base64Binary", "string" },

            // 複雜型別
            { "HumanName", "Fhir.Models.R4.HumanName" },
            { "Identifier", "Fhir.Models.R4.Identifier" },
            { "CodeableConcept", "Fhir.Models.R4.CodeableConcept" },
            { "Coding", "Fhir.Models.R4.Coding" },
            { "Reference", "Fhir.Models.R4.Reference" },
            { "Period", "Fhir.Models.R4.Period" },
            { "Quantity", "Fhir.Models.R4.Quantity" },
            { "Range", "Fhir.Models.R4.Range" },
            { "Ratio", "Fhir.Models.R4.Ratio" },
            { "SampledData", "Fhir.Models.R4.SampledData" },
            { "Address", "Fhir.Models.R4.Address" },
            { "ContactPoint", "Fhir.Models.R4.ContactPoint" },
            { "Annotation", "Fhir.Models.R4.Annotation" },
            { "Attachment", "Fhir.Models.R4.Attachment" },
            { "Narrative", "Fhir.Models.R4.Narrative" },
            { "Meta", "Fhir.Models.R4.Meta" },
            { "Extension", "Fhir.Models.R4.Extension" },

            // 資源型別
            { "Patient", "Fhir.Models.R4.Patient" },
            { "Observation", "Fhir.Models.R4.Observation" },
            { "Encounter", "Fhir.Models.R4.Encounter" },
            { "Condition", "Fhir.Models.R4.Condition" },
            { "Procedure", "Fhir.Models.R4.Procedure" },
            { "MedicationRequest", "Fhir.Models.R4.MedicationRequest" },
            { "Medication", "Fhir.Models.R4.Medication" },
            { "Organization", "Fhir.Models.R4.Organization" },
            { "Practitioner", "Fhir.Models.R4.Practitioner" },
            { "PractitionerRole", "Fhir.Models.R4.PractitionerRole" },
            { "Location", "Fhir.Models.R4.Location" },
            { "Device", "Fhir.Models.R4.Device" },
            { "AllergyIntolerance", "Fhir.Models.R4.AllergyIntolerance" },
            { "Immunization", "Fhir.Models.R4.Immunization" },
            { "CarePlan", "Fhir.Models.R4.CarePlan" },
            { "CareTeam", "Fhir.Models.R4.CareTeam" },
            { "Goal", "Fhir.Models.R4.Goal" },
            { "EpisodeOfCare", "Fhir.Models.R4.EpisodeOfCare" },
            { "Account", "Fhir.Models.R4.Account" },
            { "ChargeItem", "Fhir.Models.R4.ChargeItem" },
            { "Invoice", "Fhir.Models.R4.Invoice" },
            { "PaymentNotice", "Fhir.Models.R4.PaymentNotice" },
            { "PaymentReconciliation", "Fhir.Models.R4.PaymentReconciliation" },
            { "Claim", "Fhir.Models.R4.Claim" },
            { "ClaimResponse", "Fhir.Models.R4.ClaimResponse" },
            { "Coverage", "Fhir.Models.R4.Coverage" },
            { "CoverageEligibilityRequest", "Fhir.Models.R4.CoverageEligibilityRequest" },
            { "CoverageEligibilityResponse", "Fhir.Models.R4.CoverageEligibilityResponse" },
            { "EnrollmentRequest", "Fhir.Models.R4.EnrollmentRequest" },
            { "EnrollmentResponse", "Fhir.Models.R4.EnrollmentResponse" },
            { "ExplanationOfBenefit", "Fhir.Models.R4.ExplanationOfBenefit" },
            { "InsurancePlan", "Fhir.Models.R4.InsurancePlan" },
            { "VisionPrescription", "Fhir.Models.R4.VisionPrescription" },
            { "ActivityDefinition", "Fhir.Models.R4.ActivityDefinition" },
            { "DeviceDefinition", "Fhir.Models.R4.DeviceDefinition" },
            { "HealthcareService", "Fhir.Models.R4.HealthcareService" },
            { "MedicinalProduct", "Fhir.Models.R4.MedicinalProduct" },
            { "MedicinalProductAuthorization", "Fhir.Models.R4.MedicinalProductAuthorization" },
            { "MedicinalProductContraindication", "Fhir.Models.R4.MedicinalProductContraindication" },
            { "MedicinalProductIndication", "Fhir.Models.R4.MedicinalProductIndication" },
            { "MedicinalProductIngredient", "Fhir.Models.R4.MedicinalProductIngredient" },
            { "MedicinalProductInteraction", "Fhir.Models.R4.MedicinalProductInteraction" },
            { "MedicinalProductManufactured", "Fhir.Models.R4.MedicinalProductManufactured" },
            { "MedicinalProductPackaged", "Fhir.Models.R4.MedicinalProductPackaged" },
            { "MedicinalProductPharmaceutical", "Fhir.Models.R4.MedicinalProductPharmaceutical" },
            { "MedicinalProductUndesirableEffect", "Fhir.Models.R4.MedicinalProductUndesirableEffect" },
            { "NutritionOrder", "Fhir.Models.R4.NutritionOrder" },
            { "RequestGroup", "Fhir.Models.R4.RequestGroup" },
            { "ResearchDefinition", "Fhir.Models.R4.ResearchDefinition" },
            { "ResearchElementDefinition", "Fhir.Models.R4.ResearchElementDefinition" },
            { "ResearchStudy", "Fhir.Models.R4.ResearchStudy" },
            { "ResearchSubject", "Fhir.Models.R4.ResearchSubject" },
            { "RiskAssessment", "Fhir.Models.R4.RiskAssessment" },
            { "ServiceRequest", "Fhir.Models.R4.ServiceRequest" },
            { "Specimen", "Fhir.Models.R4.Specimen" },
            { "SpecimenDefinition", "Fhir.Models.R4.SpecimenDefinition" },
            { "Substance", "Fhir.Models.R4.Substance" },
            { "SubstanceNucleicAcid", "Fhir.Models.R4.SubstanceNucleicAcid" },
            { "SubstancePolymer", "Fhir.Models.R4.SubstancePolymer" },
            { "SubstanceProtein", "Fhir.Models.R4.SubstanceProtein" },
            { "SubstanceReferenceInformation", "Fhir.Models.R4.SubstanceReferenceInformation" },
            { "SubstanceSourceMaterial", "Fhir.Models.R4.SubstanceSourceMaterial" },
            { "SubstanceSpecification", "Fhir.Models.R4.SubstanceSpecification" },
            { "SupplyDelivery", "Fhir.Models.R4.SupplyDelivery" },
            { "SupplyRequest", "Fhir.Models.R4.SupplyRequest" },
            { "Task", "Fhir.Models.R4.Task" },
            { "VerificationResult", "Fhir.Models.R4.VerificationResult" }
        };
    }

    /// <summary>
    /// 將 FHIR 型別映射到 C# 型別
    /// </summary>
    public string MapFhirTypeToCSharp(string fhirType)
    {
        if (_fhirToCSharpMap.TryGetValue(fhirType, out var csharpType))
        {
            return csharpType;
        }

        // 如果找不到映射，返回原始型別名稱
        return fhirType;
    }
} 