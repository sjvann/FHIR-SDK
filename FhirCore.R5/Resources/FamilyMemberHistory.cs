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
    /// FHIR R5 FamilyMemberHistory 資源
    /// 
    /// <para>
    /// FamilyMemberHistory 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var familymemberhistory = new FamilyMemberHistory("familymemberhistory-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 FamilyMemberHistory 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class FamilyMemberHistory : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private List<FhirCanonical>? _instantiatescanonical;
        private List<FhirUri>? _instantiatesuri;
        private FhirCode? _status;
        private CodeableConcept? _dataabsentreason;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _patient;
        private FhirDateTime? _date;
        private List<FamilyMemberHistoryParticipant>? _participant;
        private FhirString? _name;
        private CodeableConcept? _relationship;
        private CodeableConcept? _sex;
        private FamilyMemberHistoryBornChoice? _born;
        private FamilyMemberHistoryAgeChoice? _age;
        private FhirBoolean? _estimatedage;
        private FamilyMemberHistoryDeceasedChoice? _deceased;
        private List<CodeableReference>? _reason;
        private List<Annotation>? _note;
        private List<FamilyMemberHistoryCondition>? _condition;
        private List<FamilyMemberHistoryProcedure>? _procedure;
        private CodeableConcept? _function;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _actor;
        private CodeableConcept? _code;
        private CodeableConcept? _outcome;
        private FhirBoolean? _contributedtodeath;
        private FamilyMemberHistoryConditionOnsetChoice? _onset;
        private List<Annotation>? _note;
        private CodeableConcept? _code;
        private CodeableConcept? _outcome;
        private FhirBoolean? _contributedtodeath;
        private FamilyMemberHistoryProcedurePerformedChoice? _performed;
        private List<Annotation>? _note;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "FamilyMemberHistory";        /// <summary>
        /// Identifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Identifier 的詳細描述。
        /// </para>
        /// </remarks>
        public Property
		private List<Identifier>? Identifier
        {
            get => _identifier;
            set
            {
                _identifier = value;
                OnPropertyChanged(nameof(Identifier));
            }
        }        /// <summary>
        /// Instantiatescanonical
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatescanonical 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirCanonical>? Instantiatescanonical
        {
            get => _instantiatescanonical;
            set
            {
                _instantiatescanonical = value;
                OnPropertyChanged(nameof(Instantiatescanonical));
            }
        }        /// <summary>
        /// Instantiatesuri
        /// </summary>
        /// <remarks>
        /// <para>
        /// Instantiatesuri 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FhirUri>? Instantiatesuri
        {
            get => _instantiatesuri;
            set
            {
                _instantiatesuri = value;
                OnPropertyChanged(nameof(Instantiatesuri));
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
        /// Dataabsentreason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dataabsentreason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Dataabsentreason
        {
            get => _dataabsentreason;
            set
            {
                _dataabsentreason = value;
                OnPropertyChanged(nameof(Dataabsentreason));
            }
        }        /// <summary>
        /// Patient
        /// </summary>
        /// <remarks>
        /// <para>
        /// Patient 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Patient
        {
            get => _patient;
            set
            {
                _patient = value;
                OnPropertyChanged(nameof(Patient));
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
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FamilyMemberHistoryParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
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
        /// Relationship
        /// </summary>
        /// <remarks>
        /// <para>
        /// Relationship 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Relationship
        {
            get => _relationship;
            set
            {
                _relationship = value;
                OnPropertyChanged(nameof(Relationship));
            }
        }        /// <summary>
        /// Sex
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sex 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Sex
        {
            get => _sex;
            set
            {
                _sex = value;
                OnPropertyChanged(nameof(Sex));
            }
        }        /// <summary>
        /// Born
        /// </summary>
        /// <remarks>
        /// <para>
        /// Born 的詳細描述。
        /// </para>
        /// </remarks>
        public FamilyMemberHistoryBornChoice? Born
        {
            get => _born;
            set
            {
                _born = value;
                OnPropertyChanged(nameof(Born));
            }
        }        /// <summary>
        /// Age
        /// </summary>
        /// <remarks>
        /// <para>
        /// Age 的詳細描述。
        /// </para>
        /// </remarks>
        public FamilyMemberHistoryAgeChoice? Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }        /// <summary>
        /// Estimatedage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Estimatedage 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Estimatedage
        {
            get => _estimatedage;
            set
            {
                _estimatedage = value;
                OnPropertyChanged(nameof(Estimatedage));
            }
        }        /// <summary>
        /// Deceased
        /// </summary>
        /// <remarks>
        /// <para>
        /// Deceased 的詳細描述。
        /// </para>
        /// </remarks>
        public FamilyMemberHistoryDeceasedChoice? Deceased
        {
            get => _deceased;
            set
            {
                _deceased = value;
                OnPropertyChanged(nameof(Deceased));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableReference>? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// Condition
        /// </summary>
        /// <remarks>
        /// <para>
        /// Condition 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FamilyMemberHistoryCondition>? Condition
        {
            get => _condition;
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }        /// <summary>
        /// Procedure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Procedure 的詳細描述。
        /// </para>
        /// </remarks>
        public List<FamilyMemberHistoryProcedure>? Procedure
        {
            get => _procedure;
            set
            {
                _procedure = value;
                OnPropertyChanged(nameof(Procedure));
            }
        }        /// <summary>
        /// Function
        /// </summary>
        /// <remarks>
        /// <para>
        /// Function 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Function
        {
            get => _function;
            set
            {
                _function = value;
                OnPropertyChanged(nameof(Function));
            }
        }        /// <summary>
        /// Actor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Actor
        {
            get => _actor;
            set
            {
                _actor = value;
                OnPropertyChanged(nameof(Actor));
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
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Contributedtodeath
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributedtodeath 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Contributedtodeath
        {
            get => _contributedtodeath;
            set
            {
                _contributedtodeath = value;
                OnPropertyChanged(nameof(Contributedtodeath));
            }
        }        /// <summary>
        /// Onset
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onset 的詳細描述。
        /// </para>
        /// </remarks>
        public FamilyMemberHistoryConditionOnsetChoice? Onset
        {
            get => _onset;
            set
            {
                _onset = value;
                OnPropertyChanged(nameof(Onset));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
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
        /// Outcome
        /// </summary>
        /// <remarks>
        /// <para>
        /// Outcome 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Outcome
        {
            get => _outcome;
            set
            {
                _outcome = value;
                OnPropertyChanged(nameof(Outcome));
            }
        }        /// <summary>
        /// Contributedtodeath
        /// </summary>
        /// <remarks>
        /// <para>
        /// Contributedtodeath 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirBoolean? Contributedtodeath
        {
            get => _contributedtodeath;
            set
            {
                _contributedtodeath = value;
                OnPropertyChanged(nameof(Contributedtodeath));
            }
        }        /// <summary>
        /// Performed
        /// </summary>
        /// <remarks>
        /// <para>
        /// Performed 的詳細描述。
        /// </para>
        /// </remarks>
        public FamilyMemberHistoryProcedurePerformedChoice? Performed
        {
            get => _performed;
            set
            {
                _performed = value;
                OnPropertyChanged(nameof(Performed));
            }
        }        /// <summary>
        /// Note
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note 的詳細描述。
        /// </para>
        /// </remarks>
        public List<Annotation>? Note
        {
            get => _note;
            set
            {
                _note = value;
                OnPropertyChanged(nameof(Note));
            }
        }        /// <summary>
        /// 建立新的 FamilyMemberHistory 資源實例
        /// </summary>
        public FamilyMemberHistory()
        {
        }

        /// <summary>
        /// 建立新的 FamilyMemberHistory 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public FamilyMemberHistory(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"FamilyMemberHistory(Id: {Id})";
        }
    }    /// <summary>
    /// FamilyMemberHistoryParticipant 背骨元素
    /// </summary>
    public class FamilyMemberHistoryParticipant
    {
        // TODO: 添加屬性實作
        
        public FamilyMemberHistoryParticipant() { }
    }    /// <summary>
    /// FamilyMemberHistoryCondition 背骨元素
    /// </summary>
    public class FamilyMemberHistoryCondition
    {
        // TODO: 添加屬性實作
        
        public FamilyMemberHistoryCondition() { }
    }    /// <summary>
    /// FamilyMemberHistoryProcedure 背骨元素
    /// </summary>
    public class FamilyMemberHistoryProcedure
    {
        // TODO: 添加屬性實作
        
        public FamilyMemberHistoryProcedure() { }
    }    /// <summary>
    /// FamilyMemberHistoryBornChoice 選擇類型
    /// </summary>
    public class FamilyMemberHistoryBornChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public FamilyMemberHistoryBornChoice(JsonObject value) : base("familymemberhistoryborn", value, _supportType) { }
        public FamilyMemberHistoryBornChoice(IComplexType? value) : base("familymemberhistoryborn", value) { }
        public FamilyMemberHistoryBornChoice(IPrimitiveType? value) : base("familymemberhistoryborn", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "FamilyMemberHistoryBorn" : "familymemberhistoryborn";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// FamilyMemberHistoryAgeChoice 選擇類型
    /// </summary>
    public class FamilyMemberHistoryAgeChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public FamilyMemberHistoryAgeChoice(JsonObject value) : base("familymemberhistoryage", value, _supportType) { }
        public FamilyMemberHistoryAgeChoice(IComplexType? value) : base("familymemberhistoryage", value) { }
        public FamilyMemberHistoryAgeChoice(IPrimitiveType? value) : base("familymemberhistoryage", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "FamilyMemberHistoryAge" : "familymemberhistoryage";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// FamilyMemberHistoryDeceasedChoice 選擇類型
    /// </summary>
    public class FamilyMemberHistoryDeceasedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public FamilyMemberHistoryDeceasedChoice(JsonObject value) : base("familymemberhistorydeceased", value, _supportType) { }
        public FamilyMemberHistoryDeceasedChoice(IComplexType? value) : base("familymemberhistorydeceased", value) { }
        public FamilyMemberHistoryDeceasedChoice(IPrimitiveType? value) : base("familymemberhistorydeceased", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "FamilyMemberHistoryDeceased" : "familymemberhistorydeceased";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// FamilyMemberHistoryConditionOnsetChoice 選擇類型
    /// </summary>
    public class FamilyMemberHistoryConditionOnsetChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public FamilyMemberHistoryConditionOnsetChoice(JsonObject value) : base("familymemberhistoryconditiononset", value, _supportType) { }
        public FamilyMemberHistoryConditionOnsetChoice(IComplexType? value) : base("familymemberhistoryconditiononset", value) { }
        public FamilyMemberHistoryConditionOnsetChoice(IPrimitiveType? value) : base("familymemberhistoryconditiononset", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "FamilyMemberHistoryConditionOnset" : "familymemberhistoryconditiononset";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// FamilyMemberHistoryProcedurePerformedChoice 選擇類型
    /// </summary>
    public class FamilyMemberHistoryProcedurePerformedChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public FamilyMemberHistoryProcedurePerformedChoice(JsonObject value) : base("familymemberhistoryprocedureperformed", value, _supportType) { }
        public FamilyMemberHistoryProcedurePerformedChoice(IComplexType? value) : base("familymemberhistoryprocedureperformed", value) { }
        public FamilyMemberHistoryProcedurePerformedChoice(IPrimitiveType? value) : base("familymemberhistoryprocedureperformed", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "FamilyMemberHistoryProcedurePerformed" : "familymemberhistoryprocedureperformed";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
