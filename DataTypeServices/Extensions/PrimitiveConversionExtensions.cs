using System;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace DataTypeServices.Extensions
{
    /// <summary>
    /// C# 基本型別到 FHIR Primitive 型別的轉換擴充方法。
    /// 保持單純同步，不含任何 I/O 或非同步邏輯。
    /// </summary>
    public static class PrimitiveConversionExtensions
    {
        // string
        public static FhirString ToFhirString(this string value) => new FhirString(value);
        public static FhirCode ToFhirCode(this string value) => new FhirCode(value);
        public static FhirUri ToFhirUri(this string value) => new FhirUri(value);

        // bool / 數值
        public static FhirBoolean ToFhirBoolean(this bool value) => new FhirBoolean(value);
        public static FhirInteger ToFhirInteger(this int value) => new FhirInteger(value);
        public static FhirDecimal ToFhirDecimal(this decimal value) => new FhirDecimal(value);

        // Date/Time
        public static FhirDateTime ToFhirDateTime(this DateTime value) => new FhirDateTime(value);
        public static FhirDate ToFhirDate(this DateTime value) => new FhirDate(value.ToString("yyyy-MM-dd"));

        // Uri / Guid
        public static FhirUri ToFhirUri(this Uri value) => new FhirUri(value.ToString());
        public static FhirUuid ToFhirUuid(this Guid value) => FhirUuid.FromGuid(value);
    }
}

