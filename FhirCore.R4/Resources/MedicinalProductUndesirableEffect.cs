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
    /// FHIR R4 MedicinalProductUndesirableEffect 資源
    /// 
    /// <para>
    /// Describe the undesirable effects of the medicinal product.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var medicinalproductundesirableeffect = new MedicinalProductUndesirableEffect("medicinalproductundesirableeffect-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 MedicinalProductUndesirableEffect 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MedicinalProductUndesirableEffect : ResourceBase<R4Version>
    {
        private CodeableConcept? _classification;

        /// <summary>
        /// classification
        /// </summary>
        /// <remarks>
        /// <para>
        /// classification 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? classification
        {
            get => _classification;
            set
            {
                _classification = value;
                OnPropertyChanged(nameof(classification));
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

        private CodeableConcept? _frequencyofoccurrence;

        /// <summary>
        /// frequencyOfOccurrence
        /// </summary>
        /// <remarks>
        /// <para>
        /// frequencyOfOccurrence 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? frequencyOfOccurrence
        {
            get => _frequencyofoccurrence;
            set
            {
                _frequencyofoccurrence = value;
                OnPropertyChanged(nameof(frequencyOfOccurrence));
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

        private CodeableConcept? _symptomconditioneffect;

        /// <summary>
        /// symptomConditionEffect
        /// </summary>
        /// <remarks>
        /// <para>
        /// symptomConditionEffect 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? symptomConditionEffect
        {
            get => _symptomconditioneffect;
            set
            {
                _symptomconditioneffect = value;
                OnPropertyChanged(nameof(symptomConditionEffect));
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
        public override string ResourceType => "MedicinalProductUndesirableEffect";

        /// <summary>
        /// 建立新的 MedicinalProductUndesirableEffect 資源實例
        /// </summary>
        public MedicinalProductUndesirableEffect()
        {
        }

        /// <summary>
        /// 建立新的 MedicinalProductUndesirableEffect 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MedicinalProductUndesirableEffect(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MedicinalProductUndesirableEffect(Id: {Id})";
        }
    }
}
