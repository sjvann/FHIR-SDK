
using System.Text.Json.Nodes;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Annotation data type.
    /// A text note which also contains information about who made the statement and when.
    /// </summary>
    /// <remarks>
    /// An Annotation represents a text note that can be attached to various FHIR resources.
    /// It includes information about who made the annotation, when it was made, and the
    /// actual text content. Annotations are commonly used for clinical notes, comments,
    /// or other textual information that needs to be associated with a resource.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple annotation
    /// var annotation = new Annotation
    /// {
    ///     Text = new FhirMarkdown("Patient reported mild headache"),
    ///     Time = new FhirDateTime(DateTime.Now)
    /// };
    ///
    /// // Create with author information
    /// var detailedAnnotation = new Annotation
    /// {
    ///     Author = new ChoiceType(new FhirString("Dr. Smith")),
    ///     Time = new FhirDateTime(DateTime.Now),
    ///     Text = new FhirMarkdown("Patient shows improvement in symptoms")
    /// };
    ///
    /// // Create for medication notes
    /// var medicationNote = new Annotation
    /// {
    ///     Author = new ChoiceType(new FhirString("Nurse Johnson")),
    ///     Time = new FhirDateTime(DateTime.Now),
    ///     Text = new FhirMarkdown("Medication administered as prescribed")
    /// };
    /// </code>
    /// </example>
    public class Annotation : ComplexType<Annotation>
    {
        #region Private Fields

        private ChoiceType? _Author;
        private FhirDateTime? _Time;
        private FhirMarkdown? _Text;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the individual responsible for making the annotation.
        /// </summary>
        /// <value>
        /// The author of the annotation, which can be a string or a Reference.
        /// </value>
        /// <remarks>
        /// The author can be specified as a simple string (e.g., "Dr. Smith") or as a
        /// Reference to a Practitioner, Patient, or other resource. This helps identify
        /// who made the annotation for audit and accountability purposes.
        /// </remarks>
        public ChoiceType? Author
        {
            get { return _Author; }
            set
            {
                _Author = value;
                OnPropertyChanged("author", value);
            }
        }

        /// <summary>
        /// Gets or sets the time when the annotation was made.
        /// </summary>
        /// <value>
        /// The date/time when the annotation was created.
        /// </value>
        /// <remarks>
        /// The time indicates when the annotation was made. This is important for
        /// understanding the context and timeline of the annotation relative to
        /// other events in the patient's care.
        /// </remarks>
        public FhirDateTime? Time
        {
            get { return _Time; }
            set
            {
                _Time = value;
                OnPropertyChanged("time", value);
            }
        }

        /// <summary>
        /// Gets or sets the text content of the annotation.
        /// </summary>
        /// <value>
        /// The actual text content of the annotation in Markdown format.
        /// </value>
        /// <remarks>
        /// The text contains the actual content of the annotation. It can include
        /// Markdown formatting for better readability and structure. This is the
        /// primary content of the annotation.
        /// </remarks>
        public FhirMarkdown? Text
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
        /// Initializes a new instance of the <see cref="Annotation"/> class.
        /// </summary>
        public Annotation() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the annotation data.</param>
        public Annotation(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Annotation"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the annotation.</param>
        public Annotation(string value) : base(value) { }

        #endregion
    }
}
