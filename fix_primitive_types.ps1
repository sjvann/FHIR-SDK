# 修復所有 Primitive Types 的基類繼承
$primitiveTypes = @(
    @{ File = "FhirBoolean.cs"; Base = "BooleanPrimitiveTypeBase"; Type = "bool" },
    @{ File = "FhirCanonical.cs"; Base = "PrimitiveTypeBase<string>"; Type = "string" },
    @{ File = "FhirCode.cs"; Base = "StringPrimitiveTypeBase"; Type = "string" },
    @{ File = "FhirDateTime.cs"; Base = "PrimitiveTypeBase<DateTime>"; Type = "DateTime" },
    @{ File = "FhirDate.cs"; Base = "PrimitiveTypeBase<DateTime>"; Type = "DateTime" },
    @{ File = "FhirDecimal.cs"; Base = "PrimitiveTypeBase<decimal>"; Type = "decimal" },
    @{ File = "FhirId.cs"; Base = "StringPrimitiveTypeBase"; Type = "string" },
    @{ File = "FhirInstant.cs"; Base = "PrimitiveTypeBase<DateTime>"; Type = "DateTime" },
    @{ File = "FhirInteger.cs"; Base = "NumericPrimitiveTypeBase<int>"; Type = "int" },
    @{ File = "FhirBase64Binary.cs"; Base = "PrimitiveTypeBase<byte[]>"; Type = "byte[]" },
    @{ File = "FhirInteger64.cs"; Base = "PrimitiveTypeBase<long>"; Type = "long" },
    @{ File = "FhirOid.cs"; Base = "PrimitiveTypeBase<string>"; Type = "string" },
    @{ File = "FhirPositiveInt.cs"; Base = "PrimitiveTypeBase<int>"; Type = "int" },
    @{ File = "FhirMarkdown.cs"; Base = "PrimitiveTypeBase<string>"; Type = "string" },
    @{ File = "FhirTime.cs"; Base = "PrimitiveTypeBase<TimeSpan>"; Type = "TimeSpan" },
    @{ File = "FhirUri.cs"; Base = "StringPrimitiveTypeBase"; Type = "string" },
    @{ File = "FhirUnsignedInt.cs"; Base = "PrimitiveTypeBase<uint>"; Type = "uint" },
    @{ File = "FhirUuid.cs"; Base = "PrimitiveTypeBase<Guid>"; Type = "Guid" },
    @{ File = "FhirXhtml.cs"; Base = "PrimitiveTypeBase<string>"; Type = "string" },
    @{ File = "FhirUrl.cs"; Base = "StringPrimitiveTypeBase"; Type = "string" }
)

foreach ($pt in $primitiveTypes) {
    $filePath = "Fhir.TypeFramework/DataTypes/PrimitiveTypes/$($pt.File)"
    
    if (Test-Path $filePath) {
        $content = Get-Content $filePath -Raw
        
        # 替換 using 語句
        $content = $content -replace "using Fhir\.TypeFramework\.Bases\.PrimitiveTypeBases;", "using Fhir.TypeFramework.Bases;`nusing System.ComponentModel.DataAnnotations;`nusing System.Text.Json.Serialization;"
        
        # 替換基類繼承
        $content = $content -replace "public class $($pt.File -replace '\.cs$', '') : $($pt.Base)", "public class $($pt.File -replace '\.cs$', '') : PrimitiveType"
        
        # 添加 Value 屬性
        $className = $pt.File -replace '\.cs$', ''
        $typeName = $pt.Type
        $valueProperty = @"
    /// <summary>
    /// $typeName 值
    /// </summary>
    [JsonIgnore]
    public $typeName? Value
    {
        get => $($typeName == "string" ? "StringValue" : "ParseValue(StringValue) as $typeName");
        set => StringValue = $($typeName == "string" ? "value" : "ValueToString(value)");
    }

"@
        
        # 在類別定義後添加 Value 屬性
        $content = $content -replace "public class $className : PrimitiveType", "public class $className : PrimitiveType`n{$valueProperty"
        
        # 修復隱含轉換運算子
        $content = $content -replace "return CreateFromString<[^>]+>\(value\);", "return value == null ? null : new $className(value);"
        $content = $content -replace "return GetStringValue\(fhirString\);", "return fhirString?.Value;"
        
        # 添加必要的抽象方法實現
        $abstractMethods = @"

    /// <summary>
    /// 從字串解析值
    /// </summary>
    /// <param name="value">要解析的字串</param>
    /// <returns>解析後的值</returns>
    public override object? ParseValue(string value)
    {
        return $($typeName == "string" ? "value" : "System.Convert.ChangeType(value, typeof($typeName))");
    }

    /// <summary>
    /// 將值轉換為字串
    /// </summary>
    /// <param name="value">要轉換的值</param>
    /// <returns>值的字串表示</returns>
    public override string? ValueToString(object? value)
    {
        return value?.ToString();
    }

    /// <summary>
    /// 驗證值是否符合 FHIR 規範
    /// </summary>
    /// <param name="value">要驗證的值</param>
    /// <returns>如果值符合規範則為 true，否則為 false</returns>
    public override bool IsValidValue(object? value)
    {
        if (value == null) return true;
        return value is $typeName;
    }
"@
        
        # 在類別結束前添加抽象方法
        $content = $content -replace "(\s+})\s*$", "$abstractMethods`n$1"
        
        Set-Content $filePath $content -Encoding UTF8
        Write-Host "Fixed: $($pt.File)"
    }
} 