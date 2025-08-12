
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Signature data type.
    /// A digital signature along with supporting context.
    /// </summary>
    /// <remarks>
    /// A Signature represents a digital signature that can be used to verify the
    /// authenticity and integrity of a resource or document. It includes information
    /// about who signed the document, when it was signed, and the actual signature data.
    /// Signatures are commonly used for consent forms, prescriptions, and other
    /// legally binding documents in healthcare.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple signature
    /// var signature = new Signature
    /// {
    ///     Type = new List&lt;Coding&gt;
    ///     {
    ///         new Coding
    ///         {
    ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-SignatureType"),
    ///             Code = new FhirCode("1.2.840.10065.1.12.1.1"),
    ///             Display = new FhirString("Author's Signature")
    ///         }
    ///     },
    ///     When = new FhirInstant(DateTime.UtcNow),
    ///     Who = new ReferenceType("Practitioner/123"),
    ///     Data = new FhirBase64Binary("SGVsbG8gV29ybGQ=")
    /// };
    ///
    /// // Create a signature for a consent form
    /// var consentSignature = new Signature
    /// {
    ///     Type = new List&lt;Coding&gt;
    ///     {
    ///         new Coding
    ///         {
    ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-SignatureType"),
    ///             Code = new FhirCode("1.2.840.10065.1.12.1.2"),
    ///             Display = new FhirString("Patient's Signature")
    ///         }
    ///     },
    ///     When = new FhirInstant(DateTime.UtcNow),
    ///     Who = new ReferenceType("Patient/456"),
    ///     OnBehalfOf = new ReferenceType("Organization/789"),
    ///     TargetFormat = new FhirCode("application/pdf"),
    ///     SigFormat = new FhirCode("application/x-pkcs7-signature"),
    ///     Data = new FhirBase64Binary("U2lnbmF0dXJlRGF0YQ==")
    /// };
    ///
    /// // Create a signature for a prescription
    /// var prescriptionSignature = new Signature
    /// {
    ///     Type = new List&lt;Coding&gt;
    ///     {
    ///         new Coding
    ///         {
    ///             System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-SignatureType"),
    ///             Code = new FhirCode("1.2.840.10065.1.12.1.3"),
    ///             Display = new FhirString("Prescriber's Signature")
    ///         }
    ///     },
    ///     When = new FhirInstant(DateTime.UtcNow),
    ///     Who = new ReferenceType("Practitioner/123"),
    ///     TargetFormat = new FhirCode("application/xml"),
    ///     SigFormat = new FhirCode("application/x-pkcs7-signature"),
    ///     Data = new FhirBase64Binary("UHJlc2NyaXB0aW9uU2lnbmF0dXJl")
    /// };
    /// </code>
    /// </example>
    public class Signature : ComplexType<Signature>
    {
        private List<Coding>? _Type;
        private FhirInstant? _When;
        private ReferenceType? _Who;
        private ReferenceType? _OnBehalfOf;
        private FhirCode? _TargetFormat;
        private FhirCode? _SigFormat;
        private FhirBase64Binary? _Data;

        /// <summary>
        /// Gets or sets the type of signature.
        /// </summary>
        /// <value>
        /// A list of codings that describe the type of signature.
        /// </value>
        /// <remarks>
        /// The type specifies the kind of signature being provided. Common types
        /// include author's signature, patient's signature, prescriber's signature,
        /// and witness signature. This helps identify the role and authority of
        /// the person who signed the document.
        /// </remarks>
        public List<Coding>? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }

        /// <summary>
        /// Gets or sets the time when the signature was created.
        /// </summary>
        /// <value>
        /// The instant when the signature was created.
        /// </value>
        /// <remarks>
        /// The when specifies the exact time when the signature was created.
        /// This is important for audit trails and legal compliance, as it
        /// establishes when the document was signed.
        /// </remarks>
        public FhirInstant? When
        {
            get { return _When; }
            set
            {
                _When = value;
                OnPropertyChanged("when", value);
            }
        }

        /// <summary>
        /// Gets or sets the reference to the person who signed.
        /// </summary>
        /// <value>
        /// A reference to the person who created the signature.
        /// </value>
        /// <remarks>
        /// The who specifies the person who created the signature. This is
        /// typically a reference to a Practitioner, Patient, or other
        /// relevant resource that identifies the signer.
        /// </remarks>
        public ReferenceType? Who
        {
            get { return _Who; }
            set
            {
                _Who = value;
                OnPropertyChanged("who", value);
            }
        }

        /// <summary>
        /// Gets or sets the reference to the person on whose behalf the signature was created.
        /// </summary>
        /// <value>
        /// A reference to the person on whose behalf the signature was created.
        /// </value>
        /// <remarks>
        /// The onBehalfOf specifies the person on whose behalf the signature
        /// was created. This is used when someone signs on behalf of another
        /// person, such as a legal guardian signing for a minor.
        /// </remarks>
        public ReferenceType? OnBehalfOf
        {
            get { return _OnBehalfOf; }
            set
            {
                _OnBehalfOf = value;
                OnPropertyChanged("onBehalfOf", value);
            }
        }

        /// <summary>
        /// Gets or sets the mime type of the target resource being signed.
        /// </summary>
        /// <value>
        /// The mime type of the target resource being signed.
        /// </value>
        /// <remarks>
        /// The targetFormat specifies the mime type of the target resource
        /// being signed. This helps verify that the signature is being
        /// applied to the correct type of document.
        /// </remarks>
        public FhirCode? TargetFormat
        {
            get { return _TargetFormat; }
            set
            {
                _TargetFormat = value;
                OnPropertyChanged("targetFormat", value);
            }
        }

        /// <summary>
        /// Gets or sets the mime type of the signature.
        /// </summary>
        /// <value>
        /// The mime type of the signature data.
        /// </value>
        /// <remarks>
        /// The sigFormat specifies the mime type of the signature data.
        /// This indicates the format of the signature, such as PKCS#7,
        /// XML signature, or other signature formats.
        /// </remarks>
        public FhirCode? SigFormat
        {
            get { return _SigFormat; }
            set
            {
                _SigFormat = value;
                OnPropertyChanged("sigFormat", value);
            }
        }

        /// <summary>
        /// Gets or sets the actual signature data.
        /// </summary>
        /// <value>
        /// The actual signature data as a base64-encoded string.
        /// </value>
        /// <remarks>
        /// The data contains the actual signature data as a base64-encoded
        /// string. This is the digital signature that can be used to verify
        /// the authenticity and integrity of the signed document.
        /// </remarks>
        public FhirBase64Binary? Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
                OnPropertyChanged("data", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signature"/> class.
        /// </summary>
        public Signature() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signature"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the signature data.</param>
        public Signature(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Signature"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the signature.</param>
        public Signature(string value) : base(value) { }
    }
}
