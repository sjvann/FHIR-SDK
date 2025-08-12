using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Linq;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR canonical primitive type.
    /// A URI that refers to a resource by its canonical URL, and may have a version appended.
    /// </summary>
    /// <remarks>
    /// The FHIR canonical type represents a canonical URL that identifies a FHIR resource.
    /// It may include a version suffix separated by a vertical bar (|). Canonical URLs are
    /// used to reference definitional resources like StructureDefinitions, ValueSets,
    /// CodeSystems, etc. The canonical URL should be globally unique and persistent.
    /// Format: {canonical-url}[|{version}]
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create canonical values
    /// var profile = new FhirCanonical("http://hl7.org/fhir/StructureDefinition/Patient");
    /// var versioned = new FhirCanonical("http://hl7.org/fhir/StructureDefinition/Patient|4.0.1");
    ///
    /// // Parse canonical components
    /// string baseUrl = versioned.GetBaseUrl();
    /// string version = versioned.GetVersion();
    /// bool hasVersion = versioned.HasVersion();
    /// </code>
    /// </example>
    public class FhirCanonical : PrimitiveType<FhirCanonical, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCanonical"/> class.
        /// </summary>
        public FhirCanonical() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCanonical"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the canonical value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirCanonical(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCanonical"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the canonical value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirCanonical(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCanonical"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The canonical URL string.</param>
        /// <param name="element">The element metadata.</param>
        public FhirCanonical(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCanonical"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the canonical value.</param>
        public FhirCanonical(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCanonical"/> class from a string value.
        /// </summary>
        /// <param name="value">The canonical URL string.</param>
        public FhirCanonical(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the canonical URL string value of this FHIR canonical.
        /// </summary>
        /// <value>
        /// The canonical URL string, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR canonical.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// FHIR canonical URLs must not contain whitespace characters and should be valid URI references.
        /// </remarks>
        public override bool IsValidValue() => IsValidCanonicalString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The canonical URL string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Gets the base URL part of the canonical (without version).
        /// </summary>
        /// <returns>The base URL, or the full value if no version is present, or <c>null</c> if no value is set.</returns>
        public string? GetBaseUrl()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return null;

            var pipeIndex = _stringValue.IndexOf('|');
            return pipeIndex >= 0 ? _stringValue.Substring(0, pipeIndex) : _stringValue;
        }

        /// <summary>
        /// Gets the version part of the canonical URL.
        /// </summary>
        /// <returns>The version string, or <c>null</c> if no version is present or no value is set.</returns>
        public string? GetVersion()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return null;

            var pipeIndex = _stringValue.IndexOf('|');
            return pipeIndex >= 0 && pipeIndex < _stringValue.Length - 1
                ? _stringValue.Substring(pipeIndex + 1)
                : null;
        }

        /// <summary>
        /// Determines whether this canonical URL includes a version.
        /// </summary>
        /// <returns><c>true</c> if a version is present; otherwise, <c>false</c>.</returns>
        public bool HasVersion()
        {
            return !string.IsNullOrEmpty(GetVersion());
        }

        /// <summary>
        /// Converts this canonical to a .NET Uri object (base URL only).
        /// </summary>
        /// <returns>A Uri object for the base URL, or <c>null</c> if the value is null or invalid.</returns>
        public Uri? ToUri()
        {
            var baseUrl = GetBaseUrl();
            if (string.IsNullOrEmpty(baseUrl))
                return null;

            try
            {
                return new Uri(baseUrl, UriKind.RelativeOrAbsolute);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirCanonical"/> instance from a base URL and version.
        /// </summary>
        /// <param name="baseUrl">The base canonical URL.</param>
        /// <param name="version">The version (optional).</param>
        /// <returns>A new <see cref="FhirCanonical"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="baseUrl"/> is null.</exception>
        public static FhirCanonical FromUrlAndVersion(string baseUrl, string? version = null)
        {
            if (baseUrl == null)
                throw new ArgumentNullException(nameof(baseUrl));

            var canonical = string.IsNullOrEmpty(version) ? baseUrl : $"{baseUrl}|{version}";
            return new FhirCanonical(canonical);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR canonical.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR canonical.</returns>
        protected override string GetExpectedFormat()
        {
            return "Canonical URL without whitespace, optionally with version: {url}[|{version}]";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Canonical value cannot be null or empty";

            if (_stringValue.Any(char.IsWhiteSpace))
                return $"'{_stringValue}' contains whitespace characters. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid canonical URL format. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string is a valid FHIR canonical.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR canonical; otherwise, <c>false</c>.</returns>
        private static bool IsValidCanonicalString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Must not contain whitespace
            if (value.Any(char.IsWhiteSpace))
                return false;

            // Split by pipe to check base URL and version separately
            var parts = value.Split('|');
            if (parts.Length > 2)
                return false; // Too many pipe characters

            // Validate base URL part
            var baseUrl = parts[0];
            if (string.IsNullOrEmpty(baseUrl))
                return false;

            try
            {
                new Uri(baseUrl, UriKind.RelativeOrAbsolute);
            }
            catch
            {
                return false;
            }

            // If there's a version part, it should not be empty
            if (parts.Length == 2 && string.IsNullOrEmpty(parts[1]))
                return false;

            return true;
        }

        #endregion
    }
}
