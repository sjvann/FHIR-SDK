using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR string primitive type.
    /// A sequence of Unicode characters. Note that FHIR strings SHALL NOT exceed 1MB in size.
    /// </summary>
    /// <remarks>
    /// The FHIR string type is used to represent textual data in FHIR resources.
    /// It supports the full Unicode character set and has a maximum size limit of 1MB when encoded in UTF-8.
    /// This type is commonly used for names, descriptions, and other textual content in FHIR resources.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple string
    /// var name = new FhirString("John Doe");
    ///
    /// // Create with validation
    /// var description = new FhirString("Patient description");
    /// var validationResult = description.ValidateDetailed();
    ///
    /// // Access the value
    /// string value = name.Value; // "John Doe"
    /// </code>
    /// </example>
    public class FhirString : PrimitiveType<FhirString, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirString"/> class.
        /// </summary>
        public FhirString() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirString"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the string value.</param>
        public FhirString(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirString"/> class from a string value.
        /// </summary>
        /// <param name="value">The string value.</param>
        public FhirString(string? value) : this(value, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirString"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the string value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirString(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirString"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirString(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirString"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirString(string? value, Element? element) : base(value, element) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the string value of this FHIR string.
        /// </summary>
        /// <value>
        /// The string value, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR string.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// FHIR strings can contain any Unicode characters and must not exceed 1MB in UTF-8 encoding.
        /// </remarks>
        public override bool IsValidValue() => CheckValidate(@"^[\s\S]+$", _stringValue);

        protected override string GetExpectedFormat()
        {
            return "Any sequence of Unicode characters (max length: 1MB in UTF-8)";
        }

        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "String value cannot be null or empty";

            // 檢查長度限制（FHIR規範建議1MB限制）
            var utf8ByteCount = System.Text.Encoding.UTF8.GetByteCount(_stringValue);
            if (utf8ByteCount > 1024 * 1024) // 1MB
                return $"String value is too long ({utf8ByteCount:N0} bytes). Maximum allowed: 1MB";

            return $"'{_stringValue}' contains invalid characters for FHIR string type";
        }

        public override object? GetValue() => Value;

        #endregion
    }
}
