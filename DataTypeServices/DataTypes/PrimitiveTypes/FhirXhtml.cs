using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR xhtml primitive type.
    /// XHTML content that can be used in FHIR resources for rich text formatting.
    /// </summary>
    /// <remarks>
    /// The FHIR xhtml type represents XHTML content that can be embedded in FHIR resources.
    /// This allows for rich text formatting, including basic HTML elements like paragraphs,
    /// lists, tables, and formatting tags. The content must be valid XHTML and should follow
    /// FHIR's XHTML profile restrictions for security and compatibility.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create XHTML content
    /// var xhtml = new FhirXhtml("&lt;p&gt;This is a &lt;strong&gt;bold&lt;/strong&gt; paragraph.&lt;/p&gt;");
    ///
    /// // Create with more complex content
    /// var complexXhtml = new FhirXhtml(@"&lt;div&gt;
    ///     &lt;h2&gt;Patient Information&lt;/h2&gt;
    ///     &lt;p&gt;This patient has a history of &lt;em&gt;diabetes&lt;/em&gt;.&lt;/p&gt;
    ///     &lt;ul&gt;
    ///         &lt;li&gt;Medication: Insulin&lt;/li&gt;
    ///         &lt;li&gt;Dosage: 10 units daily&lt;/li&gt;
    ///     &lt;/ul&gt;
    /// &lt;/div&gt;");
    ///
    /// // Validate the XHTML
    /// var result = xhtml.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"XHTML content: {xhtml.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirXhtml : PrimitiveType<FhirXhtml, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirXhtml"/> class.
        /// </summary>
        public FhirXhtml() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirXhtml"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the xhtml value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirXhtml(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirXhtml"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the xhtml value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirXhtml(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirXhtml"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirXhtml(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirXhtml"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the xhtml value.</param>
        public FhirXhtml(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirXhtml"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the xhtml content.</param>
        public FhirXhtml(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the string value of this FHIR xhtml.
        /// </summary>
        /// <value>
        /// The string value, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the FHIR type name for this xhtml type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("XHTML" or "xhtml").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "XHTML" : "xhtml";

        /// <summary>
        /// Gets the JSON representation of this xhtml value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this xhtml, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<string>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR xhtml.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR xhtml values must contain well-formed XHTML content with proper tag structure.
        /// The content should follow FHIR's XHTML profile for security and compatibility.
        /// </remarks>
        public override bool IsValidValue() => IsValidXhtmlValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid xhtml value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid xhtml; otherwise, <c>false</c>.</returns>
        private static bool IsValidXhtmlValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 基本檢查：確保包含至少一個有效的HTML標籤
            // 這個regex檢查是否有成對的HTML標籤
            return Regex.IsMatch(value, @"<([A-Za-z][A-Za-z0-9]*)\b[^>]*>(.*?)</\1>", RegexOptions.Singleline);
        }

        /// <summary>
        /// Gets the expected format description for FHIR xhtml.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR xhtml.</returns>
        protected override string GetExpectedFormat()
        {
            return "Valid XHTML content with proper tag structure (e.g., &lt;p&gt;content&lt;/p&gt;, &lt;div&gt;&lt;h2&gt;title&lt;/h2&gt;&lt;/div&gt;)";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "XHTML value cannot be null or empty";

            if (!Regex.IsMatch(_stringValue, @"<([A-Za-z][A-Za-z0-9]*)\b[^>]*>", RegexOptions.Singleline))
                return $"'{_stringValue}' does not contain valid HTML tags. {GetExpectedFormat()}";

            if (!Regex.IsMatch(_stringValue, @"<([A-Za-z][A-Za-z0-9]*)\b[^>]*>(.*?)</\1>", RegexOptions.Singleline))
                return $"'{_stringValue}' has mismatched or invalid HTML tag structure. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not valid XHTML content. {GetExpectedFormat()}";
        }

        #endregion
    }
}
