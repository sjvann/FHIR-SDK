using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Globalization;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR date primitive type.
    /// A date, or partial date (e.g. just year or year + month).
    /// </summary>
    /// <remarks>
    /// The FHIR date type represents a date without time information. It can represent:
    /// - Full dates (YYYY-MM-DD)
    /// - Partial dates with year and month (YYYY-MM)
    /// - Year only (YYYY)
    /// The format follows ISO 8601 date format without time zone information.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a full date
    /// var birthDate = new FhirDate("2023-12-25");
    ///
    /// // Create from DateTime
    /// var today = FhirDate.Today();
    ///
    /// // Create partial dates
    /// var yearOnly = FhirDate.FromYear(2023);
    /// var yearMonth = FhirDate.FromYearMonth(2023, 12);
    ///
    /// // Access the value
    /// DateTime? date = birthDate.Value;
    /// </code>
    /// </example>
    public class FhirDate : PrimitiveType<FhirDate, DateTime>, IDateTimeValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class.
        /// </summary>
        public FhirDate() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the date value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirDate(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the date value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirDate(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class from a DateTime value and element.
        /// </summary>
        /// <param name="value">The DateTime value (time portion will be ignored).</param>
        /// <param name="element">The element metadata.</param>
        public FhirDate(DateTime? value, Element? element) : base(value?.ToString("yyyy-MM-dd"), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the date value.</param>
        public FhirDate(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class from a DateTime value.
        /// </summary>
        /// <param name="value">The DateTime value (time portion will be ignored).</param>
        public FhirDate(DateTime? value) : base(value?.ToString("yyyy-MM-dd"), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDate"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the date (YYYY, YYYY-MM, or YYYY-MM-DD).</param>
        public FhirDate(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the DateTime value of this FHIR date.
        /// </summary>
        /// <value>
        /// The DateTime value, or <c>null</c> if no value has been set or the value is invalid.
        /// For partial dates, missing components default to 1 (e.g., "2023" becomes "2023-01-01").
        /// </value>
        public DateTime? Value => ParseDateValue(_stringValue);

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
        /// Converts this date to its JSON string representation.
        /// </summary>
        /// <returns>A JSON string representing this date.</returns>
        public override string ToJsonString() => $"\"{_stringValue}\"";

        /// <summary>
        /// Gets the JSON representation of this date value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this date, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create(_stringValue);

        /// <summary>
        /// Validates whether the current value is a valid FHIR date.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR dates can be in the format YYYY, YYYY-MM, or YYYY-MM-DD.
        /// </remarks>
        public override bool IsValidValue() => IsValidDateString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The DateTime value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Gets the precision level of this date.
        /// </summary>
        /// <returns>The precision level (Year, Month, or Day).</returns>
        public DatePrecision GetPrecision()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return DatePrecision.Unknown;

            if (Regex.IsMatch(_stringValue, @"^\d{4}$"))
                return DatePrecision.Year;
            else if (Regex.IsMatch(_stringValue, @"^\d{4}-\d{2}$"))
                return DatePrecision.Month;
            else if (Regex.IsMatch(_stringValue, @"^\d{4}-\d{2}-\d{2}$"))
                return DatePrecision.Day;
            else
                return DatePrecision.Unknown;
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        /// Creates a new <see cref="FhirDate"/> instance representing today's date.
        /// </summary>
        /// <returns>A new <see cref="FhirDate"/> instance with today's date.</returns>
        public static FhirDate Today() => new FhirDate(DateTime.Today);

        /// <summary>
        /// Creates a new <see cref="FhirDate"/> instance from a year only.
        /// </summary>
        /// <param name="year">The year (e.g., 2023).</param>
        /// <returns>A new <see cref="FhirDate"/> instance with year precision.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when year is not between 1 and 9999.</exception>
        public static FhirDate FromYear(int year)
        {
            if (year < 1 || year > 9999)
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1 and 9999");

            return new FhirDate(year.ToString("0000"));
        }

        /// <summary>
        /// Creates a new <see cref="FhirDate"/> instance from year and month.
        /// </summary>
        /// <param name="year">The year (e.g., 2023).</param>
        /// <param name="month">The month (1-12).</param>
        /// <returns>A new <see cref="FhirDate"/> instance with month precision.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when parameters are out of valid range.</exception>
        public static FhirDate FromYearMonth(int year, int month)
        {
            if (year < 1 || year > 9999)
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be between 1 and 9999");
            if (month < 1 || month > 12)
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12");

            return new FhirDate($"{year:0000}-{month:00}");
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR dates.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR dates.</returns>
        protected override string GetExpectedFormat()
        {
            return "FHIR date format: YYYY, YYYY-MM, or YYYY-MM-DD (e.g., '2023', '2023-12', '2023-12-25')";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Date value cannot be null or empty";

            return $"'{_stringValue}' is not a valid FHIR date format. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string is a valid FHIR date.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR date; otherwise, <c>false</c>.</returns>
        private static bool IsValidDateString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Check format patterns
            var yearPattern = @"^([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)$";
            var yearMonthPattern = @"^([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])$";
            var fullDatePattern = @"^([0-9]([0-9]([0-9][1-9]|[1-9]0)|[1-9]00)|[1-9]000)-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$";

            if (Regex.IsMatch(value, yearPattern) ||
                Regex.IsMatch(value, yearMonthPattern) ||
                Regex.IsMatch(value, fullDatePattern))
            {
                // Additional validation: try to parse the date
                return ParseDateValue(value) != null;
            }

            return false;
        }

        /// <summary>
        /// Parses a FHIR date string into a DateTime value.
        /// </summary>
        /// <param name="value">The FHIR date string to parse.</param>
        /// <returns>The parsed DateTime value, or <c>null</c> if parsing fails.</returns>
        private static DateTime? ParseDateValue(string? value)
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
                else if (Regex.IsMatch(value, @"^\d{4}-\d{2}-\d{2}$")) // Full date
                {
                    return DateTime.ParseExact(value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
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

    /// <summary>
    /// Represents the precision level of a FHIR date.
    /// </summary>
    public enum DatePrecision
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
        Day
    }
}
