# 簡單修復腳本
$files = @(
    "FhirBoolean.cs",
    "FhirCode.cs", 
    "FhirDateTime.cs",
    "FhirDate.cs",
    "FhirDecimal.cs",
    "FhirId.cs",
    "FhirInstant.cs",
    "FhirInteger.cs",
    "FhirInteger64.cs",
    "FhirOid.cs",
    "FhirPositiveInt.cs",
    "FhirMarkdown.cs",
    "FhirTime.cs",
    "FhirUri.cs",
    "FhirUnsignedInt.cs",
    "FhirUuid.cs",
    "FhirXhtml.cs",
    "FhirUrl.cs"
)

foreach ($file in $files) {
    $filePath = "Fhir.TypeFramework/DataTypes/PrimitiveTypes/$file"
    if (Test-Path $filePath) {
        $content = Get-Content $filePath -Raw
        
        # 移除重複的 using
        $content = $content -replace "using Fhir\.TypeFramework\.Bases;\s*\nusing Fhir\.TypeFramework\.Bases;", "using Fhir.TypeFramework.Bases;"
        $content = $content -replace "using System\.ComponentModel\.Annotations;\s*\nusing System\.ComponentModel\.Annotations;", "using System.ComponentModel.DataAnnotations;"
        
        # 移除無效的語法
        $content = $content -replace "public class \w+ : PrimitiveType\s*\{\s*/// <summary>\s*/// \w+ \?\?\s*/// </summary>\s*\[JsonIgnore\]\s*public\s+Value\s*\{\s*get => ;\s*set => StringValue = ;\s*\}\s*", "public class $($file -replace '\.cs$', '') : PrimitiveType`n{"
        
        # 移除重複的基類定義
        $content = $content -replace "\{\s*public \w+\(\) \{ \}\s*\{\s*public \w+\([^)]*\) : base\([^)]*\) \{ \}", "`n    public $($file -replace '\.cs$', '')() { }"
        
        Set-Content $filePath $content -Encoding UTF8
        Write-Host "Fixed: $file"
    }
} 