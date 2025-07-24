using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Fhir.Support.Base;

/// <summary>
/// 簡化的 FHIR 元素基礎類別
/// </summary>
public abstract class SimpleElement
{
    /// <summary>
    /// 元素 ID
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// 擴展
    /// </summary>
    [JsonPropertyName("extension")]
    public List<SimpleExtension>? Extension { get; set; }

    /// <summary>
    /// 驗證
    /// </summary>
    public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        return Enumerable.Empty<ValidationResult>();
    }
}

/// <summary>
/// 簡化的 FHIR 擴展類別
/// </summary>
public class SimpleExtension : SimpleElement
{
    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }
}

/// <summary>
/// 簡化的 FHIR 原始型別基礎類別
/// </summary>
/// <typeparam name="T">原生 C# 型別</typeparam>
public abstract class SimplePrimitiveType<T> : SimpleElement
{
    /// <summary>
    /// 實際值
    /// </summary>
    [JsonPropertyName("value")]
    public T? Value { get; set; }

    /// <summary>
    /// 轉換為字串
    /// </summary>
    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }
}

/// <summary>
/// 簡化的 FHIR 複雜型別基礎類別
/// </summary>
public abstract class SimpleComplexType : SimpleElement
{
    /// <summary>
    /// 從 JSON 解析
    /// </summary>
    public virtual void ParseFromJson(JsonNode? jsonNode)
    {
        if (jsonNode is JsonObject jsonObject)
        {
            if (jsonObject.TryGetPropertyValue("id", out var idNode))
                Id = idNode?.ToString();

            if (jsonObject.TryGetPropertyValue("extension", out var extensionNode))
            {
                // 簡化的擴展解析
                Extension = new List<SimpleExtension>();
            }
        }
    }
}

/// <summary>
/// 簡化的 FHIR BackboneElement 基礎類別
/// </summary>
public abstract class SimpleBackboneElement : SimpleComplexType
{
    /// <summary>
    /// 修飾符擴展
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<SimpleExtension>? ModifierExtension { get; set; }
}

/// <summary>
/// 簡化的 FHIR 資源基礎類別
/// </summary>
public abstract class SimpleResource : SimpleComplexType
{
    /// <summary>
    /// 資源類型
    /// </summary>
    [JsonPropertyName("resourceType")]
    public abstract string ResourceType { get; }

    /// <summary>
    /// Meta 資料
    /// </summary>
    [JsonPropertyName("meta")]
    public SimpleMeta? Meta { get; set; }

    /// <summary>
    /// 隱含規則
    /// </summary>
    [JsonPropertyName("implicitRules")]
    public string? ImplicitRules { get; set; }

    /// <summary>
    /// 語言
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
}

/// <summary>
/// 簡化的 FHIR DomainResource 基礎類別
/// </summary>
public abstract class SimpleDomainResource : SimpleResource
{
    /// <summary>
    /// 敘述
    /// </summary>
    [JsonPropertyName("text")]
    public SimpleNarrative? Text { get; set; }

    /// <summary>
    /// 包含的資源
    /// </summary>
    [JsonPropertyName("contained")]
    public List<SimpleResource>? Contained { get; set; }

    /// <summary>
    /// 修飾符擴展
    /// </summary>
    [JsonPropertyName("modifierExtension")]
    public List<SimpleExtension>? ModifierExtension { get; set; }
}

/// <summary>
/// 簡化的 FHIR Meta 類別
/// </summary>
public class SimpleMeta : SimpleElement
{
    /// <summary>
    /// 版本 ID
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; set; }

    /// <summary>
    /// 最後更新時間
    /// </summary>
    [JsonPropertyName("lastUpdated")]
    public string? LastUpdated { get; set; }

    /// <summary>
    /// 來源
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// 標籤
    /// </summary>
    [JsonPropertyName("tag")]
    public List<SimpleCoding>? Tag { get; set; }

    /// <summary>
    /// 安全標籤
    /// </summary>
    [JsonPropertyName("security")]
    public List<SimpleCoding>? Security { get; set; }

    /// <summary>
    /// 設定檔
    /// </summary>
    [JsonPropertyName("profile")]
    public List<string>? Profile { get; set; }
}

/// <summary>
/// 簡化的 FHIR Narrative 類別
/// </summary>
public class SimpleNarrative : SimpleElement
{
    /// <summary>
    /// 狀態
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// 內容
    /// </summary>
    [JsonPropertyName("div")]
    public string? Div { get; set; }
}

/// <summary>
/// 簡化的 FHIR Coding 類別
/// </summary>
public class SimpleCoding : SimpleElement
{
    /// <summary>
    /// 系統
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// 版本
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 顯示
    /// </summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>
    /// 使用者選擇
    /// </summary>
    [JsonPropertyName("userSelected")]
    public bool? UserSelected { get; set; }
}

/// <summary>
/// 簡化的 FHIR Identifier 類別
/// </summary>
public class SimpleIdentifier : SimpleElement
{
    /// <summary>
    /// 使用
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// 類型
    /// </summary>
    [JsonPropertyName("type")]
    public SimpleCodeableConcept? Type { get; set; }

    /// <summary>
    /// 系統
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// 期間
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }

    /// <summary>
    /// 分配者
    /// </summary>
    [JsonPropertyName("assigner")]
    public SimpleReference? Assigner { get; set; }
}

/// <summary>
/// 簡化的 FHIR CodeableConcept 類別
/// </summary>
public class SimpleCodeableConcept : SimpleElement
{
    /// <summary>
    /// 編碼
    /// </summary>
    [JsonPropertyName("coding")]
    public List<SimpleCoding>? Coding { get; set; }

    /// <summary>
    /// 文字
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// 簡化的 FHIR Period 類別
/// </summary>
public class SimplePeriod : SimpleElement
{
    /// <summary>
    /// 開始
    /// </summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    /// <summary>
    /// 結束
    /// </summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }
}

/// <summary>
/// 簡化的 FHIR Reference 類別（基礎版本，不依賴具體資源）
/// </summary>
public class SimpleReference : SimpleElement
{
    /// <summary>
    /// 參考
    /// </summary>
    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    /// <summary>
    /// 類型
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 識別碼
    /// </summary>
    [JsonPropertyName("identifier")]
    public SimpleIdentifier? Identifier { get; set; }

    /// <summary>
    /// 顯示
    /// </summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }
}

/// <summary>
/// 簡化的 FHIR Signature 類別
/// </summary>
public class SimpleSignature : SimpleElement
{
    /// <summary>
    /// 類型
    /// </summary>
    [JsonPropertyName("type")]
    public List<SimpleCoding>? Type { get; set; }

    /// <summary>
    /// 何時
    /// </summary>
    [JsonPropertyName("when")]
    public string? When { get; set; }

    /// <summary>
    /// 誰
    /// </summary>
    [JsonPropertyName("who")]
    public SimpleReference? Who { get; set; }

    /// <summary>
    /// 代表
    /// </summary>
    [JsonPropertyName("onBehalfOf")]
    public SimpleReference? OnBehalfOf { get; set; }

    /// <summary>
    /// 目標格式
    /// </summary>
    [JsonPropertyName("targetFormat")]
    public string? TargetFormat { get; set; }

    /// <summary>
    /// 簽名格式
    /// </summary>
    [JsonPropertyName("sigFormat")]
    public string? SigFormat { get; set; }

    /// <summary>
    /// 資料
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition 類別
/// </summary>
public class SimpleElementDefinition : SimpleElement
{
    /// <summary>
    /// 路徑
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// 表示
    /// </summary>
    [JsonPropertyName("representation")]
    public List<string>? Representation { get; set; }

    /// <summary>
    /// 簡短
    /// </summary>
    [JsonPropertyName("short")]
    public string? Short { get; set; }

    /// <summary>
    /// 定義
    /// </summary>
    [JsonPropertyName("definition")]
    public string? Definition { get; set; }

    /// <summary>
    /// 註解
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// 要求
    /// </summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary>
    /// 別名
    /// </summary>
    [JsonPropertyName("alias")]
    public List<string>? Alias { get; set; }

    /// <summary>
    /// 最小值
    /// </summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }

    /// <summary>
    /// 最大值
    /// </summary>
    [JsonPropertyName("max")]
    public string? Max { get; set; }

    /// <summary>
    /// 基礎
    /// </summary>
    [JsonPropertyName("base")]
    public SimpleElementDefinitionBase? Base { get; set; }

    /// <summary>
    /// 內容參考
    /// </summary>
    [JsonPropertyName("contentReference")]
    public string? ContentReference { get; set; }

    /// <summary>
    /// 類型
    /// </summary>
    [JsonPropertyName("type")]
    public List<SimpleElementDefinitionType>? Type { get; set; }

    /// <summary>
    /// 預設值
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public object? DefaultValue { get; set; }

    /// <summary>
    /// 意義
    /// </summary>
    [JsonPropertyName("meaningWhenMissing")]
    public string? MeaningWhenMissing { get; set; }

    /// <summary>
    /// 順序意義
    /// </summary>
    [JsonPropertyName("orderMeaning")]
    public string? OrderMeaning { get; set; }

    /// <summary>
    /// 固定
    /// </summary>
    [JsonPropertyName("fixed")]
    public object? Fixed { get; set; }

    /// <summary>
    /// 模式
    /// </summary>
    [JsonPropertyName("pattern")]
    public object? Pattern { get; set; }

    /// <summary>
    /// 範例
    /// </summary>
    [JsonPropertyName("example")]
    public List<SimpleElementDefinitionExample>? Example { get; set; }

    /// <summary>
    /// 最小值值
    /// </summary>
    [JsonPropertyName("minValue")]
    public object? MinValue { get; set; }

    /// <summary>
    /// 最大值值
    /// </summary>
    [JsonPropertyName("maxValue")]
    public object? MaxValue { get; set; }

    /// <summary>
    /// 最大長度
    /// </summary>
    [JsonPropertyName("maxLength")]
    public int? MaxLength { get; set; }

    /// <summary>
    /// 條件
    /// </summary>
    [JsonPropertyName("condition")]
    public List<string>? Condition { get; set; }

    /// <summary>
    /// 約束
    /// </summary>
    [JsonPropertyName("constraint")]
    public List<SimpleElementDefinitionConstraint>? Constraint { get; set; }

    /// <summary>
    /// 必須支援
    /// </summary>
    [JsonPropertyName("mustSupport")]
    public bool? MustSupport { get; set; }

    /// <summary>
    /// 是否修飾符
    /// </summary>
    [JsonPropertyName("isModifier")]
    public bool? IsModifier { get; set; }

    /// <summary>
    /// 是否摘要
    /// </summary>
    [JsonPropertyName("isSummary")]
    public bool? IsSummary { get; set; }

    /// <summary>
    /// 綁定
    /// </summary>
    [JsonPropertyName("binding")]
    public SimpleElementDefinitionBinding? Binding { get; set; }

    /// <summary>
    /// 對應
    /// </summary>
    [JsonPropertyName("mapping")]
    public List<SimpleElementDefinitionMapping>? Mapping { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Base 類別
/// </summary>
public class SimpleElementDefinitionBase : SimpleElement
{
    /// <summary>
    /// 路徑
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// 最小值
    /// </summary>
    [JsonPropertyName("min")]
    public int? Min { get; set; }

    /// <summary>
    /// 最大值
    /// </summary>
    [JsonPropertyName("max")]
    public string? Max { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Type 類別
/// </summary>
public class SimpleElementDefinitionType : SimpleElement
{
    /// <summary>
    /// 代碼
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// 設定檔
    /// </summary>
    [JsonPropertyName("profile")]
    public List<string>? Profile { get; set; }

    /// <summary>
    /// 目標設定檔
    /// </summary>
    [JsonPropertyName("targetProfile")]
    public List<string>? TargetProfile { get; set; }

    /// <summary>
    /// 聚合
    /// </summary>
    [JsonPropertyName("aggregation")]
    public List<string>? Aggregation { get; set; }

    /// <summary>
    /// 版本
    /// </summary>
    [JsonPropertyName("versioning")]
    public string? Versioning { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Example 類別
/// </summary>
public class SimpleElementDefinitionExample : SimpleElement
{
    /// <summary>
    /// 標籤
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public object? Value { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Constraint 類別
/// </summary>
public class SimpleElementDefinitionConstraint : SimpleElement
{
    /// <summary>
    /// 金鑰
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// 要求
    /// </summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary>
    /// 嚴重性
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// 人類
    /// </summary>
    [JsonPropertyName("human")]
    public string? Human { get; set; }

    /// <summary>
    /// 表達式
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>
    /// XPath
    /// </summary>
    [JsonPropertyName("xpath")]
    public string? Xpath { get; set; }

    /// <summary>
    /// 來源
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Binding 類別
/// </summary>
public class SimpleElementDefinitionBinding : SimpleElement
{
    /// <summary>
    /// 強度
    /// </summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// 值集
    /// </summary>
    [JsonPropertyName("valueSet")]
    public string? ValueSet { get; set; }

    /// <summary>
    /// 擴展
    /// </summary>
    [JsonPropertyName("additional")]
    public List<SimpleElementDefinitionBindingAdditional>? Additional { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Binding Additional 類別
/// </summary>
public class SimpleElementDefinitionBindingAdditional : SimpleElement
{
    /// <summary>
    /// 用途
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// 值集
    /// </summary>
    [JsonPropertyName("valueSet")]
    public string? ValueSet { get; set; }

    /// <summary>
    /// 文件
    /// </summary>
    [JsonPropertyName("documentation")]
    public string? Documentation { get; set; }

    /// <summary>
    /// 簡短定義
    /// </summary>
    [JsonPropertyName("shortDoco")]
    public string? ShortDoco { get; set; }

    /// <summary>
    /// 用法
    /// </summary>
    [JsonPropertyName("usage")]
    public List<string>? Usage { get; set; }
}

/// <summary>
/// 簡化的 FHIR ElementDefinition Mapping 類別
/// </summary>
public class SimpleElementDefinitionMapping : SimpleElement
{
    /// <summary>
    /// 身分
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// 語言
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 對應
    /// </summary>
    [JsonPropertyName("map")]
    public string? Map { get; set; }

    /// <summary>
    /// 註解
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }
}

/// <summary>
/// 簡化的 FHIR HumanName 類別
/// </summary>
public class SimpleHumanName : SimpleElement
{
    /// <summary>
    /// 使用
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// 文字
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// 家族
    /// </summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// 給定
    /// </summary>
    [JsonPropertyName("given")]
    public List<string>? Given { get; set; }

    /// <summary>
    /// 前綴
    /// </summary>
    [JsonPropertyName("prefix")]
    public List<string>? Prefix { get; set; }

    /// <summary>
    /// 後綴
    /// </summary>
    [JsonPropertyName("suffix")]
    public List<string>? Suffix { get; set; }

    /// <summary>
    /// 期間
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }
}

/// <summary>
/// 簡化的 FHIR ContactPoint 類別
/// </summary>
public class SimpleContactPoint : SimpleElement
{
    /// <summary>
    /// 系統
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// 使用
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// 排名
    /// </summary>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }

    /// <summary>
    /// 期間
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }
}

/// <summary>
/// 簡化的 FHIR Address 類別
/// </summary>
public class SimpleAddress : SimpleElement
{
    /// <summary>
    /// 使用
    /// </summary>
    [JsonPropertyName("use")]
    public string? Use { get; set; }

    /// <summary>
    /// 類型
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// 文字
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>
    /// 行
    /// </summary>
    [JsonPropertyName("line")]
    public List<string>? Line { get; set; }

    /// <summary>
    /// 城市
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// 區
    /// </summary>
    [JsonPropertyName("district")]
    public string? District { get; set; }

    /// <summary>
    /// 州
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// 郵遞區號
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// 國家
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// 期間
    /// </summary>
    [JsonPropertyName("period")]
    public SimplePeriod? Period { get; set; }
}

/// <summary>
/// 簡化的 FHIR Quantity 類別
/// </summary>
public class SimpleQuantity : SimpleElement
{
    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }

    /// <summary>
    /// 比較器
    /// </summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>
    /// 單位
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>
    /// 系統
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// 簡化的 FHIR Range 類別
/// </summary>
public class SimpleRange : SimpleElement
{
    /// <summary>
    /// 低
    /// </summary>
    [JsonPropertyName("low")]
    public SimpleQuantity? Low { get; set; }

    /// <summary>
    /// 高
    /// </summary>
    [JsonPropertyName("high")]
    public SimpleQuantity? High { get; set; }
}

/// <summary>
/// 簡化的 FHIR Ratio 類別
/// </summary>
public class SimpleRatio : SimpleElement
{
    /// <summary>
    /// 分子
    /// </summary>
    [JsonPropertyName("numerator")]
    public SimpleQuantity? Numerator { get; set; }

    /// <summary>
    /// 分母
    /// </summary>
    [JsonPropertyName("denominator")]
    public SimpleQuantity? Denominator { get; set; }
}

/// <summary>
/// 簡化的 FHIR SampledData 類別
/// </summary>
public class SimpleSampledData : SimpleElement
{
    /// <summary>
    /// 原點
    /// </summary>
    [JsonPropertyName("origin")]
    public SimpleQuantity? Origin { get; set; }

    /// <summary>
    /// 期間
    /// </summary>
    [JsonPropertyName("period")]
    public decimal? Period { get; set; }

    /// <summary>
    /// 因數
    /// </summary>
    [JsonPropertyName("factor")]
    public decimal? Factor { get; set; }

    /// <summary>
    /// 下限
    /// </summary>
    [JsonPropertyName("lowerLimit")]
    public decimal? LowerLimit { get; set; }

    /// <summary>
    /// 上限
    /// </summary>
    [JsonPropertyName("upperLimit")]
    public decimal? UpperLimit { get; set; }

    /// <summary>
    /// 維度
    /// </summary>
    [JsonPropertyName("dimensions")]
    public int? Dimensions { get; set; }

    /// <summary>
    /// 資料
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}

/// <summary>
/// 簡化的 FHIR Duration 類別
/// </summary>
public class SimpleDuration : SimpleElement
{
    /// <summary>
    /// 值
    /// </summary>
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }

    /// <summary>
    /// 比較器
    /// </summary>
    [JsonPropertyName("comparator")]
    public string? Comparator { get; set; }

    /// <summary>
    /// 單位
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>
    /// 系統
    /// </summary>
    [JsonPropertyName("system")]
    public string? System { get; set; }

    /// <summary>
    /// 代碼
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}

/// <summary>
/// 簡化的 FHIR Annotation 類別
/// </summary>
public class SimpleAnnotation : SimpleElement
{
    /// <summary>
    /// 作者參考
    /// </summary>
    [JsonPropertyName("authorReference")]
    public SimpleReference? AuthorReference { get; set; }

    /// <summary>
    /// 作者字串
    /// </summary>
    [JsonPropertyName("authorString")]
    public string? AuthorString { get; set; }

    /// <summary>
    /// 時間
    /// </summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

    /// <summary>
    /// 文字
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// 簡化的 FHIR Attachment 類別
/// </summary>
public class SimpleAttachment : SimpleElement
{
    /// <summary>
    /// 內容類型
    /// </summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>
    /// 語言
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// 資料
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// URL
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// 大小
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }

    /// <summary>
    /// 雜湊
    /// </summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    [JsonPropertyName("creation")]
    public string? Creation { get; set; }
} 