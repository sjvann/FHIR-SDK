using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR boolean primitive type.
    /// Value of 'true' or 'false'.
    /// </summary>
    /// <remarks>
    /// The FHIR boolean type represents a binary choice between true and false.
    /// It is used for yes/no, on/off type of data elements in FHIR resources.
    /// The value is case-insensitive and can be represented as "true"/"false" or "True"/"False".
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a boolean value
    /// var isActive = new FhirBoolean(true);
    ///
    /// // Create from string
    /// var isEnabled = new FhirBoolean("true");
    ///
    /// // Check the value
    /// if (isActive.Value == true)
    /// {
    ///     Console.WriteLine("Patient is active");
    /// }
    /// </code>
    /// </example>
    public class FhirBoolean : PrimitiveType<FhirBoolean,bool>, IBooleanValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class.
        /// </summary>
        public FhirBoolean() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the boolean value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirBoolean(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the boolean value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirBoolean(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class from a boolean value and element.
        /// </summary>
        /// <param name="value">The boolean value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirBoolean(bool? value, Element? element) : base(value?.ToString(), element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the boolean value.</param>
        public FhirBoolean(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class from a boolean value.
        /// </summary>
        /// <param name="value">The boolean value.</param>
        public FhirBoolean(bool? value) : base(value?.ToString(), null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirBoolean"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the boolean value ("true" or "false").</param>
        public FhirBoolean(string? value) : base(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether this instance has a value.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has a value; otherwise, <c>false</c>.
        /// </value>
        public bool HasValue => !string.IsNullOrEmpty(_stringValue);

        /// <summary>
        /// Gets the boolean value of this FHIR boolean.
        /// </summary>
        /// <value>
        /// The boolean value (true or false), or <c>null</c> if no value has been set or the value is invalid.
        /// </value>
        public bool? Value => _stringValue?.ToLower() switch
        {
            "true" => true,
            "false" => false,
            _ => null
        };

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the JSON representation of this boolean value.
        /// </summary>
        /// <returns>A <see cref="JsonValue"/> representing this boolean, or <c>null</c> if no value is set.</returns>
        public override JsonValue? GetJsonValue() => JsonValue.Create<bool?>(Value);

        /// <summary>
        /// Validates whether the current value is a valid FHIR boolean.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR boolean values are "true", "True", "false", or "False".
        /// </remarks>
        public override bool IsValidValue() => CheckValidate(@"^(true|True|false|False)$", _stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The boolean value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        #endregion
    }

}
