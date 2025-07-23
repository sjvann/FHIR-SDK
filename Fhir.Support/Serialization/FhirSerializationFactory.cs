using Fhir.Support.Interfaces;

namespace Fhir.Support.Serialization;

/// <summary>
/// 工廠類別，用於創建 FHIR 序列化器和解析器
/// </summary>
public static class FhirSerializationFactory
{
    /// <summary>
    /// 創建 JSON 序列化器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>JSON 序列化器實例</returns>
    public static IFhirSerializer CreateJsonSerializer(FhirContext context)
    {
        var serializerType = Type.GetType("Fhir.Serialization.Json.JsonSerializer, Fhir.Serialization.Json");
        if (serializerType == null)
            throw new TypeLoadException("Cannot load Fhir.Serialization.Json.JsonSerializer. Make sure Fhir.Serialization.Json package is referenced.");
            
        return (IFhirSerializer)Activator.CreateInstance(serializerType, context)!;
    }

    /// <summary>
    /// 創建 JSON 解析器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>JSON 解析器實例</returns>
    public static IFhirParser CreateJsonParser(FhirContext context)
    {
        var parserType = Type.GetType("Fhir.Serialization.Json.JsonParser, Fhir.Serialization.Json");
        if (parserType == null)
            throw new TypeLoadException("Cannot load Fhir.Serialization.Json.JsonParser. Make sure Fhir.Serialization.Json package is referenced.");
            
        return (IFhirParser)Activator.CreateInstance(parserType, context)!;
    }

    /// <summary>
    /// 創建 XML 序列化器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>XML 序列化器實例</returns>
    public static IFhirSerializer CreateXmlSerializer(FhirContext context)
    {
        var serializerType = Type.GetType("Fhir.Serialization.Xml.XmlSerializer, Fhir.Serialization.Xml");
        if (serializerType == null)
            throw new TypeLoadException("Cannot load Fhir.Serialization.Xml.XmlSerializer. Make sure Fhir.Serialization.Xml package is referenced.");
            
        return (IFhirSerializer)Activator.CreateInstance(serializerType, context)!;
    }

    /// <summary>
    /// 創建 XML 解析器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>XML 解析器實例</returns>
    public static IFhirParser CreateXmlParser(FhirContext context)
    {
        var parserType = Type.GetType("Fhir.Serialization.Xml.XmlParser, Fhir.Serialization.Xml");
        if (parserType == null)
            throw new TypeLoadException("Cannot load Fhir.Serialization.Xml.XmlParser. Make sure Fhir.Serialization.Xml package is referenced.");
            
        return (IFhirParser)Activator.CreateInstance(parserType, context)!;
    }

    /// <summary>
    /// 根據格式創建序列化器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <param name="format">序列化格式</param>
    /// <returns>序列化器實例</returns>
    public static IFhirSerializer CreateSerializer(FhirContext context, FhirFormat format)
    {
        return format switch
        {
            FhirFormat.Json => CreateJsonSerializer(context),
            FhirFormat.Xml => CreateXmlSerializer(context),
            _ => throw new ArgumentException($"Unsupported format: {format}", nameof(format))
        };
    }

    /// <summary>
    /// 根據格式創建解析器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <param name="format">序列化格式</param>
    /// <returns>解析器實例</returns>
    public static IFhirParser CreateParser(FhirContext context, FhirFormat format)
    {
        return format switch
        {
            FhirFormat.Json => CreateJsonParser(context),
            FhirFormat.Xml => CreateXmlParser(context),
            _ => throw new ArgumentException($"Unsupported format: {format}", nameof(format))
        };
    }

    /// <summary>
    /// 根據內容自動檢測格式並創建解析器
    /// </summary>
    /// <param name="context">FHIR 上下文</param>
    /// <param name="content">要解析的內容</param>
    /// <returns>解析器實例</returns>
    public static IFhirParser CreateParserForContent(FhirContext context, string content)
    {
        var format = DetectFormat(content);
        return CreateParser(context, format);
    }

    /// <summary>
    /// 自動檢測內容格式
    /// </summary>
    /// <param name="content">要檢測的內容</param>
    /// <returns>檢測到的格式</returns>
    public static FhirFormat DetectFormat(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentException("Content cannot be null or empty", nameof(content));

        var trimmed = content.TrimStart();
        
        if (trimmed.StartsWith("{") || trimmed.StartsWith("["))
            return FhirFormat.Json;
        
        if (trimmed.StartsWith("<"))
            return FhirFormat.Xml;
            
        throw new ArgumentException("Cannot detect format from content", nameof(content));
    }
}

/// <summary>
/// FHIR 序列化和解析的擴展方法
/// </summary>
public static class FhirSerializationExtensions
{
    /// <summary>
    /// 將資源序列化為 JSON 字串
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resource">要序列化的資源</param>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>JSON 字串</returns>
    public static string ToJson<T>(this T resource, FhirContext context) where T : IResource
    {
        var serializer = FhirSerializationFactory.CreateJsonSerializer(context);
        return serializer.Serialize(resource);
    }

    /// <summary>
    /// 將資源序列化為 XML 字串
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="resource">要序列化的資源</param>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>XML 字串</returns>
    public static string ToXml<T>(this T resource, FhirContext context) where T : IResource
    {
        var serializer = FhirSerializationFactory.CreateXmlSerializer(context);
        return serializer.Serialize(resource);
    }

    /// <summary>
    /// 從 JSON 字串解析資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="json">JSON 字串</param>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>解析的資源</returns>
    public static T FromJson<T>(string json, FhirContext context) where T : IResource
    {
        var parser = FhirSerializationFactory.CreateJsonParser(context);
        return parser.Parse<T>(json);
    }

    /// <summary>
    /// 從 XML 字串解析資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="xml">XML 字串</param>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>解析的資源</returns>
    public static T FromXml<T>(string xml, FhirContext context) where T : IResource
    {
        var parser = FhirSerializationFactory.CreateXmlParser(context);
        return parser.Parse<T>(xml);
    }

    /// <summary>
    /// 自動檢測格式並解析資源
    /// </summary>
    /// <typeparam name="T">資源型別</typeparam>
    /// <param name="content">要解析的內容</param>
    /// <param name="context">FHIR 上下文</param>
    /// <returns>解析的資源</returns>
    public static T ParseAuto<T>(string content, FhirContext context) where T : IResource
    {
        var parser = FhirSerializationFactory.CreateParserForContent(context, content);
        return parser.Parse<T>(content);
    }
}
