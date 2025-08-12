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
    /// FHIR R4 Observation 資源
    /// 
    /// <para>
    /// Measurements and simple assertions made about a patient, device or other subject.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var observation = new Observation("observation-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Observation 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Observation : ResourceBase<R4Version>
    {
        private List<ReferenceType>? _basedon;

        /// <summary>
        /// basedOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// basedOn 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? basedOn
        {
            get => _basedon;
            set
            {
                _basedon = value;
                OnPropertyChanged(nameof(basedOn));
            }
        }

        private CodeableConcept? _bodysite;

        /// <summary>
        /// bodySite
        /// </summary>
        /// <remarks>
        /// <para>
        /// bodySite 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? bodySite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(bodySite));
            }
        }

        private List<CodeableConcept>? _category;

        /// <summary>
        /// category
        /// </summary>
        /// <remarks>
        /// <para>
        /// category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(category));
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

        private List<BackboneElement>? _component;

        /// <summary>
        /// component
        /// </summary>
        /// <remarks>
        /// <para>
        /// component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(component));
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

        private CodeableConcept? _dataabsentreason;

        /// <summary>
        /// dataAbsentReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// dataAbsentReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? dataAbsentReason
        {
            get => _dataabsentreason;
            set
            {
                _dataabsentreason = value;
                OnPropertyChanged(nameof(dataAbsentReason));
            }
        }

        private List<ReferenceType>? _derivedfrom;

        /// <summary>
        /// derivedFrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// derivedFrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? derivedFrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(derivedFrom));
            }
        }

        private ReferenceType? _device;

        /// <summary>
        /// device
        /// </summary>
        /// <remarks>
        /// <para>
        /// device 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? device
        {
            get => _device;
            set
            {
                _device = value;
                OnPropertyChanged(nameof(device));
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

        private List<ReferenceType>? _focus;

        /// <summary>
        /// focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(focus));
            }
        }

        private List<ReferenceType>? _hasmember;

        /// <summary>
        /// hasMember
        /// </summary>
        /// <remarks>
        /// <para>
        /// hasMember 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? hasMember
        {
            get => _hasmember;
            set
            {
                _hasmember = value;
                OnPropertyChanged(nameof(hasMember));
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

        private List<CodeableConcept>? _interpretation;

        /// <summary>
        /// interpretation
        /// </summary>
        /// <remarks>
        /// <para>
        /// interpretation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? interpretation
        {
            get => _interpretation;
            set
            {
                _interpretation = value;
                OnPropertyChanged(nameof(interpretation));
            }
        }

        private FhirInstant? _issued;

        /// <summary>
        /// issued
        /// </summary>
        /// <remarks>
        /// <para>
        /// issued 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInstant? issued
        {
            get => _issued;
            set
            {
                _issued = value;
                OnPropertyChanged(nameof(issued));
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

        private CodeableConcept? _method;

        /// <summary>
        /// method
        /// </summary>
        /// <remarks>
        /// <para>
        /// method 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? method
        {
            get => _method;
            set
            {
                _method = value;
                OnPropertyChanged(nameof(method));
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

        private List<ReferenceType>? _partof;

        /// <summary>
        /// partOf
        /// </summary>
        /// <remarks>
        /// <para>
        /// partOf 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? partOf
        {
            get => _partof;
            set
            {
                _partof = value;
                OnPropertyChanged(nameof(partOf));
            }
        }

        private List<ReferenceType>? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private List<BackboneElement>? _referencerange;

        /// <summary>
        /// referenceRange
        /// </summary>
        /// <remarks>
        /// <para>
        /// referenceRange 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? referenceRange
        {
            get => _referencerange;
            set
            {
                _referencerange = value;
                OnPropertyChanged(nameof(referenceRange));
            }
        }

        private ReferenceType? _specimen;

        /// <summary>
        /// specimen
        /// </summary>
        /// <remarks>
        /// <para>
        /// specimen 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? specimen
        {
            get => _specimen;
            set
            {
                _specimen = value;
                OnPropertyChanged(nameof(specimen));
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
        public override string ResourceType => "Observation";

        /// <summary>
        /// 建立新的 Observation 資源實例
        /// </summary>
        public Observation()
        {
        }

        /// <summary>
        /// 建立新的 Observation 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Observation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Observation(Id: {Id})";
        }
    }
}
