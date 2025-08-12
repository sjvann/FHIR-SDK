using FhirCore.Base;
using FhirCore.R5;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.TypeFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using FhirCore.Interfaces;

namespace FhirCore.R5.Resources
{
    /// <summary>
    /// FHIR R5 ConditionDefinition 資源
    /// 
    /// <para>
    /// ConditionDefinition 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var conditiondefinition = new ConditionDefinition("conditiondefinition-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ConditionDefinition 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ConditionDefinition : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private ConditionDefinitionVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private FhirString? _subtitle;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private CodeableConcept? _code;
        private CodeableConcept? _severity;
        private CodeableConcept? _bodysite;
        private CodeableConcept? _stage;
        private FhirBoolean? _hasseverity;
        private FhirBoolean? _hasbodysite;
        private FhirBoolean? _hasstage;
        private List<FhirUri>? _definition;
        private List<ConditionDefinitionObservation>? _observation;
        private List<ConditionDefinitionMedication>? _medication;
        private List<ConditionDefinitionPrecondition>? _precondition;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _team;
        private List<ConditionDefinitionQuestionnaire>? _questionnaire;
        private List<ConditionDefinitionPlan>? _plan;
        private CodeableConcept? _category;
        private CodeableConcept? _code;
        private CodeableConcept? _category;
        private CodeableConcept? _code;
        private FhirCode? _type;
        private CodeableConcept? _code;
        private ConditionDefinitionPreconditionValueChoice? _value;
        private FhirCode? _purpose;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;
        private CodeableConcept? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reference;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ConditionDefinition";        /// <summary>
        /// Url
        /// </summary>
        /// <remarks>
        /// <para>
        /// Url 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private FhirUri? Url
        {
            get => _url;
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Version
        /// </summary>
        /// <remarks>
        /// <para>
        /// Version 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged(nameof(Version));
            }
        }        /// <summary>
        /// Versionalgorithm
        /// </summary>
        /// <remarks>
        /// <para>
        /// Versionalgorithm 的詳細描述。
        /// </para>
        /// </remarks>
        public ConditionDefinitionVersionAlgorithmChoice? Versionalgorithm
        {
            get => _versionalgorithm;
            set
            {
                _versionalgorithm = value;
                OnPropertyChanged(nameof(Versionalgorithm));
            }
        }        /// <summary>
        /// Name
        /// </summary>
        /// <remarks>
        /// <para>
        /// Name 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }        /// <summary>
        /// Title
        /// </summary>
        /// <remarks>
        /// <para>
        /// Title 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }        /// <summary>
        /// Subtitle
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subtitle 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Subtitle
        {
            get => _subtitle;
            set
            {
                _subtitle = value;
                OnPropertyChanged(nameof(Subtitle));
            }
        }        /// <summary>
        /// Status
        /// </summary>
        /// <remarks>
        /// <para>
        /// Status 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged(nameof(Status));
            }
        }        /// <summary>
        /// Experimental
        /// </summary>
        /// <remarks>
        /// <para>
        /// Experimental 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Experimental
        {
            get => _experimental;
            set
            {
                _experimental = value;
                OnPropertyChanged(nameof(Experimental));
            }
        }        /// <summary>
        /// Date
        /// </summary>
        /// <remarks>
        /// <para>
        /// Date 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }        /// <summary>
        /// Publisher
        /// </summary>
        /// <remarks>
        /// <para>
        /// Publisher 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Publisher
        {
            get => _publisher;
            set
            {
                _publisher = value;
                OnPropertyChanged(nameof(Publisher));
            }
        }        /// <summary>
        /// Contact
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contact 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactDetail>? Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged(nameof(Contact));
            }
        }        /// <summary>
        /// Description
        /// </summary>
        /// <remarks>
        /// <para>
        /// Description 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }        /// <summary>
        /// Usecontext
        /// </summary>
        /// <remarks>
        /// <para>
        /// Usecontext 的詳細描述。
        /// </para>
        /// </remarks>
        public List<UsageContext>? Usecontext
        {
            get => _usecontext;
            set
            {
                _usecontext = value;
                OnPropertyChanged(nameof(Usecontext));
            }
        }        /// <summary>
        /// Jurisdiction
        /// </summary>
        /// <remarks>
        /// <para>
        /// Jurisdiction 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Jurisdiction
        {
            get => _jurisdiction;
            set
            {
                _jurisdiction = value;
                OnPropertyChanged(nameof(Jurisdiction));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Severity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Severity 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Severity
        {
            get => _severity;
            set
            {
                _severity = value;
                OnPropertyChanged(nameof(Severity));
            }
        }        /// <summary>
        /// Bodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Bodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Bodysite
        {
            get => _bodysite;
            set
            {
                _bodysite = value;
                OnPropertyChanged(nameof(Bodysite));
            }
        }        /// <summary>
        /// Stage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stage 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Stage
        {
            get => _stage;
            set
            {
                _stage = value;
                OnPropertyChanged(nameof(Stage));
            }
        }        /// <summary>
        /// Hasseverity
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hasseverity 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Hasseverity
        {
            get => _hasseverity;
            set
            {
                _hasseverity = value;
                OnPropertyChanged(nameof(Hasseverity));
            }
        }        /// <summary>
        /// Hasbodysite
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hasbodysite 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Hasbodysite
        {
            get => _hasbodysite;
            set
            {
                _hasbodysite = value;
                OnPropertyChanged(nameof(Hasbodysite));
            }
        }        /// <summary>
        /// Hasstage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Hasstage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Hasstage
        {
            get => _hasstage;
            set
            {
                _hasstage = value;
                OnPropertyChanged(nameof(Hasstage));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Observation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Observation 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConditionDefinitionObservation>? Observation
        {
            get => _observation;
            set
            {
                _observation = value;
                OnPropertyChanged(nameof(Observation));
            }
        }        /// <summary>
        /// Medication
        /// </summary>
        /// <remarks>
        /// <para>
        /// Medication 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConditionDefinitionMedication>? Medication
        {
            get => _medication;
            set
            {
                _medication = value;
                OnPropertyChanged(nameof(Medication));
            }
        }        /// <summary>
        /// Precondition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Precondition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConditionDefinitionPrecondition>? Precondition
        {
            get => _precondition;
            set
            {
                _precondition = value;
                OnPropertyChanged(nameof(Precondition));
            }
        }        /// <summary>
        /// Team
        /// </summary>
        /// <remarks>
        /// <para>
        /// Team 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Team
        {
            get => _team;
            set
            {
                _team = value;
                OnPropertyChanged(nameof(Team));
            }
        }        /// <summary>
        /// Questionnaire
        /// </summary>
        /// <remarks>
        /// <para>
        /// Questionnaire 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConditionDefinitionQuestionnaire>? Questionnaire
        {
            get => _questionnaire;
            set
            {
                _questionnaire = value;
                OnPropertyChanged(nameof(Questionnaire));
            }
        }        /// <summary>
        /// Plan
        /// </summary>
        /// <remarks>
        /// <para>
        /// Plan 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ConditionDefinitionPlan>? Plan
        {
            get => _plan;
            set
            {
                _plan = value;
                OnPropertyChanged(nameof(Plan));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public ConditionDefinitionPreconditionValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// Role
        /// </summary>
        /// <remarks>
        /// <para>
        /// Role 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged(nameof(Role));
            }
        }        /// <summary>
        /// Reference
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reference 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reference
        {
            get => _reference;
            set
            {
                _reference = value;
                OnPropertyChanged(nameof(Reference));
            }
        }        /// <summary>
        /// 建立新的 ConditionDefinition 資源實例
        /// </summary>
        public ConditionDefinition()
        {
        }

        /// <summary>
        /// 建立新的 ConditionDefinition 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ConditionDefinition(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ConditionDefinition(Id: {Id})";
        }
    }    /// <summary>
    /// ConditionDefinitionObservation 背骨元素
    /// </summary>
    public class ConditionDefinitionObservation
    {
        // TODO: 添加屬性實作
        
        public ConditionDefinitionObservation() { }
    }    /// <summary>
    /// ConditionDefinitionMedication 背骨元素
    /// </summary>
    public class ConditionDefinitionMedication
    {
        // TODO: 添加屬性實作
        
        public ConditionDefinitionMedication() { }
    }    /// <summary>
    /// ConditionDefinitionPrecondition 背骨元素
    /// </summary>
    public class ConditionDefinitionPrecondition
    {
        // TODO: 添加屬性實作
        
        public ConditionDefinitionPrecondition() { }
    }    /// <summary>
    /// ConditionDefinitionQuestionnaire 背骨元素
    /// </summary>
    public class ConditionDefinitionQuestionnaire
    {
        // TODO: 添加屬性實作
        
        public ConditionDefinitionQuestionnaire() { }
    }    /// <summary>
    /// ConditionDefinitionPlan 背骨元素
    /// </summary>
    public class ConditionDefinitionPlan
    {
        // TODO: 添加屬性實作
        
        public ConditionDefinitionPlan() { }
    }    /// <summary>
    /// ConditionDefinitionVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class ConditionDefinitionVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConditionDefinitionVersionAlgorithmChoice(JsonObject value) : base("conditiondefinitionversionalgorithm", value, _supportType) { }
        public ConditionDefinitionVersionAlgorithmChoice(IComplexType? value) : base("conditiondefinitionversionalgorithm", value) { }
        public ConditionDefinitionVersionAlgorithmChoice(IPrimitiveType? value) : base("conditiondefinitionversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConditionDefinitionVersionAlgorithm" : "conditiondefinitionversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// ConditionDefinitionPreconditionValueChoice 選擇類型
    /// </summary>
    public class ConditionDefinitionPreconditionValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public ConditionDefinitionPreconditionValueChoice(JsonObject value) : base("conditiondefinitionpreconditionvalue", value, _supportType) { }
        public ConditionDefinitionPreconditionValueChoice(IComplexType? value) : base("conditiondefinitionpreconditionvalue", value) { }
        public ConditionDefinitionPreconditionValueChoice(IPrimitiveType? value) : base("conditiondefinitionpreconditionvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "ConditionDefinitionPreconditionValue" : "conditiondefinitionpreconditionvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
