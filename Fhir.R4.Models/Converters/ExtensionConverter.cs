using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.Models.Base;

namespace Fhir.R4.Models.Converters;

/// <summary>
/// Extension 的 JSON 轉換器
/// 處理 Extension 的序列化和反序列化，特別是 value[x] 的處理
/// </summary>
public class ExtensionConverter : JsonConverter<Extension>
{
    public override Extension? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
            return null;
            
        if (reader.TokenType != JsonTokenType.StartObject)
            throw new JsonException("Expected StartObject token");
            
        var extension = new Extension();
        
        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                break;
                
            if (reader.TokenType != JsonTokenType.PropertyName)
                continue;
                
            var propertyName = reader.GetString();
            reader.Read();
            
            switch (propertyName)
            {
                case "url":
                    extension.Url = reader.GetString() ?? string.Empty;
                    break;
                    
                case "valueString":
                    extension.ValueString = reader.GetString();
                    break;
                    
                case "valueInteger":
                    extension.ValueInteger = reader.GetInt32();
                    break;
                    
                case "valueBoolean":
                    extension.ValueBoolean = reader.GetBoolean();
                    break;
                    
                case "valueDecimal":
                    extension.ValueDecimal = reader.GetDecimal();
                    break;
                    
                case "extension":
                    extension.SubExtensions = JsonSerializer.Deserialize<List<Extension>>(ref reader, options);
                    break;
                    
                default:
                    // 跳過未知屬性
                    reader.Skip();
                    break;
            }
        }
        
        return extension;
    }
    
    public override void Write(Utf8JsonWriter writer, Extension value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        // url 是必要的
        writer.WriteString("url", value.Url);
        
        // 寫入 value[x] - 只寫入有值的屬性
        if (value.ValueString != null)
        {
            writer.WriteString("valueString", value.ValueString);
        }
        else if (value.ValueInteger != null)
        {
            writer.WriteNumber("valueInteger", value.ValueInteger.Value);
        }
        else if (value.ValueBoolean != null)
        {
            writer.WriteBoolean("valueBoolean", value.ValueBoolean.Value);
        }
        else if (value.ValueDecimal != null)
        {
            writer.WriteNumber("valueDecimal", value.ValueDecimal.Value);
        }
        // 其他複雜型別的序列化會在完整實作中添加
        
        // 寫入子 extensions
        if (value.SubExtensions != null && value.SubExtensions.Any())
        {
            writer.WritePropertyName("extension");
            JsonSerializer.Serialize(writer, value.SubExtensions, options);
        }
        
        writer.WriteEndObject();
    }
}
