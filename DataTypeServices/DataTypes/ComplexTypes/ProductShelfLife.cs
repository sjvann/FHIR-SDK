using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR ProductShelfLife data type.
    /// The shelf-life and storage information for a product.
    /// </summary>
    /// <remarks>
    /// ProductShelfLife describes the shelf-life and storage information for a product,
    /// including the type of shelf-life, the period during which the product is
    /// considered safe and effective, and any special precautions for storage.
    /// This is commonly used for pharmaceutical products, medical devices, and
    /// other healthcare products that have expiration dates and storage requirements.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple product shelf life
    /// var shelfLife = new ProductShelfLife
    /// {
    ///     Type = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
    ///                 Code = new FhirCode("EXP"),
    ///                 Display = new FhirString("Expiration Date")
    ///             }
    ///         }
    ///     },
    ///     Period = new ProductShelfLifePeriodChoice(new Duration
    ///     {
    ///         Value = new FhirDecimal(24),
    ///         Unit = new FhirString("months")
    ///     })
    /// };
    ///
    /// // Create a product shelf life with special precautions
    /// var detailedShelfLife = new ProductShelfLife
    /// {
    ///     Type = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
    ///                 Code = new FhirCode("EXP"),
    ///                 Display = new FhirString("Expiration Date")
    ///             }
    ///         }
    ///     },
    ///     Period = new ProductShelfLifePeriodChoice(new Duration
    ///     {
    ///         Value = new FhirDecimal(12),
    ///         Unit = new FhirString("months")
    ///     }),
    ///     SpecialPrecautionsForStorage = new List&lt;CodeableConcept&gt;
    ///     {
    ///         new CodeableConcept
    ///         {
    ///             Coding = new List&lt;Coding&gt;
    ///             {
    ///                 new Coding
    ///                 {
    ///                     System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
    ///                     Code = new FhirCode("REF"),
    ///                     Display = new FhirString("Refrigerated")
    ///                 }
    ///             }
    ///         },
    ///         new CodeableConcept
    ///         {
    ///             Coding = new List&lt;Coding&gt;
    ///             {
    ///                 new Coding
    ///                 {
    ///                     System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
    ///                     Code = new FhirCode("LGT"),
    ///                     Display = new FhirString("Light Sensitive")
    ///                 }
    ///             }
    ///         }
    ///     }
    /// };
    ///
    /// // Create a product shelf life with string period
    /// var stringShelfLife = new ProductShelfLife
    /// {
    ///     Type = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActCode"),
    ///                 Code = new FhirCode("BBD"),
    ///                 Display = new FhirString("Best Before Date")
    ///             }
    ///         }
    ///     },
    ///     Period = new ProductShelfLifePeriodChoice(new FhirString("6 months from date of opening"))
    /// };
    /// </code>
    /// </example>
    public class ProductShelfLife : ComplexType<ProductShelfLife>
    {
        private CodeableConcept? _type;
        private ProductShelfLifePeriodChoice? _period;
        private List<CodeableConcept>? _specialPrecautionsForStorage;

        /// <summary>
        /// Gets or sets the type of shelf-life.
        /// </summary>
        /// <value>
        /// A coded concept that describes the type of shelf-life.
        /// </value>
        /// <remarks>
        /// The type specifies the kind of shelf-life being described. Common types
        /// include expiration date, best before date, and use by date. This helps
        /// systems understand the nature and importance of the shelf-life information.
        /// </remarks>
        public CodeableConcept? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }

        /// <summary>
        /// Gets or sets the period during which the product is considered safe and effective.
        /// </summary>
        /// <value>
        /// The period during which the product is considered safe and effective.
        /// </value>
        /// <remarks>
        /// The period specifies the time period during which the product is considered
        /// safe and effective. This can be expressed as a Duration (e.g., 24 months)
        /// or as a string description (e.g., "6 months from date of opening").
        /// </remarks>
        public ProductShelfLifePeriodChoice? Period
        {
            get { return _period; }
            set
            {
                _period = value;
                OnPropertyChanged("period", value);
            }
        }

        /// <summary>
        /// Gets or sets the special precautions for storage.
        /// </summary>
        /// <value>
        /// A list of coded concepts that describe special precautions for storage.
        /// </value>
        /// <remarks>
        /// The specialPrecautionsForStorage specifies any special handling or storage
        /// requirements for the product. This can include requirements for refrigeration,
        /// protection from light, humidity control, and other environmental factors
        /// that affect product stability.
        /// </remarks>
        public List<CodeableConcept>? SpecialPrecautionsForStorage
        {
            get { return _specialPrecautionsForStorage; }
            set
            {
                _specialPrecautionsForStorage = value;
                OnPropertyChanged("specialPrecautionsForStorage", value);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductShelfLife"/> class.
        /// </summary>
        public ProductShelfLife() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductShelfLife"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the product shelf life data.</param>
        public ProductShelfLife(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductShelfLife"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the product shelf life.</param>
        public ProductShelfLife(string value) : base(value) { }
    }

    /// <summary>
    /// Represents a choice type for ProductShelfLife period.
    /// The period can be either a Duration or a string.
    /// </summary>
    /// <remarks>
    /// ProductShelfLifePeriodChoice allows the period to be expressed either as a
    /// Duration (for precise time periods) or as a string (for descriptive periods
    /// like "6 months from date of opening"). This flexibility accommodates different
    /// ways of expressing shelf-life information.
    /// </remarks>
    public class ProductShelfLifePeriodChoice : ChoiceType
    {
        private static readonly List<string> _supportType = [
            "Duration", "string"
        ];

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductShelfLifePeriodChoice"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the period choice data.</param>
        public ProductShelfLifePeriodChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductShelfLifePeriodChoice"/> class with a complex type value.
        /// </summary>
        /// <param name="value">The complex type value for the period.</param>
        public ProductShelfLifePeriodChoice(IComplexType? value) : base("subject", value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductShelfLifePeriodChoice"/> class with a primitive type value.
        /// </summary>
        /// <param name="value">The primitive type value for the period.</param>
        public ProductShelfLifePeriodChoice(IPrimitiveType? value) : base("subject", value) { }

        /// <summary>
        /// Gets the prefix name for this choice type.
        /// </summary>
        /// <param name="withCapital">Whether to capitalize the first letter.</param>
        /// <returns>The prefix name with appropriate capitalization.</returns>
        public override string GetPrefixName(bool withCapital = true) => "subject".ToTitleCase(withCapital);

        /// <summary>
        /// Gets the list of supported data types for this choice.
        /// </summary>
        /// <returns>A list of supported data type names.</returns>
        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
}
