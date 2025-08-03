
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Attachment data type.
    /// For referring to data content defined in other formats.
    /// </summary>
    /// <remarks>
    /// An Attachment represents a file or document that is attached to a FHIR resource.
    /// It can contain the actual data (embedded) or a reference to an external location
    /// (URL). Attachments are commonly used for images, documents, reports, and other
    /// binary content in healthcare systems.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple attachment with embedded data
    /// var embeddedAttachment = new Attachment
    /// {
    ///     ContentType = new FhirCode("application/pdf"),
    ///     Language = new FhirCode("en"),
    ///     Data = new FhirBase64Binary("JVBERi0xLjQKJcOkw7zDtsO8..."),
    ///     Size = new FhirInteger64(1024),
    ///     Hash = new FhirBase64Binary("sha256-hash-value"),
    ///     Title = new FhirString("Patient Consent Form"),
    ///     Creation = new FhirDateTime(DateTime.Now)
    /// };
    ///
    /// // Create an attachment with URL reference
    /// var urlAttachment = new Attachment
    /// {
    ///     ContentType = new FhirCode("image/jpeg"),
    ///     Url = new FhirUrl("https://example.com/images/x-ray.jpg"),
    ///     Size = new FhirInteger64(2048),
    ///     Title = new FhirString("Chest X-Ray"),
    ///     Creation = new FhirDateTime(DateTime.Now)
    /// };
    ///
    /// // Create an image attachment with dimensions
    /// var imageAttachment = new Attachment
    /// {
    ///     ContentType = new FhirCode("image/png"),
    ///     Data = new FhirBase64Binary("iVBORw0KGgoAAAANSUhEUgAA..."),
    ///     Size = new FhirInteger64(512),
    ///     Height = new FhirPositiveInt(800),
    ///     Width = new FhirPositiveInt(600),
    ///     Title = new FhirString("Patient Photo"),
    ///     Creation = new FhirDateTime(DateTime.Now)
    /// };
    /// </code>
    /// </example>
    public class Attachment : ComplexType<Attachment>
    {
        private FhirCode? _ContentType;
        private FhirCode? _Language;
        private FhirBase64Binary? _Data;
        private FhirUrl? _Url;
        private FhirInteger64? _Size;
        private FhirBase64Binary? _Hash;
        private FhirString? _Title;
        private FhirDateTime? _Creation;
        private FhirPositiveInt? _Height;
        private FhirPositiveInt? _Width;
        private FhirPositiveInt? _Frames;
        private FhirDecimal? _Duration;
        private FhirPositiveInt? _Pages;

        /// <summary>
        /// Gets or sets the mime type of the content.
        /// </summary>
        /// <value>
        /// The mime type of the content (e.g., "application/pdf", "image/jpeg").
        /// </value>
        /// <remarks>
        /// The contentType specifies the mime type of the attached content.
        /// This helps systems understand how to process and display the content.
        /// Common types include application/pdf, image/jpeg, image/png, etc.
        /// </remarks>
        public FhirCode? ContentType
        {
            get { return _ContentType; }
            set
            {
                _ContentType = value;
                OnPropertyChanged("contentType", value);
            }
        }

        /// <summary>
        /// Gets or sets the language of the content.
        /// </summary>
        /// <value>
        /// The language of the content (e.g., "en", "es", "fr").
        /// </value>
        /// <remarks>
        /// The language specifies the language of the content. This is important
        /// for text-based attachments and helps with accessibility and localization.
        /// </remarks>
        public FhirCode? Language
        {
            get { return _Language; }
            set
            {
                _Language = value;
                OnPropertyChanged("language", value);
            }
        }

        /// <summary>
        /// Gets or sets the actual data of the attachment.
        /// </summary>
        /// <value>
        /// The actual data as a base64-encoded string.
        /// </value>
        /// <remarks>
        /// The data contains the actual content of the attachment as a base64-encoded
        /// string. This is used when the content is embedded in the FHIR resource.
        /// For large files, it's often better to use a URL reference instead.
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
        /// Gets or sets the URL reference to the attachment.
        /// </summary>
        /// <value>
        /// The URL where the attachment can be accessed.
        /// </value>
        /// <remarks>
        /// The url provides a reference to where the attachment can be accessed.
        /// This is used when the content is stored externally rather than embedded
        /// in the FHIR resource. The URL should be accessible and secure.
        /// </remarks>
        public FhirUrl? Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
                OnPropertyChanged("url", value);
            }
        }

        /// <summary>
        /// Gets or sets the size of the attachment in bytes.
        /// </summary>
        /// <value>
        /// The size of the attachment in bytes.
        /// </value>
        /// <remarks>
        /// The size specifies the size of the attachment in bytes. This helps
        /// systems understand the resource requirements for processing the attachment
        /// and can be used for validation and optimization.
        /// </remarks>
        public FhirInteger64? Size
        {
            get { return _Size; }
            set
            {
                _Size = value;
                OnPropertyChanged("size", value);
            }
        }

        /// <summary>
        /// Gets or sets the hash of the attachment data.
        /// </summary>
        /// <value>
        /// The hash of the attachment data for integrity verification.
        /// </value>
        /// <remarks>
        /// The hash provides a cryptographic hash of the attachment data. This
        /// can be used to verify the integrity of the attachment and ensure
        /// that it hasn't been corrupted or tampered with.
        /// </remarks>
        public FhirBase64Binary? Hash
        {
            get { return _Hash; }
            set
            {
                _Hash = value;
                OnPropertyChanged("hash", value);
            }
        }

        /// <summary>
        /// Gets or sets the human-readable title of the attachment.
        /// </summary>
        /// <value>
        /// A human-readable title for the attachment.
        /// </value>
        /// <remarks>
        /// The title provides a human-readable name for the attachment. This
        /// helps users identify the content and understand what the attachment
        /// contains without having to open it.
        /// </remarks>
        public FhirString? Title
        {
            get { return _Title; }
            set
            {
                _Title = value;
                OnPropertyChanged("title", value);
            }
        }

        /// <summary>
        /// Gets or sets the creation date of the attachment.
        /// </summary>
        /// <value>
        /// The date when the attachment was created.
        /// </value>
        /// <remarks>
        /// The creation specifies when the attachment was created. This is
        /// important for audit trails and helps establish the timeline of
        /// when the content was generated.
        /// </remarks>
        public FhirDateTime? Creation
        {
            get { return _Creation; }
            set
            {
                _Creation = value;
                OnPropertyChanged("creation", value);
            }
        }

        /// <summary>
        /// Gets or sets the height of the image in pixels.
        /// </summary>
        /// <value>
        /// The height of the image in pixels.
        /// </value>
        /// <remarks>
        /// The height specifies the height of the image in pixels. This is
        /// only relevant for image attachments and helps with display and
        /// processing of the image content.
        /// </remarks>
        public FhirPositiveInt? Height
        {
            get { return _Height; }
            set
            {
                _Height = value;
                OnPropertyChanged("height", value);
            }
        }

        /// <summary>
        /// Gets or sets the width of the image in pixels.
        /// </summary>
        /// <value>
        /// The width of the image in pixels.
        /// </value>
        /// <remarks>
        /// The width specifies the width of the image in pixels. This is
        /// only relevant for image attachments and helps with display and
        /// processing of the image content.
        /// </remarks>
        public FhirPositiveInt? Width
        {
            get { return _Width; }
            set
            {
                _Width = value;
                OnPropertyChanged("width", value);
            }
        }

        /// <summary>
        /// Gets or sets the number of frames in the image.
        /// </summary>
        /// <value>
        /// The number of frames in the image (for animated images).
        /// </value>
        /// <remarks>
        /// The frames specifies the number of frames in the image. This is
        /// relevant for animated images (like GIFs) and helps systems understand
        /// how to display the image content.
        /// </remarks>
        public FhirPositiveInt? Frames
        {
            get { return _Frames; }
            set
            {
                _Frames = value;
                OnPropertyChanged("frames", value);
            }
        }

        /// <summary>
        /// Gets or sets the duration of the media in seconds.
        /// </summary>
        /// <value>
        /// The duration of the media in seconds.
        /// </value>
        /// <remarks>
        /// The duration specifies the length of the media in seconds. This is
        /// relevant for audio and video attachments and helps systems understand
        /// the length of the media content.
        /// </remarks>
        public FhirDecimal? Duration
        {
            get { return _Duration; }
            set
            {
                _Duration = value;
                OnPropertyChanged("duration", value);
            }
        }

        /// <summary>
        /// Gets or sets the number of pages in the document.
        /// </summary>
        /// <value>
        /// The number of pages in the document.
        /// </value>
        /// <remarks>
        /// The pages specifies the number of pages in the document. This is
        /// relevant for document attachments (like PDFs) and helps users
        /// understand the size and scope of the document.
        /// </remarks>
        public FhirPositiveInt? Pages
        {
            get { return _Pages; }
            set
            {
                _Pages = value;
                OnPropertyChanged("pages", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class.
        /// </summary>
        public Attachment() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the attachment data.</param>
        public Attachment(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attachment"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the attachment.</param>
        public Attachment(string value) : base(value) { }
    }
}
