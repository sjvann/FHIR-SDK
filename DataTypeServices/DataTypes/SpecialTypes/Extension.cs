using System.Text.Json.Nodes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ChoiceTypes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    /// <summary>
    /// Represents a FHIR Extension data type.
    /// Optional extension element - found in all resources.
    /// </summary>
    /// <remarks>
    /// Extension allows for additional information to be added to FHIR resources without
    /// modifying the core resource structure. Extensions are identified by a URL and can
    /// contain any type of value. They are commonly used for local customizations and
    /// additional data that doesn't fit into the standard resource structure.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple extension
    /// var extension = new Extension
    /// {
    ///     Url = new FhirUri("http://example.com/extension/patient-preference"),
    ///     Value = new ChoiceValue(new FhirString("vegetarian"))
    /// };
    ///
    /// // Create an extension with complex value
    /// var complexExtension = new Extension
    /// {
    ///     Url = new FhirUri("http://example.com/extension/medication-administration-time"),
    ///     Value = new ChoiceValue(new FhirDateTime(DateTime.Now))
    /// };
    ///
    /// // Create an extension with boolean value
    /// var booleanExtension = new Extension
    /// {
    ///     Url = new FhirUri("http://example.com/extension/patient-consent"),
    ///     Value = new ChoiceValue(new FhirBoolean(true))
    /// };
    /// </code>
    /// </example>
    public class Extension : ComplexType<Extension>
    {
        #region Private Fields

        private FhirUri? _Url;
        private ChoiceValue? _Value;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the URL that identifies the extension.
        /// </summary>
        /// <value>
        /// The URL that uniquely identifies this extension.
        /// </value>
        /// <remarks>
        /// The URL serves as the unique identifier for the extension. It should be a
        /// stable, canonical URL that identifies the extension definition. This allows
        /// systems to understand what the extension represents and how to process it.
        /// </remarks>
        public FhirUri? Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
                OnPropertyChanged("url", value);
            }
        }

        /// <summary>
        /// Gets or sets the value of the extension.
        /// </summary>
        /// <value>
        /// The value of the extension, which can be any FHIR data type.
        /// </value>
        /// <remarks>
        /// The value contains the actual data for the extension. It can be any FHIR
        /// data type including primitive types (string, boolean, integer, etc.) or
        /// complex types (CodeableConcept, Reference, etc.). The type should be
        /// appropriate for the extension's purpose.
        /// </remarks>
        public ChoiceValue? Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                OnPropertyChanged("value", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Extension"/> class.
        /// </summary>
        public Extension() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extension"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the extension data.</param>
        public Extension(JsonObject? value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Extension"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the extension.</param>
        public Extension(string value) : base(value) { }

        #endregion
    }
}
