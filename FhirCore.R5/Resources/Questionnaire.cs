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
    /// FHIR R5 Questionnaire 資源
    /// 
    /// <para>
    /// Questionnaire 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var questionnaire = new Questionnaire("questionnaire-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 Questionnaire 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class Questionnaire : ResourceBase<R5Version>
    {
        private Property
		private FhirUri? _url;
        private List<Identifier>? _identifier;
        private FhirString? _version;
        private QuestionnaireVersionAlgorithmChoice? _versionalgorithm;
        private FhirString? _name;
        private FhirString? _title;
        private List<FhirCanonical>? _derivedfrom;
        private FhirCode? _status;
        private FhirBoolean? _experimental;
        private List<FhirCode>? _subjecttype;
        private FhirDateTime? _date;
        private FhirString? _publisher;
        private List<ContactDetail>? _contact;
        private FhirMarkdown? _description;
        private List<UsageContext>? _usecontext;
        private List<CodeableConcept>? _jurisdiction;
        private FhirMarkdown? _purpose;
        private FhirMarkdown? _copyright;
        private FhirString? _copyrightlabel;
        private FhirDate? _approvaldate;
        private FhirDate? _lastreviewdate;
        private Period? _effectiveperiod;
        private List<Coding>? _code;
        private List<QuestionnaireItem>? _item;
        private FhirString? _question;
        private FhirCode? _operator;
        private QuestionnaireItemEnableWhenAnswerChoice? _answer;
        private QuestionnaireItemAnswerOptionValueChoice? _value;
        private FhirBoolean? _initialselected;
        private QuestionnaireItemInitialValueChoice? _value;
        private FhirString? _linkid;
        private FhirUri? _definition;
        private List<Coding>? _code;
        private FhirString? _prefix;
        private FhirCode? _type;
        private List<QuestionnaireItemEnableWhen>? _enablewhen;
        private FhirCode? _enablebehavior;
        private FhirCode? _disableddisplay;
        private FhirBoolean? _required;
        private FhirBoolean? _repeats;
        private FhirBoolean? _readonly;
        private FhirInteger? _maxlength;
        private FhirCode? _answerconstraint;
        private FhirCanonical? _answervalueset;
        private List<QuestionnaireItemAnswerOption>? _answeroption;
        private List<QuestionnaireItemInitial>? _initial;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "Questionnaire";        /// <summary>
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
        public QuestionnaireVersionAlgorithmChoice? Versionalgorithm
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
        /// Derivedfrom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Derivedfrom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Derivedfrom
        {
            get => _derivedfrom;
            set
            {
                _derivedfrom = value;
                OnPropertyChanged(nameof(Derivedfrom));
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
        /// Subjecttype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjecttype 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCode>? Subjecttype
        {
            get => _subjecttype;
            set
            {
                _subjecttype = value;
                OnPropertyChanged(nameof(Subjecttype));
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
        /// Purpose
        /// </summary>
        /// <remarks>
        /// <para>
        /// Purpose 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Purpose
        {
            get => _purpose;
            set
            {
                _purpose = value;
                OnPropertyChanged(nameof(Purpose));
            }
        }        /// <summary>
        /// Copyright
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyright 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirMarkdown? Copyright
        {
            get => _copyright;
            set
            {
                _copyright = value;
                OnPropertyChanged(nameof(Copyright));
            }
        }        /// <summary>
        /// Copyrightlabel
        /// </summary>
        /// <remarks>
        /// <para>
        /// Copyrightlabel 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Copyrightlabel
        {
            get => _copyrightlabel;
            set
            {
                _copyrightlabel = value;
                OnPropertyChanged(nameof(Copyrightlabel));
            }
        }        /// <summary>
        /// Approvaldate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Approvaldate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Approvaldate
        {
            get => _approvaldate;
            set
            {
                _approvaldate = value;
                OnPropertyChanged(nameof(Approvaldate));
            }
        }        /// <summary>
        /// Lastreviewdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Lastreviewdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDate? Lastreviewdate
        {
            get => _lastreviewdate;
            set
            {
                _lastreviewdate = value;
                OnPropertyChanged(nameof(Lastreviewdate));
            }
        }        /// <summary>
        /// Effectiveperiod
        /// </summary>
        /// <remarks>
        /// <para>
        /// Effectiveperiod 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Effectiveperiod
        {
            get => _effectiveperiod;
            set
            {
                _effectiveperiod = value;
                OnPropertyChanged(nameof(Effectiveperiod));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Item
        /// </summary>
        /// <remarks>
        /// <para>
        /// Item 的詳細描述。
        /// </para>
        /// </remarks>
        public List<QuestionnaireItem>? Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged(nameof(Item));
            }
        }        /// <summary>
        /// Question
        /// </summary>
        /// <remarks>
        /// <para>
        /// Question 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Question
        {
            get => _question;
            set
            {
                _question = value;
                OnPropertyChanged(nameof(Question));
            }
        }        /// <summary>
        /// Operator
        /// </summary>
        /// <remarks>
        /// <para>
        /// Operator 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Operator
        {
            get => _operator;
            set
            {
                _operator = value;
                OnPropertyChanged(nameof(Operator));
            }
        }        /// <summary>
        /// Answer
        /// </summary>
        /// <remarks>
        /// <para>
        /// Answer 的詳細描述。
        /// </para>
        /// </remarks>
        public QuestionnaireItemEnableWhenAnswerChoice? Answer
        {
            get => _answer;
            set
            {
                _answer = value;
                OnPropertyChanged(nameof(Answer));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public QuestionnaireItemAnswerOptionValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Initialselected
        /// </summary>
        /// <remarks>
        /// <para>
        /// Initialselected 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Initialselected
        {
            get => _initialselected;
            set
            {
                _initialselected = value;
                OnPropertyChanged(nameof(Initialselected));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public QuestionnaireItemInitialValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Linkid
        /// </summary>
        /// <remarks>
        /// <para>
        /// Linkid 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Linkid
        {
            get => _linkid;
            set
            {
                _linkid = value;
                OnPropertyChanged(nameof(Linkid));
            }
        }        /// <summary>
        /// Definition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Definition 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirUri? Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                OnPropertyChanged(nameof(Definition));
            }
        }        /// <summary>
        /// Code
        /// </summary>
        /// <remarks>
        /// <para>
        /// Code 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Coding>? Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged(nameof(Code));
            }
        }        /// <summary>
        /// Prefix
        /// </summary>
        /// <remarks>
        /// <para>
        /// Prefix 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirString? Prefix
        {
            get => _prefix;
            set
            {
                _prefix = value;
                OnPropertyChanged(nameof(Prefix));
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
        /// Enablewhen
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enablewhen 的詳細描述。
        /// </para>
        /// </remarks>
        public List<QuestionnaireItemEnableWhen>? Enablewhen
        {
            get => _enablewhen;
            set
            {
                _enablewhen = value;
                OnPropertyChanged(nameof(Enablewhen));
            }
        }        /// <summary>
        /// Enablebehavior
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enablebehavior 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Enablebehavior
        {
            get => _enablebehavior;
            set
            {
                _enablebehavior = value;
                OnPropertyChanged(nameof(Enablebehavior));
            }
        }        /// <summary>
        /// Disableddisplay
        /// </summary>
        /// <remarks>
        /// <para>
        /// Disableddisplay 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Disableddisplay
        {
            get => _disableddisplay;
            set
            {
                _disableddisplay = value;
                OnPropertyChanged(nameof(Disableddisplay));
            }
        }        /// <summary>
        /// Required
        /// </summary>
        /// <remarks>
        /// <para>
        /// Required 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Required
        {
            get => _required;
            set
            {
                _required = value;
                OnPropertyChanged(nameof(Required));
            }
        }        /// <summary>
        /// Repeats
        /// </summary>
        /// <remarks>
        /// <para>
        /// Repeats 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Repeats
        {
            get => _repeats;
            set
            {
                _repeats = value;
                OnPropertyChanged(nameof(Repeats));
            }
        }        /// <summary>
        /// Readonly
        /// </summary>
        /// <remarks>
        /// <para>
        /// Readonly 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Readonly
        {
            get => _readonly;
            set
            {
                _readonly = value;
                OnPropertyChanged(nameof(Readonly));
            }
        }        /// <summary>
        /// Maxlength
        /// </summary>
        /// <remarks>
        /// <para>
        /// Maxlength 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Maxlength
        {
            get => _maxlength;
            set
            {
                _maxlength = value;
                OnPropertyChanged(nameof(Maxlength));
            }
        }        /// <summary>
        /// Answerconstraint
        /// </summary>
        /// <remarks>
        /// <para>
        /// Answerconstraint 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Answerconstraint
        {
            get => _answerconstraint;
            set
            {
                _answerconstraint = value;
                OnPropertyChanged(nameof(Answerconstraint));
            }
        }        /// <summary>
        /// Answervalueset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Answervalueset 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Answervalueset
        {
            get => _answervalueset;
            set
            {
                _answervalueset = value;
                OnPropertyChanged(nameof(Answervalueset));
            }
        }        /// <summary>
        /// Answeroption
        /// </summary>
        /// <remarks>
        /// <para>
        /// Answeroption 的詳細描述。
        /// </para>
        /// </remarks>
        public List<QuestionnaireItemAnswerOption>? Answeroption
        {
            get => _answeroption;
            set
            {
                _answeroption = value;
                OnPropertyChanged(nameof(Answeroption));
            }
        }        /// <summary>
        /// Initial
        /// </summary>
        /// <remarks>
        /// <para>
        /// Initial 的詳細描述。
        /// </para>
        /// </remarks>
        public List<QuestionnaireItemInitial>? Initial
        {
            get => _initial;
            set
            {
                _initial = value;
                OnPropertyChanged(nameof(Initial));
            }
        }        /// <summary>
        /// 建立新的 Questionnaire 資源實例
        /// </summary>
        public Questionnaire()
        {
        }

        /// <summary>
        /// 建立新的 Questionnaire 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public Questionnaire(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"Questionnaire(Id: {Id})";
        }
    }    /// <summary>
    /// QuestionnaireItemEnableWhen 背骨元素
    /// </summary>
    public class QuestionnaireItemEnableWhen
    {
        // TODO: 添加屬性實作
        
        public QuestionnaireItemEnableWhen() { }
    }    /// <summary>
    /// QuestionnaireItemAnswerOption 背骨元素
    /// </summary>
    public class QuestionnaireItemAnswerOption
    {
        // TODO: 添加屬性實作
        
        public QuestionnaireItemAnswerOption() { }
    }    /// <summary>
    /// QuestionnaireItemInitial 背骨元素
    /// </summary>
    public class QuestionnaireItemInitial
    {
        // TODO: 添加屬性實作
        
        public QuestionnaireItemInitial() { }
    }    /// <summary>
    /// QuestionnaireItem 背骨元素
    /// </summary>
    public class QuestionnaireItem
    {
        // TODO: 添加屬性實作
        
        public QuestionnaireItem() { }
    }    /// <summary>
    /// QuestionnaireVersionAlgorithmChoice 選擇類型
    /// </summary>
    public class QuestionnaireVersionAlgorithmChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public QuestionnaireVersionAlgorithmChoice(JsonObject value) : base("questionnaireversionalgorithm", value, _supportType) { }
        public QuestionnaireVersionAlgorithmChoice(IComplexType? value) : base("questionnaireversionalgorithm", value) { }
        public QuestionnaireVersionAlgorithmChoice(IPrimitiveType? value) : base("questionnaireversionalgorithm", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "QuestionnaireVersionAlgorithm" : "questionnaireversionalgorithm";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// QuestionnaireItemEnableWhenAnswerChoice 選擇類型
    /// </summary>
    public class QuestionnaireItemEnableWhenAnswerChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public QuestionnaireItemEnableWhenAnswerChoice(JsonObject value) : base("questionnaireitemenablewhenanswer", value, _supportType) { }
        public QuestionnaireItemEnableWhenAnswerChoice(IComplexType? value) : base("questionnaireitemenablewhenanswer", value) { }
        public QuestionnaireItemEnableWhenAnswerChoice(IPrimitiveType? value) : base("questionnaireitemenablewhenanswer", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "QuestionnaireItemEnableWhenAnswer" : "questionnaireitemenablewhenanswer";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// QuestionnaireItemAnswerOptionValueChoice 選擇類型
    /// </summary>
    public class QuestionnaireItemAnswerOptionValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public QuestionnaireItemAnswerOptionValueChoice(JsonObject value) : base("questionnaireitemansweroptionvalue", value, _supportType) { }
        public QuestionnaireItemAnswerOptionValueChoice(IComplexType? value) : base("questionnaireitemansweroptionvalue", value) { }
        public QuestionnaireItemAnswerOptionValueChoice(IPrimitiveType? value) : base("questionnaireitemansweroptionvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "QuestionnaireItemAnswerOptionValue" : "questionnaireitemansweroptionvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// QuestionnaireItemInitialValueChoice 選擇類型
    /// </summary>
    public class QuestionnaireItemInitialValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public QuestionnaireItemInitialValueChoice(JsonObject value) : base("questionnaireiteminitialvalue", value, _supportType) { }
        public QuestionnaireItemInitialValueChoice(IComplexType? value) : base("questionnaireiteminitialvalue", value) { }
        public QuestionnaireItemInitialValueChoice(IPrimitiveType? value) : base("questionnaireiteminitialvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "QuestionnaireItemInitialValue" : "questionnaireiteminitialvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
