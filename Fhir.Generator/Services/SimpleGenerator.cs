using System.Text;
using Fhir.Generator.Models;
using System.Collections.Generic; // Added for Dictionary
using System; // Added for DateTime

namespace Fhir.Generator.Services;

/// <summary>
/// 簡化的 FHIR 生成器
/// </summary>
public class SimpleGenerator
{
    private readonly SimpleTypeMapper _typeMapper;

    public SimpleGenerator()
    {
        _typeMapper = new SimpleTypeMapper();
    }

    /// <summary>
    /// 生成簡化的原始型別
    /// </summary>
    public string GenerateSimplePrimitiveType(PrimitiveTypeInfo info, string version)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine($"// Auto-generated for FHIR {version}");
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine("using Fhir.Support.Base;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.Models.{version};");
        sb.AppendLine();
        sb.AppendLine($"/// <summary>");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </summary>");
        sb.AppendLine($"public class {info.ClassName} : SimplePrimitiveType<{info.NativeType}>");
        sb.AppendLine("{");
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// 建立新的 {info.ClassName} 實例");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public {info.ClassName}() {{ }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// 建立新的 {info.ClassName} 實例");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    /// <param name=\"value\">初始值</param>");
        sb.AppendLine($"    public {info.ClassName}({info.NativeType}? value)");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        Value = value;");
        sb.AppendLine($"    }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// 驗證值");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    /// <param name=\"validationContext\">驗證上下文</param>");
        sb.AppendLine($"    /// <returns>驗證結果</returns>");
        sb.AppendLine($"    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        // 基礎驗證邏輯");
        sb.AppendLine($"        if (Value == null) yield break;");
        sb.AppendLine();
        sb.AppendLine($"        // 預設無額外驗證");
        sb.AppendLine($"    }}");
        sb.AppendLine("}");

        return sb.ToString();
    }

    /// <summary>
    /// 生成簡化的複雜型別
    /// </summary>
    public string GenerateSimpleComplexType(DataTypeInfo info, string version)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine($"// Auto-generated for FHIR {version}");
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine("using Fhir.Support.Base;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.Models.{version};");
        sb.AppendLine();
        sb.AppendLine($"/// <summary>");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </summary>");
        sb.AppendLine($"public class {info.ClassName} : SimpleComplexType");
        sb.AppendLine("{");

        // 生成屬性
        foreach (var property in info.Properties)
        {
            var propertyType = GetSimplePropertyType(property.Type, property.Name);
            var description = CleanDescription(property.Description);
            
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    /// {description}");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    [JsonPropertyName(\"{GetJsonPropertyName(property.Name)}\")]");
            sb.AppendLine($"    public {propertyType} {property.Name} {{ get; set; }}");
            sb.AppendLine();
        }

        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// 驗證此實例");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    /// <param name=\"validationContext\">驗證上下文</param>");
        sb.AppendLine($"    /// <returns>驗證結果</returns>");
        sb.AppendLine($"    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        foreach (var result in base.Validate(validationContext))");
        sb.AppendLine($"            yield return result;");
        sb.AppendLine();
        sb.AppendLine($"        // 自訂驗證邏輯");
        sb.AppendLine($"        // 子類別可以覆寫此方法來添加特定的驗證邏輯");
        sb.AppendLine($"    }}");
        sb.AppendLine("}");

        return sb.ToString();
    }

    /// <summary>
    /// 生成簡化的資源
    /// </summary>
    public string GenerateSimpleResource(ResourceInfo info, string version)
    {
        var sb = new StringBuilder();
        
        sb.AppendLine($"// Auto-generated for FHIR {version}");
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine("using Fhir.Support.Base;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.Models.{version};");
        sb.AppendLine();
        sb.AppendLine($"/// <summary>");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </summary>");
        sb.AppendLine($"public class {info.ClassName} : SimpleDomainResource");
        sb.AppendLine("{");

        // 生成屬性
        foreach (var property in info.Properties)
        {
            var propertyType = GetSimplePropertyType(property.Type, property.Name);
            var description = CleanDescription(property.Description);
            
            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    /// {description}");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    [JsonPropertyName(\"{GetJsonPropertyName(property.Name)}\")]");
            sb.AppendLine($"    public {propertyType} {property.Name} {{ get; set; }}");
            sb.AppendLine();
        }

        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// 資源類型");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public override string ResourceType => \"{info.ResourceType}\";");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// 驗證此實例");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    /// <param name=\"validationContext\">驗證上下文</param>");
        sb.AppendLine($"    /// <returns>驗證結果</returns>");
        sb.AppendLine($"    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        foreach (var result in base.Validate(validationContext))");
        sb.AppendLine($"            yield return result;");
        sb.AppendLine();
        sb.AppendLine($"        // 自訂驗證邏輯");
        sb.AppendLine($"        // 子類別可以覆寫此方法來添加特定的驗證邏輯");
        sb.AppendLine($"    }}");
        sb.AppendLine("}");

        return sb.ToString();
    }

    /// <summary>
    /// 取得簡單屬性型別
    /// </summary>
    private string GetSimplePropertyType(string fhirType, string propertyName)
    {
        // 基礎型別映射
        var baseTypeMapping = new Dictionary<string, string>
        {
            { "boolean", "bool?" },
            { "integer", "int?" },
            { "decimal", "decimal?" },
            { "string", "string?" },
            { "date", "DateTime?" },
            { "dateTime", "DateTime?" },
            { "time", "string?" },
            { "instant", "DateTime?" },
            { "code", "string?" },
            { "uri", "string?" },
            { "url", "string?" },
            { "canonical", "string?" },
            { "base64Binary", "string?" },
            { "markdown", "string?" },
            { "unsignedInt", "uint?" },
            { "positiveInt", "uint?" },
            { "id", "string?" },
            { "oid", "string?" },
            { "uuid", "string?" }
        };

        // 複雜型別映射到 Fhir.Support.Base
        var complexTypeMapping = new Dictionary<string, string>
        {
            { "Identifier", "SimpleIdentifier?" },
            { "HumanName", "SimpleHumanName?" },
            { "ContactPoint", "SimpleContactPoint?" },
            { "Address", "SimpleAddress?" },
            { "CodeableConcept", "SimpleCodeableConcept?" },
            { "Coding", "SimpleCoding?" },
            { "Reference", "SimpleReference?" },
            { "Period", "SimplePeriod?" },
            { "Quantity", "SimpleQuantity?" },
            { "Range", "SimpleRange?" },
            { "Ratio", "SimpleRatio?" },
            { "SampledData", "SimpleSampledData?" },
            { "Duration", "SimpleDuration?" },
            { "Annotation", "SimpleAnnotation?" },
            { "Attachment", "SimpleAttachment?" }
        };

        // 檢查基礎型別
        if (baseTypeMapping.ContainsKey(fhirType))
        {
            return baseTypeMapping[fhirType];
        }

        // 檢查複雜型別
        if (complexTypeMapping.ContainsKey(fhirType))
        {
            return complexTypeMapping[fhirType];
        }

        // 如果是嵌套組件，暫時使用 SimpleBackboneElement
        if (fhirType.Contains("."))
        {
            // 處理嵌套類型，暫時使用 SimpleBackboneElement
            return "SimpleBackboneElement?";
        }

        // 預設返回 string
        return "string?";
    }

    private string GetJsonPropertyName(string propertyName)
    {
        if (string.IsNullOrEmpty(propertyName))
            return string.Empty;

        // 轉換為 camelCase
        if (propertyName.Length == 0)
            return propertyName;

        if (propertyName.Length == 1)
            return propertyName.ToLowerInvariant();

        return char.ToLowerInvariant(propertyName[0]) + propertyName.Substring(1);
    }

    private string CleanDescription(string description)
    {
        if (string.IsNullOrEmpty(description))
            return string.Empty;

        // 移除 HTML 標籤
        description = System.Text.RegularExpressions.Regex.Replace(description, @"<[^>]*>", "");

        // 清理特殊字元
        description = description.Replace("&quot;", "\"")
                               .Replace("&apos;", "'")
                               .Replace("&lt;", "<")
                               .Replace("&gt;", ">")
                               .Replace("&amp;", "&");

        // 處理換行符號
        description = description.Replace("\r\n", " ")
                               .Replace("\r", " ")
                               .Replace("\n", " ");

        // 移除多餘的空白
        description = System.Text.RegularExpressions.Regex.Replace(description, @"\s+", " ");

        // 限制長度
        if (description.Length > 200)
        {
            description = description.Substring(0, 197) + "...";
        }

        return description.Trim();
    }
} 