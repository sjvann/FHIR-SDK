
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR MarketingStatus data type.
    /// The marketing status describes the path that a product takes to reach the market.
    /// </summary>
    /// <remarks>
    /// MarketingStatus describes the marketing status of a product, including the
    /// countries and jurisdictions where it is marketed, the status of marketing
    /// in those regions, and the time periods during which it is marketed.
    /// This is commonly used for pharmaceutical products, medical devices, and
    /// other healthcare products that require regulatory approval.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple marketing status
    /// var marketingStatus = new MarketingStatus
    /// {
    ///     Country = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/iso3166-1-2"),
    ///                 Code = new FhirCode("US"),
    ///                 Display = new FhirString("United States")
    ///             }
    ///         }
    ///     },
    ///     Status = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActStatus"),
    ///                 Code = new FhirCode("active"),
    ///                 Display = new FhirString("Active")
    ///             }
    ///         }
    ///     }
    /// };
    ///
    /// // Create a marketing status with jurisdiction and date range
    /// var detailedMarketingStatus = new MarketingStatus
    /// {
    ///     Country = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/iso3166-1-2"),
    ///                 Code = new FhirCode("CA"),
    ///                 Display = new FhirString("Canada")
    ///             }
    ///         }
    ///     },
    ///     Jurisdiction = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/iso3166-2"),
    ///                 Code = new FhirCode("CA-ON"),
    ///                 Display = new FhirString("Ontario")
    ///             }
    ///         }
    ///     },
    ///     Status = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActStatus"),
    ///                 Code = new FhirCode("active"),
    ///                 Display = new FhirString("Active")
    ///             }
    ///         }
    ///     },
    ///     DateRange = new Period
    ///     {
    ///         Start = new FhirDateTime(DateTime.Today),
    ///         End = new FhirDateTime(DateTime.Today.AddYears(5))
    ///     }
    /// };
    ///
    /// // Create a marketing status with restore date
    /// var suspendedMarketingStatus = new MarketingStatus
    /// {
    ///     Country = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/iso3166-1-2"),
    ///                 Code = new FhirCode("EU"),
    ///                 Display = new FhirString("European Union")
    ///             }
    ///         }
    ///     },
    ///     Status = new CodeableConcept
    ///     {
    ///         Coding = new List&lt;Coding&gt;
    ///         {
    ///             new Coding
    ///             {
    ///                 System = new FhirUri("http://terminology.hl7.org/CodeSystem/v3-ActStatus"),
    ///                 Code = new FhirCode("suspended"),
    ///                 Display = new FhirString("Suspended")
    ///             }
    ///         }
    ///     },
    ///     RestoreDate = new FhirDateTime(DateTime.Today.AddMonths(6))
    /// };
    /// </code>
    /// </example>
    public class MarketingStatus : ComplexType<MarketingStatus>
    {
        private CodeableConcept? _country;
        private CodeableConcept? _jurisdiction;
        private CodeableConcept? _status;
        private Period? dateRange;
        private FhirDateTime? _restoreDate;

        /// <summary>
        /// Gets or sets the country where the product is marketed.
        /// </summary>
        /// <value>
        /// A coded concept that describes the country where the product is marketed.
        /// </value>
        /// <remarks>
        /// The country specifies the country where the product is marketed. This
        /// is typically coded using ISO 3166-1 alpha-2 country codes. The country
        /// determines the regulatory environment and requirements for the product.
        /// </remarks>
        public CodeableConcept? Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged("country", value);
            }
        }

        /// <summary>
        /// Gets or sets the jurisdiction where the product is marketed.
        /// </summary>
        /// <value>
        /// A coded concept that describes the jurisdiction where the product is marketed.
        /// </value>
        /// <remarks>
        /// The jurisdiction specifies the specific jurisdiction (state, province,
        /// region) where the product is marketed. This provides more granular
        /// information than the country and is important for products that have
        /// different regulatory requirements within a country.
        /// </remarks>
        public CodeableConcept? Jurisdiction
        {
            get { return _jurisdiction; }
            set
            {
                _jurisdiction = value;
                OnPropertyChanged("jurisdiction", value);
            }
        }

        /// <summary>
        /// Gets or sets the status of marketing in the specified country/jurisdiction.
        /// </summary>
        /// <value>
        /// A coded concept that describes the marketing status.
        /// </value>
        /// <remarks>
        /// The status specifies the current marketing status of the product in
        /// the specified country or jurisdiction. Common statuses include active,
        /// suspended, withdrawn, and pending. This reflects the regulatory
        /// approval and market availability of the product.
        /// </remarks>
        public CodeableConcept? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }

        /// <summary>
        /// Gets or sets the date range during which the marketing status applies.
        /// </summary>
        /// <value>
        /// The period during which the marketing status is valid.
        /// </value>
        /// <remarks>
        /// The dateRange specifies the time period during which the marketing
        /// status applies. This is important for tracking changes in marketing
        /// status over time and for products that have temporary approvals or
        /// suspensions.
        /// </remarks>
        public Period? DateRange
        {
            get { return dateRange; }
            set
            {
                dateRange = value;
                OnPropertyChanged("dateRange", value);
            }
        }

        /// <summary>
        /// Gets or sets the date when the marketing status will be restored.
        /// </summary>
        /// <value>
        /// The date when the marketing status will be restored.
        /// </value>
        /// <remarks>
        /// The restoreDate specifies when a suspended marketing status will be
        /// restored. This is used when a product has been temporarily suspended
        /// and there is a planned date for resumption of marketing activities.
        /// </remarks>
        public FhirDateTime? RestoreDate
        {
            get { return _restoreDate; }
            set
            {
                _restoreDate = value;
                OnPropertyChanged("restoreDate", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingStatus"/> class.
        /// </summary>
        public MarketingStatus() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingStatus"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the marketing status data.</param>
        public MarketingStatus(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingStatus"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the marketing status.</param>
        public MarketingStatus(string value) : base(value) { }
    }
}
