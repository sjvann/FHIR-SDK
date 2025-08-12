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
    /// FHIR R4 NutritionOrder 資源
    /// 
    /// <para>
    /// A request to supply a diet, formula feeding (enteral) or oral nutritional supplement to a patient/resident.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var nutritionorder = new NutritionOrder("nutritionorder-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 NutritionOrder 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class NutritionOrder : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _allergyintolerance;

        /// <summary>
        /// allergyIntolerance
        /// </summary>
        /// <remarks>
        /// <para>
        /// allergyIntolerance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? allergyIntolerance
        {
            get => _allergyintolerance;
            set
            {
                _allergyintolerance = value;
                OnPropertyChanged(nameof(allergyIntolerance));
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

        private FhirDateTime? _datetime;

        /// <summary>
        /// dateTime
        /// </summary>
        /// <remarks>
        /// <para>
        /// dateTime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? dateTime
        {
            get => _datetime;
            set
            {
                _datetime = value;
                OnPropertyChanged(nameof(dateTime));
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

        private BackboneElement? _enteralformula;

        /// <summary>
        /// enteralFormula
        /// </summary>
        /// <remarks>
        /// <para>
        /// enteralFormula 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? enteralFormula
        {
            get => _enteralformula;
            set
            {
                _enteralformula = value;
                OnPropertyChanged(nameof(enteralFormula));
            }
        }

        private List<CodeableConcept>? _excludefoodmodifier;

        /// <summary>
        /// excludeFoodModifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// excludeFoodModifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? excludeFoodModifier
        {
            get => _excludefoodmodifier;
            set
            {
                _excludefoodmodifier = value;
                OnPropertyChanged(nameof(excludeFoodModifier));
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

        private List<CodeableConcept>? _foodpreferencemodifier;

        /// <summary>
        /// foodPreferenceModifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// foodPreferenceModifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? foodPreferenceModifier
        {
            get => _foodpreferencemodifier;
            set
            {
                _foodpreferencemodifier = value;
                OnPropertyChanged(nameof(foodPreferenceModifier));
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

        private List<FhirUri>? _instantiates;

        /// <summary>
        /// instantiates
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiates 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? instantiates
        {
            get => _instantiates;
            set
            {
                _instantiates = value;
                OnPropertyChanged(nameof(instantiates));
            }
        }

        private List<FhirCanonical>? _instantiatescanonical;

        /// <summary>
        /// instantiatesCanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesCanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? instantiatesCanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(instantiatesCanonical));
            }
        }

        private List<FhirUri>? _instantiatesuri;

        /// <summary>
        /// instantiatesUri
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesUri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? instantiatesUri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(instantiatesUri));
            }
        }

        private FhirCode? _intent;

        /// <summary>
        /// intent
        /// </summary>
        /// <remarks>
        /// <para>
        /// intent 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? intent
        {
            get => _intent;
            set
            {
                _intent = value;
                OnPropertyChanged(nameof(intent));
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

        private BackboneElement? _oraldiet;

        /// <summary>
        /// oralDiet
        /// </summary>
        /// <remarks>
        /// <para>
        /// oralDiet 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? oralDiet
        {
            get => _oraldiet;
            set
            {
                _oraldiet = value;
                OnPropertyChanged(nameof(oralDiet));
            }
        }

        private ReferenceType? _orderer;

        /// <summary>
        /// orderer
        /// </summary>
        /// <remarks>
        /// <para>
        /// orderer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? orderer
        {
            get => _orderer;
            set
            {
                _orderer = value;
                OnPropertyChanged(nameof(orderer));
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

        private List<BackboneElement>? _supplement;

        /// <summary>
        /// supplement
        /// </summary>
        /// <remarks>
        /// <para>
        /// supplement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? supplement
        {
            get => _supplement;
            set
            {
                _supplement = value;
                OnPropertyChanged(nameof(supplement));
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
        public override string ResourceType => "NutritionOrder";

        /// <summary>
        /// 建立新的 NutritionOrder 資源實例
        /// </summary>
        public NutritionOrder()
        {
        }

        /// <summary>
        /// 建立新的 NutritionOrder 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public NutritionOrder(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"NutritionOrder(Id: {Id})";
        }
    }
}
