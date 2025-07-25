#!/usr/bin/env pwsh
# FHIR R4 程式碼生成腳本

param(
    [switch]$Clean = $false,
    [switch]$Verbose = $false
)

Write-Host "🚀 FHIR R4 程式碼生成開始..." -ForegroundColor Green

# 設定路徑
$rootPath = Split-Path -Parent $PSScriptRoot
$definitionsPath = Join-Path $rootPath "Definitions\R4\definitions.json.zip"
$outputPath = Join-Path $rootPath "Fhir.R4.Models"
$generatorPath = Join-Path $rootPath "Fhir.Generator"

# 檢查必要檔案
Write-Host "📋 檢查必要檔案..." -ForegroundColor Yellow

if (-not (Test-Path $definitionsPath)) {
    Write-Host "❌ R4 定義檔不存在: $definitionsPath" -ForegroundColor Red
    Write-Host "💡 請先下載 R4 定義檔:" -ForegroundColor Cyan
    Write-Host "   wget https://hl7.org/fhir/R4/definitions.json.zip -O `"$definitionsPath`"" -ForegroundColor Gray
    exit 1
}

# 檢查檔案大小
$fileSize = (Get-Item $definitionsPath).Length / 1MB
Write-Host "✅ R4 定義檔: $([math]::Round($fileSize, 2)) MB" -ForegroundColor Green

# 清理舊檔案
if ($Clean) {
    Write-Host "🧹 清理舊的生成檔案..." -ForegroundColor Yellow
    
    $foldersToClean = @(
        "$outputPath\DataTypes",
        "$outputPath\Resources"
    )
    
    foreach ($folder in $foldersToClean) {
        if (Test-Path $folder) {
            Remove-Item -Path "$folder\*.cs" -Force -ErrorAction SilentlyContinue
            Write-Host "  清理: $folder" -ForegroundColor Gray
        }
    }
}

# 建立輸出目錄
Write-Host "📁 建立輸出目錄..." -ForegroundColor Yellow
New-Item -ItemType Directory -Force -Path "$outputPath\DataTypes" | Out-Null
New-Item -ItemType Directory -Force -Path "$outputPath\Resources" | Out-Null

# 編譯生成器
Write-Host "🔨 編譯生成器..." -ForegroundColor Yellow
Push-Location $generatorPath
try {
    dotnet build --configuration Release --verbosity quiet
    if ($LASTEXITCODE -ne 0) {
        Write-Host "❌ 生成器編譯失敗" -ForegroundColor Red
        exit 1
    }
    Write-Host "✅ 生成器編譯成功" -ForegroundColor Green
}
finally {
    Pop-Location
}

# 執行程式碼生成
Write-Host "⚡ 執行 R4 程式碼生成..." -ForegroundColor Yellow

$generateArgs = @(
    "run"
    "--project", $generatorPath
    "--configuration", "Release"
    "--"
    "--fhir-version", "R4"
    "--definition-file", "definitions.json.zip"
)

if ($Verbose) {
    $generateArgs += "--verbose"
}

$stopwatch = [System.Diagnostics.Stopwatch]::StartNew()

try {
    & dotnet @generateArgs
    
    if ($LASTEXITCODE -ne 0) {
        Write-Host "❌ R4 程式碼生成失敗" -ForegroundColor Red
        exit 1
    }
    
    $stopwatch.Stop()
    Write-Host "✅ R4 程式碼生成成功! 耗時: $($stopwatch.Elapsed.TotalSeconds.ToString('F1')) 秒" -ForegroundColor Green
}
catch {
    Write-Host "❌ 生成過程發生錯誤: $($_.Exception.Message)" -ForegroundColor Red
    exit 1
}

# 統計生成結果
Write-Host "📊 統計生成結果..." -ForegroundColor Yellow

$dataTypeCount = (Get-ChildItem "$outputPath\DataTypes\*.cs" -ErrorAction SilentlyContinue).Count
$resourceCount = (Get-ChildItem "$outputPath\Resources\*.cs" -ErrorAction SilentlyContinue).Count

Write-Host "  📄 DataTypes: $dataTypeCount 個檔案" -ForegroundColor Cyan
Write-Host "  🏥 Resources: $resourceCount 個檔案" -ForegroundColor Cyan

# 編譯驗證
Write-Host "🔍 編譯驗證..." -ForegroundColor Yellow

Push-Location $outputPath
try {
    dotnet build --configuration Release --verbosity quiet
    
    if ($LASTEXITCODE -eq 0) {
        Write-Host "✅ R4 模型編譯成功" -ForegroundColor Green
    } else {
        Write-Host "⚠️  R4 模型編譯有警告或錯誤" -ForegroundColor Yellow
        Write-Host "💡 請檢查編譯輸出以了解詳情" -ForegroundColor Cyan
    }
}
finally {
    Pop-Location
}

Write-Host "🎉 R4 程式碼生成完成!" -ForegroundColor Green
Write-Host "📦 輸出位置: $outputPath" -ForegroundColor Cyan
