# 效能測試執行腳本
param(
    [string]$Configuration = "Release",
    [string]$Filter = "*",
    [switch]$GenerateReport
)

Write-Host "開始執行效能測試..." -ForegroundColor Green

# 設定環境變數
$env:DOTNET_ENVIRONMENT = "Production"

# 建置專案
Write-Host "建置專案..." -ForegroundColor Yellow
dotnet build --configuration $Configuration --no-restore

if ($LASTEXITCODE -ne 0) {
    Write-Host "建置失敗！" -ForegroundColor Red
    exit 1
}

# 執行效能測試
Write-Host "執行效能測試..." -ForegroundColor Yellow
$benchmarkArgs = @(
    "--configuration", $Configuration,
    "--filter", $Filter,
    "--exporters", "JSON",
    "--artifacts", "./benchmarks"
)

if ($GenerateReport) {
    $benchmarkArgs += "--exporters", "HTML"
}

dotnet run --project PerformanceTests -- $benchmarkArgs

if ($LASTEXITCODE -ne 0) {
    Write-Host "效能測試執行失敗！" -ForegroundColor Red
    exit 1
}

# 檢查結果
if (Test-Path "./benchmarks") {
    Write-Host "效能測試完成！結果已儲存到 ./benchmarks 目錄" -ForegroundColor Green
    
    # 顯示結果摘要
    $results = Get-ChildItem "./benchmarks" -Filter "*.json" | Select-Object -First 1
    if ($results) {
        Write-Host "測試結果檔案: $($results.FullName)" -ForegroundColor Cyan
    }
} else {
    Write-Host "警告：未找到效能測試結果檔案" -ForegroundColor Yellow
}

Write-Host "效能測試執行完成！" -ForegroundColor Green 