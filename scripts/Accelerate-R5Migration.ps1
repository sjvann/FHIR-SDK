# FHIR R5 �귽�E���D���}��
# ��X�۰ʤƾE���M AI �ͦ���ؤ��

param(
    [ValidateSet("Migration", "AI", "Hybrid", "Analysis")]
    [string]$Mode = "Hybrid",
    [switch]$DryRun = $false,
    [string]$Priority = "High"  # High, Medium, Low, All
)

$ErrorActionPreference = "Stop"

Write-Host @"
?? FHIR R5 �귽�E���[�t�u��
����������������������������������������������������������������������������������������������

�Ҧ�: $Mode
�u����: $Priority  
���B��: $DryRun

"@ -ForegroundColor Cyan

# �귽�u���Ť���
$ResourcePriority = @{
    "High" = @(
        # �̭��n���֤߸귽 (20��)
        "AllergyIntolerance", "Appointment", "Bundle", "CarePlan", "CareTeam",
        "Communication", "Composition", "DiagnosticReport", "Goal", "Group", 
        "Immunization", "Person", "RelatedPerson", "Schedule", "Slot",
        "Account", "ActivityDefinition", "AuditEvent", "Consent", "Device"
    )
    "Medium" = @(
        # ���n���{�ɸ귽 (25��)
        "Procedure", "MedicationRequest", "MedicationAdministration", "MedicationDispense", 
        "MedicationStatement", "ClinicalImpression", "DetectedIssue", "FamilyMemberHistory",
        "Flag", "RiskAssessment", "ServiceRequest", "Specimen", "BodyStructure",
        "ImagingStudy", "MolecularSequence", "VisionPrescription", "NutritionOrder",
        "ClinicalUseDefinition", "Evidence", "EvidenceReport", "EvidenceVariable",
        "ResearchStudy", "ResearchSubject", "GuidanceResponse", "SupplyRequest"
    )
    "Low" = @(
        # �޲z�M�w�q�귽 (�Ѿl���Ҧ��귽)
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

# ���R�{���귽���p
function Analyze-CurrentStatus {
    Write-Host "?? ���R��e�귽���p..." -ForegroundColor Yellow
    
    $sourceFiles = Get-ChildItem -Path "ResourceTypeServices\R5" -Filter "*.cs" | Where-Object { $_.Name -notmatch "Choice|Participant|Stage" }
    $targetFiles = Get-ChildItem -Path "FhirCore.R5\Resources" -Filter "*.cs" -ErrorAction SilentlyContinue
    
    $sourceResources = $sourceFiles | ForEach-Object { [System.IO.Path]::GetFileNameWithoutExtension($_.Name) }
    $completedResources = $targetFiles | ForEach-Object { [System.IO.Path]::GetFileNameWithoutExtension($_.Name) }
    
    $pendingResources = $sourceResources | Where-Object { $_ -notin $completedResources }
    
    Write-Host @"
?? �귽���p���R���i
������������������������������������������������������������������������������

�`�귽��: $($sourceResources.Count)
�w����: $($completedResources.Count)
�ݳB�z: $($pendingResources.Count)

�w�������귽:
$($completedResources -join ", ")

�ݳB�z���귽:
$($pendingResources -join ", ")

"@ -ForegroundColor Green

    return @{
        SourceResources = $sourceResources
        CompletedResources = $completedResources  
        PendingResources = $pendingResources
    }
}

# ����E���Ҧ�
function Execute-Migration {
    param([string[]]$Resources)
    
    Write-Host "?? ����۰ʤƾE��..." -ForegroundColor Yellow
    
    $migrationScript = "scripts\Migrate-R5Resources.ps1"
    if (Test-Path $migrationScript) {
        & $migrationScript -DryRun:$DryRun
    } else {
        Write-Warning "�E���}�����s�b: $migrationScript"
    }
}

# ���� AI �ͦ��Ҧ�
function Execute-AIGeneration {
    param([string[]]$Resources)
    
    Write-Host "?? ���� AI ��q�ͦ�..." -ForegroundColor Yellow
    
    $aiScript = "scripts\Generate-R5Resources-AI.ps1"
    if (Test-Path $aiScript) {
        & $aiScript -ResourceNames $Resources -GenerateFactoryMethods -GenerateDocumentation
    } else {
        Write-Warning "AI �ͦ��}�����s�b: $aiScript"
    }
}

# �V�X�Ҧ��G�����ܵ���
function Execute-HybridMode {
    param($AnalysisResult)
    
    Write-Host "?? ����V�X�Ҧ�..." -ForegroundColor Yellow
    
    # ���o�n�B�z���귽
    $targetResources = switch ($Priority) {
        "High" { $ResourcePriority["High"] }
        "Medium" { $ResourcePriority["High"] + $ResourcePriority["Medium"] }
        "Low" { $ResourcePriority["Low"] }
        "All" { $ResourcePriority["High"] + $ResourcePriority["Medium"] + $ResourcePriority["Low"] }
    }
    
    $pendingTargets = $targetResources | Where-Object { $_ -in $AnalysisResult.PendingResources }
    
    Write-Host "?? �N�B�z $($pendingTargets.Count) �Ӹ귽 (�u����: $Priority)" -ForegroundColor Cyan
    
    # �����귽�G�������ξE���A²�檺�� AI �ͦ�
    $complexResources = @()
    $simpleResources = @()
    
    foreach ($resource in $pendingTargets) {
        $sourceFile = "ResourceTypeServices\R5\$resource.cs"
        if (Test-Path $sourceFile) {
            $content = Get-Content $sourceFile -Raw
            
            # �P�_������
            $choiceTypeCount = ([regex]::Matches($content, "Choice : ChoiceType")).Count
            $backboneCount = ([regex]::Matches($content, "BackboneElementType")).Count
            $propertyCount = ([regex]::Matches($content, "public .+ \w+ \{")).Count
            
            if ($choiceTypeCount -gt 1 -or $backboneCount -gt 2 -or $propertyCount -gt 15) {
                $complexResources += $resource
            } else {
                $simpleResources += $resource
            }
        } else {
            # �p�G��l�ɮפ��s�b�A�� AI �ͦ�
            $simpleResources += $resource
        }
    }
    
    Write-Host @"
?? �귽�������G:
�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w
�����귽 (�ϥξE��): $($complexResources.Count) ��
²��귽 (�ϥ� AI): $($simpleResources.Count) ��

�����귽: $($complexResources -join ", ")
²��귽: $($simpleResources -join ", ")

"@ -ForegroundColor Green
    
    # ��������귽�E��
    if ($complexResources.Count -gt 0) {
        Write-Host "?? �B�z�����귽..." -ForegroundColor Yellow
        Execute-Migration -Resources $complexResources
    }
    
    # ����²��귽 AI �ͦ�
    if ($simpleResources.Count -gt 0) {
        Write-Host "?? �B�z²��귽..." -ForegroundColor Yellow
        Execute-AIGeneration -Resources $simpleResources
    }
}

# ���ҩM�ظm
function Validate-Results {
    Write-Host "?? ���ҵ��G..." -ForegroundColor Yellow
    
    if (-not $DryRun) {
        Write-Host "���b����ظm����..." -ForegroundColor Cyan
        
        try {
            $buildResult = & dotnet build FhirCore.R5\FhirCore.R5.csproj 2>&1
            if ($LASTEXITCODE -eq 0) {
                Write-Host "? �ظm���\�I" -ForegroundColor Green
            } else {
                Write-Host "? �ظm���ѡA���ˬd���~�G" -ForegroundColor Red
                Write-Host $buildResult -ForegroundColor Red
            }
        } catch {
            Write-Host "? �ظm���Үɵo�Ϳ��~: $($_.Exception.Message)" -ForegroundColor Red
        }
    }
}

# �ͦ��i�׳��i
function Generate-ProgressReport {
    param($AnalysisResult)
    
    $totalResources = 159  # FHIR R5 �`�귽��
    $completedCount = $AnalysisResult.CompletedResources.Count
    $progressPercentage = [math]::Round(($completedCount / $totalResources) * 100, 1)
    
    $report = @"
?? FHIR R5 �귽�E���i�׳��i
����������������������������������������������������������������������������������������������
����ɶ�: $(Get-Date -Format "yyyy-MM-dd HH:mm:ss")
����Ҧ�: $Mode
�u����: $Priority

�i�ײέp:
�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w
�`�귽��: $totalResources
�w����: $completedCount
�i��: $progressPercentage%
�Ѿl: $($totalResources - $completedCount)

�w�����귽:
�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w�w
$($AnalysisResult.CompletedResources -join "`n")

"@
    
    Write-Host $report -ForegroundColor Green
    
    # �g�J���i�ɮ�
    $reportFile = "reports\migration-progress-$(Get-Date -Format 'yyyyMMdd-HHmmss').md"
    $reportDir = Split-Path $reportFile -Parent
    if (-not (Test-Path $reportDir)) {
        New-Item -ItemType Directory -Path $reportDir -Force | Out-Null
    }
    
    $report | Out-File -FilePath $reportFile -Encoding UTF8
    Write-Host "?? �i�׳��i�w�x�s: $reportFile" -ForegroundColor Cyan
}

# �D�����޿�
function Main {
    try {
        # ���R�{��
        $analysisResult = Analyze-CurrentStatus
        
        # �ھڼҦ�����
        switch ($Mode) {
            "Analysis" {
                # �Ȥ��R�A������
                Write-Host "? ���R�����A������E��" -ForegroundColor Green
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
        
        # �ͦ��i�׳��i
        Generate-ProgressReport -AnalysisResult $analysisResult
        
        Write-Host "?? �E���[�t�u����槹���I" -ForegroundColor Green
        
    } catch {
        Write-Host "? ����L�{���o�Ϳ��~: $($_.Exception.Message)" -ForegroundColor Red
        exit 1
    }
}

# ����D�޿�
Main