
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Money data type.
    /// An amount of economic utility in some recognized currency.
    /// </summary>
    /// <remarks>
    /// Money represents a monetary amount with a specific currency. It is used for
    /// financial transactions, pricing, billing, and other economic activities in
    /// healthcare. The currency should be specified using ISO 4217 currency codes.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple money amount
    /// var money = new Money
    /// {
    ///     Value = new FhirDecimal(100.50m),
    ///     Currency = new FhirCode("USD")
    /// };
    ///
    /// // Create with different currency
    /// var euroAmount = new Money
    /// {
    ///     Value = new FhirDecimal(85.25m),
    ///     Currency = new FhirCode("EUR")
    /// };
    ///
    /// // Create for medication cost
    /// var medicationCost = new Money
    /// {
    ///     Value = new FhirDecimal(25.99m),
    ///     Currency = new FhirCode("USD")
    /// };
    /// </code>
    /// </example>
    public class Money : ComplexType<Money>
    {
        #region Private Fields

        private FhirDecimal? _Value;
        private FhirCode? _Currency;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the numerical value of the money amount.
        /// </summary>
        /// <value>
        /// The numerical value of the monetary amount.
        /// </value>
        /// <remarks>
        /// The value represents the numerical amount of money. It should be a decimal
        /// number that accurately represents the monetary value, including cents or
        /// other fractional units as appropriate for the currency.
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
        /// Gets or sets the currency code for this monetary amount.
        /// </summary>
        /// <value>
        /// The ISO 4217 currency code (e.g., "USD", "EUR", "JPY").
        /// </value>
        /// <remarks>
        /// The currency should be specified using ISO 4217 currency codes. Common
        /// examples include USD (US Dollar), EUR (Euro), JPY (Japanese Yen), etc.
        /// This allows for proper interpretation and conversion of monetary values.
        /// </remarks>
        public FhirCode? Currency
        {
            get { return _Currency; }
            set
            {
                _Currency = value;
                OnPropertyChanged("currency", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        public Money() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the money data.</param>
        public Money(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the money amount.</param>
        public Money(string value) : base(value) { }

        #endregion
    }
}
