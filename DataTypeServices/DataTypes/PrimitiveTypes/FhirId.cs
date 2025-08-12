using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR id primitive type.
    /// Any combination of letters, digits, hyphens and underscores, not to exceed 64 characters.
    /// </summary>
    /// <remarks>
    /// The FHIR id type represents a string identifier that can be used within FHIR resources.
    /// It is commonly used for internal identifiers, element IDs, and other short identifiers
    /// that need to be unique within a specific context. The value must be between 1 and 64
    /// characters and can only contain letters (A-Z, a-z), digits (0-9), hyphens (-), and periods (.).
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create an id value
    /// var patientId = new FhirId("patient-123");
    ///
    /// // Create with different characters
    /// var elementId = new FhirId("element_456");
    /// var simpleId = new FhirId("abc123");
    ///
    /// // Validate the id
    /// var result = patientId.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"Patient ID: {patientId.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirId : PrimitiveType<FhirId, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirId"/> class.
        /// </summary>
        public FhirId() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirId"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the id value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirId(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirId"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the id value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirId(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirId"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirId(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirId"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the id value.</param>
        public FhirId(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirId"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the id.</param>
        public FhirId(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the string value of this FHIR id.
        /// </summary>
        /// <value>
        /// The string value, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR id.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR id values must be between 1 and 64 characters and can only contain
        /// letters (A-Z, a-z), digits (0-9), hyphens (-), and periods (.).
        /// </remarks>
        public override bool IsValidValue() => IsValidIdValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid id value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid id; otherwise, <c>false</c>.</returns>
        private static bool IsValidIdValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 檢查長度：1-64字符
            if (value.Length < 1 || value.Length > 64) return false;

            // 檢查字符：只允許字母、數字、連字符和句點
            return Regex.IsMatch(value, @"^[A-Za-z0-9\-\.]+$");
        }

        /// <summary>
        /// Gets the expected format description for FHIR id.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR id.</returns>
        protected override string GetExpectedFormat()
        {
            return "1-64 characters containing only letters (A-Z, a-z), digits (0-9), hyphens (-), and periods (.)";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Id value cannot be null or empty";

            if (_stringValue.Length > 64)
                return $"Id value is too long ({_stringValue.Length} characters). Maximum allowed: 64 characters";

            var invalidChars = _stringValue.Where(c => !char.IsLetterOrDigit(c) && c != '-' && c != '.').ToArray();
            if (invalidChars.Any())
                return $"Id contains invalid characters: '{string.Join("', '", invalidChars)}'. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid FHIR id. {GetExpectedFormat()}";
        }

        #endregion
    }
}
