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
    /// FHIR R4 CarePlan 資源
    /// 
    /// <para>
    /// Describes the intention of how one or more practitioners intend to deliver care for a particular patient, group or community for a period of time, possibly limited to care for a specific condition or set of conditions.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var careplan = new CarePlan("careplan-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 CarePlan 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CarePlan : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _activity;

        /// <summary>
        /// activity
        /// </summary>
        /// <remarks>
        /// <para>
        /// activity 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? activity
        {
            get => _activity;
            set
            {
                _activity = value;
                OnPropertyChanged(nameof(activity));
            }
        }

        private List<ReferenceType>? _addresses;

        /// <summary>
        /// addresses
        /// </summary>
        /// <remarks>
        /// <para>
        /// addresses 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? addresses
        {
            get => _addresses;
            set
            {
                _addresses = value;
                OnPropertyChanged(nameof(addresses));
            }
        }

        private ReferenceType? _author;

        /// <summary>
        /// author
        /// </summary>
        /// <remarks>
        /// <para>
        /// author 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(author));
            }
        }

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

        private List<ReferenceType>? _careteam;

        /// <summary>
        /// careTeam
        /// </summary>
        /// <remarks>
        /// <para>
        /// careTeam 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? careTeam
        {
            get => _careteam;
            set
            {
                _careteam = value;
                OnPropertyChanged(nameof(careTeam));
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

        private List<ReferenceType>? _contributor;

        /// <summary>
        /// contributor
        /// </summary>
        /// <remarks>
        /// <para>
        /// contributor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? contributor
        {
            get => _contributor;
            set
            {
                _contributor = value;
                OnPropertyChanged(nameof(contributor));
            }
        }

        private FhirDateTime? _created;

        /// <summary>
        /// created
        /// </summary>
        /// <remarks>
        /// <para>
        /// created 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? created
        {
            get => _created;
            set
            {
                _created = value;
                OnPropertyChanged(nameof(created));
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

        private List<ReferenceType>? _goal;

        /// <summary>
        /// goal
        /// </summary>
        /// <remarks>
        /// <para>
        /// goal 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? goal
        {
            get => _goal;
            set
            {
                _goal = value;
                OnPropertyChanged(nameof(goal));
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

        private Period? _period;

        /// <summary>
        /// period
        /// </summary>
        /// <remarks>
        /// <para>
        /// period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(period));
            }
        }

        private List<ReferenceType>? _replaces;

        /// <summary>
        /// replaces
        /// </summary>
        /// <remarks>
        /// <para>
        /// replaces 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? replaces
        {
            get => _replaces;
            set
            {
                _replaces = value;
                OnPropertyChanged(nameof(replaces));
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

        private FhirString? _title;

        /// <summary>
        /// title
        /// </summary>
        /// <remarks>
        /// <para>
        /// title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(title));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CarePlan";

        /// <summary>
        /// 建立新的 CarePlan 資源實例
        /// </summary>
        public CarePlan()
        {
        }

        /// <summary>
        /// 建立新的 CarePlan 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CarePlan(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CarePlan(Id: {Id})";
        }
    }
}
