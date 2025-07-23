using Fhir.Support.Versioning;
using Fhir.Support.Attributes;
using Fhir.Support.Interfaces;
using Fhir.Support.Serialization;
using System.Reflection;
using System.Text.Json;

namespace Fhir.Serialization.Json;

/// <summary>
/// 提供將 FHIR JSON 字串反序列化為強型別 FHIR 物件的功能。
/// </summary>
public class JsonParser : IFhirParser
{
    private readonly IFhirContext _context;

    /// <summary>
    /// 初始化 <see cref="JsonParser"/> 的新實例。
    /// </summary>
    /// <param name="context">要使用的 FHIR 上下文。</param>
    public JsonParser(IFhirContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    public T Parse<T>(string json) where T : IResource
    {
        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;
        
        var resourceType = root.GetProperty("resourceType").GetString()!;
        var type = _context.ModelAssembly.GetType($"Fhir.{_context.Version}.Models.{resourceType}");

        if (type == null)
        {
            throw new TypeLoadException($"在 '{_context.ModelAssembly.FullName}' 中找不到型別 '{resourceType}'。");
        }

        var resource = (T)Activator.CreateInstance(type)!;
        PopulateObject(root, resource);
        return resource;
    }

    private void PopulateObject(JsonElement jsonElement, object obj)
    {
        var properties = obj.GetType().GetProperties()
            .Where(p => p.IsDefined(typeof(FhirElementAttribute), false));

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<FhirElementAttribute>()!;
            
            // 正常屬性 (e.g., "birthDate")
            if (jsonElement.TryGetProperty(attr.Name, out var jsonProperty))
            {
                SetProperty(obj, prop, jsonProperty, attr.IsList);
            }

            // Primitive 的 Shadow 屬性 (e.g., "_birthDate" for extensions)
            if (IsFhirPrimitive(prop.PropertyType) || (attr.IsList && IsFhirPrimitive(prop.PropertyType.GetGenericArguments()[0])))
            {
                if (jsonElement.TryGetProperty("_" + attr.Name, out var shadowJsonProperty))
                {
                    // Get the actual property value that we may have already set
                    var existingValue = prop.GetValue(obj);
                    if (existingValue != null)
                    {
                        // The shadow property populates additional fields on the *existing* primitive object
                        PopulateObject(shadowJsonProperty, existingValue);
                    }
                    // If the main property didn't exist, we might need to create a new primitive
                    // and populate it from the shadow. This case is less common.
                }
            }
        }
    }

    private void SetProperty(object parentObject, PropertyInfo prop, JsonElement jsonProperty, bool isList)
    {
        if (isList)
        {
            var itemType = prop.PropertyType.GetGenericArguments()[0];
            var listType = typeof(List<>).MakeGenericType(itemType);
            var list = (System.Collections.IList)Activator.CreateInstance(listType)!;

            foreach (var item in jsonProperty.EnumerateArray())
            {
                var listItem = CreateAndPopulate(item, itemType);
                if (listItem != null)
                {
                    list.Add(listItem);
                }
            }
            prop.SetValue(parentObject, list);
        }
        else
        {
            var value = CreateAndPopulate(jsonProperty, prop.PropertyType);
            if (value != null)
            {
                prop.SetValue(parentObject, value);
            }
        }
    }
    
    private bool IsFhirPrimitive(Type type)
    {
        // A simple way to identify FHIR primitives. They are classes, not C# primitives,
        // and have a "Value" property.
        return type.IsClass && type.Namespace != null && type.Namespace.Contains("Models") && type.GetProperty("Value") != null;
    }

    private object? CreateAndPopulate(JsonElement jsonElement, Type targetType)
    {
        // Check if the target is a FHIR primitive like FhirString, FhirBoolean, etc.
        if (IsFhirPrimitive(targetType))
        {
            var instance = Activator.CreateInstance(targetType);
            var valueProp = targetType.GetProperty("Value");
            if (valueProp != null)
            {
                var primitiveValue = ConvertJsonPrimitive(jsonElement, valueProp.PropertyType);
                valueProp.SetValue(instance, primitiveValue);
            }
            return instance;
        }

        if (jsonElement.ValueKind == JsonValueKind.Object)
        {
            // Handle Complex Types (which are not primitives)
            var instance = Activator.CreateInstance(targetType);
            if (instance != null)
            {
                PopulateObject(jsonElement, instance);
            }
            return instance;
        }

        // This case would be for C# primitives if they were directly used, which they are not in our model.
        // It can be a fallback or for extensions.
        return ConvertJsonPrimitive(jsonElement, targetType);
    }

    private object? ConvertJsonPrimitive(JsonElement jsonElement, Type targetType)
    {
        return targetType.Name switch
        {
            "String" => jsonElement.GetString(),
            "Boolean" => jsonElement.GetBoolean(),
            "Int32" => jsonElement.GetInt32(),
            "Decimal" => jsonElement.GetDecimal(),
            "DateTimeOffset" => jsonElement.GetDateTimeOffset(),
            // 其他 Primitive Type 轉換...
            _ => jsonElement.ToString() // 作為備用
        };
    }
} 