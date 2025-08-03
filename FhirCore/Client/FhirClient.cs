using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FhirCore.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace FhirCore.Client
{
    /// <summary>
    /// 現代化 FHIR 客戶端，提供完整的 FHIR 操作支援
    /// </summary>
    public class FhirClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly string _baseUrl;

        public FhirClient(string baseUrl, HttpClient? httpClient = null)
        {
            _baseUrl = baseUrl?.TrimEnd('/') ?? throw new ArgumentNullException(nameof(baseUrl));
            _httpClient = httpClient ?? new HttpClient();
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };
        }

        /// <summary>
        /// 讀取資源
        /// </summary>
        public async Task<T?> ReadAsync<T>(string resourceType, string id) where T : class
        {
            var url = $"{_baseUrl}/{resourceType}/{id}";
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json, _jsonOptions);
        }

        /// <summary>
        /// 搜尋資源
        /// </summary>
        public async Task<SearchResult<T>> SearchAsync<T>(string resourceType, SearchParameters parameters) where T : class
        {
            var queryString = parameters.ToQueryString();
            var url = $"{_baseUrl}/{resourceType}?{queryString}";
            
            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<SearchResult<T>>(json, _jsonOptions) ?? new SearchResult<T>();
        }

        /// <summary>
        /// 建立資源
        /// </summary>
        public async Task<CreateResult> CreateAsync<T>(T resource) where T : class
        {
            var resourceType = GetResourceType(resource);
            var url = $"{_baseUrl}/{resourceType}";
            
            var json = JsonSerializer.Serialize(resource, _jsonOptions);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/fhir+json");
            
            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            
            return new CreateResult
            {
                Id = ExtractIdFromLocation(response.Headers.Location?.ToString()),
                Location = response.Headers.Location?.ToString()
            };
        }

        /// <summary>
        /// 更新資源
        /// </summary>
        public async Task<UpdateResult> UpdateAsync<T>(T resource, string id) where T : class
        {
            var resourceType = GetResourceType(resource);
            var url = $"{_baseUrl}/{resourceType}/{id}";
            
            var json = JsonSerializer.Serialize(resource, _jsonOptions);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/fhir+json");
            
            var response = await _httpClient.PutAsync(url, content);
            response.EnsureSuccessStatusCode();
            
            return new UpdateResult
            {
                Id = id,
                VersionId = ExtractVersionId(response.Headers)
            };
        }

        /// <summary>
        /// 刪除資源
        /// </summary>
        public async Task<DeleteResult> DeleteAsync(string resourceType, string id)
        {
            var url = $"{_baseUrl}/{resourceType}/{id}";
            var response = await _httpClient.DeleteAsync(url);
            response.EnsureSuccessStatusCode();
            
            return new DeleteResult
            {
                Id = id,
                Success = true
            };
        }

        /// <summary>
        /// 批次操作
        /// </summary>
        public async Task<BatchResult> BatchAsync(BatchRequest request)
        {
            var url = $"{_baseUrl}";
            var json = JsonSerializer.Serialize(request, _jsonOptions);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/fhir+json");
            
            var response = await _httpClient.PostAsync(url, content);
            response.EnsureSuccessStatusCode();
            
            var responseJson = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<BatchResult>(responseJson, _jsonOptions) ?? new BatchResult();
        }

        private static string GetResourceType<T>(T resource) where T : class
        {
            // 透過反射取得資源類型
            var resourceTypeProperty = typeof(T).GetProperty("ResourceType");
            if (resourceTypeProperty?.GetValue(resource) is string resourceType)
                return resourceType;
            
            // 預設使用類型名稱
            return typeof(T).Name.ToLowerInvariant();
        }

        private static string? ExtractIdFromLocation(string? location)
        {
            if (string.IsNullOrEmpty(location))
                return null;
            
            var parts = location.Split('/');
            return parts.Length > 0 ? parts[^1] : null;
        }

        private static string? ExtractVersionId(HttpResponseHeaders headers)
        {
            // 從 ETag 或其他標頭提取版本 ID
            return headers.ETag?.Tag?.Trim('"');
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }

    /// <summary>
    /// 搜尋參數
    /// </summary>
    public class SearchParameters
    {
        private readonly Dictionary<string, string> _parameters = new();

        public SearchParameters Add(string name, string value)
        {
            _parameters[name] = value;
            return this;
        }

        public string ToQueryString()
        {
            return string.Join("&", _parameters.Select(p => $"{p.Key}={Uri.EscapeDataString(p.Value)}"));
        }
    }

    /// <summary>
    /// 搜尋結果
    /// </summary>
    public class SearchResult<T>
    {
        public List<T> Entry { get; set; } = new();
        public int Total { get; set; }
        public string? NextLink { get; set; }
    }

    /// <summary>
    /// 建立結果
    /// </summary>
    public class CreateResult
    {
        public string? Id { get; set; }
        public string? Location { get; set; }
    }

    /// <summary>
    /// 更新結果
    /// </summary>
    public class UpdateResult
    {
        public string Id { get; set; } = string.Empty;
        public string? VersionId { get; set; }
    }

    /// <summary>
    /// 刪除結果
    /// </summary>
    public class DeleteResult
    {
        public string Id { get; set; } = string.Empty;
        public bool Success { get; set; }
    }

    /// <summary>
    /// 批次請求
    /// </summary>
    public class BatchRequest
    {
        public string ResourceType { get; set; } = "Bundle";
        public string Type { get; set; } = "batch";
        public List<BatchEntry> Entry { get; set; } = new();
    }

    /// <summary>
    /// 批次項目
    /// </summary>
    public class BatchEntry
    {
        public BatchRequest? Request { get; set; }
        public object? Resource { get; set; }
    }

    /// <summary>
    /// 批次結果
    /// </summary>
    public class BatchResult
    {
        public string ResourceType { get; set; } = "Bundle";
        public string Type { get; set; } = "batch-response";
        public List<BatchResponseEntry> Entry { get; set; } = new();
    }

    /// <summary>
    /// 批次回應項目
    /// </summary>
    public class BatchResponseEntry
    {
        public BatchResponse? Response { get; set; }
        public object? Resource { get; set; }
    }

    /// <summary>
    /// 批次回應
    /// </summary>
    public class BatchResponse
    {
        public string Status { get; set; } = string.Empty;
        public string? Location { get; set; }
        public string? Etag { get; set; }
        public string? LastModified { get; set; }
    }
} 