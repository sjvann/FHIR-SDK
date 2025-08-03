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
    /// FHIR R5 ImmunizationEvaluation 資源
    /// 
    /// <para>
    /// ImmunizationEvaluation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var immunizationevaluation = new ImmunizationEvaluation("immunizationevaluation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ImmunizationEvaluation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImmunizationEvaluation : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _authority;
        private CodeableConcept? _targetdisease;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _immunizationevent;
        private CodeableConcept? _dosestatus;
        private List<CodeableConcept>? _dosestatusreason;
        private FhirMarkdown? _description;
        private FhirString? _series;
        private FhirString? _dosenumber;
        private FhirString? _seriesdoses;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImmunizationEvaluation";        /// <summary>
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
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Authority
        /// </summary>
        /// <remarks>
        /// <para>
        /// Authority 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Authority
        {
            get => _authority;
            set
            {
                _authority = value;
                OnPropertyChanged(nameof(Authority));
            }
        }        /// <summary>
        /// Targetdisease
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetdisease 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Targetdisease
        {
            get => _targetdisease;
            set
            {
                _targetdisease = value;
                OnPropertyChanged(nameof(Targetdisease));
            }
        }        /// <summary>
        /// Immunizationevent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Immunizationevent 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Immunizationevent
        {
            get => _immunizationevent;
            set
            {
                _immunizationevent = value;
                OnPropertyChanged(nameof(Immunizationevent));
            }
        }        /// <summary>
        /// Dosestatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosestatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Dosestatus
        {
            get => _dosestatus;
            set
            {
                _dosestatus = value;
                OnPropertyChanged(nameof(Dosestatus));
            }
        }        /// <summary>
        /// Dosestatusreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosestatusreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Dosestatusreason
        {
            get => _dosestatusreason;
            set
            {
                _dosestatusreason = value;
                OnPropertyChanged(nameof(Dosestatusreason));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Series
        /// </summary>
        /// <remarks>
        /// <para>
        /// Series 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Series
        {
            get => _series;
            set
            {
                _series = value;
                OnPropertyChanged(nameof(Series));
            }
        }        /// <summary>
        /// Dosenumber
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dosenumber 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Dosenumber
        {
            get => _dosenumber;
            set
            {
                _dosenumber = value;
                OnPropertyChanged(nameof(Dosenumber));
            }
        }        /// <summary>
        /// Seriesdoses
        /// </summary>
        /// <remarks>
        /// <para>
        /// Seriesdoses 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Seriesdoses
        {
            get => _seriesdoses;
            set
            {
                _seriesdoses = value;
                OnPropertyChanged(nameof(Seriesdoses));
            }
        }        /// <summary>
        /// 建立新的 ImmunizationEvaluation 資源實例
        /// </summary>
        public ImmunizationEvaluation()
        {
        }

        /// <summary>
        /// 建立新的 ImmunizationEvaluation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ImmunizationEvaluation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ImmunizationEvaluation(Id: {Id})";
        }
    }
}
