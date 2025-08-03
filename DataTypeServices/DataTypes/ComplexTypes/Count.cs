using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Count data type.
    /// A measured amount (or an amount that can potentially be measured).
    /// </summary>
    /// <remarks>
    /// Count is a specialized form of Quantity that represents a count of discrete items.
    /// It inherits from Quantity but is specifically used for counting discrete objects
    /// rather than measuring continuous quantities. Examples include counts of pills,
    /// number of procedures, or count of occurrences.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple count
    /// var count = new Count
    /// {
    ///     Value = new FhirDecimal(10),
    ///     Unit = new FhirString("tablets")
    /// };
    ///
    /// // Create a count with system
    /// var systemCount = new Count
    /// {
    ///     Value = new FhirDecimal(5),
    ///     Unit = new FhirString("procedures"),
    ///     System = new FhirUri("http://unitsofmeasure.org"),
    ///     Code = new FhirCode("1")
    /// };
    ///
    /// // Create a count for medication
    /// var medicationCount = new Count
    /// {
    ///     Value = new FhirDecimal(30),
    ///     Unit = new FhirString("capsules"),
    ///     System = new FhirUri("http://unitsofmeasure.org"),
    ///     Code = new FhirCode("1")
    /// };
    /// </code>
    /// </example>
    public class Count : Quantity
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Count"/> class.
        /// </summary>
        public Count() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Count"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the count data.</param>
        public Count(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Count"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the count.</param>
        public Count(string value) : base(value) { }

        #endregion
    }
}
