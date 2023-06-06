using Core.ExtensionImp;
using System.Text.Json.Nodes;

namespace DataTypeService.Primitive
{
    public static partial class PrimaryHelper
    {
        #region Primary Data Type
        #region For String

        public static FhirString? ToFhirString(this string? value)
        {
            return value != null ? new FhirString(value) : null;
        }
        public static FhirBase64Binary? ToFhirBase64Binary(this string? value)
        {
            return value != null ? new FhirBase64Binary(value.Based64Encode()) : null;
        }
        public static FhirCanonical? ToFhirCanonical(this string? value)
        {
            return value != null ? new FhirCanonical(value) : null;
        }
        public static FhirCode? ToFhirCode(this string? value)
        {
            return value != null ? new FhirCode(value) : null;
        }
        public static FhirId? ToFhirId(this string? value)
        {
            return value != null ? new FhirId(value) : null;
        }
        public static FhirMarkdown? ToFhirMarkdown(this string? value)
        {
            return value != null ? new FhirMarkdown(value) : null;
        }
        public static FhirOid? ToFhirOid(this string? value)
        {
            return value != null ? new FhirOid(value) : null;
        }
        public static FhirTime? ToFhirTime(this string? value)
        {
            return value != null ? new FhirTime(value) : null;
        }
        public static FhirUri? ToFhirUri(this string? value)
        {
            return value != null ? new FhirUri(value) : null;
        }
        public static FhirUrl? ToFhirUrl(this string? value)
        {
            return value != null ? new FhirUrl(value) : null;
        }
        public static FhirXHtml? ToFhirXHtml(this string? value)
        {
            return value != null ? new FhirXHtml(value) : null;
        }
        #endregion
        #region For Number
        public static FhirInteger64? ToFhirInt64(this long? value)
        {
            return value != null ? new FhirInteger64(value) : null;
        }
        public static FhirBoolean? ToFhirBoolean(this bool? value)
        {
            return value != null ? new FhirBoolean(value) : null;
        }
        public static FhirDecimal? ToFhirDecimal(this decimal? value)
        {
            return value != null ? new FhirDecimal(value) : null;
        }
        public static FhirInteger? ToFhirInteger(this int? value)
        {
            return value != null ? new FhirInteger(value) : null;
        }
        public static FhirPositiveInt? ToFhirPositiveInt(this int? value)
        {
            return value != null ? new FhirPositiveInt(value) : null;
        }
        public static FhirUnsignedInt? ToFhirPositiveInt(this uint? value)
        {
            return value != null ? new FhirUnsignedInt(value) : null;
        }
        #endregion
        #region For DateTime
        public static FhirDate? ToFhirDate(this DateTime value)
        {
            if (value.Year <= 1900 || value.Month <= 0 || value.Day <= 0)
            { return null; }
            else
            {
                return new FhirDate(value);
            }

        }
        public static FhirDateTime? ToFhirDateTime(this DateTime value)
        {
            if (value.Year <= 1900 || value.Month <= 0 || value.Day <= 0)
            { return null; }
            else
            {
                return new FhirDateTime(value);
            }


        }
        public static FhirInstant? ToFhirInstant(this DateTime value)
        {
            if (value.Year <= 1900 || value.Month <= 0 || value.Day <= 0)
            { return null; }
            else
            {
                return new FhirInstant(value);
            }


        }
        #endregion
        #endregion
      

    }
}
