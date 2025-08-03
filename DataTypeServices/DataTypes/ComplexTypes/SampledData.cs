
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using System.Text.Json.Nodes;

namespace DataTypeServices.DataTypes.ComplexTypes
{
    /// <summary>
    /// Represents a FHIR SampledData data type.
    /// A series of measurements taken by a device, represented as a series of data points.
    /// </summary>
    /// <remarks>
    /// SampledData represents a series of measurements taken by a device, such as a
    /// blood glucose monitor, heart rate monitor, or other medical device. It includes
    /// information about the origin point, sampling interval, and the actual data points.
    /// This is commonly used for continuous monitoring data and device measurements.
    /// </remarks>
    /// <example>
    /// <code>
    /// // Create a simple sampled data for blood glucose
    /// var glucoseData = new SampledData
    /// {
    ///     Origin = new SimpleQuantity { Value = new FhirDecimal(0), Unit = new FhirString("mg/dL") },
    ///     Interval = new FhirDecimal(15),
    ///     IntervalUnit = new FhirCode("min"),
    ///     Factor = new FhirDecimal(1),
    ///     LowerLimit = new FhirDecimal(70),
    ///     UpperLimit = new FhirDecimal(140),
    ///     Dimensions = new FhirPositiveInt(1),
    ///     Data = new FhirString("120,125,118,122,130,128,125")
    /// };
    ///
    /// // Create sampled data for heart rate monitoring
    /// var heartRateData = new SampledData
    /// {
    ///     Origin = new SimpleQuantity { Value = new FhirDecimal(0), Unit = new FhirString("bpm") },
    ///     Interval = new FhirDecimal(1),
    ///     IntervalUnit = new FhirCode("min"),
    ///     Factor = new FhirDecimal(1),
    ///     LowerLimit = new FhirDecimal(60),
    ///     UpperLimit = new FhirDecimal(100),
    ///     Dimensions = new FhirPositiveInt(1),
    ///     Data = new FhirString("72,75,73,78,76,74,77")
    /// };
    ///
    /// // Create sampled data with code map
    /// var mappedData = new SampledData
    /// {
    ///     Origin = new SimpleQuantity { Value = new FhirDecimal(0), Unit = new FhirString("mmHg") },
    ///     Interval = new FhirDecimal(30),
    ///     IntervalUnit = new FhirCode("min"),
    ///     Factor = new FhirDecimal(1),
    ///     LowerLimit = new FhirDecimal(90),
    ///     UpperLimit = new FhirDecimal(140),
    ///     Dimensions = new FhirPositiveInt(1),
    ///     CodeMap = new FhirCanonical("http://example.com/codes/systolic-pressure"),
    ///     Data = new FhirString("120,125,118,122,130,128,125")
    /// };
    /// </code>
    /// </example>
    public class SampledData : ComplexType<SampledData>
    {
        private SimpleQuantity? _Origin;
        private FhirDecimal? _Interval;
        private FhirCode? _IntervalUnit;
        private FhirDecimal? _Factor;
        private FhirDecimal? _LowerLimit;
        private FhirDecimal? _UpperLimit;
        private FhirPositiveInt? _Dimensions;
        private FhirCanonical? _CodeMap;
        private FhirString? _Offsets;
        private FhirString? _Data;

        /// <summary>
        /// Gets or sets the base quantity that a zero value in the sample represents.
        /// </summary>
        /// <value>
        /// The base quantity that represents the zero point for the sampled data.
        /// </value>
        /// <remarks>
        /// The origin represents the base quantity that a zero value in the sample
        /// represents. This is used to establish the reference point for the data
        /// series. For example, if the origin is 0 mg/dL, then a data point of
        /// 120 represents 120 mg/dL.
        /// </remarks>
        public SimpleQuantity? Origin
        {
            get => _Origin;
            set
            {
                _Origin = value;
                OnPropertyChanged("origin", value);
            }
        }

        /// <summary>
        /// Gets or sets the length of time between sampling points.
        /// </summary>
        /// <value>
        /// The length of time between sampling points.
        /// </value>
        /// <remarks>
        /// The interval specifies the length of time between sampling points.
        /// This is used in conjunction with the intervalUnit to determine the
        /// timing of each data point in the series.
        /// </remarks>
        public FhirDecimal? Interval
        {
            get => _Interval;
            set
            {
                _Interval = value;
                OnPropertyChanged("interval", value);
            }
        }

        /// <summary>
        /// Gets or sets the unit of time for the interval.
        /// </summary>
        /// <value>
        /// The unit of time for the interval (second, minute, hour, day, week, month, year).
        /// </value>
        /// <remarks>
        /// The intervalUnit specifies the unit of time for the interval.
        /// This is used in conjunction with the interval value to determine
        /// the timing of each data point in the series.
        /// </remarks>
        public FhirCode? IntervalUnit
        {
            get => _IntervalUnit;
            set
            {
                _IntervalUnit = value;
                OnPropertyChanged("intervalUnit", value);
            }
        }

        /// <summary>
        /// Gets or sets the factor that is applied to the data values.
        /// </summary>
        /// <value>
        /// The factor that is applied to the data values.
        /// </value>
        /// <remarks>
        /// The factor is a multiplier that is applied to the data values.
        /// This allows for data compression or scaling. For example, if the
        /// factor is 0.1, then a data value of 120 represents 12.0.
        /// </remarks>
        public FhirDecimal? Factor
        {
            get => _Factor;
            set
            {
                _Factor = value;
                OnPropertyChanged("factor", value);
            }
        }

        /// <summary>
        /// Gets or sets the lower limit of detection.
        /// </summary>
        /// <value>
        /// The lower limit of detection for the sampled data.
        /// </value>
        /// <remarks>
        /// The lowerLimit specifies the lower limit of detection for the
        /// sampled data. Values below this limit may not be reliable or
        /// may be below the device's detection threshold.
        /// </remarks>
        public FhirDecimal? LowerLimit
        {
            get => _LowerLimit;
            set
            {
                _LowerLimit = value;
                OnPropertyChanged("lowerLimit", value);
            }
        }

        /// <summary>
        /// Gets or sets the upper limit of detection.
        /// </summary>
        /// <value>
        /// The upper limit of detection for the sampled data.
        /// </value>
        /// <remarks>
        /// The upperLimit specifies the upper limit of detection for the
        /// sampled data. Values above this limit may not be reliable or
        /// may be above the device's detection threshold.
        /// </remarks>
        public FhirDecimal? UpperLimit
        {
            get => _UpperLimit;
            set
            {
                _UpperLimit = value;
                OnPropertyChanged("upperLimit", value);
            }
        }

        /// <summary>
        /// Gets or sets the number of sample points at each time point.
        /// </summary>
        /// <value>
        /// The number of sample points at each time point.
        /// </value>
        /// <remarks>
        /// The dimensions specifies the number of sample points at each
        /// time point. For simple one-dimensional data, this is typically 1.
        /// For multi-dimensional data, this represents the number of values
        /// at each time point.
        /// </remarks>
        public FhirPositiveInt? Dimensions
        {
            get => _Dimensions;
            set
            {
                _Dimensions = value;
                OnPropertyChanged("dimensions", value);
            }
        }

        /// <summary>
        /// Gets or sets the reference to a code map that defines the data.
        /// </summary>
        /// <value>
        /// A reference to a code map that defines the data.
        /// </value>
        /// <remarks>
        /// The codeMap provides a reference to a code map that defines
        /// the meaning of the data values. This is used when the data
        /// values represent coded concepts rather than numeric values.
        /// </remarks>
        public FhirCanonical? CodeMap
        {
            get => _CodeMap;
            set
            {
                _CodeMap = value;
                OnPropertyChanged("codeMap", value);
            }
        }

        /// <summary>
        /// Gets or sets the offsets for the data points.
        /// </summary>
        /// <value>
        /// The offsets for the data points.
        /// </value>
        /// <remarks>
        /// The offsets specify the offsets for the data points. This is
        /// used when the data points are not evenly spaced or when there
        /// are gaps in the data series.
        /// </remarks>
        public FhirString? Offsets
        {
            get => _Offsets;
            set
            {
                _Offsets = value;
                OnPropertyChanged("offsets", value);
            }
        }

        /// <summary>
        /// Gets or sets the actual data points.
        /// </summary>
        /// <value>
        /// The actual data points as a comma-separated string.
        /// </value>
        /// <remarks>
        /// The data contains the actual data points as a comma-separated
        /// string. The values are relative to the origin and may be
        /// scaled by the factor. The number of values should match the
        /// expected number based on the dimensions and time series.
        /// </remarks>
        public FhirString? Data
        {
            get => _Data;
            set
            {
                _Data = value;
                OnPropertyChanged("data", value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampledData"/> class.
        /// </summary>
        public SampledData() : base() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampledData"/> class from a JSON object.
        /// </summary>
        /// <param name="value">The JSON object containing the sampled data.</param>
        public SampledData(JsonObject value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampledData"/> class from a string value.
        /// </summary>
        /// <param name="value">The string representation of the sampled data.</param>
        public SampledData(string value) : base(value) { }
    }
}
