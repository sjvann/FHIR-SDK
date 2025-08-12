
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR RatioRange data type.
    /// A set of ordered Quantities defined by a low and high limit for the numerator.
    /// </summary>
    /// <remarks>
    /// A RatioRange represents a range of ratios where the numerator can vary between
    /// a low and high value, while the denominator remains constant. This is commonly
    /// used to represent reference ranges for laboratory values that are expressed as
    /// ratios, such as albumin/globulin ratios or other proportional measurements.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple ratio range
    /// var ratioRange = new RatioRange
    /// {
    ///     LowNumerator = new SimpleQuantity { Value = new FhirDecimal(1.0m), Unit = new FhirString("g/dL") },
    ///     HighNumerator = new SimpleQuantity { Value = new FhirDecimal(2.5m), Unit = new FhirString("g/dL") },
    ///     Denominator = new SimpleQuantity { Value = new FhirDecimal(1.0m), Unit = new FhirString("g/dL") }
    /// };
    ///
    /// // Create a ratio range for albumin/globulin ratio
    /// var albuminGlobulinRange = new RatioRange
    /// {
    ///     LowNumerator = new SimpleQuantity { Value = new FhirDecimal(3.4m), Unit = new FhirString("g/dL") },
    ///     HighNumerator = new SimpleQuantity { Value = new FhirDecimal(5.4m), Unit = new FhirString("g/dL") },
    ///     Denominator = new SimpleQuantity { Value = new FhirDecimal(1.0m), Unit = new FhirString("g/dL") }
    /// };
    ///
    /// // Create a ratio range with only high limit
    /// var maxRatioRange = new RatioRange
    /// {
    ///     HighNumerator = new SimpleQuantity { Value = new FhirDecimal(10.0m), Unit = new FhirString("mg/dL") },
    ///     Denominator = new SimpleQuantity { Value = new FhirDecimal(1.0m), Unit = new FhirString("dL") }
    /// };
    /// </code>
    /// </example>
    public class RatioRange : ComplexType<RatioRange>
    {
        private SimpleQuantity? _LowNumerator;
        private SimpleQuantity? _HighNumerator;
        private SimpleQuantity? _Denominator;

        /// <summary>
        /// Gets or sets the low limit of the numerator range.
        /// </summary>
        /// <value>
        /// The lower bound of the numerator range. If not present, there is no lower bound.
        /// </value>
        /// <remarks>
        /// The lowNumerator represents the lower boundary of the numerator range.
        /// If this is not specified, the ratio range has no lower bound for the numerator.
        /// The lowNumerator value is inclusive in the range.
        /// </remarks>
        public SimpleQuantity? LowNumerator
        {
            get { return _LowNumerator; }
            set
            {
                _LowNumerator = value;
                OnPropertyChanged("lowNumerator", value);
            }
        }

        /// <summary>
        /// Gets or sets the high limit of the numerator range.
        /// </summary>
        /// <value>
        /// The upper bound of the numerator range. If not present, there is no upper bound.
        /// </value>
        /// <remarks>
        /// The highNumerator represents the upper boundary of the numerator range.
        /// If this is not specified, the ratio range has no upper bound for the numerator.
        /// The highNumerator value is inclusive in the range.
        /// </remarks>
        public SimpleQuantity? HighNumerator
        {
            get { return _HighNumerator; }
            set
            {
                _HighNumerator = value;
                OnPropertyChanged("highNumerator", value);
            }
        }

        /// <summary>
        /// Gets or sets the denominator value for the ratio range.
        /// </summary>
        /// <value>
        /// The denominator value that remains constant across the ratio range.
        /// </value>
        /// <remarks>
        /// The denominator represents the constant value in the ratio relationship.
        /// This value remains the same while the numerator can vary between the
        /// lowNumerator and highNumerator values.
        /// </remarks>
        public SimpleQuantity? Denominator
        {
            get { return _Denominator; }
            set
            {
                _Denominator = value;
                OnPropertyChanged("denominator", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatioRange"/> class.
        /// </summary>
        public RatioRange() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatioRange"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the ratio range data.</param>
        public RatioRange(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RatioRange"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the ratio range.</param>
        public RatioRange(string value) : base(value) { }
    }
}
