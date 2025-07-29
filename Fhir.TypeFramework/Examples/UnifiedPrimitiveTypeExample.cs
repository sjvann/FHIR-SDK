using Fhir.TypeFramework.Bases;
using Fhir.TypeFramework.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fhir.TypeFramework.Examples;

/// <summary>
/// 使用統一基礎類別的範例
/// 展示如何用 UnifiedPrimitiveTypeBase 取代所有現有的基礎類別
/// </summary>
public static class UnifiedPrimitiveTypeExample
{
    /// <summary>
    /// 字串型別範例 - 使用 UnifiedPrimitiveTypeBase&lt;string&gt;
    /// </summary>
    public class FhirStringExample : UnifiedPrimitiveTypeBase<string>
    {
        /// <summary>
        /// Gets or sets the string value.
        /// </summary>
        [JsonIgnore]
        public string? StringValue { get => Value; set => Value = value; }

        /// <summary>
        /// Initializes a new instance of the FhirStringExample class.
        /// </summary>
        public FhirStringExample() { }

        /// <summary>
        /// Initializes a new instance of the FhirStringExample class with the specified value.
        /// </summary>
        /// <param name="value">The string value.</param>
        public FhirStringExample(string? value) : base(value) { }

        /// <summary>
        /// Implicitly converts a string to a FhirStringExample.
        /// </summary>
        /// <param name="value">The string value to convert.</param>
        /// <returns>A FhirStringExample instance, or null if the value is null.</returns>
        public static implicit operator FhirStringExample?(string? value)
        {
            return CreateFromString<FhirStringExample>(value);
        }

        /// <summary>
        /// Implicitly converts a FhirStringExample to a string.
        /// </summary>
        /// <param name="fhirString">The FhirStringExample to convert.</param>
        /// <returns>The string value, or null if the FhirStringExample is null.</returns>
        public static implicit operator string?(FhirStringExample? fhirString)
        {
            return GetStringValue<FhirStringExample>(fhirString);
        }

        /// <summary>
        /// Parses a string value.
        /// </summary>
        /// <param name="value">The string to parse.</param>
        /// <returns>The parsed string value.</returns>
        protected override string? ParseValueFromString(string value)
        {
            return value;
        }

        /// <summary>
        /// Converts a value to string.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The string representation.</returns>
        protected override string? ValueToString(string? value)
        {
            return value;
        }

        /// <summary>
        /// Validates the string value.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        protected override bool ValidateValue(string value)
        {
            return ValidationFramework.ValidateStringByteSize(value, 1024 * 1024);
        }
    }

    /// <summary>
    /// 數值型別範例 - 使用 UnifiedPrimitiveTypeBase&lt;int&gt;
    /// </summary>
    public class FhirIntegerExample : UnifiedPrimitiveTypeBase<int>
    {
        /// <summary>
        /// Gets or sets the integer value.
        /// </summary>
        [JsonIgnore]
        public int? IntegerValue { get => Value; set => Value = value; }

        /// <summary>
        /// Initializes a new instance of the FhirIntegerExample class.
        /// </summary>
        public FhirIntegerExample() { }

        /// <summary>
        /// Initializes a new instance of the FhirIntegerExample class with the specified value.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public FhirIntegerExample(int? value) : base(value) { }

        /// <summary>
        /// Implicitly converts an int to a FhirIntegerExample.
        /// </summary>
        /// <param name="value">The int value to convert.</param>
        /// <returns>A FhirIntegerExample instance, or null if the value is null.</returns>
        public static implicit operator FhirIntegerExample?(int? value)
        {
            return CreateFromValue<FhirIntegerExample>(value);
        }

        /// <summary>
        /// Implicitly converts a FhirIntegerExample to an int.
        /// </summary>
        /// <param name="fhirInteger">The FhirIntegerExample to convert.</param>
        /// <returns>The int value, or null if the FhirIntegerExample is null.</returns>
        public static implicit operator int?(FhirIntegerExample? fhirInteger)
        {
            return GetValue<FhirIntegerExample>(fhirInteger);
        }

        /// <summary>
        /// Parses an integer value from string.
        /// </summary>
        /// <param name="value">The string to parse.</param>
        /// <returns>The parsed integer value.</returns>
        protected override int? ParseValueFromString(string value)
        {
            if (int.TryParse(value, out var result))
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// Converts an integer value to string.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The string representation.</returns>
        protected override string? ValueToString(int? value)
        {
            return value?.ToString();
        }

        /// <summary>
        /// Validates the integer value.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        protected override bool ValidateValue(int value)
        {
            return true; // 整數沒有額外驗證規則
        }
    }

    /// <summary>
    /// 布林型別範例 - 使用 UnifiedPrimitiveTypeBase&lt;bool&gt;
    /// </summary>
    public class FhirBooleanExample : UnifiedPrimitiveTypeBase<bool>
    {
        /// <summary>
        /// Gets or sets the boolean value.
        /// </summary>
        [JsonIgnore]
        public bool? BooleanValue { get => Value; set => Value = value; }

        /// <summary>
        /// Initializes a new instance of the FhirBooleanExample class.
        /// </summary>
        public FhirBooleanExample() { }

        /// <summary>
        /// Initializes a new instance of the FhirBooleanExample class with the specified value.
        /// </summary>
        /// <param name="value">The boolean value.</param>
        public FhirBooleanExample(bool? value) : base(value) { }

        /// <summary>
        /// Implicitly converts a bool to a FhirBooleanExample.
        /// </summary>
        /// <param name="value">The bool value to convert.</param>
        /// <returns>A FhirBooleanExample instance, or null if the value is null.</returns>
        public static implicit operator FhirBooleanExample?(bool? value)
        {
            return CreateFromValue<FhirBooleanExample>(value);
        }

        /// <summary>
        /// Implicitly converts a FhirBooleanExample to a bool.
        /// </summary>
        /// <param name="fhirBoolean">The FhirBooleanExample to convert.</param>
        /// <returns>The bool value, or null if the FhirBooleanExample is null.</returns>
        public static implicit operator bool?(FhirBooleanExample? fhirBoolean)
        {
            return GetValue<FhirBooleanExample>(fhirBoolean);
        }

        /// <summary>
        /// Parses a boolean value from string.
        /// </summary>
        /// <param name="value">The string to parse.</param>
        /// <returns>The parsed boolean value.</returns>
        protected override bool? ParseValueFromString(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            
            return value.ToLowerInvariant() switch
            {
                "true" or "1" or "yes" or "on" => true,
                "false" or "0" or "no" or "off" => false,
                _ => null
            };
        }

        /// <summary>
        /// Converts a boolean value to string.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The string representation.</returns>
        protected override string? ValueToString(bool? value)
        {
            return value?.ToString().ToLowerInvariant();
        }

        /// <summary>
        /// Validates the boolean value.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        protected override bool ValidateValue(bool value)
        {
            return true; // 布林值沒有額外驗證規則
        }
    }
} 