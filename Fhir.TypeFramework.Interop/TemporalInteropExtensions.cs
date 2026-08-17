using System.Globalization;
using Fhir.TypeFramework.DataTypes;
using Fhir.TypeFramework.DataTypes.PrimitiveTypes;

namespace Fhir.TypeFramework.Interop;

/// <summary>.NET 日期時間型別轉 FHIR temporal primitive 的擴充方法。</summary>
public static class TemporalInteropExtensions
{
    /// <summary>將 <see cref="DateTime"/> 轉為 <see cref="FhirDate"/>；預設以不變文化輸出完整日期字串。</summary>
    public static FhirDate ToFhirDate(this DateTime value, bool preservePartialDate = false)
        => preservePartialDate
            ? new FhirDate(value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
            : new FhirDate(value);

    public static FhirDate? ToFhirDate(this DateTime? value, bool preservePartialDate = false)
        => value is null ? null : value.Value.ToFhirDate(preservePartialDate);

    /// <summary>以 lexical 字串建立 <see cref="FhirDate"/>（例如 <c>1997</c>、<c>1997-06</c>）。</summary>
    public static FhirDate ToFhirDateFromLexical(this string lexical)
        => new(lexical);

    public static FhirDateTime ToFhirDateTime(this DateTime value)
        => new FhirDateTime(value);

    public static FhirDateTime? ToFhirDateTime(this DateTime? value)
        => value is null ? null : value.Value.ToFhirDateTime();

    public static FhirDateTime ToFhirDateTimeFromLexical(this string lexical)
        => new(lexical);

    public static FhirInstant ToFhirInstant(this DateTimeOffset value)
        => new FhirInstant(value.UtcDateTime);

    public static FhirInstant? ToFhirInstant(this DateTimeOffset? value)
        => value is null ? null : value.Value.ToFhirInstant();

    public static FhirTime ToFhirTime(this TimeSpan value)
        => new FhirTime(value);

    public static FhirTime? ToFhirTime(this TimeSpan? value)
        => value is null ? null : value.Value.ToFhirTime();

    public static FhirDate ToFhirDate(this DateOnly value)
        => new FhirDate(value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

    public static FhirDate? ToFhirDate(this DateOnly? value)
        => value is null ? null : value.Value.ToFhirDate();

    public static FhirTime ToFhirTime(this TimeOnly value)
        => new FhirTime(value.ToString("HH:mm:ss", CultureInfo.InvariantCulture));
}
