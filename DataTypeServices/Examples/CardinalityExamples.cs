using DataTypeServices.Attributes;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using DataTypeServices.Validation;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DataTypeServices.Examples
{
    /// <summary>
    /// 示例 Patient 類型，展示 cardinality 屬性的使用
    /// </summary>
    public class ExamplePatient : ComplexType<ExamplePatient>
    {
        private FhirId? _id;
        private List<Identifier>? _identifier;
        private FhirBoolean? _active;
        private List<HumanName>? _name;
        private List<ContactPoint>? _telecom;
        private FhirCode? _gender;
        private FhirDate? _birthDate;
        private List<Address>? _address;

        /// <summary>
        /// 患者 ID - 可選 (0..1)
        /// </summary>
        [Optional]
        public new FhirId? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("id", value);
            }
        }

        /// <summary>
        /// 識別符 - 可選多值 (0..*)
        /// </summary>
        [OptionalMultiple]
        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        /// <summary>
        /// 是否啟用 - 可選 (0..1)
        /// </summary>
        [Optional]
        public FhirBoolean? Active
        {
            get { return _active; }
            set
            {
                _active = value;
                OnPropertyChanged("active", value);
            }
        }

        /// <summary>
        /// 姓名 - 必填多值 (1..*)
        /// </summary>
        [RequiredMultiple]
        public List<HumanName>? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("name", value);
            }
        }

        /// <summary>
        /// 聯絡方式 - 可選多值 (0..*)
        /// </summary>
        [OptionalMultiple]
        public List<ContactPoint>? Telecom
        {
            get { return _telecom; }
            set
            {
                _telecom = value;
                OnPropertyChanged("telecom", value);
            }
        }

        /// <summary>
        /// 性別 - 可選 (0..1)
        /// </summary>
        [Optional]
        public FhirCode? Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
                OnPropertyChanged("gender", value);
            }
        }

        /// <summary>
        /// 出生日期 - 可選 (0..1)
        /// </summary>
        [Optional]
        public FhirDate? BirthDate
        {
            get { return _birthDate; }
            set
            {
                _birthDate = value;
                OnPropertyChanged("birthDate", value);
            }
        }

        /// <summary>
        /// 地址 - 限制最多 3 個 (0..3)
        /// </summary>
        [Cardinality(0, 3)]
        public List<Address>? Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("address", value);
            }
        }

        public ExamplePatient() : base() { }
        public ExamplePatient(JsonObject value) : base(value) { }
        public ExamplePatient(string value) : base(value) { }
    }

    /// <summary>
    /// 示例 Observation 類型，展示更複雜的 cardinality 約束
    /// </summary>
    public class ExampleObservation : ComplexType<ExampleObservation>
    {
        private FhirId? _id;
        private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _code;
        private ReferenceType? _subject;
        private List<ReferenceType>? _performer;
        private FhirDateTime? _effectiveDateTime;
        private List<ObservationComponent>? _component;

        /// <summary>
        /// Observation ID - 可選 (0..1)
        /// </summary>
        [Optional]
        public new FhirId? Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("id", value);
            }
        }

        /// <summary>
        /// 識別符 - 可選多值 (0..*)
        /// </summary>
        [OptionalMultiple]
        public List<Identifier>? Identifier
        {
            get { return _identifier; }
            set
            {
                _identifier = value;
                OnPropertyChanged("identifier", value);
            }
        }

        /// <summary>
        /// 狀態 - 必填 (1..1)
        /// </summary>
        [Required]
        public FhirCode? Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("status", value);
            }
        }

        /// <summary>
        /// 觀察項目代碼 - 必填 (1..1)
        /// </summary>
        [Required]
        public CodeableConcept? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        /// <summary>
        /// 受檢者 - 可選 (0..1)
        /// </summary>
        [Optional]
        public ReferenceType? Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged("subject", value);
            }
        }

        /// <summary>
        /// 執行者 - 可選多值 (0..*)
        /// </summary>
        [OptionalMultiple]
        public List<ReferenceType>? Performer
        {
            get { return _performer; }
            set
            {
                _performer = value;
                OnPropertyChanged("performer", value);
            }
        }

        /// <summary>
        /// 觀察時間 - 可選 (0..1)
        /// </summary>
        [Optional]
        public FhirDateTime? EffectiveDateTime
        {
            get { return _effectiveDateTime; }
            set
            {
                _effectiveDateTime = value;
                OnPropertyChanged("effectiveDateTime", value);
            }
        }

        /// <summary>
        /// 組件 - 可選多值，最多 10 個 (0..10)
        /// </summary>
        [Multiple(0, 10)]
        public List<ObservationComponent>? Component
        {
            get { return _component; }
            set
            {
                _component = value;
                OnPropertyChanged("component", value);
            }
        }

        public ExampleObservation() : base() { }
        public ExampleObservation(JsonObject value) : base(value) { }
        public ExampleObservation(string value) : base(value) { }
    }

    /// <summary>
    /// 示例 Observation 組件
    /// </summary>
    public class ObservationComponent : ComplexType<ObservationComponent>
    {
        private CodeableConcept? _code;
        private Quantity? _valueQuantity;

        /// <summary>
        /// 組件代碼 - 必填 (1..1)
        /// </summary>
        [Required]
        public CodeableConcept? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        /// <summary>
        /// 數值 - 可選 (0..1)
        /// </summary>
        [Optional]
        public Quantity? ValueQuantity
        {
            get { return _valueQuantity; }
            set
            {
                _valueQuantity = value;
                OnPropertyChanged("valueQuantity", value);
            }
        }

        public ObservationComponent() : base() { }
        public ObservationComponent(JsonObject value) : base(value) { }
        public ObservationComponent(string value) : base(value) { }
    }
}
