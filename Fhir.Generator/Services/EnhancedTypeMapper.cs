using Fhir.Generator.Models;

namespace Fhir.Generator.Services;

public class EnhancedTypeMapper
{
    // FHIR 基礎型別統一對應到 Fhir 前綴的類別（用於所有引用）
    private readonly Dictionary<string, string> _primitiveTypeMap = new()
    {
        ["boolean"] = "FhirBoolean",
        ["integer"] = "FhirInteger",
        ["integer64"] = "FhirInteger64",
        ["decimal"] = "FhirDecimal",
        ["base64Binary"] = "FhirBase64Binary",
        ["instant"] = "FhirInstant",
        ["string"] = "FhirString",
        ["uri"] = "FhirUri",
        ["url"] = "FhirUrl",
        ["canonical"] = "FhirCanonical",
        ["oid"] = "FhirOid",
        ["uuid"] = "FhirUuid",
        ["date"] = "FhirDate",
        ["dateTime"] = "FhirDateTime",
        ["time"] = "FhirTime",
        ["code"] = "FhirCode",
        ["id"] = "FhirId",
        ["markdown"] = "FhirMarkdown",
        ["unsignedInt"] = "FhirUnsignedInt",
        ["positiveInt"] = "FhirPositiveInt",
        ["xhtml"] = "FhirXhtml"
    };

    // FHIR 基礎型別對應到 C# 原生型別（用於轉換方法）
    private readonly Dictionary<string, string> _primitiveToNativeTypeMap = new()
    {
        ["boolean"] = "bool?",
        ["integer"] = "int?",
        ["integer64"] = "long?",
        ["decimal"] = "decimal?",
        ["base64Binary"] = "byte[]",
        ["instant"] = "DateTimeOffset?",
        ["string"] = "string",
        ["uri"] = "string",
        ["url"] = "string",
        ["canonical"] = "string",
        ["oid"] = "string",
        ["uuid"] = "string",
        ["date"] = "DateTime?",
        ["dateTime"] = "DateTime?",
        ["time"] = "TimeSpan?",
        ["code"] = "string",
        ["id"] = "string",
        ["markdown"] = "string",
        ["unsignedInt"] = "uint?",
        ["positiveInt"] = "uint?",
        ["xhtml"] = "string"
    };
    
    private readonly Dictionary<string, string> _complexTypeMap = new()
    {
        // 常用複雜型別
        ["Reference"] = "Reference",
        ["CodeableConcept"] = "CodeableConcept",
        ["Coding"] = "Coding",
        ["Identifier"] = "Identifier",
        ["HumanName"] = "HumanName",
        ["Address"] = "Address",
        ["ContactPoint"] = "ContactPoint",
        ["Quantity"] = "Quantity",
        ["Period"] = "Period",
        ["Range"] = "Range",
        ["Ratio"] = "Ratio",
        ["Attachment"] = "Attachment",
        ["Narrative"] = "Narrative",
        ["Extension"] = "Extension",
        ["Meta"] = "Meta",
        ["BackboneElement"] = "BackboneElement"
    };

    // 抽象型別映射 - 需要具體實例時使用 Impl 類別
    private readonly Dictionary<string, string> _abstractTypeToImplMap = new()
    {
        ["Quantity"] = "QuantityImpl",
        ["Reference"] = "ReferenceImpl"
        // 根據需要添加其他抽象型別
    };
    
    public string MapFhirTypeToCSharp(string fhirType, bool isArray = false, List<string>? targetProfiles = null)
    {
        // 清理型別名稱，移除 URL 前綴
        var cleanType = CleanTypeName(fhirType);

        string baseType;

        // 處理 Reference 型別
        if (cleanType == "Reference")
        {
            // FHIR Reference 設計：
            // 1. 單一資源類型：可以考慮使用泛型 Reference<T>（未來功能）
            // 2. 多資源類型：必須使用基礎 Reference，執行時透過 type 欄位判斷
            // 3. 無限制：使用基礎 Reference
            baseType = "Reference";
        }
        // 處理 FHIR 基礎型別
        else if (_primitiveTypeMap.ContainsKey(cleanType))
        {
            baseType = _primitiveTypeMap[cleanType];
        }
        // 處理複雜型別
        else if (_complexTypeMap.ContainsKey(cleanType))
        {
            baseType = _complexTypeMap[cleanType];
        }
        // 處理抽象型別
        else if (_abstractTypeToImplMap.ContainsKey(cleanType))
        {
            baseType = _abstractTypeToImplMap[cleanType];
        }
        // 預設處理
        else
        {
            // 嘗試從 targetProfiles 推斷資源類型
            if (targetProfiles != null && targetProfiles.Any())
            {
                var resourceType = ExtractResourceTypeFromProfile(targetProfiles.First());
                if (!string.IsNullOrEmpty(resourceType))
                {
                    baseType = resourceType;
                }
                else
                {
                    baseType = ToPascalCase(cleanType);
                }
            }
            else
            {
                baseType = ToPascalCase(cleanType);
            }
        }

        return baseType;
    }

    /// <summary>
    /// 根據 FHIR 基數將型別對應到 C# 型別
    /// </summary>
    /// <param name="fhirType">FHIR 型別名稱</param>
    /// <param name="minCardinality">最小基數</param>
    /// <param name="maxCardinality">最大基數 ("*" 表示無限制)</param>
    /// <param name="targetProfiles">目標設定檔（用於 Reference 型別）</param>
    /// <returns>對應的 C# 型別</returns>
    public string MapFhirTypeToCSharpWithCardinality(string fhirType, int minCardinality, string maxCardinality, List<string>? targetProfiles = null)
    {
        // 清理型別名稱，移除 URL 前綴
        var cleanType = CleanTypeName(fhirType);

        string baseType;

        // 處理 Reference 型別
        if (cleanType == "Reference")
        {
            // 統一使用基礎 Reference 類型，支援所有 FHIR Reference 情境
            baseType = "Reference";
        }
        // 基本型別
        else if (_primitiveTypeMap.TryGetValue(cleanType, out var primitiveType))
        {
            baseType = primitiveType;
        }
        // 複雜型別
        else if (_complexTypeMap.TryGetValue(cleanType, out var complexType))
        {
            baseType = complexType;
        }
        // 資源型別或未知型別
        else
        {
            baseType = ToPascalCase(cleanType);
        }

        // 根據基數決定最終型別
        return ApplyCardinalityToType(baseType, minCardinality, maxCardinality);
    }

    /// <summary>
    /// 根據基數將基礎型別轉換為適當的 C# 型別
    /// </summary>
    /// <param name="baseType">基礎型別</param>
    /// <param name="minCardinality">最小基數</param>
    /// <param name="maxCardinality">最大基數</param>
    /// <returns>應用基數後的 C# 型別</returns>
    private string ApplyCardinalityToType(string baseType, int minCardinality, string maxCardinality)
    {
        // 判斷是否為陣列型別
        bool isArray = maxCardinality == "*" || (int.TryParse(maxCardinality, out var max) && max > 1);

        // 判斷是否為必要欄位
        bool isRequired = minCardinality > 0;

        if (isArray)
        {
            // [0..*] → List<Type>? (可為 null 的列表)
            // [1..*] → List<Type> (必要的列表)
            return isRequired ? $"List<{baseType}>" : $"List<{baseType}>?";
        }
        else
        {
            // [0..1] → Type? (可為 null 的單一值)
            // [1..1] → Type (必要的單一值)

            // 檢查是否為值型別，如果是則需要加 ?
            if (!isRequired && IsValueType(baseType))
            {
                return $"{baseType}?";
            }
            else if (!isRequired && !IsValueType(baseType))
            {
                // 參考型別本身就可以為 null，不需要額外的 ?
                return baseType;
            }
            else
            {
                // 必要欄位
                return baseType;
            }
        }
    }

    /// <summary>
    /// 判斷型別是否為值型別
    /// </summary>
    /// <param name="typeName">型別名稱</param>
    /// <returns>是否為值型別</returns>
    private bool IsValueType(string typeName)
    {
        // FHIR 型別都是參考型別，不是值型別
        if (typeName.StartsWith("Fhir") || _primitiveTypeMap.ContainsValue(typeName))
        {
            return false; // FHIR 型別都是參考型別
        }
        
        // 真正的 C# 值型別
        return typeName == "int" || typeName == "bool" || typeName == "decimal" ||
               typeName == "DateTime" || typeName == "TimeSpan" ||
               typeName == "uint" || typeName == "long" || typeName == "ulong" ||
               typeName == "float" || typeName == "double" || typeName == "char" ||
               typeName == "byte" || typeName == "sbyte" || typeName == "short" || typeName == "ushort";
    }

    /// <summary>
    /// 清理型別名稱，移除 URL 前綴和無效字符
    /// </summary>
    /// <param name="typeName">原始型別名稱</param>
    /// <returns>清理後的型別名稱</returns>
    private string CleanTypeName(string typeName)
    {
        if (string.IsNullOrEmpty(typeName))
            return typeName;

        // 處理 URL 格式的型別名稱，如 "http://hl7.org/fhirpath/System.String"
        if (typeName.Contains("://"))
        {
            // 提取最後一個部分
            var parts = typeName.Split('/', '.');
            var lastPart = parts.LastOrDefault();

            // 移除 "System." 前綴
            if (lastPart?.StartsWith("System.") == true)
            {
                lastPart = lastPart[7..]; // 移除 "System."
            }

            // 將 FHIRPath 型別對應到 FHIR 型別
            return MapFhirPathTypeToFhirType(lastPart ?? typeName);
        }

        // 移除其他無效字符
        return typeName.Replace(":", "").Replace("/", "").Replace(".", "");
    }

    /// <summary>
    /// 將 FHIRPath 型別對應到 FHIR 型別
    /// </summary>
    /// <param name="fhirPathType">FHIRPath 型別名稱</param>
    /// <returns>對應的 FHIR 型別名稱</returns>
    private string MapFhirPathTypeToFhirType(string fhirPathType)
    {
        return fhirPathType switch
        {
            "String" => "string",
            "Boolean" => "boolean",
            "Integer" => "integer",
            "Decimal" => "decimal",
            "Date" => "date",
            "DateTime" => "dateTime",
            "Time" => "time",
            _ => fhirPathType.ToLower() // 預設轉為小寫
        };
    }
    
    private string ExtractResourceTypeFromProfile(string profile)
    {
        // 從 profile URL 中提取資源型別
        // 例如: http://hl7.org/fhir/StructureDefinition/Patient -> Patient
        var parts = profile.Split('/');
        return parts.LastOrDefault() ?? "Resource";
    }
    
    /// <summary>
    /// 取得 FHIR 基礎型別對應的 C# 原生型別（用於轉換方法）
    /// </summary>
    public string GetNativeType(string fhirType)
    {
        return _primitiveToNativeTypeMap.TryGetValue(fhirType, out var nativeType)
            ? nativeType
            : "object";
    }

    /// <summary>
    /// 檢查是否為 FHIR 基礎型別
    /// </summary>
    public bool IsPrimitiveType(string fhirType)
    {
        return _primitiveTypeMap.ContainsKey(fhirType);
    }

    public TypeKind DetermineTypeKind(string fhirType, string? kind = null)
    {
        if (_primitiveTypeMap.ContainsKey(fhirType))
            return TypeKind.PrimitiveType;

        return kind switch
        {
            "resource" => TypeKind.Resource,
            "complex-type" => TypeKind.ComplexType,
            "primitive-type" => TypeKind.PrimitiveType,
            _ => TypeKind.ComplexType
        };
    }

    private static string ToPascalCase(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        return char.ToUpper(input[0]) + input[1..];
    }
}
