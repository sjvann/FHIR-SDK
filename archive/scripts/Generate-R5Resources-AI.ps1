# AI 批量生成 FHIR R5 資源工具
# 基於模板和 AI 模式識別的資源生成器

param(
    [string[]]$ResourceNames = @(),
    [string]$TemplateMode = "Smart",  # Smart, Simple, Complete
    [string]$OutputPath = "FhirCore.R5\Resources",
    [switch]$GenerateFactoryMethods = $true,
    [switch]$GenerateDocumentation = $true
)

# 資源分類和模板
$ResourceTemplates = @{
    # 核心資源模板
    "Patient-like" = @{
        Pattern = @("Patient", "Person", "Practitioner", "RelatedPerson")
        RequiredProperties = @("identifier", "name", "active")
        CommonProperties = @("gender", "birthDate", "address", "telecom")
    }
    
    # 臨床資源模板  
    "Clinical-like" = @{
        Pattern = @("Condition", "Observation", "Procedure", "DiagnosticReport")
        RequiredProperties = @("status", "code", "subject")
        CommonProperties = @("encounter", "effectiveDateTime", "performer")
    }
    
    # 管理資源模板
    "Administrative-like" = @{
        Pattern = @("Organization", "Location", "HealthcareService", "Endpoint")
        RequiredProperties = @("active", "name")
        CommonProperties = @("identifier", "type", "telecom", "address")
    }
    
    # 工作流程資源模板
    "Workflow-like" = @{
        Pattern = @("Task", "Appointment", "Schedule", "Slot")
        RequiredProperties = @("status", "intent")
        CommonProperties = @("identifier", "subject", "for")
    }
}

# FHIR R5 完整資源列表（按優先級分組）
$AllR5Resources = @{
    # 第一批：高優先級核心資源 (20個)
    "Core-High" = @(
        "Account", "ActivityDefinition", "AllergyIntolerance", "Appointment", "AuditEvent",
        "Bundle", "CarePlan", "CareTeam", "Communication", "Composition", 
        "Consent", "Device", "DiagnosticReport", "Goal", "Group", 
        "Immunization", "Person", "RelatedPerson", "Schedule", "Slot"
    )
    
    # 第二批：臨床資源 (25個)
    "Clinical" = @(
        "ClinicalImpression", "DetectedIssue", "FamilyMemberHistory", "Flag", "MedicationAdministration",
        "MedicationDispense", "MedicationRequest", "MedicationStatement", "Procedure", "RiskAssessment",
        "ServiceRequest", "Specimen", "BodyStructure", "ImagingStudy", "MolecularSequence",
        "VisionPrescription", "NutritionOrder", "ClinicalUseDefinition", "Evidence", "EvidenceReport",
        "EvidenceVariable", "ResearchStudy", "ResearchSubject", "GuidanceResponse", "SupplyRequest"
    )
    
    # 第三批：管理和工作流程資源 (30個)  
    "Administrative" = @(
        "PractitionerRole", "HealthcareService", "Location", "AppointmentResponse", "Task",
        "MessageHeader", "MessageDefinition", "OperationOutcome", "Parameters", "Subscription",
        "Coverage", "ExplanationOfBenefit", "Claim", "ClaimResponse", "PaymentNotice",
        "PaymentReconciliation", "ChargeItem", "Invoice", "InsurancePlan", "Linkage",
        "List", "Library", "Measure", "MeasureReport", "SupplyDelivery", "EnrollmentRequest",
        "EnrollmentResponse", "VisionPrescription", "DeviceDefinition", "BiologicallyDerivedProduct"
    )
    
    # 第四批：定義和特殊資源 (40個)
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

# AI 模式：智能資源生成函式
function Generate-SmartResource {
    param(
        [string]$ResourceName,
        [string]$Category
    )
    
    # 根據資源名稱智能推斷屬性
    $intelligentProperties = Get-IntelligentProperties -ResourceName $ResourceName -Category $Category
    
    # 生成高品質的文檔
    $documentation = Generate-IntelligentDocumentation -ResourceName $ResourceName -Category $Category
    
    # 建立完整的資源代碼
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
        /// 資源類型
        /// </summary>
        public override string ResourceType => "$ResourceName";

$($intelligentProperties.Properties)

$($intelligentProperties.Constructors)

        /// <summary>
        /// 轉換為字串表示
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

# 智能屬性推斷
function Get-IntelligentProperties {
    param([string]$ResourceName, [string]$Category)
    
    $fields = ""
    $properties = ""
    $constructors = ""
    $subClasses = ""
    
    # 根據資源名稱和類別推斷常見屬性
    $commonFields = @()
    
    # 所有資源都有的基本屬性
    $commonFields += @{Name="identifier"; Type="List<Identifier>?"; Description="識別碼"}
    
    # 根據分類添加特定屬性
    switch ($Category) {
        "Core-High" {
            if ($ResourceName -match "Person|Patient|Practitioner") {
                $commonFields += @{Name="name"; Type="List<HumanName>?"; Description="姓名"}
                $commonFields += @{Name="telecom"; Type="List<ContactPoint>?"; Description="聯絡方式"}
                $commonFields += @{Name="gender"; Type="FhirCode?"; Description="性別"}
                $commonFields += @{Name="birthDate"; Type="FhirDate?"; Description="出生日期"}
                $commonFields += @{Name="active"; Type="FhirBoolean?"; Description="是否啟用"}
            }
            if ($ResourceName -match "Organization|Location") {
                $commonFields += @{Name="name"; Type="FhirString?"; Description="名稱"}
                $commonFields += @{Name="type"; Type="List<CodeableConcept>?"; Description="類型"}
                $commonFields += @{Name="active"; Type="FhirBoolean?"; Description="是否啟用"}
            }
            if ($ResourceName -match "Appointment|Schedule") {
                $commonFields += @{Name="status"; Type="FhirCode?"; Description="狀態"; Required=$true}
                $commonFields += @{Name="serviceType"; Type="List<CodeableConcept>?"; Description="服務類型"}
                $commonFields += @{Name="start"; Type="FhirDateTime?"; Description="開始時間"}
                $commonFields += @{Name="end"; Type="FhirDateTime?"; Description="結束時間"}
            }
        }
        "Clinical" {
            $commonFields += @{Name="status"; Type="FhirCode?"; Description="狀態"; Required=$true}
            $commonFields += @{Name="code"; Type="CodeableConcept?"; Description="代碼"}
            $commonFields += @{Name="subject"; Type="DataTypeServices.DataTypes.SpecialTypes.ReferenceType?"; Description="主體"; Required=$true}
            $commonFields += @{Name="encounter"; Type="DataTypeServices.DataTypes.SpecialTypes.ReferenceType?"; Description="就診"}
            
            if ($ResourceName -match "Medication") {
                $commonFields += @{Name="effectiveDateTime"; Type="FhirDateTime?"; Description="生效時間"}
                $commonFields += @{Name="dosage"; Type="List<Dosage>?"; Description="劑量"}
            }
            if ($ResourceName -match "Procedure|Observation") {
                $commonFields += @{Name="performedDateTime"; Type="FhirDateTime?"; Description="執行時間"}
                $commonFields += @{Name="performer"; Type="List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>?"; Description="執行者"}
            }
        }
        "Administrative" {
            $commonFields += @{Name="active"; Type="FhirBoolean?"; Description="是否啟用"}
            $commonFields += @{Name="period"; Type="Period?"; Description="有效期間"}
            
            if ($ResourceName -match "Task") {
                $commonFields += @{Name="status"; Type="FhirCode?"; Description="狀態"; Required=$true}
                $commonFields += @{Name="intent"; Type="FhirCode?"; Description="意圖"; Required=$true}
                $commonFields += @{Name="for"; Type="DataTypeServices.DataTypes.SpecialTypes.ReferenceType?"; Description="對象"}
            }
        }
        "Definition" {
            $commonFields += @{Name="url"; Type="FhirUri?"; Description="URL"}
            $commonFields += @{Name="version"; Type="FhirString?"; Description="版本"}
            $commonFields += @{Name="name"; Type="FhirString?"; Description="名稱"}
            $commonFields += @{Name="status"; Type="FhirCode?"; Description="狀態"; Required=$true}
            $commonFields += @{Name="date"; Type="FhirDateTime?"; Description="日期"}
            $commonFields += @{Name="publisher"; Type="FhirString?"; Description="發布者"}
        }
    }
    
    # 生成私有欄位
    foreach ($field in $commonFields) {
        $fieldName = "_" + $field.Name.ToLower()
        $fields += "        private $($field.Type) $fieldName;`n"
    }
    
    # 生成公開屬性
    foreach ($field in $commonFields) {
        $propertyName = (Get-Culture).TextInfo.ToTitleCase($field.Name)
        $fieldName = "_" + $field.Name.ToLower()
        
        $required = ""
        if ($field.Required) {
            $required = "`n        [Required(ErrorMessage = `"$propertyName 是必填欄位`")]"
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
    
    # 生成建構函式
    $constructors = @"
        /// <summary>
        /// 建立新的 $ResourceName 資源實例
        /// </summary>
        public $ResourceName()
        {
        }

        /// <summary>
        /// 建立新的 $ResourceName 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
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

# 智能文檔生成
function Generate-IntelligentDocumentation {
    param([string]$ResourceName, [string]$Category)
    
    $purpose = Get-ResourcePurpose -ResourceName $ResourceName -Category $Category
    $examples = Get-ResourceExamples -ResourceName $ResourceName
    $r5Features = Get-R5Features -ResourceName $ResourceName
    
    return @"
    /// <summary>
    /// FHIR R5 $ResourceName 資源
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
    /// R5 版本的主要特點：
    /// $r5Features
    /// </para>
    /// </remarks>
"@
}

# 資源用途描述生成
function Get-ResourcePurpose {
    param([string]$ResourceName, [string]$Category)
    
    $purposes = @{
        "AllergyIntolerance" = "記錄患者的過敏反應和不良反應資訊，包括過敏原、嚴重程度和臨床表現。"
        "Appointment" = "管理醫療預約的安排，包括時間、參與者、服務類型等資訊。"
        "CarePlan" = "描述患者的護理計劃，包括目標、活動和時間安排。"
        "Procedure" = "記錄對患者執行的醫療程序或手術，包括時間、方法和結果。"
        "DiagnosticReport" = "提供診斷檢查的結果報告，如實驗室檢驗、影像學檢查等。"
        "MedicationRequest" = "記錄藥物處方的詳細資訊，包括藥物、劑量、給藥方式等。"
        "Task" = "管理醫療工作流程中的任務，包括任務狀態、負責人和執行時間。"
        "Bundle" = "將多個 FHIR 資源組合成一個集合，用於資料傳輸和處理。"
        "Location" = "描述醫療服務提供的物理位置或虛擬地點。"
    }
    
    # 使用 if-else 而非三元運算子
    if ($purposes.ContainsKey($ResourceName)) {
        return $purposes[$ResourceName]
    } else {
        return "這是 FHIR R5 標準中的重要資源類型，用於醫療資訊的標準化表示和交換。"
    }
}

# 範例代碼生成
function Get-ResourceExamples {
    param([string]$ResourceName)
    
    $varName = $ResourceName.ToLower()
    return @"
var $varName = new $ResourceName("$varName-001");
// 設定必要屬性...
$varName.Status = new FhirCode("active");
"@
}

# R5 特點描述
function Get-R5Features {
    param([string]$ResourceName)
    
    return @"
- 增強的資料結構和驗證規則
- 改進的互操作性和擴展性
- 更好的臨床工作流程支援
"@
}

# 批量生成工廠方法
function Generate-BatchFactoryMethods {
    param([string[]]$ResourceNames)
    
    $factoryCode = @"
// 批量生成的工廠方法
namespace FhirCore.R5.Factory
{
    public static partial class R5Factory
    {
"@
    
    foreach ($resourceName in $ResourceNames) {
        $factoryCode += @"

        #region $resourceName Factory Methods

        /// <summary>
        /// 創建新的 $resourceName 資源
        /// </summary>
        public static $resourceName Create$resourceName() => new();

        /// <summary>
        /// 創建具有指定 ID 的 $resourceName 資源
        /// </summary>
        public static $resourceName Create$resourceName(string id) => new(id);

        /// <summary>
        /// 創建測試用的 $resourceName 資源
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

# 主執行函式
function Main {
    Write-Host "?? AI 批量生成 FHIR R5 資源開始..." -ForegroundColor Green
    
    # 決定要生成的資源
    if ($ResourceNames.Count -eq 0) {
        # 預設生成高優先級資源
        $ResourceNames = $AllR5Resources["Core-High"]
    }
    
    $generatedCount = 0
    $allFactoryMethods = @()
    
    foreach ($resourceName in $ResourceNames) {
        # 判斷資源分類
        $category = "Core-High"
        foreach ($cat in $AllR5Resources.Keys) {
            if ($AllR5Resources[$cat] -contains $resourceName) {
                $category = $cat
                break
            }
        }
        
        Write-Host "生成資源: $resourceName (分類: $category)" -ForegroundColor Yellow
        
        # 生成資源代碼
        $resourceCode = Generate-SmartResource -ResourceName $resourceName -Category $category
        
        # 寫入檔案
        $outputFile = Join-Path $OutputPath "$resourceName.cs"
        $outputDir = Split-Path $outputFile -Parent
        if (-not (Test-Path $outputDir)) {
            New-Item -ItemType Directory -Path $outputDir -Force | Out-Null
        }
        
        $resourceCode | Out-File -FilePath $outputFile -Encoding UTF8
        
        $allFactoryMethods += $resourceName
        $generatedCount++
        
        Write-Host "? 完成: $resourceName" -ForegroundColor Green
    }
    
    # 生成工廠方法
    if ($GenerateFactoryMethods) {
        Write-Host "生成工廠方法..." -ForegroundColor Yellow
        $factoryCode = Generate-BatchFactoryMethods -ResourceNames $allFactoryMethods
        $factoryFile = "FhirCore.R5\Factory\R5Factory_AIGenerated.cs"
        $factoryCode | Out-File -FilePath $factoryFile -Encoding UTF8
        Write-Host "? 工廠方法已生成: $factoryFile" -ForegroundColor Green
    }
    
    Write-Host "?? AI 批量生成完成！" -ForegroundColor Green
    Write-Host "生成了 $generatedCount 個資源" -ForegroundColor Cyan
}

# 執行
Main