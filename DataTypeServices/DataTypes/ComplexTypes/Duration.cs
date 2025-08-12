using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Duration data type.
    /// A length of time.
    /// </summary>
    /// <remarks>
    /// A Duration represents a length of time with a value and unit. It is commonly
    /// used to represent time periods, intervals, and durations in healthcare,
    /// such as medication administration periods, appointment durations, or
    /// treatment timeframes.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple duration
    /// var duration = new Duration
    /// {
    ///     Value = new FhirDecimal(30),
    ///     Unit = new FhirString("minutes")
    /// };
    ///
    /// // Create a duration with comparator
    /// var rangeDuration = new Duration
    /// {
    ///     Comparator = new FhirCode("&lt;"),
    ///     Value = new FhirDecimal(60),
    ///     Unit = new FhirString("minutes")
    /// };
    ///
    /// // Create a duration with system and code
    /// var systemDuration = new Duration
    /// {
    ///     Value = new FhirDecimal(2),
    ///     Unit = new FhirString("hours"),
    ///     System = new FhirUri("http://unitsofmeasure.org"),
    ///     Code = new FhirCode("h")
    /// };
    ///
    /// // Create a duration for medication administration
    /// var medicationDuration = new Duration
    /// {
    ///     Value = new FhirDecimal(15),
    ///     Unit = new FhirString("minutes"),
    ///     System = new FhirUri("http://unitsofmeasure.org"),
    ///     Code = new FhirCode("min")
    /// };
    /// </code>
    /// </example>
    public class Duration : ComplexType<Duration>
    {
        private FhirDecimal? _Value;
        private FhirCode? _Comparator;
        private FhirString? _Unit;
        private FhirUri? _System;
        private FhirCode? _Code;

        /// <summary>
        /// Gets or sets the numerical value of the duration.
        /// </summary>
        /// <value>
        /// The numerical value of the duration.
        /// </value>
        /// <remarks>
        /// The value represents the numerical amount of the duration. It should be a
        /// decimal number that accurately represents the time period.
        /// </remarks>
        public FhirDecimal? Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                OnPropertyChanged("value", value);
            }
        }

        /// <summary>
        /// Gets or sets the comparator for this duration.
        /// </summary>
        /// <value>
        /// A coded value indicating how the duration should be understood and evaluated.
        /// </value>
        /// <remarks>
        /// The comparator allows for range expressions. Common values include:
        /// &lt; (less than), &lt;= (less than or equal), &gt; (greater than),
        /// &gt;= (greater than or equal), ~ (approximately).
        /// </remarks>
        public FhirCode? Comparator
        {
            get { return _Comparator; }
            set
            {
                _Comparator = value;
                OnPropertyChanged("comparator", value);
            }
        }

        /// <summary>
        /// Gets or sets the unit of time for this duration.
        /// </summary>
        /// <value>
        /// A human-readable representation of the unit of time.
        /// </value>
        /// <remarks>
        /// The unit provides a human-readable description of the unit of time.
        /// Examples include "seconds", "minutes", "hours", "days", "weeks", etc.
        /// </remarks>
        public FhirString? Unit
        {
            get { return _Unit; }
            set
            {
                _Unit = value;
                OnPropertyChanged("unit", value);
            }
        }

        /// <summary>
        /// Gets or sets the system that defines the unit of time.
        /// </summary>
        /// <value>
        /// The URI that identifies the coding system for the unit.
        /// </value>
        /// <remarks>
        /// The system URI should be a stable, canonical URL that identifies the
        /// coding system for the unit. This allows systems to understand the
        /// context and meaning of the unit.
        /// </remarks>
        public FhirUri? System
        {
            get { return _System; }
            set
            {
                _System = value;
                OnPropertyChanged("system", value);
            }
        }

        /// <summary>
        /// Gets or sets the code for the unit of time.
        /// </summary>
        /// <value>
        /// The code that identifies the unit of time within the coding system.
        /// </value>
        /// <remarks>
        /// The code provides a standardized identifier for the unit of time
        /// within the specified coding system. This allows for precise
        /// identification and comparison of time units.
        /// </remarks>
        public FhirCode? Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("code", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class.
        /// </summary>
        public Duration() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the duration data.</param>
        public Duration(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the duration.</param>
        public Duration(string value) : base(value) { }
    }
}
