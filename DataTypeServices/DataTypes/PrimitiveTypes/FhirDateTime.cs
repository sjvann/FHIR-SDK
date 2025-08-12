using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Globalization;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR dateTime primitive type.
    /// A date, date-time or partial date (e.g. just year or year + month) as used in human communication.
    /// </summary>
    /// <remarks>
    /// The FHIR dateTime type represents a date and time, including timezone information.
    /// It supports various levels of precision from year to milliseconds and can include timezone offsets.
    /// The format follows ISO 8601 with some FHIR-specific constraints.
    /// Supported formats:
    /// - YYYY (year only)
    /// - YYYY-MM (year and month)
    /// - YYYY-MM-DD (date only)
    /// - YYYY-MM-DDTHH:MM:SS (date and time)
    /// - YYYY-MM-DDTHH:MM:SS.sss (with milliseconds)
    /// - Any of the above with timezone: Z or ±HH:MM
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create various dateTime formats
    /// var yearOnly = new FhirDateTime("2023");
    /// var dateOnly = new FhirDateTime("2023-12-25");
    /// var dateTime = new FhirDateTime("2023-12-25T14:30:00");
    /// var withTimezone = new FhirDateTime("2023-12-25T14:30:00Z");
    ///
    /// // Create from DateTime
    /// var now = FhirDateTime.Now();
    /// var utcNow = FhirDateTime.UtcNow();
    ///
    /// // Access the value
    /// DateTime? dt = dateTime.Value;
    /// </code>
    /// </example>
    public class FhirDateTime : PrimitiveType<FhirDateTime, DateTime>, IDateTimeValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class.
        /// </summary>
        public FhirDateTime() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the dateTime value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirDateTime(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the dateTime value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirDateTime(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class from a DateTime value and element.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirDateTime(DateTime? value, Element? element) : base(FormatDateTime(value), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the dateTime value.</param>
        public FhirDateTime(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class from a DateTime value.
        /// </summary>
        /// <param name="value">The DateTime value.</param>
        public FhirDateTime(DateTime? value) : base(FormatDateTime(value), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDateTime"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the dateTime.</param>
        public FhirDateTime(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the DateTime value of this FHIR dateTime.
        /// </summary>
        /// <value>
        /// The DateTime value, or <c>null</c> if no value has been set or the value is invalid.
        /// For partial dates, missing components default to their minimum values.
        /// </value>
        public DateTime? Value => ParseDateTimeValue(_stringValue);

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
        /// Converts this dateTime to its JSON string representation.
        /// </summary>
        /// <returns>A JSON string representing this dateTime.</returns>
        public override string ToJsonString() => $"\"{_stringValue}\"";

        /// <summary>
        /// Gets the JSON representation of this dateTime value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this dateTime, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create(_stringValue);

        /// <summary>
        /// Validates whether the current value is a valid FHIR dateTime.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        public override bool IsValidValue() => IsValidDateTimeValue(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The DateTime value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Gets the precision level of this dateTime.
        /// </summary>
        /// <returns>The precision level of the dateTime.</returns>
        public DateTimePrecision GetPrecision()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return DateTimePrecision.Unknown;

            if (Regex.IsMatch(_stringValue, @"^\d{4}$"))
                return DateTimePrecision.Year;
            else if (Regex.IsMatch(_stringValue, @"^\d{4}-\d{2}$"))
                return DateTimePrecision.Month;
            else if (Regex.IsMatch(_stringValue, @"^\d{4}-\d{2}-\d{2}$"))
                return DateTimePrecision.Day;
            else if (Regex.IsMatch(_stringValue, @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}"))
                return DateTimePrecision.Second;
            else if (Regex.IsMatch(_stringValue, @"^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}\.\d+"))
                return DateTimePrecision.Millisecond;
            else
                return DateTimePrecision.Unknown;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirDateTime"/> instance representing the current date and time.
        /// </summary>
        /// <returns>A new <see cref="FhirDateTime"/> instance with the current local date and time.</returns>
        public static FhirDateTime Now() => new FhirDateTime(DateTime.Now);

        /// <summary>
        /// Creates a new <see cref="FhirDateTime"/> instance representing the current UTC date and time.
        /// </summary>
        /// <returns>A new <see cref="FhirDateTime"/> instance with the current UTC date and time.</returns>
        public static FhirDateTime UtcNow() => new FhirDateTime(DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));

        /// <summary>
        /// Creates a new <see cref="FhirDateTime"/> instance from a DateTimeOffset.
        /// </summary>
        /// <param name="dateTimeOffset">The DateTimeOffset value.</param>
        /// <returns>A new <see cref="FhirDateTime"/> instance with timezone information.</returns>
        public static FhirDateTime FromDateTimeOffset(DateTimeOffset dateTimeOffset)
        {
            return new FhirDateTime(dateTimeOffset.ToString("yyyy-MM-ddTHH:mm:sszzz"));
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR dateTime.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR dateTime.</returns>
        protected override string GetExpectedFormat()
        {
            return "FHIR dateTime format: YYYY, YYYY-MM, YYYY-MM-DD, or YYYY-MM-DDTHH:MM:SS[.sss][Z|(+|-)HH:MM] (e.g., 2023-12-25T14:30:00Z)";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "DateTime value cannot be null or empty";

            // 檢查基本格式
            if (_stringValue.Length < 4)
                return $"'{_stringValue}' is too short for a valid dateTime. {GetExpectedFormat()}";

            // 檢查年份
            if (!_stringValue.Substring(0, 4).All(char.IsDigit))
                return $"'{_stringValue}' must start with a 4-digit year. {GetExpectedFormat()}";

            // 嘗試解析以提供更具體的錯誤
            try
            {
                DateTime.Parse(_stringValue);
                return $"'{_stringValue}' is not in valid FHIR dateTime format. {GetExpectedFormat()}";
            }
            catch (FormatException)
            {
                return $"'{_stringValue}' contains invalid date/time components. {GetExpectedFormat()}";
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Formats a DateTime value to FHIR dateTime string format.
        /// </summary>
        /// <param name="value">The DateTime value to format.</param>
        /// <returns>The formatted FHIR dateTime string, or <c>null</c> if value is null.</returns>
        private static string? FormatDateTime(DateTime? value)
        {
            if (!value.HasValue)
                return null;

            // Use ISO 8601 format with seconds precision
            return value.Value.ToString("yyyy-MM-ddTHH:mm:ss");
        }

        /// <summary>
        /// Parses a FHIR dateTime string into a DateTime value.
        /// </summary>
        /// <param name="value">The FHIR dateTime string to parse.</param>
        /// <returns>The parsed DateTime value, or <c>null</c> if parsing fails.</returns>
        private static DateTime? ParseDateTimeValue(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            try
            {
                // Handle different precision levels
                if (Regex.IsMatch(value, @"^\d{4}$")) // Year only
                {
                    return new DateTime(int.Parse(value), 1, 1);
                }
                else if (Regex.IsMatch(value, @"^\d{4}-\d{2}$")) // Year-Month
                {
                    var parts = value.Split('-');
                    return new DateTime(int.Parse(parts[0]), int.Parse(parts[1]), 1);
                }
                else if (Regex.IsMatch(value, @"^\d{4}-\d{2}-\d{2}$")) // Date only
                {
                    return DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                }
                else
                {
                    // Full dateTime with possible timezone
                    return DateTime.Parse(value, CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
                }
            }
            catch
            {
                // Parsing failed
            }

            return null;
        }

        /// <summary>
        /// Validates whether the specified string is a valid FHIR dateTime.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR dateTime; otherwise, <c>false</c>.</returns>
        private static bool IsValidDateTimeValue(string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            // 檢查基本格式：不允許前後空白
            if (value != value.Trim()) return false;

            // 使用FHIR規範的regex，但更嚴格
            var fhirDateTimeRegex = @"^([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)(-(0[1-9]|1[0-2])(-(0[1-9]|[1-2][0-9]|3[0-1])(T([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?)?)?(Z|(\+|-)((0[0-9]|1[0-3]):[0-5][0-9]|14:00)?)?)?$";

            if (!Regex.IsMatch(value, fhirDateTimeRegex)) return false;

            // 額外的語義驗證
            return ValidateDateTimeSemantics(value);
        }

        /// <summary>
        /// Validates the semantic correctness of a dateTime value.
        /// </summary>
        /// <param name="value">The dateTime string to validate.</param>
        /// <returns><c>true</c> if semantically valid; otherwise, <c>false</c>.</returns>
        private static bool ValidateDateTimeSemantics(string value)
        {
            try
            {
                // Use the parsing method to validate semantics
                return ParseDateTimeValue(value) != null;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }

    /// <summary>
    /// Represents the precision level of a FHIR dateTime.
    /// </summary>
    public enum DateTimePrecision
    {
        /// <summary>
        /// Unknown or invalid precision.
        /// </summary>
        Unknown,

        /// <summary>
        /// Year precision (YYYY).
        /// </summary>
        Year,

        /// <summary>
        /// Month precision (YYYY-MM).
        /// </summary>
        Month,

        /// <summary>
        /// Day precision (YYYY-MM-DD).
        /// </summary>
        Day,

        /// <summary>
        /// Second precision (YYYY-MM-DDTHH:MM:SS).
        /// </summary>
        Second,

        /// <summary>
        /// Millisecond precision (YYYY-MM-DDTHH:MM:SS.sss).
        /// </summary>
        Millisecond
    }
}
