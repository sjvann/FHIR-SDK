# FHIR R5 資源遷移主控腳本
# 整合自動化遷移和 AI 生成兩種方案

param(
    [ValidateSet("Migration", "AI", "Hybrid", "Analysis")]
    [string]$Mode = "Hybrid",
    [switch]$DryRun = $false,
    [string]$Priority = "High"  # High, Medium, Low, All
)

$ErrorActionPreference = "Stop"

Write-Host @"
?? FHIR R5 資源遷移加速工具
═══════════════════════════════════════════════

模式: $Mode
優先級: $Priority  
乾運行: $DryRun

"@ -ForegroundColor Cyan

# 資源優先級分組
$ResourcePriority = @{
    "High" = @(
        # 最重要的核心資源 (20個)
        "AllergyIntolerance", "Appointment", "Bundle", "CarePlan", "CareTeam",
        "Communication", "Composition", "DiagnosticReport", "Goal", "Group", 
        "Immunization", "Person", "RelatedPerson", "Schedule", "Slot",
        "Account", "ActivityDefinition", "AuditEvent", "Consent", "Device"
    )
    "Medium" = @(
        # 重要的臨床資源 (25個)
        "Procedure", "MedicationRequest", "MedicationAdministration", "MedicationDispense", 
        "MedicationStatement", "ClinicalImpression", "DetectedIssue", "FamilyMemberHistory",
        "Flag", "RiskAssessment", "ServiceRequest", "Specimen", "BodyStructure",
        "ImagingStudy", "MolecularSequence", "VisionPrescription", "NutritionOrder",
        "ClinicalUseDefinition", "Evidence", "EvidenceReport", "EvidenceVariable",
        "ResearchStudy", "ResearchSubject", "GuidanceResponse", "SupplyRequest"
    )
    "Low" = @(
        # 管理和定義資源 (剩餘的所有資源)
        "PractitionerRole", "HealthcareService", "Location", "AppointmentResponse", "Task",
        "MessageHeader", "MessageDefinition", "OperationOutcome", "Parameters", "Subscription",
        "Coverage", "ExplanationOfBenefit", "Claim", "ClaimResponse", "PaymentNotice",
        "PaymentReconciliation", "ChargeItem", "Invoice", "InsurancePlan", "Linkage",
        "List", "Library", "Measure", "MeasureReport", "StructureDefinition", "StructureMap",
        "CapabilityStatement", "OperationDefinition", "SearchParameter", "CodeSystem", "ValueSet",
        "ConceptMap", "NamingSystem", "TerminologyCapabilities", "ImplementationGuide",
        "TestScript", "TestReport", "TestPlan", "Questionnaire", "QuestionnaireResponse",
        "PlanDefinition", "Substance", "SubstanceDefinition", "SpecimenDefinition",
        "ObservationDefinition", "ActorDefinition", "Requirements", "GraphDefinition",
        "ExampleScenario", "CompartmentDefinition", "ChargeItemDefinition", "EventDefinition",
        "CatalogEntry", "Citation", "ArtifactAssessment", "Binary", "DocumentReference",
        "Media", "Endpoint", "Provenance", "ImagingSelection", "Transport", "Permission",
        "VerificationResult", "InventoryItem", "InventoryReport", "FormularyItem", "GenomicStudy"
    )
}

# 分析現有資源狀況
function Analyze-CurrentStatus {
    Write-Host "?? 分析當前資源狀況..." -ForegroundColor Yellow
    
    $sourceFiles = Get-ChildItem -Path "ResourceTypeServices\R5" -Filter "*.cs" | Where-Object { $_.Name -notmatch "Choice|Participant|Stage" }
    $targetFiles = Get-ChildItem -Path "FhirCore.R5\Resources" -Filter "*.cs" -ErrorAction SilentlyContinue
    
    $sourceResources = $sourceFiles | ForEach-Object { [System.IO.Path]::GetFileNameWithoutExtension($_.Name) }
    $completedResources = $targetFiles | ForEach-Object { [System.IO.Path]::GetFileNameWithoutExtension($_.Name) }
    
    $pendingResources = $sourceResources | Where-Object { $_ -notin $completedResources }
    
    Write-Host @"
?? 資源狀況分析報告
═══════════════════════════════════════

總資源數: $($sourceResources.Count)
已完成: $($completedResources.Count)
待處理: $($pendingResources.Count)

已完成的資源:
$($completedResources -join ", ")

待處理的資源:
$($pendingResources -join ", ")

"@ -ForegroundColor Green

    return @{
        SourceResources = $sourceResources
        CompletedResources = $completedResources  
        PendingResources = $pendingResources
    }
}

# 執行遷移模式
function Execute-Migration {
    param([string[]]$Resources)
    
    Write-Host "?? 執行自動化遷移..." -ForegroundColor Yellow
    
    $migrationScript = "scripts\Migrate-R5Resources.ps1"
    if (Test-Path $migrationScript) {
        & $migrationScript -DryRun:$DryRun
    } else {
        Write-Warning "遷移腳本不存在: $migrationScript"
    }
}

# 執行 AI 生成模式
function Execute-AIGeneration {
    param([string[]]$Resources)
    
    Write-Host "?? 執行 AI 批量生成..." -ForegroundColor Yellow
    
    $aiScript = "scripts\Generate-R5Resources-AI.ps1"
    if (Test-Path $aiScript) {
        & $aiScript -ResourceNames $Resources -GenerateFactoryMethods -GenerateDocumentation
    } else {
        Write-Warning "AI 生成腳本不存在: $aiScript"
    }
}

# 混合模式：智能選擇策略
function Execute-HybridMode {
    param($AnalysisResult)
    
    Write-Host "?? 執行混合模式..." -ForegroundColor Yellow
    
    # 取得要處理的資源
    $targetResources = switch ($Priority) {
        "High" { $ResourcePriority["High"] }
        "Medium" { $ResourcePriority["High"] + $ResourcePriority["Medium"] }
        "Low" { $ResourcePriority["Low"] }
        "All" { $ResourcePriority["High"] + $ResourcePriority["Medium"] + $ResourcePriority["Low"] }
    }
    
    $pendingTargets = $targetResources | Where-Object { $_ -in $AnalysisResult.PendingResources }
    
    Write-Host "?? 將處理 $($pendingTargets.Count) 個資源 (優先級: $Priority)" -ForegroundColor Cyan
    
    # 分類資源：複雜的用遷移，簡單的用 AI 生成
    $complexResources = @()
    $simpleResources = @()
    
    foreach ($resource in $pendingTargets) {
        $sourceFile = "ResourceTypeServices\R5\$resource.cs"
        if (Test-Path $sourceFile) {
            $content = Get-Content $sourceFile -Raw
            
            # 判斷複雜度
            $choiceTypeCount = ([regex]::Matches($content, "Choice : ChoiceType")).Count
            $backboneCount = ([regex]::Matches($content, "BackboneElementType")).Count
            $propertyCount = ([regex]::Matches($content, "public .+ \w+ \{")).Count
            
            if ($choiceTypeCount -gt 1 -or $backboneCount -gt 2 -or $propertyCount -gt 15) {
                $complexResources += $resource
            } else {
                $simpleResources += $resource
            }
        } else {
            # 如果原始檔案不存在，用 AI 生成
            $simpleResources += $resource
        }
    }
    
    Write-Host @"
?? 資源分類結果:
─────────────────────────────────────────
複雜資源 (使用遷移): $($complexResources.Count) 個
簡單資源 (使用 AI): $($simpleResources.Count) 個

複雜資源: $($complexResources -join ", ")
簡單資源: $($simpleResources -join ", ")

"@ -ForegroundColor Green
    
    # 執行複雜資源遷移
    if ($complexResources.Count -gt 0) {
        Write-Host "?? 處理複雜資源..." -ForegroundColor Yellow
        Execute-Migration -Resources $complexResources
    }
    
    # 執行簡單資源 AI 生成
    if ($simpleResources.Count -gt 0) {
        Write-Host "?? 處理簡單資源..." -ForegroundColor Yellow
        Execute-AIGeneration -Resources $simpleResources
    }
}

# 驗證和建置
function Validate-Results {
    Write-Host "?? 驗證結果..." -ForegroundColor Yellow
    
    if (-not $DryRun) {
        Write-Host "正在執行建置驗證..." -ForegroundColor Cyan
        
        try {
            $buildResult = & dotnet build FhirCore.R5\FhirCore.R5.csproj 2>&1
            if ($LASTEXITCODE -eq 0) {
                Write-Host "? 建置成功！" -ForegroundColor Green
            } else {
                Write-Host "? 建置失敗，請檢查錯誤：" -ForegroundColor Red
                Write-Host $buildResult -ForegroundColor Red
            }
        } catch {
            Write-Host "? 建置驗證時發生錯誤: $($_.Exception.Message)" -ForegroundColor Red
        }
    }
}

# 生成進度報告
function Generate-ProgressReport {
    param($AnalysisResult)
    
    $totalResources = 159  # FHIR R5 總資源數
    $completedCount = $AnalysisResult.CompletedResources.Count
    $progressPercentage = [math]::Round(($completedCount / $totalResources) * 100, 1)
    
    $report = @"
?? FHIR R5 資源遷移進度報告
═══════════════════════════════════════════════
執行時間: $(Get-Date -Format "yyyy-MM-dd HH:mm:ss")
執行模式: $Mode
優先級: $Priority

進度統計:
─────────────────────────────────────────
總資源數: $totalResources
已完成: $completedCount
進度: $progressPercentage%
剩餘: $($totalResources - $completedCount)

已完成資源:
─────────────────────────────────────────
$($AnalysisResult.CompletedResources -join "`n")

"@
    
    Write-Host $report -ForegroundColor Green
    
    # 寫入報告檔案
    $reportFile = "reports\migration-progress-$(Get-Date -Format 'yyyyMMdd-HHmmss').md"
    $reportDir = Split-Path $reportFile -Parent
    if (-not (Test-Path $reportDir)) {
        New-Item -ItemType Directory -Path $reportDir -Force | Out-Null
    }
    
    $report | Out-File -FilePath $reportFile -Encoding UTF8
    Write-Host "?? 進度報告已儲存: $reportFile" -ForegroundColor Cyan
}

# 主執行邏輯
function Main {
    try {
        # 分析現狀
        $analysisResult = Analyze-CurrentStatus
        
        # 根據模式執行
        switch ($Mode) {
            "Analysis" {
                # 僅分析，不執行
                Write-Host "? 分析完成，未執行遷移" -ForegroundColor Green
            }
            "Migration" {
                Execute-Migration -Resources $analysisResult.PendingResources
                Validate-Results
            }
            "AI" {
                $targetResources = $ResourcePriority[$Priority]
                $pendingTargets = $targetResources | Where-Object { $_ -in $analysisResult.PendingResources }
                Execute-AIGeneration -Resources $pendingTargets
                Validate-Results
            }
            "Hybrid" {
                Execute-HybridMode -AnalysisResult $analysisResult
                Validate-Results
            }
        }
        
        # 生成進度報告
        Generate-ProgressReport -AnalysisResult $analysisResult
        
        Write-Host "?? 遷移加速工具執行完成！" -ForegroundColor Green
        
    } catch {
        Write-Host "? 執行過程中發生錯誤: $($_.Exception.Message)" -ForegroundColor Red
        exit 1
    }
}

# 執行主邏輯
Main