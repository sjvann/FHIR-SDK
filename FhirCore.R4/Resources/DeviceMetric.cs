using FhirCore.Base;
using FhirCore.R4;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R4.Resources
{
    /// <summary>
    /// FHIR R4 DeviceMetric 資源
    /// 
    /// <para>
    /// Describes a measurement, calculation or setting capability of a medical device.
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
    /// R4 版本的 DeviceMetric 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceMetric : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _calibration;

        /// <summary>
        /// calibration
        /// </summary>
        /// <remarks>
        /// <para>
        /// calibration 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? calibration
        {
            get => _calibration;
            set
            {
                _calibration = value;
                OnPropertyChanged(nameof(calibration));
            }
        }

        private FhirCode? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
            }
        }

        private FhirCode? _color;

        /// <summary>
        /// color
        /// </summary>
        /// <remarks>
        /// <para>
        /// color 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? color
        {
            get => _color;
            set
            {
                _color = value;
                OnPropertyChanged(nameof(color));
            }
        }

        private List<FhirString>? _contained;

        /// <summary>
        /// contained
        /// </summary>
        /// <remarks>
        /// <para>
        /// contained 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contained
        {
            get => _contained;
            set
            {
                _contained = value;
                OnPropertyChanged(nameof(contained));
            }
        }

        private List<Extension>? _extension;

        /// <summary>
        /// extension
        /// </summary>
        /// <remarks>
        /// <para>
        /// extension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? extension
        {
            get => _extension;
            set
            {
                _extension = value;
                OnPropertyChanged(nameof(extension));
            }
        }

        private FhirString? _id;

        /// <summary>
        /// id
        /// </summary>
        /// <remarks>
        /// <para>
        /// id 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(id));
            }
        }

        private List<Identifier>? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(identifier));
            }
        }

        private FhirUri? _implicitrules;

        /// <summary>
        /// implicitRules
        /// </summary>
        /// <remarks>
        /// <para>
        /// implicitRules 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? implicitRules
        {
            get => _implicitrules;
            set
            {
                _implicitrules = value;
                OnPropertyChanged(nameof(implicitRules));
            }
        }

        private FhirCode? _language;

        /// <summary>
        /// language
        /// </summary>
        /// <remarks>
        /// <para>
        /// language 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged(nameof(language));
            }
        }

        private Timing? _measurementperiod;

        /// <summary>
        /// measurementPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// measurementPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Timing? measurementPeriod
        {
            get => _measurementperiod;
            set
            {
                _measurementperiod = value;
                OnPropertyChanged(nameof(measurementPeriod));
            }
        }

        private Meta? _meta;

        /// <summary>
        /// meta
        /// </summary>
        /// <remarks>
        /// <para>
        /// meta 的詳細描述。
        /// </para>
        /// </remarks>
        public Meta? meta
        {
            get => _meta;
            set
            {
                _meta = value;
                OnPropertyChanged(nameof(meta));
            }
        }

        private List<Extension>? _modifierextension;

        /// <summary>
        /// modifierExtension
        /// </summary>
        /// <remarks>
        /// <para>
        /// modifierExtension 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Extension>? modifierExtension
        {
            get => _modifierextension;
            set
            {
                _modifierextension = value;
                OnPropertyChanged(nameof(modifierExtension));
            }
        }

        private FhirCode? _operationalstatus;

        /// <summary>
        /// operationalStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// operationalStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? operationalStatus
        {
            get => _operationalstatus;
            set
            {
                _operationalstatus = value;
                OnPropertyChanged(nameof(operationalStatus));
            }
        }

        private ReferenceType? _parent;

        /// <summary>
        /// parent
        /// </summary>
        /// <remarks>
        /// <para>
        /// parent 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? parent
        {
            get => _parent;
            set
            {
                _parent = value;
                OnPropertyChanged(nameof(parent));
            }
        }

        private ReferenceType? _source;

        /// <summary>
        /// source
        /// </summary>
        /// <remarks>
        /// <para>
        /// source 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? source
        {
            get => _source;
            set
            {
                _source = value;
                OnPropertyChanged(nameof(source));
            }
        }

        private FhirString? _text;

        /// <summary>
        /// text
        /// </summary>
        /// <remarks>
        /// <para>
        /// text 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? text
        {
            get => _text;
            set
            {
                _text = value;
                OnPropertyChanged(nameof(text));
            }
        }

        private CodeableConcept? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private CodeableConcept? _unit;

        /// <summary>
        /// unit
        /// </summary>
        /// <remarks>
        /// <para>
        /// unit 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? unit
        {
            get => _unit;
            set
            {
                _unit = value;
                OnPropertyChanged(nameof(unit));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DeviceMetric";

        /// <summary>
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
    }
}
