using FhirResourceGenerator.Core;
using Microsoft.Extensions.Logging;

namespace FhirResourceGenerator.Parsers;

/// <summary>
/// FHIR 類型解析器
/// </summary>
/// <remarks>
/// 負責將 FHIR 類型映射到 C# 類型
/// </remarks>
public class FhirTypeResolver
{
    private readonly ILogger<FhirTypeResolver> _logger;
    private readonly Dictionary<string, TypeMapping> _typeMappings;

    public FhirTypeResolver(ILogger<FhirTypeResolver> logger)
    {
        _logger = logger;
        _typeMappings = InitializeTypeMappings();
    }

    /// <summary>
    /// 解析 C# 類型
    /// </summary>
    public async Task<string> ResolveCSharpTypeAsync(string fhirType, bool isArray = false)
    {
        await Task.CompletedTask; // 避免編譯器警告

        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            var csharpType = mapping.CSharpType;
            
            if (isArray)
            {
                csharpType = $"List<{csharpType}>";
            }
            
            if (mapping.IsNullable && !isArray)
            {
                csharpType += "?";
            }

            return csharpType;
        }

        _logger.LogWarning("未知的 FHIR 類型：{FhirType}", fhirType);
        
        // 預設處理
        var defaultType = isArray ? $"List<{fhirType}>" : fhirType;
        return defaultType;
    }

    /// <summary>
    /// 取得類型的命名空間
    /// </summary>
    public string GetTypeNamespace(string fhirType)
    {
        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            return mapping.Namespace;
        }

        return "System"; // 預設命名空間
    }

    /// <summary>
    /// 是否為原始類型
    /// </summary>
    public bool IsPrimitiveType(string fhirType)
    {
        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            return mapping.IsPrimitive;
        }

        return false;
    }

    /// <summary>
    /// 是否為複雜類型
    /// </summary>
    public bool IsComplexType(string fhirType)
    {
        if (_typeMappings.TryGetValue(fhirType, out var mapping))
        {
            return mapping.IsComplex;
        }

        return false;
    }

    /// <summary>
    /// 初始化類型映射
    /// </summary>
    private Dictionary<string, TypeMapping> InitializeTypeMappings()
    {
        return new Dictionary<string, TypeMapping>
        {
            // 原始類型
            ["string"] = new("FhirString", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["boolean"] = new("FhirBoolean", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["integer"] = new("FhirInteger", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["positiveInt"] = new("FhirPositiveInt", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["unsignedInt"] = new("FhirUnsignedInt", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["decimal"] = new("FhirDecimal", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["uri"] = new("FhirUri", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["url"] = new("FhirUrl", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["canonical"] = new("FhirCanonical", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["base64Binary"] = new("FhirBase64Binary", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["instant"] = new("FhirInstant", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["date"] = new("FhirDate", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["dateTime"] = new("FhirDateTime", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["time"] = new("FhirTime", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["code"] = new("FhirCode", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["oid"] = new("FhirOid", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["id"] = new("FhirId", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["markdown"] = new("FhirMarkdown", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["uuid"] = new("FhirUuid", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),
            ["xhtml"] = new("FhirXhtml", "DataTypeServices.DataTypes.PrimitiveTypes", true, true, false),

            // 複雜類型
            ["Address"] = new("Address", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Age"] = new("Age", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Annotation"] = new("Annotation", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Attachment"] = new("Attachment", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["CodeableConcept"] = new("CodeableConcept", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["CodeableReference"] = new("CodeableReference", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Coding"] = new("Coding", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["ContactPoint"] = new("ContactPoint", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Count"] = new("Count", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Distance"] = new("Distance", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Duration"] = new("Duration", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["HumanName"] = new("HumanName", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Identifier"] = new("Identifier", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Money"] = new("Money", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Period"] = new("Period", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Quantity"] = new("Quantity", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Range"] = new("Range", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Ratio"] = new("Ratio", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["RatioRange"] = new("RatioRange", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["SampledData"] = new("SampledData", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Signature"] = new("Signature", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),
            ["Timing"] = new("Timing", "DataTypeServices.DataTypes.ComplexTypes", true, false, true),

            // 特殊類型
            ["Reference"] = new("ReferenceType", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),
            ["Extension"] = new("Extension", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),
            ["Narrative"] = new("Narrative", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),
            ["Meta"] = new("Meta", "DataTypeServices.DataTypes.SpecialTypes", true, false, true),

            // 後設類型
            ["Element"] = new("Element", "DataTypeServices.DataTypes.MetaTypes", true, false, true),
            ["BackboneElement"] = new("BackboneElement", "DataTypeServices.DataTypes.MetaTypes", true, false, true),
            ["DomainResource"] = new("DomainResource", "FhirCore.Base", true, false, true),
            ["Resource"] = new("ResourceBase", "FhirCore.Base", true, false, true),

            // 選擇類型和未知類型的預設處理
            ["ChoiceType"] = new("ChoiceType", "DataTypeServices.DataTypes.ChoiceTypes", true, false, true),
            ["BackboneElement"] = new("BackboneElement", "DataTypeServices.DataTypes.MetaTypes", true, false, true)
        };
    }
}

/// <summary>
/// 類型映射資訊
/// </summary>
/// <remarks>
/// 包含 FHIR 類型到 C# 類型的映射資訊
/// </remarks>
public class TypeMapping
{
    /// <summary>
    /// C# 類型名稱
    /// </summary>
    public string CSharpType { get; }

    /// <summary>
    /// 命名空間
    /// </summary>
    public string Namespace { get; }

    /// <summary>
    /// 是否可為 null
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// 是否為原始類型
    /// </summary>
    public bool IsPrimitive { get; }

    /// <summary>
    /// 是否為複雜類型
    /// </summary>
    public bool IsComplex { get; }

    public TypeMapping(string csharpType, string @namespace, bool isNullable = true, 
        bool isPrimitive = false, bool isComplex = false)
    {
        CSharpType = csharpType;
        Namespace = @namespace;
        IsNullable = isNullable;
        IsPrimitive = isPrimitive;
        IsComplex = isComplex;
    }

    /// <summary>
    /// 取得完整類型名稱
    /// </summary>
    public string GetFullTypeName()
    {
        return $"{Namespace}.{CSharpType}";
    }

    /// <summary>
    /// 轉換為陣列類型
    /// </summary>
    public TypeMapping AsArray()
    {
        return new TypeMapping($"List<{CSharpType}>", "System.Collections.Generic", 
            IsNullable, false, IsComplex);
    }
}