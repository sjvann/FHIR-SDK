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
    /// FHIR R5 MeasureReport 資源
    /// 
    /// <para>
    /// MeasureReport 資源的詳細描述將在此處添加。
    /// 這是 FHIR R5 標準中的重要資源類型。
    /// </para>
    /// 
    /// <example>
    /// <code>
    /// var measurereport = new MeasureReport("measurereport-001");
    /// // 設定資源屬性...
    /// </code>
    /// </example>
    /// </summary>
    /// <remarks>
    /// <para>
    /// R5 版本的 MeasureReport 資源具有以下特點：
    /// - 增強的資料結構
    /// - 改進的驗證規則  
    /// - 更好的互操作性
    /// </para>
    /// </remarks>
    public class MeasureReport : ResourceBase<R5Version>
    {
        private Property
		private List<Identifier>? _identifier;
        private FhirCode? _status;
        private FhirCode? _type;
        private FhirCode? _dataupdatetype;
        private FhirCanonical? _measure;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private FhirDateTime? _date;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reporter;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _reportingvendor;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _location;
        private Period? _period;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _inputparameters;
        private CodeableConcept? _scoring;
        private CodeableConcept? _improvementnotation;
        private List<MeasureReportGroup>? _group;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _supplementaldata;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _evaluatedresource;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private FhirInteger? _count;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subjectresults;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subjectreport;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subjects;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private MeasureReportGroupStratifierStratumComponentValueChoice? _value;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private FhirInteger? _count;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subjectresults;
        private List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? _subjectreport;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subjects;
        private MeasureReportGroupStratifierStratumValueChoice? _value;
        private List<MeasureReportGroupStratifierStratumComponent>? _component;
        private List<MeasureReportGroupStratifierStratumPopulation>? _population;
        private MeasureReportGroupStratifierStratumMeasureScoreChoice? _measurescore;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private List<MeasureReportGroupStratifierStratum>? _stratum;
        private FhirString? _linkid;
        private CodeableConcept? _code;
        private DataTypeServices.DataTypes.SpecialTypes.ReferenceType? _subject;
        private List<MeasureReportGroupPopulation>? _population;
        private MeasureReportGroupMeasureScoreChoice? _measurescore;
        private List<MeasureReportGroupStratifier>? _stratifier;

        /// <summary>
        /// 資源類型
        /// </summary>
        public override string ResourceType => "MeasureReport";        /// <summary>
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
        /// Dataupdatetype
        /// </summary>
        /// <remarks>
        /// <para>
        /// Dataupdatetype 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCode? Dataupdatetype
        {
            get => _dataupdatetype;
            set
            {
                _dataupdatetype = value;
                OnPropertyChanged(nameof(Dataupdatetype));
            }
        }        /// <summary>
        /// Measure
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measure 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirCanonical? Measure
        {
            get => _measure;
            set
            {
                _measure = value;
                OnPropertyChanged(nameof(Measure));
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
        /// Reporter
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reporter 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reporter
        {
            get => _reporter;
            set
            {
                _reporter = value;
                OnPropertyChanged(nameof(Reporter));
            }
        }        /// <summary>
        /// Reportingvendor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Reportingvendor 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Reportingvendor
        {
            get => _reportingvendor;
            set
            {
                _reportingvendor = value;
                OnPropertyChanged(nameof(Reportingvendor));
            }
        }        /// <summary>
        /// Location
        /// </summary>
        /// <remarks>
        /// <para>
        /// Location 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Location
        {
            get => _location;
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
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
        /// Inputparameters
        /// </summary>
        /// <remarks>
        /// <para>
        /// Inputparameters 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Inputparameters
        {
            get => _inputparameters;
            set
            {
                _inputparameters = value;
                OnPropertyChanged(nameof(Inputparameters));
            }
        }        /// <summary>
        /// Scoring
        /// </summary>
        /// <remarks>
        /// <para>
        /// Scoring 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Scoring
        {
            get => _scoring;
            set
            {
                _scoring = value;
                OnPropertyChanged(nameof(Scoring));
            }
        }        /// <summary>
        /// Improvementnotation
        /// </summary>
        /// <remarks>
        /// <para>
        /// Improvementnotation 的詳細描述。
        /// </para>
        /// </remarks>
        public CodeableConcept? Improvementnotation
        {
            get => _improvementnotation;
            set
            {
                _improvementnotation = value;
                OnPropertyChanged(nameof(Improvementnotation));
            }
        }        /// <summary>
        /// Group
        /// </summary>
        /// <remarks>
        /// <para>
        /// Group 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureReportGroup>? Group
        {
            get => _group;
            set
            {
                _group = value;
                OnPropertyChanged(nameof(Group));
            }
        }        /// <summary>
        /// Supplementaldata
        /// </summary>
        /// <remarks>
        /// <para>
        /// Supplementaldata 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Supplementaldata
        {
            get => _supplementaldata;
            set
            {
                _supplementaldata = value;
                OnPropertyChanged(nameof(Supplementaldata));
            }
        }        /// <summary>
        /// Evaluatedresource
        /// </summary>
        /// <remarks>
        /// <para>
        /// Evaluatedresource 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Evaluatedresource
        {
            get => _evaluatedresource;
            set
            {
                _evaluatedresource = value;
                OnPropertyChanged(nameof(Evaluatedresource));
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
        /// Count
        /// </summary>
        /// <remarks>
        /// <para>
        /// Count 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }        /// <summary>
        /// Subjectresults
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjectresults 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subjectresults
        {
            get => _subjectresults;
            set
            {
                _subjectresults = value;
                OnPropertyChanged(nameof(Subjectresults));
            }
        }        /// <summary>
        /// Subjectreport
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjectreport 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Subjectreport
        {
            get => _subjectreport;
            set
            {
                _subjectreport = value;
                OnPropertyChanged(nameof(Subjectreport));
            }
        }        /// <summary>
        /// Subjects
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjects 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subjects
        {
            get => _subjects;
            set
            {
                _subjects = value;
                OnPropertyChanged(nameof(Subjects));
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
        public MeasureReportGroupStratifierStratumComponentValueChoice? Value
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
        /// Count
        /// </summary>
        /// <remarks>
        /// <para>
        /// Count 的詳細描述。
        /// </para>
        /// </remarks>
        public FhirInteger? Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }        /// <summary>
        /// Subjectresults
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjectresults 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subjectresults
        {
            get => _subjectresults;
            set
            {
                _subjectresults = value;
                OnPropertyChanged(nameof(Subjectresults));
            }
        }        /// <summary>
        /// Subjectreport
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjectreport 的詳細描述。
        /// </para>
        /// </remarks>
        public List<DataTypeServices.DataTypes.SpecialTypes.ReferenceType>? Subjectreport
        {
            get => _subjectreport;
            set
            {
                _subjectreport = value;
                OnPropertyChanged(nameof(Subjectreport));
            }
        }        /// <summary>
        /// Subjects
        /// </summary>
        /// <remarks>
        /// <para>
        /// Subjects 的詳細描述。
        /// </para>
        /// </remarks>
        public DataTypeServices.DataTypes.SpecialTypes.ReferenceType? Subjects
        {
            get => _subjects;
            set
            {
                _subjects = value;
                OnPropertyChanged(nameof(Subjects));
            }
        }        /// <summary>
        /// Value
        /// </summary>
        /// <remarks>
        /// <para>
        /// Value 的詳細描述。
        /// </para>
        /// </remarks>
        public MeasureReportGroupStratifierStratumValueChoice? Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
            }
        }        /// <summary>
        /// Component
        /// </summary>
        /// <remarks>
        /// <para>
        /// Component 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureReportGroupStratifierStratumComponent>? Component
        {
            get => _component;
            set
            {
                _component = value;
                OnPropertyChanged(nameof(Component));
            }
        }        /// <summary>
        /// Population
        /// </summary>
        /// <remarks>
        /// <para>
        /// Population 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureReportGroupStratifierStratumPopulation>? Population
        {
            get => _population;
            set
            {
                _population = value;
                OnPropertyChanged(nameof(Population));
            }
        }        /// <summary>
        /// Measurescore
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measurescore 的詳細描述。
        /// </para>
        /// </remarks>
        public MeasureReportGroupStratifierStratumMeasureScoreChoice? Measurescore
        {
            get => _measurescore;
            set
            {
                _measurescore = value;
                OnPropertyChanged(nameof(Measurescore));
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
        /// Stratum
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stratum 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureReportGroupStratifierStratum>? Stratum
        {
            get => _stratum;
            set
            {
                _stratum = value;
                OnPropertyChanged(nameof(Stratum));
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
        /// Population
        /// </summary>
        /// <remarks>
        /// <para>
        /// Population 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureReportGroupPopulation>? Population
        {
            get => _population;
            set
            {
                _population = value;
                OnPropertyChanged(nameof(Population));
            }
        }        /// <summary>
        /// Measurescore
        /// </summary>
        /// <remarks>
        /// <para>
        /// Measurescore 的詳細描述。
        /// </para>
        /// </remarks>
        public MeasureReportGroupMeasureScoreChoice? Measurescore
        {
            get => _measurescore;
            set
            {
                _measurescore = value;
                OnPropertyChanged(nameof(Measurescore));
            }
        }        /// <summary>
        /// Stratifier
        /// </summary>
        /// <remarks>
        /// <para>
        /// Stratifier 的詳細描述。
        /// </para>
        /// </remarks>
        public List<MeasureReportGroupStratifier>? Stratifier
        {
            get => _stratifier;
            set
            {
                _stratifier = value;
                OnPropertyChanged(nameof(Stratifier));
            }
        }        /// <summary>
        /// 建立新的 MeasureReport 資源實例
        /// </summary>
        public MeasureReport()
        {
        }

        /// <summary>
        /// 建立新的 MeasureReport 資源實例
        /// </summary>
        /// <param name="id">資源的唯一識別碼</param>
        public MeasureReport(string id)
        {
            Id = id;
        }

        /// <summary>
        /// 轉換為字串表示
        /// </summary>
        public override string ToString()
        {
            return $"MeasureReport(Id: {Id})";
        }
    }    /// <summary>
    /// MeasureReportGroupPopulation 背骨元素
    /// </summary>
    public class MeasureReportGroupPopulation
    {
        // TODO: 添加屬性實作
        
        public MeasureReportGroupPopulation() { }
    }    /// <summary>
    /// MeasureReportGroupStratifierStratumComponent 背骨元素
    /// </summary>
    public class MeasureReportGroupStratifierStratumComponent
    {
        // TODO: 添加屬性實作
        
        public MeasureReportGroupStratifierStratumComponent() { }
    }    /// <summary>
    /// MeasureReportGroupStratifierStratumPopulation 背骨元素
    /// </summary>
    public class MeasureReportGroupStratifierStratumPopulation
    {
        // TODO: 添加屬性實作
        
        public MeasureReportGroupStratifierStratumPopulation() { }
    }    /// <summary>
    /// MeasureReportGroupStratifierStratum 背骨元素
    /// </summary>
    public class MeasureReportGroupStratifierStratum
    {
        // TODO: 添加屬性實作
        
        public MeasureReportGroupStratifierStratum() { }
    }    /// <summary>
    /// MeasureReportGroupStratifier 背骨元素
    /// </summary>
    public class MeasureReportGroupStratifier
    {
        // TODO: 添加屬性實作
        
        public MeasureReportGroupStratifier() { }
    }    /// <summary>
    /// MeasureReportGroup 背骨元素
    /// </summary>
    public class MeasureReportGroup
    {
        // TODO: 添加屬性實作
        
        public MeasureReportGroup() { }
    }    /// <summary>
    /// MeasureReportGroupMeasureScoreChoice 選擇類型
    /// </summary>
    public class MeasureReportGroupMeasureScoreChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureReportGroupMeasureScoreChoice(JsonObject value) : base("measurereportgroupmeasurescore", value, _supportType) { }
        public MeasureReportGroupMeasureScoreChoice(IComplexType? value) : base("measurereportgroupmeasurescore", value) { }
        public MeasureReportGroupMeasureScoreChoice(IPrimitiveType? value) : base("measurereportgroupmeasurescore", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureReportGroupMeasureScore" : "measurereportgroupmeasurescore";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MeasureReportGroupStratifierStratumValueChoice 選擇類型
    /// </summary>
    public class MeasureReportGroupStratifierStratumValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureReportGroupStratifierStratumValueChoice(JsonObject value) : base("measurereportgroupstratifierstratumvalue", value, _supportType) { }
        public MeasureReportGroupStratifierStratumValueChoice(IComplexType? value) : base("measurereportgroupstratifierstratumvalue", value) { }
        public MeasureReportGroupStratifierStratumValueChoice(IPrimitiveType? value) : base("measurereportgroupstratifierstratumvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureReportGroupStratifierStratumValue" : "measurereportgroupstratifierstratumvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MeasureReportGroupStratifierStratumComponentValueChoice 選擇類型
    /// </summary>
    public class MeasureReportGroupStratifierStratumComponentValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureReportGroupStratifierStratumComponentValueChoice(JsonObject value) : base("measurereportgroupstratifierstratumcomponentvalue", value, _supportType) { }
        public MeasureReportGroupStratifierStratumComponentValueChoice(IComplexType? value) : base("measurereportgroupstratifierstratumcomponentvalue", value) { }
        public MeasureReportGroupStratifierStratumComponentValueChoice(IPrimitiveType? value) : base("measurereportgroupstratifierstratumcomponentvalue", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureReportGroupStratifierStratumComponentValue" : "measurereportgroupstratifierstratumcomponentvalue";
        public override List<string> SetSupportDataType() => _supportType;
    }    /// <summary>
    /// MeasureReportGroupStratifierStratumMeasureScoreChoice 選擇類型
    /// </summary>
    public class MeasureReportGroupStratifierStratumMeasureScoreChoice : ChoiceType
    {
        private static readonly List<string> _supportType = new() { "string", "dateTime" };

        public MeasureReportGroupStratifierStratumMeasureScoreChoice(JsonObject value) : base("measurereportgroupstratifierstratummeasurescore", value, _supportType) { }
        public MeasureReportGroupStratifierStratumMeasureScoreChoice(IComplexType? value) : base("measurereportgroupstratifierstratummeasurescore", value) { }
        public MeasureReportGroupStratifierStratumMeasureScoreChoice(IPrimitiveType? value) : base("measurereportgroupstratifierstratummeasurescore", value) { }

        public override string GetPrefixName(bool withCapital = true) => withCapital ? "MeasureReportGroupStratifierStratumMeasureScore" : "measurereportgroupstratifierstratummeasurescore";
        public override List<string> SetSupportDataType() => _supportType;
    }
}
