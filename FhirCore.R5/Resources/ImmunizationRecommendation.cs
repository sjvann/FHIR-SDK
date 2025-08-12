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
    /// FHIR R5 ImmunizationRecommendation 資源
    /// 
    /// <para>
    /// ImmunizationRecommendation 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var immunizationrecommendation = new ImmunizationRecommendation("immunizationrecommendation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ImmunizationRecommendation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImmunizationRecommendation : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _authority;
        private List<ImmunizationRecommendationRecommendation>? _recommendation;
        private CodeableConcept? _code;
        private FhirDateTime? _value;
        private List<CodeableConcept>? _vaccinecode;
        private List<CodeableConcept>? _targetdisease;
        private List<CodeableConcept>? _contraindicatedvaccinecode;
        private CodeableConcept? _forecaststatus;
        private List<CodeableConcept>? _forecastreason;
        private List<ImmunizationRecommendationRecommendationDateCriterion>? _datecriterion;
        private FhirMarkdown? _description;
        private FhirString? _series;
        private FhirString? _dosenumber;
        private FhirString? _seriesdoses;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportingimmunization;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supportingpatientinformation;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImmunizationRecommendation";        /// <summary>
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
        /// Recommendation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Recommendation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImmunizationRecommendationRecommendation>? Recommendation
        {
            get => _recommendation;
            set
            {
                _recommendation = value;
                OnPropertyChanged(nameof(Recommendation));
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
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Vaccinecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Vaccinecode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Vaccinecode
        {
            get => _vaccinecode;
            set
            {
                _vaccinecode = value;
                OnPropertyChanged(nameof(Vaccinecode));
            }
        }        /// <summary>
        /// Targetdisease
        /// </summary>
        /// <remarks>
        /// <para>
        /// Targetdisease 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Targetdisease
        {
            get => _targetdisease;
            set
            {
                _targetdisease = value;
                OnPropertyChanged(nameof(Targetdisease));
            }
        }        /// <summary>
        /// Contraindicatedvaccinecode
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contraindicatedvaccinecode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Contraindicatedvaccinecode
        {
            get => _contraindicatedvaccinecode;
            set
            {
                _contraindicatedvaccinecode = value;
                OnPropertyChanged(nameof(Contraindicatedvaccinecode));
            }
        }        /// <summary>
        /// Forecaststatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// Forecaststatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Forecaststatus
        {
            get => _forecaststatus;
            set
            {
                _forecaststatus = value;
                OnPropertyChanged(nameof(Forecaststatus));
            }
        }        /// <summary>
        /// Forecastreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Forecastreason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Forecastreason
        {
            get => _forecastreason;
            set
            {
                _forecastreason = value;
                OnPropertyChanged(nameof(Forecastreason));
            }
        }        /// <summary>
        /// Datecriterion
        /// </summary>
        /// <remarks>
        /// <para>
        /// Datecriterion 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ImmunizationRecommendationRecommendationDateCriterion>? Datecriterion
        {
            get => _datecriterion;
            set
            {
                _datecriterion = value;
                OnPropertyChanged(nameof(Datecriterion));
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
        /// Supportingimmunization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportingimmunization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportingimmunization
        {
            get => _supportingimmunization;
            set
            {
                _supportingimmunization = value;
                OnPropertyChanged(nameof(Supportingimmunization));
            }
        }        /// <summary>
        /// Supportingpatientinformation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supportingpatientinformation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supportingpatientinformation
        {
            get => _supportingpatientinformation;
            set
            {
                _supportingpatientinformation = value;
                OnPropertyChanged(nameof(Supportingpatientinformation));
            }
        }        /// <summary>
        /// 建立新的 ImmunizationRecommendation 資源實例
        /// </summary>
        public ImmunizationRecommendation()
        {
        }

        /// <summary>
        /// 建立新的 ImmunizationRecommendation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ImmunizationRecommendation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ImmunizationRecommendation(Id: {Id})";
        }
    }    /// <summary>
    /// ImmunizationRecommendationRecommendationDateCriterion 背骨元素
    /// </summary>
    public class ImmunizationRecommendationRecommendationDateCriterion
    {
        // TODO: 添加屬性實作
        
        public ImmunizationRecommendationRecommendationDateCriterion() { }
    }    /// <summary>
    /// ImmunizationRecommendationRecommendation 背骨元素
    /// </summary>
    public class ImmunizationRecommendationRecommendation
    {
        // TODO: 添加屬性實作
        
        public ImmunizationRecommendationRecommendation() { }
    }
}
