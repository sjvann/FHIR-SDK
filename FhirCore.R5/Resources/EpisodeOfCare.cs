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
    /// FHIR R5 EpisodeOfCare 資源
    /// 
    /// <para>
    /// EpisodeOfCare 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var episodeofcare = new EpisodeOfCare("episodeofcare-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 EpisodeOfCare 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class EpisodeOfCare : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<EpisodeOfCareStatusHistory>? _statushistory;
        private List<CodeableConcept>? _type;
        private List<EpisodeOfCareReason>? _reason;
        private List<EpisodeOfCareDiagnosis>? _diagnosis;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _managingorganization;
        private Period? _period;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _referralrequest;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _caremanager;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _careteam;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _account;
        private FhirCode? _status;
        private Period? _period;
        private CodeableConcept? _use;
        private List<CodeableReference>? _value;
        private List<CodeableReference>? _condition;
        private CodeableConcept? _use;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "EpisodeOfCare";        /// <summary>
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
        /// Statushistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// Statushistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EpisodeOfCareStatusHistory>? Statushistory
        {
            get => _statushistory;
            set
            {
                _statushistory = value;
                OnPropertyChanged(nameof(Statushistory));
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
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EpisodeOfCareReason>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Diagnosis
        /// </summary>
        /// <remarks>
        /// <para>
        /// Diagnosis 的詳細描述。
        /// </para>
        /// </remarks>
        public List<EpisodeOfCareDiagnosis>? Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
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
        /// Managingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Managingorganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(Managingorganization));
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
        /// Referralrequest
        /// </summary>
        /// <remarks>
        /// <para>
        /// Referralrequest 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Referralrequest
        {
            get => _referralrequest;
            set
            {
                _referralrequest = value;
                OnPropertyChanged(nameof(Referralrequest));
            }
        }        /// <summary>
        /// Caremanager
        /// </summary>
        /// <remarks>
        /// <para>
        /// Caremanager 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Caremanager
        {
            get => _caremanager;
            set
            {
                _caremanager = value;
                OnPropertyChanged(nameof(Caremanager));
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
        /// Account
        /// </summary>
        /// <remarks>
        /// <para>
        /// Account 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged(nameof(Account));
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
        /// Use
        /// </summary>
        /// <remarks>
        /// <para>
        /// Use 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(Use));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Use
        /// </summary>
        /// <remarks>
        /// <para>
        /// Use 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Use
        {
            get => _use;
            set
            {
                _use = value;
                OnPropertyChanged(nameof(Use));
            }
        }        /// <summary>
        /// 建立新的 EpisodeOfCare 資源實例
        /// </summary>
        public EpisodeOfCare()
        {
        }

        /// <summary>
        /// 建立新的 EpisodeOfCare 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public EpisodeOfCare(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"EpisodeOfCare(Id: {Id})";
        }
    }    /// <summary>
    /// EpisodeOfCareStatusHistory 背骨元素
    /// </summary>
    public class EpisodeOfCareStatusHistory
    {
        // TODO: 添加屬性實作
        
        public EpisodeOfCareStatusHistory() { }
    }    /// <summary>
    /// EpisodeOfCareReason 背骨元素
    /// </summary>
    public class EpisodeOfCareReason
    {
        // TODO: 添加屬性實作
        
        public EpisodeOfCareReason() { }
    }    /// <summary>
    /// EpisodeOfCareDiagnosis 背骨元素
    /// </summary>
    public class EpisodeOfCareDiagnosis
    {
        // TODO: 添加屬性實作
        
        public EpisodeOfCareDiagnosis() { }
    }
}
