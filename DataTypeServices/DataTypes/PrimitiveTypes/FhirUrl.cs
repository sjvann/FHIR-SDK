using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Linq;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR url primitive type.
    /// A Uniform Resource Locator (RFC 1738).
    /// </summary>
    /// <remarks>
    /// The FHIR url type represents a URL as defined by RFC 1738. It is a specialized form of URI
    /// that specifies the location of a resource. URLs must be absolute and typically include
    /// a scheme (http, https, ftp, etc.). This type is commonly used for endpoint URLs,
    /// service locations, and external resource references.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create URL values
    /// var endpoint = new FhirUrl("https://api.example.com/fhir");
    /// var serviceUrl = new FhirUrl("http://terminology.hl7.org/CodeSystem/v3-ActCode");
    ///
    /// // Validate URL
    /// var validationResult = endpoint.ValidateDetailed();
    /// if (validationResult.IsValid)
    /// {
    ///     Uri uri = endpoint.ToUri();
    ///     string scheme = endpoint.GetScheme();
    /// }
    /// </code>
    /// </example>
    public class FhirUrl : PrimitiveType<FhirUrl, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class.
        /// </summary>
        public FhirUrl() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the URL value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirUrl(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the URL value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUrl(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The URL string.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUrl(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the URL value.</param>
        public FhirUrl(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class from a string value.
        /// </summary>
        /// <param name="value">The URL string.</param>
        public FhirUrl(string? value) : base(value, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUrl"/> class from a Uri object.
        /// </summary>
        /// <param name="uri">The Uri object (must be absolute).</param>
        /// <exception cref="ArgumentException">Thrown when the URI is not absolute.</exception>
        public FhirUrl(Uri uri) : base(ValidateAndGetUriString(uri), null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the URL string value of this FHIR url.
        /// </summary>
        /// <value>
        /// The URL string, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR url.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// FHIR URLs must be absolute URLs without whitespace characters.
        /// </remarks>
        public override bool IsValidValue() => IsValidUrlString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The URL string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Converts this FHIR url to a .NET Uri object.
        /// </summary>
        /// <returns>A Uri object, or <c>null</c> if the value is null or invalid.</returns>
        public Uri? ToUri()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return null;

            try
            {
                var uri = new Uri(_stringValue, UriKind.Absolute);
                return uri.IsAbsoluteUri ? uri : null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the scheme of this URL.
        /// </summary>
        /// <returns>The scheme (e.g., "http", "https"), or <c>null</c> if the URL is invalid.</returns>
        public string? GetScheme()
        {
            var uri = ToUri();
            return uri?.Scheme;
        }

        /// <summary>
        /// Gets the host of this URL.
        /// </summary>
        /// <returns>The host name, or <c>null</c> if the URL is invalid.</returns>
        public string? GetHost()
        {
            var uri = ToUri();
            return uri?.Host;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirUrl"/> instance from a .NET Uri object.
        /// </summary>
        /// <param name="uri">The Uri object (must be absolute).</param>
        /// <returns>A new <see cref="FhirUrl"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="uri"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the URI is not absolute.</exception>
        public static FhirUrl FromUri(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));
            if (!uri.IsAbsoluteUri)
                throw new ArgumentException("URL must be absolute", nameof(uri));

            return new FhirUrl(uri.ToString());
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR url.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR url.</returns>
        protected override string GetExpectedFormat()
        {
            return "Absolute URL (RFC 1738) without whitespace characters (e.g., 'https://example.com/path')";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "URL value cannot be null or empty";

            if (_stringValue.Any(char.IsWhiteSpace))
                return $"'{_stringValue}' contains whitespace characters. {GetExpectedFormat()}";

            try
            {
                var uri = new Uri(_stringValue, UriKind.Absolute);
                if (!uri.IsAbsoluteUri)
                    return $"'{_stringValue}' is not an absolute URL. {GetExpectedFormat()}";
            }
            catch
            {
                return $"'{_stringValue}' is not a valid URL format. {GetExpectedFormat()}";
            }

            return $"'{_stringValue}' is not a valid URL. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates and gets the string representation of a URI.
        /// </summary>
        /// <param name="uri">The URI to validate.</param>
        /// <returns>The string representation of the URI.</returns>
        /// <exception cref="ArgumentNullException">Thrown when uri is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the URI is not absolute.</exception>
        private static string ValidateAndGetUriString(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));
            if (!uri.IsAbsoluteUri)
                throw new ArgumentException("URL must be absolute", nameof(uri));

            return uri.ToString();
        }

        /// <summary>
        /// Validates whether the specified string is a valid FHIR url.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR url; otherwise, <c>false</c>.</returns>
        private static bool IsValidUrlString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Must not contain whitespace
            if (value.Any(char.IsWhiteSpace))
                return false;

            // Try to create an absolute URI to validate format
            try
            {
                var uri = new Uri(value, UriKind.Absolute);
                if (!uri.IsAbsoluteUri) return false;
                // 允許的 URL schemes：僅 http, https
                return uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
