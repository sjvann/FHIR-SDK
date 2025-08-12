using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR CodeableConcept data type.
    /// A concept that may be defined by a formal reference to a terminology or ontology
    /// or may be provided by text.
    /// </summary>
    /// <remarks>
    /// A CodeableConcept represents a coded concept that can be used to classify or categorize
    /// information. It can contain multiple codings from different coding systems, as well as
    /// a human-readable text representation. This is commonly used for diagnoses, procedures,
    /// medications, and other clinical concepts.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple codeable concept
    /// var concept = new CodeableConcept
    /// {
    ///     Coding = new List&lt;Coding&gt;
    ///     {
    ///         new Coding
    ///         {
    ///             System = new FhirUri("http://snomed.info/sct"),
    ///             Code = new FhirCode("73211009"),
    ///             Display = new FhirString("Diabetes mellitus")
    ///         }
    ///     },
    ///     Text = new FhirString("Diabetes mellitus")
    /// };
    ///
    /// // Create with multiple codings
    /// var multiCoding = new CodeableConcept
    /// {
    ///     Coding = new List&lt;Coding&gt;
    ///     {
    ///         new Coding
    ///         {
    ///             System = new FhirUri("http://snomed.info/sct"),
    ///             Code = new FhirCode("73211009"),
    ///             Display = new FhirString("Diabetes mellitus")
    ///         },
    ///         new Coding
    ///         {
    ///             System = new FhirUri("http://loinc.org"),
    ///             Code = new FhirCode("250-8"),
    ///             Display = new FhirString("Glucose")
    ///         }
    ///     },
    ///     Text = new FhirString("Diabetes mellitus with glucose monitoring")
    /// };
    /// </code>
    /// </example>
    public class CodeableConcept : ComplexType<CodeableConcept>
    {
        #region Private Fields

        private List<Coding>? _Coding;
        private FhirString? _Text;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the coding entries for this concept.
        /// </summary>
        /// <value>
        /// A list of codings that define this concept. Each coding contains a system, code, and display.
        /// </value>
        /// <remarks>
        /// A concept can have multiple codings from different coding systems. For example,
        /// a diagnosis might be coded in both SNOMED CT and ICD-10. The codings should be
        /// equivalent in meaning, though they may have different levels of detail.
        /// </remarks>
        public List<Coding>? Coding
        {
            get { return _Coding; }
            set
            {
                _Coding = value;
                OnPropertyChanged("coding", value);
            }
        }

        /// <summary>
        /// Gets or sets the text representation of the concept.
        /// </summary>
        /// <value>
        /// A human-readable representation of the concept that can be used for display purposes.
        /// </value>
        /// <remarks>
        /// The text should be a human-readable representation of the concept. It can be provided
        /// instead of or in addition to the codings. When both text and codings are present,
        /// the text should be consistent with the meaning of the codings.
        /// </remarks>
        public FhirString? Text
        {
            get { return _Text; }
            set
            {
                _Text = value;
                OnPropertyChanged("text", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeableConcept"/> class.
        /// </summary>
        public CodeableConcept() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeableConcept"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the codeable concept data.</param>
        public CodeableConcept(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeableConcept"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the codeable concept.</param>
        public CodeableConcept(string value) : base(value) { }

        #endregion
    }
}