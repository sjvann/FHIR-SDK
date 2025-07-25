using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.Converters;

/// <summary>
/// ChoiceType 的 JSON 轉換器
/// 處理 FHIR Choice Types 的序列化和反序列化
/// 
/// 注意：ChoiceType 的序列化由包含它的類別處理，
/// 因為需要輸出正確的 JSON 屬性名稱（如 valueString, valueInteger）
/// </summary>
public class ChoiceTypeConverter : JsonConverter<IChoiceType>
{
    public override IChoiceType? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // ChoiceType 的反序列化由包含它的類別處理
        // 因為需要知道具體的屬性名稱（如 valueString, valueInteger）
        // 這個方法主要用於型別註冊，實際反序列化在 Resource/DataType 層級處理
        
        if (reader.TokenType == JsonTokenType.Null)
            return null;
            
        // 跳過當前值，因為實際處理在父類別中
        reader.Skip();
        return null;
    }
    
    public override void Write(Utf8JsonWriter writer, IChoiceType value, JsonSerializerOptions options)
    {
        // ChoiceType 的序列化由包含它的類別處理
        // 因為需要輸出正確的屬性名稱（如 valueString, valueInteger）
        // 這個方法主要用於型別註冊，實際序列化在 Resource/DataType 層級處理
        
        if (value?.Value == null)
        {
            writer.WriteNullValue();
            return;
        }
        
        // 直接序列化內部值
        JsonSerializer.Serialize(writer, value.Value, value.Value.GetType(), options);
    }
    
    public override bool CanConvert(Type typeToConvert)
    {
        // 檢查是否為 ChoiceType 的泛型實作
        if (!typeToConvert.IsGenericType)
            return false;
            
        var genericTypeDef = typeToConvert.GetGenericTypeDefinition();
        
        return genericTypeDef == typeof(ChoiceType<>) ||
               genericTypeDef == typeof(ChoiceType<,>) ||
               genericTypeDef == typeof(ChoiceType<,,>) ||
               genericTypeDef == typeof(ChoiceType<,,,>);
    }
}

/// <summary>
/// 輔助類別，用於處理 ChoiceType 的 JSON 序列化
/// 提供統一的方法來處理不同 ChoiceType 的序列化需求
/// </summary>
public static class ChoiceTypeJsonHelper
{
    /// <summary>
    /// 從 JSON 屬性名稱中提取型別名稱
    /// </summary>
    /// <param name="propertyName">JSON 屬性名稱（如 "valueString"）</param>
    /// <param name="baseName">基礎名稱（如 "value"）</param>
    /// <returns>型別名稱（如 "String"）</returns>
    public static string? ExtractTypeNameFromProperty(string propertyName, string baseName)
    {
        if (!propertyName.StartsWith(baseName))
            return null;
            
        var typeName = propertyName.Substring(baseName.Length);
        return string.IsNullOrEmpty(typeName) ? null : typeName;
    }
    
    /// <summary>
    /// 生成 JSON 屬性名稱
    /// </summary>
    /// <param name="baseName">基礎名稱（如 "value"）</param>
    /// <param name="typeName">型別名稱（如 "String"）</param>
    /// <returns>JSON 屬性名稱（如 "valueString"）</returns>
    public static string GeneratePropertyName(string baseName, string typeName)
    {
        return baseName + char.ToUpperInvariant(typeName[0]) + typeName.Substring(1);
    }
    
    /// <summary>
    /// 將 FHIR 型別名稱轉換為 JSON 屬性中使用的格式
    /// </summary>
    /// <param name="fhirTypeName">FHIR 型別名稱</param>
    /// <returns>JSON 屬性格式的型別名稱</returns>
    public static string ConvertFhirTypeToJsonFormat(string fhirTypeName)
    {
        return fhirTypeName switch
        {
            // Primitive types - 首字母大寫
            "boolean" => "Boolean",
            "integer" => "Integer", 
            "string" => "String",
            "decimal" => "Decimal",
            "uri" => "Uri",
            "url" => "Url",
            "canonical" => "Canonical",
            "base64Binary" => "Base64Binary",
            "instant" => "Instant",
            "date" => "Date",
            "dateTime" => "DateTime",
            "time" => "Time",
            "code" => "Code",
            "oid" => "Oid",
            "id" => "Id",
            "markdown" => "Markdown",
            "unsignedInt" => "UnsignedInt",
            "positiveInt" => "PositiveInt",
            "uuid" => "Uuid",
            
            // Complex types - 保持原樣（已經是 PascalCase）
            _ => fhirTypeName
        };
    }
    
    /// <summary>
    /// 檢查屬性名稱是否為 Choice Type 屬性
    /// </summary>
    /// <param name="propertyName">屬性名稱</param>
    /// <param name="baseName">基礎名稱</param>
    /// <returns>是否為 Choice Type 屬性</returns>
    public static bool IsChoiceTypeProperty(string propertyName, string baseName)
    {
        return propertyName.StartsWith(baseName) && 
               propertyName.Length > baseName.Length &&
               char.IsUpper(propertyName[baseName.Length]);
    }
    
    /// <summary>
    /// 取得 Choice Type 的所有可能 JSON 屬性名稱
    /// </summary>
    /// <param name="baseName">基礎名稱（如 "value"）</param>
    /// <param name="allowedTypes">允許的型別列表</param>
    /// <returns>所有可能的 JSON 屬性名稱</returns>
    public static string[] GetAllChoiceTypePropertyNames(string baseName, string[] allowedTypes)
    {
        return allowedTypes
            .Select(type => GeneratePropertyName(baseName, ConvertFhirTypeToJsonFormat(type)))
            .ToArray();
    }
    
    /// <summary>
    /// 驗證 Choice Type 的值設定
    /// 確保只有一個值被設定
    /// </summary>
    /// <param name="choiceType">Choice Type 實例</param>
    /// <param name="propertyName">正在設定的屬性名稱</param>
    /// <param name="value">要設定的值</param>
    /// <returns>是否通過驗證</returns>
    public static bool ValidateChoiceTypeSetting(IChoiceType choiceType, string propertyName, object? value)
    {
        if (value == null)
            return true; // 清除值總是允許的
            
        if (choiceType.HasValue)
        {
            // 如果已經有值，檢查是否為相同的屬性
            var currentTypeName = choiceType.ValueTypeName;
            var newTypeName = ExtractTypeNameFromProperty(propertyName, "value"); // 假設基礎名稱為 "value"
            
            return string.Equals(currentTypeName, newTypeName?.ToLowerInvariant(), StringComparison.OrdinalIgnoreCase);
        }
        
        return true; // 沒有現有值時，設定任何允許的值都是可以的
    }
}
