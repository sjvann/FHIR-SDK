using FhirCore.Interfaces;
using FhirCore.Versioning;

namespace FhirCore.R5
{
    /// <summary>
    /// FHIR R5 �����w�q
    /// </summary>
    public class R5Version : IFhirVersion
    {
        /// <summary>
        /// ���o FHIR R5 ������
        /// </summary>
        public string Version => "5.0.0";

        /// <summary>
        /// ���㪺 R5 �䴩�귽�����C��
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
        /// ���㪺 R5 �䴩��������C��
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
        /// �ˬd�O�_�䴩���w���귽����
        /// </summary>
        /// <param name="resourceType">�귽�����W��</param>
        /// <returns>�O�_�䴩</returns>
        public bool SupportsResourceType(string resourceType)
        {
            return SupportedResourceTypes.Contains(resourceType);
        }

        /// <summary>
        /// �ˬd�O�_�䴩���w���������
        /// </summary>
        /// <param name="dataType">��������W��</param>
        /// <returns>�O�_�䴩</returns>
        public bool SupportsDataType(string dataType)
        {
            return SupportedDataTypes.Contains(dataType);
        }

        /// <summary>
        /// ���o�䴩���귽�����C��
        /// </summary>
        /// <returns>�䴩���귽����</returns>
        /// <remarks>
        /// ��^���㪺 FHIR R5 �귽�����C��A�P SupportsResourceType ��k�O���@�P
        /// </remarks>
        public IEnumerable<string> GetSupportedResourceTypes()
        {
            return SupportedResourceTypes.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// ���o�䴩����������C��
        /// </summary>
        /// <returns>�䴩���������</returns>
        /// <remarks>
        /// ��^���㪺 FHIR R5 ��������C��A�P SupportsDataType ��k�O���@�P
        /// </remarks>
        public IEnumerable<string> GetSupportedDataTypes()
        {
            return SupportedDataTypes.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// ���o�귽�������`�ƶq
        /// </summary>
        /// <returns>�䴩���귽�����ƶq</returns>
        public int GetResourceTypeCount()
        {
            return SupportedResourceTypes.Count;
        }

        /// <summary>
        /// ���o����������`�ƶq  
        /// </summary>
        /// <returns>�䴩����������ƶq</returns>
        public int GetDataTypeCount()
        {
            return SupportedDataTypes.Count;
        }

        /// <summary>
        /// ���Ҹ귽�O�_�ŦX FHIR R5 �з�
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G</returns>
        public ValidationResult ValidateResource(object resource)
        {
            // R5 �S�w�������޿�
            var results = new List<ValidationResult>();
            
            // �򥻵��c����
            results.AddRange(ValidateStructure(resource));
            
            // R5 �S�w�y�q����
            results.AddRange(ValidateR5Semantics(resource));
            
            // R5 �~�ȳW�h����
            results.AddRange(ValidateR5BusinessRules(resource));
            
            // �p�G��������~�A��^���ѵ��G
            if (results.Any(r => !r.IsValid))
            {
                var errorMessages = results.Where(r => !r.IsValid).SelectMany(r => r.Messages).ToList();
                return new ValidationResult(false, errorMessages, "R5Validation");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// ���� R5 �귽���c
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G���X</returns>
        private IEnumerable<ValidationResult> ValidateStructure(object resource)
        {
            // R5 ���c�����޿�
            var results = new List<ValidationResult>();
            
            if (resource == null)
            {
                results.Add(ValidationResult.Error("�귽���ର null", "Resource"));
            }
            
            return results;
        }

        /// <summary>
        /// ���� R5 �y�q�W�h
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G���X</returns>
        private IEnumerable<ValidationResult> ValidateR5Semantics(object resource)
        {
            // R5 �y�q�����޿�
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// ���� R5 �~�ȳW�h
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G���X</returns>
        private IEnumerable<ValidationResult> ValidateR5BusinessRules(object resource)
        {
            // R5 �~�ȳW�h�����޿�
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// ���o������T�K�n
        /// </summary>
        /// <returns>������T�r��</returns>
        public override string ToString()
        {
            return $"FHIR R5 (v{Version}) - Resources: {GetResourceTypeCount()}, DataTypes: {GetDataTypeCount()}";
        }
    }
}