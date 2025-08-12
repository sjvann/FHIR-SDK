using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR base64Binary primitive type.
    /// A stream of bytes, base64 encoded.
    /// </summary>
    /// <remarks>
    /// The FHIR base64Binary type represents binary data encoded using Base64 encoding as defined in RFC 4648.
    /// This type is used for storing binary content such as images, documents, or other binary data within FHIR resources.
    /// The encoded data must follow the Base64 alphabet and padding rules.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create from base64 string
    /// var binaryData = new FhirBase64Binary("SGVsbG8gV29ybGQ="); // "Hello World" encoded
    ///
    /// // Create from byte array
    /// byte[] bytes = System.Text.Encoding.UTF8.GetBytes("Hello World");
    /// var binary = FhirBase64Binary.FromBytes(bytes);
    ///
    /// // Validate the data
    /// var validationResult = binary.ValidateDetailed();
    /// if (validationResult.IsValid)
    /// {
    ///     byte[] decoded = binary.ToBytes();
    /// }
    /// </code>
    /// </example>
    public class FhirBase64Binary : PrimitiveType<FhirBase64Binary, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBase64Binary"/> class.
        /// </summary>
        public FhirBase64Binary() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBase64Binary"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the base64 encoded string.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirBase64Binary(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBase64Binary"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the base64 encoded string.</param>
        /// <param name="element">The element metadata.</param>
        public FhirBase64Binary(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBase64Binary"/> class from a base64 string and element.
        /// </summary>
        /// <param name="value">The base64 encoded string.</param>
        /// <param name="element">The element metadata.</param>
        public FhirBase64Binary(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBase64Binary"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the base64 encoded string.</param>
        public FhirBase64Binary(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBase64Binary"/> class from a base64 string.
        /// </summary>
        /// <param name="value">The base64 encoded string.</param>
        public FhirBase64Binary(string? value) : this(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the base64 encoded string value of this FHIR base64Binary.
        /// </summary>
        /// <value>
        /// The base64 encoded string, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR base64Binary.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid base64Binary values must conform to the Base64 encoding specification (RFC 4648).
        /// </remarks>
        public override bool IsValidValue() => IsValidBase64String(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The base64 string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Converts the base64 encoded string to a byte array.
        /// </summary>
        /// <returns>The decoded byte array, or <c>null</c> if the value is null or invalid.</returns>
        /// <exception cref="FormatException">Thrown when the base64 string is not valid.</exception>
        public byte[]? ToBytes()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return null;

            try
            {
                return Convert.FromBase64String(_stringValue);
            }
            catch (FormatException)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the size of the decoded binary data in bytes.
        /// </summary>
        /// <returns>The size in bytes, or 0 if the value is null or invalid.</returns>
        public int GetSizeInBytes()
        {
            var bytes = ToBytes();
            return bytes?.Length ?? 0;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirBase64Binary"/> instance from a byte array.
        /// </summary>
        /// <param name="bytes">The byte array to encode.</param>
        /// <returns>A new <see cref="FhirBase64Binary"/> instance with the encoded data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="bytes"/> is null.</exception>
        public static FhirBase64Binary FromBytes(byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            return new FhirBase64Binary(Convert.ToBase64String(bytes));
        }

        /// <summary>
        /// Creates a new <see cref="FhirBase64Binary"/> instance from a stream.
        /// </summary>
        /// <param name="stream">The stream to read and encode.</param>
        /// <returns>A new <see cref="FhirBase64Binary"/> instance with the encoded data.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="stream"/> is null.</exception>
        public static FhirBase64Binary FromStream(System.IO.Stream stream)
        {
            if (stream == null)
                throw new ArgumentNullException(nameof(stream));

            using var memoryStream = new System.IO.MemoryStream();
            stream.CopyTo(memoryStream);
            return FromBytes(memoryStream.ToArray());
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR base64Binary.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR base64Binary.</returns>
        protected override string GetExpectedFormat()
        {
            return "Base64 encoded binary data (RFC 4648). Example: 'SGVsbG8gV29ybGQ='";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Base64Binary value cannot be null or empty";

            if (!IsValidBase64String(_stringValue))
                return $"'{_stringValue}' is not a valid base64 encoded string. {GetExpectedFormat()}";

            return $"'{_stringValue}' contains invalid base64 characters or format";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string is a valid base64 encoded string.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid base64 string; otherwise, <c>false</c>.</returns>
        private static bool IsValidBase64String(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Check basic format with regex
            if (!Regex.IsMatch(value, @"^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$"))
                return false;

            // Try to decode to verify it's valid base64
            try
            {
                Convert.FromBase64String(value);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        #endregion
    }
}
