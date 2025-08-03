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
    /// FHIR R4 GuidanceResponse 資源
    /// 
    /// <para>
    /// A guidance response is the formal response to a guidance request, including any output parameters returned by the evaluation, as well as the description of any proposed actions to be taken.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var guidanceresponse = new GuidanceResponse("guidanceresponse-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 GuidanceResponse 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class GuidanceResponse : ResourceBase<R4Version>
    {
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

        private List<FhirString>? _datarequirement;

        /// <summary>
        /// dataRequirement
        /// </summary>
        /// <remarks>
        /// <para>
        /// dataRequirement 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirString>? dataRequirement
        {
            get => _datarequirement;
            set
            {
                _datarequirement = value;
                OnPropertyChanged(nameof(dataRequirement));
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

        private List<ReferenceType>? _evaluationmessage;

        /// <summary>
        /// evaluationMessage
        /// </summary>
        /// <remarks>
        /// <para>
        /// evaluationMessage 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? evaluationMessage
        {
            get => _evaluationmessage;
            set
            {
                _evaluationmessage = value;
                OnPropertyChanged(nameof(evaluationMessage));
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

        private FhirDateTime? _occurrencedatetime;

        /// <summary>
        /// occurrenceDateTime
        /// </summary>
        /// <remarks>
        /// <para>
        /// occurrenceDateTime 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? occurrenceDateTime
        {
            get => _occurrencedatetime;
            set
            {
                _occurrencedatetime = value;
                OnPropertyChanged(nameof(occurrenceDateTime));
            }
        }

        private ReferenceType? _outputparameters;

        /// <summary>
        /// outputParameters
        /// </summary>
        /// <remarks>
        /// <para>
        /// outputParameters 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? outputParameters
        {
            get => _outputparameters;
            set
            {
                _outputparameters = value;
                OnPropertyChanged(nameof(outputParameters));
            }
        }

        private ReferenceType? _performer;

        /// <summary>
        /// performer
        /// </summary>
        /// <remarks>
        /// <para>
        /// performer 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? performer
        {
            get => _performer;
            set
            {
                _performer = value;
                OnPropertyChanged(nameof(performer));
            }
        }

        private List<CodeableConcept>? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private List<ReferenceType>? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private Identifier? _requestidentifier;

        /// <summary>
        /// requestIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// requestIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? requestIdentifier
        {
            get => _requestidentifier;
            set
            {
                _requestidentifier = value;
                OnPropertyChanged(nameof(requestIdentifier));
            }
        }

        private ReferenceType? _result;

        /// <summary>
        /// result
        /// </summary>
        /// <remarks>
        /// <para>
        /// result 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(result));
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
        public override string ResourceType => "GuidanceResponse";

        /// <summary>
        /// 建立新的 GuidanceResponse 資源實例
        /// </summary>
        public GuidanceResponse()
        {
        }

        /// <summary>
        /// 建立新的 GuidanceResponse 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public GuidanceResponse(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"GuidanceResponse(Id: {Id})";
        }
    }
}
