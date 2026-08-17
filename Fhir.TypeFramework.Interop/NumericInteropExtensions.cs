using Fhir.TypeFramework.DataTypes;

namespace Fhir.TypeFramework.Interop;

/// <summary>數值與布林轉 FHIR primitive 的擴充方法。</summary>
public static class NumericInteropExtensions
{
    public static FhirInteger ToFhirInteger(this int value) => new(value);
    public static FhirInteger? ToFhirInteger(this int? value) => value is null ? null : new FhirInteger(value.Value);

    public static FhirInteger64 ToFhirInteger64(this long value) => new(value);
    public static FhirInteger64? ToFhirInteger64(this long? value) => value is null ? null : new FhirInteger64(value.Value);

    public static FhirDecimal ToFhirDecimal(this decimal value) => new(value);
    public static FhirDecimal? ToFhirDecimal(this decimal? value) => value is null ? null : new FhirDecimal(value.Value);

    public static FhirPositiveInt ToFhirPositiveInt(this int value) => new(value);
    public static FhirUnsignedInt ToFhirUnsignedInt(this uint value) => new(value);

    public static FhirBoolean ToFhirBoolean(this bool value) => new(value);
    public static FhirBoolean? ToFhirBoolean(this bool? value) => value is null ? null : new FhirBoolean(value.Value);
}
