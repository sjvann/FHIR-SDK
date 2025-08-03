# FHIR R5 �귽��q�E���}��
# PowerShell �۰ʤƸ}��

param(
    [string]$SourcePath = "ResourceTypeServices\R5",
    [string]$TargetPath = "FhirCore.R5\Resources",
    [switch]$DryRun = $false
)

# �]�w�ܼ�
$ErrorActionPreference = "Stop"
$script:ProcessedCount = 0
$script:SkippedCount = 0
$script:ErrorCount = 0

# �w�������귽�C��]���L�o�ǡ^
$CompletedResources = @(
    "Patient", "Basic", "Organization", "Practitioner", 
    "Medication", "Observation", "Encounter", "Condition"
)

# ��x�禡
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

# ���o�귽�ҪO
function Get-ResourceTemplate {
    param([string]$ResourceName, [string]$OriginalContent)
    
    # �ѪR��l�ɮ׵��c
    $properties = @()
    $backboneElements = @()
    $choiceTypes = @()
    
    # �����p���ݩ�
    $privateMatches = [regex]::Matches($OriginalContent, 'private\s+([^?]+\??)\s+_(\w+);')
    foreach ($match in $privateMatches) {
        $type = $match.Groups[1].Value.Trim()
        $name = $match.Groups[2].Value
        $properties += @{ Type = $type; Name = $name; PublicName = (Get-Culture).TextInfo.ToTitleCase($name) }
    }
    
    # ���� BackboneElement ���O
    $backboneMatches = [regex]::Matches($OriginalContent, 'public class (\w+) : BackboneElementType<\1>')
    foreach ($match in $backboneMatches) {
        $backboneElements += $match.Groups[1].Value
    }
    
    # ���� ChoiceType ���O  
    $choiceMatches = [regex]::Matches($OriginalContent, 'public class (\w+Choice) : ChoiceType')
    foreach ($match in $choiceMatches) {
        $choiceTypes += $match.Groups[1].Value
    }
    
    return @{ ResourceName = $ResourceName; Properties = $properties; BackboneElements = $backboneElements; ChoiceTypes = $choiceTypes }
}

# �ͦ��{�N�Ƹ귽�N�X
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
    /// FHIR R5 $resourceName �귽
    /// 
    /// <para>
    /// $resourceName �귽���ԲӴy�z�N�b���B�K�[�C
    /// �o�O FHIR R5 �зǤ������n�귽�����C
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var $($resourceName.ToLower()) = new $resourceName("$($resourceName.ToLower())-001");
    /// // �]�w�귽�ݩ�...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 ������ $resourceName �귽�㦳�H�U�S�I�G
    /// - �W�j����Ƶ��c
    /// - ��i�����ҳW�h  
    /// - ��n�����ާ@��
    /// </para>
    /// </remarks>
    public class $resourceName : ResourceBase<R5Version>
    {
"@

    # �K�[�p�����
    foreach ($prop in $Template.Properties) {
        $fixedType = $prop.Type -replace 'ReferenceType', 'DataTypeServices.DataTypes.SpecialTypes.ReferenceType'
        $code += "`n        private $fixedType _$($prop.Name.ToLower());"
    }
    
    $code += "`n`n        /// <summary>`n        /// �귽����`n        /// </summary>"
    $code += "`n        public override string ResourceType => `"$resourceName`";"
    
    # �K�[���}�ݩ�
    foreach ($prop in $Template.Properties) {
        $fixedType = $prop.Type -replace 'ReferenceType', 'DataTypeServices.DataTypes.SpecialTypes.ReferenceType'
        $code += @"
        /// <summary>
        /// $($prop.PublicName)
        /// </summary>
        /// <remarks>
        /// <para>
        /// $($prop.PublicName) ���ԲӴy�z�C
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
    
    # �K�[�غc�禡
    $code += @"
        /// <summary>
        /// �إ߷s�� $resourceName �귽���
        /// </summary>
        public $resourceName()
        {
        }

        /// <summary>
        /// �إ߷s�� $resourceName �귽���
        /// </summary>
        /// <param name="id">�귽���ߤ@�ѧO�X</param>
        public $resourceName(string id)
        {
            Id = id;
        }

        /// <summary>
        /// �ഫ���r����
        /// </summary>
        public override string ToString()
        {
            return `$"$resourceName(Id: {Id})";
        }
    }
"@

    # �K�[ BackboneElement ���O
    foreach ($backbone in $Template.BackboneElements) {
        $code += @"
    /// <summary>
    /// $backbone �I������
    /// </summary>
    public class $backbone
    {
        // TODO: �K�[�ݩʹ�@
        
        public $backbone() { }
    }
"@
    }
    
    # �K�[ ChoiceType ���O
    foreach ($choice in $Template.ChoiceTypes) {
        $baseName = $choice -replace 'Choice', ''
        $code += @"
    /// <summary>
    /// $choice �������
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

# �ͦ��u�t��k
function Generate-FactoryMethods {
    param([string]$ResourceName)
    
    return @"
        #region $ResourceName Factory Methods

        /// <summary>
        /// �Ыطs�� $ResourceName �귽
        /// </summary>
        public static $ResourceName Create$ResourceName() => new();

        /// <summary>
        /// �Ыب㦳���w ID �� $ResourceName �귽
        /// </summary>
        public static $ResourceName Create$ResourceName(string id) => new(id);

        /// <summary>
        /// �Ыش��եΪ� $ResourceName �귽
        /// </summary>
        public static $ResourceName CreateTest$ResourceName(string suffix = "001")
        {
            var id = `$"test-$($ResourceName.ToLower())-{suffix}";
            return new $ResourceName(id);
        }

        #endregion
"@
}

# �B�z��@�귽�ɮ�
function Process-ResourceFile {
    param([string]$FilePath)
    
    $fileName = [System.IO.Path]::GetFileNameWithoutExtension($FilePath)
    
    # ���L�w�������귽
    if ($CompletedResources -contains $fileName) {
        Write-Log "���L�w�������귽: $fileName" "WARN"
        $script:SkippedCount++
        return
    }
    
    try {
        Write-Log "�B�z�귽: $fileName"
        
        # Ū����l�ɮ�
        $originalContent = Get-Content $FilePath -Raw -Encoding UTF8
        
        # �ѪR�귽���c
        $template = Get-ResourceTemplate -ResourceName $fileName -OriginalContent $originalContent
        
        # �ͦ��{�N�ƥN�X
        $modernCode = Generate-ModernResourceCode -Template $template
        
        # �إߥؼ��ɮ׸��|
        $targetFile = Join-Path $TargetPath "$fileName.cs"
        
        if (-not $DryRun) {
            # �T�O�ؼХؿ��s�b
            $targetDir = Split-Path $targetFile -Parent
            if (-not (Test-Path $targetDir)) {
                New-Item -ItemType Directory -Path $targetDir -Force | Out-Null
            }
            
            # �g�J�ɮ�
            $modernCode | Out-File -FilePath $targetFile -Encoding UTF8
            
            # ��s�u�t��k
            $factoryMethods = Generate-FactoryMethods -ResourceName $fileName
            Add-Content -Path "FhirCore.R5\Factory\R5Factory_Generated.cs" -Value $factoryMethods -Encoding UTF8
        }
        
        Write-Log "�����B�z: $fileName" "SUCCESS"
        $script:ProcessedCount++
        
    } catch {
        Write-Log "�B�z $fileName �ɵo�Ϳ��~: $($_.Exception.Message)" "ERROR"
        $script:ErrorCount++
    }
}

# �D�n�����޿�
function Main {
    Write-Log "�}�l FHIR R5 �귽��q�E��"
    Write-Log "�ӷ����|: $SourcePath"
    Write-Log "�ؼи��|: $TargetPath"
    Write-Log "���B��Ҧ�: $DryRun"
    
    # �ˬd�ӷ����|
    if (-not (Test-Path $SourcePath)) {
        Write-Log "�ӷ����|���s�b: $SourcePath" "ERROR"
        return
    }
    
    # ���o�Ҧ� .cs �ɮ�
    $resourceFiles = Get-ChildItem -Path $SourcePath -Filter "*.cs" | Where-Object { $_.Name -notmatch "Choice|Participant|Stage" }
    
    Write-Log "�o�{ $($resourceFiles.Count) �Ӹ귽�ɮ�"
    
    # �إߤu�t�X�i�ɮ�
    if (-not $DryRun) {
        $factoryHeader = @"
/// �۰ʥͦ����u�t��k
using FhirCore.R5.Resources;

namespace FhirCore.R5.Factory
{
    public static partial class R5Factory
    {
"@
        $factoryHeader | Out-File -FilePath "FhirCore.R5\Factory\R5Factory_Generated.cs" -Encoding UTF8
    }
    
    # �B�z�C�Ӹ귽�ɮ�
    foreach ($file in $resourceFiles) {
        Process-ResourceFile -FilePath $file.FullName
    }
    
    # �����u�t�ɮ�
    if (-not $DryRun) {
        Add-Content -Path "FhirCore.R5\Factory\R5Factory_Generated.cs" -Value "    }" -Encoding UTF8
    }
    
    # �`�����i
    Write-Log "��q�E�������I" "SUCCESS"
    Write-Log "�B�z���\: $script:ProcessedCount ��"
    Write-Log "���L: $script:SkippedCount ��"
    Write-Log "���~: $script:ErrorCount ��"
}

# ����D�޿�
Main