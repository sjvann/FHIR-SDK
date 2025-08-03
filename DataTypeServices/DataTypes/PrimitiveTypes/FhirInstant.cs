using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR instant primitive type.
    /// An instant in time - known at least to the second.
    /// </summary>
    /// <remarks>
    /// The FHIR instant type represents a specific moment in time with timezone information.
    /// It is always precise to at least the second and must include timezone information.
    /// The format follows ISO 8601 with mandatory timezone (Z for UTC or ±HH:MM for offset).
    /// This type is used for timestamps that need to be precise and unambiguous across timezones.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create instant values
    /// var timestamp = new FhirInstant("2023-12-25T10:30:00.123Z");
    /// var withOffset = new FhirInstant("2023-12-25T10:30:00+05:00");
    ///
    /// // Create from DateTimeOffset
    /// var now = FhirInstant.Now();
    /// var utcNow = FhirInstant.UtcNow();
    ///
    /// // Access the value
    /// DateTimeOffset? instant = timestamp.Value;
    /// </code>
    /// </example>
    public class FhirInstant : PrimitiveType<FhirInstant, DateTime>, IDatetimeOffsetValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class.
        /// </summary>
        public FhirInstant() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the instant value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirInstant(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the instant value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirInstant(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class from a DateTimeOffset value and element.
        /// </summary>
        /// <param name="value">The DateTimeOffset value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirInstant(DateTimeOffset? value, Element? element) : base(FormatInstant(value), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the instant value.</param>
        public FhirInstant(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class from a DateTimeOffset value.
        /// </summary>
        /// <param name="value">The DateTimeOffset value.</param>
        public FhirInstant(DateTimeOffset? value) : base(FormatInstant(value), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirInstant"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the instant.</param>
        public FhirInstant(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the DateTimeOffset value of this FHIR instant.
        /// </summary>
        /// <value>
        /// The DateTimeOffset value, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        public DateTimeOffset? Value => ParseInstantValue(_stringValue);

        /// <summary>
        /// Gets a value indicating whether this instance has a value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => !string.IsNullOrEmpty(_stringValue) && IsValidValue();

        #endregion

        #region Public Methods

        /// <summary>
        /// Converts this instant to its JSON string representation.
        /// </summary>
        /// <returns>A JSON string representing this instant.</returns>
        public override string ToJsonString() => $"\"{_stringValue}\"";

        /// <summary>
        /// Gets the JSON representation of this instant value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this instant, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create(_stringValue);

        /// <summary>
        /// Validates whether the current value is a valid FHIR instant.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR instants must include timezone information and be precise to at least the second.
        /// </remarks>
        public override bool IsValidValue() => IsValidInstantString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The DateTimeOffset value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Converts this instant to UTC.
        /// </summary>
        /// <returns>A new <see cref="FhirInstant"/> representing the same moment in UTC, or <c>null</c> if no value is set.</returns>
        public FhirInstant? ToUtc()
        {
            var value = Value;
            if (value.HasValue)
            {
                return new FhirInstant(value.Value.UtcDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
            }
            return null;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirInstant"/> instance representing the current moment.
        /// </summary>
        /// <returns>A new <see cref="FhirInstant"/> instance with the current local date and time.</returns>
        public static FhirInstant Now() => new FhirInstant(DateTimeOffset.Now);

        /// <summary>
        /// Creates a new <see cref="FhirInstant"/> instance representing the current UTC moment.
        /// </summary>
        /// <returns>A new <see cref="FhirInstant"/> instance with the current UTC date and time.</returns>
        public static FhirInstant UtcNow() => new FhirInstant(DateTimeOffset.UtcNow);

        /// <summary>
        /// Creates a new <see cref="FhirInstant"/> instance from a Unix timestamp.
        /// </summary>
        /// <param name="unixTimestamp">The Unix timestamp (seconds since 1970-01-01 00:00:00 UTC).</param>
        /// <returns>A new <see cref="FhirInstant"/> instance.</returns>
        public static FhirInstant FromUnixTimestamp(long unixTimestamp)
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            return new FhirInstant(dateTimeOffset);
        }

        /// <summary>
        /// Creates a new <see cref="FhirInstant"/> instance from a Unix timestamp in milliseconds.
        /// </summary>
        /// <param name="unixTimestampMs">The Unix timestamp in milliseconds.</param>
        /// <returns>A new <see cref="FhirInstant"/> instance.</returns>
        public static FhirInstant FromUnixTimestampMs(long unixTimestampMs)
        {
            var dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(unixTimestampMs);
            return new FhirInstant(dateTimeOffset);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR instant.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR instant.</returns>
        protected override string GetExpectedFormat()
        {
            return "FHIR instant format: YYYY-MM-DDTHH:MM:SS[.sss](Z|(+|-)HH:MM) (e.g., '2023-12-25T10:30:00.123Z')";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Instant value cannot be null or empty";

            if (!_stringValue.Contains('T'))
                return $"'{_stringValue}' must include time component. {GetExpectedFormat()}";

            if (!(_stringValue.EndsWith('Z') || _stringValue.Contains('+') || _stringValue.LastIndexOf('-') > 10))
                return $"'{_stringValue}' must include timezone information. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid FHIR instant format. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Formats a DateTimeOffset to FHIR instant string format.
        /// </summary>
        /// <param name="value">The DateTimeOffset to format.</param>
        /// <returns>The formatted FHIR instant string, or <c>null</c> if value is null.</returns>
        private static string? FormatInstant(DateTimeOffset? value)
        {
            if (!value.HasValue)
                return null;

            // Format with milliseconds and timezone
            if (value.Value.Millisecond > 0)
                return value.Value.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
            else
                return value.Value.ToString("yyyy-MM-ddTHH:mm:sszzz");
        }

        /// <summary>
        /// Validates whether the specified string is a valid FHIR instant.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR instant; otherwise, <c>false</c>.</returns>
        private static bool IsValidInstantString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Must include time component
            if (!value.Contains('T'))
                return false;

            // Must include timezone
            if (!(value.EndsWith('Z') || value.Contains('+') || value.LastIndexOf('-') > 10))
                return false;

            // Check format with regex
            var instantRegex = @"^([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00))$";

            if (!Regex.IsMatch(value, instantRegex))
                return false;

            // Try to parse to verify it's valid
            return ParseInstantValue(value) != null;
        }

        /// <summary>
        /// Parses a FHIR instant string into a DateTimeOffset value.
        /// </summary>
        /// <param name="value">The FHIR instant string to parse.</param>
        /// <returns>The parsed DateTimeOffset value, or <c>null</c> if parsing fails.</returns>
        private static DateTimeOffset? ParseInstantValue(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            try
            {
                return DateTimeOffset.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
            }
            catch
            {
                // Parsing failed
            }

            return null;
        }

        #endregion
    }
}
