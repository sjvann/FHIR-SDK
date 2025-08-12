using DataTypeServices.DataTypes.ChoiceTypes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.MetaTypes
{
    /// <summary>
    /// Represents a FHIR UsageContext data type.
    /// Specifies the clinical context in which a resource is used.
    /// </summary>
    /// <remarks>
    /// UsageContext provides information about the context in which a resource is used.
    /// It can specify the type of usage (e.g., age, gender, workflow) and the value
    /// for that context. This helps systems understand when and how to use resources
    /// appropriately.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a usage context for age
    /// var ageContext = new UsageContext
    /// {
    ///     Code = new Coding
    ///     {
    ///         System = new FhirUri("http://terminology.hl7.org/CodeSystem/usage-context-type"),
    ///         Code = new FhirCode("age"),
    ///         Display = new FhirString("Age")
    ///     },
    ///     Value = new ChoiceValue(new Range
    ///     {
    ///         Low = new SimpleQuantity { Value = new FhirDecimal(18), Unit = new FhirString("years") },
    ///         High = new SimpleQuantity { Value = new FhirDecimal(65), Unit = new FhirString("years") }
    ///     })
    /// };
    ///
    /// // Create a usage context for gender
    /// var genderContext = new UsageContext
    /// {
    ///     Code = new Coding
    ///     {
    ///         System = new FhirUri("http://terminology.hl7.org/CodeSystem/usage-context-type"),
    ///         Code = new FhirCode("gender"),
    ///         Display = new FhirString("Gender")
    ///     },
    ///     Value = new ChoiceValue(new FhirCode("female"))
    /// };
    ///
    /// // Create a usage context for workflow
    /// var workflowContext = new UsageContext
    /// {
    ///     Code = new Coding
    ///     {
    ///         System = new FhirUri("http://terminology.hl7.org/CodeSystem/usage-context-type"),
    ///         Code = new FhirCode("workflow"),
    ///         Display = new FhirString("Workflow Setting")
    ///     },
    ///     Value = new ChoiceValue(new FhirCode("inpatient"))
    /// };
    /// </code>
    /// </example>
    public class UsageContext : ComplexType<UsageContext>
    {
        #region Private Fields

        private Coding? _code;
        private ChoiceValue? _value;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the code that defines the type of usage context.
        /// </summary>
        /// <value>
        /// A coding that defines the type of usage context (e.g., age, gender, workflow).
        /// </value>
        /// <remarks>
        /// The code specifies the type of usage context. Common types include:
        /// "age" for age-related contexts, "gender" for gender-specific contexts,
        /// "workflow" for workflow-related contexts, and "task" for task-specific contexts.
        /// </remarks>
        public Coding? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        /// <summary>
        /// Gets or sets the value for this usage context.
        /// </summary>
        /// <value>
        /// The value for the usage context, which can be a CodeableConcept, Quantity, Range, or Reference.
        /// </value>
        /// <remarks>
        /// The value specifies the actual context value. For age contexts, this might be a Range
        /// representing an age range. For gender contexts, this might be a CodeableConcept representing
        /// the gender. The type of value should be appropriate for the context type.
        /// </remarks>
        public ChoiceValue? Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("value", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageContext"/> class.
        /// </summary>
        public UsageContext() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageContext"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the usage context data.</param>
        public UsageContext(JsonObject? value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageContext"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the usage context.</param>
        public UsageContext(string value) : base(value) { }

        #endregion
    }
}
