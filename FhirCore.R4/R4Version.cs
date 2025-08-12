using FhirCore.Interfaces;
using FhirCore.Versioning;

namespace FhirCore.R4
{
    /// <summary>
    /// FHIR R4 �����w�q
    /// </summary>
    public class R4Version : IFhirVersion
    {
        /// <summary>
        /// ���o FHIR R4 ������
        /// </summary>
        public string Version => "4.0.1";

        /// <summary>
        /// �Ҧ��� R4 �䴩�귽�����C��
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
        /// �Ҧ��� R4 �䴩��������C��
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
        /// �ˬd�O�_�䴩���w�귽����
        /// </summary>
        /// <param name="resourceType">�귽�����W��</param>
        /// <returns>�O�_�䴩</returns>
        public bool SupportsResourceType(string resourceType)
        {
            return SupportedResourceTypes.Contains(resourceType);
        }

        /// <summary>
        /// �ˬd�O�_�䴩���w�������
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
        /// �^�ǩҦ��� FHIR R4 �귽�����C��A�P SupportsResourceType ��k�O�����@�P
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
        /// �^�ǩҦ��� FHIR R4 ��������C��A�P SupportsDataType ��k�O�����@�P
        /// </remarks>
        public IEnumerable<string> GetSupportedDataTypes()
        {
            return SupportedDataTypes.OrderBy(x => x).ToList();
        }

        /// <summary>
        /// ���o�귽�����`�ƶq
        /// </summary>
        /// <returns>�䴩���귽�����ƶq</returns>
        public int GetResourceTypeCount()
        {
            return SupportedResourceTypes.Count;
        }

        /// <summary>
        /// ���o��������`�ƶq  
        /// </summary>
        /// <returns>�䴩����������ƶq</returns>
        public int GetDataTypeCount()
        {
            return SupportedDataTypes.Count;
        }

        /// <summary>
        /// ���Ҹ귽�O�_�ŦX FHIR R4 �W�d
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G</returns>
        public ValidationResult ValidateResource(object resource)
        {
            // R4 �S�w�������޿�
            var results = new List<ValidationResult>();
            
            // �򥻵��c����
            results.AddRange(ValidateStructure(resource));
            
            // R4 �S�w�y�N����
            results.AddRange(ValidateR4Semantics(resource));
            
            // R4 �~�ȳW�h����
            results.AddRange(ValidateR4BusinessRules(resource));
            
            // �p�G��������~�A�^�ǥ��ѵ��G
            if (results.Any(r => !r.IsValid))
            {
                var errorMessages = results.Where(r => !r.IsValid).SelectMany(r => r.Messages).ToList();
                return new ValidationResult(false, errorMessages, "R4Validation");
            }

            return ValidationResult.Success();
        }

        /// <summary>
        /// ���� R4 �귽���c
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G�C��</returns>
        private IEnumerable<ValidationResult> ValidateStructure(object resource)
        {
            // R4 ���c�����޿�
            var results = new List<ValidationResult>();
            
            if (resource == null)
            {
                results.Add(ValidationResult.Error("�귽���ର null", "Resource"));
            }
            
            return results;
        }

        /// <summary>
        /// ���� R4 �y�N�W�h
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G�C��</returns>
        private IEnumerable<ValidationResult> ValidateR4Semantics(object resource)
        {
            // R4 �y�N�����޿�
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// ���� R4 �~�ȳW�h
        /// </summary>
        /// <param name="resource">�n���Ҫ��귽</param>
        /// <returns>���ҵ��G�C��</returns>
        private IEnumerable<ValidationResult> ValidateR4BusinessRules(object resource)
        {
            // R4 �~�ȳW�h�����޿�
            return Enumerable.Empty<ValidationResult>();
        }

        /// <summary>
        /// ���o�����ԲӺK�n
        /// </summary>
        /// <returns>�����ԲӦr��</returns>
        public override string ToString()
        {
            return $"FHIR R4 (v{Version}) - Resources: {GetResourceTypeCount()}, DataTypes: {GetDataTypeCount()}";
        }
    }
}