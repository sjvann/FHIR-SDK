# 修復剩餘的大括號問題
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
        
        # 計算大括號數量
        $openBraces = ($content | Select-String -Pattern "{" -AllMatches).Matches.Count
        $closeBraces = ($content | Select-String -Pattern "}" -AllMatches).Matches.Count
        
        Write-Host "$file - Open: $openBraces, Close: $closeBraces"
        
        # 如果大括號不匹配，在檔案末尾添加缺少的大括號
        if ($openBraces -gt $closeBraces) {
            $missingBraces = $openBraces - $closeBraces
            $content += "`n" + ("}" * $missingBraces)
            Set-Content $filePath $content -Encoding UTF8
            Write-Host "Fixed $file - added $missingBraces closing braces"
        }
    }
} 