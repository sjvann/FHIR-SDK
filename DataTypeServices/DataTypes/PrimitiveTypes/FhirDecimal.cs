using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR decimal primitive type.
    /// Rational numbers that have a decimal representation.
    /// </summary>
    /// <remarks>
    /// The FHIR decimal type represents rational numbers with decimal representation.
    /// It is used for precise numeric values such as measurements, quantities, and monetary amounts.
    /// The decimal type supports up to 18 digits of precision and can represent values in scientific notation.
    /// Values must not have unnecessary leading zeros and trailing zeros after the decimal point should be avoided.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a decimal value
    /// var temperature = new FhirDecimal(98.6m);
    ///
    /// // Create from string
    /// var weight = new FhirDecimal("70.5");
    ///
    /// // Scientific notation
    /// var verySmall = new FhirDecimal("1.23e-4");
    ///
    /// // Access the value
    /// decimal? temp = temperature.Value; // 98.6
    /// </code>
    /// </example>
    public class FhirDecimal : PrimitiveType<FhirDecimal,decimal>, IDecimalValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class.
        /// </summary>
        public FhirDecimal() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the decimal value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirDecimal(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the decimal value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirDecimal(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class from a decimal value and element.
        /// </summary>
        /// <param name="value">The decimal value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirDecimal(decimal? value, Element? element) : base(value?.ToString(), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the decimal value.</param>
        public FhirDecimal(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class from a decimal value.
        /// </summary>
        /// <param name="value">The decimal value.</param>
        public FhirDecimal(decimal? value) : base(value?.ToString(), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirDecimal"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the decimal value.</param>
        public FhirDecimal(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether this instance has a valid decimal value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a valid decimal value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => decimal.TryParse(_stringValue, out _);

        /// <summary>
        /// Gets the decimal value of this FHIR decimal.
        /// </summary>
        /// <value>
        /// The decimal value, or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        /// <exception cref="FormatException">Thrown when the string value cannot be converted to a decimal.</exception>
        public decimal? Value
        {
            get
            {
                if (string.IsNullOrEmpty(_stringValue)) return null;
                return decimal.TryParse(_stringValue, out var v) ? v : (decimal?)null;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the JSON representation of this decimal value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this decimal, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<decimal?>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR decimal.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR decimals can have up to 18 digits of precision and may use scientific notation.
        /// Leading zeros (except for values less than 1) and unnecessary trailing zeros should be avoided.
        /// </remarks>
        public override bool IsValidValue()
        {
            if (string.IsNullOrEmpty(_stringValue)) return false;
            // 科學記號不支援，且必須是標準十進位格式（可帶負號）
            if (_stringValue.Contains('e') || _stringValue.Contains('E')) return false;
            return CheckValidate(@"^-?(0|[1-9][0-9]*)(\.[0-9]+)?$", _stringValue);
        }

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The decimal value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion
    }
}
