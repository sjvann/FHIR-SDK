using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR time primitive type.
    /// A time during the day, with no date specified.
    /// </summary>
    /// <remarks>
    /// The FHIR time type represents a time of day without date information.
    /// It follows the format HH:MM:SS with optional milliseconds (HH:MM:SS.sss).
    /// The time is based on a 24-hour clock and does not include timezone information.
    /// Valid range: 00:00:00 to 23:59:59.999
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create time values
    /// var appointmentTime = new FhirTime("14:30:00");
    /// var preciseTime = new FhirTime("09:15:30.500");
    ///
    /// // Create from TimeSpan
    /// var timeSpan = new TimeSpan(14, 30, 0);
    /// var time = FhirTime.FromTimeSpan(timeSpan);
    ///
    /// // Create current time
    /// var now = FhirTime.Now();
    ///
    /// // Access the value
    /// TimeSpan? ts = time.TimeSpanValue;
    /// </code>
    /// </example>
    public class FhirTime : PrimitiveType<FhirTime, DateTime>, IDateTimeValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class.
        /// </summary>
        public FhirTime() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the time value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirTime(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the time value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirTime(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a DateTime value and element.
        /// </summary>
        /// <param name="value">The DateTime value (only time portion will be used).</param>
        /// <param name="element">The element metadata.</param>
        public FhirTime(DateTime? value, Element? element) : base(value?.ToString("HH:mm:ss"), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the time value.</param>
        public FhirTime(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a DateTime value.
        /// </summary>
        /// <param name="value">The DateTime value (only time portion will be used).</param>
        public FhirTime(DateTime? value) : base(value?.ToString("HH:mm:ss"), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the time (HH:MM:SS or HH:MM:SS.sss).</param>
        public FhirTime(string? value) : base(value, null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirTime"/> class from a TimeSpan value.
        /// </summary>
        /// <param name="timeSpan">The TimeSpan value representing the time of day.</param>
        public FhirTime(TimeSpan timeSpan) : base(FormatTimeSpan(timeSpan), null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the DateTime value of this FHIR time (with today's date).
        /// </summary>
        /// <value>
        /// The DateTime value with today's date and the specified time, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        /// <remarks>
        /// This property combines today's date with the time value for compatibility with DateTime-based APIs.
        /// Use <see cref="TimeSpanValue"/> if you only need the time portion.
        /// </remarks>
        public DateTime? Value => ParseTimeValue(_stringValue);

        /// <summary>
        /// Gets the TimeSpan value of this FHIR time.
        /// </summary>
        /// <value>
        /// The TimeSpan value representing the time of day, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        public TimeSpan? TimeSpanValue => ParseTimeSpanValue(_stringValue);

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
        /// Gets the FHIR type name for this time type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("Time" or "time").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Time" : "time";

        /// <summary>
        /// Gets the JSON representation of this time value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this time, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create(_stringValue);

        /// <summary>
        /// Validates whether the current value is a valid FHIR time.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR times must be in the format HH:MM:SS or HH:MM:SS.sss with valid time components.
        /// </remarks>
        public override bool IsValidValue() => IsValidTimeString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The TimeSpan value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => TimeSpanValue;

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirTime"/> instance representing the current time.
        /// </summary>
        /// <returns>A new <see cref="FhirTime"/> instance with the current time.</returns>
        public static FhirTime Now() => new FhirTime(DateTime.Now);

        /// <summary>
        /// Creates a new <see cref="FhirTime"/> instance from a TimeSpan.
        /// </summary>
        /// <param name="timeSpan">The TimeSpan representing the time of day.</param>
        /// <returns>A new <see cref="FhirTime"/> instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when timeSpan is negative or >= 24 hours.</exception>
        public static FhirTime FromTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan < TimeSpan.Zero || timeSpan >= TimeSpan.FromDays(1))
                throw new ArgumentOutOfRangeException(nameof(timeSpan), "TimeSpan must be between 00:00:00 and 23:59:59.999");

            return new FhirTime(timeSpan);
        }

        /// <summary>
        /// Creates a new <see cref="FhirTime"/> instance from hour, minute, and second components.
        /// </summary>
        /// <param name="hour">The hour (0-23).</param>
        /// <param name="minute">The minute (0-59).</param>
        /// <param name="second">The second (0-59).</param>
        /// <returns>A new <see cref="FhirTime"/> instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when any component is out of valid range.</exception>
        public static FhirTime FromComponents(int hour, int minute, int second)
        {
            if (hour < 0 || hour > 23)
                throw new ArgumentOutOfRangeException(nameof(hour), "Hour must be between 0 and 23");
            if (minute < 0 || minute > 59)
                throw new ArgumentOutOfRangeException(nameof(minute), "Minute must be between 0 and 59");
            if (second < 0 || second > 59)
                throw new ArgumentOutOfRangeException(nameof(second), "Second must be between 0 and 59");

            return new FhirTime(new TimeSpan(hour, minute, second));
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR time.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR time.</returns>
        protected override string GetExpectedFormat()
        {
            return "FHIR time format: HH:MM:SS or HH:MM:SS.sss (e.g., '14:30:00', '09:15:30.500')";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Time value cannot be null or empty";

            return $"'{_stringValue}' is not a valid FHIR time format. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Formats a TimeSpan to FHIR time string format.
        /// </summary>
        /// <param name="timeSpan">The TimeSpan to format.</param>
        /// <returns>The formatted FHIR time string.</returns>
        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan.Milliseconds > 0)
                return timeSpan.ToString(@"hh\:mm\:ss\.fff");
            else
                return timeSpan.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Validates whether the specified string is a valid FHIR time.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR time; otherwise, <c>false</c>.</returns>
        private static bool IsValidTimeString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Check format with regex
            if (!Regex.IsMatch(value, @"^([01][0-9]|2[0-3]):[0-5][0-9]:([0-5][0-9]|60)(\.[0-9]{1,9})?$"))
                return false;

            // Try to parse to verify it's valid
            return ParseTimeSpanValue(value) != null;
        }

        /// <summary>
        /// Parses a FHIR time string into a DateTime value (with today's date).
        /// </summary>
        /// <param name="value">The FHIR time string to parse.</param>
        /// <returns>The parsed DateTime value, or <c>null</c> if parsing fails.</returns>
        private static DateTime? ParseTimeValue(string? value)
        {
            var timeSpan = ParseTimeSpanValue(value);
            if (timeSpan.HasValue)
            {
                return DateTime.Today.Add(timeSpan.Value);
            }
            return null;
        }

        /// <summary>
        /// Parses a FHIR time string into a TimeSpan value.
        /// </summary>
        /// <param name="value">The FHIR time string to parse.</param>
        /// <returns>The parsed TimeSpan value, or <c>null</c> if parsing fails.</returns>
        private static TimeSpan? ParseTimeSpanValue(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            try
            {
                // Handle format with milliseconds
                if (value.Contains('.'))
                {
                    return TimeSpan.ParseExact(value, @"hh\:mm\:ss\.fff", CultureInfo.InvariantCulture);
                }
                else
                {
                    return TimeSpan.ParseExact(value, @"hh\:mm\:ss", CultureInfo.InvariantCulture);
                }
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
