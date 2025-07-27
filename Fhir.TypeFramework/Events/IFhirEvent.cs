namespace Fhir.TypeFramework.Events;

/// <summary>
/// FHIR 事件介面
/// 定義 FHIR 事件的基本結構
/// </summary>
public interface IFhirEvent
{
    /// <summary>
    /// 事件型別
    /// </summary>
    string EventType { get; }
    
    /// <summary>
    /// 事件時間戳
    /// </summary>
    DateTime Timestamp { get; }
    
    /// <summary>
    /// 事件資料
    /// </summary>
    object? Data { get; }
    
    /// <summary>
    /// 事件來源
    /// </summary>
    string? Source { get; }
    
    /// <summary>
    /// 事件優先級
    /// </summary>
    EventPriority Priority { get; }
}

/// <summary>
/// 事件優先級枚舉
/// </summary>
public enum EventPriority
{
    /// <summary>
    /// 低優先級
    /// </summary>
    Low,
    
    /// <summary>
    /// 一般優先級
    /// </summary>
    Normal,
    
    /// <summary>
    /// 高優先級
    /// </summary>
    High,
    
    /// <summary>
    /// 緊急優先級
    /// </summary>
    Critical
}

/// <summary>
/// FHIR 事件實作
/// </summary>
public class FhirEvent : IFhirEvent
{
    /// <summary>
    /// 初始化 FHIR 事件
    /// </summary>
    /// <param name="eventType">事件型別</param>
    /// <param name="data">事件資料</param>
    /// <param name="source">事件來源</param>
    /// <param name="priority">事件優先級</param>
    public FhirEvent(string eventType, object? data = null, string? source = null, EventPriority priority = EventPriority.Normal)
    {
        EventType = eventType;
        Timestamp = DateTime.UtcNow;
        Data = data;
        Source = source;
        Priority = priority;
    }
    
    public string EventType { get; }
    public DateTime Timestamp { get; }
    public object? Data { get; }
    public string? Source { get; }
    public EventPriority Priority { get; }
}

/// <summary>
/// 資源變更事件
/// </summary>
public class ResourceChangedEvent : FhirEvent
{
    /// <summary>
    /// 變更型別
    /// </summary>
    public ChangeType ChangeType { get; }
    
    /// <summary>
    /// 資源 ID
    /// </summary>
    public string? ResourceId { get; }
    
    /// <summary>
    /// 資源型別
    /// </summary>
    public string? ResourceType { get; }
    
    /// <summary>
    /// 初始化資源變更事件
    /// </summary>
    /// <param name="changeType">變更型別</param>
    /// <param name="resourceId">資源 ID</param>
    /// <param name="resourceType">資源型別</param>
    /// <param name="data">事件資料</param>
    public ResourceChangedEvent(ChangeType changeType, string? resourceId, string? resourceType, object? data = null)
        : base($"Resource.{changeType}", data, "FhirTypeFramework", EventPriority.Normal)
    {
        ChangeType = changeType;
        ResourceId = resourceId;
        ResourceType = resourceType;
    }
}

/// <summary>
/// 變更型別枚舉
/// </summary>
public enum ChangeType
{
    /// <summary>
    /// 建立
    /// </summary>
    Created,
    
    /// <summary>
    /// 更新
    /// </summary>
    Updated,
    
    /// <summary>
    /// 刪除
    /// </summary>
    Deleted,
    
    /// <summary>
    /// 驗證
    /// </summary>
    Validated,
    
    /// <summary>
    /// 序列化
    /// </summary>
    Serialized,
    
    /// <summary>
    /// 反序列化
    /// </summary>
    Deserialized
}

/// <summary>
/// 驗證事件
/// </summary>
public class ValidationEvent : FhirEvent
{
    /// <summary>
    /// 驗證結果
    /// </summary>
    public bool IsValid { get; }
    
    /// <summary>
    /// 驗證錯誤數量
    /// </summary>
    public int ErrorCount { get; }
    
    /// <summary>
    /// 驗證警告數量
    /// </summary>
    public int WarningCount { get; }
    
    /// <summary>
    /// 初始化驗證事件
    /// </summary>
    /// <param name="isValid">是否有效</param>
    /// <param name="errorCount">錯誤數量</param>
    /// <param name="warningCount">警告數量</param>
    /// <param name="data">事件資料</param>
    public ValidationEvent(bool isValid, int errorCount = 0, int warningCount = 0, object? data = null)
        : base("Validation", data, "FhirTypeFramework", isValid ? EventPriority.Normal : EventPriority.High)
    {
        IsValid = isValid;
        ErrorCount = errorCount;
        WarningCount = warningCount;
    }
}

/// <summary>
/// 序列化事件
/// </summary>
public class SerializationEvent : FhirEvent
{
    /// <summary>
    /// 序列化格式
    /// </summary>
    public string Format { get; }
    
    /// <summary>
    /// 序列化大小（位元組）
    /// </summary>
    public int Size { get; }
    
    /// <summary>
    /// 序列化耗時（毫秒）
    /// </summary>
    public long Duration { get; }
    
    /// <summary>
    /// 初始化序列化事件
    /// </summary>
    /// <param name="format">序列化格式</param>
    /// <param name="size">序列化大小</param>
    /// <param name="duration">序列化耗時</param>
    /// <param name="data">事件資料</param>
    public SerializationEvent(string format, int size, long duration, object? data = null)
        : base("Serialization", data, "FhirTypeFramework", EventPriority.Low)
    {
        Format = format;
        Size = size;
        Duration = duration;
    }
} 