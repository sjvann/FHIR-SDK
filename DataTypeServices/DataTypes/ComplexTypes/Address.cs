
using DataTypeServices.Builders;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;
using TerminologyService.ValueSet;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Address data type.
    /// An address expressed using postal conventions (as opposed to GPS or other location definition formats).
    /// This data type may be used to convey addresses for use in delivering mail as well as for visiting locations
    /// which might not be valid for mail delivery. There are a variety of postal address formats defined around the world.
    /// </summary>
    /// <remarks>
    /// The Address data type is used to represent postal addresses. It includes components such as street address lines,
    /// city, state/province, postal code, and country. It also supports different use contexts (home, work, temporary)
    /// and types (postal, physical, both).
    /// </remarks>
    /// <example>
    /// <code>
    /// var address = new Address
    /// {
    ///     Use = FhirCode&lt;EnumAddressUse&gt;.Init(EnumAddressUse.home),
    ///     Type = FhirCode&lt;EnumAddressType&gt;.Init(EnumAddressType.physical),
    ///     Line = new List&lt;FhirString&gt; { new FhirString("123 Main Street"), new FhirString("Apt 4B") },
    ///     City = new FhirString("Anytown"),
    ///     State = new FhirString("NY"),
    ///     PostalCode = new FhirString("12345"),
    ///     Country = new FhirString("USA")
    /// };
    /// </code>
    /// </example>
    public class Address : ComplexType<Address>
    {
        #region Private Fields

        private FhirCode<EnumAddressUse>? _Use;
        private FhirCode<EnumAddressType>? _Type;
        private FhirString? _Text;
        private List<FhirString>? _Line;
        private FhirString? _City;
        private FhirString? _District;
        private FhirString? _State;
        private FhirString? _PostalCode;
        private FhirString? _Country;
        private Period? _Period;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the purpose of this address.
        /// </summary>
        /// <value>
        /// A coded value indicating the purpose of the address (home, work, temp, old, billing).
        /// </value>
        /// <remarks>
        /// Applications can assume that an address is current unless it explicitly says that it is temporary or old.
        /// </remarks>
        public FhirCode<EnumAddressUse>? Use
        {
            get { return _Use; }
            set
            {
                _Use = value;
                OnPropertyChanged("use", value);
            }
        }

        /// <summary>
        /// Gets or sets the type of address.
        /// </summary>
        /// <value>
        /// A coded value distinguishing between postal and physical or both (postal, physical, both).
        /// </value>
        /// <remarks>
        /// The distinction between postal and physical is relevant to, among others, delivery services
        /// that might restrict their service to one type of address only.
        /// </remarks>
        public FhirCode<EnumAddressType>? Type
        {
            get { return _Type; }
            set
            {
                _Type = value;
                OnPropertyChanged("type", value);
            }
        }

        /// <summary>
        /// Gets or sets the text representation of the address.
        /// </summary>
        /// <value>
        /// Specifies the entire address as it should be displayed e.g. on a postal label.
        /// This may be provided instead of or as well as the specific parts.
        /// </value>
        /// <remarks>
        /// Can provide both a text representation and parts. Applications updating an address
        /// SHALL ensure that when both text and parts are present, no content is included in the text
        /// that isn't found in a part.
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
        /// <summary>
        /// Gets or sets the street address lines.
        /// </summary>
        /// <value>
        /// This component contains the house number, apartment number, street name, street direction,
        /// P.O. Box number, delivery hints, and similar address information.
        /// </value>
        /// <remarks>
        /// Multiple line elements can be provided to represent different parts of the street address.
        /// The order of line elements is significant and should be preserved.
        /// </remarks>
        public List<FhirString>? Line
        {
            get { return _Line; }
            set
            {
                _Line = value;
                OnPropertyChanged("line", value);
            }
        }

        /// <summary>
        /// Gets or sets the name of the city, town, suburb, village or other community or delivery center.
        /// </summary>
        /// <value>
        /// The name of the city, town, village, or other community or delivery center.
        /// </value>
        public FhirString? City
        {
            get { return _City; }
            set
            {
                _City = value;
                OnPropertyChanged("city", value);
            }
        }

        /// <summary>
        /// Gets or sets the name of the administrative area (county).
        /// </summary>
        /// <value>
        /// The name of the administrative area such as a county.
        /// </value>
        /// <remarks>
        /// District is sometimes known as county, but in some regions 'county' is used in place of city (municipality),
        /// so county name should be conveyed in city instead.
        /// </remarks>
        public FhirString? District
        {
            get { return _District; }
            set
            {
                _District = value;
                OnPropertyChanged("district", value);
            }
        }

        /// <summary>
        /// Gets or sets the sub-unit of a country with limited sovereignty in a federally organized country.
        /// </summary>
        /// <value>
        /// A sub-unit of a country with limited sovereignty in a federally organized country.
        /// A code may be used if codes are in common use (e.g. US 2 letter state codes).
        /// </value>
        /// <remarks>
        /// For addresses in the US, this would be the state. For addresses in Canada, this would be the province.
        /// </remarks>
        public FhirString? State
        {
            get { return _State; }
            set
            {
                _State = value;
                OnPropertyChanged("state", value);
            }
        }

        /// <summary>
        /// Gets or sets the postal code for area.
        /// </summary>
        /// <value>
        /// A postal code designating a region defined by the postal service.
        /// </value>
        /// <remarks>
        /// Also known as ZIP code in the United States.
        /// </remarks>
        public FhirString? PostalCode
        {
            get { return _PostalCode; }
            set
            {
                _PostalCode = value;
                OnPropertyChanged("postalCode", value);
            }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// Country - a nation as commonly understood or generally accepted.
        /// </value>
        /// <remarks>
        /// ISO 3166 3 letter codes can be used in place of a human readable country name.
        /// </remarks>
        public FhirString? Country
        {
            get { return _Country; }
            set
            {
                _Country = value;
                OnPropertyChanged("country", value);
            }
        }
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
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the address data.</param>
        public Address(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class from a JSON string.
        /// </summary>
        /// <param name="value">The JSON string containing the address data.</param>
        public Address(string value) : base(value) { }

        #endregion

        #region Fluent Builder Methods

        /// <summary>
        /// 創建 Address Builder
        /// </summary>
        /// <returns>AddressBuilder 實例</returns>
        public static AddressBuilder Builder()
        {
            return new AddressBuilder();
        }

        /// <summary>
        /// 從現有 Address 創建 Builder
        /// </summary>
        /// <param name="address">現有的 Address</param>
        /// <returns>AddressBuilder 實例</returns>
        public static AddressBuilder Builder(Address address)
        {
            return new AddressBuilder(address);
        }

        /// <summary>
        /// 快速創建家庭地址
        /// </summary>
        /// <param name="configure">配置動作</param>
        /// <returns>Address 實例</returns>
        public static Address Home(Action<AddressBuilder> configure)
        {
            var builder = Builder().WithUse(EnumAddressUse.home);
            configure(builder);
            return builder.Build();
        }

        /// <summary>
        /// 快速創建工作地址
        /// </summary>
        /// <param name="configure">配置動作</param>
        /// <returns>Address 實例</returns>
        public static Address Work(Action<AddressBuilder> configure)
        {
            var builder = Builder().WithUse(EnumAddressUse.work);
            configure(builder);
            return builder.Build();
        }

        /// <summary>
        /// 快速創建臨時地址
        /// </summary>
        /// <param name="configure">配置動作</param>
        /// <returns>Address 實例</returns>
        public static Address Temp(Action<AddressBuilder> configure)
        {
            var builder = Builder().WithUse(EnumAddressUse.temp);
            configure(builder);
            return builder.Build();
        }

        #endregion
    }
}
