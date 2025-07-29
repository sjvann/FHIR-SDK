# 修復缺少 PrimitiveTypeBases using 語句的檔案
$files = @(
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirBase64Binary.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirDate.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirMarkdown.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirOid.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirInteger64.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirPositiveInt.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirUnsignedInt.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirXhtml.cs",
    "Fhir.TypeFramework/DataTypes/PrimitiveTypes/FhirUuid.cs"
)

foreach ($file in $files) {
    if (Test-Path $file) {
        $content = Get-Content $file -Raw
        if ($content -match "using Fhir\.TypeFramework\.Bases;") {
            $newContent = $content -replace "using Fhir\.TypeFramework\.Bases;", "using Fhir.TypeFramework.Bases;`nusing Fhir.TypeFramework.Bases.PrimitiveTypeBases;"
            Set-Content $file $newContent -Encoding UTF8
            Write-Host "Fixed: $file"
        }
    }
} 