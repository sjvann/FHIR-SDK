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
    /// FHIR R4 ResearchStudy 資源
    /// 
    /// <para>
    /// A process where a researcher or organization plans and then executes a series of steps intended to increase the field of healthcare-related knowledge.  This includes studies of safety, efficacy, comparative effectiveness and other information about medications, devices, therapies and other interventional and investigative techniques.  A ResearchStudy involves the gathering of information about human or animal subjects.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var researchstudy = new ResearchStudy("researchstudy-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ResearchStudy 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ResearchStudy : ResourceBase<R4Version>
    {
        private List<BackboneElement>? _arm;

        /// <summary>
        /// arm
        /// </summary>
        /// <remarks>
        /// <para>
        /// arm 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? arm
        {
            get => _arm;
            set
            {
                _arm = value;
                OnPropertyChanged(nameof(arm));
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

        private List<CodeableConcept>? _condition;

        /// <summary>
        /// condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(condition));
            }
        }

        private List<FhirString>? _contact;

        /// <summary>
        /// contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(contact));
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

        private FhirMarkdown? _description;

        /// <summary>
        /// description
        /// </summary>
        /// <remarks>
        /// <para>
        /// description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(description));
            }
        }

        private List<ReferenceType>? _enrollment;

        /// <summary>
        /// enrollment
        /// </summary>
        /// <remarks>
        /// <para>
        /// enrollment 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? enrollment
        {
            get => _enrollment;
            set
            {
                _enrollment = value;
                OnPropertyChanged(nameof(enrollment));
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

        private List<CodeableConcept>? _focus;

        /// <summary>
        /// focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// focus 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(focus));
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

        private List<CodeableConcept>? _keyword;

        /// <summary>
        /// keyword
        /// </summary>
        /// <remarks>
        /// <para>
        /// keyword 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? keyword
        {
            get => _keyword;
            set
            {
                _keyword = value;
                OnPropertyChanged(nameof(keyword));
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

        private List<CodeableConcept>? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(location));
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

        private List<BackboneElement>? _objective;

        /// <summary>
        /// objective
        /// </summary>
        /// <remarks>
        /// <para>
        /// objective 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? objective
        {
            get => _objective;
            set
            {
                _objective = value;
                OnPropertyChanged(nameof(objective));
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

        private CodeableConcept? _phase;

        /// <summary>
        /// phase
        /// </summary>
        /// <remarks>
        /// <para>
        /// phase 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? phase
        {
            get => _phase;
            set
            {
                _phase = value;
                OnPropertyChanged(nameof(phase));
            }
        }

        private CodeableConcept? _primarypurposetype;

        /// <summary>
        /// primaryPurposeType
        /// </summary>
        /// <remarks>
        /// <para>
        /// primaryPurposeType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? primaryPurposeType
        {
            get => _primarypurposetype;
            set
            {
                _primarypurposetype = value;
                OnPropertyChanged(nameof(primaryPurposeType));
            }
        }

        private ReferenceType? _principalinvestigator;

        /// <summary>
        /// principalInvestigator
        /// </summary>
        /// <remarks>
        /// <para>
        /// principalInvestigator 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? principalInvestigator
        {
            get => _principalinvestigator;
            set
            {
                _principalinvestigator = value;
                OnPropertyChanged(nameof(principalInvestigator));
            }
        }

        private List<ReferenceType>? _protocol;

        /// <summary>
        /// protocol
        /// </summary>
        /// <remarks>
        /// <para>
        /// protocol 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? protocol
        {
            get => _protocol;
            set
            {
                _protocol = value;
                OnPropertyChanged(nameof(protocol));
            }
        }

        private CodeableConcept? _reasonstopped;

        /// <summary>
        /// reasonStopped
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonStopped 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? reasonStopped
        {
            get => _reasonstopped;
            set
            {
                _reasonstopped = value;
                OnPropertyChanged(nameof(reasonStopped));
            }
        }

        private List<FhirString>? _relatedartifact;

        /// <summary>
        /// relatedArtifact
        /// </summary>
        /// <remarks>
        /// <para>
        /// relatedArtifact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? relatedArtifact
        {
            get => _relatedartifact;
            set
            {
                _relatedartifact = value;
                OnPropertyChanged(nameof(relatedArtifact));
            }
        }

        private List<ReferenceType>? _site;

        /// <summary>
        /// site
        /// </summary>
        /// <remarks>
        /// <para>
        /// site 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? site
        {
            get => _site;
            set
            {
                _site = value;
                OnPropertyChanged(nameof(site));
            }
        }

        private ReferenceType? _sponsor;

        /// <summary>
        /// sponsor
        /// </summary>
        /// <remarks>
        /// <para>
        /// sponsor 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? sponsor
        {
            get => _sponsor;
            set
            {
                _sponsor = value;
                OnPropertyChanged(nameof(sponsor));
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
        public override string ResourceType => "ResearchStudy";

        /// <summary>
        /// 建立新的 ResearchStudy 資源實例
        /// </summary>
        public ResearchStudy()
        {
        }

        /// <summary>
        /// 建立新的 ResearchStudy 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ResearchStudy(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ResearchStudy(Id: {Id})";
        }
    }
}
