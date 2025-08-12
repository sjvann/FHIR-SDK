using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR unsignedInt primitive type.
    /// An unsigned integer in the range 0 to 4,294,967,295 (32-bit).
    /// </summary>
    /// <remarks>
    /// The FHIR unsignedInt type is a 32-bit unsigned integer that can be zero or positive.
    /// It is used for counting, indexing, and other numeric operations that require non-negative
    /// whole numbers. The value must not have leading zeros (except for the value 0 itself) and
    /// must be within the valid range for a 32-bit unsigned integer (0 to 4,294,967,295).
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create an unsignedInt value
    /// var count = new FhirUnsignedInt(42);
    ///
    /// // Create from string
    /// var age = new FhirUnsignedInt("25");
    ///
    /// // Create zero value
    /// var zero = new FhirUnsignedInt(0);
    ///
    /// // Validate the value
    /// var result = count.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"Count: {count.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirUnsignedInt : PrimitiveType<FhirUnsignedInt, uint>, IUnsignedInteger32Value
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class.
        /// </summary>
        public FhirUnsignedInt() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the unsignedInt value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirUnsignedInt(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the unsignedInt value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUnsignedInt(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class from a uint value and element.
        /// </summary>
        /// <param name="value">The uint value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUnsignedInt(uint? value, Element? element) : base(value?.ToString(), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the unsignedInt value.</param>
        public FhirUnsignedInt(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class from a uint value.
        /// </summary>
        /// <param name="value">The uint value.</param>
        public FhirUnsignedInt(uint? value) : base(value?.ToString(), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUnsignedInt"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the unsignedInt value.</param>
        public FhirUnsignedInt(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether this instance has a valid unsignedInt value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a valid unsignedInt value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => uint.TryParse(_stringValue, out _);

        /// <summary>
        /// Gets the uint value of this FHIR unsignedInt.
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
        /// Gets the JSON representation of this unsignedInt value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this unsignedInt, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<uint?>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR unsignedInt.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR unsignedInt values must be non-negative and within the 32-bit unsigned integer range.
        /// </remarks>
        public override bool IsValidValue() => IsValidUnsignedIntValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The uint value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid unsignedInt value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid unsignedInt; otherwise, <c>false</c>.</returns>
        private static bool IsValidUnsignedIntValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用更嚴格的regex：^(0|[1-9][0-9]*)$
            if (!Regex.IsMatch(value, @"^(0|[1-9][0-9]*)$")) return false;

            // 檢查是否在uint範圍內
            return uint.TryParse(value, out _);
        }

        /// <summary>
        /// Gets the expected format description for FHIR unsignedInt.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR unsignedInt.</returns>
        protected override string GetExpectedFormat()
        {
            return "A 32-bit unsigned integer (e.g., 0, 123, 456). Range: 0 to 4,294,967,295";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "UnsignedInt value cannot be null or empty";

            if (!uint.TryParse(_stringValue, out uint value))
                return $"'{_stringValue}' is not a valid unsignedInt. {GetExpectedFormat()}";

            // 如果能解析但regex不匹配，可能是格式問題（如前導零）
            return $"'{_stringValue}' has invalid unsignedInt format. {GetExpectedFormat()}";
        }

        #endregion
    }
}
