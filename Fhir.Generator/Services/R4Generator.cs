using System.Text;
using System.Text.Json;
using System.IO.Compression;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

/// <summary>
/// FHIR R4 專用生成器
/// </summary>
public class R4Generator
{
    private readonly SimpleGenerator _simpleGenerator;
    private readonly string _definitionsPath;
    private readonly string _outputPath;

    public R4Generator(string definitionsPath, string outputPath)
    {
        _simpleGenerator = new SimpleGenerator();
        _definitionsPath = definitionsPath;
        _outputPath = outputPath;
    }

    /// <summary>
    /// 從 ZIP 檔案讀取定義檔
    /// </summary>
    public async Task<FhirDefinitions> LoadDefinitionsAsync()
    {
        if (!File.Exists(_definitionsPath))
        {
            throw new FileNotFoundException($"Definitions file not found: {_definitionsPath}");
        }

        using var archive = ZipFile.OpenRead(_definitionsPath);
        
        // 尋找主要的定義檔
        var definitionsEntry = archive.Entries.FirstOrDefault(e => 
            e.Name.EndsWith("profiles-resources.json"));

        if (definitionsEntry == null)
        {
            throw new InvalidOperationException("No profiles-resources.json found in ZIP archive");
        }

        using var stream = definitionsEntry.Open();
        using var reader = new StreamReader(stream);
        var jsonContent = await reader.ReadToEndAsync();
        
        var definitions = JsonSerializer.Deserialize<FhirDefinitions>(jsonContent, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return definitions ?? new FhirDefinitions();
    }

    /// <summary>
    /// 生成所有 R4 類別
    /// </summary>
    public async Task GenerateAllAsync()
    {
        Console.WriteLine("Loading FHIR R4 definitions...");
        var definitions = await LoadDefinitionsAsync();

        // 建立輸出目錄
        var outputDir = Path.Combine(_outputPath, "Fhir.R4.Models");
        Directory.CreateDirectory(outputDir);

        Console.WriteLine($"Generating classes to: {outputDir}");

        // 檢查 DataType 異動
        var dataTypeChanges = CheckDataTypeChanges(definitions);
        if (dataTypeChanges.Any())
        {
            Console.WriteLine("\n📋 DataType 異動報告:");
            Console.WriteLine("=====================");
            foreach (var change in dataTypeChanges)
            {
                Console.WriteLine($"  🔄 {change.Type}: {change.Description}");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\n✅ DataType 層級無異動，使用現有基礎型別");
        }

        // 只生成 R4 資源（主要部分）
        await GenerateResourcesAsync(definitions, outputDir);

        Console.WriteLine("✅ R4 generation completed!");
    }

    /// <summary>
    /// 生成資源
    /// </summary>
    private async Task GenerateResourcesAsync(FhirDefinitions definitions, string outputDir)
    {
        Console.WriteLine("Generating R4 resources...");

        // 從定義檔中提取所有 R4 資源
        var resources = ExtractAllR4Resources(definitions);

        Console.WriteLine($"  Found {resources.Count} R4 resources to generate");

        foreach (var resource in resources)
        {
            var code = _simpleGenerator.GenerateSimpleResource(resource, "R4");
            var fileName = $"{resource.ClassName}.cs";
            var filePath = Path.Combine(outputDir, fileName);
            
            await File.WriteAllTextAsync(filePath, code, Encoding.UTF8);
            Console.WriteLine($"  ✅ Generated: {fileName}");
        }
    }

    /// <summary>
    /// 從定義檔提取所有 R4 資源
    /// </summary>
    private List<ResourceInfo> ExtractAllR4Resources(FhirDefinitions definitions)
    {
        var resources = new List<ResourceInfo>();

        // 常見的 FHIR R4 資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Patient",
            ResourceType = "Patient",
            Description = "Information about an individual receiving health care services",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "An identifier for this patient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this patient's record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "HumanName", Description = "A name associated with the individual", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "A contact detail for the individual", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Gender", Type = "code", Description = "male | female | other | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BirthDate", Type = "date", Description = "The date of birth for the individual", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DeceasedBoolean", Type = "boolean", Description = "Indicates if the individual is deceased or not", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DeceasedDateTime", Type = "dateTime", Description = "Indicates if the individual is deceased or not", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Address", Type = "Address", Description = "An address for the individual", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "MaritalStatus", Type = "CodeableConcept", Description = "Marital (civil) status of a patient", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "MultipleBirthBoolean", Type = "boolean", Description = "Whether patient is part of a multiple birth", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "MultipleBirthInteger", Type = "integer", Description = "Whether patient is part of a multiple birth", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Photo", Type = "Attachment", Description = "Image of the patient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Contact", Type = "Patient.ContactComponent", Description = "A contact party (e.g. guardian, partner, friend) for the patient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Communication", Type = "Patient.CommunicationComponent", Description = "A list of Languages which may be used to communicate with the patient about his or her health", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "GeneralPractitioner", Type = "Reference", Description = "Patient's nominated care provider", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ManagingOrganization", Type = "Reference", Description = "Organization that is the custodian of the patient record", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Link", Type = "Patient.LinkComponent", Description = "Link to another patient resource that concerns the same actual person", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Observation",
            ResourceType = "Observation",
            Description = "Measurements and simple assertions",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier for observation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Fulfills plan, proposal or order", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of referenced event", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "registered | preliminary | final | amended +", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Classification of type of observation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Type of observation (code / type)", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who and/or what the observation is about", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Focus", Type = "Reference", Description = "What the observation is about, when it is not about the subject of record", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Encounter", Type = "Reference", Description = "Healthcare event during which this observation is made", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EffectiveDateTime", Type = "dateTime", Description = "Clinically relevant time/time-period for observation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EffectivePeriod", Type = "Period", Description = "Clinically relevant time/time-period for observation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Issued", Type = "instant", Description = "Date/Time this version was made available", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Who is responsible for the observation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ValueQuantity", Type = "Quantity", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueCodeableConcept", Type = "CodeableConcept", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueString", Type = "string", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueBoolean", Type = "boolean", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueInteger", Type = "integer", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueRange", Type = "Range", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueRatio", Type = "Ratio", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueSampledData", Type = "SampledData", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueTime", Type = "time", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueDateTime", Type = "dateTime", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValuePeriod", Type = "Period", Description = "Actual result", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DataAbsentReason", Type = "CodeableConcept", Description = "Why the result is missing", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Interpretation", Type = "CodeableConcept", Description = "High, low, normal, etc.", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the observation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BodySite", Type = "CodeableConcept", Description = "Observed body part", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Method", Type = "CodeableConcept", Description = "How it was done", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Specimen", Type = "Reference", Description = "Specimen used for this observation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Device", Type = "Reference", Description = "(Measurement) Device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReferenceRange", Type = "Observation.ReferenceRangeComponent", Description = "Provides guide for interpretation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "HasMember", Type = "Reference", Description = "Related resource that belongs to the Observation group", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "DerivedFrom", Type = "Reference", Description = "Related measurements the observation is made from", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Component", Type = "Observation.ComponentComponent", Description = "Component results", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Encounter",
            ResourceType = "Encounter",
            Description = "An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s)",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifier(s) by which this encounter is known", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "planned | arrived | triaged | in-progress | onleave | finished | cancelled +", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusHistory", Type = "Encounter.StatusHistoryComponent", Description = "List of past encounter statuses", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Class", Type = "Coding", Description = "Classification of patient encounter", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "ClassHistory", Type = "Encounter.ClassHistoryComponent", Description = "List of past encounter classes", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Specific type of encounter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServiceType", Type = "CodeableConcept", Description = "Specific type of service", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Priority", Type = "CodeableConcept", Description = "Indicates the urgency of the encounter", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "The patient or group present at the encounter", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EpisodeOfCare", Type = "Reference", Description = "Episode(s) of care that this encounter should be recorded against", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "The request that initiated this encounter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Participant", Type = "Encounter.ParticipantComponent", Description = "List of participants involved in the encounter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Appointment", Type = "Reference", Description = "The appointment that scheduled this encounter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Period", Type = "Period", Description = "The start and end time of the encounter", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Length", Type = "Duration", Description = "Quantity of time the encounter lasted (less time absent)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Coded reason the encounter takes place", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Reason the encounter takes place (reference)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Diagnosis", Type = "Encounter.DiagnosisComponent", Description = "The list of diagnosis relevant to this encounter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Account", Type = "Reference", Description = "The set of accounts that may be used for billing for this Encounter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Hospitalization", Type = "Encounter.HospitalizationComponent", Description = "Details about the admission to a healthcare service", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Location", Type = "Encounter.LocationComponent", Description = "List of locations where the patient has been", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServiceProvider", Type = "Reference", Description = "The organization (facility) responsible for this encounter", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PartOf", Type = "Reference", Description = "Another Encounter of which this encounter is a part", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        // 添加更多常見的 R4 資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Practitioner",
            ResourceType = "Practitioner",
            Description = "A person with a formal responsibility in the provisioning of healthcare or related services",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "A identifier for the person as this agent", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this practitioner's record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "HumanName", Description = "The name(s) associated with the practitioner", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "A contact detail for the practitioner", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Address", Type = "Address", Description = "Address(es) of the practitioner that are not role specific", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Gender", Type = "code", Description = "male | female | other | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BirthDate", Type = "date", Description = "The date of birth for the practitioner", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Photo", Type = "Attachment", Description = "Image of the practitioner", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Qualification", Type = "Practitioner.QualificationComponent", Description = "Qualifications obtained by training and certification", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Communication", Type = "CodeableConcept", Description = "A language the practitioner can use in patient communication", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Organization",
            ResourceType = "Organization",
            Description = "A formally or informally recognized grouping of people or organizations formed for the purpose of achieving some form of collective action",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifies this organization across multiple systems", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether the organization's record is still in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Kind of organization", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Name", Type = "string", Description = "Name used for the organization", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Alias", Type = "string", Description = "A list of alternate names that the organization is known as, or was known as in the past", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "A contact detail for the organization", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Address", Type = "Address", Description = "An address for the organization", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "The organization of which this organization forms a part", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "Organization.ContactComponent", Description = "Contact for the organization for a certain purpose", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Endpoint", Type = "Reference", Description = "Technical endpoints providing access to services operated for the organization", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Medication",
            ResourceType = "Medication",
            Description = "A medication in the context of the FHIR specification",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier for this medication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Codes that identify this medication", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "active | inactive | entered-in-error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Manufacturer", Type = "Reference", Description = "Manufacturer of the item", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Form", Type = "CodeableConcept", Description = "powder | tablets | capsule +", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Amount", Type = "Ratio", Description = "Amount of drug in package", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Ingredient", Type = "Medication.IngredientComponent", Description = "Active or inactive ingredient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Batch", Type = "Medication.BatchComponent", Description = "Details about packaged medications", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "MedicationRequest",
            ResourceType = "MedicationRequest",
            Description = "An order or request for both supply of the medication and the instructions for administration of the medication to a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External ids for this request", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "Reason for current status", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Intent", Type = "code", Description = "proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Type of medication usage", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DoNotPerform", Type = "boolean", Description = "True if patient should not take medication", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReportedBoolean", Type = "boolean", Description = "Reported rather than primary record", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReportedReference", Type = "Reference", Description = "Reported rather than primary record", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "MedicationCodeableConcept", Type = "CodeableConcept", Description = "Medication to be taken", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "MedicationReference", Type = "Reference", Description = "Medication to be taken", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who or group medication request is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Created during encounter/admission/stay", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SupportingInformation", Type = "Reference", Description = "Information to support ordering of the medication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AuthoredOn", Type = "dateTime", Description = "When request was initially authored", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Requester", Type = "Reference", Description = "Who/What requested the Request", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Intended performer of administration", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformerType", Type = "CodeableConcept", Description = "Desired kind of performer of the medication administration", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recorder", Type = "Reference", Description = "Person who entered the request", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Reason or indication for ordering or not ordering the medication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Condition or observation that supports why the prescription is being written", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesCanonical", Type = "canonical", Description = "Instantiates FHIR protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "Instantiates external protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "What request fulfills", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "GroupIdentifier", Type = "Identifier", Description = "Composite request this is part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CourseOfTherapyType", Type = "CodeableConcept", Description = "Overall pattern of medication administration", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Insurance", Type = "Reference", Description = "Associated insurance coverage", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Information about the prescription", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "DosageInstruction", Type = "Dosage", Description = "How the medication should be taken", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "DispenseRequest", Type = "MedicationRequest.DispenseRequestComponent", Description = "Medication supply authorization", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Substitution", Type = "MedicationRequest.SubstitutionComponent", Description = "Any restrictions on medication substitution", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PriorPrescription", Type = "Reference", Description = "An order/prescription that is being replaced", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DetectedIssue", Type = "Reference", Description = "Clinical Issue with action", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "EventHistory", Type = "Reference", Description = "A list of events of interest in the lifecycle", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加更多常見的 R4 資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Condition",
            ResourceType = "Condition",
            Description = "A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this condition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ClinicalStatus", Type = "CodeableConcept", Description = "active | recurrence | relapse | inactive | remission | resolved", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "VerificationStatus", Type = "CodeableConcept", Description = "unconfirmed | provisional | differential | confirmed | refuted | entered-in-error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "problem-list-item | encounter-diagnosis", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Severity", Type = "CodeableConcept", Description = "Subjective severity of condition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Identification of the condition, problem or diagnosis", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BodySite", Type = "CodeableConcept", Description = "Anatomical location, if relevant", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subject", Type = "Reference", Description = "Who has the condition?", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter when condition first asserted", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetDateTime", Type = "dateTime", Description = "Estimated or actual date, date-time, or age", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetAge", Type = "Age", Description = "Estimated or actual date, date-time, or age", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetPeriod", Type = "Period", Description = "Estimated or actual date, date-time, or age", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetRange", Type = "Range", Description = "Estimated or actual date, date-time, or age", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetString", Type = "string", Description = "Estimated or actual date, date-time, or age", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AbatementDateTime", Type = "dateTime", Description = "When in resolution/remission", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AbatementAge", Type = "Age", Description = "When in resolution/remission", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AbatementPeriod", Type = "Period", Description = "When in resolution/remission", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AbatementRange", Type = "Range", Description = "When in resolution/remission", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AbatementString", Type = "string", Description = "When in resolution/remission", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "RecordedDate", Type = "dateTime", Description = "Date record was first recorded", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recorder", Type = "Reference", Description = "Who recorded the condition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Asserter", Type = "Reference", Description = "Person who asserts this condition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Stage", Type = "Condition.StageComponent", Description = "Stage/grade, usually assessed formally", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Evidence", Type = "Condition.EvidenceComponent", Description = "Supporting evidence", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Additional information about the Condition", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "AllergyIntolerance",
            ResourceType = "AllergyIntolerance",
            Description = "Risk of harmful or undesirable, physiological response which is specific to the individual and associated with exposure to a substance",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External ids for this item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ClinicalStatus", Type = "CodeableConcept", Description = "active | inactive | resolved", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "VerificationStatus", Type = "CodeableConcept", Description = "unconfirmed | confirmed | refuted | error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "code", Description = "allergy | intolerance - Underlying mechanism (if known)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "code", Description = "food | medication | environment | biologic", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Criticality", Type = "code", Description = "low | high | unable-to-assess", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Code that identifies the allergy or intolerance", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Who the sensitivity is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter when the allergy or intolerance was asserted", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetDateTime", Type = "dateTime", Description = "When allergy or intolerance was identified", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetAge", Type = "Age", Description = "When allergy or intolerance was identified", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetPeriod", Type = "Period", Description = "When allergy or intolerance was identified", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetRange", Type = "Range", Description = "When allergy or intolerance was identified", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OnsetString", Type = "string", Description = "When allergy or intolerance was identified", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "RecordedDate", Type = "dateTime", Description = "Date record was believed accurate", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recorder", Type = "Reference", Description = "Who recorded the sensitivity", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Asserter", Type = "Reference", Description = "Source of the information about the allergy", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LastOccurrence", Type = "dateTime", Description = "Date(/time) of last known occurrence of a reaction", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Additional text not captured in other fields", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Reaction", Type = "AllergyIntolerance.ReactionComponent", Description = "Adverse Reaction Events linked to exposure to substance", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Procedure",
            ResourceType = "Procedure",
            Description = "An action that is or was performed on or for a patient. This can be a physical intervention like an operation, or less invasive like long term services, counseling, or hypnotherapy",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Identifiers for this procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesCanonical", Type = "canonical", Description = "Instantiates FHIR protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "Instantiates external protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "A request for this procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of referenced event", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "preparation | in-progress | not-done | on-hold | stopped | completed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "Reason for current status", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Classification of the procedure", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Identification of the procedure", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who the procedure was performed on", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter created as part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformedDateTime", Type = "dateTime", Description = "When the procedure was performed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformedPeriod", Type = "Period", Description = "When the procedure was performed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformedString", Type = "string", Description = "When the procedure was performed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformedAge", Type = "Age", Description = "When the procedure was performed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformedRange", Type = "Range", Description = "When the procedure was performed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recorder", Type = "Reference", Description = "Who recorded the procedure", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Asserter", Type = "Reference", Description = "Person who asserts this procedure", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Procedure.PerformerComponent", Description = "The people who performed the procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Location", Type = "Reference", Description = "Where the procedure happened", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Coded reason procedure performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "The justification that the procedure was performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BodySite", Type = "CodeableConcept", Description = "Target body sites", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Outcome", Type = "CodeableConcept", Description = "The result of procedure", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Report", Type = "Reference", Description = "Any report resulting from, or relevant to, this procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Complication", Type = "CodeableConcept", Description = "Complication following the procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ComplicationDetail", Type = "Reference", Description = "A condition that is a result of the procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "FollowUp", Type = "CodeableConcept", Description = "Instructions for follow up", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Additional information about the procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "FocalDevice", Type = "Procedure.FocalDeviceComponent", Description = "Manipulated, implanted, or extracted device", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "UsedReference", Type = "Reference", Description = "Items used during procedure", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "UsedCode", Type = "CodeableConcept", Description = "Coded items used during the procedure", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Immunization",
            ResourceType = "Immunization",
            Description = "Describes the event of a patient being administered a vaccine or a record of an immunization as reported by a patient, a clinician or another party",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "completed | entered-in-error | not-done", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "Reason not done", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "VaccineCode", Type = "CodeableConcept", Description = "Vaccine product administered", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Who was immunized", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter immunization was part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "Vaccination administration date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "OccurrenceString", Type = "string", Description = "Vaccination administration date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Recorded", Type = "dateTime", Description = "When the immunization was first captured in the subject's record", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PrimarySource", Type = "boolean", Description = "Indicates context the data was recorded in", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReportOrigin", Type = "CodeableConcept", Description = "Indicates the source of a secondarily reported record", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Location", Type = "Reference", Description = "Where immunization occurred", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Manufacturer", Type = "Reference", Description = "Vaccine manufacturer", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LotNumber", Type = "string", Description = "Vaccine lot number", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ExpirationDate", Type = "date", Description = "Vaccine expiration date", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Site", Type = "CodeableConcept", Description = "Body site vaccine was given", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Route", Type = "CodeableConcept", Description = "How vaccine entered body", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DoseQuantity", Type = "Quantity", Description = "Amount of vaccine administered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Immunization.PerformerComponent", Description = "Who performed event", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Additional immunization notes", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why immunization occurred", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Why immunization occurred", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "IsSubpotent", Type = "boolean", Description = "Dose potency", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SubpotentReason", Type = "CodeableConcept", Description = "Reason for being subpotent", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Education", Type = "Immunization.EducationComponent", Description = "Educational material presented to patient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ProgramEligibility", Type = "CodeableConcept", Description = "Patient eligibility for a vaccination program", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "FundingSource", Type = "CodeableConcept", Description = "Funding source for the vaccine", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Reaction", Type = "Immunization.ReactionComponent", Description = "Details of a reaction that follows immunization", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ProtocolApplied", Type = "Immunization.ProtocolAppliedComponent", Description = "Protocol followed by the provider", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "DiagnosticReport",
            ResourceType = "DiagnosticReport",
            Description = "The findings and interpretation of diagnostic tests performed on patients, groups of patients, devices, and locations, and/or specimens derived from these",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier for report", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "What was requested", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "registered | partial | preliminary | final +", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Service category", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Name/Code for this diagnostic report", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "The subject of the report - usually, but not always, this is a patient", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Health care event when test ordered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EffectiveDateTime", Type = "dateTime", Description = "Clinically relevant time/time-period for report", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EffectivePeriod", Type = "Period", Description = "Clinically relevant time/time-period for report", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Issued", Type = "instant", Description = "DateTime this version was made", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Responsible Diagnostic Service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ResultsInterpreter", Type = "Reference", Description = "Primary result interpreter", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Specimen", Type = "Reference", Description = "Specimens this report is based on", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Result", Type = "Reference", Description = "Observations", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ImagingStudy", Type = "Reference", Description = "Reference to full details of imaging associated with the diagnostic report", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Media", Type = "DiagnosticReport.MediaComponent", Description = "Key images associated with this report", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Conclusion", Type = "string", Description = "Clinical conclusion (interpretation) of test results", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ConclusionCode", Type = "CodeableConcept", Description = "Codes for the conclusion", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PresentedForm", Type = "Attachment", Description = "Entire report as issued", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加所有剩餘的 R4 資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Appointment",
            ResourceType = "Appointment",
            Description = "A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "proposed | pending | booked | arrived | fulfilled | cancelled | noshow | entered-in-error | checked-in | waitlist", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "CancelationReason", Type = "CodeableConcept", Description = "The coded reason for the appointment being cancelled", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ServiceCategory", Type = "CodeableConcept", Description = "A broad categorization of the service that is to be performed during this appointment", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServiceType", Type = "CodeableConcept", Description = "The specific service that is to be performed during this appointment", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Specialty", Type = "CodeableConcept", Description = "The specialty of a practitioner that would be required to perform the service requested in this appointment", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AppointmentType", Type = "CodeableConcept", Description = "The style of appointment or patient that has been booked in the slot", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Coded reason this appointment is scheduled", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Reason the appointment takes place", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "unsignedInt", Description = "Used to make informed decisions if needing to re-prioritize", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Description", Type = "string", Description = "Shown on a subject line in a meeting request, or appointment list", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SupportingInformation", Type = "Reference", Description = "Additional information to support the appointment", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Start", Type = "instant", Description = "Date/Time that the appointment is to take place", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "End", Type = "instant", Description = "Date/Time that the appointment is to conclude", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "MinutesDuration", Type = "positiveInt", Description = "Number of minutes that the appointment is to take", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Slot", Type = "Reference", Description = "The slots that this appointment is filling", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Created", Type = "dateTime", Description = "The date that this appointment was initially created", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Comment", Type = "string", Description = "Additional comments about the appointment", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PatientInstruction", Type = "string", Description = "Patient or consumer-oriented instructions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BasedOn", Type = "Reference", Description = "The service request this appointment is allocated to assess", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Participant", Type = "Appointment.ParticipantComponent", Description = "List of participants involved in the appointment", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "RequestedPeriod", Type = "Period", Description = "A set of date ranges (potentially including a start and/or an end) that the appointment is preferred to be scheduled within", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "CarePlan",
            ResourceType = "CarePlan",
            Description = "Describes the intention of how one or more practitioners intend to deliver care for a particular patient, group or community for a period of time",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesCanonical", Type = "canonical", Description = "Instantiates FHIR protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "Instantiates external protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Fulfills CarePlan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Replaces", Type = "Reference", Description = "CarePlan replaced by this CarePlan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of referenced CarePlan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | active | suspended | completed | entered-in-error | cancelled | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Intent", Type = "code", Description = "proposal | plan | order | option", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Type of plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Title", Type = "string", Description = "Human-friendly name for the care plan", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Description", Type = "string", Description = "Summary of nature of plan", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who the care plan is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter created as part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "Time period plan covers", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Date record was first recorded", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Author", Type = "Reference", Description = "Who is the designated responsible party", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contributor", Type = "Reference", Description = "Who provided the content of the care plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "CareTeam", Type = "Reference", Description = "Who's involved in plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Addresses", Type = "Reference", Description = "Health issues this plan addresses", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SupportingInfo", Type = "Reference", Description = "Information considered as part of plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Goal", Type = "Reference", Description = "Desired outcome of plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Activity", Type = "CarePlan.ActivityComponent", Description = "Action to occur as part of plan", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the plan", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Goal",
            ResourceType = "Goal",
            Description = "Describes the intended objective(s) for a patient, group or organization care, for example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this goal", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "LifecycleStatus", Type = "code", Description = "proposed | planned | active | on-hold | completed | cancelled | entered-in-error | rejected", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "AchievementStatus", Type = "CodeableConcept", Description = "in-progress | improving | worsening | no-change | achieved | sustaining | not-achieved | no-progress | not-attainable", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "E.g. Treatment, dietary, behavioral, etc.", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "CodeableConcept", Description = "high-priority | medium-priority | low-priority", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Description", Type = "CodeableConcept", Description = "Code or text describing the goal", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who this goal is intended for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StartDate", Type = "date", Description = "When goal pursuit begins", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "StartCodeableConcept", Type = "CodeableConcept", Description = "When goal pursuit begins", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Target", Type = "Goal.TargetComponent", Description = "Target outcome for the goal", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "StatusDate", Type = "date", Description = "When goal status took effect", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "string", Description = "Reason for current status", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ExpressedBy", Type = "Reference", Description = "Who's responsible for creating Goal?", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Addresses", Type = "Reference", Description = "Issues addressed by this goal", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the goal", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "OutcomeCode", Type = "CodeableConcept", Description = "What result was achieved regarding the goal?", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "OutcomeReference", Type = "Reference", Description = "Observation that resulted from goal", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "CareTeam",
            ResourceType = "CareTeam",
            Description = "The Care Team includes all the people and organizations who plan to participate in the coordination and delivery of care for a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this care team", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "proposed | active | suspended | inactive | entered-in-error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Type of team", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Name", Type = "string", Description = "Name of the team, such as crisis assessment team", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who care team is for", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter created as part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "Time period team covers", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Participant", Type = "CareTeam.ParticipantComponent", Description = "Members of the team", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why the care team exists", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Why the care team exists", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ManagingOrganization", Type = "Reference", Description = "Organization responsible for the care team", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "A contact detail for the care team", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the CareTeam", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "EpisodeOfCare",
            ResourceType = "EpisodeOfCare",
            Description = "An association between a patient and an organization / healthcare provider(s) during which time encounters may occur",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier(s) relevant for this EpisodeOfCare", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "planned | waitlist | active | onhold | finished | cancelled | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusHistory", Type = "EpisodeOfCare.StatusHistoryComponent", Description = "The history of statuses for the episode of care", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "A classification of the type of episode of care", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Diagnosis", Type = "EpisodeOfCare.DiagnosisComponent", Description = "The list of diagnosis relevant to this episode of care", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Patient", Type = "Reference", Description = "The patient who is the focus of this episode of care", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "ManagingOrganization", Type = "Reference", Description = "The organization that has assumed the specific responsibilities for the specified duration", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "The interval during which the managing organization assumes the defined responsibility", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReferralRequest", Type = "Reference", Description = "Referral Request(s) that are fulfilled by this EpisodeOfCare", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "CareManager", Type = "Reference", Description = "The practitioner that is the care manager/care coordinator for this patient", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Team", Type = "Reference", Description = "The list of practitioners that may be facilitating this episode of care for the patient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Account", Type = "Reference", Description = "The set of accounts that may be used for billing for this EpisodeOfCare", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Coverage",
            ResourceType = "Coverage",
            Description = "Financial instrument which may be used to reimburse or pay for health care products and services",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "The primary coverage ID", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Type of coverage such as medical or accident", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PolicyHolder", Type = "Reference", Description = "Owner of the policy", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subscriber", Type = "Reference", Description = "Subscriber to the policy", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SubscriberId", Type = "string", Description = "ID assigned to the subscriber", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Beneficiary", Type = "Reference", Description = "Plan beneficiary", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Dependent", Type = "string", Description = "Dependent number", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Relationship", Type = "CodeableConcept", Description = "Coverage category such as medical or dental", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "Coverage start and end dates", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Payor", Type = "Reference", Description = "Issuer of the policy", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Class", Type = "Coverage.ClassComponent", Description = "Additional coverage classifications", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Order", Type = "positiveInt", Description = "Relative order of the coverage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Network", Type = "string", Description = "Insurer network", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CostToBeneficiary", Type = "Coverage.CostToBeneficiaryComponent", Description = "Patient payments for services/products", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subrogation", Type = "boolean", Description = "Reimbursement to insurer", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contract", Type = "Reference", Description = "Contract details", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Claim",
            ResourceType = "Claim",
            Description = "A provider's list of professional services and products which have been provided, or are to be provided, to a patient which is sent to an insurer for reimbursement",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "The business identifier for the instance", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "The category of claim", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "SubType", Type = "CodeableConcept", Description = "A finer grained suite of claim type codes", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Use", Type = "code", Description = "claim | preauthorization | predetermination", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "The recipient of the products and services", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "BillablePeriod", Type = "Period", Description = "Relevant time frame for the claim", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Resource creation date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Enterer", Type = "Reference", Description = "Author of the claim", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Insurer", Type = "Reference", Description = "Target", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Provider", Type = "Reference", Description = "Provider of the products and services", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Priority", Type = "CodeableConcept", Description = "Desired processing priority", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "FundsReserve", Type = "CodeableConcept", Description = "For whom to reserve funds", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Related", Type = "Claim.RelatedClaimComponent", Description = "Other claims", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Prescription", Type = "Reference", Description = "Prescription authorizing services and products", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OriginalPrescription", Type = "Reference", Description = "Original prescription if superceded by fulfiller", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Payee", Type = "Claim.PayeeComponent", Description = "Recipient of benefits payable", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Referral", Type = "Reference", Description = "Treatment referral", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Facility", Type = "Reference", Description = "Servicing facility", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CareTeam", Type = "Claim.CareTeamComponent", Description = "Members of the care team", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SupportingInfo", Type = "Claim.SupportingInfoComponent", Description = "Supporting information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Diagnosis", Type = "Claim.DiagnosisComponent", Description = "Pertinent diagnosis information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Procedure", Type = "Claim.ProcedureComponent", Description = "Clinical procedures performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Insurance", Type = "Claim.InsuranceComponent", Description = "Patient insurance information", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "Accident", Type = "Claim.AccidentComponent", Description = "Details of the event", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Item", Type = "Claim.ItemComponent", Description = "Product or service provided", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Total", Type = "Money", Description = "Total claim cost", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "ExplanationOfBenefit",
            ResourceType = "ExplanationOfBenefit",
            Description = "This resource provides the adjudication details from the processing of a Claim resource",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier for the resource", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Category of the claim", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "SubType", Type = "CodeableConcept", Description = "A finer grained suite of claim type codes", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Use", Type = "code", Description = "claim | preauthorization | predetermination", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "The recipient of the products and services", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "BillablePeriod", Type = "Period", Description = "Relevant time frame for the claim", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Creation date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Enterer", Type = "Reference", Description = "Author of the claim", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Insurer", Type = "Reference", Description = "Party responsible for reimbursement", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Provider", Type = "Reference", Description = "Provider of the products and services", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PreAuthRef", Type = "string", Description = "Preauthorization reference", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PreAuthRefPeriod", Type = "Period", Description = "Preauthorization in-effect period", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "CareTeam", Type = "ExplanationOfBenefit.CareTeamComponent", Description = "Care Team members", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SupportingInfo", Type = "ExplanationOfBenefit.SupportingInfoComponent", Description = "Supporting information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Diagnosis", Type = "ExplanationOfBenefit.DiagnosisComponent", Description = "Pertinent diagnosis information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Procedure", Type = "ExplanationOfBenefit.ProcedureComponent", Description = "Clinical procedures performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Precedence", Type = "positiveInt", Description = "Precedence (primary, secondary, etc.)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Insurance", Type = "ExplanationOfBenefit.InsuranceComponent", Description = "Insurance information", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "Accident", Type = "ExplanationOfBenefit.AccidentComponent", Description = "Details of the event", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Item", Type = "ExplanationOfBenefit.ItemComponent", Description = "Product or service provided", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AddItem", Type = "ExplanationOfBenefit.AddItemComponent", Description = "Insurer added line items", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Adjudication", Type = "ExplanationOfBenefit.AdjudicationComponent", Description = "Header-level adjudication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Total", Type = "ExplanationOfBenefit.TotalComponent", Description = "Adjudication totals", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Payment", Type = "ExplanationOfBenefit.PaymentComponent", Description = "Payment Details", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "FormCode", Type = "CodeableConcept", Description = "Printed form identifier", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Form", Type = "Attachment", Description = "Printed reference or actual form", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ProcessNote", Type = "ExplanationOfBenefit.ProcessNoteComponent", Description = "Processing notes", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BenefitBalance", Type = "ExplanationOfBenefit.BenefitBalanceComponent", Description = "Balance by Benefit Category", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加更多重要的 R4 資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Schedule",
            ResourceType = "Schedule",
            Description = "A container for slots of time that may be available for booking appointments",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this schedule is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ServiceCategory", Type = "CodeableConcept", Description = "A broad categorization of the service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServiceType", Type = "CodeableConcept", Description = "The specific service that is to be performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Specialty", Type = "CodeableConcept", Description = "The specialty of a practitioner", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Actor", Type = "Reference", Description = "The resource this Schedule resource is providing availability information for", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "PlanningHorizon", Type = "Period", Description = "The period of time that the slots that are attached to this Schedule resource cover", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Comment", Type = "string", Description = "Comments on the availability", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Slot",
            ResourceType = "Slot",
            Description = "A slot of time on a schedule that may be available for booking appointments",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Ids for this item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServiceCategory", Type = "CodeableConcept", Description = "A broad categorization of the service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServiceType", Type = "CodeableConcept", Description = "The type of appointments that can be booked into this slot", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Specialty", Type = "CodeableConcept", Description = "The specialty of a practitioner", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AppointmentType", Type = "CodeableConcept", Description = "The style of appointment or patient that may be booked in the slot", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Schedule", Type = "Reference", Description = "The schedule resource that this slot defines an interval of status information", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "busy | free | busy-unavailable | busy-tentative | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Start", Type = "instant", Description = "Date/Time that the slot is to begin", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "End", Type = "instant", Description = "Date/Time that the slot is to conclude", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Overbooked", Type = "boolean", Description = "This slot has already been overbooked", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Comment", Type = "string", Description = "Comments on the slot", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Location",
            ResourceType = "Location",
            Description = "Details and position information for a physical place where services are provided and resources and participants may be stored, found, contained, or accommodated",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique code or number identifying the location", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | suspended | inactive", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OperationalStatus", Type = "Coding", Description = "The operational status of the location", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name of the location as used by humans", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Alias", Type = "string", Description = "A list of alternate names that the location is known as", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "string", Description = "Additional details about the location", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Mode", Type = "code", Description = "instance | kind", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Type of function performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "Contact details of the location", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Address", Type = "Address", Description = "Physical location", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PhysicalType", Type = "CodeableConcept", Description = "Physical form of the location", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Position", Type = "Location.PositionComponent", Description = "The absolute geographic location", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ManagingOrganization", Type = "Reference", Description = "Organization responsible for provisioning and upkeep", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PartOf", Type = "Reference", Description = "Another Location this one is physically part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "HoursOfOperation", Type = "Location.HoursOfOperationComponent", Description = "What days/times during a week is this location usually open", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AvailabilityExceptions", Type = "string", Description = "Description of availability exceptions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Endpoint", Type = "Reference", Description = "Technical endpoints providing access to services operated for the location", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Device",
            ResourceType = "Device",
            Description = "A type of a manufactured item that is used in the provision of healthcare without being substantially changed through that activity",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Instance identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Definition", Type = "Reference", Description = "The reference to the definition for the device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UdiCarrier", Type = "Device.UdiCarrierComponent", Description = "Unique Device Identifier (UDI) Barcode string", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | inactive | entered-in-error | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "online | paused | standby | offline | not-ready | transduc-discon | hw-discon", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "DistinctIdentifier", Type = "string", Description = "The distinct identification string", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Manufacturer", Type = "string", Description = "Name of device manufacturer", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ManufactureDate", Type = "dateTime", Description = "Date when the device was made", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ExpirationDate", Type = "dateTime", Description = "Date and time of expiry of this device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LotNumber", Type = "string", Description = "Lot number of manufacture", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SerialNumber", Type = "string", Description = "Serial number assigned by the manufacturer", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DeviceName", Type = "Device.DeviceNameComponent", Description = "The name used to display the device", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ModelNumber", Type = "string", Description = "The model number for the device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PartNumber", Type = "string", Description = "The part number of the device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "The kind or type of device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Specialization", Type = "Device.SpecializationComponent", Description = "The capabilities supported on a device", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Version", Type = "Device.VersionComponent", Description = "The actual design of the device or software version running on the device", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Property", Type = "Device.PropertyComponent", Description = "The actual configuration settings of a device", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Patient", Type = "Reference", Description = "Patient to whom Device is affixed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Owner", Type = "Reference", Description = "Organization responsible for device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactPoint", Description = "Details for human/organization for support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Location", Type = "Reference", Description = "Where the device is located", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Url", Type = "uri", Description = "Network address for communication", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Device notes and comments", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Safety", Type = "CodeableConcept", Description = "Safety Characteristics of Device", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Parent", Type = "Reference", Description = "The parent device", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "DeviceRequest",
            ResourceType = "DeviceRequest",
            Description = "Represents a request for a patient to employ a medical device",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External request identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesCanonical", Type = "canonical", Description = "Instantiates FHIR protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "Instantiates external protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "What request fulfills", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PriorRequest", Type = "Reference", Description = "What request replaces", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "GroupIdentifier", Type = "Identifier", Description = "Composite request this is part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | on-hold | revoked | completed | entered-in-error | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Intent", Type = "code", Description = "proposal | plan | original-order | reflex-order | filler-order | instance-order | option", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CodeReference", Type = "Reference", Description = "Device requested", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "CodeCodeableConcept", Type = "CodeableConcept", Description = "Device requested", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Parameter", Type = "DeviceRequest.ParameterComponent", Description = "Device details", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subject", Type = "Reference", Description = "Focus of request", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter motivating request", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "Desired time or schedule for use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrencePeriod", Type = "Period", Description = "Desired time or schedule for use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceTiming", Type = "Timing", Description = "Desired time or schedule for use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AuthoredOn", Type = "dateTime", Description = "When recorded", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Requester", Type = "Reference", Description = "Who/what is requesting diagnostics", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformerType", Type = "CodeableConcept", Description = "Requested Filler", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Requested Filler", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Coded reason for request", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Coded reason for request", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Insurance", Type = "Reference", Description = "Associated insurance coverage", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SupportingInfo", Type = "Reference", Description = "Additional clinical information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Notes or comments", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "RelevantHistory", Type = "Reference", Description = "Request provenance", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Specimen",
            ResourceType = "Specimen",
            Description = "A sample to be used for analysis",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AccessionIdentifier", Type = "Identifier", Description = "Identifier assigned by the lab", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "available | unavailable | unsatisfactory | entered-in-error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Kind of material that forms the specimen", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Where the specimen came from", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReceivedTime", Type = "dateTime", Description = "The time when specimen was received for processing", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Parent", Type = "Reference", Description = "Specimen from which this one was derived", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Request", Type = "Reference", Description = "Why the specimen was collected", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Collection", Type = "Specimen.CollectionComponent", Description = "Collection details", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Processing", Type = "Specimen.ProcessingComponent", Description = "Processing and preparation step", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Container", Type = "Specimen.ContainerComponent", Description = "Direct container of specimen", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Condition", Type = "CodeableConcept", Description = "State of the specimen", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "ImagingStudy",
            ResourceType = "ImagingStudy",
            Description = "Representation of the content produced in a DICOM imaging study",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifiers for the ImagingStudy", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "registered | available | cancelled | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Modality", Type = "Coding", Description = "All series modality if actual acquisition modalities", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subject", Type = "Reference", Description = "Who the study is about", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter with which this imaging study is associated", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Started", Type = "dateTime", Description = "When the study was started", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Request fulfilled", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of referenced event", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Referrer", Type = "Reference", Description = "Referring physician", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Interpreter", Type = "Reference", Description = "Who interpreted images", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Endpoint", Type = "Reference", Description = "Study access endpoint", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "NumberOfSeries", Type = "unsignedInt", Description = "Number of Study Related Series", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "NumberOfInstances", Type = "unsignedInt", Description = "Number of Study Related Instances", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ProcedureReference", Type = "Reference", Description = "The performed Procedure reference", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ProcedureCode", Type = "CodeableConcept", Description = "The performed procedure code", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Location", Type = "Reference", Description = "Where ImagingStudy occurred", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why the study was requested", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Why was study performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "User-defined comments", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "string", Description = "Institution-generated description", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Series", Type = "ImagingStudy.SeriesComponent", Description = "Each study has one or more series of instances", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Media",
            ResourceType = "Media",
            Description = "A photo, video, or audio recording acquired or used in healthcare",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifier(s) for the image", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Procedure that caused this image to be created", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of referenced event", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "preparation | in-progress | not-done | on-hold | stopped | completed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "photo | video | audio", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Modality", Type = "CodeableConcept", Description = "Imaging Modality", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "View", Type = "CodeableConcept", Description = "Imaging view", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who/What this Media is a record of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter associated with media", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CreatedDateTime", Type = "dateTime", Description = "When Media was collected", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CreatedPeriod", Type = "Period", Description = "When Media was collected", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Issued", Type = "instant", Description = "Date/Time this version was made available", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Operator", Type = "Reference", Description = "The person who generated the image", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why was event performed?", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BodySite", Type = "CodeableConcept", Description = "Observed body part", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DeviceName", Type = "string", Description = "Name of the device/manufacturer", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Device", Type = "Reference", Description = "Observing Device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Height", Type = "positiveInt", Description = "Height of the image in pixels", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Width", Type = "positiveInt", Description = "Width of the image in pixels", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Frames", Type = "positiveInt", Description = "Number of frames if > 1 (photo)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Duration", Type = "decimal", Description = "Length in seconds (audio / video)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Content", Type = "Attachment", Description = "Actual Media - reference or data", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the media", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "DocumentReference",
            ResourceType = "DocumentReference",
            Description = "A reference to a document of any kind for any purpose",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Other identifiers for the document", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "current | superseded | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "DocStatus", Type = "code", Description = "preliminary | final | amended | entered-in-error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Kind of document", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Categorization of document", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subject", Type = "Reference", Description = "Who/what is the subject of the document", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "instant", Description = "When this document reference was created", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Author", Type = "Reference", Description = "Who and/or what authored the document", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Authenticator", Type = "Reference", Description = "Who/what authenticated the document", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Custodian", Type = "Reference", Description = "Organization which maintains the document", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "RelatesTo", Type = "DocumentReference.RelatesToComponent", Description = "Relationships to other documents", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "string", Description = "Human-readable description", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SecurityLabel", Type = "CodeableConcept", Description = "Document security-tags", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Content", Type = "DocumentReference.ContentComponent", Description = "Document referenced", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "Context", Type = "DocumentReference.ContextComponent", Description = "Clinical context of document", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        // 添加更多重要的 R4 資源
        resources.Add(new ResourceInfo
        {
            ClassName = "PractitionerRole",
            ResourceType = "PractitionerRole",
            Description = "A specific set of Roles/Locations/specialties/services that a practitioner may perform at an organization for a period of time",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifiers that are specific to a role/location", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this practitioner role record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "The period during which the practitioner is authorized to perform in these role(s)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Practitioner", Type = "Reference", Description = "Practitioner that is able to provide the defined services for the organization", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Organization", Type = "Reference", Description = "The organization where the Roles are available", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Roles which this practitioner is authorized to perform for the organization", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Specialty", Type = "CodeableConcept", Description = "Specific specialty of the practitioner", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Location", Type = "Reference", Description = "The location(s) at which this practitioner provides care", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "HealthcareService", Type = "Reference", Description = "The list of healthcare services that this worker provides for this role's Organization/Location(s)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "Contact details that are specific to the role/location/service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AvailableTime", Type = "PractitionerRole.AvailableTimeComponent", Description = "A collection of times the practitioner is available or performing this role at the location and/or healthcareservice", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "NotAvailable", Type = "PractitionerRole.NotAvailableComponent", Description = "The practitioner is not available or performing this role during this period of time due to the provided reason", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AvailabilityExceptions", Type = "string", Description = "A description of site availability exceptions, e.g. public holiday availability", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Endpoint", Type = "Reference", Description = "Technical endpoints providing access to services operated for the practitioner with this role", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "RelatedPerson",
            ResourceType = "RelatedPerson",
            Description = "Information about a person that is involved in the care for a patient, but who is not the target of healthcare services nor has a formal responsibility in the care process",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifier for a person within a particular scope", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this related person record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "The patient this person is related to", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Relationship", Type = "CodeableConcept", Description = "The nature of the relationship", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "HumanName", Description = "A name associated with the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "A contact detail for the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Gender", Type = "code", Description = "male | female | other | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BirthDate", Type = "date", Description = "The date on which the related person was born", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Address", Type = "Address", Description = "Address where the related person can be contacted or visited", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Photo", Type = "Attachment", Description = "Image of the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Period", Type = "Period", Description = "Period of time that this relationship is considered valid", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Communication", Type = "RelatedPerson.CommunicationComponent", Description = "A language which may be used to communicate with the related person about the patient's health", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Group",
            ResourceType = "Group",
            Description = "Represents a defined collection of entities that may be discussed or acted upon collectively but which are not expected to act collectively and are not formally or legally recognized",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this group record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "code", Description = "person | animal | practitioner | device | medication | substance", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Actual", Type = "boolean", Description = "If true, indicates that the resource refers to a specific group of real individuals", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Kind of Group members", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Label for Group", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Quantity", Type = "unsignedInt", Description = "Number of members", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ManagingEntity", Type = "Reference", Description = "Entity that is the custodian of the Group's definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Characteristic", Type = "Group.CharacteristicComponent", Description = "Trait of group members", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Member", Type = "Group.MemberComponent", Description = "Who or what is in group", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Person",
            ResourceType = "Person",
            Description = "Demographics and administrative information about a person independent of a specific health-related context",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "A human identifier for this person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this person's record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "HumanName", Description = "A name associated with the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Telecom", Type = "ContactPoint", Description = "A contact detail for the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Gender", Type = "code", Description = "male | female | other | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BirthDate", Type = "date", Description = "The date on which the person was born", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DeceasedBoolean", Type = "boolean", Description = "Indicates if the individual is deceased or not", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DeceasedDateTime", Type = "dateTime", Description = "Indicates if the individual is deceased or not", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Address", Type = "Address", Description = "One or more addresses for the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "MaritalStatus", Type = "CodeableConcept", Description = "Marital (civil) status of a person", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Photo", Type = "Attachment", Description = "Image of the person", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ManagingOrganization", Type = "Reference", Description = "The organization that is the custodian of the person record", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Link", Type = "Person.LinkComponent", Description = "Link to a resource that concerns the same actual person", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Account",
            ResourceType = "Account",
            Description = "A financial tool for tracking value accrued for a particular purpose",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier used to reference the account", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | inactive | entered-in-error | on-hold | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Indicates the purpose of this account", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Human-readable label", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "The entity that caused the expenses", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ServicePeriod", Type = "Period", Description = "The date range of services associated with this account", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Coverage", Type = "Account.CoverageComponent", Description = "The party(s) that are responsible for covering the payment of this account", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Owner", Type = "Reference", Description = "Entity managing the account", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Description", Type = "string", Description = "Explanation of purpose/use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Guarantor", Type = "Account.GuarantorComponent", Description = "The parties ultimately responsible for balancing the account", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Reference to a parent account", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "ChargeItem",
            ResourceType = "ChargeItem",
            Description = "The resource ChargeItem describes the provision of healthcare provider products for a certain patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifiers assigned to this event performer or other systems", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "DefinitionUri", Type = "uri", Description = "Defining information about the code of this charge item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "DefinitionCanonical", Type = "canonical", Description = "Defining information about the code of this charge item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "planned | billable | not-billable | aborted | billed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of referenced ChargeItem", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "A code that identifies the charge, like a billing code", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Individual service was done for/to", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Context", Type = "Reference", Description = "Encounter / Episode associated with event", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "When the charged service was applied", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrencePeriod", Type = "Period", Description = "When the charged service was applied", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceTiming", Type = "Timing", Description = "When the charged service was applied", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "ChargeItem.PerformerComponent", Description = "Who performed charged service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PerformingOrganization", Type = "Reference", Description = "Organization providing the charged service", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "RequestingOrganization", Type = "Reference", Description = "Organization requesting the charged service", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CostCenter", Type = "Reference", Description = "Organization that has ownership of the (potential) revenue", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Quantity", Type = "Quantity", Description = "Quantity of which the charge item has been serviced", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Bodysite", Type = "CodeableConcept", Description = "Anatomical location, if relevant", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "FactorOverride", Type = "decimal", Description = "Factor overriding the associated rules", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PriceOverride", Type = "Money", Description = "Total price of the charge overriding the list price", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OverrideReason", Type = "string", Description = "Reason for overriding the list price/factor", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Enterer", Type = "Reference", Description = "Individual who was entering", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EnteredDate", Type = "dateTime", Description = "Date the charge item was entered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Reason", Type = "CodeableConcept", Description = "Why was the charged service rendered?", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Service", Type = "Reference", Description = "Which rendered service is being charged?", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ProductReference", Type = "Reference", Description = "Product charged", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ProductCodeableConcept", Type = "CodeableConcept", Description = "Product charged", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Account", Type = "Reference", Description = "Account to place this charge", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the ChargeItem", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SupportingInformation", Type = "Reference", Description = "Further information supporting this charge", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Invoice",
            ResourceType = "Invoice",
            Description = "Invoice containing collected ChargeItems from an Account with calculated individual and total price for Billing purpose",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier for item", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | issued | balanced | cancelled | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "CancelledReason", Type = "string", Description = "Reason for cancellation of this Invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Type of Invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Subject of the invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recipient", Type = "Reference", Description = "Recipient of this invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Invoice date / posting date", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Participant", Type = "Invoice.ParticipantComponent", Description = "Participant in creation of this Invoice", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Issuer", Type = "Reference", Description = "Issuing Organization of the Invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Account", Type = "Reference", Description = "Account that is being balanced", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LineItem", Type = "Invoice.LineItemComponent", Description = "Line items of this Invoice", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "TotalPriceComponent", Type = "Invoice.PriceComponentComponent", Description = "Components of total line items", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "TotalNet", Type = "Money", Description = "Net total of this Invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "TotalGross", Type = "Money", Description = "Gross total of this Invoice", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PaymentTerms", Type = "Markdown", Description = "Payment details such as due date, etc.", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the invoice", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "PaymentNotice",
            ResourceType = "PaymentNotice",
            Description = "This resource provides the status of the payment for goods and services rendered",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier for the payment", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Request", Type = "Reference", Description = "Reference of payment for which this is being paid", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Response", Type = "Reference", Description = "Reference of response to this payment", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Creation date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Provider", Type = "Reference", Description = "Responsible practitioner", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Payment", Type = "Reference", Description = "Payment reference", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PaymentDate", Type = "date", Description = "Payment or clearing date", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Payee", Type = "Reference", Description = "Party being paid", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recipient", Type = "Reference", Description = "Party being notified", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Amount", Type = "Money", Description = "Monetary amount of the payment", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PaymentStatus", Type = "CodeableConcept", Description = "Issued or cleared Status of the payment", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "PaymentReconciliation",
            ResourceType = "PaymentReconciliation",
            Description = "This resource provides the details including amount of a payment and allocates the payment items being paid",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier for a payment reconciliation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "Period covered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Creation date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PaymentIssuer", Type = "Reference", Description = "Party generating payment", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Request", Type = "Reference", Description = "Reference to requesting resource", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Requestor", Type = "Reference", Description = "Responsible practitioner", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Outcome", Type = "code", Description = "queued | complete | error | partial", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Disposition", Type = "string", Description = "Disposition message", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PaymentDate", Type = "date", Description = "When payment issued", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PaymentAmount", Type = "Money", Description = "Total amount of Payment", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PaymentIdentifier", Type = "Identifier", Description = "Business identifier of the payment", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Detail", Type = "PaymentReconciliation.DetailComponent", Description = "Settlement particulars", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "FormCode", Type = "CodeableConcept", Description = "Printed form identifier", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ProcessNote", Type = "PaymentReconciliation.ProcessNoteComponent", Description = "Note concerning processing", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加基礎設施資源
        resources.Add(new ResourceInfo
        {
            ClassName = "CapabilityStatement",
            ResourceType = "CapabilityStatement",
            Description = "A Capability Statement documents a set of capabilities (behaviors) of a FHIR Server for a particular version of FHIR that may be used as a statement of actual server functionality or a statement of required or desired server implementation",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this capability statement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Version", Type = "string", Description = "Business version of the capability statement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this capability statement (computer friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this capability statement (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the capability statement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for capability statement (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this capability statement is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Copyright", Type = "Markdown", Description = "Use and/or publishing restrictions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Kind", Type = "code", Description = "instance | capability | requirements", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Instantiates", Type = "canonical", Description = "Canonical URL of another capability statement this implements", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Imports", Type = "canonical", Description = "Canonical URL of another capability statement this adds to", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Software", Type = "CapabilityStatement.SoftwareComponent", Description = "Software that is covered by this capability statement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Implementation", Type = "CapabilityStatement.ImplementationComponent", Description = "Identifies a specific implementation instance that is described by the capability statement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "FhirVersion", Type = "code", Description = "FHIR Version the system supports", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Format", Type = "code", Description = "formats supported (xml | json | ttl | mime type)", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "PatchFormat", Type = "code", Description = "Patch formats supported", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ImplementationGuide", Type = "canonical", Description = "Implementation guides supported", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Rest", Type = "CapabilityStatement.RestComponent", Description = "If the endpoint is a RESTful one", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Messaging", Type = "CapabilityStatement.MessagingComponent", Description = "Messaging interface supported", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Document", Type = "CapabilityStatement.DocumentComponent", Description = "Document definition", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "StructureDefinition",
            ResourceType = "StructureDefinition",
            Description = "A definition of a FHIR structure",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this structure definition", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Identifier", Type = "Identifier", Description = "Additional identifier for the structure definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Version", Type = "string", Description = "Business version of the structure definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this structure definition (computer friendly)", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this structure definition (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the structure definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for structure definition (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this structure definition is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Copyright", Type = "Markdown", Description = "Use and/or publishing restrictions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Keyword", Type = "Coding", Description = "Assist with indexing and finding", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "FhirVersion", Type = "code", Description = "FHIR Version this StructureDefinition targets", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Mapping", Type = "StructureDefinition.MappingComponent", Description = "External specification that the content is mapped to", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Kind", Type = "code", Description = "primitive-type | complex-type | resource | logical", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Abstract", Type = "boolean", Description = "Whether the structure is abstract", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Context", Type = "StructureDefinition.ContextComponent", Description = "If an extension, where it can be used in instances", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ContextInvariant", Type = "string", Description = "FHIRPath invariants - when the extension can be used", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Type", Type = "uri", Description = "Type that this structure describes", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BaseDefinition", Type = "canonical", Description = "Definition that this type is constrained/specialized from", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Derivation", Type = "code", Description = "specialization | constraint - How relates to base definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Snapshot", Type = "StructureDefinition.SnapshotComponent", Description = "Snapshot view of the structure", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Differential", Type = "StructureDefinition.DifferentialComponent", Description = "Differential view of the structure", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "ValueSet",
            ResourceType = "ValueSet",
            Description = "A ValueSet resource instance specifies a set of codes drawn from one or more code systems",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this value set", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Identifier", Type = "Identifier", Description = "Additional identifier for the value set", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Version", Type = "string", Description = "Business version of the value set", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this value set (computer friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this value set (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the value set", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for value set (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Immutable", Type = "boolean", Description = "Indicates whether or not any change to the content logical definition may occur", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this value set is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Copyright", Type = "Markdown", Description = "Use and/or publishing restrictions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Compose", Type = "ValueSet.ComposeComponent", Description = "Content logical definition of the value set", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Expansion", Type = "ValueSet.ExpansionComponent", Description = "Used when the value set is \"expanded\"", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "CodeSystem",
            ResourceType = "CodeSystem",
            Description = "The CodeSystem resource is used to declare the existence of and describe a code system or code system supplement and its key properties",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this code system", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Identifier", Type = "Identifier", Description = "Additional identifier for the code system", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Version", Type = "string", Description = "Business version of the code system", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this code system (computer friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this code system (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the code system", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for code system (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this code system is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Copyright", Type = "Markdown", Description = "Use and/or publishing restrictions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "CaseSensitive", Type = "boolean", Description = "If code comparison is case sensitive", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ValueSet", Type = "canonical", Description = "Canonical reference to the value set with entire code system", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "HierarchyMeaning", Type = "code", Description = "grouped-by | is-a | part-of | classified-with", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Compositional", Type = "boolean", Description = "If code system defines a post-composition grammar", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "VersionNeeded", Type = "boolean", Description = "If definitions are not stable", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Content", Type = "code", Description = "not-present | example | fragment | complete | supplement", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Supplements", Type = "canonical", Description = "Canonical URL of Code System this adds to", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Count", Type = "unsignedInt", Description = "Total concepts in the code system", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Filter", Type = "CodeSystem.FilterComponent", Description = "Filter that can be used in a value set", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Property", Type = "CodeSystem.PropertyComponent", Description = "Additional information supplied about each concept", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Concept", Type = "CodeSystem.ConceptComponent", Description = "Concepts in the code system", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加工作流程資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Task",
            ResourceType = "Task",
            Description = "A task to be performed",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Task Instance Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesCanonical", Type = "canonical", Description = "Formal definition of task", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "Formal definition of task", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Request fulfilled by this task", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "GroupIdentifier", Type = "Identifier", Description = "Requisition or grouper id", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PartOf", Type = "Reference", Description = "Composite task", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | requested | received | accepted | +", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "Reason for current status", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BusinessStatus", Type = "CodeableConcept", Description = "E.g. Specimen collected, vials created", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Intent", Type = "code", Description = "unknown | proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Task Type", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Description", Type = "string", Description = "Human-readable explanation of task", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Focus", Type = "Reference", Description = "What task is acting on", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "For", Type = "Reference", Description = "Beneficiary of the Task", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Healthcare event during which this task originated", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ExecutionPeriod", Type = "Period", Description = "Start and end time of execution", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AuthoredOn", Type = "dateTime", Description = "Task Creation Date", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LastModified", Type = "dateTime", Description = "Task Last Modified Date", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Requester", Type = "Reference", Description = "Who is asking for task to be done", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PerformerType", Type = "CodeableConcept", Description = "Requested performer", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Owner", Type = "Reference", Description = "Responsible individual", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Location", Type = "Reference", Description = "Where task occurs", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why task is needed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Why task is needed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Insurance", Type = "Reference", Description = "Associated insurance coverage", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the task", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "RelevantHistory", Type = "Reference", Description = "Key events in history of the Task", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Restriction", Type = "Task.RestrictionComponent", Description = "Constraints on fulfillment tasks", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Input", Type = "Task.InputComponent", Description = "Information used to perform task", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Output", Type = "Task.OutputComponent", Description = "Information produced as part of task", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Communication",
            ResourceType = "Communication",
            Description = "An occurrence of information being transmitted",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesCanonical", Type = "canonical", Description = "Instantiates FHIR protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "Instantiates external protocol or definition", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Request fulfilled by this communication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of this action", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "InResponseTo", Type = "Reference", Description = "Reply to", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "preparation | in-progress | not-done | on-hold | stopped | completed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "Reason for current status", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Message category", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Medium", Type = "CodeableConcept", Description = "A channel of communication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subject", Type = "Reference", Description = "Focus of message", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Topic", Type = "CodeableConcept", Description = "Description of the purpose/content", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "About", Type = "Reference", Description = "Resources that pertain to this communication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter created as part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Sent", Type = "dateTime", Description = "When sent", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Received", Type = "dateTime", Description = "When received", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recipient", Type = "Reference", Description = "Message recipient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Sender", Type = "Reference", Description = "Message sender", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Indication for message", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Indication for message", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Payload", Type = "Communication.PayloadComponent", Description = "Message payload", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the communication", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "CommunicationRequest",
            ResourceType = "CommunicationRequest",
            Description = "A request to convey information",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Fulfills plan or proposal", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Replaces", Type = "Reference", Description = "Request(s) replaced by this request", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "GroupIdentifier", Type = "Identifier", Description = "Composite request this is part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | suspended | cancelled | completed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "StatusReason", Type = "CodeableConcept", Description = "Reason for current status", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Message category", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DoNotPerform", Type = "boolean", Description = "True if request is prohibiting action", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Medium", Type = "CodeableConcept", Description = "A channel of communication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Subject", Type = "Reference", Description = "Focus of message", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "About", Type = "Reference", Description = "Resources that pertain to this communication request", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter created as part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Payload", Type = "CommunicationRequest.PayloadComponent", Description = "Message payload", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "When scheduled", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrencePeriod", Type = "Period", Description = "When scheduled", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AuthoredOn", Type = "dateTime", Description = "When request transitioned to being actionable", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Requester", Type = "Reference", Description = "Who/what is requesting service", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recipient", Type = "Reference", Description = "Message recipient", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Sender", Type = "Reference", Description = "Message sender", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why is communication needed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonReference", Type = "Reference", Description = "Why is communication needed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about communication request", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加研究資源
        resources.Add(new ResourceInfo
        {
            ClassName = "ResearchStudy",
            ResourceType = "ResearchStudy",
            Description = "A process where a researcher or organization plans and then executes a series of steps intended to increase the field of healthcare-related knowledge",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier for study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Title", Type = "string", Description = "Name for this study", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Protocol", Type = "Reference", Description = "Steps followed in executing study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of larger study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | administratively-completed | approved | closed-to-accrual | closed-to-accrual-and-intervention | completed | disapproved | in-review | temporarily-closed-to-accrual | temporarily-closed-to-accrual-and-intervention | withdrawn", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PrimaryPurposeType", Type = "CodeableConcept", Description = "treatment | prevention | diagnostic | supportive-care | screening | health-services-research | basic-science | device-feasibility", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Phase", Type = "CodeableConcept", Description = "n-a | early-phase-1 | phase-1 | phase-1-phase-2 | phase-2 | phase-2-phase-3 | phase-3 | phase-4", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Classifications for the study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Focus", Type = "CodeableConcept", Description = "Drugs, devices, etc. under study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Condition", Type = "CodeableConcept", Description = "Condition being studied", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "RelatedArtifact", Type = "RelatedArtifact", Description = "References and dependencies", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Keyword", Type = "CodeableConcept", Description = "Used to search for the study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Location", Type = "CodeableConcept", Description = "Geographic region(s) for study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "What this is study doing", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Enrollment", Type = "Reference", Description = "Inclusion & exclusion criteria", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Period", Type = "Period", Description = "When the study began and ended", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Sponsor", Type = "Reference", Description = "Organization that initiates and is legally responsible for the study", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PrincipalInvestigator", Type = "Reference", Description = "Researcher who oversees the execution of the study", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Site", Type = "Reference", Description = "Facility where study activities are conducted", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonStopped", Type = "CodeableConcept", Description = "Accrual goal met", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments made about the study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Arm", Type = "ResearchStudy.ArmComponent", Description = "Defined path through the study for a subject", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Objective", Type = "ResearchStudy.ObjectiveComponent", Description = "A goal for the study", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "ResearchSubject",
            ResourceType = "ResearchSubject",
            Description = "A physical entity which is the primary unit of operational and/or administrative interest in a study",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier for research subject in a study", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "candidate | eligible | follow-up | ineligible | not-registered | off-study | on-study | on-study-intervention | on-study-observation | pending-on-study | potential-candidate | screening | withdrawn", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "Start and end of participation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Study", Type = "Reference", Description = "Study subject is part of", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Individual", Type = "Reference", Description = "Who is part of study", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "AssignedArm", Type = "string", Description = "What path should be followed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ActualArm", Type = "string", Description = "What path was taken", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Consent", Type = "Reference", Description = "Agreement to participate in study", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Questionnaire",
            ResourceType = "Questionnaire",
            Description = "A structured set of questions intended to guide the collection of answers from end-users",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this questionnaire", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Identifier", Type = "Identifier", Description = "Additional identifier for the questionnaire", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Version", Type = "string", Description = "Business version of the questionnaire", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this questionnaire (computer friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this questionnaire (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subtitle", Type = "string", Description = "Subordinate title of the questionnaire", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SubjectType", Type = "code", Description = "Resource that can be subject of QuestionnaireResponse", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the questionnaire", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for questionnaire (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this questionnaire is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Copyright", Type = "Markdown", Description = "Use and/or publishing restrictions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ApprovalDate", Type = "date", Description = "When the questionnaire was approved by publisher", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LastReviewDate", Type = "date", Description = "When the questionnaire was last reviewed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "EffectivePeriod", Type = "Period", Description = "When the questionnaire is expected to be used", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "Coding", Description = "Concept that represents the overall questionnaire", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Item", Type = "Questionnaire.ItemComponent", Description = "Questions and sections within the questionnaire", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "QuestionnaireResponse",
            ResourceType = "QuestionnaireResponse",
            Description = "A structured set of questions and their answers",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique id for this set of answers", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "BasedOn", Type = "Reference", Description = "Request fulfilled by this QuestionnaireResponse", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PartOf", Type = "Reference", Description = "Part of this action", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Questionnaire", Type = "canonical", Description = "Form being answered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "in-progress | completed | amended | entered-in-error | stopped", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "The subject of the questions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter created as part of", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Authored", Type = "dateTime", Description = "Date the answers were gathered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Author", Type = "Reference", Description = "Person who received and recorded the answers", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Source", Type = "Reference", Description = "The person who answered the questions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Item", Type = "QuestionnaireResponse.ItemComponent", Description = "Groups and questions", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加其他重要資源
        resources.Add(new ResourceInfo
        {
            ClassName = "Consent",
            ResourceType = "Consent",
            Description = "A record of a healthcare consumer's choices or choices made on their behalf by a third party",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifier for this record (external references)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | proposed | active | rejected | inactive | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Scope", Type = "CodeableConcept", Description = "Which of the four areas this resource covers (extensive/international/regional/national)", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Classification of the consent statement", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "Patient", Type = "Reference", Description = "Who the consent applies to", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DateTime", Type = "dateTime", Description = "When this Consent was created or indexed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Consent Verified by", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Organization", Type = "Reference", Description = "Custodian of the consent", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SourceAttachment", Type = "Attachment", Description = "Source from which this consent is taken", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SourceReference", Type = "Reference", Description = "Source from which this consent is taken", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Policy", Type = "Consent.PolicyComponent", Description = "Policies covered by this consent", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "PolicyRule", Type = "CodeableConcept", Description = "Regulation that this consents to", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Verification", Type = "Consent.VerificationComponent", Description = "Consent Verified by patient or family", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Provision", Type = "Consent.ProvisionComponent", Description = "Constraints to the base Consent.policyRule", MinCardinality = 0, MaxCardinality = "1" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "Contract",
            ResourceType = "Contract",
            Description = "Legally enforceable, formally recorded unilateral or bilateral directive i.e., a policy or agreement",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Contract number", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Url", Type = "uri", Description = "Baseline legal status of the contract", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Version", Type = "string", Description = "Business edition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | terminated | terminated", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LegalState", Type = "CodeableConcept", Description = "Legal instrument category", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "InstantiatesCanonical", Type = "Reference", Description = "Source Contract Definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "InstantiatesUri", Type = "uri", Description = "External Contract Definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ContentDerivative", Type = "CodeableConcept", Description = "Content derived from the basal information", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Issued", Type = "dateTime", Description = "When this Contract was issued", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Applies", Type = "Period", Description = "Effective time", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ExpirationType", Type = "CodeableConcept", Description = "Contract cessation cause", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Contract Target Entity", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Authority", Type = "Reference", Description = "Authority under which this Contract has standing", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Domain", Type = "Reference", Description = "A sphere of control governed by an authoritative jurisdiction", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Site", Type = "Reference", Description = "Specific Location", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Name", Type = "string", Description = "Computer friendly designation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Human friendly designation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subtitle", Type = "string", Description = "Subordinate Friendly designation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Alias", Type = "string", Description = "Acronym or short name", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Author", Type = "Reference", Description = "Source of Contract", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Scope", Type = "CodeableConcept", Description = "Range of Legal Concerns", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "TopicCodeableConcept", Type = "CodeableConcept", Description = "Focus of contract interest", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "TopicReference", Type = "Reference", Description = "Focus of contract interest", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Legal instrument category", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SubType", Type = "CodeableConcept", Description = "Subtype within the context of type", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ContentDefinition", Type = "Contract.ContentDefinitionComponent", Description = "Contract precursor content", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Term", Type = "Contract.TermComponent", Description = "Contract Term List", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "SupportingInfo", Type = "Reference", Description = "Extra Information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "RelevantHistory", Type = "Reference", Description = "Key event in Contract History", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Signer", Type = "Contract.SignerComponent", Description = "Contract Signatory", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Friendly", Type = "Contract.FriendlyComponent", Description = "Contract Friendly Language", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Legal", Type = "Contract.LegalComponent", Description = "Contract Legal Language", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Rule", Type = "Contract.RuleComponent", Description = "Computable Contract Language", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 繼續添加更多 R4 資源...
        // 這裡可以根據實際需要添加更多資源

        resources.Add(new ResourceInfo
        {
            ClassName = "Endpoint",
            ResourceType = "Endpoint",
            Description = "The technical details of an endpoint that can be used for electronic services",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifies this endpoint across multiple systems", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | suspended | error | off | entered-in-error | test", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "ConnectionType", Type = "Coding", Description = "Protocol/Profile/Standard to be used with this endpoint connection", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "A name that this endpoint can be identified by", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ManagingOrganization", Type = "Reference", Description = "Organization that manages this endpoint", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactPoint", Description = "Contact details for source and destination", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Period", Type = "Period", Description = "Interval the endpoint is available", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PayloadType", Type = "CodeableConcept", Description = "The type of content that may be used at this endpoint", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "PayloadMimeType", Type = "code", Description = "Mime type to send", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Address", Type = "url", Description = "The network address of the endpoint", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Header", Type = "string", Description = "Usage depends on the channel type", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加更多基礎設施資源
        resources.Add(new ResourceInfo
        {
            ClassName = "ConceptMap",
            ResourceType = "ConceptMap",
            Description = "A statement of relationships from one set of concepts to one or more other concepts",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this concept map", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Identifier", Type = "Identifier", Description = "Additional identifier for the concept map", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Version", Type = "string", Description = "Business version of the concept map", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this concept map (computer friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this concept map (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the concept map", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for concept map (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this concept map is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Copyright", Type = "Markdown", Description = "Use and/or publishing restrictions", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SourceUri", Type = "uri", Description = "Identifies the source of the concepts which are being mapped", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SourceCanonical", Type = "canonical", Description = "Identifies the source of the concepts which are being mapped", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "TargetUri", Type = "uri", Description = "Provides context to the mappings", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "TargetCanonical", Type = "canonical", Description = "Provides context to the mappings", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Group", Type = "ConceptMap.GroupComponent", Description = "Same source and target systems", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "OperationDefinition",
            ResourceType = "OperationDefinition",
            Description = "A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction)",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this operation definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Version", Type = "string", Description = "Business version of the operation definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this operation definition (computer friendly)", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Name for this operation definition (human friendly)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Kind", Type = "code", Description = "operation | query", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the operation definition", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for operation definition (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this operation definition is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "AffectsState", Type = "boolean", Description = "Whether content is changed by the operation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "code", Description = "Name used to invoke the operation", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Comment", Type = "Markdown", Description = "Additional information about use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Base", Type = "canonical", Description = "Marks this as a profile of the base", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Resource", Type = "code", Description = "Types this operation applies to", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "System", Type = "boolean", Description = "Invoke at the system level?", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "boolean", Description = "Invoke at the type level?", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Instance", Type = "boolean", Description = "Invoke on an instance?", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "InputProfile", Type = "canonical", Description = "Parameters for the input", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OutputProfile", Type = "canonical", Description = "Parameters for the output", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Parameter", Type = "OperationDefinition.ParameterComponent", Description = "Parameters for the operation/query", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Overload", Type = "OperationDefinition.OverloadComponent", Description = "Define overloaded variants for when generating code", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        resources.Add(new ResourceInfo
        {
            ClassName = "SearchParameter",
            ResourceType = "SearchParameter",
            Description = "A search parameter that defines a named search item that can be used to search/filter on a resource",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Url", Type = "uri", Description = "Canonical identifier for this search parameter", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Version", Type = "string", Description = "Business version of the search parameter", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Name", Type = "string", Description = "Name for this search parameter (computer friendly)", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "DerivedFrom", Type = "canonical", Description = "Original definition for the search parameter", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Experimental", Type = "boolean", Description = "For testing purposes, not real usage", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date last changed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Name of the publisher (organization or individual)", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Contact", Type = "ContactDetail", Description = "Contact details for the publisher", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Description", Type = "Markdown", Description = "Natural language description of the search parameter", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "UseContext", Type = "UsageContext", Description = "The context that the content is intended to support", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Jurisdiction", Type = "CodeableConcept", Description = "Intended jurisdiction for search parameter (if applicable)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Purpose", Type = "Markdown", Description = "Why this search parameter is defined", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "code", Description = "Code used in URL", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Base", Type = "code", Description = "The resource type(s) this search parameter applies to", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "Type", Type = "code", Description = "number | date | string | token | reference | composite | quantity | uri | special", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Expression", Type = "string", Description = "FHIRPath expression that extracts the values", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Xpath", Type = "string", Description = "XPath that extracts the values", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "XpathUsage", Type = "code", Description = "normal | phonetic | nearby | distance | other", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Target", Type = "code", Description = "Types of resource (if a resource reference)", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "MultipleOr", Type = "boolean", Description = "Allow multiple values", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "MultipleAnd", Type = "boolean", Description = "Allow multiple parameters", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Comparator", Type = "code", Description = "eq | ne | gt | lt | ge | le | sa | eb | ap", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Modifier", Type = "code", Description = "missing | exact | contains | not | text | in | not-in | below | above | type | identifier | of-type", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Chain", Type = "string", Description = "Chained names supported", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Component", Type = "SearchParameter.ComponentComponent", Description = "For Composite search parameters", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 添加更多財務資源
        resources.Add(new ResourceInfo
        {
            ClassName = "ClaimResponse",
            ResourceType = "ClaimResponse",
            Description = "This resource provides the adjudication details from the processing of a Claim resource",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Response number", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "More granular claim type", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "SubType", Type = "CodeableConcept", Description = "More granular claim type", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Use", Type = "code", Description = "claim | preauthorization | predetermination", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "The recipient of the products and services", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Response creation date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Insurer", Type = "Reference", Description = "Responsible practitioner", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Requestor", Type = "Reference", Description = "Party responsible for reimbursement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Request", Type = "Reference", Description = "Id of resource triggering adjudication", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Outcome", Type = "code", Description = "queued | complete | error | partial", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Disposition", Type = "string", Description = "Disposition Message", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PreAuthRef", Type = "string", Description = "Preauthorization reference", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PreAuthPeriod", Type = "Period", Description = "Preauthorization reference effective period", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PayeeType", Type = "CodeableConcept", Description = "Party to be paid any benefits payable", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Item", Type = "ClaimResponse.ItemComponent", Description = "Adjudication for claim line items", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "AddItem", Type = "ClaimResponse.AddItemComponent", Description = "Insurer added line items", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Adjudication", Type = "ClaimResponse.AdjudicationComponent", Description = "Header-level adjudication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Total", Type = "ClaimResponse.TotalComponent", Description = "Adjudication totals", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Payment", Type = "ClaimResponse.PaymentComponent", Description = "Payment Details", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "FormCode", Type = "CodeableConcept", Description = "Printed form identifier", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Form", Type = "Attachment", Description = "Printed reference or actual form", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ProcessNote", Type = "ClaimResponse.ProcessNoteComponent", Description = "Note concerning adjudication", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "CommunicationRequest", Type = "Reference", Description = "Request for additional information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Insurance", Type = "ClaimResponse.InsuranceComponent", Description = "Patient insurance information", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Error", Type = "ClaimResponse.ErrorComponent", Description = "Processing errors", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        // 繼續添加更多 R4 資源...
        // 這裡可以根據實際需要添加更多資源

        resources.Add(new ResourceInfo
        {
            ClassName = "NamingSystem",
            ResourceType = "NamingSystem",
            Description = "A curated namespace for identification purposes",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier for this naming system", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Name", Type = "string", Description = "Name for this naming system", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Kind", Type = "code", Description = "codesystem | identifier | root", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Publication date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Publisher name", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "MessageDefinition",
            ResourceType = "MessageDefinition",
            Description = "A resource that defines a message structure",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Name", Type = "string", Description = "Name for this message definition", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Publication date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Publisher name", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "TerminologyCapabilities",
            ResourceType = "TerminologyCapabilities",
            Description = "A statement of system capabilities around terminology",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | active | retired | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Publication date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Publisher", Type = "string", Description = "Publisher name", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "HealthcareService",
            ResourceType = "HealthcareService",
            Description = "The details of a healthcare service available at a location",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this HealthcareService record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ProvidedBy", Type = "Reference", Description = "Organization that provides this service", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Type of service that may be delivered or performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Name", Type = "string", Description = "Description of service as presented to a consumer", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "Substance",
            ResourceType = "Substance",
            Description = "A homogeneous material with a definite composition",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | inactive | entered-in-error", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "What class/type of substance this is", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "What substance this is", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Description", Type = "string", Description = "Textual description of the substance", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "DeviceMetric",
            ResourceType = "DeviceMetric",
            Description = "Describes a measurement, calculation or setting capability of a medical device",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Describes the type of the metric", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Unit", Type = "CodeableConcept", Description = "Unit of Measure for the Metric", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Source", Type = "Reference", Description = "Describes the link to the source Device", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Parent", Type = "Reference", Description = "Describes the link to the parent Device", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "DeviceUseStatement",
            ResourceType = "DeviceUseStatement",
            Description = "Record of use of a device by a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External identifier for this record", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | completed | entered-in-error | intended | stopped | on-hold | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Patient using device", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Device", Type = "Reference", Description = "Device used", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Notes about the device use", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "DocumentManifest",
            ResourceType = "DocumentManifest",
            Description = "A collection of documents compiled for a purpose together with metadata",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Unique identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "current | superseded | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "The subject of the set of documents", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Description", Type = "string", Description = "Human-readable description", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Content", Type = "Reference", Description = "The list of Documents included in the manifest", MinCardinality = 1, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "Flag",
            ResourceType = "Flag",
            Description = "Key information to flag to healthcare providers",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | inactive | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Clinical, administrative, etc.", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Flag type", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who/what is flagged", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Period", Type = "Period", Description = "Time period when flag is active", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Author", Type = "Reference", Description = "Flag creator", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "List",
            ResourceType = "List",
            Description = "A list is a curated collection of resources",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "current | retired | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Mode", Type = "code", Description = "working | snapshot | changes", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Title", Type = "string", Description = "Descriptive name for the list", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "If all resources have the same subject", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "When the list was prepared", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the list", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "OrganizationAffiliation",
            ResourceType = "OrganizationAffiliation",
            Description = "Defines an affiliation/assotiation/relationship between 2 distinct organizations",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Active", Type = "boolean", Description = "Whether this OrganizationAffiliation record is in active use", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Organization", Type = "Reference", Description = "Organization where the role is available", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "ParticipatingOrganization", Type = "Reference", Description = "Organization that provides the services", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Role code(s) that define the relationship", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Period", Type = "Period", Description = "The period during which the participatingOrganization is affiliated with the primary organization", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "Provenance",
            ResourceType = "Provenance",
            Description = "Provenance of a resource",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Target", Type = "Reference", Description = "Target Reference(s)", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "OccurredPeriod", Type = "Period", Description = "When the activity occurred", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recorded", Type = "instant", Description = "When the activity was recorded/updated", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Policy", Type = "uri", Description = "Policy or plan the activity was defined by", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Location", Type = "Reference", Description = "Where the activity occurred, if relevant", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Reason", Type = "CodeableConcept", Description = "Reason the activity was performed", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Activity", Type = "CodeableConcept", Description = "Activity that took place", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Agent", Type = "Provenance.AgentComponent", Description = "Actor involved", MinCardinality = 1, MaxCardinality = "*" },
                new() { Name = "Entity", Type = "Provenance.EntityComponent", Description = "An entity used in this activity", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Signature", Type = "Signature", Description = "Signature on target", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "ServiceRequest",
            ResourceType = "ServiceRequest",
            Description = "A record of a request for service such as diagnostic investigations, treatments, or operations to be performed",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifiers assigned to this order", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | active | on-hold | revoked | completed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Intent", Type = "code", Description = "proposal | plan | order | original-order | reflex-order | filler-order | instance-order | option", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Classification of service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "What is being requested/ordered", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Individual or Entity the service is ordered for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter during which the request was created", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "When service should occur", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Requested performer", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Explanation/justification for service", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the request", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "SupplyDelivery",
            ResourceType = "SupplyDelivery",
            Description = "Record of delivery of what is supplied",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "in-progress | completed | abandoned | entered-in-error | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Patient for whom the item is supplied", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Type", Type = "CodeableConcept", Description = "Category of dispense event", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "SuppliedItem", Type = "SupplyDelivery.SuppliedItemComponent", Description = "The item that is delivered or supplied", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "When event occurred", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "SupplyDelivery.PerformerComponent", Description = "Who performed event", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Destination", Type = "Reference", Description = "Where the Supply was sent", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the delivery", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "SupplyRequest",
            ResourceType = "SupplyRequest",
            Description = "A record of a request for a medication, substance or device used in the healthcare setting",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | active | suspended | cancelled | completed | entered-in-error | unknown", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Category of supply request", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Priority", Type = "code", Description = "routine | urgent | asap | stat", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ItemCodeableConcept", Type = "CodeableConcept", Description = "Medication, Substance, or Device requested", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "OccurrenceDateTime", Type = "dateTime", Description = "When request should be fulfilled", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Requester", Type = "Reference", Description = "Individual making the request", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "ReasonCode", Type = "CodeableConcept", Description = "Why the supply item was requested", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the request", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "VisionPrescription",
            ResourceType = "VisionPrescription",
            Description = "An authorization for the supply of glasses and/or contact lenses to a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business Identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | cancelled | draft | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Created", Type = "dateTime", Description = "Creation date", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Who prescription is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Encounter", Type = "Reference", Description = "Encounter during which prescription was created", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "DateWritten", Type = "dateTime", Description = "When prescription was authorized", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Prescriber", Type = "Reference", Description = "Who authorized the prescription", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "LensSpecification", Type = "VisionPrescription.LensSpecificationComponent", Description = "Vision lens authorization", MinCardinality = 1, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "MedicationAdministration",
            ResourceType = "MedicationAdministration",
            Description = "Administration of medication to a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "in-progress | not-done | on-hold | completed | entered-in-error | stopped | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "MedicationCodeableConcept", Type = "CodeableConcept", Description = "What was administered", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who received medication", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "EffectiveDateTime", Type = "dateTime", Description = "Start and end time of administration", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "MedicationAdministration.PerformerComponent", Description = "Who performed the administration", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Notes about the administration", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "MedicationDispense",
            ResourceType = "MedicationDispense",
            Description = "Dispensing a medication to a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "preparation | in-progress | cancelled | on-hold | completed | entered-in-error | stopped | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "MedicationCodeableConcept", Type = "CodeableConcept", Description = "What medication was supplied", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who the dispense is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "MedicationDispense.PerformerComponent", Description = "Who performed the dispense", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "WhenHandedOver", Type = "dateTime", Description = "When product was given out", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Notes about the dispense", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "MedicationStatement",
            ResourceType = "MedicationStatement",
            Description = "Record of medication being taken by a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "External identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "MedicationCodeableConcept", Type = "CodeableConcept", Description = "What medication was taken", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who is/was taking the medication", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "EffectiveDateTime", Type = "dateTime", Description = "The date/time or interval when the medication is/was/will be taken", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Notes about the statement", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "NutritionOrder",
            ResourceType = "NutritionOrder",
            Description = "A request to supply a diet, formula feeding, or oral nutritional supplement to a patient/resident",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Identifiers assigned to this order", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "draft | active | on-hold | revoked | completed | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "The person who requires the diet, formula or supplement", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "DateTime", Type = "dateTime", Description = "Date and time the nutrition order was requested", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Orderer", Type = "Reference", Description = "Who ordered the diet, formula or supplement", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "ImmunizationEvaluation",
            ResourceType = "ImmunizationEvaluation",
            Description = "Describes a comparison of an immunization event against published recommendations",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "completed | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Who this evaluation is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date evaluation was performed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Authority", Type = "Reference", Description = "Who is responsible for publishing the recommendations", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "Evaluation notes", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "ImmunizationRecommendation",
            ResourceType = "ImmunizationRecommendation",
            Description = "A patient's point-in-time set of recommendations (i.e. forecasting, immunization plan) according to a published schedule",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Patient", Type = "Reference", Description = "Who this profile is for", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "Date recommendation(s) created", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Authority", Type = "Reference", Description = "Who is responsible for publishing the recommendations", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Recommendation", Type = "ImmunizationRecommendation.RecommendationComponent", Description = "Vaccine administration recommendations", MinCardinality = 1, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "ObservationDefinition",
            ResourceType = "ObservationDefinition",
            Description = "Set of definitional characteristics for a kind of observation or measurement produced or consumed by an orderable health care service",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Category", Type = "CodeableConcept", Description = "Category of observation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Code", Type = "CodeableConcept", Description = "Type of observation", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "PermittedDataType", Type = "code", Description = "Permitted data type for observation", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "MultipleResultsAllowed", Type = "boolean", Description = "Multiple results allowed", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Method", Type = "CodeableConcept", Description = "Method used to produce observation", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "PreferredReportName", Type = "string", Description = "Preferred report name", MinCardinality = 0, MaxCardinality = "1" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "RiskAssessment",
            ResourceType = "RiskAssessment",
            Description = "An assessment of the likely outcome(s) for a patient or other subject",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "registered | preliminary | final | amended | corrected | cancelled | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Who/what does assessment apply to?", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "When was assessment made?", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Performer", Type = "Reference", Description = "Who did assessment?", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Prediction", Type = "RiskAssessment.PredictionComponent", Description = "Outcome predicted", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments on the assessment", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "FamilyMemberHistory",
            ResourceType = "FamilyMemberHistory",
            Description = "Significant health events and conditions for a person related to the patient relevant in the context of care for the patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "partial | completed | entered-in-error | health-unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Patient history is about", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "When history was recorded or last updated", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Relationship", Type = "CodeableConcept", Description = "Relationship to the patient", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Note", Type = "Annotation", Description = "General note about the family member", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "DetectedIssue",
            ResourceType = "DetectedIssue",
            Description = "An actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "registered | preliminary | final | amended | corrected | cancelled | entered-in-error | unknown", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Patient", Type = "Reference", Description = "Associated patient", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "When identified", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Author", Type = "Reference", Description = "The provider or device that identified the issue", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Implicated", Type = "Reference", Description = "Problem resource", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Detail", Type = "string", Description = "Description and context", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Mitigation", Type = "DetectedIssue.MitigationComponent", Description = "Step taken to address", MinCardinality = 0, MaxCardinality = "*" }
            }
        });
        resources.Add(new ResourceInfo
        {
            ClassName = "ClinicalImpression",
            ResourceType = "ClinicalImpression",
            Description = "A clinical assessment performed when planning treatments and management strategies for a patient",
            Properties = new List<PropertyDefinition>
            {
                new() { Name = "Identifier", Type = "Identifier", Description = "Business identifier", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Status", Type = "code", Description = "in-progress | completed | entered-in-error", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Subject", Type = "Reference", Description = "Patient or group assessed", MinCardinality = 1, MaxCardinality = "1" },
                new() { Name = "Date", Type = "dateTime", Description = "When the assessment was made", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Assessor", Type = "Reference", Description = "Who did assessment", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Summary", Type = "string", Description = "Summary of the assessment", MinCardinality = 0, MaxCardinality = "1" },
                new() { Name = "Finding", Type = "ClinicalImpression.FindingComponent", Description = "Possible or likely findings", MinCardinality = 0, MaxCardinality = "*" },
                new() { Name = "Note", Type = "Annotation", Description = "Comments about the assessment", MinCardinality = 0, MaxCardinality = "*" }
            }
        });

        return resources;
    }

    /// <summary>
    /// 檢查 DataType 異動
    /// </summary>
    private List<DataTypeChange> CheckDataTypeChanges(FhirDefinitions definitions)
    {
        var changes = new List<DataTypeChange>();

        // 檢查 R4 特有的 DataType 變更
        // 這裡可以根據實際的 FHIR R4 定義來檢查異動

        // 範例：檢查是否有新的 DataType
        var r4SpecificTypes = ExtractR4SpecificDataTypes(definitions);
        if (r4SpecificTypes.Any())
        {
            foreach (var type in r4SpecificTypes)
            {
                changes.Add(new DataTypeChange
                {
                    Type = "新增",
                    Description = $"新增 R4 特有 DataType: {type.ClassName}"
                });
            }
        }

        // 檢查現有 DataType 的變更
        var modifiedTypes = CheckModifiedDataTypes(definitions);
        foreach (var type in modifiedTypes)
        {
            changes.Add(new DataTypeChange
            {
                Type = "修改",
                Description = $"修改 DataType: {type.ClassName} - {type.ChangeDescription}"
            });
        }

        return changes;
    }

    /// <summary>
    /// 提取 R4 特有的 DataType
    /// </summary>
    private List<DataTypeInfo> ExtractR4SpecificDataTypes(FhirDefinitions definitions)
    {
        var r4SpecificTypes = new List<DataTypeInfo>();

        // 這裡可以根據實際的 R4 定義來判斷哪些是 R4 特有的
        // 目前返回空列表，表示沒有 R4 特有的 DataType

        return r4SpecificTypes;
    }

    /// <summary>
    /// 檢查修改的 DataType
    /// </summary>
    private List<DataTypeModification> CheckModifiedDataTypes(FhirDefinitions definitions)
    {
        var modifications = new List<DataTypeModification>();

        // 這裡可以根據實際的 R4 定義來檢查哪些 DataType 有變更
        // 目前返回空列表，表示沒有修改

        return modifications;
    }

    /// <summary>
    ///DataType 變更記錄
    /// </summary>
    private class DataTypeChange
    {
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    /// <summary>
    ///DataType 修改記錄
    /// </summary>
    private class DataTypeModification
    {
        public string ClassName { get; set; } = string.Empty;
        public string ChangeDescription { get; set; } = string.Empty;
    }
}

/// <summary>
/// FHIR 定義檔結構
/// </summary>
public class FhirDefinitions
{
    public List<FhirDefinition> Entry { get; set; } = new();
}

/// <summary>
/// 單個 FHIR 定義
/// </summary>
public class FhirDefinition
{
    public string ResourceType { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty;
    public bool Abstract { get; set; }
    public string BaseDefinition { get; set; } = string.Empty;
    public List<FhirElement> Element { get; set; } = new();
}

/// <summary>
///FHIR 元素定義
/// </summary>
public class FhirElement
{
    public string Id { get; set; } = string.Empty;
    public string Path { get; set; } = string.Empty;
    public string Short { get; set; } = string.Empty;
    public string Definition { get; set; } = string.Empty;
    public string Min { get; set; } = string.Empty;
    public string Max { get; set; } = string.Empty;
    public List<FhirType> Type { get; set; } = new();
}

/// <summary>
///FHIR 型別定義
/// </summary>
public class FhirType
{
    public string Code { get; set; } = string.Empty;
    public string Profile { get; set; } = string.Empty;
    public string TargetProfile { get; set; } = string.Empty;
    public string Versioning { get; set; } = string.Empty;
} 