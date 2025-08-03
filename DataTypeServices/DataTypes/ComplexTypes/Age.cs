using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Age - A duration of time during which an organism (or a process) has existed.
    /// This is a specialization of Quantity that represents an age.
    /// </summary>
    public class Age : Quantity
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Age() : base() { }

        /// <summary>
        /// Constructor from JSON object
        /// </summary>
        /// <param name="value">JSON object representing the Age</param>
        public Age(JsonObject value) : base(value) { }

        /// <summary>
        /// Constructor from JSON string
        /// </summary>
        /// <param name="value">JSON string representing the Age</param>
        public Age(string value) : base(value) { }

        /// <summary>
        /// Constructor with value and unit
        /// </summary>
        /// <param name="value">The age value</param>
        /// <param name="unit">The unit of age (e.g., "years", "months", "days")</param>
        public Age(decimal value, string unit) : base()
        {
            Value = new FhirDecimal(value);
            Unit = new FhirString(unit);
            System = new FhirUri("http://unitsofmeasure.org");
            
            // Set appropriate UCUM code based on unit
            Code = new FhirCode(GetUcumCodeForUnit(unit));
        }

        /// <summary>
        /// Constructor with value, unit, and system
        /// </summary>
        /// <param name="value">The age value</param>
        /// <param name="unit">The unit of age</param>
        /// <param name="system">The system URI</param>
        /// <param name="code">The code for the unit</param>
        public Age(decimal value, string unit, string system, string code) : base()
        {
            Value = new FhirDecimal(value);
            Unit = new FhirString(unit);
            System = new FhirUri(system);
            Code = new FhirCode(code);
        }

        /// <summary>
        /// Get FHIR type name
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter</param>
        /// <returns>The FHIR type name</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Age" : "age";

        /// <summary>
        /// Get the appropriate UCUM code for common age units
        /// </summary>
        /// <param name="unit">The unit string</param>
        /// <returns>The UCUM code</returns>
        private static string GetUcumCodeForUnit(string unit)
        {
            return unit.ToLowerInvariant() switch
            {
                "years" or "year" or "yr" or "y" => "a",
                "months" or "month" or "mo" => "mo",
                "weeks" or "week" or "wk" or "w" => "wk",
                "days" or "day" or "d" => "d",
                "hours" or "hour" or "hr" or "h" => "h",
                "minutes" or "minute" or "min" => "min",
                "seconds" or "second" or "sec" or "s" => "s",
                _ => unit
            };
        }

        /// <summary>
        /// Create an Age representing years
        /// </summary>
        /// <param name="years">Number of years</param>
        /// <returns>Age instance</returns>
        public static Age Years(decimal years)
        {
            return new Age(years, "years");
        }

        /// <summary>
        /// Create an Age representing months
        /// </summary>
        /// <param name="months">Number of months</param>
        /// <returns>Age instance</returns>
        public static Age Months(decimal months)
        {
            return new Age(months, "months");
        }

        /// <summary>
        /// Create an Age representing weeks
        /// </summary>
        /// <param name="weeks">Number of weeks</param>
        /// <returns>Age instance</returns>
        public static Age Weeks(decimal weeks)
        {
            return new Age(weeks, "weeks");
        }

        /// <summary>
        /// Create an Age representing days
        /// </summary>
        /// <param name="days">Number of days</param>
        /// <returns>Age instance</returns>
        public static Age Days(decimal days)
        {
            return new Age(days, "days");
        }

        /// <summary>
        /// Validate that this Age has appropriate constraints
        /// </summary>
        /// <returns>True if valid, false otherwise</returns>
        public bool IsValidAge()
        {
            // Age should have a positive value
            if (Value?.Value <= 0)
                return false;

            // Age should typically use time-based units
            var code = Code?.Value?.ToLowerInvariant();
            var validAgeCodes = new[] { "a", "mo", "wk", "d", "h", "min", "s" };

            if (!string.IsNullOrEmpty(code) && !validAgeCodes.Contains(code))
                return false;

            return true;
        }
    }
}
