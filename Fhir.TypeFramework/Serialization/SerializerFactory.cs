using Fhir.TypeFramework.Abstractions;

namespace Fhir.TypeFramework.Serialization;

/// <summary>
/// 序列化格式枚舉
/// </summary>
public enum SerializationFormat
{
    /// <summary>
    /// JSON 格式
    /// </summary>
    Json,
    
    /// <summary>
    /// XML 格式
    /// </summary>
    Xml
}

/// <summary>
/// 序列化器介面
/// </summary>
public interface ISerializer
{
    /// <summary>
    /// 序列化為字串
    /// </summary>
    /// <typeparam name="T">要序列化的型別</typeparam>
    /// <param name="value">要序列化的值</param>
    /// <returns>序列化後的字串</returns>
    string Serialize<T>(T value) where T : ITypeFramework;
    
    /// <summary>
    /// 反序列化
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="data">要反序列化的資料</param>
    /// <returns>反序列化的物件</returns>
    T? Deserialize<T>(string data) where T : class, ITypeFramework, new();
}

/// <summary>
/// JSON 序列化器實作
/// </summary>
public class JsonSerializer : ISerializer
{
    private readonly FhirJsonSerializer _serializer;
    
    public JsonSerializer()
    {
        _serializer = new FhirJsonSerializer();
    }
    
    public string Serialize<T>(T value) where T : ITypeFramework
    {
        return _serializer.SerializeFhirFormat("value", value);
    }
    
    public T? Deserialize<T>(string data) where T : class, ITypeFramework, new()
    {
        return _serializer.DeserializeSimple<T>(data);
    }
}

/// <summary>
/// XML 序列化器實作
/// </summary>
public class XmlSerializer : ISerializer
{
    private readonly FhirXmlSerializer _serializer;
    
    public XmlSerializer()
    {
        _serializer = new FhirXmlSerializer();
    }
    
    public string Serialize<T>(T value) where T : ITypeFramework
    {
        return _serializer.Serialize(value);
    }
    
    public T? Deserialize<T>(string data) where T : class, ITypeFramework, new()
    {
        return _serializer.Deserialize<T>(data);
    }
}

/// <summary>
/// 序列化器工廠
/// 提供統一的序列化器建立介面
/// </summary>
public class SerializerFactory
{
    private static readonly Dictionary<SerializationFormat, ISerializer> _serializers = new();
    private static readonly object _lock = new();
    
    /// <summary>
    /// 靜態建構函式，初始化預設序列化器
    /// </summary>
    static SerializerFactory()
    {
        RegisterDefaultSerializers();
    }
    
    /// <summary>
    /// 建立序列化器
    /// </summary>
    /// <param name="format">序列化格式</param>
    /// <returns>對應的序列化器</returns>
    public static ISerializer CreateSerializer(SerializationFormat format)
    {
        lock (_lock)
        {
            if (_serializers.TryGetValue(format, out var serializer))
            {
                return serializer;
            }
            
            throw new ArgumentException($"Unsupported serialization format: {format}");
        }
    }
    
    /// <summary>
    /// 註冊自訂序列化器
    /// </summary>
    /// <param name="format">序列化格式</param>
    /// <param name="serializer">序列化器</param>
    public static void RegisterSerializer(SerializationFormat format, ISerializer serializer)
    {
        lock (_lock)
        {
            _serializers[format] = serializer;
        }
    }
    
    /// <summary>
    /// 移除序列化器
    /// </summary>
    /// <param name="format">序列化格式</param>
    /// <returns>如果成功移除則為 true，否則為 false</returns>
    public static bool RemoveSerializer(SerializationFormat format)
    {
        lock (_lock)
        {
            return _serializers.Remove(format);
        }
    }
    
    /// <summary>
    /// 取得所有支援的序列化格式
    /// </summary>
    /// <returns>序列化格式集合</returns>
    public static IEnumerable<SerializationFormat> GetSupportedFormats()
    {
        lock (_lock)
        {
            return _serializers.Keys.ToList();
        }
    }
    
    /// <summary>
    /// 檢查是否支援指定的序列化格式
    /// </summary>
    /// <param name="format">序列化格式</param>
    /// <returns>如果支援則為 true，否則為 false</returns>
    public static bool IsFormatSupported(SerializationFormat format)
    {
        lock (_lock)
        {
            return _serializers.ContainsKey(format);
        }
    }
    
    /// <summary>
    /// 序列化為指定格式
    /// </summary>
    /// <typeparam name="T">要序列化的型別</typeparam>
    /// <param name="value">要序列化的值</param>
    /// <param name="format">序列化格式</param>
    /// <returns>序列化後的字串</returns>
    public static string Serialize<T>(T value, SerializationFormat format) where T : ITypeFramework
    {
        var serializer = CreateSerializer(format);
        return serializer.Serialize(value);
    }
    
    /// <summary>
    /// 反序列化
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="data">要反序列化的資料</param>
    /// <param name="format">序列化格式</param>
    /// <returns>反序列化的物件</returns>
    public static T? Deserialize<T>(string data, SerializationFormat format) where T : class, ITypeFramework, new()
    {
        var serializer = CreateSerializer(format);
        return serializer.Deserialize<T>(data);
    }
    
    /// <summary>
    /// 註冊預設序列化器
    /// </summary>
    private static void RegisterDefaultSerializers()
    {
        RegisterSerializer(SerializationFormat.Json, new JsonSerializer());
        RegisterSerializer(SerializationFormat.Xml, new XmlSerializer());
    }
}

/// <summary>
/// 序列化器擴展方法
/// </summary>
public static class SerializerExtensions
{
    /// <summary>
    /// 序列化為 JSON
    /// </summary>
    /// <typeparam name="T">要序列化的型別</typeparam>
    /// <param name="value">要序列化的值</param>
    /// <returns>JSON 字串</returns>
    public static string ToJson<T>(this T value) where T : ITypeFramework
    {
        return SerializerFactory.Serialize(value, SerializationFormat.Json);
    }
    
    /// <summary>
    /// 序列化為 XML
    /// </summary>
    /// <typeparam name="T">要序列化的型別</typeparam>
    /// <param name="value">要序列化的值</param>
    /// <returns>XML 字串</returns>
    public static string ToXml<T>(this T value) where T : ITypeFramework
    {
        return SerializerFactory.Serialize(value, SerializationFormat.Xml);
    }
    
    /// <summary>
    /// 從 JSON 反序列化
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="json">JSON 字串</param>
    /// <returns>反序列化的物件</returns>
    public static T? FromJson<T>(this string json) where T : class, ITypeFramework, new()
    {
        return SerializerFactory.Deserialize<T>(json, SerializationFormat.Json);
    }
    
    /// <summary>
    /// 從 XML 反序列化
    /// </summary>
    /// <typeparam name="T">目標型別</typeparam>
    /// <param name="xml">XML 字串</param>
    /// <returns>反序列化的物件</returns>
    public static T? FromXml<T>(this string xml) where T : class, ITypeFramework, new()
    {
        return SerializerFactory.Deserialize<T>(xml, SerializationFormat.Xml);
    }
} 