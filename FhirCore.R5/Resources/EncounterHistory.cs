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
    /// FHIR R5 EncounterHistory 資源
    /// 
    /// <para>
    /// EncounterHistory 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var encounterhistory = new EncounterHistory("encounterhistory-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 EncounterHistory 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class EncounterHistory : ResourceBase<R5Version>
    {
        private Property
		private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private List<Identifier>? _identifier;
        private FhirCode? _status;
        private CodeableConcept? _class;
        private List<CodeableConcept>? _type;
        private List<CodeableReference>? _servicetype;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private CodeableConcept? _subjectstatus;
        private Period? _actualperiod;
        private FhirDateTime? _plannedstartdate;
        private FhirDateTime? _plannedenddate;
        private Duration? _length;
        private List<EncounterHistoryLocation>? _location;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private CodeableConcept? _form;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "EncounterHistory";        /// <summary>
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
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
        /// Class
        /// </summary>
        /// <remarks>
        /// <para>
        /// Class 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Class
        {
            get => _class;
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Servicetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Servicetype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Servicetype
        {
            get => _servicetype;
            set
            {
                _servicetype = value;
                OnPropertyChanged(nameof(Servicetype));
            }
        }        /// <summary>
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Subjectstatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjectstatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Subjectstatus
        {
            get => _subjectstatus;
            set
            {
                _subjectstatus = value;
                OnPropertyChanged(nameof(Subjectstatus));
            }
        }        /// <summary>
        /// Actualperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actualperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Actualperiod
        {
            get => _actualperiod;
            set
            {
                _actualperiod = value;
                OnPropertyChanged(nameof(Actualperiod));
            }
        }        /// <summary>
        /// Plannedstartdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Plannedstartdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Plannedstartdate
        {
            get => _plannedstartdate;
            set
            {
                _plannedstartdate = value;
                OnPropertyChanged(nameof(Plannedstartdate));
            }
        }        /// <summary>
        /// Plannedenddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Plannedenddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Plannedenddate
        {
            get => _plannedenddate;
            set
            {
                _plannedenddate = value;
                OnPropertyChanged(nameof(Plannedenddate));
            }
        }        /// <summary>
        /// Length
        /// </summary>
        /// <remarks>
        /// <para>
        /// Length 的詳細描述。
        /// </para>
        /// </remarks>
        public Duration? Length
        {
            get => _length;
            set
            {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EncounterHistoryLocation>? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }        /// <summary>
        /// Form
        /// </summary>
        /// <remarks>
        /// <para>
        /// Form 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }        /// <summary>
        /// 建立新的 EncounterHistory 資源實例
        /// </summary>
        public EncounterHistory()
        {
        }

        /// <summary>
        /// 建立新的 EncounterHistory 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public EncounterHistory(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"EncounterHistory(Id: {Id})";
        }
    }    /// <summary>
    /// EncounterHistoryLocation 背骨元素
    /// </summary>
    public class EncounterHistoryLocation
    {
        // TODO: 添加屬性實作
        
        public EncounterHistoryLocation() { }
    }
}
