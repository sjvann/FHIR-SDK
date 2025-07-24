# FHIR 定義檔目錄結構規範

## 目錄結構

```
FHIR-SDK/
├── Definitions/                    # FHIR 定義檔根目錄
│   ├── R4/                        # R4 版本定義檔
│   │   ├── definitions.json.zip   # 完整的 FHIR 定義檔
│   │   ├── metadata/              # 版本元資料
│   │   │   ├── version-info.json
│   │   │   └── extracted-info.json
│   │   └── extracted/             # 解壓縮後的檔案 (可選)
│   │       ├── profiles/          # 資源定義檔
│   │       ├── valuesets/         # 值集定義檔
│   │       └── search-parameters/ # 搜尋參數定義檔
│   ├── R5/                        # R5 版本定義檔 (未來)
│   └── R6/                        # R6 版本定義檔 (未來)
├── Fhir.Generator/                # 生成器專案
├── Fhir.Support/                  # 支援庫專案
└── Fhir.Support.Tests/            # 測試專案
```

## 下載規範

### 1. R4 定義檔下載

#### 官方下載來源
- **主要來源**: [HL7 FHIR R4 定義檔](https://hl7.org/fhir/R4/downloads.html)
- **直接下載**: `definitions.json.zip`

#### 下載方式
```bash
# 下載完整的定義檔
wget https://hl7.org/fhir/R4/definitions.json.zip -O Definitions/R4/definitions.json.zip

# 或手動下載並放置到 Definitions/R4/ 目錄
```

### 2. 版本資訊檔案

建立 `Definitions/R4/metadata/version-info.json`:
```json
{
  "version": "R4",
  "release": "4.0.1",
  "date": "2023-03-28",
  "downloadDate": "2024-01-15",
  "source": "https://hl7.org/fhir/R4/",
  "files": {
    "definitions": "definitions.json.zip"
  },
  "fileSize": "8.5MB",
  "extracted": false
}
```

## 檔案命名規範

### 1. 目錄命名
- 使用大寫版本號：`R4`, `R5`, `R6`
- 使用小寫描述性名稱：`metadata`, `extracted`

### 2. 檔案命名
- 使用官方檔案名稱：`definitions.json.zip`
- 保持 ZIP 格式
- 記錄檔案大小和完整性

### 3. 版本控制
- 每個版本獨立目錄
- 保留版本元資料
- 記錄下載日期和來源

## 驗證規範

### 1. 檔案完整性檢查
```bash
# 檢查必要檔案是否存在
ls -la Definitions/R4/definitions.json.zip
ls -la Definitions/R4/metadata/version-info.json
```

### 2. ZIP 格式驗證
```bash
# 驗證 ZIP 格式
unzip -t Definitions/R4/definitions.json.zip
```

### 3. 版本一致性檢查
```bash
# 檢查版本資訊
jq '.version' Definitions/R4/metadata/version-info.json
```

## 自動化腳本

### 1. 下載腳本
建立 `scripts/download-definitions.ps1`:
```powershell
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
```

### 2. 驗證腳本
建立 `scripts/validate-definitions.ps1`:
```powershell
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
```

## 使用方式

### 1. 下載 R4 定義檔
```bash
# PowerShell
.\scripts\download-definitions.ps1 -Version R4

# 或手動下載
wget https://hl7.org/fhir/R4/definitions.json.zip -O Definitions/R4/definitions.json.zip
```

### 2. 驗證定義檔
```bash
# PowerShell
.\scripts\validate-definitions.ps1 -Version R4
```

### 3. 在生成器中使用
```csharp
// 在 Fhir.Generator 中使用
var definitionsPath = "Definitions/R4/definitions.json.zip";
var versionInfoPath = "Definitions/R4/metadata/version-info.json";
```

## 注意事項

1. **版本控制**: 將定義檔加入 `.gitignore`，只保留版本資訊
2. **備份**: 定期備份下載的定義檔
3. **更新**: 定期檢查新版本並更新
4. **驗證**: 每次下載後都要驗證檔案完整性

這個結構將幫助我們：
- 保持定義檔的組織性
- 支援多版本管理
- 自動化下載和驗證
- 確保版本一致性 