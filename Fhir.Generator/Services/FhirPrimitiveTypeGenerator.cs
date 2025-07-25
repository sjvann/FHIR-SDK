using System.Text;

namespace Fhir.Generator.Services;

/// <summary>
/// 生成 FHIR 基礎型別類別的生成器
/// </summary>
public class FhirPrimitiveTypeGenerator
{
    private readonly EnhancedTypeMapper _typeMapper;

    public FhirPrimitiveTypeGenerator(EnhancedTypeMapper typeMapper)
    {
        _typeMapper = typeMapper;
    }

    /// <summary>
    /// 生成所有 FHIR 基礎型別
    /// </summary>
    /// <param name="outputDir">輸出目錄</param>
    /// <param name="version">FHIR 版本</param>
    public async Task GenerateAllPrimitiveTypesAsync(string outputDir, string version)
    {
        var primitiveTypes = new Dictionary<string, PrimitiveTypeInfo>
        {
            ["boolean"] = new("FhirBoolean", "bool?", "FhirPrimitiveType<bool?>", "Value of \"true\" or \"false\""),
            ["integer"] = new("FhirInteger", "int?", "FhirNumericType<int>", "A whole number"),
            ["integer64"] = new("FhirInteger64", "long?", "FhirNumericType<long>", "A very large whole number"),
            ["decimal"] = new("FhirDecimal", "decimal?", "FhirNumericType<decimal>", "A rational number with implicit precision"),
            ["base64Binary"] = new("FhirBase64Binary", "byte[]", "FhirPrimitiveType<byte[]>", "A stream of bytes"),
            ["instant"] = new("FhirInstant", "DateTimeOffset?", "FhirPrimitiveType<DateTimeOffset?>", "An instant in time - known at least to the second"),
            ["string"] = new("FhirString", "string", "FhirStringType", "A sequence of Unicode characters"),
            ["uri"] = new("FhirUri", "string", "FhirStringType", "String of characters used to identify a name or a resource"),
            ["url"] = new("FhirUrl", "string", "FhirStringType", "A URI that is a reference to a canonical URL on a FHIR resource"),
            ["canonical"] = new("FhirCanonical", "string", "FhirStringType", "A URI that is a reference to a canonical URL on a FHIR resource"),
            ["oid"] = new("FhirOid", "string", "FhirStringType", "An OID represented as a URI"),
            ["uuid"] = new("FhirUuid", "string", "FhirStringType", "A UUID, represented as a URI"),
            ["date"] = new("FhirDate", "DateTime?", "FhirPrimitiveType<DateTime?>", "A date or partial date"),
            ["dateTime"] = new("FhirDateTime", "DateTime?", "FhirPrimitiveType<DateTime?>", "A date, date-time or partial date"),
            ["time"] = new("FhirTime", "TimeSpan?", "FhirPrimitiveType<TimeSpan?>", "A time during the day, with no date specified"),
            ["code"] = new("FhirCode", "string", "FhirStringType", "A string which has at least one character and no leading or trailing whitespace"),
            ["id"] = new("FhirId", "string", "FhirStringType", "Any combination of letters, numerals, \"-\" and \".\", with a length limit of 64 characters"),
            ["markdown"] = new("FhirMarkdown", "string", "FhirStringType", "A string that may contain Github Flavored Markdown syntax"),
            ["unsignedInt"] = new("FhirUnsignedInt", "uint?", "FhirNumericType<uint>", "An integer with a value that is not negative"),
            ["positiveInt"] = new("FhirPositiveInt", "uint?", "FhirNumericType<uint>", "An integer with a value that is positive"),
            ["xhtml"] = new("FhirXhtml", "string", "FhirStringType", "XHTML format, as defined by W3C")
        };

        var dir = Path.Combine(outputDir, "DataTypes");
        Directory.CreateDirectory(dir);

        foreach (var (fhirType, info) in primitiveTypes)
        {
            var content = GeneratePrimitiveTypeClass(info, version);
            await File.WriteAllTextAsync(Path.Combine(dir, $"{info.ClassName}.cs"), content);
        }
    }

    /// <summary>
    /// 生成單個基礎型別類別
    /// </summary>
    private string GeneratePrimitiveTypeClass(PrimitiveTypeInfo info, string version)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"// Auto-generated for FHIR {version}");
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine("using Fhir.Support.Base;");
        sb.AppendLine("using Fhir.Support.Attributes;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.{version}.Models;");
        sb.AppendLine();
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine("/// </summary>");
        sb.AppendLine($"public class {info.ClassName} : {info.BaseClass}");
        sb.AppendLine("{");

        // 建構函式
        sb.AppendLine("    /// <summary>");
        sb.AppendLine($"    /// 建立新的 {info.ClassName} 實例");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine($"    public {info.ClassName}() {{ }}");
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine($"    /// 建立新的 {info.ClassName} 實例");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <param name=\"value\">初始值</param>");
        sb.AppendLine($"    public {info.ClassName}({info.NativeType} value) : base(value) {{ }}");
        sb.AppendLine();

        // 隱式轉換
        sb.AppendLine("    /// <summary>");
        sb.AppendLine($"    /// 隱式轉換從 {info.NativeType}");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine($"    /// <param name=\"value\">原生值</param>");
        sb.AppendLine($"    public static implicit operator {info.ClassName}?({info.NativeType} value)");
        sb.AppendLine("    {");
        sb.AppendLine($"        return value == null ? null : new {info.ClassName}(value);");
        sb.AppendLine("    }");
        sb.AppendLine();

        sb.AppendLine("    /// <summary>");
        sb.AppendLine($"    /// 隱式轉換到 {info.NativeType}");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine($"    /// <param name=\"fhirValue\">FHIR 值</param>");
        sb.AppendLine($"    public static implicit operator {info.NativeType}({info.ClassName}? fhirValue)");
        sb.AppendLine("    {");
        sb.AppendLine("        return fhirValue?.Value;");
        sb.AppendLine("    }");

        // 添加特定型別的方法
        AddTypeSpecificMethods(sb, info);

        sb.AppendLine("}");

        return sb.ToString();
    }

    /// <summary>
    /// 添加特定型別的方法
    /// </summary>
    private void AddTypeSpecificMethods(StringBuilder sb, PrimitiveTypeInfo info)
    {
        switch (info.ClassName)
        {
            case "FhirDate":
            case "FhirDateTime":
                AddDateTimeMethods(sb);
                break;
            case "FhirTime":
                AddTimeMethods(sb);
                break;
            case "FhirInstant":
                AddInstantMethods(sb);
                break;
            case "FhirBase64Binary":
                AddBase64BinaryMethods(sb);
                break;
        }
    }

    private void AddDateTimeMethods(StringBuilder sb)
    {
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 DateTime");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>DateTime 值</returns>");
        sb.AppendLine("    public DateTime? ToDateTime() => Value;");
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 DateOnly");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>DateOnly 值</returns>");
        sb.AppendLine("    public DateOnly? ToDateOnly() => Value.HasValue ? DateOnly.FromDateTime(Value.Value) : null;");
    }

    private void AddTimeMethods(StringBuilder sb)
    {
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 TimeSpan");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>TimeSpan 值</returns>");
        sb.AppendLine("    public TimeSpan? ToTimeSpan() => Value;");
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 TimeOnly");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>TimeOnly 值</returns>");
        sb.AppendLine("    public TimeOnly? ToTimeOnly() => Value.HasValue ? TimeOnly.FromTimeSpan(Value.Value) : null;");
    }

    private void AddInstantMethods(StringBuilder sb)
    {
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 DateTimeOffset");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>DateTimeOffset 值</returns>");
        sb.AppendLine("    public DateTimeOffset? ToDateTimeOffset() => Value;");
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 UTC DateTime");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>UTC DateTime 值</returns>");
        sb.AppendLine("    public DateTime? ToUtcDateTime() => Value?.UtcDateTime;");
    }

    private void AddBase64BinaryMethods(StringBuilder sb)
    {
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 轉換為 Base64 字串");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <returns>Base64 字串</returns>");
        sb.AppendLine("    public string ToBase64String() => Value != null ? Convert.ToBase64String(Value) : string.Empty;");
        sb.AppendLine();
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// 從 Base64 字串建立");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    /// <param name=\"base64String\">Base64 字串</param>");
        sb.AppendLine("    /// <returns>FhirBase64Binary 實例</returns>");
        sb.AppendLine("    public static FhirBase64Binary FromBase64String(string base64String)");
        sb.AppendLine("    {");
        sb.AppendLine("        return new FhirBase64Binary(Convert.FromBase64String(base64String));");
        sb.AppendLine("    }");
    }

    /// <summary>
    /// 基礎型別資訊
    /// </summary>
    private record PrimitiveTypeInfo(string ClassName, string NativeType, string BaseClass, string Description);
}
