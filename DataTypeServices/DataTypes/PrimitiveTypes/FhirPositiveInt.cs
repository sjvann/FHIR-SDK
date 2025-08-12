using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR positiveInt primitive type.
    /// An unsigned integer in the range 1 to 4,294,967,295 (32-bit).
    /// </summary>
    /// <remarks>
    /// The FHIR positiveInt type is a 32-bit unsigned integer that must be greater than zero.
    /// It is used for counting, indexing, and other numeric operations that require positive
    /// whole numbers. The value must not have leading zeros and must be within the valid range
    /// for a 32-bit unsigned integer (1 to 4,294,967,295).
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a positiveInt value
    /// var count = new FhirPositiveInt(42);
    ///
    /// // Create from string
    /// var age = new FhirPositiveInt("25");
    ///
    /// // Validate the value
    /// var result = count.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"Count: {count.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirPositiveInt : PrimitiveType<FhirPositiveInt, uint>, IUnsignedInteger32Value
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class.
        /// </summary>
        public FhirPositiveInt() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the positiveInt value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirPositiveInt(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the positiveInt value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirPositiveInt(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class from a uint value and element.
        /// </summary>
        /// <param name="value">The uint value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirPositiveInt(uint? value, Element? element) : base(value?.ToString(), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the positiveInt value.</param>
        public FhirPositiveInt(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class from a uint value.
        /// </summary>
        /// <param name="value">The uint value.</param>
        public FhirPositiveInt(uint? value) : base(value?.ToString(), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirPositiveInt"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the positiveInt value.</param>
        public FhirPositiveInt(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether this instance has a valid positiveInt value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a valid positiveInt value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => uint.TryParse(_stringValue, out _);

        /// <summary>
        /// Gets the uint value of this FHIR positiveInt.
        /// </summary>
        /// <value>
        /// The uint value, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        /// <exception cref="FormatException">Thrown when the string value cannot be converted to a uint.</exception>
        public uint? Value
        {
            get
            {
                if (string.IsNullOrEmpty(_stringValue)) return null;
                return uint.TryParse(_stringValue, out var v) ? v : (uint?)null;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the JSON representation of this positiveInt value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this positiveInt, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<uint?>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR positiveInt.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR positiveInt values must be greater than zero and within the 32-bit unsigned integer range.
        /// </remarks>
        public override bool IsValidValue() => IsValidPositiveIntValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The uint value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Gets the FHIR type name for this positiveInt type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("PositiveInt" or "positiveInt").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "PositiveInt" : "positiveInt";

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirPositiveInt"/> instance from an integer value.
        /// </summary>
        /// <param name="value">The integer value (must be positive).</param>
        /// <returns>A new <see cref="FhirPositiveInt"/> instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="value"/> is not positive.</exception>
        public static FhirPositiveInt FromInt(int value)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Value must be positive");

            return new FhirPositiveInt((uint)value);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid positiveInt value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid positiveInt; otherwise, <c>false</c>.</returns>
        private static bool IsValidPositiveIntValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用更嚴格的regex：^[1-9][0-9]*$
            if (!Regex.IsMatch(value, @"^[1-9][0-9]*$")) return false;

            // 檢查是否在uint範圍內且大於0
            return uint.TryParse(value, out uint result) && result > 0;
        }

        /// <summary>
        /// Gets the expected format description for FHIR positiveInt.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR positiveInt.</returns>
        protected override string GetExpectedFormat()
        {
            return "A positive 32-bit unsigned integer (e.g., 1, 123, 456). Range: 1 to 4,294,967,295";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "PositiveInt value cannot be null or empty";

            if (!uint.TryParse(_stringValue, out uint value))
                return $"'{_stringValue}' is not a valid positiveInt. {GetExpectedFormat()}";

            if (value == 0)
                return $"'{_stringValue}' must be greater than zero. {GetExpectedFormat()}";

            // 如果能解析但regex不匹配，可能是格式問題（如前導零）
            return $"'{_stringValue}' has invalid positiveInt format. {GetExpectedFormat()}";
        }

        #endregion
    }
}
