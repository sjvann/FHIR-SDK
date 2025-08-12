using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace FhirCore.Caching
{
    /// <summary>
    /// FHIR 快取介面
    /// </summary>
    public interface IFhirCache
    {
        Task<T?> GetAsync<T>(string key) where T : class;
        Task SetAsync<T>(string key, T value, TimeSpan? expiration = null) where T : class;
        Task RemoveAsync(string key);
        Task ClearAsync();
    }

    /// <summary>
    /// 記憶體快取實作
    /// </summary>
    public class MemoryCache : IFhirCache
    {
        private readonly ConcurrentDictionary<string, CacheItem> _cache = new();

        public async Task<T?> GetAsync<T>(string key) where T : class
        {
            if (_cache.TryGetValue(key, out var item) && !item.IsExpired)
            {
                return item.Value as T;
            }

            // 移除過期的項目
            if (item?.IsExpired == true)
            {
                _cache.TryRemove(key, out _);
            }

            return null;
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiration = null) where T : class
        {
            var item = new CacheItem
            {
                Value = value,
                ExpirationTime = expiration.HasValue ? DateTime.UtcNow.Add(expiration.Value) : null
            };

            _cache.AddOrUpdate(key, item, (_, _) => item);
        }

        public async Task RemoveAsync(string key)
        {
            _cache.TryRemove(key, out _);
        }

        public async Task ClearAsync()
        {
            _cache.Clear();
        }

        private class CacheItem
        {
            public object Value { get; set; } = null!;
            public DateTime? ExpirationTime { get; set; }
            public bool IsExpired => ExpirationTime.HasValue && DateTime.UtcNow > ExpirationTime.Value;
        }
    }

    /// <summary>
    /// 分散式快取實作（Redis）
    /// </summary>
    public class DistributedCache : IFhirCache
    {
        private readonly IDistributedCache _cache;

        public DistributedCache(IDistributedCache cache)
        {
            _cache = cache;
        }

        public async Task<T?> GetAsync<T>(string key) where T : class
        {
            var data = await _cache.GetStringAsync(key);
            if (string.IsNullOrEmpty(data))
                return null;

            return System.Text.Json.JsonSerializer.Deserialize<T>(data);
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiration = null) where T : class
        {
            var data = System.Text.Json.JsonSerializer.Serialize(value);
            var options = new DistributedCacheEntryOptions();
            
            if (expiration.HasValue)
                options.SetAbsoluteExpiration(expiration.Value);

            await _cache.SetStringAsync(key, data, options);
        }

        public async Task RemoveAsync(string key)
        {
            await _cache.RemoveAsync(key);
        }

        public async Task ClearAsync()
        {
            // 注意：分散式快取通常不支援清除所有項目
            // 這需要實作特定的清除邏輯
            throw new NotSupportedException("Clear operation is not supported for distributed cache");
        }
    }

    /// <summary>
    /// 快取管理員
    /// </summary>
    public class FhirCacheManager
    {
        private readonly IFhirCache _cache;
        private readonly TimeSpan _defaultExpiration = TimeSpan.FromMinutes(30);

        public FhirCacheManager(IFhirCache cache)
        {
            _cache = cache;
        }

        /// <summary>
        /// 取得或設定快取項目
        /// </summary>
        public async Task<T> GetOrSetAsync<T>(string key, Func<Task<T>> factory, TimeSpan? expiration = null) where T : class
        {
            var cached = await _cache.GetAsync<T>(key);
            if (cached != null)
                return cached;

            var value = await factory();
            await _cache.SetAsync(key, value, expiration ?? _defaultExpiration);
            return value;
        }

        /// <summary>
        /// 建立快取鍵
        /// </summary>
        public static string CreateKey(string resourceType, string id, string? version = null)
        {
            return version != null ? $"{resourceType}:{id}:{version}" : $"{resourceType}:{id}";
        }

        /// <summary>
        /// 建立搜尋快取鍵
        /// </summary>
        public static string CreateSearchKey(string resourceType, string query)
        {
            return $"search:{resourceType}:{query.GetHashCode()}";
        }
    }

    /// <summary>
    /// 分散式快取介面（用於依賴注入）
    /// </summary>
    public interface IDistributedCache
    {
        Task<string?> GetStringAsync(string key);
        Task SetStringAsync(string key, string value, DistributedCacheEntryOptions? options = null);
        Task RemoveAsync(string key);
    }

    /// <summary>
    /// 分散式快取選項
    /// </summary>
    public class DistributedCacheEntryOptions
    {
        public TimeSpan? AbsoluteExpiration { get; set; }
        public TimeSpan? SlidingExpiration { get; set; }

        public void SetAbsoluteExpiration(TimeSpan expiration)
        {
            AbsoluteExpiration = expiration;
        }

        public void SetSlidingExpiration(TimeSpan expiration)
        {
            SlidingExpiration = expiration;
        }
    }
} 