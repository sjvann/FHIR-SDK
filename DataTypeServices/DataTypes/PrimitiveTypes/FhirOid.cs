using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR oid primitive type.
    /// An OID represented as a URI, following RFC 3001 format.
    /// </summary>
    /// <remarks>
    /// The FHIR oid type represents an Object Identifier (OID) in URI format.
    /// OIDs are hierarchical identifiers used in healthcare systems for coding
    /// schemes, value sets, and other standardized identifiers. The format follows
    /// RFC 3001 with the prefix "urn:oid:" followed by a valid OID in dot notation.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create an OID value
    /// var oid = new FhirOid("urn:oid:2.16.840.1.113883.2.4.6.1");
    ///
    /// // Create with different OID
    /// var snomedOid = new FhirOid("urn:oid:2.16.840.1.113883.6.96");
    /// var loincOid = new FhirOid("urn:oid:2.16.840.1.113883.6.1");
    ///
    /// // Validate the OID
    /// var result = oid.ValidateDetailed();
    /// if (result.IsValid)
    /// {
    ///     Console.WriteLine($"OID: {oid.Value}");
    /// }
    /// </code>
    /// </example>
    public class FhirOid : PrimitiveType<FhirOid, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirOid"/> class.
        /// </summary>
        public FhirOid() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirOid"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the oid value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirOid(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirOid"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the oid value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirOid(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirOid"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirOid(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirOid"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the oid value.</param>
        public FhirOid(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirOid"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the oid.</param>
        public FhirOid(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the string value of this FHIR oid.
        /// </summary>
        /// <value>
        /// The string value, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR oid.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR oid values must follow the format "urn:oid:" followed by a valid OID
        /// in dot notation, where each component is a non-negative integer.
        /// </remarks>
        public override bool IsValidValue() => IsValidOidValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Gets the FHIR type name for this oid type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("Oid" or "oid").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Oid" : "oid";

        /// <summary>
        /// Gets the OID part without the "urn:oid:" prefix.
        /// </summary>
        /// <returns>The OID in dot notation, or <c>null</c> if the value is invalid.</returns>
        public string? GetOidValue()
        {
            if (string.IsNullOrEmpty(_stringValue) || !_stringValue.StartsWith("urn:oid:", StringComparison.OrdinalIgnoreCase))
                return null;

            return _stringValue.Substring(8); // Remove "urn:oid:" prefix
        }

        /// <summary>
        /// Gets the root arc of the OID (the first number).
        /// </summary>
        /// <returns>The root arc (0, 1, or 2), or -1 if invalid.</returns>
        public int GetRootArc()
        {
            var oidValue = GetOidValue();
            if (string.IsNullOrEmpty(oidValue))
                return -1;

            var firstDot = oidValue.IndexOf('.');
            var rootPart = firstDot > 0 ? oidValue.Substring(0, firstDot) : oidValue;

            return int.TryParse(rootPart, out int root) ? root : -1;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirOid"/> instance from an OID string.
        /// </summary>
        /// <param name="oid">The OID in dot notation (without "urn:oid:" prefix).</param>
        /// <returns>A new <see cref="FhirOid"/> instance.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="oid"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the OID format is invalid.</exception>
        public static FhirOid FromOid(string oid)
        {
            if (oid == null)
                throw new ArgumentNullException(nameof(oid));

            if (!Regex.IsMatch(oid, @"^[0-2](\.(0|[1-9][0-9]*))+$"))
                throw new ArgumentException("Invalid OID format", nameof(oid));

            return new FhirOid($"urn:oid:{oid}");
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string represents a valid oid value.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid oid; otherwise, <c>false</c>.</returns>
        private static bool IsValidOidValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用regex檢查格式：urn:oid:[0-2](\.(0|[1-9][0-9]*))+
            return Regex.IsMatch(value, @"^urn:oid:[0-2](\.(0|[1-9][0-9]*))+$");
        }

        /// <summary>
        /// Gets the expected format description for FHIR oid.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR oid.</returns>
        protected override string GetExpectedFormat()
        {
            return "urn:oid: followed by a valid OID in dot notation (e.g., urn:oid:2.16.840.1.113883.2.4.6.1)";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Oid value cannot be null or empty";

            if (!_stringValue.StartsWith("urn:oid:", StringComparison.OrdinalIgnoreCase))
                return $"'{_stringValue}' must start with 'urn:oid:'. {GetExpectedFormat()}";

            // 提取OID部分進行進一步驗證
            var oidPart = _stringValue.Substring(8); // 移除 "urn:oid:" 前綴
            if (!Regex.IsMatch(oidPart, @"^[0-2](\.(0|[1-9][0-9]*))+$"))
                return $"'{_stringValue}' has invalid OID format. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid FHIR oid. {GetExpectedFormat()}";
        }

        #endregion
    }
}
