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
    /// FHIR R4 MedicinalProductContraindication 資源
    /// 
    /// <para>
    /// The clinical particulars - indications, contraindications etc. of a medicinal product, including for regulatory purposes.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductcontraindication = new MedicinalProductContraindication("medicinalproductcontraindication-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductContraindication 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductContraindication : ResourceBase<R4Version>
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

        private CodeableConcept? _disease;

        /// <summary>
        /// disease
        /// </summary>
        /// <remarks>
        /// <para>
        /// disease 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? disease
        {
            get => _disease;
            set
            {
                _disease = value;
                OnPropertyChanged(nameof(disease));
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

        private List<ReferenceType>? _therapeuticindication;

        /// <summary>
        /// therapeuticIndication
        /// </summary>
        /// <remarks>
        /// <para>
        /// therapeuticIndication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? therapeuticIndication
        {
            get => _therapeuticindication;
            set
            {
                _therapeuticindication = value;
                OnPropertyChanged(nameof(therapeuticIndication));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MedicinalProductContraindication";

        /// <summary>
        /// 建立新的 MedicinalProductContraindication 資源實例
        /// </summary>
        public MedicinalProductContraindication()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductContraindication 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductContraindication(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductContraindication(Id: {Id})";
        }
    }
}
