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
    /// FHIR R4 ActivityDefinition 資源
    /// 
    /// <para>
    /// This resource allows for the definition of some activity to be performed, independent of a particular patient, practitioner, or other performance context.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var activitydefinition = new ActivityDefinition("activitydefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 ActivityDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ActivityDefinition : ResourceBase<R4Version>
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

        private List<CodeableConcept>? _bodysite;

        /// <summary>
        /// bodySite
        /// </summary>
        /// <remarks>
        /// <para>
        /// bodySite 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? bodySite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(bodySite));
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

        private FhirBoolean? _donotperform;

        /// <summary>
        /// doNotPerform
        /// </summary>
        /// <remarks>
        /// <para>
        /// doNotPerform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? doNotPerform
        {
            get => _donotperform;
            set
            {
                _donotperform = value;
                OnPropertyChanged(nameof(doNotPerform));
            }
        }

        private List<FhirString>? _dosage;

        /// <summary>
        /// dosage
        /// </summary>
        /// <remarks>
        /// <para>
        /// dosage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? dosage
        {
            get => _dosage;
            set
            {
                _dosage = value;
                OnPropertyChanged(nameof(dosage));
            }
        }

        private List<BackboneElement>? _dynamicvalue;

        /// <summary>
        /// dynamicValue
        /// </summary>
        /// <remarks>
        /// <para>
        /// dynamicValue 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? dynamicValue
        {
            get => _dynamicvalue;
            set
            {
                _dynamicvalue = value;
                OnPropertyChanged(nameof(dynamicValue));
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

        private FhirCode? _kind;

        /// <summary>
        /// kind
        /// </summary>
        /// <remarks>
        /// <para>
        /// kind 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? kind
        {
            get => _kind;
            set
            {
                _kind = value;
                OnPropertyChanged(nameof(kind));
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

        private ReferenceType? _location;

        /// <summary>
        /// location
        /// </summary>
        /// <remarks>
        /// <para>
        /// location 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? location
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

        private List<ReferenceType>? _observationrequirement;

        /// <summary>
        /// observationRequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// observationRequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? observationRequirement
        {
            get => _observationrequirement;
            set
            {
                _observationrequirement = value;
                OnPropertyChanged(nameof(observationRequirement));
            }
        }

        private List<ReferenceType>? _observationresultrequirement;

        /// <summary>
        /// observationResultRequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// observationResultRequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? observationResultRequirement
        {
            get => _observationresultrequirement;
            set
            {
                _observationresultrequirement = value;
                OnPropertyChanged(nameof(observationResultRequirement));
            }
        }

        private List<BackboneElement>? _participant;

        /// <summary>
        /// participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(participant));
            }
        }

        private FhirCode? _priority;

        /// <summary>
        /// priority
        /// </summary>
        /// <remarks>
        /// <para>
        /// priority 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(priority));
            }
        }

        private FhirCanonical? _profile;

        /// <summary>
        /// profile
        /// </summary>
        /// <remarks>
        /// <para>
        /// profile 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? profile
        {
            get => _profile;
            set
            {
                _profile = value;
                OnPropertyChanged(nameof(profile));
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

        private Quantity? _quantity;

        /// <summary>
        /// quantity
        /// </summary>
        /// <remarks>
        /// <para>
        /// quantity 的詳細描述。
        /// </para>
        /// </remarks>
        public Quantity? quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
                OnPropertyChanged(nameof(quantity));
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

        private List<ReferenceType>? _specimenrequirement;

        /// <summary>
        /// specimenRequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// specimenRequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? specimenRequirement
        {
            get => _specimenrequirement;
            set
            {
                _specimenrequirement = value;
                OnPropertyChanged(nameof(specimenRequirement));
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

        private FhirCanonical? _transform;

        /// <summary>
        /// transform
        /// </summary>
        /// <remarks>
        /// <para>
        /// transform 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? transform
        {
            get => _transform;
            set
            {
                _transform = value;
                OnPropertyChanged(nameof(transform));
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
        public override string ResourceType => "ActivityDefinition";

        /// <summary>
        /// 建立新的 ActivityDefinition 資源實例
        /// </summary>
        public ActivityDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ActivityDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ActivityDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ActivityDefinition(Id: {Id})";
        }
    }
}
