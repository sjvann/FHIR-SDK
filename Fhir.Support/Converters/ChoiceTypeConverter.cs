using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;

namespace Fhir.Support.Converters;

/// <summary>
/// JSON 轉換器，用於處理 FHIR Choice Types 的序列化和反序列化
/// </summary>
public class ChoiceTypeConverter<T1, T2> : JsonConverter<OneOf<T1, T2>>
{
    private readonly string _baseName;
    private readonly Dictionary<Type, string> _typeToSuffix;
    private readonly Dictionary<string, Type> _suffixToType;

    public ChoiceTypeConverter(string baseName, Dictionary<Type, string> typeMapping)
    {
        _baseName = baseName;
        _typeToSuffix = typeMapping;
        _suffixToType = typeMapping.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
    }

    public override OneOf<T1, T2> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        // 尋找匹配的屬性
        foreach (var property in root.EnumerateObject())
        {
            if (property.Name.StartsWith(_baseName))
            {
                var suffix = property.Name.Substring(_baseName.Length);
                if (_suffixToType.TryGetValue(suffix, out var targetType))
                {
                    var value = JsonSerializer.Deserialize(property.Value.GetRawText(), targetType, options);
                    
                    if (targetType == typeof(T1))
                        return OneOf<T1, T2>.FromT0((T1)value!);
                    if (targetType == typeof(T2))
                        return OneOf<T1, T2>.FromT1((T2)value!);
                }
            }
        }

        throw new JsonException($"No valid choice type found for {_baseName}[x]");
    }

    public override void Write(Utf8JsonWriter writer, OneOf<T1, T2> value, JsonSerializerOptions options)
    {
        value.Switch(
            t1 => WriteValue(writer, t1, typeof(T1), options),
            t2 => WriteValue(writer, t2, typeof(T2), options)
        );
    }

    private void WriteValue(Utf8JsonWriter writer, object value, Type type, JsonSerializerOptions options)
    {
        if (_typeToSuffix.TryGetValue(type, out var suffix))
        {
            var propertyName = _baseName + suffix;
            writer.WritePropertyName(propertyName);
            JsonSerializer.Serialize(writer, value, type, options);
        }
    }
}

/// <summary>
/// 三個型別的 Choice Type 轉換器
/// </summary>
public class ChoiceTypeConverter<T1, T2, T3> : JsonConverter<OneOf<T1, T2, T3>>
{
    private readonly string _baseName;
    private readonly Dictionary<Type, string> _typeToSuffix;
    private readonly Dictionary<string, Type> _suffixToType;

    public ChoiceTypeConverter(string baseName, Dictionary<Type, string> typeMapping)
    {
        _baseName = baseName;
        _typeToSuffix = typeMapping;
        _suffixToType = typeMapping.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
    }

    public override OneOf<T1, T2, T3> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        foreach (var property in root.EnumerateObject())
        {
            if (property.Name.StartsWith(_baseName))
            {
                var suffix = property.Name.Substring(_baseName.Length);
                if (_suffixToType.TryGetValue(suffix, out var targetType))
                {
                    var value = JsonSerializer.Deserialize(property.Value.GetRawText(), targetType, options);
                    
                    if (targetType == typeof(T1))
                        return OneOf<T1, T2, T3>.FromT0((T1)value!);
                    if (targetType == typeof(T2))
                        return OneOf<T1, T2, T3>.FromT1((T2)value!);
                    if (targetType == typeof(T3))
                        return OneOf<T1, T2, T3>.FromT2((T3)value!);
                }
            }
        }

        throw new JsonException($"No valid choice type found for {_baseName}[x]");
    }

    public override void Write(Utf8JsonWriter writer, OneOf<T1, T2, T3> value, JsonSerializerOptions options)
    {
        value.Switch(
            t1 => WriteValue(writer, t1, typeof(T1), options),
            t2 => WriteValue(writer, t2, typeof(T2), options),
            t3 => WriteValue(writer, t3, typeof(T3), options)
        );
    }

    private void WriteValue(Utf8JsonWriter writer, object value, Type type, JsonSerializerOptions options)
    {
        if (_typeToSuffix.TryGetValue(type, out var suffix))
        {
            var propertyName = _baseName + suffix;
            writer.WritePropertyName(propertyName);
            JsonSerializer.Serialize(writer, value, type, options);
        }
    }
}
