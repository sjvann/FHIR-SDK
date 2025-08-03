using FhirCore.Interfaces;
using FhirCore.Versioning;

namespace FhirCore.R4
{
    /// <summary>
    /// FHIR R4 版本定義
    /// </summary>
    public class R4Version : IFhirVersion
    {
        /// <summary>
        /// 取得 FHIR R4 版本號
        /// </summary>
        public string Version => "4.0.1";

        /// <summary>
        /// 所有的 R4 支援資源類型列表
        /// </summary>
        private static readonly HashSet<string> SupportedResourceTypes = new()
        {
            "Account", "ActivityDefinition", "AdverseEvent", "AllergyIntolerance", "Appointment", 
            "AppointmentResponse", "AuditEvent", "Basic", "Binary", "BiologicallyDerivedProduct",
            "BodyStructure", "Bundle", "CapabilityStatement", "CarePlan", "CareTeam", "CatalogEntry",
            "ChargeItem", "ChargeItemDefinition", "Claim", "ClaimResponse", "ClinicalImpression",
            "CodeSystem", "Communication", "CommunicationRequest", "CompartmentDefinition", 
            "Composition", "ConceptMap", "Condition", "Consent", "Contract", "Coverage",
            "CoverageEligibilityRequest", "CoverageEligibilityResponse", "DetectedIssue", "Device",
            "DeviceDefinition", "DeviceMetric", "DeviceRequest", "DeviceUseStatement", 
            "DiagnosticReport", "DocumentManifest", "DocumentReference", "EffectEvidenceSynthesis",
            "Encounter", "Endpoint", "EnrollmentRequest", "EnrollmentResponse", "EpisodeOfCare",
            "EventDefinition", "Evidence", "EvidenceVariable", "ExampleScenario", 
            "ExplanationOfBenefit", "FamilyMemberHistory", "Flag", "Goal", "GraphDefinition",
            "Group", "GuidanceResponse", "HealthcareService", "ImagingStudy", "Immunization",
            "ImmunizationEvaluation", "ImmunizationRecommendation", "ImplementationGuide",
            "InsurancePlan", "Invoice", "Library", "Linkage", "List", "Location", "Measure",
            "MeasureReport", "Media", "Medication", "MedicationAdministration", "MedicationDispense",
            "MedicationKnowledge", "MedicationRequest", "MedicationStatement", "MedicinalProduct",
            "MedicinalProductAuthorization", "MedicinalProductContraindication", 
            "MedicinalProductIndication", "MedicinalProductIngredient", "MedicinalProductInteraction",
            "MedicinalProductManufactured", "MedicinalProductPackaged", "MedicinalProductPharmaceutical",
            "MedicinalProductUndesirableEffect", "MessageDefinition", "MessageHeader", 
            "MolecularSequence", "NamingSystem", "NutritionOrder", "Observation", 
            "ObservationDefinition", "OperationDefinition", "OperationOutcome", "Organization",
            "OrganizationAffiliation", "Parameters", "Patient", "PaymentNotice", 
            "PaymentReconciliation", "Person", "PlanDefinition", "Practitioner", "PractitionerRole",
            "Procedure", "Provenance", "Questionnaire", "QuestionnaireResponse", "RelatedPerson",
            "RequestGroup", "ResearchDefinition", "ResearchElementDefinition", "ResearchStudy",
            "ResearchSubject", "RiskAssessment", "RiskEvidenceSynthesis", "Schedule", 
            "SearchParameter", "ServiceRequest", "Slot", "Specimen", "SpecimenDefinition",
            "StructureDefinition", "StructureMap", "Subscription", "Substance", 
            "SubstanceNucleicAcid", "SubstancePolymer", "SubstanceProtein", 
            "SubstanceReferenceInformation", "SubstanceSourceMaterial", "SubstanceSpecification",
            "SupplyDelivery", "SupplyRequest", "Task", "TerminologyCapabilities", "TestReport",
            "TestScript", "ValueSet", "VerificationResult", "VisionPrescription"
        };

        /// <summary>
        /// 所有的 R4 支援資料類型列表
        /// </summary>
        private static readonly HashSet<string> SupportedDataTypes = new()
        {
            // Primitive Types
            "base64Binary", "boolean", "canonical", "code", "date", "dateTime", "decimal", "id",
            "instant", "integer", "markdown", "oid", "positiveInt", "string", "time",
            "unsignedInt", "uri", "url", "uuid", "xhtml",
            
            // Complex Types (General Purpose)
            "Address", "Age", "Annotation", "Attachment", "CodeableConcept", "Coding", 
            "ContactDetail", "ContactPoint", "Contributor", "DataRequirement", "Expression",
            "Extension", "HumanName", "Identifier", "MarketingStatus", "Meta", "Money",
            "Narrative", "ParameterDefinition", "Period", "ProductShelfLife", "Quantity", 
            "Range", "Ratio", "Reference", "RelatedArtifact", "SampledData", "Signature",
            "SimpleQuantity", "Timing", "TriggerDefinition", "UsageContext",
            
            // Complex Types (Metadata)
            "Count", "Distance", "Duration",
            
            // Complex Types (Special Purpose)  
            "Dosage", "ElementDefinition", "Population"
        };

        /// <summary>
        /// 檢查是否支援指定資源類型
        /// </summary>
        /// <param name="resourceType">資源類型名稱</param>
        /// <returns>是否支援</returns>
        public bool SupportsResourceType(string resourceType)
        {
            return SupportedResourceTypes.Contains(resourceType);
        }

        /// <summary>
        /// 檢查是否支援指定資料類型
        /// </summary>
        /// <param name="dataType">資料類型名稱</param>
        /// <returns>是否支援</returns>
        public bool SupportsDataType(string dataType)
        {
            return SupportedDataTypes.Contains(dataType);
        }

        /// <summary>
        /// 取得支援的資源類型列表
        /// </summary>
        /// <returns>支援的資源類型</returns>
        /// <remarks>
        /// 回傳所有的 FHIR R4 資源類型列表，與 SupportsResourceType 方法是完全一致
        /// </remarks>
        public IEnumerable<string> GetSupportedResourceTypes()
        {
            return SupportedResourceTypes.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// 取得支援的資料類型列表
        /// </summary>
        /// <returns>支援的資料類型</returns>
        /// <remarks>
        /// 回傳所有的 FHIR R4 資料類型列表，與 SupportsDataType 方法是完全一致
        /// </remarks>
        public IEnumerable<string> GetSupportedDataTypes()
        {
            return SupportedDataTypes.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// 取得資源類型總數量
        /// </summary>
        /// <returns>支援的資源類型數量</returns>
        public int GetResourceTypeCount()
        {
            return SupportedResourceTypes.Count;
        }

        /// <summary>
        /// 取得資料類型總數量  
        /// </summary>
        /// <returns>支援的資料類型數量</returns>
        public int GetDataTypeCount()
        {
            return SupportedDataTypes.Count;
        }

        /// <summary>
        /// 驗證資源是否符合 FHIR R4 規範
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果</returns>
        public ValidationResult ValidateResource(object resource)
        {
            // R4 特定的驗證邏輯
            var results = new List<ValidationResult>();
            
            // 基本結構驗證
            results.AddRange(ValidateStructure(resource));
            
            // R4 特定語意驗證
            results.AddRange(ValidateR4Semantics(resource));
            
            // R4 業務規則驗證
            results.AddRange(ValidateR4BusinessRules(resource));
            
            // 如果有任何錯誤，回傳失敗結果
            if (results.Any(r => !r.IsValid))
            {
                var errorMessages = results.Where(r => !r.IsValid).SelectMany(r => r.Messages).ToList();
                return new ValidationResult(false, errorMessages, "R4Validation");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證 R4 資源結構
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果列表</returns>
        private IEnumerable<ValidationResult> ValidateStructure(object resource)
        {
            // R4 結構驗證邏輯
            var results = new List<ValidationResult>();
            
            if (resource == null)
            {
                results.Add(ValidationResult.Error("資源不能為 null", "Resource"));
            }
            
            return results;
        }

        /// <summary>
        /// 驗證 R4 語意規則
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果列表</returns>
        private IEnumerable<ValidationResult> ValidateR4Semantics(object resource)
        {
            // R4 語意驗證邏輯
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// 驗證 R4 業務規則
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果列表</returns>
        private IEnumerable<ValidationResult> ValidateR4BusinessRules(object resource)
        {
            // R4 業務規則驗證邏輯
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// 取得版本詳細摘要
        /// </summary>
        /// <returns>版本詳細字串</returns>
        public override string ToString()
        {
            return $"FHIR R4 (v{Version}) - Resources: {GetResourceTypeCount()}, DataTypes: {GetDataTypeCount()}";
        }
    }
}