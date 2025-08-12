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
    /// FHIR R4 Task 資源
    /// 
    /// <para>
    /// A task to be performed.
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var task = new Task("task-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R4 版本的 Task 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Task : ResourceBase<R4Version>
    {
        private FhirDateTime? _authoredon;

        /// <summary>
        /// authoredOn
        /// </summary>
        /// <remarks>
        /// <para>
        /// authoredOn 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? authoredOn
        {
            get => _authoredon;
            set
            {
                _authoredon = value;
                OnPropertyChanged(nameof(authoredOn));
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

        private CodeableConcept? _businessstatus;

        /// <summary>
        /// businessStatus
        /// </summary>
        /// <remarks>
        /// <para>
        /// businessStatus 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? businessStatus
        {
            get => _businessstatus;
            set
            {
                _businessstatus = value;
                OnPropertyChanged(nameof(businessStatus));
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

        private Period? _executionperiod;

        /// <summary>
        /// executionPeriod
        /// </summary>
        /// <remarks>
        /// <para>
        /// executionPeriod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? executionPeriod
        {
            get => _executionperiod;
            set
            {
                _executionperiod = value;
                OnPropertyChanged(nameof(executionPeriod));
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

        private ReferenceType? _focus;

        /// <summary>
        /// focus
        /// </summary>
        /// <remarks>
        /// <para>
        /// focus 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? focus
        {
            get => _focus;
            set
            {
                _focus = value;
                OnPropertyChanged(nameof(focus));
            }
        }

        private ReferenceType? _for;

        /// <summary>
        /// for
        /// </summary>
        /// <remarks>
        /// <para>
        /// for 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? for
        {
            get => _for;
            set
            {
                _for = value;
                OnPropertyChanged(nameof(for));
            }
        }

        private Identifier? _groupidentifier;

        /// <summary>
        /// groupIdentifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// groupIdentifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Identifier? groupIdentifier
        {
            get => _groupidentifier;
            set
            {
                _groupidentifier = value;
                OnPropertyChanged(nameof(groupIdentifier));
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

        private List<BackboneElement>? _input;

        /// <summary>
        /// input
        /// </summary>
        /// <remarks>
        /// <para>
        /// input 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? input
        {
            get => _input;
            set
            {
                _input = value;
                OnPropertyChanged(nameof(input));
            }
        }

        private FhirCanonical? _instantiatescanonical;

        /// <summary>
        /// instantiatesCanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesCanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? instantiatesCanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(instantiatesCanonical));
            }
        }

        private FhirUri? _instantiatesuri;

        /// <summary>
        /// instantiatesUri
        /// </summary>
        /// <remarks>
        /// <para>
        /// instantiatesUri 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? instantiatesUri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(instantiatesUri));
            }
        }

        private List<ReferenceType>? _insurance;

        /// <summary>
        /// insurance
        /// </summary>
        /// <remarks>
        /// <para>
        /// insurance 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? insurance
        {
            get => _insurance;
            set
            {
                _insurance = value;
                OnPropertyChanged(nameof(insurance));
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

        private FhirDateTime? _lastmodified;

        /// <summary>
        /// lastModified
        /// </summary>
        /// <remarks>
        /// <para>
        /// lastModified 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? lastModified
        {
            get => _lastmodified;
            set
            {
                _lastmodified = value;
                OnPropertyChanged(nameof(lastModified));
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

        private List<BackboneElement>? _output;

        /// <summary>
        /// output
        /// </summary>
        /// <remarks>
        /// <para>
        /// output 的詳細描述。
        /// </para>
        /// </remarks>
        public List<BackboneElement>? output
        {
            get => _output;
            set
            {
                _output = value;
                OnPropertyChanged(nameof(output));
            }
        }

        private ReferenceType? _owner;

        /// <summary>
        /// owner
        /// </summary>
        /// <remarks>
        /// <para>
        /// owner 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? owner
        {
            get => _owner;
            set
            {
                _owner = value;
                OnPropertyChanged(nameof(owner));
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

        private List<CodeableConcept>? _performertype;

        /// <summary>
        /// performerType
        /// </summary>
        /// <remarks>
        /// <para>
        /// performerType 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? performerType
        {
            get => _performertype;
            set
            {
                _performertype = value;
                OnPropertyChanged(nameof(performerType));
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

        private CodeableConcept? _reasoncode;

        /// <summary>
        /// reasonCode
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonCode 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? reasonCode
        {
            get => _reasoncode;
            set
            {
                _reasoncode = value;
                OnPropertyChanged(nameof(reasonCode));
            }
        }

        private ReferenceType? _reasonreference;

        /// <summary>
        /// reasonReference
        /// </summary>
        /// <remarks>
        /// <para>
        /// reasonReference 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? reasonReference
        {
            get => _reasonreference;
            set
            {
                _reasonreference = value;
                OnPropertyChanged(nameof(reasonReference));
            }
        }

        private List<ReferenceType>? _relevanthistory;

        /// <summary>
        /// relevantHistory
        /// </summary>
        /// <remarks>
        /// <para>
        /// relevantHistory 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ReferenceType>? relevantHistory
        {
            get => _relevanthistory;
            set
            {
                _relevanthistory = value;
                OnPropertyChanged(nameof(relevantHistory));
            }
        }

        private ReferenceType? _requester;

        /// <summary>
        /// requester
        /// </summary>
        /// <remarks>
        /// <para>
        /// requester 的詳細描述。
        /// </para>
        /// </remarks>
        public ReferenceType? requester
        {
            get => _requester;
            set
            {
                _requester = value;
                OnPropertyChanged(nameof(requester));
            }
        }

        private BackboneElement? _restriction;

        /// <summary>
        /// restriction
        /// </summary>
        /// <remarks>
        /// <para>
        /// restriction 的詳細描述。
        /// </para>
        /// </remarks>
        public BackboneElement? restriction
        {
            get => _restriction;
            set
            {
                _restriction = value;
                OnPropertyChanged(nameof(restriction));
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

        private CodeableConcept? _statusreason;

        /// <summary>
        /// statusReason
        /// </summary>
        /// <remarks>
        /// <para>
        /// statusReason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? statusReason
        {
            get => _statusreason;
            set
            {
                _statusreason = value;
                OnPropertyChanged(nameof(statusReason));
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
        public override string ResourceType => "Task";

        /// <summary>
        /// 建立新的 Task 資源實例
        /// </summary>
        public Task()
        {
        }

        /// <summary>
        /// 建立新的 Task 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Task(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Task(Id: {Id})";
        }
    }
}
