# AI ��q�ͦ� FHIR R5 �귽�u��
# ���ҪO�M AI �Ҧ��ѧO���귽�ͦ���

param(
    [string[]]$ResourceNames = @(),
    [string]$TemplateMode = "Smart",  # Smart, Simple, Complete
    [string]$OutputPath = "FhirCore.R5\Resources",
    [switch]$GenerateFactoryMethods = $true,
    [switch]$GenerateDocumentation = $true
)

# �귽�����M�ҪO
$ResourceTemplates = @{
    # �֤߸귽�ҪO
    "Patient-like" = @{
        Pattern = @("Patient", "Person", "Practitioner", "RelatedPerson")
        RequiredProperties = @("identifier", "name", "active")
        CommonProperties = @("gender", "birthDate", "address", "telecom")
    }
    
    # �{�ɸ귽�ҪO  
    "Clinical-like" = @{
        Pattern = @("Condition", "Observation", "Procedure", "DiagnosticReport")
        RequiredProperties = @("status", "code", "subject")
        CommonProperties = @("encounter", "effectiveDateTime", "performer")
    }
    
    # �޲z�귽�ҪO
    "Administrative-like" = @{
        Pattern = @("Organization", "Location", "HealthcareService", "Endpoint")
        RequiredProperties = @("active", "name")
        CommonProperties = @("identifier", "type", "telecom", "address")
    }
    
    # �u�@�y�{�귽�ҪO
    "Workflow-like" = @{
        Pattern = @("Task", "Appointment", "Schedule", "Slot")
        RequiredProperties = @("status", "intent")
        CommonProperties = @("identifier", "subject", "for")
    }
}

# FHIR R5 ����귽�C��]���u���Ť��ա^
$AllR5Resources = @{
    # �Ĥ@��G���u���Ů֤߸귽 (20��)
    "Core-High" = @(
        "Account", "ActivityDefinition", "AllergyIntolerance", "Appointment", "AuditEvent",
        "Bundle", "CarePlan", "CareTeam", "Communication", "Composition", 
        "Consent", "Device", "DiagnosticReport", "Goal", "Group", 
        "Immunization", "Person", "RelatedPerson", "Schedule", "Slot"
    )
    
    # �ĤG��G�{�ɸ귽 (25��)
    "Clinical" = @(
        "ClinicalImpression", "DetectedIssue", "FamilyMemberHistory", "Flag", "MedicationAdministration",
        "MedicationDispense", "MedicationRequest", "MedicationStatement", "Procedure", "RiskAssessment",
        "ServiceRequest", "Specimen", "BodyStructure", "ImagingStudy", "MolecularSequence",
        "VisionPrescription", "NutritionOrder", "ClinicalUseDefinition", "Evidence", "EvidenceReport",
        "EvidenceVariable", "ResearchStudy", "ResearchSubject", "GuidanceResponse", "SupplyRequest"
    )
    
    # �ĤT��G�޲z�M�u�@�y�{�귽 (30��)  
    "Administrative" = @(
        "PractitionerRole", "HealthcareService", "Location", "AppointmentResponse", "Task",
        "MessageHeader", "MessageDefinition", "OperationOutcome", "Parameters", "Subscription",
        "Coverage", "ExplanationOfBenefit", "Claim", "ClaimResponse", "PaymentNotice",
        "PaymentReconciliation", "ChargeItem", "Invoice", "InsurancePlan", "Linkage",
        "List", "Library", "Measure", "MeasureReport", "SupplyDelivery", "EnrollmentRequest",
        "EnrollmentResponse", "VisionPrescription", "DeviceDefinition", "BiologicallyDerivedProduct"
    )
    
    # �ĥ|��G�w�q�M�S��귽 (40��)
    "Definition" = @(
        "StructureDefinition", "StructureMap", "CapabilityStatement", "OperationDefinition", "SearchParameter",
        "CodeSystem", "ValueSet", "ConceptMap", "NamingSystem", "TerminologyCapabilities",
        "ImplementationGuide", "TestScript", "TestReport", "TestPlan", "Questionnaire",
        "QuestionnaireResponse", "PlanDefinition", "Substance", "SubstanceDefinition", "SpecimenDefinition",
        "ObservationDefinition", "ActorDefinition", "Requirements", "GraphDefinition", "ExampleScenario",
        "CompartmentDefinition", "ChargeItemDefinition", "EventDefinition", "CatalogEntry", "Citation",
        "ArtifactAssessment", "Binary", "DocumentReference", "Media", "Endpoint",
        "Provenance", "ImagingSelection", "Transport", "Permission", "VerificationResult",
        "InventoryItem", "InventoryReport", "FormularyItem", "GenomicStudy", "DeviceUsage"
    )
}

# AI �Ҧ��G����귽�ͦ��禡
function Generate-SmartResource {
    param(
        [string]$ResourceName,
        [string]$Category
    )
    
    # �ھڸ귽�W�ٴ�����_�ݩ�
    $intelligentProperties = Get-IntelligentProperties -ResourceName $ResourceName -Category $Category
    
    # �ͦ����~�誺����
    $documentation = Generate-IntelligentDocumentation -ResourceName $ResourceName -Category $Category
    
    # �إߧ��㪺�귽�N�X
    $resourceCode = @"
using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
$documentation
    public class $ResourceName : ResourceBase<R5Version>
    {
$($intelligentProperties.Fields)

        /// <summary>
        /// �귽����
        /// </summary>
        public override string ResourceType => "$ResourceName";

$($intelligentProperties.Properties)

$($intelligentProperties.Constructors)

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            return `$"$ResourceName(Id: {Id})";
        }
    }
$($intelligentProperties.SubClasses)
}
"@
    
    return $resourceCode
}

# �����ݩʱ��_
function Get-IntelligentProperties {
    param([string]$ResourceName, [string]$Category)
    
    $fields = ""
    $properties = ""
    $constructors = ""
    $subClasses = ""
    
    # �ھڸ귽�W�٩M���O���_�`���ݩ�
    $commonFields = @()
    
    # �Ҧ��귽���������ݩ�
    $commonFields += @{Name="identifier"; Type="List<Identifier>?"; Description="�ѧO�X"}
    
    # �ھڤ����K�[�S�w�ݩ�
    switch ($Category) {
        "Core-High" {
            if ($ResourceName -match "Person|Patient|Practitioner") {
                $commonFields += @{Name="name"; Type="List<HumanName>?"; Description="�m�W"}
                $commonFields += @{Name="telecom"; Type="List<ContactPoint>?"; Description="�p���覡"}
                $commonFields += @{Name="gender"; Type="FhirCode?"; Description="�ʧO"}
                $commonFields += @{Name="birthDate"; Type="FhirDate?"; Description="�X�ͤ��"}
                $commonFields += @{Name="active"; Type="FhirBoolean?"; Description="�O�_�ҥ�"}
            }
            if ($ResourceName -match "Organization|Location") {
                $commonFields += @{Name="name"; Type="FhirString?"; Description="�W��"}
                $commonFields += @{Name="type"; Type="List<CodeableConcept>?"; Description="����"}
                $commonFields += @{Name="active"; Type="FhirBoolean?"; Description="�O�_�ҥ�"}
            }
            if ($ResourceName -match "Appointment|Schedule") {
                $commonFields += @{Name="status"; Type="FhirCode?"; Description="���A"; Required=$true}
                $commonFields += @{Name="serviceType"; Type="List<CodeableConcept>?"; Description="�A������"}
                $commonFields += @{Name="start"; Type="FhirDateTime?"; Description="�}�l�ɶ�"}
                $commonFields += @{Name="end"; Type="FhirDateTime?"; Description="�����ɶ�"}
            }
        }
        "Clinical" {
            $commonFields += @{Name="status"; Type="FhirCode?"; Description="���A"; Required=$true}
            $commonFields += @{Name="code"; Type="CodeableConcept?"; Description="�N�X"}
            $commonFields += @{Name="subject"; Type="DataTypeServices.DataTypes.SpecialTypes.ReferenceType?"; Description="�D��"; Required=$true}
            $commonFields += @{Name="encounter"; Type="DataTypeServices.DataTypes.SpecialTypes.ReferenceType?"; Description="�N�E"}
            
            if ($ResourceName -match "Medication") {
                $commonFields += @{Name="effectiveDateTime"; Type="FhirDateTime?"; Description="�ͮĮɶ�"}
                $commonFields += @{Name="dosage"; Type="List<Dosage>?"; Description="���q"}
            }
            if ($ResourceName -match "Procedure|Observation") {
                $commonFields += @{Name="performedDateTime"; Type="FhirDateTime?"; Description="����ɶ�"}
                $commonFields += @{Name="performer"; Type="List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>?"; Description="�����"}
            }
        }
        "Administrative" {
            $commonFields += @{Name="active"; Type="FhirBoolean?"; Description="�O�_�ҥ�"}
            $commonFields += @{Name="period"; Type="Period?"; Description="���Ĵ���"}
            
            if ($ResourceName -match "Task") {
                $commonFields += @{Name="status"; Type="FhirCode?"; Description="���A"; Required=$true}
                $commonFields += @{Name="intent"; Type="FhirCode?"; Description="�N��"; Required=$true}
                $commonFields += @{Name="for"; Type="DataTypeServices.DataTypes.SpecialTypes.ReferenceType?"; Description="��H"}
            }
        }
        "Definition" {
            $commonFields += @{Name="url"; Type="FhirUri?"; Description="URL"}
            $commonFields += @{Name="version"; Type="FhirString?"; Description="����"}
            $commonFields += @{Name="name"; Type="FhirString?"; Description="�W��"}
            $commonFields += @{Name="status"; Type="FhirCode?"; Description="���A"; Required=$true}
            $commonFields += @{Name="date"; Type="FhirDateTime?"; Description="���"}
            $commonFields += @{Name="publisher"; Type="FhirString?"; Description="�o����"}
        }
    }
    
    # �ͦ��p�����
    foreach ($field in $commonFields) {
        $fieldName = "_" + $field.Name.ToLower()
        $fields += "        private $($field.Type) $fieldName;`n"
    }
    
    # �ͦ����}�ݩ�
    foreach ($field in $commonFields) {
        $propertyName = (Get-Culture).TextInfo.ToTitleCase($field.Name)
        $fieldName = "_" + $field.Name.ToLower()
        
        $required = ""
        if ($field.Required) {
            $required = "`n        [Required(ErrorMessage = `"$propertyName �O�������`")]"
        }
        
        $properties += @"
$required
        /// <summary>
        /// $($field.Description)
        /// </summary>
        public $($field.Type) $propertyName
        {
            get => $fieldName;
            set
            {
                $fieldName = value;
                OnPropertyChanged(nameof($propertyName));
            }
        }

"@
    }
    
    # �ͦ��غc�禡
    $constructors = @"
        /// <summary>
        /// �إ߷s�� $ResourceName �귽���
        /// </summary>
        public $ResourceName()
        {
        }

        /// <summary>
        /// �إ߷s�� $ResourceName �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public $ResourceName(string id)
        {
            Id = id;
        }
"@
    
    return @{
        Fields = $fields
        Properties = $properties
        Constructors = $constructors
        SubClasses = $subClasses
    }
}

# ������ɥͦ�
function Generate-IntelligentDocumentation {
    param([string]$ResourceName, [string]$Category)
    
    $purpose = Get-ResourcePurpose -ResourceName $ResourceName -Category $Category
    $examples = Get-ResourceExamples -ResourceName $ResourceName
    $r5Features = Get-R5Features -ResourceName $ResourceName
    
    return @"
    /// <summary>
    /// FHIR R5 $ResourceName �귽
    /// 
    /// <para>
    /// $purpose
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// $examples
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 �������D�n�S�I�G
    /// $r5Features
    /// </para>
    /// </remarks>
"@
}

# �귽�γ~�y�z�ͦ�
function Get-ResourcePurpose {
    param([string]$ResourceName, [string]$Category)
    
    $purposes = @{
        "AllergyIntolerance" = "�O���w�̪��L�Ӥ����M���}������T�A�]�A�L�ӭ�B�Y���{�שM�{�ɪ�{�C"
        "Appointment" = "�޲z�����w�����w�ơA�]�A�ɶ��B�ѻP�̡B�A����������T�C"
        "CarePlan" = "�y�z�w�̪��@�z�p���A�]�A�ؼСB���ʩM�ɶ��w�ơC"
        "Procedure" = "�O����w�̰��檺�����{�ǩΤ�N�A�]�A�ɶ��B��k�M���G�C"
        "DiagnosticReport" = "���ѶE�_�ˬd�����G���i�A�p���������B�v�����ˬd���C"
        "MedicationRequest" = "�O���Ī��B�誺�ԲӸ�T�A�]�A�Ī��B���q�B���Ĥ覡���C"
        "Task" = "�޲z�����u�@�y�{�������ȡA�]�A���Ȫ��A�B�t�d�H�M����ɶ��C"
        "Bundle" = "�N�h�� FHIR �귽�զX���@�Ӷ��X�A�Ω��ƶǿ�M�B�z�C"
        "Location" = "�y�z�����A�ȴ��Ѫ����z��m�ε����a�I�C"
    }
    
    # �ϥ� if-else �ӫD�T���B��l
    if ($purposes.ContainsKey($ResourceName)) {
        return $purposes[$ResourceName]
    } else {
        return "�o�O FHIR R5 �зǤ������n�귽�����A�Ω�������T���зǤƪ�ܩM�洫�C"
    }
}

# �d�ҥN�X�ͦ�
function Get-ResourceExamples {
    param([string]$ResourceName)
    
    $varName = $ResourceName.ToLower()
    return @"
var $varName = new $ResourceName("$varName-001");
// �]�w���n�ݩ�...
$varName.Status = new FhirCode("active");
"@
}

# R5 �S�I�y�z
function Get-R5Features {
    param([string]$ResourceName)
    
    return @"
- �W�j����Ƶ��c�M���ҳW�h
- ��i�����ާ@�ʩM�X�i��
- ��n���{�ɤu�@�y�{�䴩
"@
}

# ��q�ͦ��u�t��k
function Generate-BatchFactoryMethods {
    param([string[]]$ResourceNames)
    
    $factoryCode = @"
// ��q�ͦ����u�t��k
namespace FhirCore.R5.Factory
{
    public static partial class R5Factory
    {
"@
    
    foreach ($resourceName in $ResourceNames) {
        $factoryCode += @"

        #region $resourceName Factory Methods

        /// <summary>
        /// �Ыطs�� $resourceName �귽
        /// </summary>
        public static $resourceName Create$resourceName() => new();

        /// <summary>
        /// �Ыب㦳���w ID �� $resourceName �귽
        /// </summary>
        public static $resourceName Create$resourceName(string id) => new(id);

        /// <summary>
        /// �Ыش��եΪ� $resourceName �귽
        /// </summary>
        public static $resourceName CreateTest$resourceName(string suffix = "001")
        {
            var id = `$"test-$($resourceName.ToLower())-{suffix}";
            return new $resourceName(id);
        }

        #endregion
"@
    }
    
    $factoryCode += @"

    }
}
"@
    
    return $factoryCode
}

# �D����禡
function Main {
    Write-Host "?? AI ��q�ͦ� FHIR R5 �귽�}�l..." -ForegroundColor Green
    
    # �M�w�n�ͦ����귽
    if ($ResourceNames.Count -eq 0) {
        # �w�]�ͦ����u���Ÿ귽
        $ResourceNames = $AllR5Resources["Core-High"]
    }
    
    $generatedCount = 0
    $allFactoryMethods = @()
    
    foreach ($resourceName in $ResourceNames) {
        # �P�_�귽����
        $category = "Core-High"
        foreach ($cat in $AllR5Resources.Keys) {
            if ($AllR5Resources[$cat] -contains $resourceName) {
                $category = $cat
                break
            }
        }
        
        Write-Host "�ͦ��귽: $resourceName (����: $category)" -ForegroundColor Yellow
        
        # �ͦ��귽�N�X
        $resourceCode = Generate-SmartResource -ResourceName $resourceName -Category $category
        
        # �g�J�ɮ�
        $outputFile = Join-Path $OutputPath "$resourceName.cs"
        $outputDir = Split-Path $outputFile -Parent
        if (-not (Test-Path $outputDir)) {
            New-Item -ItemType Directory -Path $outputDir -Force | Out-Null
        }
        
        $resourceCode | Out-File -FilePath $outputFile -Encoding UTF8
        
        $allFactoryMethods += $resourceName
        $generatedCount++
        
        Write-Host "? ����: $resourceName" -ForegroundColor Green
    }
    
    # �ͦ��u�t��k
    if ($GenerateFactoryMethods) {
        Write-Host "�ͦ��u�t��k..." -ForegroundColor Yellow
        $factoryCode = Generate-BatchFactoryMethods -ResourceNames $allFactoryMethods
        $factoryFile = "FhirCore.R5\Factory\R5Factory_AIGenerated.cs"
        $factoryCode | Out-File -FilePath $factoryFile -Encoding UTF8
        Write-Host "? �u�t��k�w�ͦ�: $factoryFile" -ForegroundColor Green
    }
    
    Write-Host "?? AI ��q�ͦ������I" -ForegroundColor Green
    Write-Host "�ͦ��F $generatedCount �Ӹ귽" -ForegroundColor Cyan
}

# ����
Main