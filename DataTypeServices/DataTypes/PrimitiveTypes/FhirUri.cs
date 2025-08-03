using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Linq;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR uri primitive type.
    /// A Uniform Resource Identifier Reference (RFC 3986).
    /// </summary>
    /// <remarks>
    /// The FHIR uri type represents a URI reference as defined by RFC 3986.
    /// It is used for identifying resources and concepts. URIs can be absolute or relative,
    /// and may include fragments. This type is commonly used for system identifiers,
    /// profile references, and other resource identifiers in FHIR.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create URI values
    /// var profileUri = new FhirUri("http://hl7.org/fhir/StructureDefinition/Patient");
    /// var relativeUri = new FhirUri("Patient/123");
    /// var systemUri = new FhirUri("http://loinc.org");
    ///
    /// // Validate URI
    /// var validationResult = profileUri.ValidateDetailed();
    /// if (validationResult.IsValid)
    /// {
    ///     Uri uri = profileUri.ToUri();
    /// }
    /// </code>
    /// </example>
    public class FhirUri : PrimitiveType<FhirUri, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class.
        /// </summary>
        public FhirUri() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the URI value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirUri(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the URI value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUri(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The URI string.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUri(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the URI value.</param>
        public FhirUri(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class from a string value.
        /// </summary>
        /// <param name="value">The URI string.</param>
        public FhirUri(string? value) : base(value, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUri"/> class from a Uri object.
        /// </summary>
        /// <param name="uri">The Uri object.</param>
        public FhirUri(Uri uri) : base(uri?.ToString(), null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the URI string value of this FHIR uri.
        /// </summary>
        /// <value>
        /// The URI string, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR uri.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// FHIR URIs must not contain whitespace characters and should be valid URI references.
        /// </remarks>
        public override bool IsValidValue() => IsValidUriString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The URI string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Converts this FHIR uri to a .NET Uri object.
        /// </summary>
        /// <returns>A Uri object, or <c>null</c> if the value is null or invalid.</returns>
        public Uri? ToUri()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return null;

            try
            {
                return new Uri(_stringValue, UriKind.RelativeOrAbsolute);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Determines whether this URI is absolute.
        /// </summary>
        /// <returns><c>true</c> if the URI is absolute; otherwise, <c>false</c>.</returns>
        public bool IsAbsolute()
        {
            var uri = ToUri();
            return uri?.IsAbsoluteUri == true;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirUri"/> instance from a .NET Uri object.
        /// </summary>
        /// <param name="uri">The Uri object.</param>
        /// <returns>A new <see cref="FhirUri"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="uri"/> is null.</exception>
        public static FhirUri FromUri(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            return new FhirUri(uri.ToString());
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR uri.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR uri.</returns>
        protected override string GetExpectedFormat()
        {
            return "Valid URI reference (RFC 3986) without whitespace characters";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "URI value cannot be null or empty";

            if (_stringValue.Any(char.IsWhiteSpace))
                return $"'{_stringValue}' contains whitespace characters. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid URI format. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string is a valid FHIR uri.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR uri; otherwise, <c>false</c>.</returns>
        private static bool IsValidUriString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Must not contain whitespace
            if (value.Any(char.IsWhiteSpace))
                return false;

            // Try to create a URI to validate format
            try
            {
                new Uri(value, UriKind.RelativeOrAbsolute);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
