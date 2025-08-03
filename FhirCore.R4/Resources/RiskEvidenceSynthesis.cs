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
    /// FHIR R4 RiskEvidenceSynthesis 資源
    /// 
    /// <para>
    /// The RiskEvidenceSynthesis resource describes the likelihood of an outcome in a population plus exposure state where the risk estimate is derived from a combination of research studies.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var riskevidencesynthesis = new RiskEvidenceSynthesis("riskevidencesynthesis-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 RiskEvidenceSynthesis 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class RiskEvidenceSynthesis : ResourceBase<R4Version>
    {
        private FhirDate? _approvaldate;

        /// <summary>
        /// approvalDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// approvalDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? approvalDate
        {
            get => _approvaldate;
            set
            {
                _approvaldate = value;
                OnPropertyChanged(nameof(approvalDate));
            }
        }

        private List<FhirString>? _author;

        /// <summary>
        /// author
        /// </summary>
        /// <remarks>
        /// <para>
        /// author 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? author
        {
            get => _author;
            set
            {
                _author = value;
                OnPropertyChanged(nameof(author));
            }
        }

        private List<BackboneElement>? _certainty;

        /// <summary>
        /// certainty
        /// </summary>
        /// <remarks>
        /// <para>
        /// certainty 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? certainty
        {
            get => _certainty;
            set
            {
                _certainty = value;
                OnPropertyChanged(nameof(certainty));
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

        private FhirMarkdown? _copyright;

        /// <summary>
        /// copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(copyright));
            }
        }

        private FhirDateTime? _date;

        /// <summary>
        /// date
        /// </summary>
        /// <remarks>
        /// <para>
        /// date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(date));
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

        private List<FhirString>? _editor;

        /// <summary>
        /// editor
        /// </summary>
        /// <remarks>
        /// <para>
        /// editor 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? editor
        {
            get => _editor;
            set
            {
                _editor = value;
                OnPropertyChanged(nameof(editor));
            }
        }

        private Period? _effectiveperiod;

        /// <summary>
        /// effectivePeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// effectivePeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? effectivePeriod
        {
            get => _effectiveperiod;
            set
            {
                _effectiveperiod = value;
                OnPropertyChanged(nameof(effectivePeriod));
            }
        }

        private List<FhirString>? _endorser;

        /// <summary>
        /// endorser
        /// </summary>
        /// <remarks>
        /// <para>
        /// endorser 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? endorser
        {
            get => _endorser;
            set
            {
                _endorser = value;
                OnPropertyChanged(nameof(endorser));
            }
        }

        private ReferenceType? _exposure;

        /// <summary>
        /// exposure
        /// </summary>
        /// <remarks>
        /// <para>
        /// exposure 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? exposure
        {
            get => _exposure;
            set
            {
                _exposure = value;
                OnPropertyChanged(nameof(exposure));
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

        private List<CodeableConcept>? _jurisdiction;

        /// <summary>
        /// jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(jurisdiction));
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

        private FhirDate? _lastreviewdate;

        /// <summary>
        /// lastReviewDate
        /// </summary>
        /// <remarks>
        /// <para>
        /// lastReviewDate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? lastReviewDate
        {
            get => _lastreviewdate;
            set
            {
                _lastreviewdate = value;
                OnPropertyChanged(nameof(lastReviewDate));
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

        private FhirString? _name;

        /// <summary>
        /// name
        /// </summary>
        /// <remarks>
        /// <para>
        /// name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(name));
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

        private ReferenceType? _outcome;

        /// <summary>
        /// outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(outcome));
            }
        }

        private ReferenceType? _population;

        /// <summary>
        /// population
        /// </summary>
        /// <remarks>
        /// <para>
        /// population 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? population
        {
            get => _population;
            set
            {
                _population = value;
                OnPropertyChanged(nameof(population));
            }
        }

        private FhirString? _publisher;

        /// <summary>
        /// publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(publisher));
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

        private List<FhirString>? _reviewer;

        /// <summary>
        /// reviewer
        /// </summary>
        /// <remarks>
        /// <para>
        /// reviewer 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? reviewer
        {
            get => _reviewer;
            set
            {
                _reviewer = value;
                OnPropertyChanged(nameof(reviewer));
            }
        }

        private BackboneElement? _riskestimate;

        /// <summary>
        /// riskEstimate
        /// </summary>
        /// <remarks>
        /// <para>
        /// riskEstimate 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? riskEstimate
        {
            get => _riskestimate;
            set
            {
                _riskestimate = value;
                OnPropertyChanged(nameof(riskEstimate));
            }
        }

        private BackboneElement? _samplesize;

        /// <summary>
        /// sampleSize
        /// </summary>
        /// <remarks>
        /// <para>
        /// sampleSize 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? sampleSize
        {
            get => _samplesize;
            set
            {
                _samplesize = value;
                OnPropertyChanged(nameof(sampleSize));
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

        private CodeableConcept? _studytype;

        /// <summary>
        /// studyType
        /// </summary>
        /// <remarks>
        /// <para>
        /// studyType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? studyType
        {
            get => _studytype;
            set
            {
                _studytype = value;
                OnPropertyChanged(nameof(studyType));
            }
        }

        private CodeableConcept? _synthesistype;

        /// <summary>
        /// synthesisType
        /// </summary>
        /// <remarks>
        /// <para>
        /// synthesisType 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? synthesisType
        {
            get => _synthesistype;
            set
            {
                _synthesistype = value;
                OnPropertyChanged(nameof(synthesisType));
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

        private List<CodeableConcept>? _topic;

        /// <summary>
        /// topic
        /// </summary>
        /// <remarks>
        /// <para>
        /// topic 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? topic
        {
            get => _topic;
            set
            {
                _topic = value;
                OnPropertyChanged(nameof(topic));
            }
        }

        private FhirUri? _url;

        /// <summary>
        /// url
        /// </summary>
        /// <remarks>
        /// <para>
        /// url 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(url));
            }
        }

        private List<FhirString>? _usecontext;

        /// <summary>
        /// useContext
        /// </summary>
        /// <remarks>
        /// <para>
        /// useContext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? useContext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(useContext));
            }
        }

        private FhirString? _version;

        /// <summary>
        /// version
        /// </summary>
        /// <remarks>
        /// <para>
        /// version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(version));
            }
        }

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "RiskEvidenceSynthesis";

        /// <summary>
        /// 建立新的 RiskEvidenceSynthesis 資源實例
        /// </summary>
        public RiskEvidenceSynthesis()
        {
        }

        /// <summary>
        /// 建立新的 RiskEvidenceSynthesis 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public RiskEvidenceSynthesis(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"RiskEvidenceSynthesis(Id: {Id})";
        }
    }
}
