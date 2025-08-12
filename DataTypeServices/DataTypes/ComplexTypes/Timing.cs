using System.Text.Json.Nodes;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.PrimitiveTypes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// 表示 FHIR Timing 資料類型
    /// 
    /// <para>
    /// 指定可能多次發生的事件。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var timing = new Timing
    /// {
    ///     Event = new List&lt;FhirDateTime&gt; { new FhirDateTime(DateTime.Now.AddDays(1)) }
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Timing 用於指定事件應何時發生。它可以表示單一事件、
    /// 重複事件或複雜的排程。
    /// </para>
    /// </remarks>
    public class Timing : BackboneType<Timing>
    {

        private List<FhirDateTime>? _Event;
        private Repeat? _Repeat;
        private CodeableConcept? _Code;

        /// <summary>
        /// 取得或設定事件的一天中的時間
        /// </summary>
        /// <value>事件應發生的日期/時間值列表</value>
        public List<FhirDateTime>? Event
        {
            get { return _Event; }
            set
            {
                _Event = value;
                OnPropertyChanged("event", value);
            }
        }

        /// <summary>
        /// 取得或設定此計時的重複模式
        /// </summary>
        /// <value>定義事件應多久發生一次的重複模式</value>
        public Repeat? Repeat
        {
            get { return _Repeat; }
            set
            {
                _Repeat = value;
                OnPropertyChanged("repeat", value);
            }
        }

        /// <summary>
        /// 取得或設定此計時的編碼概念
        /// </summary>
        /// <value>描述計時事件的編碼概念</value>
        public CodeableConcept? Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("code", value);
            }
        }

        /// <summary>
        /// 初始化 Timing 類別的新執行個體
        /// </summary>
        public Timing() : base() { }

        /// <summary>
        /// 從 JSON 物件初始化 Timing 類別的新執行個體
        /// </summary>
        /// <param name="value">包含計時資料的 JSON 物件</param>
        public Timing(JsonObject value) : base(value) { }

        /// <summary>
        /// 從字串值初始化 Timing 類別的新執行個體
        /// </summary>
        /// <param name="value">計時的字串表示</param>
        public Timing(string value) : base(value) { }
    }

    /// <summary>
    /// 表示 FHIR Repeat 資料類型
    /// 
    /// <para>
    /// 描述事件應何時發生的一組規則。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var repeat = new Repeat
    /// {
    ///     Frequency = new FhirPositiveInt(1),
    ///     Period = new FhirDecimal(1),
    ///     PeriodUnit = new FhirCode("d")
    /// };
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Repeat 定義重複事件的模式。它包括頻率、週期、
    /// 邊界和其他控制事件發生的參數。
    /// </para>
    /// </remarks>
    public class Repeat : ComplexType<Repeat>
    {
        private ChoiceType? _Bounds;
        private FhirPositiveInt? _Count;
        private FhirPositiveInt? _CountMax;
        private FhirDecimal? _Duration;
        private FhirDecimal? _DurationMax;
        private FhirCode? _DurationUnit;
        private FhirPositiveInt? _Frequency;
        private FhirPositiveInt? _FrequencyMax;
        private FhirDecimal? _Period;
        private FhirDecimal? _PeriodMax;
        private FhirCode? _PeriodUnit;
        private List<FhirCode>? _DayOfWeek;
        private List<FhirTime>? _TimeOfDay;
        private List<FhirCode>? _When;
        private FhirUnsignedInt? _Offset;

        /// <summary>
        /// 取得或設定重複事件應發生的時間長度
        /// </summary>
        /// <value>重複事件的邊界，可以是 Duration 或 Period</value>
        public ChoiceType? Bounds
        {
            get { return _Bounds; }
            set
            {
                _Bounds = value;
                OnPropertyChanged("bounds", value);
            }
        }

        /// <summary>
        /// 取得或設定事件應發生的次數
        /// </summary>
        /// <value>事件應發生的次數</value>
        public FhirPositiveInt? Count
        {
            get { return _Count; }
            set
            {
                _Count = value;
                OnPropertyChanged("count", value);
            }
        }

        /// <summary>
        /// 取得或設定事件應發生的最大次數
        /// </summary>
        /// <value>事件應發生的最大次數</value>
        public FhirPositiveInt? CountMax
        {
            get { return _CountMax; }
            set
            {
                _CountMax = value;
                OnPropertyChanged("countMax", value);
            }
        }

        /// <summary>
        /// 取得或設定事件每次發生的持續時間
        /// </summary>
        /// <value>事件每次發生的持續時間</value>
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
        /// 取得或設定事件每次發生的最大持續時間
        /// </summary>
        /// <value>事件每次發生的最大持續時間</value>
        public FhirDecimal? DurationMax
        {
            get { return _DurationMax; }
            set
            {
                _DurationMax = value;
                OnPropertyChanged("durationMax", value);
            }
        }

        /// <summary>
        /// 取得或設定持續時間的時間單位
        /// </summary>
        /// <value>持續時間的時間單位代碼</value>
        public FhirCode? DurationUnit
        {
            get { return _DurationUnit; }
            set
            {
                _DurationUnit = value;
                OnPropertyChanged("durationUnit", value);
            }
        }

        /// <summary>
        /// 取得或設定事件的頻率
        /// </summary>
        /// <value>事件在週期內應發生的次數</value>
        public FhirPositiveInt? Frequency
        {
            get { return _Frequency; }
            set
            {
                _Frequency = value;
                OnPropertyChanged("frequency", value);
            }
        }

        /// <summary>
        /// 取得或設定事件的最大頻率
        /// </summary>
        /// <value>事件在週期內應發生的最大次數</value>
        public FhirPositiveInt? FrequencyMax
        {
            get { return _FrequencyMax; }
            set
            {
                _FrequencyMax = value;
                OnPropertyChanged("frequencyMax", value);
            }
        }

        /// <summary>
        /// 取得或設定重複事件的週期
        /// </summary>
        /// <value>重複事件的週期</value>
        public FhirDecimal? Period
        {
            get { return _Period; }
            set
            {
                _Period = value;
                OnPropertyChanged("period", value);
            }
        }

        /// <summary>
        /// 取得或設定重複事件的最大週期
        /// </summary>
        /// <value>重複事件的最大週期</value>
        public FhirDecimal? PeriodMax
        {
            get { return _PeriodMax; }
            set
            {
                _PeriodMax = value;
                OnPropertyChanged("periodMax", value);
            }
        }

        /// <summary>
        /// 取得或設定週期的時間單位
        /// </summary>
        /// <value>週期的時間單位代碼</value>
        public FhirCode? PeriodUnit
        {
            get { return _PeriodUnit; }
            set
            {
                _PeriodUnit = value;
                OnPropertyChanged("periodUnit", value);
            }
        }

        /// <summary>
        /// 取得或設定事件應發生的星期幾
        /// </summary>
        /// <value>事件應發生的星期幾代碼列表</value>
        public List<FhirCode>? DayOfWeek
        {
            get { return _DayOfWeek; }
            set
            {
                _DayOfWeek = value;
                OnPropertyChanged("dayOfWeek", value);
            }
        }

        /// <summary>
        /// 取得或設定事件應發生的一天中的時間
        /// </summary>
        /// <value>事件應發生的一天中的時間列表</value>
        public List<FhirTime>? TimeOfDay
        {
            get { return _TimeOfDay; }
            set
            {
                _TimeOfDay = value;
                OnPropertyChanged("timeOfDay", value);
            }
        }

        /// <summary>
        /// 取得或設定事件計時關係
        /// </summary>
        /// <value>事件計時關係代碼列表</value>
        public List<FhirCode>? When
        {
            get { return _When; }
            set
            {
                _When = value;
                OnPropertyChanged("when", value);
            }
        }

        /// <summary>
        /// 取得或設定事件的偏移量
        /// </summary>
        /// <value>事件的偏移量（以分鐘為單位）</value>
        public FhirUnsignedInt? Offset
        {
            get { return _Offset; }
            set
            {
                _Offset = value;
                OnPropertyChanged("offset", value);
            }
        }

        /// <summary>
        /// 初始化 Repeat 類別的新執行個體
        /// </summary>
        public Repeat() : base() { }

        /// <summary>
        /// 從 JSON 物件初始化 Repeat 類別的新執行個體
        /// </summary>
        /// <param name="value">包含重複資料的 JSON 物件</param>
        public Repeat(JsonObject value) : base(value) { }

        /// <summary>
        /// 從字串值初始化 Repeat 類別的新執行個體
        /// </summary>
        /// <param name="value">重複的字串表示</param>
        public Repeat(string value) : base(value) { }
    }
}
