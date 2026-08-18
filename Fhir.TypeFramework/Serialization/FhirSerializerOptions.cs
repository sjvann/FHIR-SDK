namespace Fhir.TypeFramework.Serialization;

/// <summary>JSON／XML 解析時對未知元素與格式錯誤的處理。</summary>
public enum FhirSerializationHandling
{
    /// <summary>未知非 companion 元素擲回 <see cref="FhirSerializationException"/>。</summary>
    Strict,

    /// <summary>未知元素進入 <see cref="Fhir.TypeFramework.Bases.Base.Overflow"/> 並可 round-trip。</summary>
    Lenient
}

/// <summary>序列化／反序列化選項。既有無參數 API 維持 Lenient，以免官方 fixture 中的額外元素中斷既有測試。</summary>
public sealed class FhirSerializerOptions
{
    public static FhirSerializerOptions Strict { get; } = new() { Handling = FhirSerializationHandling.Strict };

    public static FhirSerializerOptions Lenient { get; } = new() { Handling = FhirSerializationHandling.Lenient };

    public FhirSerializationHandling Handling { get; init; } = FhirSerializationHandling.Strict;

    public bool WriteIndented { get; init; } = true;
}
