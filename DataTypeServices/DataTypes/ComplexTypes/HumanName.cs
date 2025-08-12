
using DataTypeServices.Builders;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using TerminologyService.ValueSet;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR HumanName data type.
    /// A human's name with the ability to identify parts and usage.
    /// </summary>
    /// <remarks>
    /// Names may be changed, or repudiated, or people may have different names in different contexts.
    /// Names may be divided into parts of different type that have variable significance depending
    /// on context, though the division into parts does not always matter. With personal names,
    /// the different parts might or might not be imbued with some implicit meaning; various cultures
    /// associate different importance with the name parts and the degree to which systems must care
    /// about name parts around the world varies widely.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple name
    /// var name = new HumanName
    /// {
    ///     Use = new FhirCode("official"),
    ///     Family = new FhirString("Doe"),
    ///     Given = new List&lt;FhirString&gt; { new FhirString("John"), new FhirString("William") }
    /// };
    ///
    /// // Using the fluent builder
    /// var name2 = HumanName.Builder()
    ///     .WithUse("official")
    ///     .WithFamily("Smith")
    ///     .WithGiven("Jane", "Marie")
    ///     .WithPrefix("Dr.")
    ///     .Build();
    /// </code>
    /// </example>
    public class HumanName : ComplexType<HumanName>
    {
        #region Private Fields

        private FhirCode? _Use;
        private FhirString? _Text;
        private FhirString? _Family;
        private List<FhirString>? _Given;
        private List<FhirString>? _Prefix;
        private List<FhirString>? _Suffix;
        private Period? _Period;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the use of this name.
        /// </summary>
        /// <value>
        /// Identifies the purpose for this name (usual, official, temp, nickname, anonymous, old, maiden).
        /// </value>
        /// <remarks>
        /// Applications can assume that a name is current unless it explicitly says that it is temporary or old.
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
        /// Gets or sets the text representation of the full name.
        /// </summary>
        /// <value>
        /// Specifies the entire name as it should be displayed e.g. on an application UI.
        /// This may be provided instead of or as well as the specific parts.
        /// </value>
        /// <remarks>
        /// Can provide both a text representation and parts. Applications updating a name
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
        /// Gets or sets the family name (surname).
        /// </summary>
        /// <value>
        /// The part of a name that links to the genealogy. In some cultures (e.g. Eritrea)
        /// the family name of a son is the first name of his father.
        /// </value>
        /// <remarks>
        /// Family Name may be decomposed into specific parts using extensions (de, nl, es related cultures).
        /// </remarks>
        public FhirString? Family
        {
            get { return _Family; }
            set
            {
                _Family = value;
                OnPropertyChanged("family", value);
            }
        }
        public List<FhirString>? Given
        {
            get { return _Given; }
            set
            {
                _Given = value;
                OnPropertyChanged("given", value);
            }
        }
        public List<FhirString>? Prefix
        {
            get { return _Prefix; }
            set
            {
                _Prefix = value;
                OnPropertyChanged("prefix", value);
            }
        }
        public List<FhirString>? Suffix
        {
            get { return _Suffix; }
            set
            {
                _Suffix = value;
                OnPropertyChanged("suffix", value);
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
        /// Initializes a new instance of the <see cref="HumanName"/> class.
        /// </summary>
        public HumanName() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanName"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the name data.</param>
        public HumanName(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="HumanName"/> class from a JSON string.
        /// </summary>
        /// <param name="value">The JSON string containing the name data.</param>
        public HumanName(string value) : base(value) { }

        #endregion

        #region Fluent Builder Methods

        /// <summary>
        /// 創建 HumanName Builder
        /// </summary>
        /// <returns>HumanNameBuilder 實例</returns>
        public static HumanNameBuilder Builder()
        {
            return new HumanNameBuilder();
        }

        /// <summary>
        /// 從現有 HumanName 創建 Builder
        /// </summary>
        /// <param name="humanName">現有的 HumanName</param>
        /// <returns>HumanNameBuilder 實例</returns>
        public static HumanNameBuilder Builder(HumanName humanName)
        {
            return new HumanNameBuilder(humanName);
        }

        /// <summary>
        /// 快速創建正式姓名
        /// </summary>
        /// <param name="firstName">名</param>
        /// <param name="lastName">姓</param>
        /// <returns>HumanName 實例</returns>
        public static HumanName Official(string firstName, string lastName)
        {
            return Builder()
                .WithUse("official")
                .WithGiven(firstName)
                .WithFamily(lastName)
                .Build();
        }

        /// <summary>
        /// 快速創建暱稱
        /// </summary>
        /// <param name="nickname">暱稱</param>
        /// <returns>HumanName 實例</returns>
        public static HumanName Nickname(string nickname)
        {
            return Builder()
                .WithUse("nickname")
                .WithGiven(nickname)
                .Build();
        }

        /// <summary>
        /// 從完整姓名字符串創建
        /// </summary>
        /// <param name="fullName">完整姓名</param>
        /// <returns>HumanName 實例</returns>
        public static HumanName FromFullName(string fullName)
        {
            return Builder().ParseFullName(fullName).Build();
        }

        #endregion
    }
}
