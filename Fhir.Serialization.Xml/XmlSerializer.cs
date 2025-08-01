using Fhir.Support.Versioning;
using Fhir.Support.Attributes;
using Fhir.Support.Interfaces;
using Fhir.Support.Serialization;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace Fhir.Serialization.Xml;

/// <summary>
/// A FHIR serializer for converting strongly-typed FHIR objects into their XML string representation.
/// This serializer is version-aware and relies on the provided <see cref="IFhirContext"/> to function,
/// though serialization logic is generally consistent across FHIR versions.
/// </summary>
public class XmlSerializer : IFhirSerializer
{
    private readonly IFhirContext _context;
    private const string FhirNamespace = "http://hl7.org/fhir";

    /// <summary>
    /// 初始化 <see cref="XmlSerializer"/> 的新實例。
    /// </summary>
    /// <param name="context">要使用的 FHIR 上下文。</param>
    public XmlSerializer(IFhirContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    /// <typeparam name="T">The type of the FHIR resource.</typeparam>
    /// <param name="resource">The resource instance to serialize.</param>
    /// <returns>An XML string representing the FHIR resource.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the resource is null.</exception>
    public string SerializeToString<T>(T resource) where T : IResource
    {
        if (resource == null)
            throw new ArgumentNullException(nameof(resource));

        var doc = SerializeToXDocument(resource);
        return doc.ToString();
    }

    /// <inheritdoc/>
    /// <typeparam name="T">The type of the FHIR resource.</typeparam>
    /// <param name="resource">The resource instance to serialize.</param>
    /// <returns>An XML string representing the FHIR resource.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the resource is null.</exception>
    public byte[] SerializeToBytes<T>(T resource) where T : IResource
    {
        if (resource == null)
            throw new ArgumentNullException(nameof(resource));

        var xmlString = SerializeToString(resource);
        return System.Text.Encoding.UTF8.GetBytes(xmlString);
    }

    /// <inheritdoc/>
    /// <typeparam name="T">The type of the FHIR resource.</typeparam>
    /// <param name="resource">The resource instance to serialize.</param>
    /// <param name="stream">The stream to write the serialized XML to.</param>
    /// <exception cref="ArgumentNullException">Thrown if the resource or stream is null.</exception>
    public void SerializeToStream<T>(T resource, Stream stream) where T : IResource
    {
        if (resource == null)
            throw new ArgumentNullException(nameof(resource));
        if (stream == null)
            throw new ArgumentNullException(nameof(stream));

        var doc = SerializeToXDocument(resource);
        doc.Save(stream);
    }

    private XDocument SerializeToXDocument<T>(T resource) where T : IResource
    {
        var resourceType = resource.GetType().Name;
        var rootElement = new XElement(XName.Get(resourceType, FhirNamespace));
        
        // 添加 xmlns 屬性
        rootElement.Add(new XAttribute("xmlns", FhirNamespace));
        
        // 序列化所有屬性
        SerializeProperties(rootElement, resource);
        
        return new XDocument(
            new XDeclaration("1.0", "UTF-8", null),
            rootElement
        );
    }

    private void SerializeProperties(XElement parentElement, object obj)
    {
        var properties = obj.GetType().GetProperties()
            .Where(p => p.IsDefined(typeof(FhirElementAttribute), false))
            .OrderBy(p => p.GetCustomAttribute<FhirElementAttribute>()!.Order);

        foreach (var prop in properties)
        {
            var attr = prop.GetCustomAttribute<FhirElementAttribute>()!;
            var value = prop.GetValue(obj);
            
            if (value == null) continue;

            if (IsListProperty(prop))
            {
                SerializeListProperty(parentElement, attr.Name, value);
            }
            else
            {
                SerializeProperty(parentElement, attr.Name, value);
            }
        }
    }

    private void SerializeProperty(XElement parentElement, string elementName, object value)
    {
        var element = new XElement(XName.Get(elementName, FhirNamespace));
        
        if (IsFhirPrimitive(value.GetType()))
        {
            SerializePrimitive(element, value);
        }
        else if (IsComplexType(value.GetType()))
        {
            SerializeProperties(element, value);
        }
        else
        {
            // 處理其他型別
            element.Add(new XAttribute("value", value.ToString() ?? string.Empty));
        }
        
        parentElement.Add(element);
    }

    private void SerializeListProperty(XElement parentElement, string elementName, object listValue)
    {
        if (listValue is System.Collections.IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                if (item != null)
                {
                    SerializeProperty(parentElement, elementName, item);
                }
            }
        }
    }

    private void SerializePrimitive(XElement element, object primitive)
    {
        var valueProp = primitive.GetType().GetProperty("Value");
        if (valueProp != null)
        {
            var value = valueProp.GetValue(primitive);
            if (value != null)
            {
                element.Add(new XAttribute("value", FormatPrimitiveValue(value)));
            }
        }
        
        // 處理 Extensions
        var extensionProp = primitive.GetType().GetProperty("Extension");
        if (extensionProp != null)
        {
            var extensions = extensionProp.GetValue(primitive);
            if (extensions != null)
            {
                SerializeListProperty(element, "extension", extensions);
            }
        }
    }

    private string FormatPrimitiveValue(object value)
    {
        return value switch
        {
            DateTime dt => dt.ToString("yyyy-MM-dd"),
            DateTimeOffset dto => dto.ToString("yyyy-MM-ddTHH:mm:ss.fffK"),
            bool b => b.ToString().ToLower(),
            decimal d => d.ToString("G"),
            _ => value.ToString() ?? string.Empty
        };
    }

    private bool IsFhirPrimitive(Type type)
    {
        return type.IsClass && 
               type.Namespace != null && 
               type.Namespace.Contains("Models") && 
               type.GetProperty("Value") != null;
    }

    private bool IsComplexType(Type type)
    {
        return type.IsClass && 
               type.Namespace != null && 
               type.Namespace.Contains("Models") && 
               !IsFhirPrimitive(type);
    }

    private bool IsListProperty(PropertyInfo prop)
    {
        return prop.PropertyType.IsGenericType && 
               prop.PropertyType.GetGenericTypeDefinition() == typeof(List<>);
    }
}

/// <summary>
/// A FHIR parser for deserializing XML content into strongly-typed FHIR objects.
/// This parser is version-aware and relies on an <see cref="IFhirContext"/>
/// to determine which version-specific models to use for deserialization.
/// </summary>
public class XmlParser : IFhirParser
{
    private readonly IFhirContext _context;
    private const string FhirNamespace = "http://hl7.org/fhir";

    /// <summary>
    /// 初始化 <see cref="XmlParser"/> 的新實例。
    /// </summary>
    /// <param name="context">要使用的 FHIR 上下文。</param>
    public XmlParser(IFhirContext context)
    {
        _context = context;
    }

    /// <inheritdoc/>
    /// <typeparam name="T">The expected base type of the resource (e.g., Resource, Patient, etc.).</typeparam>
    /// <param name="xml">The XML string representing the FHIR resource.</param>
    /// <returns>A strongly-typed object representing the parsed FHIR resource.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the input XML string is null or empty.</exception>
    /// <exception cref="System.Xml.XmlException">Thrown if the input string is not valid XML.</exception>
    /// <exception cref="TypeLoadException">Thrown if the resource type specified in the XML root element cannot be found in the model assembly provided by the <see cref="IFhirContext"/>.</exception>
    /// <exception cref="InvalidCastException">Thrown if the parsed resource cannot be cast to the specified type <typeparamref name="T"/>.</exception>
    public T Parse<T>(string xml) where T : IResource
    {
        if (string.IsNullOrEmpty(xml))
            throw new ArgumentNullException(nameof(xml));

        var doc = XDocument.Parse(xml);
        var root = doc.Root!;
        
        var resourceType = root.Name.LocalName;
        var type = _context.ModelAssembly.GetType($"Fhir.{_context.Version}.Models.{resourceType}");

        if (type == null)
        {
            throw new TypeLoadException($"Cannot find type '{resourceType}' in assembly '{_context.ModelAssembly.FullName}'");
        }

        var resource = (T)Activator.CreateInstance(type)!;
        PopulateObject(root, resource);
        return resource;
    }

    private void PopulateObject(XElement element, object obj)
    {
        var properties = obj.GetType().GetProperties()
            .Where(p => p.IsDefined(typeof(FhirElementAttribute), false))
            .ToDictionary(p => p.GetCustomAttribute<FhirElementAttribute>()!.Name, p => p);

        foreach (var childElement in element.Elements())
        {
            var elementName = childElement.Name.LocalName;
            
            if (properties.TryGetValue(elementName, out var prop))
            {
                if (IsListProperty(prop))
                {
                    PopulateListProperty(element, prop, obj, elementName);
                }
                else
                {
                    var value = CreateAndPopulate(childElement, prop.PropertyType);
                    prop.SetValue(obj, value);
                }
            }
        }
    }

    private void PopulateListProperty(XElement parentElement, PropertyInfo prop, object obj, string elementName)
    {
        var itemType = prop.PropertyType.GetGenericArguments()[0];
        var listType = typeof(List<>).MakeGenericType(itemType);
        var list = (System.Collections.IList)Activator.CreateInstance(listType)!;

        foreach (var element in parentElement.Elements().Where(e => e.Name.LocalName == elementName))
        {
            var item = CreateAndPopulate(element, itemType);
            if (item != null)
            {
                list.Add(item);
            }
        }

        prop.SetValue(obj, list);
    }

    private object? CreateAndPopulate(XElement element, Type targetType)
    {
        if (IsFhirPrimitive(targetType))
        {
            return CreatePrimitive(element, targetType);
        }
        else if (IsComplexType(targetType))
        {
            var instance = Activator.CreateInstance(targetType);
            if (instance != null)
            {
                PopulateObject(element, instance);
            }
            return instance;
        }

        return null;
    }

    private object? CreatePrimitive(XElement element, Type primitiveType)
    {
        var instance = Activator.CreateInstance(primitiveType);
        var valueProp = primitiveType.GetProperty("Value");
        
        if (valueProp != null && element.Attribute("value") != null)
        {
            var valueString = element.Attribute("value")!.Value;
            var convertedValue = ConvertPrimitiveValue(valueString, valueProp.PropertyType);
            valueProp.SetValue(instance, convertedValue);
        }

        return instance;
    }

    private object? ConvertPrimitiveValue(string value, Type targetType)
    {
        return targetType.Name switch
        {
            "String" => value,
            "Boolean" => bool.Parse(value),
            "Int32" => int.Parse(value),
            "Decimal" => decimal.Parse(value),
            "DateTime" => DateTime.Parse(value),
            "DateTimeOffset" => DateTimeOffset.Parse(value),
            _ => value
        };
    }

    private bool IsFhirPrimitive(Type type)
    {
        return type.IsClass && 
               type.Namespace != null && 
               type.Namespace.Contains("Models") && 
               type.GetProperty("Value") != null;
    }

    private bool IsComplexType(Type type)
    {
        return type.IsClass && 
               type.Namespace != null && 
               type.Namespace.Contains("Models") && 
               !IsFhirPrimitive(type);
    }

    private bool IsListProperty(PropertyInfo prop)
    {
        return prop.PropertyType.IsGenericType && 
               prop.PropertyType.GetGenericTypeDefinition() == typeof(List<>);
    }
}
