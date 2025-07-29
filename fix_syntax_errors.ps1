# 修復語法錯誤腳本
$files = @(
    "FhirCode.cs",
    "FhirDate.cs",
    "FhirDateTime.cs", 
    "FhirDecimal.cs",
    "FhirId.cs",
    "FhirInstant.cs",
    "FhirInteger.cs",
    "FhirInteger64.cs",
    "FhirMarkdown.cs",
    "FhirOid.cs",
    "FhirPositiveInt.cs",
    "FhirTime.cs",
    "FhirUnsignedInt.cs",
    "FhirUri.cs",
    "FhirXhtml.cs"
)

foreach ($file in $files) {
    $filePath = "Fhir.TypeFramework/DataTypes/PrimitiveTypes/$file"
    if (Test-Path $filePath) {
        $content = Get-Content $filePath -Raw
        
        # 修復雙大括號問題
        $content = $content -replace "public class \w+ : PrimitiveType\s*\{\{", "public class $($file -replace '\.cs$', '') : PrimitiveType`n{"
        
        # 移除無效的方法調用
        $content = $content -replace "return CreateFromString<\w+>\(value\);", "return value == null ? null : new $($file -replace '\.cs$', '')(value);"
        $content = $content -replace "return GetStringValue\(fhirValue\);", "return fhirValue?.Value;"
        $content = $content -replace "return CreateFromNumeric<\w+>\(value\);", "return new $($file -replace '\.cs$', '')(value);"
        $content = $content -replace "return GetNumericValue\(fhirValue\);", "return fhirValue?.Value;"
        
        # 修復無效的 return 語句
        $content = $content -replace "return ;", "return null;"
        
        # 移除重複的抽象方法實現
        $content = $content -replace "protected override bool Validate\w+Value\([^)]*\)\s*\{[^}]*\}", ""
        
        # 確保類別正確結束
        $content = $content -replace "(\s+})\s*$", "`n$1"
        
        Set-Content $filePath $content -Encoding UTF8
        Write-Host "Fixed syntax: $file"
    }
} 