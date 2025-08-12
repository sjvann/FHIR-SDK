using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR markdown primitive type.
    /// A markdown formatted string, see http://en.wikipedia.org/wiki/Markdown.
    /// </summary>
    /// <remarks>
    /// The FHIR markdown type represents text content that uses Markdown formatting syntax.
    /// This allows for rich text formatting including headers, lists, emphasis, links, and
    /// other Markdown features while maintaining a simple, readable text format. The content
    /// can contain any Unicode characters and supports the full Markdown specification.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple markdown string
    /// var markdown = new FhirMarkdown("# Patient Information\n\nThis patient has **diabetes**.");
    ///
    /// // Create with more complex formatting
    /// var complexMarkdown = new FhirMarkdown(@"# Medical History
    ///
    /// ## Current Medications
    /// - **Insulin**: 10 units daily
    /// - **Metformin**: 500mg twice daily
    ///
    /// ## Allergies
    /// * Penicillin
    /// * Sulfa drugs
    ///
    /// For more information, see [patient portal](https://portal.example.com).");
    ///
    /// // Validate the markdown
    /// var result = markdown.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"Markdown content: {markdown.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirMarkdown : PrimitiveType<FhirMarkdown, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirMarkdown"/> class.
        /// </summary>
        public FhirMarkdown() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirMarkdown"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the markdown value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirMarkdown(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirMarkdown"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the markdown value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirMarkdown(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirMarkdown"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirMarkdown(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirMarkdown"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the markdown value.</param>
        public FhirMarkdown(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirMarkdown"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the markdown content.</param>
        public FhirMarkdown(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the string value of this FHIR markdown.
        /// </summary>
        /// <value>
        /// The string value, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR markdown.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR markdown values can contain any Unicode characters and support
        /// the full Markdown specification. The content should be well-formed Markdown.
        /// </remarks>
        public override bool IsValidValue() => IsValidMarkdownValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid markdown value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid markdown; otherwise, <c>false</c>.</returns>
        private static bool IsValidMarkdownValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // Markdown 可以包含任何 Unicode 字符，所以我們只檢查基本格式
            // 這裡使用一個寬鬆的檢查，允許任何非空字符串
            return true;
        }

        /// <summary>
        /// Gets the expected format description for FHIR markdown.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR markdown.</returns>
        protected override string GetExpectedFormat()
        {
            return "Any valid Markdown content (e.g., # Headers, **bold**, *italic*, [links](url), lists, etc.)";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Markdown value cannot be null or empty";

            return $"'{_stringValue}' is not valid Markdown content. {GetExpectedFormat()}";
        }

        #endregion
    }
}
