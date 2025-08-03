
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Range data type.
    /// A set of ordered Quantities defined by a low and high limit.
    /// </summary>
    /// <remarks>
    /// A Range represents a set of values that fall between a low and high boundary.
    /// It is commonly used to represent reference ranges for laboratory values,
    /// acceptable ranges for vital signs, or any other bounded set of values.
    /// The low and high values are inclusive of the range.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple range
    /// var range = new Range
    /// {
    ///     Low = new SimpleQuantity { Value = new FhirDecimal(10), Unit = new FhirString("mg/dL") },
    ///     High = new SimpleQuantity { Value = new FhirDecimal(20), Unit = new FhirString("mg/dL") }
    /// };
    ///
    /// // Create a reference range for glucose
    /// var glucoseRange = new Range
    /// {
    ///     Low = new SimpleQuantity { Value = new FhirDecimal(70), Unit = new FhirString("mg/dL") },
    ///     High = new SimpleQuantity { Value = new FhirDecimal(100), Unit = new FhirString("mg/dL") }
    /// };
    ///
    /// // Create a range with only high limit
    /// var maxRange = new Range
    /// {
    ///     High = new SimpleQuantity { Value = new FhirDecimal(5), Unit = new FhirString("mmol/L") }
    /// };
    /// </code>
    /// </example>
    public class Range : ComplexType<Range>
    {
        #region Private Fields

        private SimpleQuantity? _Low;
        private SimpleQuantity? _High;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the low limit of the range.
        /// </summary>
        /// <value>
        /// The lower bound of the range. If not present, there is no lower bound.
        /// </value>
        /// <remarks>
        /// The low value represents the lower boundary of the range. If this is not
        /// specified, the range has no lower bound. The low value is inclusive
        /// in the range.
        /// </remarks>
        public SimpleQuantity? Low
        {
            get { return _Low; }
            set
            {
                _Low = value;
                OnPropertyChanged("low", value);
            }
        }

        /// <summary>
        /// Gets or sets the high limit of the range.
        /// </summary>
        /// <value>
        /// The upper bound of the range. If not present, there is no upper bound.
        /// </value>
        /// <remarks>
        /// The high value represents the upper boundary of the range. If this is not
        /// specified, the range has no upper bound. The high value is inclusive
        /// in the range.
        /// </remarks>
        public SimpleQuantity? High
        {
            get { return _High; }
            set
            {
                _High = value;
                OnPropertyChanged("high", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Range"/> class.
        /// </summary>
        public Range() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the range data.</param>
        public Range(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Range"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the range.</param>
        public Range(string value) : base(value) { }

        #endregion
    }
}
