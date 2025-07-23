using Fhir.Support;
using Fhir.Support.Attributes;
using Fhir.Support.Interfaces;
using Fhir.Support.Serialization;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fhir.Serialization.Json;

/// <summary>
/// 提供將強型別 FHIR 物件序列化為 JSON 字串的功能。
/// </summary>
public class JsonSerializer : IFhirSerializer
{
    private readonly FhirContext _context;
    private readonly JsonSerializerOptions _options;

    /// <summary>
    /// 初始化 <see cref="JsonSerializer"/> 的新實例。
    /// </summary>
    /// <param name="context">要使用的 FHIR 上下文。</param>
    public JsonSerializer(FhirContext context)
    {
        _context = context;
        _options = CreateJsonOptions();
    }

    /// <inheritdoc/>
    public string SerializeToString<T>(T resource) where T : IResource
    {
        return System.Text.Json.JsonSerializer.Serialize(resource, _options);
    }

    /// <inheritdoc/>
    public byte[] SerializeToBytes<T>(T resource) where T : IResource
    {
        return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(resource, _options);
    }

    /// <inheritdoc/>
    public void SerializeToStream<T>(T resource, Stream stream) where T : IResource
    {
        System.Text.Json.JsonSerializer.Serialize(stream, resource, _options);
    }

    private JsonSerializerOptions CreateJsonOptions()
    {
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true,
            Converters =
            {
                new FhirResourceConverter(_context),
                new FhirPrimitiveConverter(),
                new FhirChoiceTypeConverter(),
                new FhirExtensionConverter()
            }
        };

        return options;
    }
}

/// <summary>
/// 處理 FHIR 資源的 JSON 轉換
/// </summary>
public class FhirResourceConverter : JsonConverter<IResource>
{
    private readonly FhirContext _context;

    public FhirResourceConverter(FhirContext context)
    {
        _context = context;
    }

    public override IResource? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;

        if (!root.TryGetProperty("resourceType", out var resourceTypeElement))
            throw new JsonException("Missing resourceType property");

        var resourceType = resourceTypeElement.GetString()!;
        var type = _context.ModelAssembly.GetType($"Fhir.{_context.Version}.Models.{resourceType}");

        if (type == null)
            throw new TypeLoadException($"Cannot find type '{resourceType}' in assembly '{_context.ModelAssembly.FullName}'");

        var resource = (IResource)Activator.CreateInstance(type)!;
        PopulateResource(root, resource, options);
        return resource;
    }

    public override void Write(Utf8JsonWriter writer, IResource value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        
        // 寫入 resourceType
        writer.WriteString("resourceType", value.GetType().Name);
        
        // 寫入所有屬性
        WriteProperties(writer, value, options);
        
        writer.WriteEndObject();
    }

    private void PopulateResource(JsonElement jsonElement, IResource resource, JsonSerializerOptions options)
    {
        var properties = resource.GetType().GetProperties()
            .Where(p => p.IsDefined(typeof(FhirElementAttribute), false))
            .OrderBy(p => p.GetCustomAttribute<FhirElementAttribute>()!.Order);

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<FhirElementAttribute>()!;
            
            if (jsonElement.TryGetProperty(attr.Name, out var jsonProperty))
            {
                var value = System.Text.Json.JsonSerializer.Deserialize(jsonProperty.GetRawText(), prop.PropertyType, options);
                prop.SetValue(resource, value);
            }
        }
    }

    private void WriteProperties(Utf8JsonWriter writer, IResource resource, JsonSerializerOptions options)
    {
        var properties = resource.GetType().GetProperties()
            .Where(p => p.IsDefined(typeof(FhirElementAttribute), false))
            .OrderBy(p => p.GetCustomAttribute<FhirElementAttribute>()!.Order);

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<FhirElementAttribute>()!;
            var value = prop.GetValue(resource);
            
            if (value != null)
            {
                writer.WritePropertyName(attr.Name);
                System.Text.Json.JsonSerializer.Serialize(writer, value, prop.PropertyType, options);
            }
        }
    }
}

/// <summary>
/// 處理 FHIR 基本型別的 JSON 轉換
/// </summary>
public class FhirPrimitiveConverter : JsonConverter<object>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return IsFhirPrimitive(typeToConvert);
    }

    public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var instance = Activator.CreateInstance(typeToConvert);
        var valueProp = typeToConvert.GetProperty("Value");
        
        if (valueProp != null)
        {
            var value = ReadPrimitiveValue(ref reader, valueProp.PropertyType);
            valueProp.SetValue(instance, value);
        }
        
        return instance;
    }

    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        var valueProp = value.GetType().GetProperty("Value");
        if (valueProp != null)
        {
            var primitiveValue = valueProp.GetValue(value);
            if (primitiveValue != null)
            {
                System.Text.Json.JsonSerializer.Serialize(writer, primitiveValue, primitiveValue.GetType(), options);
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }

    private bool IsFhirPrimitive(Type type)
    {
        return type.IsClass && 
               type.Namespace != null && 
               type.Namespace.Contains("Models") && 
               type.GetProperty("Value") != null;
    }

    private object? ReadPrimitiveValue(ref Utf8JsonReader reader, Type valueType)
    {
        return valueType.Name switch
        {
            "String" => reader.GetString(),
            "Boolean" => reader.GetBoolean(),
            "Int32" => reader.GetInt32(),
            "Decimal" => reader.GetDecimal(),
            "DateTimeOffset" => reader.GetDateTimeOffset(),
            _ => reader.GetString()
        };
    }
}

/// <summary>
/// 處理 FHIR Choice Types 的 JSON 轉換
/// </summary>
public class FhirChoiceTypeConverter : JsonConverter<object>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.GetCustomAttribute<ChoiceTypeAttribute>() != null;
    }

    public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Choice Type 的反序列化邏輯
        return System.Text.Json.JsonSerializer.Deserialize(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        // Choice Type 的序列化邏輯
        System.Text.Json.JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}

/// <summary>
/// 處理 FHIR Extensions 的 JSON 轉換
/// </summary>
public class FhirExtensionConverter : JsonConverter<object>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.Name == "Extension" || 
               (typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(List<>) &&
                typeToConvert.GetGenericArguments()[0].Name == "Extension");
    }

    public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Extension 的反序列化邏輯
        return System.Text.Json.JsonSerializer.Deserialize(ref reader, typeToConvert, options);
    }

    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        // Extension 的序列化邏輯
        System.Text.Json.JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
