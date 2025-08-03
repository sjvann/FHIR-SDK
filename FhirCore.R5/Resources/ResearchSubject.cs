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
    /// FHIR R5 ResearchSubject 資源
    /// 
    /// <para>
    /// ResearchSubject 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var researchsubject = new ResearchSubject("researchsubject-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 ResearchSubject 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class ResearchSubject : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private List<ResearchSubjectProgress>? _progress;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _study;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirId? _assignedcomparisongroup;
        private FhirId? _actualcomparisongroup;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _consent;
        private CodeableConcept? _type;
        private CodeableConcept? _subjectstate;
        private CodeableConcept? _milestone;
        private CodeableConcept? _reason;
        private FhirDateTime? _startdate;
        private FhirDateTime? _enddate;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "ResearchSubject";        /// <summary>
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
        /// Progress
        /// </summary>
        /// <remarks>
        /// <para>
        /// Progress 的詳細描述。
        /// </para>
        /// </remarks>
        public List<ResearchSubjectProgress>? Progress
        {
            get => _progress;
            set
            {
                _progress = value;
                OnPropertyChanged(nameof(Progress));
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
        /// Study
        /// </summary>
        /// <remarks>
        /// <para>
        /// Study 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Study
        {
            get => _study;
            set
            {
                _study = value;
                OnPropertyChanged(nameof(Study));
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
        /// Assignedcomparisongroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Assignedcomparisongroup 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Assignedcomparisongroup
        {
            get => _assignedcomparisongroup;
            set
            {
                _assignedcomparisongroup = value;
                OnPropertyChanged(nameof(Assignedcomparisongroup));
            }
        }        /// <summary>
        /// Actualcomparisongroup
        /// </summary>
        /// <remarks>
        /// <para>
        /// Actualcomparisongroup 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirId? Actualcomparisongroup
        {
            get => _actualcomparisongroup;
            set
            {
                _actualcomparisongroup = value;
                OnPropertyChanged(nameof(Actualcomparisongroup));
            }
        }        /// <summary>
        /// Consent
        /// </summary>
        /// <remarks>
        /// <para>
        /// Consent 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Consent
        {
            get => _consent;
            set
            {
                _consent = value;
                OnPropertyChanged(nameof(Consent));
            }
        }        /// <summary>
        /// Type
        /// </summary>
        /// <remarks>
        /// <para>
        /// Type 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }        /// <summary>
        /// Subjectstate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjectstate 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Subjectstate
        {
            get => _subjectstate;
            set
            {
                _subjectstate = value;
                OnPropertyChanged(nameof(Subjectstate));
            }
        }        /// <summary>
        /// Milestone
        /// </summary>
        /// <remarks>
        /// <para>
        /// Milestone 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Milestone
        {
            get => _milestone;
            set
            {
                _milestone = value;
                OnPropertyChanged(nameof(Milestone));
            }
        }        /// <summary>
        /// Reason
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reason 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Reason
        {
            get => _reason;
            set
            {
                _reason = value;
                OnPropertyChanged(nameof(Reason));
            }
        }        /// <summary>
        /// Startdate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Startdate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Startdate
        {
            get => _startdate;
            set
            {
                _startdate = value;
                OnPropertyChanged(nameof(Startdate));
            }
        }        /// <summary>
        /// Enddate
        /// </summary>
        /// <remarks>
        /// <para>
        /// Enddate 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirDateTime? Enddate
        {
            get => _enddate;
            set
            {
                _enddate = value;
                OnPropertyChanged(nameof(Enddate));
            }
        }        /// <summary>
        /// 建立新的 ResearchSubject 資源實例
        /// </summary>
        public ResearchSubject()
        {
        }

        /// <summary>
        /// 建立新的 ResearchSubject 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public ResearchSubject(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"ResearchSubject(Id: {Id})";
        }
    }    /// <summary>
    /// ResearchSubjectProgress 背骨元素
    /// </summary>
    public class ResearchSubjectProgress
    {
        // TODO: 添加屬性實作
        
        public ResearchSubjectProgress() { }
    }
}
