# 維護報告生成腳本
param(
    [string]$OutputPath = "./reports",
    [switch]$IncludePerformance,
    [switch]$IncludeSecurity,
    [switch]$GenerateHtml
)

Write-Host "開始生成維護報告..." -ForegroundColor Green

# 建立報告目錄
if (!(Test-Path $OutputPath)) {
    New-Item -ItemType Directory -Path $OutputPath -Force | Out-Null
}

$reportDate = Get-Date -Format "yyyy-MM-dd"
$reportFile = Join-Path $OutputPath "maintenance-report-$reportDate.md"

# 收集專案資訊
Write-Host "收集專案資訊..." -ForegroundColor Yellow

$projectInfo = @{
    ProjectName = "FHIR SDK"
    Version = "1.0.0"
    ReportDate = $reportDate
    NETVersion = (dotnet --version)
    BuildConfiguration = "Release"
}

# 建置狀態檢查
Write-Host "檢查建置狀態..." -ForegroundColor Yellow
$buildResult = dotnet build --configuration Release --verbosity quiet
$buildSuccess = $LASTEXITCODE -eq 0

# 測試狀態檢查
Write-Host "執行測試..." -ForegroundColor Yellow
$testResult = dotnet test --configuration Release --verbosity quiet --collect:"XPlat Code Coverage" --results-directory ./coverage
$testSuccess = $LASTEXITCODE -eq 0

# 程式碼覆蓋率檢查
$coverageFile = Get-ChildItem "./coverage" -Filter "coverage.cobertura.xml" -Recurse | Select-Object -First 1
$coveragePercentage = "N/A"
if ($coverageFile) {
    $coverageContent = Get-Content $coverageFile.FullName -Raw
    if ($coverageContent -match 'line-rate="([^"]+)"') {
        $coveragePercentage = [math]::Round([double]$matches[1] * 100, 2)
    }
}

# 靜態分析檢查
Write-Host "執行靜態分析..." -ForegroundColor Yellow
$analysisResult = dotnet build --verbosity normal 2>&1
$warningCount = ($analysisResult | Select-String "warning").Count
$errorCount = ($analysisResult | Select-String "error").Count

# 效能測試檢查
$performanceData = @{}
if ($IncludePerformance) {
    Write-Host "執行效能測試..." -ForegroundColor Yellow
    $perfResult = dotnet run --project PerformanceTests --configuration Release --verbosity quiet 2>&1
    $performanceData = @{
        SerializationTime = "N/A"
        ValidationTime = "N/A"
        MemoryUsage = "N/A"
    }
    
    # 解析效能測試結果
    if ($perfResult -match "SerializePatient.*?(\d+\.?\d*)\s*ns") {
        $performanceData.SerializationTime = "$($matches[1]) ns"
    }
    if ($perfResult -match "ValidatePatient.*?(\d+\.?\d*)\s*ns") {
        $performanceData.ValidationTime = "$($matches[1]) ns"
    }
}

# 安全性檢查
$securityData = @{}
if ($IncludeSecurity) {
    Write-Host "執行安全性檢查..." -ForegroundColor Yellow
    $vulnerablePackages = dotnet list package --vulnerable 2>&1
    $securityData.VulnerablePackages = ($vulnerablePackages | Select-String "vulnerable").Count
    $securityData.SecurityIssues = $securityData.VulnerablePackages -gt 0
}

# 依賴套件檢查
Write-Host "檢查依賴套件..." -ForegroundColor Yellow
$outdatedPackages = dotnet list package --outdated 2>&1
$outdatedCount = ($outdatedPackages | Select-String "outdated").Count

# 生成報告
Write-Host "生成報告..." -ForegroundColor Yellow

$reportContent = @"
# FHIR SDK 維護報告

**報告日期**: $($projectInfo.ReportDate)  
**專案版本**: $($projectInfo.Version)  
**.NET 版本**: $($projectInfo.NETVersion)

## 📊 品質指標

### 建置狀態
- **建置結果**: $(if ($buildSuccess) { "✅ 成功" } else { "❌ 失敗" })
- **測試結果**: $(if ($testSuccess) { "✅ 通過" } else { "❌ 失敗" })
- **程式碼覆蓋率**: $coveragePercentage%
- **靜態分析警告**: $warningCount
- **靜態分析錯誤**: $errorCount

### 效能指標
- **序列化效能**: $($performanceData.SerializationTime)
- **驗證效能**: $($performanceData.ValidationTime)
- **記憶體使用**: $($performanceData.MemoryUsage)

### 安全性指標
- **已知漏洞**: $($securityData.VulnerablePackages)
- **安全性狀態**: $(if ($securityData.SecurityIssues) { "⚠️ 需要關注" } else { "✅ 安全" })

### 依賴套件
- **過期套件**: $outdatedCount
- **建議更新**: $(if ($outdatedCount -gt 0) { "是" } else { "否" })

## 🔍 詳細分析

### 建置資訊
\`\`\`
$($buildResult -join "`n")
\`\`\`

### 測試結果
\`\`\`
$($testResult -join "`n")
\`\`\`

### 靜態分析結果
\`\`\`
$($analysisResult -join "`n")
\`\`\`

## 📋 建議行動

### 立即行動
$(if (-not $buildSuccess) { "- 🔧 修復建置問題" })
$(if (-not $testSuccess) { "- 🧪 修復測試問題" })
$(if ($warningCount -gt 0) { "- ⚠️ 解決靜態分析警告" })
$(if ($errorCount -gt 0) { "- ❌ 解決靜態分析錯誤" })

### 短期行動
$(if ($outdatedCount -gt 0) { "- 📦 更新過期套件" })
$(if ($securityData.SecurityIssues) { "- 🔒 修復安全性漏洞" })
$(if ([double]$coveragePercentage -lt 90) { "- 📈 提升程式碼覆蓋率" })

### 長期行動
- 📚 更新技術文件
- 🚀 效能優化
- 🔧 技術債務清理

## 📈 趨勢分析

### 品質趨勢
- 程式碼覆蓋率: $(if ([double]$coveragePercentage -ge 90) { "✅ 達標" } else { "📈 需要改善" })
- 靜態分析: $(if ($warningCount -eq 0 -and $errorCount -eq 0) { "✅ 良好" } else { "⚠️ 需要改善" })
- 建置穩定性: $(if ($buildSuccess) { "✅ 穩定" } else { "❌ 不穩定" })

### 效能趨勢
- 序列化效能: $(if ($performanceData.SerializationTime -ne "N/A") { "📊 已測量" } else { "📈 需要基準測試" })
- 驗證效能: $(if ($performanceData.ValidationTime -ne "N/A") { "📊 已測量" } else { "📈 需要基準測試" })

## 📞 聯絡資訊

如有問題或建議，請聯絡：
- 技術討論: GitHub Discussions
- 問題回報: GitHub Issues
- 緊急聯絡: 團隊 Slack 頻道

---
*此報告由自動化腳本生成於 $($projectInfo.ReportDate)*
"@

# 寫入報告檔案
$reportContent | Out-File -FilePath $reportFile -Encoding UTF8

# 生成 HTML 報告
if ($GenerateHtml) {
    $htmlFile = Join-Path $OutputPath "maintenance-report-$reportDate.html"
    $htmlContent = @"
<!DOCTYPE html>
<html lang="zh-TW">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>FHIR SDK 維護報告 - $reportDate</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; margin: 40px; }
        .header { background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); color: white; padding: 20px; border-radius: 10px; }
        .metric { background: #f8f9fa; padding: 15px; margin: 10px 0; border-radius: 5px; border-left: 4px solid #007bff; }
        .success { border-left-color: #28a745; }
        .warning { border-left-color: #ffc107; }
        .error { border-left-color: #dc3545; }
        .code { background: #f1f3f4; padding: 10px; border-radius: 3px; font-family: 'Courier New', monospace; }
        table { width: 100%; border-collapse: collapse; margin: 20px 0; }
        th, td { padding: 12px; text-align: left; border-bottom: 1px solid #ddd; }
        th { background-color: #f8f9fa; }
    </style>
</head>
<body>
    <div class="header">
        <h1>FHIR SDK 維護報告</h1>
        <p>報告日期: $reportDate | 專案版本: $($projectInfo.Version)</p>
    </div>
    
    <h2>📊 品質指標</h2>
    <div class="metric $(if ($buildSuccess) { 'success' } else { 'error' })">
        <strong>建置狀態:</strong> $(if ($buildSuccess) { "✅ 成功" } else { "❌ 失敗" })
    </div>
    <div class="metric $(if ($testSuccess) { 'success' } else { 'error' })">
        <strong>測試結果:</strong> $(if ($testSuccess) { "✅ 通過" } else { "❌ 失敗" })
    </div>
    <div class="metric $(if ([double]$coveragePercentage -ge 90) { 'success' } else { 'warning' })">
        <strong>程式碼覆蓋率:</strong> $coveragePercentage%
    </div>
    <div class="metric $(if ($warningCount -eq 0) { 'success' } else { 'warning' })">
        <strong>靜態分析警告:</strong> $warningCount
    </div>
    
    <h2>📋 建議行動</h2>
    <ul>
        $(if (-not $buildSuccess) { "<li>🔧 修復建置問題</li>" })
        $(if (-not $testSuccess) { "<li>🧪 修復測試問題</li>" })
        $(if ($warningCount -gt 0) { "<li>⚠️ 解決靜態分析警告</li>" })
        $(if ($outdatedCount -gt 0) { "<li>📦 更新過期套件</li>" })
    </ul>
</body>
</html>
"@
    $htmlContent | Out-File -FilePath $htmlFile -Encoding UTF8
    Write-Host "HTML 報告已生成: $htmlFile" -ForegroundColor Green
}

Write-Host "維護報告已生成: $reportFile" -ForegroundColor Green
Write-Host "報告包含以下資訊:" -ForegroundColor Cyan
Write-Host "- 建置狀態: $(if ($buildSuccess) { "✅" } else { "❌" })" -ForegroundColor $(if ($buildSuccess) { "Green" } else { "Red" })
Write-Host "- 測試狀態: $(if ($testSuccess) { "✅" } else { "❌" })" -ForegroundColor $(if ($testSuccess) { "Green" } else { "Red" })
Write-Host "- 程式碼覆蓋率: $coveragePercentage%" -ForegroundColor $(if ([double]$coveragePercentage -ge 90) { "Green" } else { "Yellow" })
Write-Host "- 靜態分析警告: $warningCount" -ForegroundColor $(if ($warningCount -eq 0) { "Green" } else { "Yellow" })

Write-Host "維護報告生成完成！" -ForegroundColor Green 