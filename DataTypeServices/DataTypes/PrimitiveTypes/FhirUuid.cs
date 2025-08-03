using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR uuid primitive type.
    /// A UUID, following RFC 4122 format with urn:uuid: prefix.
    /// </summary>
    /// <remarks>
    /// The FHIR uuid type represents a Universally Unique Identifier (UUID) following RFC 4122.
    /// The value must be in the format "urn:uuid:" followed by a valid UUID in the standard
    /// 8-4-4-4-12 hexadecimal format. This type is commonly used for unique identifiers
    /// in FHIR resources that need to be globally unique.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a UUID value
    /// var uuid = new FhirUuid("urn:uuid:550e8400-e29b-41d4-a716-446655440000");
    ///
    /// // Validate the UUID
    /// var result = uuid.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"UUID: {uuid.Value}");
    /// }
    ///
    /// // Generate a new UUID
    /// var newUuid = new FhirUuid($"urn:uuid:{Guid.NewGuid()}");
    /// </code>
    /// </example>
    public class FhirUuid : PrimitiveType<FhirUuid, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUuid"/> class.
        /// </summary>
        public FhirUuid() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUuid"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the uuid value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirUuid(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUuid"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the uuid value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUuid(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUuid"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirUuid(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUuid"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the uuid value.</param>
        public FhirUuid(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirUuid"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the uuid.</param>
        public FhirUuid(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the string value of this FHIR uuid.
        /// </summary>
        /// <value>
        /// The string value, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR uuid.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR uuid values must follow the format "urn:uuid:" followed by a valid UUID
        /// in the standard 8-4-4-4-12 hexadecimal format.
        /// </remarks>
        public override bool IsValidValue() => IsValidUuidValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Gets the FHIR type name for this uuid type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("Uuid" or "uuid").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Uuid" : "uuid";

        /// <summary>
        /// Gets the UUID part without the "urn:uuid:" prefix.
        /// </summary>
        /// <returns>The UUID in standard format, or <c>null</c> if the value is invalid.</returns>
        public string? GetUuidValue()
        {
            if (string.IsNullOrEmpty(_stringValue) || !_stringValue.StartsWith("urn:uuid:", StringComparison.OrdinalIgnoreCase))
                return null;

            return _stringValue.Substring(9); // Remove "urn:uuid:" prefix
        }

        /// <summary>
        /// Converts this FHIR uuid to a .NET Guid object.
        /// </summary>
        /// <returns>A Guid object, or <c>null</c> if the value is invalid.</returns>
        public Guid? ToGuid()
        {
            var uuidValue = GetUuidValue();
            if (string.IsNullOrEmpty(uuidValue))
                return null;

            try
            {
                return Guid.Parse(uuidValue);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirUuid"/> instance from a Guid.
        /// </summary>
        /// <param name="guid">The Guid to convert.</param>
        /// <returns>A new <see cref="FhirUuid"/> instance.</returns>
        public static FhirUuid FromGuid(Guid guid)
        {
            return new FhirUuid($"urn:uuid:{guid:D}");
        }

        /// <summary>
        /// Creates a new <see cref="FhirUuid"/> instance with a new random UUID.
        /// </summary>
        /// <returns>A new <see cref="FhirUuid"/> instance with a randomly generated UUID.</returns>
        public static FhirUuid NewUuid()
        {
            return FromGuid(Guid.NewGuid());
        }

        /// <summary>
        /// Creates a new <see cref="FhirUuid"/> instance from a UUID string.
        /// </summary>
        /// <param name="uuid">The UUID in standard format (without "urn:uuid:" prefix).</param>
        /// <returns>A new <see cref="FhirUuid"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="uuid"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the UUID format is invalid.</exception>
        public static FhirUuid FromUuid(string uuid)
        {
            if (uuid == null)
                throw new ArgumentNullException(nameof(uuid));

            if (!Regex.IsMatch(uuid, @"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.IgnoreCase))
                throw new ArgumentException("Invalid UUID format", nameof(uuid));

            return new FhirUuid($"urn:uuid:{uuid}");
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid uuid value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid uuid; otherwise, <c>false</c>.</returns>
        private static bool IsValidUuidValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用regex檢查格式：urn:uuid:[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}
            return Regex.IsMatch(value, @"^urn:uuid:[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Gets the expected format description for FHIR uuid.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR uuid.</returns>
        protected override string GetExpectedFormat()
        {
            return "urn:uuid: followed by a valid UUID in format 8-4-4-4-12 hexadecimal (e.g., urn:uuid:550e8400-e29b-41d4-a716-446655440000)";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Uuid value cannot be null or empty";

            if (!_stringValue.StartsWith("urn:uuid:", StringComparison.OrdinalIgnoreCase))
                return $"'{_stringValue}' must start with 'urn:uuid:'. {GetExpectedFormat()}";

            // 提取UUID部分進行進一步驗證
            var uuidPart = _stringValue.Substring(9); // 移除 "urn:uuid:" 前綴
            if (!Regex.IsMatch(uuidPart, @"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.IgnoreCase))
                return $"'{_stringValue}' has invalid UUID format. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid FHIR uuid. {GetExpectedFormat()}";
        }

        #endregion
    }
}
