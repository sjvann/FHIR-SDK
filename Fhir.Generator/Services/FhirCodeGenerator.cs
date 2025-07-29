using System.Text;
using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

/// <summary>
/// FHIR 程式碼生成器
/// 從 FHIR Schema 生成 C# 類別
/// </summary>
public class FhirCodeGenerator
{
    private readonly EnhancedTypeMapper _typeMapper;
    
    public FhirCodeGenerator()
    {
        _typeMapper = new EnhancedTypeMapper();
    }
    
    /// <summary>
    /// 生成所有程式碼
    /// </summary>
    /// <param name="schema">FHIR Schema</param>
    /// <param name="outputDir">輸出目錄</param>
    /// <param name="fhirVersion">FHIR 版本</param>
    public async Task GenerateAllAsync(FhirSchema schema, string outputDir, string fhirVersion)
    {
        Console.WriteLine($"⚡ Generating {fhirVersion} code to: {outputDir}");
        
        // 建立目錄結構
        var resourcesDir = Path.Combine(outputDir, "Resources");
        var dataTypesDir = Path.Combine(outputDir, "DataTypes");
        
        Directory.CreateDirectory(resourcesDir);
        Directory.CreateDirectory(dataTypesDir);
        
        // 生成 Resources
        Console.WriteLine($"📄 Generating {schema.Resources.Count} resources...");
        foreach (var resource in schema.Resources.Values)
        {
            await GenerateResourceAsync(resource, resourcesDir, fhirVersion);
        }
        
        // 生成 DataTypes (跳過基礎型別，使用 Fhir.TypeFramework 中的定義)
        var primitiveTypes = new HashSet<string> { "string", "boolean", "integer", "decimal", "date", "dateTime", "time", "instant", "uri", "url", "canonical", "code", "id", "oid", "uuid", "markdown", "unsignedInt", "positiveInt", "base64Binary", "xhtml" };
        
        var complexTypes = schema.DataTypes.Values.Where(dt => !primitiveTypes.Contains(dt.Name)).ToList();
        Console.WriteLine($"🔧 Generating {complexTypes.Count} complex data types...");
        foreach (var dataType in complexTypes)
        {
            await GenerateDataTypeAsync(dataType, dataTypesDir, fhirVersion);
        }
        
        Console.WriteLine($"✅ Code generation completed!");
    }

    /// <summary>
    /// 只生成 Resources
    /// </summary>
    /// <param name="schema">FHIR Schema</param>
    /// <param name="outputDir">輸出目錄</param>
    /// <param name="fhirVersion">FHIR 版本</param>
    public async Task GenerateResourcesOnlyAsync(FhirSchema schema, string outputDir, string fhirVersion)
    {
        Console.WriteLine($"⚡ Generating {fhirVersion} resources to: {outputDir}");
        
        // 建立目錄結構
        var resourcesDir = Path.Combine(outputDir, "Resources");
        Directory.CreateDirectory(resourcesDir);
        
        // 生成 Resources
        Console.WriteLine($"📄 Generating {schema.Resources.Count} resources...");
        foreach (var resource in schema.Resources.Values)
        {
            await GenerateResourceAsync(resource, resourcesDir, fhirVersion);
        }
        
        Console.WriteLine($"✅ Resource generation completed!");
    }
    
    /// <summary>
    /// 生成 Resource 類別
    /// </summary>
    private async Task GenerateResourceAsync(ResourceDefinition resource, string outputDir, string fhirVersion)
    {
        try
        {
            Console.WriteLine($"  📄 Generating resource: {resource.Name}");
            
            var content = GenerateResourceClass(resource, fhirVersion);
            var fileName = SanitizeFileName(resource.Name);
            var filePath = Path.Combine(outputDir, $"{fileName}.cs");
            
            await File.WriteAllTextAsync(filePath, content);
            Console.WriteLine($"  ✅ Generated: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  ❌ Error generating {resource.Name}: {ex.Message}");
            throw;
        }
    }
    
    /// <summary>
    /// 生成 DataType 類別
    /// </summary>
    private async Task GenerateDataTypeAsync(TypeDefinition dataType, string outputDir, string fhirVersion)
    {
        try
        {
            Console.WriteLine($"  🔧 Generating data type: {dataType.Name}");
            
            var content = GenerateDataTypeClass(dataType, fhirVersion);
            var fileName = SanitizeFileName(dataType.Name);
            var filePath = Path.Combine(outputDir, $"{fileName}.cs");
            
            await File.WriteAllTextAsync(filePath, content);
            Console.WriteLine($"  ✅ Generated: {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  ❌ Error generating {dataType.Name}: {ex.Message}");
            throw;
        }
    }
    
    /// <summary>
    /// 生成 Resource 類別內容
    /// </summary>
    private string GenerateResourceClass(ResourceDefinition resource, string fhirVersion)
    {
        var namespaceName = $"Fhir.{fhirVersion}.Models.Resources";
        var sb = new StringBuilder();
        
        // 檔案標頭
        sb.AppendLine("// <auto-generated />");
        sb.AppendLine($"// FHIR {fhirVersion} Resource: {resource.Name}");
        sb.AppendLine("// This file is automatically generated. Do not edit manually.");
        sb.AppendLine();
        
        // Using 語句
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine($"using Fhir.{fhirVersion}.Models.Base;");
        sb.AppendLine("using Fhir.TypeFramework.DataTypes;");
        sb.AppendLine();
        
        // 命名空間
        sb.AppendLine($"namespace {namespaceName};");
        sb.AppendLine();
        
        // 類別註解
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"/// {resource.Description}");
        sb.AppendLine("/// </summary>");
        
        // 類別定義
        sb.AppendLine($"public class {resource.Name} : DomainResource");
        sb.AppendLine("{");
        
        // ResourceType 屬性
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Resource type name");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    [JsonPropertyName(\"resourceType\")]");
        sb.AppendLine($"    public override string ResourceType => \"{resource.Name}\";");
        sb.AppendLine();
        
        // 生成屬性
        foreach (var property in resource.Properties.Where(p => !IsBaseProperty(p.Name)))
        {
            GenerateProperty(sb, property, fhirVersion);
        }
        
        // 驗證方法
        GenerateValidationMethod(sb, resource);
        
        sb.AppendLine("}");
        
        return sb.ToString();
    }
    
    /// <summary>
    /// 生成 DataType 類別內容
    /// </summary>
    private string GenerateDataTypeClass(TypeDefinition dataType, string fhirVersion)
    {
        var namespaceName = $"Fhir.{fhirVersion}.Models.DataTypes";
        var sb = new StringBuilder();
        
        // 檔案標頭
        sb.AppendLine("// <auto-generated />");
        sb.AppendLine($"// FHIR {fhirVersion} DataType: {dataType.Name}");
        sb.AppendLine("// This file is automatically generated. Do not edit manually.");
        sb.AppendLine();
        
        // Using 語句
        sb.AppendLine("using System.ComponentModel.DataAnnotations;");
        sb.AppendLine("using System.Text.Json.Serialization;");
        sb.AppendLine("using Fhir.Support.Base;");
        sb.AppendLine();
        
        // 命名空間
        sb.AppendLine($"namespace {namespaceName};");
        sb.AppendLine();
        
        // 類別註解
        sb.AppendLine("/// <summary>");
        sb.AppendLine($"/// {dataType.Description}");
        sb.AppendLine("/// </summary>");
        
        // 類別定義
        sb.AppendLine($"public class {dataType.Name} : Element");
        sb.AppendLine("{");
        
        // 生成屬性
        foreach (var property in dataType.Properties.Where(p => !IsBaseProperty(p.Name)))
        {
            GenerateProperty(sb, property, fhirVersion);
        }
        
        // 驗證方法
        GenerateValidationMethod(sb, dataType);
        
        sb.AppendLine("}");
        
        return sb.ToString();
    }
    
    /// <summary>
    /// 生成基本屬性
    /// </summary>
    private void GenerateBaseProperties(StringBuilder sb)
    {
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Logical id of this artifact");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    [JsonPropertyName(\"id\")]");
        sb.AppendLine("    public string? Id { get; set; }");
        sb.AppendLine();
        
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// A human-readable narrative");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    [JsonPropertyName(\"text\")]");
        sb.AppendLine("    public object? Text { get; set; }");
        sb.AppendLine();
        
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Additional content defined by implementations");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    [JsonPropertyName(\"extension\")]");
        sb.AppendLine("    public IList<object>? Extension { get; set; }");
        sb.AppendLine();
        
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Extensions that cannot be ignored");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    [JsonPropertyName(\"modifierExtension\")]");
        sb.AppendLine("    public IList<object>? ModifierExtension { get; set; }");
        sb.AppendLine();
    }
    
    /// <summary>
    /// 生成屬性
    /// </summary>
    private void GenerateProperty(StringBuilder sb, PropertyDefinition property, string fhirVersion)
    {
        var propertyName = ToPascalCase(property.Name);
        
        // 使用基數資訊來決定型別
        var propertyType = _typeMapper.MapFhirTypeToCSharpWithCardinality(
            property.Type, 
            property.MinCardinality, 
            property.MaxCardinality, 
            property.TargetProfiles);

        // 處理屬性名稱與類型名稱衝突
        if (propertyName.Equals(property.Type, StringComparison.OrdinalIgnoreCase))
        {
            propertyName += "Value";
        }

        // 清理描述中的特殊字元
        var cleanDescription = CleanDescription(property.Description);

        sb.AppendLine("    /// <summary>");
        sb.AppendLine($"    /// {cleanDescription}");
        sb.AppendLine("    /// </summary>");

        if (property.MinCardinality > 0)
        {
            sb.AppendLine("    [Required]");
        }

        sb.AppendLine($"    [JsonPropertyName(\"{property.Name}\")]");
        sb.AppendLine($"    public {propertyType} {propertyName} {{ get; set; }}");
        sb.AppendLine();
    }
    
    /// <summary>
    /// 生成驗證方法
    /// </summary>
    private void GenerateValidationMethod(StringBuilder sb, object definition)
    {
        sb.AppendLine("    /// <summary>");
        sb.AppendLine("    /// Validates this instance according to FHIR rules");
        sb.AppendLine("    /// </summary>");
        sb.AppendLine("    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)");
        sb.AppendLine("    {");
        sb.AppendLine("        foreach (var result in base.Validate(validationContext))");
        sb.AppendLine("            yield return result;");
        sb.AppendLine();
        sb.AppendLine("        // TODO: Add specific validation rules");
        sb.AppendLine("    }");
        sb.AppendLine();
    }
    
    /// <summary>
    /// 檢查是否為基本屬性
    /// </summary>
    private bool IsBaseProperty(string propertyName)
    {
        var baseProperties = new HashSet<string>
        {
            "id", "meta", "implicitRules", "language", "text", "contained",
            "extension", "modifierExtension", "resourceType"
        };
        
        return baseProperties.Contains(propertyName);
    }
    
    /// <summary>
    /// 轉換為 PascalCase
    /// </summary>
    private string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;
            
        return char.ToUpper(input[0]) + input.Substring(1);
    }
    
    /// <summary>
    /// 清理檔案名稱
    /// </summary>
    private string SanitizeFileName(string fileName)
    {
        var invalidChars = Path.GetInvalidFileNameChars();
        return string.Join("_", fileName.Split(invalidChars, StringSplitOptions.RemoveEmptyEntries));
    }

    /// <summary>
    /// 清理描述文字
    /// </summary>
    private string CleanDescription(string description)
    {
        if (string.IsNullOrEmpty(description))
            return "No description available";

        // 移除 XML 特殊字元和格式問題
        return description
            .Replace("<", "&lt;")
            .Replace(">", "&gt;")
            .Replace("&", "&amp;")
            .Replace("\"", "&quot;")
            .Replace("'", "&apos;")
            .Replace("\r\n", " ")
            .Replace("\n", " ")
            .Replace("\r", " ")
            .Trim();
    }
}
