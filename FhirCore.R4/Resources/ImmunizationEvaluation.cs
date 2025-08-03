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
    /// FHIR R4 ImmunizationEvaluation 資源
    /// 
    /// <para>
    /// Describes a comparison of an immunization event against published recommendations to determine if the administration is "valid" in relation to those  recommendations.
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
    /// R4 版本的 ImmunizationEvaluation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ImmunizationEvaluation : ResourceBase<R4Version>
    {
        private ReferenceType? _authority;

        /// <summary>
        /// authority
        /// </summary>
        /// <remarks>
        /// <para>
        /// authority 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? authority
        {
            get => _authority;
            set
            {
                _authority = value;
                OnPropertyChanged(nameof(authority));
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

        private FhirDateTime? _date;

        /// <summary>
        /// date
        /// </summary>
        /// <remarks>
        /// <para>
        /// date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(date));
            }
        }

        private FhirString? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private CodeableConcept? _dosestatus;

        /// <summary>
        /// doseStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// doseStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? doseStatus
        {
            get => _dosestatus;
            set
            {
                _dosestatus = value;
                OnPropertyChanged(nameof(doseStatus));
            }
        }

        private List<CodeableConcept>? _dosestatusreason;

        /// <summary>
        /// doseStatusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// doseStatusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? doseStatusReason
        {
            get => _dosestatusreason;
            set
            {
                _dosestatusreason = value;
                OnPropertyChanged(nameof(doseStatusReason));
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

        private ReferenceType? _immunizationevent;

        /// <summary>
        /// immunizationEvent
        /// </summary>
        /// <remarks>
        /// <para>
        /// immunizationEvent 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? immunizationEvent
        {
            get => _immunizationevent;
            set
            {
                _immunizationevent = value;
                OnPropertyChanged(nameof(immunizationEvent));
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

        private ReferenceType? _patient;

        /// <summary>
        /// patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// patient 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(patient));
            }
        }

        private FhirString? _series;

        /// <summary>
        /// series
        /// </summary>
        /// <remarks>
        /// <para>
        /// series 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? series
        {
            get => _series;
            set
            {
                _series = value;
                OnPropertyChanged(nameof(series));
            }
        }

        private FhirCode? _status;

        /// <summary>
        /// status
        /// </summary>
        /// <remarks>
        /// <para>
        /// status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(status));
            }
        }

        private CodeableConcept? _targetdisease;

        /// <summary>
        /// targetDisease
        /// </summary>
        /// <remarks>
        /// <para>
        /// targetDisease 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? targetDisease
        {
            get => _targetdisease;
            set
            {
                _targetdisease = value;
                OnPropertyChanged(nameof(targetDisease));
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

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ImmunizationEvaluation";

        /// <summary>
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
