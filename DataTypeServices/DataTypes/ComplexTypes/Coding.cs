using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Coding data type.
    /// A reference to a code defined by a terminology system.
    /// </summary>
    /// <remarks>
    /// A Coding represents a single code from a coding system. It contains the system URI,
    /// the code value, and optionally a human-readable display text. Codings are used
    /// throughout FHIR to represent standardized concepts from various terminology systems
    /// such as SNOMED CT, LOINC, ICD-10, etc.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple coding
    /// var coding = new Coding
    /// {
    ///     System = new FhirUri("http://snomed.info/sct"),
    ///     Code = new FhirCode("73211009"),
    ///     Display = new FhirString("Diabetes mellitus")
    /// };
    ///
    /// // Create with version
    /// var versionedCoding = new Coding
    /// {
    ///     System = new FhirUri("http://loinc.org"),
    ///     Version = new FhirString("2.68"),
    ///     Code = new FhirCode("250-8"),
    ///     Display = new FhirString("Glucose"),
    ///     UserSelected = new FhirBoolean(true)
    /// };
    ///
    /// // Create for medication
    /// var medicationCoding = new Coding
    /// {
    ///     System = new FhirUri("http://www.nlm.nih.gov/research/umls/rxnorm"),
    ///     Code = new FhirCode("860975"),
    ///     Display = new FhirString("Insulin Regular Human")
    /// };
    /// </code>
    /// </example>
    public class Coding : ComplexType<Coding>
    {
        #region Private Fields

        private FhirUri? _System;
        private FhirString? _Version;
        private FhirCode? _Code;
        private FhirString? _Display;
        private FhirBoolean? _UserSelected;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the identification of the code system that defines the meaning of the symbol in the code.
        /// </summary>
        /// <value>
        /// The URI that identifies the coding system. Examples include SNOMED CT, LOINC, ICD-10, etc.
        /// </value>
        /// <remarks>
        /// The system URI should be a stable, canonical URL that identifies the coding system.
        /// This allows systems to understand the context and meaning of the code.
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
        /// Gets or sets the version of the code system which was used when choosing this code.
        /// </summary>
        /// <value>
        /// The version identifier of the coding system, if applicable.
        /// </value>
        /// <remarks>
        /// The version is important for reproducibility and traceability. Different versions
        /// of a coding system may have different codes or different meanings for the same code.
        /// </remarks>
        public FhirString? Version
        {
            get { return _Version; }
            set
            {
                _Version = value;
                OnPropertyChanged("version", value);
            }
        }

        /// <summary>
        /// Gets or sets the symbol in syntax defined by the system.
        /// </summary>
        /// <value>
        /// The code value from the coding system.
        /// </value>
        /// <remarks>
        /// The code is the actual identifier from the coding system. It should be used
        /// in conjunction with the system to uniquely identify the concept.
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

        /// <summary>
        /// Gets or sets the representation defined by the system.
        /// </summary>
        /// <value>
        /// A human-readable representation of the concept as defined by the coding system.
        /// </value>
        /// <remarks>
        /// The display text should be a human-readable representation of the concept
        /// as defined by the coding system. This is useful for user interfaces and reports.
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

        /// <summary>
        /// Gets or sets a value indicating whether this coding was chosen by a user directly.
        /// </summary>
        /// <value>
        /// True if the coding was selected by a user, false if it was assigned by the system.
        /// </value>
        /// <remarks>
        /// This field indicates whether the coding was chosen by a user directly or was
        /// assigned by the system. This can be important for clinical decision support
        /// and audit purposes.
        /// </remarks>
        public FhirBoolean? UserSelected
        {
            get { return _UserSelected; }
            set
            {
                _UserSelected = value;
                OnPropertyChanged("userSelected", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Coding"/> class.
        /// </summary>
        public Coding() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coding"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the coding data.</param>
        public Coding(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coding"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the coding.</param>
        public Coding(string value) : base(value) { }

        #endregion
    }
}