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
    /// FHIR R4 ClinicalImpression 資源
    /// 
    /// <para>
    /// A record of a clinical assessment performed to determine what problem(s) may affect the patient and before planning the treatments or management strategies that are best to manage a patient's condition. Assessments are often 1:1 with a clinical consultation / encounter,  but this varies greatly depending on the clinical workflow. This resource is called "ClinicalImpression" rather than "ClinicalAssessment" to avoid confusion with the recording of assessment tools such as Apgar score.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var clinicalimpression = new ClinicalImpression("clinicalimpression-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ClinicalImpression 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ClinicalImpression : ResourceBase<R4Version>
    {
        private ReferenceType? _assessor;

        /// <summary>
        /// assessor
        /// </summary>
        /// <remarks>
        /// <para>
        /// assessor 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? assessor
        {
            get => _assessor;
            set
            {
                _assessor = value;
                OnPropertyChanged(nameof(assessor));
            }
        }

        private CodeableConcept? _code;

        /// <summary>
        /// code
        /// </summary>
        /// <remarks>
        /// <para>
        /// code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(code));
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

        private ReferenceType? _encounter;

        /// <summary>
        /// encounter
        /// </summary>
        /// <remarks>
        /// <para>
        /// encounter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? encounter
        {
            get => _encounter;
            set
            {
                _encounter = value;
                OnPropertyChanged(nameof(encounter));
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

        private List<BackboneElement>? _finding;

        /// <summary>
        /// finding
        /// </summary>
        /// <remarks>
        /// <para>
        /// finding 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? finding
        {
            get => _finding;
            set
            {
                _finding = value;
                OnPropertyChanged(nameof(finding));
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

        private List<BackboneElement>? _investigation;

        /// <summary>
        /// investigation
        /// </summary>
        /// <remarks>
        /// <para>
        /// investigation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? investigation
        {
            get => _investigation;
            set
            {
                _investigation = value;
                OnPropertyChanged(nameof(investigation));
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

        private List<Annotation>? _note;

        /// <summary>
        /// note
        /// </summary>
        /// <remarks>
        /// <para>
        /// note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(note));
            }
        }

        private ReferenceType? _previous;

        /// <summary>
        /// previous
        /// </summary>
        /// <remarks>
        /// <para>
        /// previous 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? previous
        {
            get => _previous;
            set
            {
                _previous = value;
                OnPropertyChanged(nameof(previous));
            }
        }

        private List<ReferenceType>? _problem;

        /// <summary>
        /// problem
        /// </summary>
        /// <remarks>
        /// <para>
        /// problem 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? problem
        {
            get => _problem;
            set
            {
                _problem = value;
                OnPropertyChanged(nameof(problem));
            }
        }

        private List<CodeableConcept>? _prognosiscodeableconcept;

        /// <summary>
        /// prognosisCodeableConcept
        /// </summary>
        /// <remarks>
        /// <para>
        /// prognosisCodeableConcept 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? prognosisCodeableConcept
        {
            get => _prognosiscodeableconcept;
            set
            {
                _prognosiscodeableconcept = value;
                OnPropertyChanged(nameof(prognosisCodeableConcept));
            }
        }

        private List<ReferenceType>? _prognosisreference;

        /// <summary>
        /// prognosisReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// prognosisReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? prognosisReference
        {
            get => _prognosisreference;
            set
            {
                _prognosisreference = value;
                OnPropertyChanged(nameof(prognosisReference));
            }
        }

        private List<FhirUri>? _protocol;

        /// <summary>
        /// protocol
        /// </summary>
        /// <remarks>
        /// <para>
        /// protocol 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? protocol
        {
            get => _protocol;
            set
            {
                _protocol = value;
                OnPropertyChanged(nameof(protocol));
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

        private CodeableConcept? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? statusReason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(statusReason));
            }
        }

        private ReferenceType? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
            }
        }

        private FhirString? _summary;

        /// <summary>
        /// summary
        /// </summary>
        /// <remarks>
        /// <para>
        /// summary 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? summary
        {
            get => _summary;
            set
            {
                _summary = value;
                OnPropertyChanged(nameof(summary));
            }
        }

        private List<ReferenceType>? _supportinginfo;

        /// <summary>
        /// supportingInfo
        /// </summary>
        /// <remarks>
        /// <para>
        /// supportingInfo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? supportingInfo
        {
            get => _supportinginfo;
            set
            {
                _supportinginfo = value;
                OnPropertyChanged(nameof(supportingInfo));
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
        public override string ResourceType => "ClinicalImpression";

        /// <summary>
        /// 建立新的 ClinicalImpression 資源實例
        /// </summary>
        public ClinicalImpression()
        {
        }

        /// <summary>
        /// 建立新的 ClinicalImpression 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ClinicalImpression(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ClinicalImpression(Id: {Id})";
        }
    }
}
