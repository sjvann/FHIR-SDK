using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR integer64 primitive type.
    /// A signed integer in the range -9,223,372,036,854,775,808 to +9,223,372,036,854,775,807 (64-bit).
    /// </summary>
    /// <remarks>
    /// The FHIR integer64 type is a 64-bit signed integer. It is used for counting, indexing,
    /// and other numeric operations that require whole numbers beyond the 32-bit range.
    /// The value must not have leading zeros (except for the value 0 itself) and must be within
    /// the valid range for a 64-bit signed integer.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create an integer64 value
    /// var largeCount = new FhirInteger64(9223372036854775807L);
    ///
    /// // Create from string
    /// var population = new FhirInteger64("1234567890");
    ///
    /// // Validate the value
    /// var result = largeCount.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"Large count: {largeCount.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirInteger64 : PrimitiveType<FhirInteger64, long>, IInteger64Value
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class.
        /// </summary>
        public FhirInteger64() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the integer64 value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirInteger64(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the integer64 value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirInteger64(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class from a long value and element.
        /// </summary>
        /// <param name="value">The long value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirInteger64(long? value, Element? element) : base(value?.ToString(), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the integer64 value.</param>
        public FhirInteger64(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class from a long value.
        /// </summary>
        /// <param name="value">The long value.</param>
        public FhirInteger64(long? value) : base(value?.ToString(), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger64"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the integer64 value.</param>
        public FhirInteger64(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether this instance has a valid integer64 value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a valid integer64 value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => long.TryParse(_stringValue, out _);

        /// <summary>
        /// Gets the long value of this FHIR integer64.
        /// </summary>
        /// <value>
        /// The long value, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        /// <exception cref="FormatException">Thrown when the string value cannot be converted to a long.</exception>
        public long? Value => Convert.ToInt64(_stringValue);

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the FHIR type name for this integer64 type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("Integer64" or "integer64").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Integer64" : "integer64";

        /// <summary>
        /// Gets the JSON representation of this integer64 value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this integer64, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<long?>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR integer64.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR integer64 values must be within the 64-bit signed integer range and must not have leading zeros.
        /// </remarks>
        public override bool IsValidValue() => IsValidInteger64Value(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The long value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid integer64 value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid integer64; otherwise, <c>false</c>.</returns>
        private static bool IsValidInteger64Value(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用更嚴格的regex：^(0|[-+]?[1-9][0-9]*)$
            if (!Regex.IsMatch(value, @"^(0|[-+]?[1-9][0-9]*)$")) return false;

            // 檢查是否在long範圍內
            return long.TryParse(value, out _);
        }

        /// <summary>
        /// Gets the expected format description for FHIR integer64.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR integer64.</returns>
        protected override string GetExpectedFormat()
        {
            return "A 64-bit signed integer (e.g., 0, 123, -456). Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Integer64 value cannot be null or empty";

            if (!long.TryParse(_stringValue, out long value))
                return $"'{_stringValue}' is not a valid integer64. {GetExpectedFormat()}";

            // 如果能解析但regex不匹配，可能是格式問題（如前導零）
            return $"'{_stringValue}' has invalid integer64 format. {GetExpectedFormat()}";
        }

        #endregion
    }
}
