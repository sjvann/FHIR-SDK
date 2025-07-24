param(
    [string]$Version = "R4",
    [string]$OutputPath = "Definitions"
)

Write-Host "Downloading FHIR $Version definitions..." -ForegroundColor Green

# 建立目錄結構
$basePath = "$OutputPath/$Version"
Write-Host "Creating directory structure: $basePath" -ForegroundColor Yellow

New-Item -ItemType Directory -Force -Path "$basePath/metadata" | Out-Null

# 下載檔案
$baseUrl = "https://hl7.org/fhir/$Version"
$zipFile = "$basePath/definitions.json.zip"

Write-Host "Downloading: $baseUrl/definitions.json.zip" -ForegroundColor Cyan
try {
    Invoke-WebRequest -Uri "$baseUrl/definitions.json.zip" -OutFile $zipFile -UseBasicParsing
    Write-Host "✅ Downloaded: $zipFile" -ForegroundColor Green
    
    # 檢查檔案大小
    $fileSize = (Get-Item $zipFile).Length
    $fileSizeMB = [math]::Round($fileSize / 1MB, 2)
    Write-Host "   Size: $fileSizeMB MB" -ForegroundColor Gray
}
catch {
    Write-Host "❌ Failed to download: $baseUrl/definitions.json.zip" -ForegroundColor Red
    Write-Host "Error: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}

# 建立版本資訊檔案
$versionInfo = @{
    version = $Version
    release = "4.0.1"
    date = "2023-03-28"
    downloadDate = (Get-Date).ToString("yyyy-MM-dd")
    source = $baseUrl
    files = @{
        "definitions" = "definitions.json.zip"
    }
    fileSize = "$fileSizeMB MB"
    extracted = $false
}

$versionInfoJson = $versionInfo | ConvertTo-Json -Depth 10
$versionInfoJson | Out-File -FilePath "$basePath/metadata/version-info.json" -Encoding UTF8

Write-Host "✅ Download completed for FHIR $Version" -ForegroundColor Green
Write-Host "Version info saved to: $basePath/metadata/version-info.json" -ForegroundColor Yellow 