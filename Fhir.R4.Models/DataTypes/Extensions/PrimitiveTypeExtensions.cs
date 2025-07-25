using Fhir.R4.Models.DataTypes;

namespace Fhir.R4.Models.Extensions;

/// <summary>
/// Extension methods for converting .NET primitive types to FHIR primitive types.
/// </summary>
/// <remarks>
/// These extension methods provide a fluent API for creating FHIR primitive types
/// from their corresponding .NET types, making the code more readable and expressive.
/// </remarks>
public static class PrimitiveTypeExtensions
{
    #region String Extensions

    /// <summary>
    /// Converts a string to a FhirString.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirString instance, or null if the value is null.</returns>
    public static FhirString? ToFhirString(this string? value)
    {
        return value == null ? null : new FhirString(value);
    }

    /// <summary>
    /// Converts a string to a FhirCode.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirCode instance, or null if the value is null.</returns>
    public static FhirCode? ToFhirCode(this string? value)
    {
        return value == null ? null : new FhirCode(value);
    }

    /// <summary>
    /// Converts a string to a FhirId.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirId instance, or null if the value is null.</returns>
    public static FhirId? ToFhirId(this string? value)
    {
        return value == null ? null : new FhirId(value);
    }

    /// <summary>
    /// Converts a string to a FhirUri.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUri instance, or null if the value is null.</returns>
    public static FhirUri? ToFhirUri(this string? value)
    {
        return value == null ? null : new FhirUri(value);
    }

    /// <summary>
    /// Converts a string to a FhirUrl.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUrl instance, or null if the value is null.</returns>
    public static FhirUrl? ToFhirUrl(this string? value)
    {
        return value == null ? null : new FhirUrl(value);
    }

    /// <summary>
    /// Converts a string to a FhirCanonical.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirCanonical instance, or null if the value is null.</returns>
    public static FhirCanonical? ToFhirCanonical(this string? value)
    {
        return value == null ? null : new FhirCanonical(value);
    }

    /// <summary>
    /// Converts a string to a FhirMarkdown.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirMarkdown instance, or null if the value is null.</returns>
    public static FhirMarkdown? ToFhirMarkdown(this string? value)
    {
        return value == null ? null : new FhirMarkdown(value);
    }

    /// <summary>
    /// Converts a string to a FhirOid.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirOid instance, or null if the value is null.</returns>
    public static FhirOid? ToFhirOid(this string? value)
    {
        return value == null ? null : new FhirOid(value);
    }

    /// <summary>
    /// Converts a string to a FhirUuid.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirUuid instance, or null if the value is null.</returns>
    public static FhirUuid? ToFhirUuid(this string? value)
    {
        return value == null ? null : new FhirUuid(value);
    }

    /// <summary>
    /// Converts a string to a FhirDate.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirDate instance, or null if the value is null.</returns>
    public static FhirDate? ToFhirDate(this string? value)
    {
        return value == null ? null : new FhirDate(value);
    }

    /// <summary>
    /// Converts a string to a FhirDateTime.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirDateTime instance, or null if the value is null.</returns>
    public static FhirDateTime? ToFhirDateTime(this string? value)
    {
        return value == null ? null : new FhirDateTime(value);
    }

    /// <summary>
    /// Converts a string to a FhirInstant.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirInstant instance, or null if the value is null.</returns>
    public static FhirInstant? ToFhirInstant(this string? value)
    {
        return value == null ? null : new FhirInstant(value);
    }

    /// <summary>
    /// Converts a string to a FhirTime.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    /// <returns>A FhirTime instance, or null if the value is null.</returns>
    public static FhirTime? ToFhirTime(this string? value)
    {
        return value == null ? null : new FhirTime(value);
    }

    #endregion

    #region Numeric Extensions

    /// <summary>
    /// Converts an integer to a FhirInteger.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirInteger instance.</returns>
    public static FhirInteger ToFhirInteger(this int value)
    {
        return new FhirInteger(value);
    }

    /// <summary>
    /// Converts a nullable integer to a FhirInteger.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirInteger instance, or null if the value is null.</returns>
    public static FhirInteger? ToFhirInteger(this int? value)
    {
        return value == null ? null : new FhirInteger(value);
    }

    /// <summary>
    /// Converts an integer to a FhirPositiveInt.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirPositiveInt instance.</returns>
    public static FhirPositiveInt ToFhirPositiveInt(this int value)
    {
        return new FhirPositiveInt(value);
    }

    /// <summary>
    /// Converts a nullable integer to a FhirPositiveInt.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirPositiveInt instance, or null if the value is null.</returns>
    public static FhirPositiveInt? ToFhirPositiveInt(this int? value)
    {
        return value == null ? null : new FhirPositiveInt(value);
    }

    /// <summary>
    /// Converts an integer to a FhirUnsignedInt.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirUnsignedInt instance.</returns>
    public static FhirUnsignedInt ToFhirUnsignedInt(this int value)
    {
        return new FhirUnsignedInt(value);
    }

    /// <summary>
    /// Converts a nullable integer to a FhirUnsignedInt.
    /// </summary>
    /// <param name="value">The integer value to convert.</param>
    /// <returns>A FhirUnsignedInt instance, or null if the value is null.</returns>
    public static FhirUnsignedInt? ToFhirUnsignedInt(this int? value)
    {
        return value == null ? null : new FhirUnsignedInt(value);
    }

    /// <summary>
    /// Converts a decimal to a FhirDecimal.
    /// </summary>
    /// <param name="value">The decimal value to convert.</param>
    /// <returns>A FhirDecimal instance.</returns>
    public static FhirDecimal ToFhirDecimal(this decimal value)
    {
        return new FhirDecimal(value);
    }

    /// <summary>
    /// Converts a nullable decimal to a FhirDecimal.
    /// </summary>
    /// <param name="value">The decimal value to convert.</param>
    /// <returns>A FhirDecimal instance, or null if the value is null.</returns>
    public static FhirDecimal? ToFhirDecimal(this decimal? value)
    {
        return value == null ? null : new FhirDecimal(value);
    }

    #endregion

    #region Boolean Extensions

    /// <summary>
    /// Converts a boolean to a FhirBoolean.
    /// </summary>
    /// <param name="value">The boolean value to convert.</param>
    /// <returns>A FhirBoolean instance.</returns>
    public static FhirBoolean ToFhirBoolean(this bool value)
    {
        return new FhirBoolean(value);
    }

    /// <summary>
    /// Converts a nullable boolean to a FhirBoolean.
    /// </summary>
    /// <param name="value">The boolean value to convert.</param>
    /// <returns>A FhirBoolean instance, or null if the value is null.</returns>
    public static FhirBoolean? ToFhirBoolean(this bool? value)
    {
        return value == null ? null : new FhirBoolean(value);
    }

    #endregion

    #region Binary Extensions

    /// <summary>
    /// Converts a byte array to a FhirBase64Binary.
    /// </summary>
    /// <param name="bytes">The byte array to convert.</param>
    /// <returns>A FhirBase64Binary instance, or null if the bytes are null.</returns>
    public static FhirBase64Binary? ToFhirBase64Binary(this byte[]? bytes)
    {
        return bytes == null ? null : new FhirBase64Binary(bytes);
    }

    #endregion

    #region DateTime Extensions

    /// <summary>
    /// Converts a TimeSpan to a FhirTime.
    /// </summary>
    /// <param name="timeSpan">The TimeSpan to convert.</param>
    /// <returns>A FhirTime instance.</returns>
    public static FhirTime ToFhirTime(this TimeSpan timeSpan)
    {
        return new FhirTime(timeSpan);
    }

    /// <summary>
    /// Converts a nullable TimeSpan to a FhirTime.
    /// </summary>
    /// <param name="timeSpan">The TimeSpan to convert.</param>
    /// <returns>A FhirTime instance, or null if the TimeSpan is null.</returns>
    public static FhirTime? ToFhirTime(this TimeSpan? timeSpan)
    {
        return timeSpan == null ? null : new FhirTime(timeSpan);
    }

    #endregion

    #region Guid Extensions

    /// <summary>
    /// Converts a Guid to a FhirUuid.
    /// </summary>
    /// <param name="guid">The Guid to convert.</param>
    /// <returns>A FhirUuid instance.</returns>
    public static FhirUuid ToFhirUuid(this Guid guid)
    {
        return new FhirUuid(guid);
    }

    /// <summary>
    /// Converts a nullable Guid to a FhirUuid.
    /// </summary>
    /// <param name="guid">The Guid to convert.</param>
    /// <returns>A FhirUuid instance, or null if the Guid is null.</returns>
    public static FhirUuid? ToFhirUuid(this Guid? guid)
    {
        return guid == null ? null : new FhirUuid(guid);
    }

    #endregion
}
