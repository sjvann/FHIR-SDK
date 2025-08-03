using DataTypeServices.Builders;
using FhirCore.Interfaces;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR Period data type.
    /// A time period defined by a start and end date/time.
    /// </summary>
    /// <remarks>
    /// A Period represents a time interval with a start and end date/time. It is commonly
    /// used to represent time ranges for various purposes such as medication administration
    /// periods, appointment schedules, or validity periods for data elements.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple period
    /// var period = new Period
    /// {
    ///     Start = new FhirDateTime(DateTime.Now),
    ///     End = new FhirDateTime(DateTime.Now.AddDays(7))
    /// };
    ///
    /// // Using the fluent builder
    /// var builderPeriod = Period.Builder()
    ///     .WithRange(DateTime.Today, DateTime.Today.AddDays(30))
    ///     .Build();
    ///
    /// // Quick creation methods
    /// var thisWeek = Period.ThisWeek();
    /// var thisMonth = Period.ThisMonth();
    /// var fromNow = Period.FromNow(TimeSpan.FromDays(14));
    /// </code>
    /// </example>
    public class Period : ComplexType<Period>
    {
        #region Private Fields

        private FhirDateTime? _Start;
        private FhirDateTime? _End;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the start time of the period.
        /// </summary>
        /// <value>
        /// The start date/time of the period. If not present, the period has no start bound.
        /// </value>
        /// <remarks>
        /// The start time represents the beginning of the period. If this is not specified,
        /// the period has no lower time bound. The start time is inclusive in the period.
        /// </remarks>
        public FhirDateTime? Start
        {
            get { return _Start; }
            set
            {
                _Start = value;
                OnPropertyChanged("start", value);
            }
        }

        /// <summary>
        /// Gets or sets the end time of the period.
        /// </summary>
        /// <value>
        /// The end date/time of the period. If not present, the period has no end bound.
        /// </value>
        /// <remarks>
        /// The end time represents the end of the period. If this is not specified,
        /// the period has no upper time bound. The end time is inclusive in the period.
        /// </remarks>
        public FhirDateTime? End
        {
            get { return _End; }
            set
            {
                _End = value;
                OnPropertyChanged("end", value);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class.
        /// </summary>
        public Period() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the period data.</param>
        public Period(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Period"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the period.</param>
        public Period(string value) : base(value) { }

        #endregion

        #region Fluent Builder Methods

        /// <summary>
        /// 創建 Period Builder
        /// </summary>
        /// <returns>PeriodBuilder 實例</returns>
        public static PeriodBuilder Builder()
        {
            return new PeriodBuilder();
        }

        /// <summary>
        /// 從現有 Period 創建 Builder
        /// </summary>
        /// <param name="period">現有的 Period</param>
        /// <returns>PeriodBuilder 實例</returns>
        public static PeriodBuilder Builder(Period period)
        {
            return new PeriodBuilder(period);
        }

        /// <summary>
        /// 快速創建時間範圍
        /// </summary>
        /// <param name="start">開始時間</param>
        /// <param name="end">結束時間</param>
        /// <returns>Period 實例</returns>
        public static Period Range(DateTime start, DateTime end)
        {
            return Builder().WithRange(start, end).Build();
        }

        /// <summary>
        /// 快速創建從現在開始的期間
        /// </summary>
        /// <param name="duration">持續時間</param>
        /// <returns>Period 實例</returns>
        public static Period FromNow(TimeSpan duration)
        {
            return Builder().FromNow(duration).Build();
        }

        /// <summary>
        /// 快速創建過去的期間
        /// </summary>
        /// <param name="duration">持續時間</param>
        /// <returns>Period 實例</returns>
        public static Period ToNow(TimeSpan duration)
        {
            return Builder().ToNow(duration).Build();
        }

        /// <summary>
        /// 快速創建本週期間
        /// </summary>
        /// <returns>Period 實例</returns>
        public static Period ThisWeek()
        {
            return Builder().ThisWeek().Build();
        }

        /// <summary>
        /// 快速創建本月期間
        /// </summary>
        /// <returns>Period 實例</returns>
        public static Period ThisMonth()
        {
            return Builder().ThisMonth().Build();
        }

        #endregion
    }
}
