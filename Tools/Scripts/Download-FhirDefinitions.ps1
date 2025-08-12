# Download-FhirDefinitions.ps1
# 下載 FHIR 官方定義檔的腳本

param(
    [Parameter(Mandatory = $true)]
    [ValidateSet("R4", "R5", "R6")]
    [string]$Version,
    
    [string]$OutputPath = "Definitions",
    
    [switch]$Force = $false
)

$ErrorActionPreference = "Stop"

# FHIR 官方下載 URL
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
        Write-ColorMessage "  ?? 下載: $Url" "Yellow"
        
        $webClient = New-Object System.Net.WebClient
        $webClient.Headers.Add("User-Agent", "FHIR-Resource-Generator/1.0")
        $webClient.DownloadFile($Url, $OutputPath)
        
        $fileSize = (Get-Item $OutputPath).Length
        Write-ColorMessage "  ? 完成: $(Split-Path $OutputPath -Leaf) ($([math]::Round($fileSize/1KB, 2)) KB)" "Green"
        
        return $true
    }
    catch {
        Write-ColorMessage "  ? 失敗: $($_.Exception.Message)" "Red"
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
    
    Write-ColorMessage "  ?? 建立元資料檔案: metadata.json" "Cyan"
}

# 主程式開始
Write-ColorMessage "?? FHIR 定義檔下載工具" "Green"
Write-ColorMessage "版本: $Version" "White"
Write-ColorMessage ""

# 檢查版本支援
if (-not $DownloadUrls.ContainsKey($Version)) {
    Write-ColorMessage "? 不支援的版本: $Version" "Red"
    Write-ColorMessage "支援的版本: $($DownloadUrls.Keys -join ', ')" "Yellow"
    exit 1
}

# 建立輸出目錄
$targetDir = Join-Path $OutputPath $Version
if (Test-Path $targetDir) {
    if ($Force) {
        Write-ColorMessage "??? 清理現有目錄: $targetDir" "Yellow"
        Remove-Item $targetDir -Recurse -Force
    } else {
        Write-ColorMessage "?? 目錄已存在: $targetDir" "Yellow"
        Write-ColorMessage "使用 -Force 參數強制覆寫" "Yellow"
        exit 1
    }
}

Write-ColorMessage "?? 建立目錄: $targetDir" "Cyan"
New-Item -ItemType Directory -Path $targetDir -Force | Out-Null

# 下載定義檔
Write-ColorMessage "?? 下載 FHIR $Version 定義檔..." "Green"

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

# 建立元資料檔案
Create-MetadataFile -Version $Version -OutputDir $targetDir

if ($downloadSuccess) {
    Write-ColorMessage ""
    Write-ColorMessage "? FHIR $Version 定義檔下載完成！" "Green"
    Write-ColorMessage "?? 儲存位置: $targetDir" "White"
    
    # 顯示檔案清單
    Write-ColorMessage ""
    Write-ColorMessage "?? 下載的檔案:" "Cyan"
    Get-ChildItem $targetDir -Filter "*.json" | ForEach-Object {
        $size = [math]::Round($_.Length / 1KB, 2)
        Write-ColorMessage "  - $($_.Name) ($size KB)" "White"
    }
} else {
    Write-ColorMessage ""
    Write-ColorMessage "? 部分檔案下載失敗，請檢查網路連線後重試" "Red"
    exit 1
}

Write-ColorMessage ""
Write-ColorMessage "?? 下一步: 執行資源生成器" "Green"
Write-ColorMessage "dotnet run --project Tools/FhirResourceGenerator -- generate --version $Version" "Yellow"