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
    /// FHIR R4 AllergyIntolerance 資源
    /// 
    /// <para>
    /// Risk of harmful or undesirable, physiological response which is unique to an individual and associated with exposure to a substance.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var allergyintolerance = new AllergyIntolerance("allergyintolerance-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 AllergyIntolerance 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class AllergyIntolerance : ResourceBase<R4Version>
    {
        private ReferenceType? _asserter;

        /// <summary>
        /// asserter
        /// </summary>
        /// <remarks>
        /// <para>
        /// asserter 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? asserter
        {
            get => _asserter;
            set
            {
                _asserter = value;
                OnPropertyChanged(nameof(asserter));
            }
        }

        private List<FhirCode>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
            }
        }

        private CodeableConcept? _clinicalstatus;

        /// <summary>
        /// clinicalStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// clinicalStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? clinicalStatus
        {
            get => _clinicalstatus;
            set
            {
                _clinicalstatus = value;
                OnPropertyChanged(nameof(clinicalStatus));
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

        private FhirCode? _criticality;

        /// <summary>
        /// criticality
        /// </summary>
        /// <remarks>
        /// <para>
        /// criticality 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? criticality
        {
            get => _criticality;
            set
            {
                _criticality = value;
                OnPropertyChanged(nameof(criticality));
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

        private FhirDateTime? _lastoccurrence;

        /// <summary>
        /// lastOccurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// lastOccurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? lastOccurrence
        {
            get => _lastoccurrence;
            set
            {
                _lastoccurrence = value;
                OnPropertyChanged(nameof(lastOccurrence));
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

        private List<BackboneElement>? _reaction;

        /// <summary>
        /// reaction
        /// </summary>
        /// <remarks>
        /// <para>
        /// reaction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? reaction
        {
            get => _reaction;
            set
            {
                _reaction = value;
                OnPropertyChanged(nameof(reaction));
            }
        }

        private FhirDateTime? _recordeddate;

        /// <summary>
        /// recordedDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// recordedDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? recordedDate
        {
            get => _recordeddate;
            set
            {
                _recordeddate = value;
                OnPropertyChanged(nameof(recordedDate));
            }
        }

        private ReferenceType? _recorder;

        /// <summary>
        /// recorder
        /// </summary>
        /// <remarks>
        /// <para>
        /// recorder 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? recorder
        {
            get => _recorder;
            set
            {
                _recorder = value;
                OnPropertyChanged(nameof(recorder));
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

        private FhirCode? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
            }
        }

        private CodeableConcept? _verificationstatus;

        /// <summary>
        /// verificationStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// verificationStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? verificationStatus
        {
            get => _verificationstatus;
            set
            {
                _verificationstatus = value;
                OnPropertyChanged(nameof(verificationStatus));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "AllergyIntolerance";

        /// <summary>
        /// 建立新的 AllergyIntolerance 資源實例
        /// </summary>
        public AllergyIntolerance()
        {
        }

        /// <summary>
        /// 建立新的 AllergyIntolerance 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public AllergyIntolerance(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"AllergyIntolerance(Id: {Id})";
        }
    }
}
