using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FhirCore.Interfaces
{
    /// <summary>
    /// 資源解析器接口，用於解析 FHIR Reference
    /// </summary>
    public interface IResourceResolver
    {
        /// <summary>
        /// 根據引用字符串解析資源
        /// </summary>
        /// <typeparam name="T">期望的資源類型</typeparam>
        /// <param name="reference">引用字符串</param>
        /// <returns>解析的資源，如果找不到則返回 null</returns>
        Task<T?> GetResourceAsync<T>(string reference) where T : class, IResource;

        /// <summary>
        /// 根據資源類型和 ID 解析資源
        /// </summary>
        /// <typeparam name="T">期望的資源類型</typeparam>
        /// <param name="resourceId">資源 ID</param>
        /// <returns>解析的資源，如果找不到則返回 null</returns>
        Task<T?> GetResourceByIdAsync<T>(string resourceId) where T : class, IResource;

        /// <summary>
        /// 根據 Identifier 解析資源
        /// </summary>
        /// <typeparam name="T">期望的資源類型</typeparam>
        /// <param name="system">識別符系統</param>
        /// <param name="value">識別符值</param>
        /// <returns>解析的資源，如果找不到則返回 null</returns>
        Task<T?> GetResourceByIdentifierAsync<T>(string system, string value) where T : class, IResource;

        /// <summary>
        /// 檢查引用是否存在
        /// </summary>
        /// <param name="reference">引用字符串</param>
        /// <returns>如果引用存在則返回 true</returns>
        Task<bool> ExistsAsync(string reference);

        /// <summary>
        /// 檢查資源是否存在
        /// </summary>
        /// <typeparam name="T">資源類型</typeparam>
        /// <param name="resourceId">資源 ID</param>
        /// <returns>如果資源存在則返回 true</returns>
        Task<bool> ExistsAsync<T>(string resourceId) where T : class, IResource;
    }

    /// <summary>
    /// 簡單的內存資源解析器實現，用於測試和示例
    /// </summary>
    public class InMemoryResourceResolver : IResourceResolver
    {
        private readonly Dictionary<string, IResource> _resources = new();

        /// <summary>
        /// 添加資源到解析器
        /// </summary>
        public void AddResource(string key, IResource resource)
        {
            _resources[key] = resource;
        }

        /// <summary>
        /// 添加資源到解析器（使用資源類型/ID 作為鍵）
        /// </summary>
        public void AddResource<T>(string resourceId, T resource) where T : class, IResource
        {
            var key = $"{typeof(T).Name}/{resourceId}";
            _resources[key] = resource;
        }

        public Task<T?> GetResourceAsync<T>(string reference) where T : class, IResource
        {
            if (_resources.TryGetValue(reference, out var resource) && resource is T typedResource)
            {
                return Task.FromResult<T?>(typedResource);
            }

            // 嘗試處理完整 URL
            var lastSlashIndex = reference.LastIndexOf('/');
            if (lastSlashIndex >= 0)
            {
                var potentialKey = reference.Substring(lastSlashIndex + 1);
                var resourceTypeKey = $"{typeof(T).Name}/{potentialKey}";
                if (_resources.TryGetValue(resourceTypeKey, out var urlResource) && urlResource is T typedUrlResource)
                {
                    return Task.FromResult<T?>(typedUrlResource);
                }
            }

            return Task.FromResult<T?>(null);
        }

        public Task<T?> GetResourceByIdAsync<T>(string resourceId) where T : class, IResource
        {
            var key = $"{typeof(T).Name}/{resourceId}";
            if (_resources.TryGetValue(key, out var resource) && resource is T typedResource)
            {
                return Task.FromResult<T?>(typedResource);
            }
            return Task.FromResult<T?>(null);
        }

        public Task<T?> GetResourceByIdentifierAsync<T>(string system, string value) where T : class, IResource
        {
            // 簡化實現：使用 system|value 作為鍵
            var key = $"{system}|{value}";
            if (_resources.TryGetValue(key, out var resource) && resource is T typedResource)
            {
                return Task.FromResult<T?>(typedResource);
            }
            return Task.FromResult<T?>(null);
        }

        public Task<bool> ExistsAsync(string reference)
        {
            if (_resources.ContainsKey(reference))
                return Task.FromResult(true);

            // 嘗試處理完整 URL
            var lastSlashIndex = reference.LastIndexOf('/');
            if (lastSlashIndex >= 0)
            {
                var potentialKey = reference.Substring(lastSlashIndex + 1);
                // 檢查是否有任何資源類型匹配
                foreach (var key in _resources.Keys)
                {
                    if (key.EndsWith($"/{potentialKey}"))
                        return Task.FromResult(true);
                }
            }

            return Task.FromResult(false);
        }

        public Task<bool> ExistsAsync<T>(string resourceId) where T : class, IResource
        {
            var key = $"{typeof(T).Name}/{resourceId}";
            return Task.FromResult(_resources.ContainsKey(key));
        }

        /// <summary>
        /// 清除所有資源
        /// </summary>
        public void Clear()
        {
            _resources.Clear();
        }

        /// <summary>
        /// 取得所有資源的鍵
        /// </summary>
        public IEnumerable<string> GetAllKeys()
        {
            return _resources.Keys;
        }
    }
}
