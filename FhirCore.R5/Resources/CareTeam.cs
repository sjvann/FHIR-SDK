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
    /// FHIR R5 CareTeam 資源
    /// 
    /// <para>
    /// CareTeam 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var careteam = new CareTeam("careteam-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 CareTeam 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class CareTeam : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<CodeableConcept>? _category;
        private FhirString? _name;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private Period? _period;
        private List<CareTeamParticipant>? _participant;
        private List<CodeableReference>? _reason;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _managingorganization;
        private List<ContactPoint>? _telecom;
        private List<Annotation>? _note;
        private CodeableConcept? _role;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _member;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _onbehalfof;
        private CareTeamParticipantCoverageChoice? _coverage;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "CareTeam";        /// <summary>
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
        /// Category
        /// </summary>
        /// <remarks>
        /// <para>
        /// Category 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CodeableConcept>? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
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
        /// Subject
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subject 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }        /// <summary>
        /// Period
        /// </summary>
        /// <remarks>
        /// <para>
        /// Period 的詳細描述。
        /// </para>
        /// </remarks>
        public Period? Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged(nameof(Period));
            }
        }        /// <summary>
        /// Participant
        /// </summary>
        /// <remarks>
        /// <para>
        /// Participant 的詳細描述。
        /// </para>
        /// </remarks>
        public List<CareTeamParticipant>? Participant
        {
            get => _participant;
            set
            {
                _participant = value;
                OnPropertyChanged(nameof(Participant));
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
        /// Managingorganization
        /// </summary>
        /// <remarks>
        /// <para>
        /// Managingorganization 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Managingorganization
        {
            get => _managingorganization;
            set
            {
                _managingorganization = value;
                OnPropertyChanged(nameof(Managingorganization));
            }
        }        /// <summary>
        /// Telecom
        /// </summary>
        /// <remarks>
        /// <para>
        /// Telecom 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ContactPoint>? Telecom
        {
            get => _telecom;
            set
            {
                _telecom = value;
                OnPropertyChanged(nameof(Telecom));
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
        /// Member
        /// </summary>
        /// <remarks>
        /// <para>
        /// Member 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Member
        {
            get => _member;
            set
            {
                _member = value;
                OnPropertyChanged(nameof(Member));
            }
        }        /// <summary>
        /// Onbehalfof
        /// </summary>
        /// <remarks>
        /// <para>
        /// Onbehalfof 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Onbehalfof
        {
            get => _onbehalfof;
            set
            {
                _onbehalfof = value;
                OnPropertyChanged(nameof(Onbehalfof));
            }
        }        /// <summary>
        /// Coverage
        /// </summary>
        /// <remarks>
        /// <para>
        /// Coverage 的詳細描述。
        /// </para>
        /// </remarks>
        public CareTeamParticipantCoverageChoice? Coverage
        {
            get => _coverage;
            set
            {
                _coverage = value;
                OnPropertyChanged(nameof(Coverage));
            }
        }        /// <summary>
        /// 建立新的 CareTeam 資源實例
        /// </summary>
        public CareTeam()
        {
        }

        /// <summary>
        /// 建立新的 CareTeam 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public CareTeam(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"CareTeam(Id: {Id})";
        }
    }    /// <summary>
    /// CareTeamParticipant 背骨元素
    /// </summary>
    public class CareTeamParticipant
    {
        // TODO: 添加屬性實作
        
        public CareTeamParticipant() { }
    }    /// <summary>
    /// CareTeamParticipantCoverageChoice 選擇類型
    /// </summary>
    public class CareTeamParticipantCoverageChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public CareTeamParticipantCoverageChoice(JsonObject value) : base("careteamparticipantcoverage", value, _supportType) { }
        public CareTeamParticipantCoverageChoice(IComplexType? value) : base("careteamparticipantcoverage", value) { }
        public CareTeamParticipantCoverageChoice(IPrimitiveType? value) : base("careteamparticipantcoverage", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "CareTeamParticipantCoverage" : "careteamparticipantcoverage";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
