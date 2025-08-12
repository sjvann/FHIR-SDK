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
    /// FHIR R5 CarePlan 資源
    /// 
    /// <para>
    /// CarePlan 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var careplan = new CarePlan("careplan-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 CarePlan 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CarePlan : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _basedon;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _replaces;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _partof;
        private FhirCode? _status;
        private FhirCode? _intent;
        private List<CodeableConcept>? _category;
        private FhirString? _title;
        private FhirString? _description;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _encounter;
        private Period? _period;
        private FhirDateTime? _created;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _custodian;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _contributor;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _careteam;
        private List<CodeableReference>? _addresses;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportinginfo;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _goal;
        private List<CarePlanActivity>? _activity;
        private List<Annotation>? _note;
        private List<CodeableReference>? _performedactivity;
        private List<Annotation>? _progress;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _plannedactivityreference;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CarePlan";        /// <summary>
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
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
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
        /// Replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// Replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(Replaces));
            }
        }        /// <summary>
        /// Partof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Partof 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Partof
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(Partof));
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
        /// Intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(Intent));
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
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
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
        /// Encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(Encounter));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Created
        /// </summary>
        /// <remarks>
        /// <para>
        /// Created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(Created));
            }
        }        /// <summary>
        /// Custodian
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custodian 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Custodian
        {
            get => _custodian;
            set
            {
                _custodian = value;
                OnPropertyChanged(nameof(Custodian));
            }
        }        /// <summary>
        /// Contributor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Contributor
        {
            get => _contributor;
            set
            {
                _contributor = value;
                OnPropertyChanged(nameof(Contributor));
            }
        }        /// <summary>
        /// Careteam
        /// </summary>
        /// <remarks>
        /// <para>
        /// Careteam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Careteam
        {
            get => _careteam;
            set
            {
                _careteam = value;
                OnPropertyChanged(nameof(Careteam));
            }
        }        /// <summary>
        /// Addresses
        /// </summary>
        /// <remarks>
        /// <para>
        /// Addresses 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Addresses
        {
            get => _addresses;
            set
            {
                _addresses = value;
                OnPropertyChanged(nameof(Addresses));
            }
        }        /// <summary>
        /// Supportinginfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportinginfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportinginfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(Supportinginfo));
            }
        }        /// <summary>
        /// Goal
        /// </summary>
        /// <remarks>
        /// <para>
        /// Goal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(Goal));
            }
        }        /// <summary>
        /// Activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Activity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CarePlanActivity>? Activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(Activity));
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
        /// Performedactivity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performedactivity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Performedactivity
        {
            get => _performedactivity;
            set
            {
                _performedactivity = value;
                OnPropertyChanged(nameof(Performedactivity));
            }
        }        /// <summary>
        /// Progress
        /// </summary>
        /// <remarks>
        /// <para>
        /// Progress 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Progress
        {
            get => _progress;
            set
            {
                _progress = value;
                OnPropertyChanged(nameof(Progress));
            }
        }        /// <summary>
        /// Plannedactivityreference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Plannedactivityreference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Plannedactivityreference
        {
            get => _plannedactivityreference;
            set
            {
                _plannedactivityreference = value;
                OnPropertyChanged(nameof(Plannedactivityreference));
            }
        }        /// <summary>
        /// 建立新的 CarePlan 資源實例
        /// </summary>
        public CarePlan()
        {
        }

        /// <summary>
        /// 建立新的 CarePlan 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CarePlan(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CarePlan(Id: {Id})";
        }
    }    /// <summary>
    /// CarePlanActivity 背骨元素
    /// </summary>
    public class CarePlanActivity
    {
        // TODO: 添加屬性實作
        
        public CarePlanActivity() { }
    }
}
