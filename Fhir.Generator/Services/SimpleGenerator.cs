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
        
        sb.AppendLine($"// Auto-generated for FHIR {version} - Based on existing architecture");
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine($"using Fhir.{version}.Models.Base;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.{version}.Models.DataTypes;");
        sb.AppendLine();
        sb.AppendLine($"/// <summary>");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </summary>");
        sb.AppendLine($"/// <remarks>");
        sb.AppendLine($"/// FHIR {version} {info.ClassName} PrimitiveType");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </remarks>");
        sb.AppendLine($"public class {info.ClassName} : Element");
        sb.AppendLine("{");
        sb.AppendLine($"    private {info.NativeType}? _value;");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// The actual {info.ClassName.ToLower()} value.");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    [JsonPropertyName(\"value\")]");
        sb.AppendLine($"    public {info.NativeType}? Value");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        get => _value;");
        sb.AppendLine($"        set => _value = value;");
        sb.AppendLine($"    }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Initializes a new instance of the {info.ClassName} class.");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public {info.ClassName}() {{ }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Initializes a new instance of the {info.ClassName} class with a value.");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    /// <param name=\"value\">The initial value</param>");
        sb.AppendLine($"    public {info.ClassName}({info.NativeType}? value)");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        Value = value;");
        sb.AppendLine($"    }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Implicit conversion from {info.NativeType} to {info.ClassName}");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public static implicit operator {info.ClassName}?({info.NativeType}? value)");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        return value == null ? null : new {info.ClassName}(value);");
        sb.AppendLine($"    }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Implicit conversion from {info.ClassName} to {info.NativeType}");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public static implicit operator {info.NativeType}?({info.ClassName}? fhir{info.ClassName})");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        return fhir{info.ClassName}?.Value;");
        sb.AppendLine($"    }}");
        sb.AppendLine();
        sb.AppendLine($"    /// <summary>");
        sb.AppendLine($"    /// Returns the string representation of the value");
        sb.AppendLine($"    /// </summary>");
        sb.AppendLine($"    public override string ToString()");
        sb.AppendLine($"    {{");
        sb.AppendLine($"        return Value?.ToString() ?? string.Empty;");
        sb.AppendLine($"    }}");
        sb.AppendLine();
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
        
        sb.AppendLine($"// Auto-generated for FHIR {version} - Based on existing architecture");
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine($"using Fhir.{version}.Models.Base;");
        sb.AppendLine($"using Fhir.{version}.Models.DataTypes;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.{version}.Models.Resources;");
        sb.AppendLine();
        sb.AppendLine($"/// <summary>");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </summary>");
        sb.AppendLine($"/// <remarks>");
        sb.AppendLine($"/// FHIR {version} {info.ClassName} DomainResource");
        sb.AppendLine($"/// {info.Description}");
        sb.AppendLine($"/// </remarks>");
        sb.AppendLine($"public class {info.ClassName} : DomainResource");
        sb.AppendLine("{");
        sb.AppendLine($"    [JsonPropertyName(\"resourceType\")]");
        sb.AppendLine($"    public override string ResourceType => \"{info.ClassName}\";");
        sb.AppendLine();

        // 生成屬性
        foreach (var property in info.Properties)
        {
            var propertyType = GetFhirCompliantPropertyType(property.Type, property.Name);
            var description = CleanDescription(property.Description);
            var fhirPath = $"{info.ClassName}.{GetJsonPropertyName(property.Name)}";
            var cardinality = GetCardinality(property);

            sb.AppendLine($"    /// <summary>");
            sb.AppendLine($"    /// {description}");
            sb.AppendLine($"    /// FHIR Path: {fhirPath}");
            sb.AppendLine($"    /// Cardinality: {cardinality}");
            sb.AppendLine($"    /// </summary>");
            sb.AppendLine($"    [JsonPropertyName(\"{GetJsonPropertyName(property.Name)}\")]");
            sb.AppendLine($"    public {propertyType} {property.Name} {{ get; set; }}");
            sb.AppendLine();
        }
        // 驗證邏輯由 SDK 主架構提供，Generator 只生成基本結構
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

    /// <summary>
    /// 取得正確的 FHIR 架構屬性型別 (使用正確的 FHIR Primitive Types)
    /// </summary>
    private string GetFhirCompliantPropertyType(string fhirType, string propertyName)
    {
        // 使用正確的 FHIR Primitive Types (不是 Patient.cs 的錯誤實作)
        return fhirType switch
        {
            // FHIR Primitive Types - 正確的架構
            "string" => "FhirString?",
            "code" => "FhirCode?",
            "uri" => "FhirUri?",
            "url" => "FhirUrl?",
            "canonical" => "FhirCanonical?",
            "date" => "FhirDate?",
            "dateTime" => "FhirDateTime?",
            "instant" => "FhirInstant?",
            "time" => "FhirTime?",
            "id" => "FhirId?",
            "oid" => "FhirOid?",
            "uuid" => "FhirUuid?",
            "base64Binary" => "FhirBase64Binary?",
            "markdown" => "FhirMarkdown?",
            "boolean" => "FhirBoolean?",
            "integer" => "FhirInteger?",
            "decimal" => "FhirDecimal?",
            "positiveInt" => "FhirPositiveInt?",
            "unsignedInt" => "FhirUnsignedInt?",

            // 複雜類型
            "Identifier" => "List<Identifier>?",
            "HumanName" => "List<HumanName>?",
            "ContactPoint" => "List<ContactPoint>?",
            "Address" => "List<Address>?",
            "CodeableConcept" => "CodeableConcept?",
            "Coding" => "List<Coding>?",
            "Reference" => "Reference?",
            "Period" => "Period?",
            "Quantity" => "Quantity?",
            "Range" => "Range?",
            "Ratio" => "Ratio?",
            "Attachment" => "Attachment?",
            "Annotation" => "List<Annotation>?",

            // Default to the type name with nullable
            _ => $"{fhirType}?"
        };
    }

    /// <summary>
    /// 取得屬性的 Cardinality 資訊
    /// </summary>
    private string GetCardinality(PropertyDefinition property)
    {
        // 根據屬性類型推斷 cardinality
        if (property.Type.Contains("List<"))
        {
            return property.IsRequired ? "1..*" : "0..*";
        }
        else
        {
            return property.IsRequired ? "1..1" : "0..1";
        }
    }

    // 移除複雜的驗證邏輯生成 - 這些由 SDK 主架構處理
    // Generator 只專注於生成正確的類別結構

    // 所有驗證邏輯都移除 - 由 SDK 主架構處理



    /// <summary>
    /// 提取 List<T> 中的內部類型
    /// </summary>
    private string ExtractInnerType(string type)
    {
        if (type.StartsWith("List<") && type.EndsWith(">"))
        {
            return type.Substring(5, type.Length - 6).TrimEnd('?');
        }
        return type;
    }

    /// <summary>
    /// 判斷是否為複雜類型
    /// </summary>
    private bool IsComplexType(string type)
    {
        var primitiveTypes = new[] { "string", "int", "bool", "decimal", "DateTime" };
        var fhirPrimitiveTypes = new[] { "FhirString", "FhirBoolean", "FhirInteger", "FhirDecimal", "FhirDateTime", "FhirDate", "FhirTime", "FhirInstant", "FhirUri", "FhirUrl", "FhirCode" };

        var cleanType = type.TrimEnd('?');
        return !primitiveTypes.Contains(cleanType) && !fhirPrimitiveTypes.Contains(cleanType);
    }

    // 移除所有驗證輔助方法 - 由 SDK 主架構處理
}