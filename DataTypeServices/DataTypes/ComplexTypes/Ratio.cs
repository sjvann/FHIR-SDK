
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Ratio data type.
    /// A relationship of two Quantity values - expressed as a numerator and a denominator.
    /// </summary>
    /// <remarks>
    /// A Ratio represents a relationship between two quantities, typically expressed as
    /// a numerator divided by a denominator. This is commonly used for concentrations,
    /// rates, and other proportional relationships in healthcare data.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple ratio
    /// var ratio = new Ratio
    /// {
    ///     Numerator = new Quantity { Value = new FhirDecimal(10), Unit = new FhirString("mg") },
    ///     Denominator = new SimpleQuantity { Value = new FhirDecimal(1), Unit = new FhirString("ml") }
    /// };
    ///
    /// // Create a concentration ratio
    /// var concentration = new Ratio
    /// {
    ///     Numerator = new Quantity { Value = new FhirDecimal(5), Unit = new FhirString("mmol") },
    ///     Denominator = new SimpleQuantity { Value = new FhirDecimal(1), Unit = new FhirString("L") }
    /// };
    ///
    /// // Create a dosage ratio
    /// var dosageRatio = new Ratio
    /// {
    ///     Numerator = new Quantity { Value = new FhirDecimal(2), Unit = new FhirString("tablets") },
    ///     Denominator = new SimpleQuantity { Value = new FhirDecimal(1), Unit = new FhirString("dose") }
    /// };
    /// </code>
    /// </example>
    public class Ratio : ComplexType<Ratio>
    {
        #region Private Fields

        private Quantity? _Numerator;
        private SimpleQuantity? _Denominator;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the numerator value of the ratio.
        /// </summary>
        /// <value>
        /// The numerator quantity of the ratio relationship.
        /// </value>
        /// <remarks>
        /// The numerator represents the top part of the ratio. It can be any quantity
        /// with a value and unit. The numerator and denominator together define the
        /// proportional relationship.
        /// </remarks>
        public Quantity? Numerator
        {
            get { return _Numerator; }
            set
            {
                _Numerator = value;
                OnPropertyChanged("numerator", value);
            }
        }

        /// <summary>
        /// Gets or sets the denominator value of the ratio.
        /// </summary>
        /// <value>
        /// The denominator quantity of the ratio relationship.
        /// </value>
        /// <remarks>
        /// The denominator represents the bottom part of the ratio. It is typically
        /// a SimpleQuantity (which cannot have a range or comparator). The denominator
        /// should not be zero.
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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Ratio"/> class.
        /// </summary>
        public Ratio() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ratio"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the ratio data.</param>
        public Ratio(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ratio"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the ratio.</param>
        public Ratio(string value) : base(value) { }

        #endregion
    }
}
