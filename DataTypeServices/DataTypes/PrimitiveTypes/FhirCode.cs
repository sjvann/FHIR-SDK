using DataTypeServices.TypeFramework;
using FhirCore.Interfaces;
using System;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace DataTypeServices.DataTypes.PrimitiveTypes
{
    /// <summary>
    /// Represents a FHIR code primitive type.
    /// Indicates that the value is taken from a set of controlled strings defined elsewhere.
    /// </summary>
    /// <remarks>
    /// The FHIR code type represents a string that is constrained to a specific set of values.
    /// Codes are used throughout FHIR to represent controlled vocabularies, enumerations, and coded concepts.
    /// The actual set of valid codes is defined by the context in which the code is used (e.g., a ValueSet binding).
    /// Codes must not contain leading or trailing whitespace and cannot contain control characters.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create code values
    /// var status = new FhirCode("active");
    /// var gender = new FhirCode("male");
    ///
    /// // Create strongly-typed codes
    /// var typedStatus = FhirCode&lt;PatientStatus&gt;.Init(PatientStatus.Active);
    ///
    /// // Validate code
    /// var validationResult = status.ValidateDetailed();
    /// if (validationResult.IsValid)
    /// {
    ///     string code = status.Value;
    /// }
    /// </code>
    /// </example>
    public class FhirCode : PrimitiveType<FhirCode, string>, IStringValue
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode"/> class.
        /// </summary>
        public FhirCode() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the code value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        public FhirCode(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the code value.</param>
        /// <param name="element">The element metadata.</param>
        public FhirCode(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The code string.</param>
        /// <param name="element">The element metadata.</param>
        public FhirCode(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the code value.</param>
        public FhirCode(JsonNode? value) : this(value, string.Empty) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode"/> class from a string value.
        /// </summary>
        /// <param name="value">The code string.</param>
        public FhirCode(string? value) : this(value, null) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the code string value of this FHIR code.
        /// </summary>
        /// <value>
        /// The code string, or <c>null</c> if no value has been set.
        /// </value>
        public string? Value => _stringValue;

        #endregion

        #region Public Methods

        /// <summary>
        /// Validates whether the current value is a valid FHIR code.
        /// </summary>
        /// <returns><c>true</c> if the value is valid; otherwise, <c>false</c>.</returns>
        /// <remarks>
        /// Valid FHIR codes must not have leading or trailing whitespace and cannot contain control characters.
        /// </remarks>
        public override bool IsValidValue() => IsValidCodeString(_stringValue);

        /// <summary>
        /// Gets the value as an object.
        /// </summary>
        /// <returns>The code string value as an object, or <c>null</c> if no value is set.</returns>
        public override object? GetValue() => Value;

        /// <summary>
        /// Determines whether this code is empty or whitespace.
        /// </summary>
        /// <returns><c>true</c> if the code is null, empty, or whitespace; otherwise, <c>false</c>.</returns>
        public bool IsEmpty() => string.IsNullOrWhiteSpace(_stringValue);

        /// <summary>
        /// Compares this code with another code for equality (case-sensitive).
        /// </summary>
        /// <param name="other">The other code to compare with.</param>
        /// <returns><c>true</c> if the codes are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(FhirCode? other)
        {
            if (other == null) return false;
            return string.Equals(_stringValue, other._stringValue, StringComparison.Ordinal);
        }

        /// <summary>
        /// Compares this code with a string for equality (case-sensitive).
        /// </summary>
        /// <param name="code">The code string to compare with.</param>
        /// <returns><c>true</c> if the codes are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(string? code)
        {
            return string.Equals(_stringValue, code, StringComparison.Ordinal);
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Gets the expected format description for FHIR code.
        /// </summary>
        /// <returns>A string describing the expected format for FHIR code.</returns>
        protected override string GetExpectedFormat()
        {
            return "String with no leading/trailing whitespace and no control characters";
        }

        /// <summary>
        /// Gets a detailed validation error message for the current value.
        /// </summary>
        /// <returns>A string describing why the current value is invalid.</returns>
        protected override string GetValidationErrorMessage()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return "Code value cannot be null or empty";

            if (_stringValue != _stringValue.Trim())
                return $"'{_stringValue}' has leading or trailing whitespace. {GetExpectedFormat()}";

            if (_stringValue.Any(char.IsControl))
                return $"'{_stringValue}' contains control characters. {GetExpectedFormat()}";

            return $"'{_stringValue}' is not a valid code format. {GetExpectedFormat()}";
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates whether the specified string is a valid FHIR code.
        /// </summary>
        /// <param name="value">The string value to validate.</param>
        /// <returns><c>true</c> if the value is a valid FHIR code; otherwise, <c>false</c>.</returns>
        private static bool IsValidCodeString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            // Must not have leading or trailing whitespace
            if (value != value.Trim())
                return false;

            // Must not contain control characters
            if (value.Any(char.IsControl))
                return false;

            // Use regex pattern for additional validation
            return Regex.IsMatch(value, @"^[^\s]+(\s[^\s]+)*$");
        }

        #endregion
    }

    /// <summary>
    /// Represents a strongly-typed FHIR code primitive type.
    /// A code that is constrained to a specific enumeration type.
    /// </summary>
    /// <typeparam name="T">The enumeration type that constrains the valid values for this code.</typeparam>
    /// <remarks>
    /// This generic version of FhirCode provides compile-time type safety by constraining the code values
    /// to a specific enumeration. This is particularly useful for codes that have a well-defined set of
    /// possible values, such as status codes, gender codes, or other controlled vocabularies.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Define an enum for patient status
    /// public enum PatientStatus
    /// {
    ///     Active,
    ///     Inactive,
    ///     Deceased
    /// }
    ///
    /// // Create strongly-typed codes
    /// var status = FhirCode&lt;PatientStatus&gt;.Init(PatientStatus.Active);
    /// var gender = FhirCode&lt;AdministrativeGender&gt;.Init(AdministrativeGender.Male);
    ///
    /// // Access the enum value
    /// PatientStatus statusValue = status.EnumValue;
    /// </code>
    /// </example>
    public class FhirCode<T> : FhirCode where T : Enum
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode{T}"/> class.
        /// </summary>
        protected FhirCode() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode{T}"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the enum value.</param>
        protected FhirCode(string value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode{T}"/> class from a JSON node and element name.
        /// </summary>
        /// <param name="value">The JSON node containing the code value.</param>
        /// <param name="elementName">The name of the element for metadata lookup.</param>
        protected FhirCode(JsonNode? value, string? elementName) : base(value, elementName) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode{T}"/> class from a JSON node and element.
        /// </summary>
        /// <param name="value">The JSON node containing the code value.</param>
        /// <param name="element">The element metadata.</param>
        protected FhirCode(JsonNode? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode{T}"/> class from a string value and element.
        /// </summary>
        /// <param name="value">The string representation of the enum value.</param>
        /// <param name="element">The element metadata.</param>
        protected FhirCode(string? value, Element? element) : base(value, element) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="FhirCode{T}"/> class from a JSON node.
        /// </summary>
        /// <param name="value">The JSON node containing the code value.</param>
        protected FhirCode(JsonNode? value) : this(value, string.Empty) { }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the strongly-typed enum value of this code.
        /// </summary>
        /// <value>
        /// The enum value, or the default value of the enum if parsing fails.
        /// </value>
        public T EnumValue
        {
            get
            {
                if (string.IsNullOrEmpty(_stringValue))
                    return default(T);

                try
                {
                    return (T)Enum.Parse(typeof(T), _stringValue, ignoreCase: true);
                }
                catch
                {
                    return default(T);
                }
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a new strongly-typed FhirCode from an enum value.
        /// </summary>
        /// <param name="source">The enum value to convert to a FhirCode.</param>
        /// <returns>A new <see cref="FhirCode{T}"/> instance representing the enum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="source"/> is null.</exception>
        public static FhirCode<T> Init(T source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return new FhirCode<T>(source.ToString());
        }

        /// <summary>
        /// Creates a new strongly-typed FhirCode from a string value.
        /// </summary>
        /// <param name="value">The string value to convert to a FhirCode.</param>
        /// <returns>A new <see cref="FhirCode{T}"/> instance, or null if the value is invalid.</returns>
        public static FhirCode<T>? FromString(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            try
            {
                // Validate that the string can be parsed as the enum type
                Enum.Parse(typeof(T), value, ignoreCase: true);
                return new FhirCode<T>(value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Determines whether the current code value is a valid enum value.
        /// </summary>
        /// <returns><c>true</c> if the code represents a valid enum value; otherwise, <c>false</c>.</returns>
        public bool IsValidEnumValue()
        {
            if (string.IsNullOrEmpty(_stringValue))
                return false;

            return Enum.TryParse(typeof(T), _stringValue, ignoreCase: true, out _);
        }

        /// <summary>
        /// Compares this strongly-typed code with an enum value for equality.
        /// </summary>
        /// <param name="enumValue">The enum value to compare with.</param>
        /// <returns><c>true</c> if the values are equal; otherwise, <c>false</c>.</returns>
        public bool Equals(T enumValue)
        {
            return EqualityComparer<T>.Default.Equals(EnumValue, enumValue);
        }

        #endregion
    }
}
