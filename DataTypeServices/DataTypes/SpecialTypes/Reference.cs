using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.SpecialTypes
{
    /// <summary>
    /// Represents a FHIR Reference data type.
    /// A reference from one resource to another.
    /// </summary>
    /// <remarks>
    /// Reference represents a link from one resource to another. It can contain a direct
    /// reference to another resource, an identifier that can be used to resolve the reference,
    /// or both. References are used throughout FHIR to establish relationships between
    /// resources such as Patient references in Observations or Practitioner references in
    /// Encounters.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple reference
    /// var reference = new ReferenceType
    /// {
    ///     Reference = new FhirString("Patient/123"),
    ///     Display = new FhirString("John Doe")
    /// };
    ///
    /// // Create a reference with type
    /// var typedReference = new ReferenceType
    /// {
    ///     Reference = new FhirString("Practitioner/456"),
    ///     Type = new FhirUri("http://hl7.org/fhir/StructureDefinition/Practitioner"),
    ///     Display = new FhirString("Dr. Smith")
    /// };
    ///
    /// // Create a reference with identifier
    /// var identifierReference = new ReferenceType
    /// {
    ///     Identifier = new Identifier
    ///     {
    ///         System = new FhirUri("http://hospital.com/identifiers"),
    ///         Value = new FhirString("MRN12345")
    ///     },
    ///     Display = new FhirString("Patient MRN12345")
    /// };
    /// </code>
    /// </example>
    public class ReferenceType : ComplexType<ReferenceType>
    {
        #region Private Fields

        private FhirString? _Reference;
        private FhirUri? _Type;
        private Identifier? _Identifier;
        private FhirString? _Display;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the reference to another resource.
        /// </summary>
        /// <value>
        /// A relative or absolute reference to another resource.
        /// </value>
        /// <remarks>
        /// The reference can be a relative reference (e.g., "Patient/123") or an absolute
        /// URL (e.g., "http://example.com/fhir/Patient/123"). Relative references are
        /// resolved relative to the current resource's base URL.
        /// </remarks>
        public FhirString? Reference
        {
            get { return _Reference; }
            set
            {
                _Reference = value;
                OnPropertyChanged("reference", value);
            }
        }

        /// <summary>
        /// Gets or sets the type of the referenced resource.
        /// </summary>
        /// <value>
        /// The type of the referenced resource.
        /// </value>
        /// <remarks>
        /// The type specifies the FHIR resource type of the referenced resource. This
        /// helps systems understand what type of resource is being referenced and can
        /// be used for validation and processing.
        /// </remarks>
        public FhirUri? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }

        /// <summary>
        /// Gets or sets the identifier for the referenced resource.
        /// </summary>
        /// <value>
        /// An identifier that can be used to resolve the reference.
        /// </value>
        /// <remarks>
        /// The identifier provides an alternative way to identify the referenced resource.
        /// This is useful when the direct reference is not available or when the resource
        /// needs to be resolved using an identifier system.
        /// </remarks>
        public Identifier? Identifier
        {
            get { return _Identifier; }
            set
            {
                _Identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        /// <summary>
        /// Gets or sets the display text for the reference.
        /// </summary>
        /// <value>
        /// A human-readable display text for the reference.
        /// </value>
        /// <remarks>
        /// The display provides a human-readable representation of the referenced resource.
        /// This is useful for user interfaces and reports where the actual reference
        /// might not be meaningful to users.
        /// </remarks>
        public FhirString? Display
        {
            get { return _Display; }
            set
            {
                _Display = value;
                OnPropertyChanged("display", value);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the FHIR type name for this reference type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter of the type name.</param>
        /// <returns>The FHIR type name ("Reference" or "reference").</returns>
        public override string GetFhirTypeName(bool withCapital = true) => withCapital ? "Reference" : "reference";

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceType"/> class.
        /// </summary>
        public ReferenceType() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceType"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the reference data.</param>
        public ReferenceType(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceType"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the reference.</param>
        public ReferenceType(string value) : base(value) { }

        #endregion
    }
}
