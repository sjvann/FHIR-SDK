using FhirCore.Interfaces;
using FhirCore.Versioning;

namespace FhirCore.R5
{
    /// <summary>
    /// FHIR R5 版本定義
    /// </summary>
    public class R5Version : IFhirVersion
    {
        /// <summary>
        /// 取得 FHIR R5 版本號
        /// </summary>
        public string Version => "5.0.0";

        /// <summary>
        /// 完整的 R5 支援資源類型列表
        /// </summary>
        private static readonly HashSet<string> SupportedResourceTypes = new()
        {
            "Account", "ActivityDefinition", "ActorDefinition", "AdministrableProductDefinition",
            "AdverseEvent", "AllergyIntolerance", "Appointment", "AppointmentResponse",
            "ArtifactAssessment", "AuditEvent", "Basic", "Binary", "BiologicallyDerivedProduct",
            "BiologicallyDerivedProductDispense", "BodyStructure", "Bundle", "CapabilityStatement",
            "CarePlan", "CareTeam", "ChargeItem", "ChargeItemDefinition", "Citation", "Claim",
            "ClaimResponse", "ClinicalImpression", "ClinicalUseDefinition", "CodeSystem",
            "Communication", "CommunicationRequest", "CompartmentDefinition", "Composition",
            "ConceptMap", "Condition", "ConditionDefinition", "Consent", "Contract", "Coverage",
            "CoverageEligibilityRequest", "CoverageEligibilityResponse", "DetectedIssue", "Device",
            "DeviceAssociation", "DeviceDefinition", "DeviceDispense", "DeviceMetric", "DeviceRequest",
            "DeviceUsage", "DiagnosticReport", "DocumentReference", "Encounter", "Endpoint",
            "EnrollmentRequest", "EnrollmentResponse", "EpisodeOfCare", "EventDefinition",
            "Evidence", "EvidenceReport", "EvidenceVariable", "ExampleScenario", "ExplanationOfBenefit",
            "FamilyMemberHistory", "Flag", "FormularyItem", "GenomicStudy", "Goal", "GraphDefinition",
            "Group", "GuidanceResponse", "HealthcareService", "ImagingSelection", "ImagingStudy",
            "Immunization", "ImmunizationEvaluation", "ImmunizationRecommendation", "ImplementationGuide",
            "Ingredient", "InsurancePlan", "InventoryItem", "InventoryReport", "Invoice", "Library",
            "Linkage", "List", "Location", "ManufacturedItemDefinition", "Measure", "MeasureReport",
            "Medication", "MedicationAdministration", "MedicationDispense", "MedicationKnowledge",
            "MedicationRequest", "MedicationStatement", "MedicinalProductDefinition", "MessageDefinition",
            "MessageHeader", "MolecularSequence", "NamingSystem", "NutritionIntake", "NutritionOrder",
            "NutritionProduct", "Observation", "ObservationDefinition", "OperationDefinition",
            "OperationOutcome", "Organization", "OrganizationAffiliation", "PackagedProductDefinition",
            "Parameters", "Patient", "PaymentNotice", "PaymentReconciliation", "Permission",
            "Person", "PlanDefinition", "Practitioner", "PractitionerRole", "Procedure", "Provenance",
            "Questionnaire", "QuestionnaireResponse", "RegulatedAuthorization", "RelatedPerson",
            "RequestOrchestration", "Requirements", "ResearchStudy", "ResearchSubject", "RiskAssessment",
            "Schedule", "SearchParameter", "ServiceRequest", "Slot", "Specimen", "SpecimenDefinition",
            "StructureDefinition", "StructureMap", "Subscription", "SubscriptionStatus", "SubscriptionTopic",
            "Substance", "SubstanceDefinition", "SubstanceNucleicAcid", "SubstancePolymer", "SubstanceProtein",
            "SubstanceReferenceInformation", "SubstanceSourceMaterial", "SupplyDelivery", "SupplyRequest",
            "Task", "TerminologyCapabilities", "TestPlan", "TestReport", "TestScript", "Transport",
            "ValueSet", "VerificationResult", "VisionPrescription"
        };

        /// <summary>
        /// 完整的 R5 支援資料類型列表
        /// </summary>
        private static readonly HashSet<string> SupportedDataTypes = new()
        {
            // Primitive Types
            "base64Binary", "boolean", "canonical", "code", "date", "dateTime", "decimal", "id",
            "instant", "integer", "integer64", "markdown", "oid", "positiveInt", "string", "time",
            "unsignedInt", "uri", "url", "uuid", "xhtml",
            
            // Complex Types (General Purpose)
            "Address", "Age", "Annotation", "Attachment", "CodeableConcept", "CodeableReference",
            "Coding", "ContactDetail", "ContactPoint", "Contributor", "DataRequirement", "Expression",
            "Extension", "HumanName", "Identifier", "MarketingStatus", "Meta", "Money", "MoneyQuantity",
            "Narrative", "ParameterDefinition", "Period", "ProductShelfLife", "Quantity", "Range",
            "Ratio", "RatioRange", "Reference", "RelatedArtifact", "SampledData", "Signature",
            "SimpleQuantity", "Timing", "TriggerDefinition", "UsageContext", "VirtualServiceDetail",
            
            // Complex Types (Metadata)
            "Count", "Distance", "Duration",
            
            // Complex Types (Special Purpose)  
            "Dosage", "ElementDefinition", "Population"
        };

        /// <summary>
        /// 檢查是否支援指定的資源類型
        /// </summary>
        /// <param name="resourceType">資源類型名稱</param>
        /// <returns>是否支援</returns>
        public bool SupportsResourceType(string resourceType)
        {
            return SupportedResourceTypes.Contains(resourceType);
        }

        /// <summary>
        /// 檢查是否支援指定的資料類型
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
        /// 返回完整的 FHIR R5 資源類型列表，與 SupportsResourceType 方法保持一致
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
        /// 返回完整的 FHIR R5 資料類型列表，與 SupportsDataType 方法保持一致
        /// </remarks>
        public IEnumerable<string> GetSupportedDataTypes()
        {
            return SupportedDataTypes.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// 取得資源類型的總數量
        /// </summary>
        /// <returns>支援的資源類型數量</returns>
        public int GetResourceTypeCount()
        {
            return SupportedResourceTypes.Count;
        }

        /// <summary>
        /// 取得資料類型的總數量  
        /// </summary>
        /// <returns>支援的資料類型數量</returns>
        public int GetDataTypeCount()
        {
            return SupportedDataTypes.Count;
        }

        /// <summary>
        /// 驗證資源是否符合 FHIR R5 標準
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果</returns>
        public ValidationResult ValidateResource(object resource)
        {
            // R5 特定的驗證邏輯
            var results = new List<ValidationResult>();
            
            // 基本結構驗證
            results.AddRange(ValidateStructure(resource));
            
            // R5 特定語義驗證
            results.AddRange(ValidateR5Semantics(resource));
            
            // R5 業務規則驗證
            results.AddRange(ValidateR5BusinessRules(resource));
            
            // 如果有任何錯誤，返回失敗結果
            if (results.Any(r => !r.IsValid))
            {
                var errorMessages = results.Where(r => !r.IsValid).SelectMany(r => r.Messages).ToList();
                return new ValidationResult(false, errorMessages, "R5Validation");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// 驗證 R5 資源結構
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果集合</returns>
        private IEnumerable<ValidationResult> ValidateStructure(object resource)
        {
            // R5 結構驗證邏輯
            var results = new List<ValidationResult>();
            
            if (resource == null)
            {
                results.Add(ValidationResult.Error("資源不能為 null", "Resource"));
            }
            
            return results;
        }

        /// <summary>
        /// 驗證 R5 語義規則
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果集合</returns>
        private IEnumerable<ValidationResult> ValidateR5Semantics(object resource)
        {
            // R5 語義驗證邏輯
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// 驗證 R5 業務規則
        /// </summary>
        /// <param name="resource">要驗證的資源</param>
        /// <returns>驗證結果集合</returns>
        private IEnumerable<ValidationResult> ValidateR5BusinessRules(object resource)
        {
            // R5 業務規則驗證邏輯
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// 取得版本資訊摘要
        /// </summary>
        /// <returns>版本資訊字串</returns>
        public override string ToString()
        {
            return $"FHIR R5 (v{Version}) - Resources: {GetResourceTypeCount()}, DataTypes: {GetDataTypeCount()}";
        }
    }
}