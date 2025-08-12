using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Identifier data type.
    /// An identifier for a person, place, or thing.
    /// </summary>
    /// <remarks>
    /// An Identifier represents a unique identifier for a person, place, or thing.
    /// It includes information about the type of identifier, the system that issued it,
    /// the actual value, and the period during which it is valid. Identifiers are
    /// commonly used for patient IDs, medical record numbers, insurance numbers,
    /// and other unique identifiers in healthcare systems.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple identifier
    /// var identifier = new Identifier
    /// {
    ///     Use = new FhirCode("official"),
    ///     System = new FhirUri("http://hospital.example.com/identifiers/patient"),
    ///     Value = new FhirString("MRN12345")
    /// };
    ///
    /// // Create an identifier with type
    /// var typedIdentifier = new Identifier
    /// {
    ///     Use = new FhirCode("official"),
    ///     Type = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v2-0203"),
    ///                 Code = new FhirCode("MR"),
    ///                 Display = new FhirString("Medical Record Number")
    ///             }
    ///         }
    ///     },
    ///     System = new FhirUri("http://hospital.example.com/identifiers/patient"),
    ///     Value = new FhirString("MRN12345"),
    ///     Period = new Period
    ///     {
    ///         Start = new FhirDateTime(DateTime.Today),
    ///         End = new FhirDateTime(DateTime.Today.AddYears(1))
    ///     }
    /// };
    ///
    /// // Create an identifier with assigner
    /// var assignedIdentifier = new Identifier
    /// {
    ///     Use = new FhirCode("official"),
    ///     System = new FhirUri("http://insurance.example.com/identifiers/member"),
    ///     Value = new FhirString("INS98765"),
    ///     Assigner = new ReferenceType("Organization/insurance-company")
    /// };
    /// </code>
    /// </example>
    public class Identifier : ComplexType<Identifier>
    {
        private FhirCode? _Use;
        private CodeableConcept? _Type;
        private FhirUri? _System;
        private FhirString? _Value;
        private Period? _Period;
        private ReferenceType? _Assigner;

        /// <summary>
        /// Gets or sets the purpose of this identifier.
        /// </summary>
        /// <value>
        /// A coded value indicating the purpose of the identifier (usual, official, temp, secondary, old).
        /// </value>
        /// <remarks>
        /// The use specifies the purpose of the identifier. Common values include:
        /// "usual" for the identifier that should be used for this entity,
        /// "official" for the identifier that is considered the official identifier,
        /// "temp" for a temporary identifier, "secondary" for a secondary identifier,
        /// and "old" for an identifier that is no longer valid.
        /// </remarks>
        public FhirCode? Use
        {
            get { return _Use; }
            set
            {
                _Use = value;
                OnPropertyChanged("use", value);
            }
        }

        /// <summary>
        /// Gets or sets the type of identifier.
        /// </summary>
        /// <value>
        /// A coded concept that describes the type of identifier.
        /// </value>
        /// <remarks>
        /// The type specifies the kind of identifier being provided. This helps
        /// systems understand the context and meaning of the identifier. Common
        /// types include Medical Record Number, Social Security Number, etc.
        /// </remarks>
        public CodeableConcept? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }

        /// <summary>
        /// Gets or sets the system that issued the identifier.
        /// </summary>
        /// <value>
        /// The URI that identifies the system that issued the identifier.
        /// </value>
        /// <remarks>
        /// The system specifies the organization or system that issued the identifier.
        /// This helps establish the authority and context of the identifier.
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
        /// Gets or sets the actual identifier value.
        /// </summary>
        /// <value>
        /// The actual identifier value.
        /// </value>
        /// <remarks>
        /// The value contains the actual identifier string. This should be unique
        /// within the context of the system that issued it.
        /// </remarks>
        public FhirString? Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                OnPropertyChanged("value", value);
            }
        }

        /// <summary>
        /// Gets or sets the period during which the identifier is valid.
        /// </summary>
        /// <value>
        /// The period during which the identifier is valid.
        /// </value>
        /// <remarks>
        /// The period specifies the time period during which the identifier is
        /// considered valid. This is important for identifiers that have
        /// expiration dates or validity periods.
        /// </remarks>
        public Period? Period
        {
            get { return _Period; }
            set
            {
                _Period = value;
                OnPropertyChanged("period", value);
            }
        }

        /// <summary>
        /// Gets or sets the organization that issued the identifier.
        /// </summary>
        /// <value>
        /// A reference to the organization that issued the identifier.
        /// </value>
        /// <remarks>
        /// The assigner specifies the organization that issued the identifier.
        /// This provides additional context about the authority behind the
        /// identifier and can be used for verification purposes.
        /// </remarks>
        public ReferenceType? Assigner
        {
            get { return _Assigner; }
            set
            {
                _Assigner = value;
                OnPropertyChanged("assigner", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier"/> class.
        /// </summary>
        public Identifier() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the identifier data.</param>
        public Identifier(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the identifier.</param>
        public Identifier(string value) : base(value) { }
    }
}
