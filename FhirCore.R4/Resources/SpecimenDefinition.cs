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
    /// FHIR R4 SpecimenDefinition 資源
    /// 
    /// <para>
    /// A kind of specimen with associated set of requirements.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var specimendefinition = new SpecimenDefinition("specimendefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 SpecimenDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class SpecimenDefinition : ResourceBase<R4Version>
    {
        private List<CodeableConcept>? _collection;

        /// <summary>
        /// collection
        /// </summary>
        /// <remarks>
        /// <para>
        /// collection 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? collection
        {
            get => _collection;
            set
            {
                _collection = value;
                OnPropertyChanged(nameof(collection));
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

        private Identifier? _identifier;

        /// <summary>
        /// identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? identifier
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

        private List<CodeableConcept>? _patientpreparation;

        /// <summary>
        /// patientPreparation
        /// </summary>
        /// <remarks>
        /// <para>
        /// patientPreparation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? patientPreparation
        {
            get => _patientpreparation;
            set
            {
                _patientpreparation = value;
                OnPropertyChanged(nameof(patientPreparation));
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

        private FhirString? _timeaspect;

        /// <summary>
        /// timeAspect
        /// </summary>
        /// <remarks>
        /// <para>
        /// timeAspect 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? timeAspect
        {
            get => _timeaspect;
            set
            {
                _timeaspect = value;
                OnPropertyChanged(nameof(timeAspect));
            }
        }

        private CodeableConcept? _typecollected;

        /// <summary>
        /// typeCollected
        /// </summary>
        /// <remarks>
        /// <para>
        /// typeCollected 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? typeCollected
        {
            get => _typecollected;
            set
            {
                _typecollected = value;
                OnPropertyChanged(nameof(typeCollected));
            }
        }

        private List<BackboneElement>? _typetested;

        /// <summary>
        /// typeTested
        /// </summary>
        /// <remarks>
        /// <para>
        /// typeTested 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? typeTested
        {
            get => _typetested;
            set
            {
                _typetested = value;
                OnPropertyChanged(nameof(typeTested));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "SpecimenDefinition";

        /// <summary>
        /// 建立新的 SpecimenDefinition 資源實例
        /// </summary>
        public SpecimenDefinition()
        {
        }

        /// <summary>
        /// 建立新的 SpecimenDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public SpecimenDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"SpecimenDefinition(Id: {Id})";
        }
    }
}
