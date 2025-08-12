
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR SimpleQuantity data type.
    /// A measured amount (or an amount that can potentially be measured).
    /// </summary>
    /// <remarks>
    /// SimpleQuantity is a simplified version of Quantity that does not support comparators
    /// (like &lt;, &gt;, etc.). It is used when you need to represent a measured amount
    /// without the complexity of range comparisons. This is commonly used in contexts
    /// where you need a simple numeric value with units.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple quantity
    /// var quantity = new SimpleQuantity
    /// {
    ///     Value = new FhirDecimal(10.5m),
    ///     Unit = new FhirString("mg")
    /// };
    ///
    /// // Create with system and code
    /// var systemQuantity = new SimpleQuantity
    /// {
    ///     Value = new FhirDecimal(5.0m),
    ///     Unit = new FhirString("ml"),
    ///     System = new FhirUri("http://unitsofmeasure.org"),
    ///     Code = new FhirCode("ml")
    /// };
    ///
    /// // Create for medication dosage
    /// var dosage = new SimpleQuantity
    /// {
    ///     Value = new FhirDecimal(2.0m),
    ///     Unit = new FhirString("tablets"),
    ///     System = new FhirUri("http://unitsofmeasure.org"),
    ///     Code = new FhirCode("1")
    /// };
    /// </code>
    /// </example>
    public class SimpleQuantity : ComplexType<SimpleQuantity>
    {
        #region Private Fields

        private FhirDecimal? _Value;
        private FhirString? _Unit;
        private FhirUri? _System;
        private FhirCode? _Code;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the numerical value of the quantity.
        /// </summary>
        /// <value>
        /// The numerical value of the measured amount.
        /// </value>
        /// <remarks>
        /// The value represents the numerical amount of the quantity. It should be a
        /// decimal number that accurately represents the measured value.
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
        /// Gets or sets the unit of measurement for this quantity.
        /// </summary>
        /// <value>
        /// A human-readable representation of the unit of measurement.
        /// </value>
        /// <remarks>
        /// The unit provides a human-readable description of the unit of measurement.
        /// Examples include "mg", "ml", "tablets", "doses", etc.
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
        /// Gets or sets the system that defines the unit of measurement.
        /// </summary>
        /// <value>
        /// The URI that identifies the system that defines the unit.
        /// </value>
        /// <remarks>
        /// The system URI identifies the coding system that defines the unit of measurement.
        /// Common systems include UCUM (http://unitsofmeasure.org) for standard units.
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
        /// Gets or sets the coded form of the unit.
        /// </summary>
        /// <value>
        /// The code that represents the unit in the specified system.
        /// </value>
        /// <remarks>
        /// The code represents the unit in the coding system specified by the system URI.
        /// This allows for standardized representation of units across different systems.
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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleQuantity"/> class.
        /// </summary>
        public SimpleQuantity() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleQuantity"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the simple quantity data.</param>
        public SimpleQuantity(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleQuantity"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the simple quantity.</param>
        public SimpleQuantity(string value) : base(value) { }

        #endregion
    }
}
