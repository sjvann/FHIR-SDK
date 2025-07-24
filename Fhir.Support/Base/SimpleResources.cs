using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.Support.Base;

/// <summary>
/// 簡化的 FHIR Bundle 類別
/// </summary>
public class SimpleBundle : SimpleResource
{
    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Bundle";

    /// <summary>
    /// 識別碼
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// 類型
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 時間戳記
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }

    /// <summary>
    /// 總數
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

    /// <summary>
    /// 連結
    /// </summary>
    [JsonPropertyName("link")]
    public List<SimpleBundleLink>? Link { get; set; }

    /// <summary>
    /// 項目
    /// </summary>
    [JsonPropertyName("entry")]
    public List<SimpleBundleEntry>? Entry { get; set; }

    /// <summary>
    /// 簽名
    /// </summary>
    [JsonPropertyName("signature")]
    public SimpleSignature? Signature { get; set; }
}

/// <summary>
/// 簡化的 FHIR Bundle Link 類別
/// </summary>
public class SimpleBundleLink : SimpleElement
{
    /// <summary>
    /// 關係
    /// </summary>
    [JsonPropertyName("relation")]
    public string? Relation { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// 簡化的 FHIR Bundle Entry 類別
/// </summary>
public class SimpleBundleEntry : SimpleElement
{
    /// <summary>
    /// 連結
    /// </summary>
    [JsonPropertyName("link")]
    public List<SimpleBundleLink>? Link { get; set; }

    /// <summary>
    /// 完整 URL
    /// </summary>
    [JsonPropertyName("fullUrl")]
    public string? FullUrl { get; set; }

    /// <summary>
    /// 資源
    /// </summary>
    [JsonPropertyName("resource")]
    public SimpleResource? Resource { get; set; }

    /// <summary>
    /// 搜尋
    /// </summary>
    [JsonPropertyName("search")]
    public SimpleBundleEntrySearch? Search { get; set; }

    /// <summary>
    /// 請求
    /// </summary>
    [JsonPropertyName("request")]
    public SimpleBundleEntryRequest? Request { get; set; }

    /// <summary>
    /// 回應
    /// </summary>
    [JsonPropertyName("response")]
    public SimpleBundleEntryResponse? Response { get; set; }
}

/// <summary>
/// 簡化的 FHIR Bundle Entry Search 類別
/// </summary>
public class SimpleBundleEntrySearch : SimpleElement
{
    /// <summary>
    /// 模式
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// 分數
    /// </summary>
    [JsonPropertyName("score")]
    public decimal? Score { get; set; }
}

/// <summary>
/// 簡化的 FHIR Bundle Entry Request 類別
/// </summary>
public class SimpleBundleEntryRequest : SimpleElement
{
    /// <summary>
    /// 方法
    /// </summary>
    [JsonPropertyName("method")]
    public string? Method { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// If-None-Match
    /// </summary>
    [JsonPropertyName("ifNoneMatch")]
    public string? IfNoneMatch { get; set; }

    /// <summary>
    /// If-Modified-Since
    /// </summary>
    [JsonPropertyName("ifModifiedSince")]
    public string? IfModifiedSince { get; set; }

    /// <summary>
    /// If-Match
    /// </summary>
    [JsonPropertyName("ifMatch")]
    public string? IfMatch { get; set; }

    /// <summary>
    /// If-None-Exist
    /// </summary>
    [JsonPropertyName("ifNoneExist")]
    public string? IfNoneExist { get; set; }
}

/// <summary>
/// 簡化的 FHIR Bundle Entry Response 類別
/// </summary>
public class SimpleBundleEntryResponse : SimpleElement
{
    /// <summary>
    /// 狀態
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// 位置
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// ETag
    /// </summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>
    /// 最後修改
    /// </summary>
    [JsonPropertyName("lastModified")]
    public string? LastModified { get; set; }

    /// <summary>
    /// 輸出
    /// </summary>
    [JsonPropertyName("outcome")]
    public SimpleResource? Outcome { get; set; }
}

/// <summary>
/// 簡化的 FHIR Parameters 類別
/// </summary>
public class SimpleParameters : SimpleResource
{
    /// <summary>
    /// 資源類型
    /// </summary>
    public override string ResourceType => "Parameters";

    /// <summary>
    /// 參數
    /// </summary>
    [JsonPropertyName("parameter")]
    public List<SimpleParametersParameter>? Parameter { get; set; }
}

/// <summary>
/// 簡化的 FHIR Parameters Parameter 類別
/// </summary>
public class SimpleParametersParameter : SimpleElement
{
    /// <summary>
    /// 名稱
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }

    /// <summary>
    /// 資源
    /// </summary>
    [JsonPropertyName("resource")]
    public SimpleResource? Resource { get; set; }

    /// <summary>
    /// 部分
    /// </summary>
    [JsonPropertyName("part")]
    public List<SimpleParametersParameter>? Part { get; set; }
} 