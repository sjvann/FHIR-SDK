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
    /// FHIR R5 DeviceUsage 資源
    /// 
    /// <para>
    /// DeviceUsage 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var deviceusage = new DeviceUsage("deviceusage-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 DeviceUsage 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class DeviceUsage : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _derivedfrom;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _context;
        private DeviceUsageTimingChoice? _timing;
        private FhirDateTime? _dateasserted;
        private CodeableConcept? _usagestatus;
        private List<CodeableConcept>? _usagereason;
        private DeviceUsageAdherence? _adherence;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _informationsource;
        private CodeableReference? _device;
        private List<CodeableReference>? _reason;
        private CodeableReference? _bodysite;
        private List<Annotation>? _note;
        private CodeableConcept? _code;
        private List<CodeableConcept>? _reason;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "DeviceUsage";        /// <summary>
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
        /// Basedon
        /// </summary>
        /// <remarks>
        /// <para>
        /// Basedon 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Basedon
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(Basedon));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
            }
        }        /// <summary>
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
            }
        }        /// <summary>
        /// Context
        /// </summary>
        /// <remarks>
        /// <para>
        /// Context 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Context
        {
            get => _context;
            set
            {
                _context = value;
                OnPropertyChanged(nameof(Context));
            }
        }        /// <summary>
        /// Timing
        /// </summary>
        /// <remarks>
        /// <para>
        /// Timing 的詳細描述。
        /// </para>
        /// </remarks>
        public DeviceUsageTimingChoice? Timing
        {
            get => _timing;
            set
            {
                _timing = value;
                OnPropertyChanged(nameof(Timing));
            }
        }        /// <summary>
        /// Dateasserted
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dateasserted 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Dateasserted
        {
            get => _dateasserted;
            set
            {
                _dateasserted = value;
                OnPropertyChanged(nameof(Dateasserted));
            }
        }        /// <summary>
        /// Usagestatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usagestatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Usagestatus
        {
            get => _usagestatus;
            set
            {
                _usagestatus = value;
                OnPropertyChanged(nameof(Usagestatus));
            }
        }        /// <summary>
        /// Usagereason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usagereason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Usagereason
        {
            get => _usagereason;
            set
            {
                _usagereason = value;
                OnPropertyChanged(nameof(Usagereason));
            }
        }        /// <summary>
        /// Adherence
        /// </summary>
        /// <remarks>
        /// <para>
        /// Adherence 的詳細描述。
        /// </para>
        /// </remarks>
        public DeviceUsageAdherence? Adherence
        {
            get => _adherence;
            set
            {
                _adherence = value;
                OnPropertyChanged(nameof(Adherence));
            }
        }        /// <summary>
        /// Informationsource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Informationsource 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Informationsource
        {
            get => _informationsource;
            set
            {
                _informationsource = value;
                OnPropertyChanged(nameof(Informationsource));
            }
        }        /// <summary>
        /// Device
        /// </summary>
        /// <remarks>
        /// <para>
        /// Device 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(Device));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableReference? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// 建立新的 DeviceUsage 資源實例
        /// </summary>
        public DeviceUsage()
        {
        }

        /// <summary>
        /// 建立新的 DeviceUsage 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public DeviceUsage(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"DeviceUsage(Id: {Id})";
        }
    }    /// <summary>
    /// DeviceUsageAdherence 背骨元素
    /// </summary>
    public class DeviceUsageAdherence
    {
        // TODO: 添加屬性實作
        
        public DeviceUsageAdherence() { }
    }    /// <summary>
    /// DeviceUsageTimingChoice 選擇類型
    /// </summary>
    public class DeviceUsageTimingChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public DeviceUsageTimingChoice(JsonObject value) : base("deviceusagetiming", value, _supportType) { }
        public DeviceUsageTimingChoice(IComplexType? value) : base("deviceusagetiming", value) { }
        public DeviceUsageTimingChoice(IPrimitiveType? value) : base("deviceusagetiming", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "DeviceUsageTiming" : "deviceusagetiming";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
