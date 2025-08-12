using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR integer primitive type.
    /// A signed integer in the range -2,147,483,648 to +2,147,483,647 (32-bit).
    /// </summary>
    /// <remarks>
    /// The FHIR integer type is a 32-bit signed integer. It is used for counting, indexing,
    /// and other numeric operations that require whole numbers. The value must not have
    /// leading zeros (except for the value 0 itself) and must be within the valid range
    /// for a 32-bit signed integer.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create an integer value
    /// var count = new FhirInteger(42);
    ///
    /// // Create from string
    /// var age = new FhirInteger("25");
    ///
    /// // Validate the value
    /// var result = count.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"Count: {count.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirInteger : PrimitiveType<FhirInteger,int>, IInteger32Value
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class.
        /// </summary>
        public FhirInteger() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the integer value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirInteger(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the integer value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirInteger(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class from an integer value and element.
        /// </summary>
        /// <param name="value">The integer value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirInteger(int? value, Element? element) : base(value?.ToString(), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the integer value.</param>
        public FhirInteger(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class from an integer value.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public FhirInteger(int? value) : base(value?.ToString(), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInteger"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the integer value.</param>
        public FhirInteger(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether this instance has a valid integer value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a valid integer value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => int.TryParse(_stringValue, out _);

        /// <summary>
        /// Gets the integer value of this FHIR integer.
        /// </summary>
        /// <value>
        /// The integer value, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        /// <exception cref="FormatException">Thrown when the string value cannot be converted to an integer.</exception>
        public int? Value => Convert.ToInt32(_stringValue);

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the JSON representation of this integer value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this integer, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<int?>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR integer.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR integers must be within the 32-bit signed integer range and must not have leading zeros.
        /// </remarks>
        public override bool IsValidValue() => IsValidIntegerValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The integer value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid integer value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid integer; otherwise, <c>false</c>.</returns>
        private static bool IsValidIntegerValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用更嚴格的regex：^(0|[-+]?[1-9][0-9]*)$
            if (!Regex.IsMatch(value, @"^(0|[-+]?[1-9][0-9]*)$")) return false;

            // 檢查是否在int範圍內
            return int.TryParse(value, out _);
        }

        /// <summary>
        /// Gets the expected format description for FHIR integers.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR integers.</returns>
        protected override string GetExpectedFormat()
        {
            return "A 32-bit signed integer (e.g., 0, 123, -456). Range: -2,147,483,648 to 2,147,483,647";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Integer value cannot be null or empty";

            if (!int.TryParse(_stringValue, out int value))
                return $"'{_stringValue}' is not a valid integer. {GetExpectedFormat()}";

            // 如果能解析但regex不匹配，可能是格式問題（如前導零）
            return $"'{_stringValue}' has invalid integer format. {GetExpectedFormat()}";
        }

        #endregion
    }
}
