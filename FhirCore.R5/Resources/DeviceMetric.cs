using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 DeviceMetric 資源
    /// 
    /// <para>
    /// DeviceMetric 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var devicemetric = new DeviceMetric("devicemetric-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DeviceMetric 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceMetric : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private CodeableConcept? _type;
        private CodeableConcept? _unit;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _device;
        private FhirCode? _operationalstatus;
        private FhirCode? _color;
        private FhirCode? _category;
        private Quantity? _measurementfrequency;
        private List<DeviceMetricCalibration>? _calibration;
        private FhirCode? _type;
        private FhirCode? _state;
        private FhirInstant? _time;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DeviceMetric";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Unit
        /// </summary>
        /// <remarks>
        /// <para>
        /// Unit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(Unit));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Operationalstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operationalstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Operationalstatus
        {
            get => _operationalstatus;
            set
            {
                _operationalstatus = value;
                OnPropertyChanged(nameof(Operationalstatus));
            }
        }        /// <summary>
        /// Color
        /// </summary>
        /// <remarks>
        /// <para>
        /// Color 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Measurementfrequency
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measurementfrequency 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? Measurementfrequency
        {
            get => _measurementfrequency;
            set
            {
                _measurementfrequency = value;
                OnPropertyChanged(nameof(Measurementfrequency));
            }
        }        /// <summary>
        /// Calibration
        /// </summary>
        /// <remarks>
        /// <para>
        /// Calibration 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DeviceMetricCalibration>? Calibration
        {
            get => _calibration;
            set
            {
                _calibration = value;
                OnPropertyChanged(nameof(Calibration));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// State
        /// </summary>
        /// <remarks>
        /// <para>
        /// State 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? State
        {
            get => _state;
            set
            {
                _state = value;
                OnPropertyChanged(nameof(State));
            }
        }        /// <summary>
        /// Time
        /// </summary>
        /// <remarks>
        /// <para>
        /// Time 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? Time
        {
            get => _time;
            set
            {
                _time = value;
                OnPropertyChanged(nameof(Time));
            }
        }        /// <summary>
        /// 建立新的 DeviceMetric 資源實例
        /// </summary>
        public DeviceMetric()
        {
        }

        /// <summary>
        /// 建立新的 DeviceMetric 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DeviceMetric(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DeviceMetric(Id: {Id})";
        }
    }    /// <summary>
    /// DeviceMetricCalibration 背骨元素
    /// </summary>
    public class DeviceMetricCalibration
    {
        // TODO: 添加屬性實作
        
        public DeviceMetricCalibration() { }
    }
}
