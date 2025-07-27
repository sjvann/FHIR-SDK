using System.Xml;
using System.Xml.Linq;
using Fhir.TypeFramework.Abstractions;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Serialization;

/// <summary>
/// FHIR XML 序列化器
/// 支援 FHIR R5 的 XML 序列化格式
/// </summary>
public class FhirXmlSerializer
{
    private readonly XmlSerializerOptions _options;

    /// <summary>
    /// XML 序列化選項
    /// </summary>
    public class XmlSerializerOptions
    {
        /// <summary>
        /// 是否格式化輸出
        /// </summary>
        public bool FormatOutput { get; set; } = true;
        
        /// <summary>
        /// 是否包含命名空間
        /// </summary>
        public bool IncludeNamespaces { get; set; } = true;
        
        /// <summary>
        /// 預設命名空間
        /// </summary>
        public string DefaultNamespace { get; set; } = "http://hl7.org/fhir";
        
        /// <summary>
        /// 編碼
        /// </summary>
        public string Encoding { get; set; } = "UTF-8";
    }

    /// <summary>
    /// 初始化 FhirXmlSerializer
    /// </summary>
    public FhirXmlSerializer()
    {
        _options = new XmlSerializerOptions();
    }

    /// <summary>
    /// 使用自訂選項初始化 FhirXmlSerializer
    /// </summary>
    /// <param name="options">XML 序列化選項</param>
    public FhirXmlSerializer(XmlSerializerOptions options)
    {
        _options = options;
    }

    /// <summary>
    /// 序列化為 XML
    /// </summary>
    /// <typeparam name="T">要序列化的型別</typeparam>
    /// <param name="value">要序列化的值</param>
    /// <returns>XML 字串</returns>
    public string Serialize<T>(T value) where T : ITypeFramework
    {
        if (value == null)
            return "";

        var rootElement = CreateXmlElement(value);
        var document = new XDocument(rootElement);
        
        var settings = new XmlWriterSettings
        {
            Encoding = System.Text.Encoding.GetEncoding(_options.Encoding),
            Indent = _options.FormatOutput,
            IndentChars = "  ",
            OmitXmlDeclaration = false
        };

        using var stringWriter = new StringWriter();
        using var xmlWriter = XmlWriter.Create(stringWriter, settings);
        document.Save(xmlWriter);
        
        return stringWriter.ToString();
    }

    /// <summary>
    /// 反序列化 XML
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="xml">XML 字串</param>
    /// <returns>反序列化的物件，如果失敗則為 null</returns>
    public T? Deserialize<T>(string xml) where T : class, ITypeFramework, new()
    {
        if (string.IsNullOrEmpty(xml))
            return null;

        try
        {
            var document = XDocument.Parse(xml);
            var rootElement = document.Root;
            
            if (rootElement == null)
                return null;

            return DeserializeElement<T>(rootElement);
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Failed to deserialize XML: {ex.Message}", ex);
        }
    }

    /// <summary>
    /// 建立 XML 元素
    /// </summary>
    /// <param name="value">要序列化的值</param>
    /// <returns>XML 元素</returns>
    private XElement CreateXmlElement(ITypeFramework value)
    {
        var elementName = GetElementName(value);
        var element = new XElement(elementName);

        // 添加命名空間
        if (_options.IncludeNamespaces)
        {
            element.Add(new XAttribute(XNamespace.Xmlns + "fhir", _options.DefaultNamespace));
        }

        // 序列化基本屬性
        if (value is IIdentifiableTypeFramework identifiable)
        {
            if (!string.IsNullOrEmpty(identifiable.Id))
            {
                element.Add(new XAttribute("id", identifiable.Id));
            }
        }

        // 序列化擴展
        if (value is IExtensibleTypeFramework extensible && extensible.Extension?.Any() == true)
        {
            foreach (var extension in extensible.Extension)
            {
                var extensionElement = CreateExtensionElement(extension);
                element.Add(extensionElement);
            }
        }

        // 序列化具體值
        SerializeValue(element, value);

        return element;
    }

    /// <summary>
    /// 建立擴展 XML 元素
    /// </summary>
    /// <param name="extension">擴展物件</param>
    /// <returns>擴展 XML 元素</returns>
    private XElement CreateExtensionElement(IExtension extension)
    {
        var extensionElement = new XElement("extension");
        
        if (!string.IsNullOrEmpty(extension.Url))
        {
            extensionElement.Add(new XAttribute("url", extension.Url));
        }

        if (extension.Value != null)
        {
            var valueElement = CreateValueElement(extension.Value);
            extensionElement.Add(valueElement);
        }

        return extensionElement;
    }

    /// <summary>
    /// 建立值 XML 元素
    /// </summary>
    /// <param name="value">值物件</param>
    /// <returns>值 XML 元素</returns>
    private XElement CreateValueElement(object value)
    {
        var valueType = value.GetType();
        var elementName = GetValueElementName(valueType);
        var element = new XElement(elementName);
        
        element.Value = value.ToString() ?? "";
        
        return element;
    }

    /// <summary>
    /// 序列化值
    /// </summary>
    /// <param name="parentElement">父元素</param>
    /// <param name="value">要序列化的值</param>
    private void SerializeValue(XElement parentElement, ITypeFramework value)
    {
        switch (value)
        {
            case FhirString fhirString:
                parentElement.Value = fhirString.Value ?? "";
                break;
            case FhirInteger fhirInteger:
                parentElement.Value = fhirInteger.Value?.ToString() ?? "";
                break;
            case FhirBoolean fhirBoolean:
                parentElement.Value = fhirBoolean.Value?.ToString().ToLower() ?? "";
                break;
            case FhirDateTime fhirDateTime:
                parentElement.Value = fhirDateTime.Value?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ?? "";
                break;
            case FhirDate fhirDate:
                parentElement.Value = fhirDate.Value?.ToString("yyyy-MM-dd") ?? "";
                break;
            case FhirUri fhirUri:
                parentElement.Value = fhirUri.Value ?? "";
                break;
            default:
                // 處理複雜型別
                SerializeComplexType(parentElement, value);
                break;
        }
    }

    /// <summary>
    /// 序列化複雜型別
    /// </summary>
    /// <param name="parentElement">父元素</param>
    /// <param name="value">複雜型別值</param>
    private void SerializeComplexType(XElement parentElement, ITypeFramework value)
    {
        // 這裡可以實作複雜型別的序列化邏輯
        // 例如 HumanName、Address 等
        var properties = value.GetType().GetProperties();
        
        foreach (var property in properties)
        {
            var propertyValue = property.GetValue(value);
            if (propertyValue != null)
            {
                var propertyElement = new XElement(property.Name.ToLower());
                
                if (propertyValue is ITypeFramework typeFramework)
                {
                    SerializeValue(propertyElement, typeFramework);
                }
                else
                {
                    propertyElement.Value = propertyValue.ToString() ?? "";
                }
                
                parentElement.Add(propertyElement);
            }
        }
    }

    /// <summary>
    /// 反序列化元素
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="element">XML 元素</param>
    /// <returns>反序列化的物件</returns>
    private T DeserializeElement<T>(XElement element) where T : class, ITypeFramework, new()
    {
        var result = new T();

        // 反序列化 ID
        if (result is IIdentifiableTypeFramework identifiable)
        {
            var idAttribute = element.Attribute("id");
            if (idAttribute != null)
            {
                identifiable.Id = idAttribute.Value;
            }
        }

        // 反序列化擴展
        if (result is IExtensibleTypeFramework extensible)
        {
            var extensionElements = element.Elements("extension");
            var extensions = new List<IExtension>();
            
            foreach (var extElement in extensionElements)
            {
                var extension = DeserializeExtension(extElement);
                if (extension != null)
                {
                    extensions.Add(extension);
                }
            }
            
            if (extensions.Any())
            {
                extensible.Extension = extensions;
            }
        }

        // 反序列化值
        DeserializeValue(element, result);

        return result;
    }

    /// <summary>
    /// 反序列化擴展
    /// </summary>
    /// <param name="element">擴展 XML 元素</param>
    /// <returns>擴展物件</returns>
    private IExtension? DeserializeExtension(XElement element)
    {
        var urlAttribute = element.Attribute("url");
        if (urlAttribute == null)
            return null;

        var extension = new Extension
        {
            Url = urlAttribute.Value
        };

        var valueElement = element.Elements().FirstOrDefault();
        if (valueElement != null)
        {
            extension.Value = DeserializeValueElement(valueElement);
        }

        return extension;
    }

    /// <summary>
    /// 反序列化值元素
    /// </summary>
    /// <param name="element">值 XML 元素</param>
    /// <returns>值物件</returns>
    private object DeserializeValueElement(XElement element)
    {
        var elementName = element.Name.LocalName;
        var value = element.Value;

        return elementName switch
        {
            "string" => new FhirString(value),
            "integer" => new FhirInteger(int.Parse(value)),
            "boolean" => new FhirBoolean(bool.Parse(value)),
            "dateTime" => new FhirDateTime(DateTime.Parse(value)),
            "date" => new FhirDate(DateTime.Parse(value)),
            "uri" => new FhirUri(value),
            _ => new FhirString(value) // 預設為字串
        };
    }

    /// <summary>
    /// 反序列化值
    /// </summary>
    /// <param name="element">XML 元素</param>
    /// <param name="result">結果物件</param>
    private void DeserializeValue(XElement element, ITypeFramework result)
    {
        // 根據型別實作具體的反序列化邏輯
        switch (result)
        {
            case FhirString fhirString:
                fhirString.Value = element.Value;
                break;
            case FhirInteger fhirInteger:
                if (int.TryParse(element.Value, out var intValue))
                {
                    fhirInteger.Value = intValue;
                }
                break;
            case FhirBoolean fhirBoolean:
                if (bool.TryParse(element.Value, out var boolValue))
                {
                    fhirBoolean.Value = boolValue;
                }
                break;
            case FhirDateTime fhirDateTime:
                if (DateTime.TryParse(element.Value, out var dateTimeValue))
                {
                    fhirDateTime.Value = dateTimeValue;
                }
                break;
            case FhirDate fhirDate:
                if (DateTime.TryParse(element.Value, out var dateValue))
                {
                    fhirDate.Value = dateValue;
                }
                break;
            case FhirUri fhirUri:
                fhirUri.Value = element.Value;
                break;
            default:
                // 處理複雜型別
                DeserializeComplexType(element, result);
                break;
        }
    }

    /// <summary>
    /// 反序列化複雜型別
    /// </summary>
    /// <param name="element">XML 元素</param>
    /// <param name="result">結果物件</param>
    private void DeserializeComplexType(XElement element, ITypeFramework result)
    {
        // 這裡可以實作複雜型別的反序列化邏輯
        var properties = result.GetType().GetProperties();
        
        foreach (var property in properties)
        {
            var propertyElement = element.Element(property.Name.ToLower());
            if (propertyElement != null)
            {
                var propertyValue = property.GetValue(result);
                if (propertyValue is ITypeFramework typeFramework)
                {
                    DeserializeValue(propertyElement, typeFramework);
                }
            }
        }
    }

    /// <summary>
    /// 取得元素名稱
    /// </summary>
    /// <param name="value">值物件</param>
    /// <returns>元素名稱</returns>
    private string GetElementName(ITypeFramework value)
    {
        return value.GetType().Name.ToLower();
    }

    /// <summary>
    /// 取得值元素名稱
    /// </summary>
    /// <param name="valueType">值型別</param>
    /// <returns>值元素名稱</returns>
    private string GetValueElementName(Type valueType)
    {
        return valueType.Name.ToLower().Replace("fhir", "");
    }
} 