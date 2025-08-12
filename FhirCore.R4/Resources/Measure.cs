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
    /// FHIR R4 Measure 資源
    /// 
    /// <para>
    /// The Measure resource provides the definition of a quality measure.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var measure = new Measure("measure-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Measure 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Measure : ResourceBase<R4Version>
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

        private FhirMarkdown? _clinicalrecommendationstatement;

        /// <summary>
        /// clinicalRecommendationStatement
        /// </summary>
        /// <remarks>
        /// <para>
        /// clinicalRecommendationStatement 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? clinicalRecommendationStatement
        {
            get => _clinicalrecommendationstatement;
            set
            {
                _clinicalrecommendationstatement = value;
                OnPropertyChanged(nameof(clinicalRecommendationStatement));
            }
        }

        private CodeableConcept? _compositescoring;

        /// <summary>
        /// compositeScoring
        /// </summary>
        /// <remarks>
        /// <para>
        /// compositeScoring 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? compositeScoring
        {
            get => _compositescoring;
            set
            {
                _compositescoring = value;
                OnPropertyChanged(nameof(compositeScoring));
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

        private List<FhirMarkdown>? _definition;

        /// <summary>
        /// definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// definition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirMarkdown>? definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(definition));
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

        private FhirMarkdown? _disclaimer;

        /// <summary>
        /// disclaimer
        /// </summary>
        /// <remarks>
        /// <para>
        /// disclaimer 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? disclaimer
        {
            get => _disclaimer;
            set
            {
                _disclaimer = value;
                OnPropertyChanged(nameof(disclaimer));
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

        private FhirBoolean? _experimental;

        /// <summary>
        /// experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(experimental));
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

        private List<BackboneElement>? _group;

        /// <summary>
        /// group
        /// </summary>
        /// <remarks>
        /// <para>
        /// group 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(group));
            }
        }

        private FhirMarkdown? _guidance;

        /// <summary>
        /// guidance
        /// </summary>
        /// <remarks>
        /// <para>
        /// guidance 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? guidance
        {
            get => _guidance;
            set
            {
                _guidance = value;
                OnPropertyChanged(nameof(guidance));
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

        private CodeableConcept? _improvementnotation;

        /// <summary>
        /// improvementNotation
        /// </summary>
        /// <remarks>
        /// <para>
        /// improvementNotation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? improvementNotation
        {
            get => _improvementnotation;
            set
            {
                _improvementnotation = value;
                OnPropertyChanged(nameof(improvementNotation));
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

        private List<FhirCanonical>? _library;

        /// <summary>
        /// library
        /// </summary>
        /// <remarks>
        /// <para>
        /// library 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? library
        {
            get => _library;
            set
            {
                _library = value;
                OnPropertyChanged(nameof(library));
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

        private FhirMarkdown? _purpose;

        /// <summary>
        /// purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(purpose));
            }
        }

        private FhirString? _rateaggregation;

        /// <summary>
        /// rateAggregation
        /// </summary>
        /// <remarks>
        /// <para>
        /// rateAggregation 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? rateAggregation
        {
            get => _rateaggregation;
            set
            {
                _rateaggregation = value;
                OnPropertyChanged(nameof(rateAggregation));
            }
        }

        private FhirMarkdown? _rationale;

        /// <summary>
        /// rationale
        /// </summary>
        /// <remarks>
        /// <para>
        /// rationale 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? rationale
        {
            get => _rationale;
            set
            {
                _rationale = value;
                OnPropertyChanged(nameof(rationale));
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

        private FhirString? _riskadjustment;

        /// <summary>
        /// riskAdjustment
        /// </summary>
        /// <remarks>
        /// <para>
        /// riskAdjustment 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? riskAdjustment
        {
            get => _riskadjustment;
            set
            {
                _riskadjustment = value;
                OnPropertyChanged(nameof(riskAdjustment));
            }
        }

        private CodeableConcept? _scoring;

        /// <summary>
        /// scoring
        /// </summary>
        /// <remarks>
        /// <para>
        /// scoring 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? scoring
        {
            get => _scoring;
            set
            {
                _scoring = value;
                OnPropertyChanged(nameof(scoring));
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

        private FhirString? _subtitle;

        /// <summary>
        /// subtitle
        /// </summary>
        /// <remarks>
        /// <para>
        /// subtitle 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? subtitle
        {
            get => _subtitle;
            set
            {
                _subtitle = value;
                OnPropertyChanged(nameof(subtitle));
            }
        }

        private List<BackboneElement>? _supplementaldata;

        /// <summary>
        /// supplementalData
        /// </summary>
        /// <remarks>
        /// <para>
        /// supplementalData 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? supplementalData
        {
            get => _supplementaldata;
            set
            {
                _supplementaldata = value;
                OnPropertyChanged(nameof(supplementalData));
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

        private List<CodeableConcept>? _type;

        /// <summary>
        /// type
        /// </summary>
        /// <remarks>
        /// <para>
        /// type 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(type));
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

        private FhirString? _usage;

        /// <summary>
        /// usage
        /// </summary>
        /// <remarks>
        /// <para>
        /// usage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? usage
        {
            get => _usage;
            set
            {
                _usage = value;
                OnPropertyChanged(nameof(usage));
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
        public override string ResourceType => "Measure";

        /// <summary>
        /// 建立新的 Measure 資源實例
        /// </summary>
        public Measure()
        {
        }

        /// <summary>
        /// 建立新的 Measure 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Measure(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Measure(Id: {Id})";
        }
    }
}
