# FHIR R5 資源批量遷移腳本
# PowerShell 自動化腳本

param(
    [string]$SourcePath = "ResourceTypeServices\R5",
    [string]$TargetPath = "FhirCore.R5\Resources",
    [switch]$DryRun = $false
)

# 設定變數
$ErrorActionPreference = "Stop"
$script:ProcessedCount = 0
$script:SkippedCount = 0
$script:ErrorCount = 0

# 已完成的資源列表（跳過這些）
$CompletedResources = @(
    "Patient", "Basic", "Organization", "Practitioner", 
    "Medication", "Observation", "Encounter", "Condition"
)

# 日誌函式
function Write-Log {
    param([string]$Message, [string]$Level = "INFO")
    $timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
    $color = switch($Level) {
        "ERROR" { "Red" }
        "WARN" { "Yellow" }
        "SUCCESS" { "Green" }
        default { "White" }
    }
    Write-Host "[$timestamp] [$Level] $Message" -ForegroundColor $color
}

# 取得資源模板
function Get-ResourceTemplate {
    param([string]$ResourceName, [string]$OriginalContent)
    
    # 解析原始檔案結構
    $properties = @()
    $backboneElements = @()
    $choiceTypes = @()
    
    # 提取私有屬性
    $privateMatches = [regex]::Matches($OriginalContent, 'private\s+([^?]+\??)\s+_(\w+);')
    foreach ($match in $privateMatches) {
        $type = $match.Groups[1].Value.Trim()
        $name = $match.Groups[2].Value
        $properties += @{ Type = $type; Name = $name; PublicName = (Get-Culture).TextInfo.ToTitleCase($name) }
    }
    
    # 提取 BackboneElement 類別
    $backboneMatches = [regex]::Matches($OriginalContent, 'public class (\w+) : BackboneElementType<\1>')
    foreach ($match in $backboneMatches) {
        $backboneElements += $match.Groups[1].Value
    }
    
    # 提取 ChoiceType 類別  
    $choiceMatches = [regex]::Matches($OriginalContent, 'public class (\w+Choice) : ChoiceType')
    foreach ($match in $choiceMatches) {
        $choiceTypes += $match.Groups[1].Value
    }
    
    return @{ ResourceName = $ResourceName; Properties = $properties; BackboneElements = $backboneElements; ChoiceTypes = $choiceTypes }
}

# 生成現代化資源代碼
function Generate-ModernResourceCode {
    param($Template)
    
    $resourceName = $Template.ResourceName
    
    $code = @"
using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 $resourceName 資源
    /// 
    /// <para>
    /// $resourceName 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var $($resourceName.ToLower()) = new $resourceName("$($resourceName.ToLower())-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 $resourceName 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class $resourceName : ResourceBase<R5Version>
    {
"@

    # 添加私有欄位
    foreach ($prop in $Template.Properties) {
        $fixedType = $prop.Type -replace 'ReferenceType', 'DataTypeServices.DataTypes.SpecialTypes.ReferenceType'
        $code += "`n        private $fixedType _$($prop.Name.ToLower());"
    }
    
    $code += "`n`n        /// <summary>`n        /// 資源類型`n        /// </summary>"
    $code += "`n        public override string ResourceType => `"$resourceName`";"
    
    # 添加公開屬性
    foreach ($prop in $Template.Properties) {
        $fixedType = $prop.Type -replace 'ReferenceType', 'DataTypeServices.DataTypes.SpecialTypes.ReferenceType'
        $code += @"
        /// <summary>
        /// $($prop.PublicName)
        /// </summary>
        /// <remarks>
        /// <para>
        /// $($prop.PublicName) 的詳細描述。
        /// </para>
        /// </remarks>
        public $fixedType $($prop.PublicName)
        {
            get => _$($prop.Name.ToLower());
            set
            {
                _$($prop.Name.ToLower()) = value;
                OnPropertyChanged(nameof($($prop.PublicName)));
            }
        }
"@
    }
    
    # 添加建構函式
    $code += @"
        /// <summary>
        /// 建立新的 $resourceName 資源實例
        /// </summary>
        public $resourceName()
        {
        }

        /// <summary>
        /// 建立新的 $resourceName 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public $resourceName(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return `$"$resourceName(Id: {Id})";
        }
    }
"@

    # 添加 BackboneElement 類別
    foreach ($backbone in $Template.BackboneElements) {
        $code += @"
    /// <summary>
    /// $backbone 背骨元素
    /// </summary>
    public class $backbone
    {
        // TODO: 添加屬性實作
        
        public $backbone() { }
    }
"@
    }
    
    # 添加 ChoiceType 類別
    foreach ($choice in $Template.ChoiceTypes) {
        $baseName = $choice -replace 'Choice', ''
        $code += @"
    /// <summary>
    /// $choice 選擇類型
    /// </summary>
    public class $choice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public $choice(JsonObject value) : base("$($baseName.ToLower())", value, _supportType) { }
        public $choice(IComplexType? value) : base("$($baseName.ToLower())", value) { }
        public $choice(IPrimitiveType? value) : base("$($baseName.ToLower())", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "$baseName" : "$($baseName.ToLower())";
        public override List<string> SetSupportDataType() => _supportType;
    }
"@
    }
    
    $code += "`n}"
    
    return $code
}

# 生成工廠方法
function Generate-FactoryMethods {
    param([string]$ResourceName)
    
    return @"
        #region $ResourceName Factory Methods

        /// <summary>
        /// 創建新的 $ResourceName 資源
        /// </summary>
        public static $ResourceName Create$ResourceName() => new();

        /// <summary>
        /// 創建具有指定 ID 的 $ResourceName 資源
        /// </summary>
        public static $ResourceName Create$ResourceName(string id) => new(id);

        /// <summary>
        /// 創建測試用的 $ResourceName 資源
        /// </summary>
        public static $ResourceName CreateTest$ResourceName(string suffix = "001")
        {
            var id = `$"test-$($ResourceName.ToLower())-{suffix}";
            return new $ResourceName(id);
        }

        #endregion
"@
}

# 處理單一資源檔案
function Process-ResourceFile {
    param([string]$FilePath)
    
    $fileName = [System.IO.Path]::GetFileNameWithoutExtension($FilePath)
    
    # 跳過已完成的資源
    if ($CompletedResources -contains $fileName) {
        Write-Log "跳過已完成的資源: $fileName" "WARN"
        $script:SkippedCount++
        return
    }
    
    try {
        Write-Log "處理資源: $fileName"
        
        # 讀取原始檔案
        $originalContent = Get-Content $FilePath -Raw -Encoding UTF8
        
        # 解析資源結構
        $template = Get-ResourceTemplate -ResourceName $fileName -OriginalContent $originalContent
        
        # 生成現代化代碼
        $modernCode = Generate-ModernResourceCode -Template $template
        
        # 建立目標檔案路徑
        $targetFile = Join-Path $TargetPath "$fileName.cs"
        
        if (-not $DryRun) {
            # 確保目標目錄存在
            $targetDir = Split-Path $targetFile -Parent
            if (-not (Test-Path $targetDir)) {
                New-Item -ItemType Directory -Path $targetDir -Force | Out-Null
            }
            
            # 寫入檔案
            $modernCode | Out-File -FilePath $targetFile -Encoding UTF8
            
            # 更新工廠方法
            $factoryMethods = Generate-FactoryMethods -ResourceName $fileName
            Add-Content -Path "FhirCore.R5\Factory\R5Factory_Generated.cs" -Value $factoryMethods -Encoding UTF8
        }
        
        Write-Log "完成處理: $fileName" "SUCCESS"
        $script:ProcessedCount++
        
    } catch {
        Write-Log "處理 $fileName 時發生錯誤: $($_.Exception.Message)" "ERROR"
        $script:ErrorCount++
    }
}

# 主要執行邏輯
function Main {
    Write-Log "開始 FHIR R5 資源批量遷移"
    Write-Log "來源路徑: $SourcePath"
    Write-Log "目標路徑: $TargetPath"
    Write-Log "乾運行模式: $DryRun"
    
    # 檢查來源路徑
    if (-not (Test-Path $SourcePath)) {
        Write-Log "來源路徑不存在: $SourcePath" "ERROR"
        return
    }
    
    # 取得所有 .cs 檔案
    $resourceFiles = Get-ChildItem -Path $SourcePath -Filter "*.cs" | Where-Object { $_.Name -notmatch "Choice|Participant|Stage" }
    
    Write-Log "發現 $($resourceFiles.Count) 個資源檔案"
    
    # 建立工廠擴展檔案
    if (-not $DryRun) {
        $factoryHeader = @"
/// 自動生成的工廠方法
using FhirCore.R5.Resources;

namespace FhirCore.R5.Factory
{
    public static partial class R5Factory
    {
"@
        $factoryHeader | Out-File -FilePath "FhirCore.R5\Factory\R5Factory_Generated.cs" -Encoding UTF8
    }
    
    # 處理每個資源檔案
    foreach ($file in $resourceFiles) {
        Process-ResourceFile -FilePath $file.FullName
    }
    
    # 完成工廠檔案
    if (-not $DryRun) {
        Add-Content -Path "FhirCore.R5\Factory\R5Factory_Generated.cs" -Value "    }" -Encoding UTF8
    }
    
    # 總結報告
    Write-Log "批量遷移完成！" "SUCCESS"
    Write-Log "處理成功: $script:ProcessedCount 個"
    Write-Log "跳過: $script:SkippedCount 個"
    Write-Log "錯誤: $script:ErrorCount 個"
}

# 執行主邏輯
Main