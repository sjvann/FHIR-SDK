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
    /// FHIR R4 RelatedPerson 資源
    /// 
    /// <para>
    /// Information about a person that is involved in the care for a patient, but who is not the target of healthcare, nor has a formal responsibility in the care process.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var relatedperson = new RelatedPerson("relatedperson-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 RelatedPerson 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class RelatedPerson : ResourceBase<R4Version>
    {
        private FhirBoolean? _active;

        /// <summary>
        /// active
        /// </summary>
        /// <remarks>
        /// <para>
        /// active 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? active
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged(nameof(active));
            }
        }

        private List<Address>? _address;

        /// <summary>
        /// address
        /// </summary>
        /// <remarks>
        /// <para>
        /// address 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Address>? address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged(nameof(address));
            }
        }

        private FhirDate? _birthdate;

        /// <summary>
        /// birthDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// birthDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? birthDate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(birthDate));
            }
        }

        private List<BackboneElement>? _communication;

        /// <summary>
        /// communication
        /// </summary>
        /// <remarks>
        /// <para>
        /// communication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? communication
        {
            get => _communication;
            set
            {
                _communication = value;
                OnPropertyChanged(nameof(communication));
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

        private FhirCode? _gender;

        /// <summary>
        /// gender
        /// </summary>
        /// <remarks>
        /// <para>
        /// gender 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(gender));
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

        private List<HumanName>? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public List<HumanName>? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
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

        private List<Attachment>? _photo;

        /// <summary>
        /// photo
        /// </summary>
        /// <remarks>
        /// <para>
        /// photo 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Attachment>? photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(photo));
            }
        }

        private List<CodeableConcept>? _relationship;

        /// <summary>
        /// relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(relationship));
            }
        }

        private List<ContactPoint>? _telecom;

        /// <summary>
        /// telecom
        /// </summary>
        /// <remarks>
        /// <para>
        /// telecom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(telecom));
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
        public override string ResourceType => "RelatedPerson";

        /// <summary>
        /// 建立新的 RelatedPerson 資源實例
        /// </summary>
        public RelatedPerson()
        {
        }

        /// <summary>
        /// 建立新的 RelatedPerson 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public RelatedPerson(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"RelatedPerson(Id: {Id})";
        }
    }
}
