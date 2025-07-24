param(
    [string]$Version = "R4"
)

Write-Host "Validating FHIR $Version definitions..." -ForegroundColor Green

$basePath = "Definitions/$Version"

# 檢查目錄是否存在
if (-not (Test-Path $basePath)) {
    Write-Host "❌ Directory not found: $basePath" -ForegroundColor Red
    exit 1
}

Write-Host "Checking directory structure..." -ForegroundColor Yellow

# 檢查必要目錄
$requiredDirectories = @(
    "metadata"
)

foreach ($dir in $requiredDirectories) {
    $fullPath = "$basePath/$dir"
    if (Test-Path $fullPath) {
        Write-Host "✅ Directory exists: $dir" -ForegroundColor Green
    } else {
        Write-Host "❌ Directory missing: $dir" -ForegroundColor Red
    }
}

Write-Host "`nChecking required files..." -ForegroundColor Yellow

# 檢查必要檔案
$requiredFiles = @(
    "definitions.json.zip",
    "metadata/version-info.json"
)

$missingFiles = @()

foreach ($file in $requiredFiles) {
    $fullPath = "$basePath/$file"
    if (Test-Path $fullPath) {
        Write-Host "✅ File exists: $file" -ForegroundColor Green
        
        # 檢查檔案大小
        $fileSize = (Get-Item $fullPath).Length
        if ($fileSize -gt 0) {
            $fileSizeMB = [math]::Round($fileSize / 1MB, 2)
            Write-Host "   Size: $fileSizeMB MB" -ForegroundColor Gray
        } else {
            Write-Host "   ⚠️  File is empty" -ForegroundColor Yellow
        }
    } else {
        Write-Host "❌ File missing: $file" -ForegroundColor Red
        $missingFiles += $file
    }
}

# 驗證 ZIP 格式
Write-Host "`nValidating ZIP format..." -ForegroundColor Yellow

$zipFile = "$basePath/definitions.json.zip"
if (Test-Path $zipFile) {
    try {
        # 使用 .NET 的 System.IO.Compression
        Add-Type -AssemblyName System.IO.Compression.FileSystem
        $zip = [System.IO.Compression.ZipFile]::OpenRead($zipFile)
        $entryCount = $zip.Entries.Count
        $zip.Dispose()
        Write-Host "✅ Valid ZIP: definitions.json.zip" -ForegroundColor Green
        Write-Host "   Entries: $entryCount" -ForegroundColor Gray
    }
    catch {
        Write-Host "❌ Invalid ZIP: definitions.json.zip" -ForegroundColor Red
        Write-Host "   Error: $($_.Exception.Message)" -ForegroundColor Red
    }
}

# 檢查版本資訊
$versionInfoPath = "$basePath/metadata/version-info.json"
if (Test-Path $versionInfoPath) {
    try {
        $versionInfo = Get-Content $versionInfoPath -Raw | ConvertFrom-Json
        Write-Host "`nVersion Information:" -ForegroundColor Yellow
        Write-Host "  Version: $($versionInfo.version)" -ForegroundColor Cyan
        Write-Host "  Release: $($versionInfo.release)" -ForegroundColor Cyan
        Write-Host "  Download Date: $($versionInfo.downloadDate)" -ForegroundColor Cyan
        Write-Host "  Source: $($versionInfo.source)" -ForegroundColor Cyan
        Write-Host "  File Size: $($versionInfo.fileSize)" -ForegroundColor Cyan
    }
    catch {
        Write-Host "❌ Invalid version info JSON" -ForegroundColor Red
    }
}

# 總結
Write-Host "`nValidation Summary:" -ForegroundColor Yellow
if ($missingFiles.Count -eq 0) {
    Write-Host "✅ All required files are present" -ForegroundColor Green
} else {
    Write-Host "❌ Missing files: $($missingFiles.Count)" -ForegroundColor Red
    foreach ($file in $missingFiles) {
        Write-Host "   - $file" -ForegroundColor Red
    }
}

Write-Host "`nValidation completed!" -ForegroundColor Green 