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
    /// FHIR R4 MedicinalProductIndication 資源
    /// 
    /// <para>
    /// Indication for the Medicinal Product.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductindication = new MedicinalProductIndication("medicinalproductindication-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductIndication 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductIndication : ResourceBase<R4Version>
    {
        private List<CodeableConcept>? _comorbidity;

        /// <summary>
        /// comorbidity
        /// </summary>
        /// <remarks>
        /// <para>
        /// comorbidity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? comorbidity
        {
            get => _comorbidity;
            set
            {
                _comorbidity = value;
                OnPropertyChanged(nameof(comorbidity));
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

        private CodeableConcept? _diseasestatus;

        /// <summary>
        /// diseaseStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// diseaseStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? diseaseStatus
        {
            get => _diseasestatus;
            set
            {
                _diseasestatus = value;
                OnPropertyChanged(nameof(diseaseStatus));
            }
        }

        private CodeableConcept? _diseasesymptomprocedure;

        /// <summary>
        /// diseaseSymptomProcedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// diseaseSymptomProcedure 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? diseaseSymptomProcedure
        {
            get => _diseasesymptomprocedure;
            set
            {
                _diseasesymptomprocedure = value;
                OnPropertyChanged(nameof(diseaseSymptomProcedure));
            }
        }

        private Quantity? _duration;

        /// <summary>
        /// duration
        /// </summary>
        /// <remarks>
        /// <para>
        /// duration 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(duration));
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

        private CodeableConcept? _intendedeffect;

        /// <summary>
        /// intendedEffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// intendedEffect 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? intendedEffect
        {
            get => _intendedeffect;
            set
            {
                _intendedeffect = value;
                OnPropertyChanged(nameof(intendedEffect));
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

        private List<BackboneElement>? _othertherapy;

        /// <summary>
        /// otherTherapy
        /// </summary>
        /// <remarks>
        /// <para>
        /// otherTherapy 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? otherTherapy
        {
            get => _othertherapy;
            set
            {
                _othertherapy = value;
                OnPropertyChanged(nameof(otherTherapy));
            }
        }

        private List<FhirString>? _population;

        /// <summary>
        /// population
        /// </summary>
        /// <remarks>
        /// <para>
        /// population 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? population
        {
            get => _population;
            set
            {
                _population = value;
                OnPropertyChanged(nameof(population));
            }
        }

        private List<ReferenceType>? _subject;

        /// <summary>
        /// subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// subject 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(subject));
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

        private List<ReferenceType>? _undesirableeffect;

        /// <summary>
        /// undesirableEffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// undesirableEffect 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? undesirableEffect
        {
            get => _undesirableeffect;
            set
            {
                _undesirableeffect = value;
                OnPropertyChanged(nameof(undesirableEffect));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicinalProductIndication";

        /// <summary>
        /// 建立新的 MedicinalProductIndication 資源實例
        /// </summary>
        public MedicinalProductIndication()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductIndication 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductIndication(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductIndication(Id: {Id})";
        }
    }
}
