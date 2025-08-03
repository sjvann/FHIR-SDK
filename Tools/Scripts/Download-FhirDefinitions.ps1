# Download-FhirDefinitions.ps1
# �U�� FHIR �x��w�q�ɪ��}��

param(
    [Parameter(Mandatory = $true)]
    [ValidateSet("R4", "R5", "R6")]
    [string]$Version,
    
    [string]$OutputPath = "Definitions",
    
    [switch]$Force = $false
)

$ErrorActionPreference = "Stop"

# FHIR �x��U�� URL
$DownloadUrls = @{
    "R4" = @{
        "profiles-resources" = "http://hl7.org/fhir/R4/profiles-resources.json"
        "profiles-types"     = "http://hl7.org/fhir/R4/profiles-types.json"
        "valuesets"          = "http://hl7.org/fhir/R4/valuesets.json"
    }
    "R5" = @{
        "profiles-resources" = "http://hl7.org/fhir/R5/profiles-resources.json"
        "profiles-types"     = "http://hl7.org/fhir/R5/profiles-types.json"
        "valuesets"          = "http://hl7.org/fhir/R5/valuesets.json"
    }
}

function Write-ColorMessage {
    param(
        [string]$Message,
        [string]$Color = "White"
    )
    Write-Host $Message -ForegroundColor $Color
}

function Download-File {
    param(
        [string]$Url,
        [string]$OutputPath
    )
    
    try {
        Write-ColorMessage "  ?? �U��: $Url" "Yellow"
        
        $webClient = New-Object System.Net.WebClient
        $webClient.Headers.Add("User-Agent", "FHIR-Resource-Generator/1.0")
        $webClient.DownloadFile($Url, $OutputPath)
        
        $fileSize = (Get-Item $OutputPath).Length
        Write-ColorMessage "  ? ����: $(Split-Path $OutputPath -Leaf) ($([math]::Round($fileSize/1KB, 2)) KB)" "Green"
        
        return $true
    }
    catch {
        Write-ColorMessage "  ? ����: $($_.Exception.Message)" "Red"
        return $false
    }
}

function Create-MetadataFile {
    param(
        [string]$Version,
        [string]$OutputDir
    )
    
    $metadata = @{
        version = switch ($Version) {
            "R4" { "4.0.1" }
            "R5" { "5.0.0" }
            "R6" { "6.0.0" }
        }
        fhirVersion = $Version
        downloadDate = Get-Date -Format "yyyy-MM-ddTHH:mm:ssZ"
        generator = "FHIR-Resource-Generator"
        generatorVersion = "1.0.0"
    }
    
    $metadataPath = Join-Path $OutputDir "metadata.json"
    $metadata | ConvertTo-Json -Depth 3 | Out-File -FilePath $metadataPath -Encoding UTF8
    
    Write-ColorMessage "  ?? �إߤ�����ɮ�: metadata.json" "Cyan"
}

# �D�{���}�l
Write-ColorMessage "?? FHIR �w�q�ɤU���u��" "Green"
Write-ColorMessage "����: $Version" "White"
Write-ColorMessage ""

# �ˬd�����䴩
if (-not $DownloadUrls.ContainsKey($Version)) {
    Write-ColorMessage "? ���䴩������: $Version" "Red"
    Write-ColorMessage "�䴩������: $($DownloadUrls.Keys -join ', ')" "Yellow"
    exit 1
}

# �إ߿�X�ؿ�
$targetDir = Join-Path $OutputPath $Version
if (Test-Path $targetDir) {
    if ($Force) {
        Write-ColorMessage "??? �M�z�{���ؿ�: $targetDir" "Yellow"
        Remove-Item $targetDir -Recurse -Force
    } else {
        Write-ColorMessage "?? �ؿ��w�s�b: $targetDir" "Yellow"
        Write-ColorMessage "�ϥ� -Force �ѼƱj���мg" "Yellow"
        exit 1
    }
}

Write-ColorMessage "?? �إߥؿ�: $targetDir" "Cyan"
New-Item -ItemType Directory -Path $targetDir -Force | Out-Null

# �U���w�q��
Write-ColorMessage "?? �U�� FHIR $Version �w�q��..." "Green"

$urls = $DownloadUrls[$Version]
$downloadSuccess = $true

foreach ($file in $urls.Keys) {
    $url = $urls[$file]
    $outputFile = Join-Path $targetDir "$file.json"
    
    $success = Download-File -Url $url -OutputPath $outputFile
    if (-not $success) {
        $downloadSuccess = $false
    }
}

# �إߤ�����ɮ�
Create-MetadataFile -Version $Version -OutputDir $targetDir

if ($downloadSuccess) {
    Write-ColorMessage ""
    Write-ColorMessage "? FHIR $Version �w�q�ɤU�������I" "Green"
    Write-ColorMessage "?? �x�s��m: $targetDir" "White"
    
    # ����ɮײM��
    Write-ColorMessage ""
    Write-ColorMessage "?? �U�����ɮ�:" "Cyan"
    Get-ChildItem $targetDir -Filter "*.json" | ForEach-Object {
        $size = [math]::Round($_.Length / 1KB, 2)
        Write-ColorMessage "  - $($_.Name) ($size KB)" "White"
    }
} else {
    Write-ColorMessage ""
    Write-ColorMessage "? �����ɮפU�����ѡA���ˬd�����s�u�᭫��" "Red"
    exit 1
}

Write-ColorMessage ""
Write-ColorMessage "?? �U�@�B: ����귽�ͦ���" "Green"
Write-ColorMessage "dotnet run --project Tools/FhirResourceGenerator -- generate --version $Version" "Yellow"