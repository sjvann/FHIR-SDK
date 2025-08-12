
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR ContactPoint data type.
    /// Details for all kinds of technology mediated contact points for a person or organization.
    /// </summary>
    /// <remarks>
    /// ContactPoint represents various types of contact information such as phone numbers,
    /// email addresses, fax numbers, and other communication methods. It includes information
    /// about the type of contact point, its use, priority ranking, and validity period.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a phone contact point
    /// var phone = new ContactPoint
    /// {
    ///     System = new FhirCode("phone"),
    ///     Value = new FhirString("+1-555-123-4567"),
    ///     Use = new FhirCode("work"),
    ///     Rank = new FhirPositiveInt(1)
    /// };
    ///
    /// // Create an email contact point
    /// var email = new ContactPoint
    /// {
    ///     System = new FhirCode("email"),
    ///     Value = new FhirString("doctor@hospital.com"),
    ///     Use = new FhirCode("work"),
    ///     Rank = new FhirPositiveInt(2)
    /// };
    ///
    /// // Create a fax contact point
    /// var fax = new ContactPoint
    /// {
    ///     System = new FhirCode("fax"),
    ///     Value = new FhirString("+1-555-123-4568"),
    ///     Use = new FhirCode("work"),
    ///     Period = new Period
    ///     {
    ///         Start = new FhirDateTime(DateTime.Today),
    ///         End = new FhirDateTime(DateTime.Today.AddYears(1))
    ///     }
    /// };
    /// </code>
    /// </example>
    public class ContactPoint : ComplexType<ContactPoint>
    {
        #region Private Fields

        private FhirCode? _System;
        private FhirString? _Value;
        private FhirCode? _Use;
        private FhirPositiveInt? _Rank;
        private Period? _Period;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the type of contact point system.
        /// </summary>
        /// <value>
        /// The type of contact point (phone, fax, email, pager, url, sms, other).
        /// </value>
        /// <remarks>
        /// The system indicates the type of contact point. Common values include:
        /// "phone" for telephone numbers, "fax" for fax numbers, "email" for email addresses,
        /// "pager" for pager numbers, "url" for websites, and "sms" for text messages.
        /// </remarks>
        public FhirCode? System
        {
            get { return _System; }
            set
            {
                _System = value;
                OnPropertyChanged("system", value);
            }
        }

        /// <summary>
        /// Gets or sets the actual contact point value.
        /// </summary>
        /// <value>
        /// The actual contact point value (e.g., phone number, email address).
        /// </value>
        /// <remarks>
        /// The value contains the actual contact information. For phone numbers, this should
        /// include the country code and proper formatting. For email addresses, this should
        /// be a valid email format.
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
        /// Gets or sets the purpose of this contact point.
        /// </summary>
        /// <value>
        /// The purpose of this contact point (home, work, temp, old, mobile).
        /// </value>
        /// <remarks>
        /// The use indicates the purpose of this contact point. Common values include:
        /// "home" for personal contact information, "work" for professional contact,
        /// "temp" for temporary contact, "old" for previous contact, and "mobile" for mobile devices.
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
        /// Gets or sets the rank of this contact point.
        /// </summary>
        /// <value>
        /// The rank of this contact point (1 = highest priority).
        /// </value>
        /// <remarks>
        /// The rank specifies the preferred order of use for this contact point.
        /// Lower numbers indicate higher priority. For example, rank 1 might be the
        /// primary contact method, while rank 2 would be a secondary method.
        /// </remarks>
        public FhirPositiveInt? Rank
        {
            get { return _Rank; }
            set
            {
                _Rank = value;
                OnPropertyChanged("rank", value);
            }
        }

        /// <summary>
        /// Gets or sets the time period when this contact point is valid.
        /// </summary>
        /// <value>
        /// The time period when this contact point is valid.
        /// </value>
        /// <remarks>
        /// The period specifies when this contact point is valid. This is useful for
        /// temporary contact information or when contact details change over time.
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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPoint"/> class.
        /// </summary>
        public ContactPoint() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPoint"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the contact point data.</param>
        public ContactPoint(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPoint"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the contact point.</param>
        public ContactPoint(string value) : base(value) { }

        #endregion
    }
}
