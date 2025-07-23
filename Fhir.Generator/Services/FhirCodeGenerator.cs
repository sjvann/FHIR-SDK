using System.Text;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

public class FhirCodeGenerator
{
    private readonly EnhancedTypeMapper _typeMapper;
    private readonly BaseClassGenerator _baseClassGenerator = new();
    private readonly SpecialTypeGenerator _specialTypeGenerator = new();
    private readonly FhirPrimitiveTypeGenerator _primitiveTypeGenerator;

    public FhirCodeGenerator()
    {
        _typeMapper = new EnhancedTypeMapper();
        _primitiveTypeGenerator = new FhirPrimitiveTypeGenerator(_typeMapper);
    }

    public async Task GenerateAllAsync(FhirSchema schema, string outputDir)
    {
        Console.WriteLine("🔧 Generating base classes...");
        await _baseClassGenerator.GenerateAllBaseClassesAsync(outputDir, schema.Version);

        Console.WriteLine("🔧 Generating special types...");
        await _specialTypeGenerator.GenerateSpecialTypesAsync(outputDir, schema.Version);

        Console.WriteLine("🔧 Generating FHIR primitive types...");
        await _primitiveTypeGenerator.GenerateAllPrimitiveTypesAsync(outputDir, schema.Version);

        Console.WriteLine("🔧 Generating data types...");
        foreach (var dataType in schema.DataTypes.Values.OrderBy(t => GetTypeOrder(t)))
        {
            await GenerateTypeAsync(dataType, outputDir, "DataTypes", schema.Version);
        }
        
        Console.WriteLine("🔧 Generating resources...");
        foreach (var resource in schema.Resources.Values)
        {
            await GenerateResourceAsync(resource, outputDir, "Resources", schema.Version);
        }
    }
    
    private async Task GenerateTypeAsync(TypeDefinition type, string outputDir, string subDir, string version)
    {
        // 跳過基礎型別，因為它們由 FhirPrimitiveTypeGenerator 處理
        if (_typeMapper.IsPrimitiveType(type.Name))
        {
            Console.WriteLine($"  Skipping primitive type: {type.Name} (handled by FhirPrimitiveTypeGenerator)");
            return;
        }

        var dir = Path.Combine(outputDir, subDir);
        Directory.CreateDirectory(dir);

        var content = GenerateClassContent(type, version, false);
        var fileName = SanitizeFileName(type.Name);
        await File.WriteAllTextAsync(Path.Combine(dir, $"{fileName}.cs"), content);
    }
    
    private async Task GenerateResourceAsync(ResourceDefinition resource, string outputDir, string subDir, string version)
    {
        var dir = Path.Combine(outputDir, subDir);
        Directory.CreateDirectory(dir);
        
        var content = GenerateClassContent(resource, version, true);
        var fileName = SanitizeFileName(resource.Name);
        await File.WriteAllTextAsync(Path.Combine(dir, $"{fileName}.cs"), content);
    }
    
    private string GenerateClassContent(TypeDefinition type, string version, bool isResource)
    {
        var baseClass = DetermineBaseClass(type, isResource);
        var resourceType = isResource ? ((ResourceDefinition)type).ResourceType : null;
        
        var sb = new StringBuilder();
        sb.AppendLine($"// Auto-generated for FHIR {version}");
        sb.AppendLine($"using System.ComponentModel.DataAnnotations;");
        sb.AppendLine();
        sb.AppendLine($"namespace Fhir.{version}.Models;");
        sb.AppendLine();
        
        // XML 文檔註解
        if (!string.IsNullOrEmpty(type.Description))
        {
            sb.AppendLine("/// <summary>");
            // 清理和格式化描述文字
            var cleanDescription = CleanDescriptionForXmlComment(type.Description);
            var lines = SplitDescriptionIntoLines(cleanDescription, 100); // 限制每行最多100字符

            foreach (var line in lines)
            {
                sb.AppendLine($"/// {line}");
            }
            sb.AppendLine("/// </summary>");
        }
        
        // 類別宣告
        sb.AppendLine($"public class {type.Name} : {baseClass}");
        sb.AppendLine("{");
        
        // ResourceType 屬性 (僅限資源)
        if (isResource && !string.IsNullOrEmpty(resourceType))
        {
            sb.AppendLine($"    public override string ResourceType => \"{resourceType}\";");
            sb.AppendLine();
        }
        
        // 生成屬性
        foreach (var property in type.Properties.OrderBy(p => p.Order))
        {
            GenerateProperty(sb, property);
        }
        
        // 生成驗證方法
        GenerateValidationMethod(sb, type);

        // 生成 FHIR 驗證規則
        GenerateFhirValidationMethod(sb, type);
        
        sb.AppendLine("}");
        
        return sb.ToString();
    }

    private static string SanitizeFileName(string fileName)
    {
        // 移除或替換無效的檔案名稱字符
        var invalidChars = Path.GetInvalidFileNameChars();
        var sanitized = fileName;

        foreach (var invalidChar in invalidChars)
        {
            sanitized = sanitized.Replace(invalidChar, '_');
        }

        // 替換空格為底線
        sanitized = sanitized.Replace(' ', '_');

        // 移除連續的底線
        while (sanitized.Contains("__"))
        {
            sanitized = sanitized.Replace("__", "_");
        }

        // 移除開頭和結尾的底線
        sanitized = sanitized.Trim('_');

        // 確保不是空字串
        if (string.IsNullOrEmpty(sanitized))
        {
            sanitized = "UnknownType";
        }

        return sanitized;
    }
    
    private void GenerateProperty(StringBuilder sb, PropertyDefinition property)
    {
        // XML 文檔註解
        if (!string.IsNullOrEmpty(property.Description))
        {
            sb.AppendLine("    /// <summary>");

            // 清理和格式化描述文字
            var cleanDescription = CleanDescriptionForXmlComment(property.Description);
            var lines = SplitDescriptionIntoLines(cleanDescription, 100); // 限制每行最多100字符

            foreach (var line in lines)
            {
                sb.AppendLine($"    /// {line}");
            }

            sb.AppendLine("    /// </summary>");
        }

        // FHIR 元素屬性
        sb.AppendLine($"    [FhirElement(\"{GetOriginalElementName(property)}\", Order = {property.Order})]");

        // 基數屬性
        var maxCard = property.MaxCardinality == "*" ? "int.MaxValue" : property.MaxCardinality;
        sb.AppendLine($"    [Cardinality({property.MinCardinality}, {maxCard})]");

        // Choice Type 屬性
        if (property.IsChoiceType)
        {
            var baseName = ExtractChoiceBaseName(property.Name);
            var typeCode = ExtractChoiceTypeCode(property.Name, baseName);
            sb.AppendLine($"    [ChoiceType(\"{baseName}\", \"{typeCode}\")]");
        }

        // 驗證屬性
        if (property.MinCardinality > 0)
        {
            sb.AppendLine("    [Required]");
        }

        // JSON 序列化屬性
        sb.AppendLine($"    [JsonPropertyName(\"{GetOriginalElementName(property)}\")]");

        // 屬性宣告
        sb.AppendLine($"    public {property.Type} {property.Name} {{ get; set; }}");
        sb.AppendLine();
    }

    private string GetOriginalElementName(PropertyDefinition property)
    {
        if (property.IsChoiceType)
        {
            var baseName = ExtractChoiceBaseName(property.Name);
            var typeCode = ExtractChoiceTypeCode(property.Name, baseName);
            return $"{baseName}{char.ToUpper(typeCode[0])}{typeCode[1..]}";
        }

        return char.ToLower(property.Name[0]) + property.Name[1..];
    }

    private string ExtractChoiceBaseName(string propertyName)
    {
        // 從 "ValueString" 提取 "value"
        var knownTypes = new[] { "String", "Integer", "Boolean", "DateTime", "Code", "Uri", "Decimal", "Reference", "CodeableConcept", "Coding", "Quantity", "Period", "Range", "Ratio", "Attachment", "Identifier", "HumanName", "Address", "ContactPoint", "Timing", "Signature", "Annotation" };

        foreach (var type in knownTypes.OrderByDescending(t => t.Length))
        {
            if (propertyName.EndsWith(type))
            {
                var baseName = propertyName[..^type.Length];
                if (string.IsNullOrEmpty(baseName))
                    return propertyName.ToLower();
                return char.ToLower(baseName[0]) + baseName[1..];
            }
        }

        return propertyName.ToLower();
    }

    private string ExtractChoiceTypeCode(string propertyName, string baseName)
    {
        if (propertyName.Length <= baseName.Length)
            return "unknown";

        var typeCode = propertyName[baseName.Length..];
        if (string.IsNullOrEmpty(typeCode))
            return "unknown";

        return char.ToLower(typeCode[0]) + typeCode[1..];
    }

    private void GenerateValidationMethod(StringBuilder sb, TypeDefinition type)
    {
        var choiceGroups = type.Properties
            .Where(p => p.IsChoiceType)
            .GroupBy(p => ExtractChoiceBaseName(p.Name))
            .ToList();

        if (!choiceGroups.Any()) return;

        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Validates choice type constraints");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)");
        sb.AppendLine("    {");
        sb.AppendLine("        foreach (var result in base.Validate(validationContext))");
        sb.AppendLine("            yield return result;");
        sb.AppendLine();

        foreach (var choiceGroup in choiceGroups)
        {
            var baseName = choiceGroup.Key;
            var properties = choiceGroup.ToList();

            sb.AppendLine($"        // Choice Type validation for {baseName}[x]");
            sb.AppendLine($"        var {baseName}Properties = new[] {{ {string.Join(", ", properties.Select(p => $"nameof({p.Name})"))} }};");
            sb.AppendLine($"        var {baseName}SetCount = {baseName}Properties.Count(prop => ");
            sb.AppendLine($"            GetType().GetProperty(prop)?.GetValue(this) != null);");
            sb.AppendLine();
            sb.AppendLine($"        if ({baseName}SetCount > 1)");
            sb.AppendLine("        {");
            sb.AppendLine("            yield return new ValidationResult(");
            sb.AppendLine($"                \"Only one of {string.Join(", ", properties.Select(p => p.Name))} may be specified\",");
            sb.AppendLine($"                new[] {{ {string.Join(", ", properties.Select(p => $"nameof({p.Name})"))} }});");
            sb.AppendLine("        }");
            sb.AppendLine();
        }

        sb.AppendLine("    }");
        sb.AppendLine();
    }

    private void GenerateFhirValidationMethod(StringBuilder sb, TypeDefinition type)
    {
        if (!type.ValidationRules.Any()) return;

        var validationGenerator = new ValidationRuleGenerator();
        var validationCode = validationGenerator.GenerateValidationCode(type.ValidationRules, type.Name);

        if (!string.IsNullOrEmpty(validationCode))
        {
            sb.AppendLine();
            sb.AppendLine(validationCode);
        }
    }

    private int GetTypeOrder(TypeDefinition type)
    {
        // 確保基礎型別先生成
        return type.Name switch
        {
            "Element" => 1,
            "BackboneElement" => 2,
            "DataType" => 3,
            "PrimitiveType" => 4,
            _ => 10
        };
    }

    private string DetermineBaseClass(TypeDefinition type, bool isResource)
    {
        if (isResource)
        {
            return type.BaseType switch
            {
                "DomainResource" => "DomainResource",
                "Resource" => "Resource",
                _ => "Resource"
            };
        }

        return type.BaseType switch
        {
            "Element" => "Element",
            "BackboneElement" => "BackboneElement",
            "DataType" => "DataType",
            "PrimitiveType" => "PrimitiveType",
            _ => "Element"
        };
    }

    /// <summary>
    /// 清理描述文字，移除無效字符並進行 XML 轉義
    /// </summary>
    private string CleanDescriptionForXmlComment(string description)
    {
        if (string.IsNullOrEmpty(description))
            return string.Empty;

        // 移除換行符和回車符，替換為空格
        var cleaned = description
            .Replace('\n', ' ')
            .Replace('\r', ' ')
            .Replace('\t', ' ');

        // 移除多餘的空格
        while (cleaned.Contains("  "))
        {
            cleaned = cleaned.Replace("  ", " ");
        }

        // XML 轉義
        cleaned = cleaned
            .Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("\"", "&quot;")
            .Replace("'", "&apos;");

        return cleaned.Trim();
    }

    /// <summary>
    /// 將長描述分割成多行，每行不超過指定長度
    /// </summary>
    private List<string> SplitDescriptionIntoLines(string description, int maxLength)
    {
        var lines = new List<string>();

        if (string.IsNullOrEmpty(description))
            return lines;

        if (description.Length <= maxLength)
        {
            lines.Add(description);
            return lines;
        }

        var words = description.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var currentLine = new StringBuilder();

        foreach (var word in words)
        {
            // 如果添加這個詞會超過長度限制
            if (currentLine.Length + word.Length + 1 > maxLength)
            {
                // 保存當前行並開始新行
                if (currentLine.Length > 0)
                {
                    lines.Add(currentLine.ToString());
                    currentLine.Clear();
                }
            }

            // 添加詞到當前行
            if (currentLine.Length > 0)
                currentLine.Append(' ');
            currentLine.Append(word);
        }

        // 添加最後一行
        if (currentLine.Length > 0)
        {
            lines.Add(currentLine.ToString());
        }

        return lines;
    }
}

