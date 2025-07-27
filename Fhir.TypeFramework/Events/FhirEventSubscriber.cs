using System.Collections.Concurrent;

namespace Fhir.TypeFramework.Events;

/// <summary>
/// FHIR 事件訂閱器
/// 提供事件訂閱和發布功能
/// </summary>
public class FhirEventSubscriber
{
    private readonly ConcurrentDictionary<string, List<Action<IFhirEvent>>> _subscribers = new();
    private readonly ConcurrentDictionary<string, List<Action<IFhirEvent>>> _prioritySubscribers = new();
    private readonly object _lock = new();
    
    /// <summary>
    /// 事件發布統計
    /// </summary>
    public EventStatistics Statistics { get; } = new();
    
    /// <summary>
    /// 訂閱事件
    /// </summary>
    /// <param name="eventType">事件型別</param>
    /// <param name="handler">事件處理器</param>
    public void Subscribe(string eventType, Action<IFhirEvent> handler)
    {
        if (string.IsNullOrEmpty(eventType) || handler == null)
            return;
        
        var subscribers = _subscribers.GetOrAdd(eventType, _ => new List<Action<IFhirEvent>>());
        
        lock (_lock)
        {
            subscribers.Add(handler);
        }
    }
    
    /// <summary>
    /// 訂閱優先級事件
    /// </summary>
    /// <param name="eventType">事件型別</param>
    /// <param name="priority">優先級</param>
    /// <param name="handler">事件處理器</param>
    public void Subscribe(string eventType, EventPriority priority, Action<IFhirEvent> handler)
    {
        if (string.IsNullOrEmpty(eventType) || handler == null)
            return;
        
        var key = $"{eventType}.{priority}";
        var subscribers = _prioritySubscribers.GetOrAdd(key, _ => new List<Action<IFhirEvent>>());
        
        lock (_lock)
        {
            subscribers.Add(handler);
        }
    }
    
    /// <summary>
    /// 取消訂閱事件
    /// </summary>
    /// <param name="eventType">事件型別</param>
    /// <param name="handler">事件處理器</param>
    public void Unsubscribe(string eventType, Action<IFhirEvent> handler)
    {
        if (string.IsNullOrEmpty(eventType) || handler == null)
            return;
        
        if (_subscribers.TryGetValue(eventType, out var subscribers))
        {
            lock (_lock)
            {
                subscribers.Remove(handler);
            }
        }
    }
    
    /// <summary>
    /// 取消訂閱優先級事件
    /// </summary>
    /// <param name="eventType">事件型別</param>
    /// <param name="priority">優先級</param>
    /// <param name="handler">事件處理器</param>
    public void Unsubscribe(string eventType, EventPriority priority, Action<IFhirEvent> handler)
    {
        if (string.IsNullOrEmpty(eventType) || handler == null)
            return;
        
        var key = $"{eventType}.{priority}";
        if (_prioritySubscribers.TryGetValue(key, out var subscribers))
        {
            lock (_lock)
            {
                subscribers.Remove(handler);
            }
        }
    }
    
    /// <summary>
    /// 發布事件
    /// </summary>
    /// <param name="fhirEvent">FHIR 事件</param>
    public void Publish(IFhirEvent fhirEvent)
    {
        if (fhirEvent == null)
            return;
        
        Statistics.IncrementEventCount(fhirEvent.EventType);
        
        // 發布一般事件
        if (_subscribers.TryGetValue(fhirEvent.EventType, out var subscribers))
        {
            var handlers = subscribers.ToList(); // 複製以避免並發修改
            foreach (var handler in handlers)
            {
                try
                {
                    handler(fhirEvent);
                    Statistics.IncrementHandledCount(fhirEvent.EventType);
                }
                catch (Exception ex)
                {
                    Statistics.IncrementErrorCount(fhirEvent.EventType);
                    OnError?.Invoke(fhirEvent, ex);
                }
            }
        }
        
        // 發布優先級事件
        var priorityKey = $"{fhirEvent.EventType}.{fhirEvent.Priority}";
        if (_prioritySubscribers.TryGetValue(priorityKey, out var prioritySubscribers))
        {
            var handlers = prioritySubscribers.ToList();
            foreach (var handler in handlers)
            {
                try
                {
                    handler(fhirEvent);
                    Statistics.IncrementHandledCount(fhirEvent.EventType);
                }
                catch (Exception ex)
                {
                    Statistics.IncrementErrorCount(fhirEvent.EventType);
                    OnError?.Invoke(fhirEvent, ex);
                }
            }
        }
    }
    
    /// <summary>
    /// 發布資源變更事件
    /// </summary>
    /// <param name="changeType">變更型別</param>
    /// <param name="resourceId">資源 ID</param>
    /// <param name="resourceType">資源型別</param>
    /// <param name="data">事件資料</param>
    public void PublishResourceChanged(ChangeType changeType, string? resourceId, string? resourceType, object? data = null)
    {
        var fhirEvent = new ResourceChangedEvent(changeType, resourceId, resourceType, data);
        Publish(fhirEvent);
    }
    
    /// <summary>
    /// 發布驗證事件
    /// </summary>
    /// <param name="isValid">是否有效</param>
    /// <param name="errorCount">錯誤數量</param>
    /// <param name="warningCount">警告數量</param>
    /// <param name="data">事件資料</param>
    public void PublishValidation(bool isValid, int errorCount = 0, int warningCount = 0, object? data = null)
    {
        var fhirEvent = new ValidationEvent(isValid, errorCount, warningCount, data);
        Publish(fhirEvent);
    }
    
    /// <summary>
    /// 發布序列化事件
    /// </summary>
    /// <param name="format">序列化格式</param>
    /// <param name="size">序列化大小</param>
    /// <param name="duration">序列化耗時</param>
    /// <param name="data">事件資料</param>
    public void PublishSerialization(string format, int size, long duration, object? data = null)
    {
        var fhirEvent = new SerializationEvent(format, size, duration, data);
        Publish(fhirEvent);
    }
    
    /// <summary>
    /// 清除所有訂閱
    /// </summary>
    public void ClearSubscriptions()
    {
        lock (_lock)
        {
            _subscribers.Clear();
            _prioritySubscribers.Clear();
        }
    }
    
    /// <summary>
    /// 取得訂閱統計
    /// </summary>
    /// <returns>訂閱統計資訊</returns>
    public SubscriptionStatistics GetSubscriptionStatistics()
    {
        lock (_lock)
        {
            var totalSubscribers = _subscribers.Values.Sum(s => s.Count);
            var totalPrioritySubscribers = _prioritySubscribers.Values.Sum(s => s.Count);
            
            return new SubscriptionStatistics
            {
                TotalEventTypes = _subscribers.Count + _prioritySubscribers.Count,
                TotalSubscribers = totalSubscribers + totalPrioritySubscribers,
                EventTypes = _subscribers.Keys.ToList(),
                PriorityEventTypes = _prioritySubscribers.Keys.ToList()
            };
        }
    }
    
    /// <summary>
    /// 錯誤處理事件
    /// </summary>
    public event Action<IFhirEvent, Exception>? OnError;
}

/// <summary>
/// 事件統計
/// </summary>
public class EventStatistics
{
    private readonly ConcurrentDictionary<string, EventTypeStatistics> _statistics = new();
    
    /// <summary>
    /// 增加事件計數
    /// </summary>
    /// <param name="eventType">事件型別</param>
    public void IncrementEventCount(string eventType)
    {
        var stats = _statistics.GetOrAdd(eventType, _ => new EventTypeStatistics());
        stats.IncrementEventCount();
    }
    
    /// <summary>
    /// 增加處理計數
    /// </summary>
    /// <param name="eventType">事件型別</param>
    public void IncrementHandledCount(string eventType)
    {
        var stats = _statistics.GetOrAdd(eventType, _ => new EventTypeStatistics());
        stats.IncrementHandledCount();
    }
    
    /// <summary>
    /// 增加錯誤計數
    /// </summary>
    /// <param name="eventType">事件型別</param>
    public void IncrementErrorCount(string eventType)
    {
        var stats = _statistics.GetOrAdd(eventType, _ => new EventTypeStatistics());
        stats.IncrementErrorCount();
    }
    
    /// <summary>
    /// 取得統計資訊
    /// </summary>
    /// <returns>統計資訊字典</returns>
    public Dictionary<string, EventTypeStatistics> GetStatistics()
    {
        return _statistics.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
    
    /// <summary>
    /// 重置統計
    /// </summary>
    public void Reset()
    {
        _statistics.Clear();
    }
}

/// <summary>
/// 事件型別統計
/// </summary>
public class EventTypeStatistics
{
    private long _eventCount;
    private long _handledCount;
    private long _errorCount;
    
    /// <summary>
    /// 事件總數
    /// </summary>
    public long EventCount => _eventCount;
    
    /// <summary>
    /// 處理成功數
    /// </summary>
    public long HandledCount => _handledCount;
    
    /// <summary>
    /// 錯誤數
    /// </summary>
    public long ErrorCount => _errorCount;
    
    /// <summary>
    /// 成功率
    /// </summary>
    public double SuccessRate => _eventCount > 0 ? (double)_handledCount / _eventCount : 0;
    
    /// <summary>
    /// 錯誤率
    /// </summary>
    public double ErrorRate => _eventCount > 0 ? (double)_errorCount / _eventCount : 0;
    
    /// <summary>
    /// 增加事件計數
    /// </summary>
    public void IncrementEventCount()
    {
        Interlocked.Increment(ref _eventCount);
    }
    
    /// <summary>
    /// 增加處理計數
    /// </summary>
    public void IncrementHandledCount()
    {
        Interlocked.Increment(ref _handledCount);
    }
    
    /// <summary>
    /// 增加錯誤計數
    /// </summary>
    public void IncrementErrorCount()
    {
        Interlocked.Increment(ref _errorCount);
    }
}

/// <summary>
/// 訂閱統計
/// </summary>
public class SubscriptionStatistics
{
    /// <summary>
    /// 事件型別總數
    /// </summary>
    public int TotalEventTypes { get; set; }
    
    /// <summary>
    /// 訂閱者總數
    /// </summary>
    public int TotalSubscribers { get; set; }
    
    /// <summary>
    /// 事件型別列表
    /// </summary>
    public List<string> EventTypes { get; set; } = new();
    
    /// <summary>
    /// 優先級事件型別列表
    /// </summary>
    public List<string> PriorityEventTypes { get; set; } = new();
} 