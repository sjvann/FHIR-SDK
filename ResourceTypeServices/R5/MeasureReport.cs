using System.Text.Json.Nodes;
using TerminologyService.ValueSet;
using DataTypeServices.TypeFramework;
using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.DataTypes.SpecialTypes;
using DataTypeServices.DataTypes.MetaTypes;
using Range = DataTypeServices.DataTypes.ComplexTypes.Range;
using FhirCore.Interfaces;
using FhirCore.ExtensionMethods;

namespace ResourceTypeServices.R5
{
    public class MeasureReport : ResourceType<MeasureReport>
	{
		#region private Property
		private List<Identifier>? _identifier;
private FhirCode? _status;
private FhirCode? _type;
private FhirCode? _dataUpdateType;
private FhirCanonical? _measure;
private ReferenceType? _subject;
private FhirDateTime? _date;
private ReferenceType? _reporter;
private ReferenceType? _reportingVendor;
private ReferenceType? _location;
private Period? _period;
private ReferenceType? _inputParameters;
private CodeableConcept? _scoring;
private CodeableConcept? _improvementNotation;
private List<MeasureReportGroup>? _group;
private List<ReferenceType>? _supplementalData;
private List<ReferenceType>? _evaluatedResource;

		#endregion
		#region Public Method
		public List<Identifier>? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public FhirCode? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirCode? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirCode? DataUpdateType
{
get { return _dataUpdateType; }
set {
_dataUpdateType= value;
OnPropertyChanged("dataUpdateType", value);
}
}

public FhirCanonical? Measure
{
get { return _measure; }
set {
_measure= value;
OnPropertyChanged("measure", value);
}
}

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public FhirDateTime? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}

public ReferenceType? Reporter
{
get { return _reporter; }
set {
_reporter= value;
OnPropertyChanged("reporter", value);
}
}

public ReferenceType? ReportingVendor
{
get { return _reportingVendor; }
set {
_reportingVendor= value;
OnPropertyChanged("reportingVendor", value);
}
}

public ReferenceType? Location
{
get { return _location; }
set {
_location= value;
OnPropertyChanged("location", value);
}
}

public Period? Period
{
get { return _period; }
set {
_period= value;
OnPropertyChanged("period", value);
}
}

public ReferenceType? InputParameters
{
get { return _inputParameters; }
set {
_inputParameters= value;
OnPropertyChanged("inputParameters", value);
}
}

public CodeableConcept? Scoring
{
get { return _scoring; }
set {
_scoring= value;
OnPropertyChanged("scoring", value);
}
}

public CodeableConcept? ImprovementNotation
{
get { return _improvementNotation; }
set {
_improvementNotation= value;
OnPropertyChanged("improvementNotation", value);
}
}

public List<MeasureReportGroup>? Group
{
get { return _group; }
set {
_group= value;
OnPropertyChanged("group", value);
}
}

public List<ReferenceType>? SupplementalData
{
get { return _supplementalData; }
set {
_supplementalData= value;
OnPropertyChanged("supplementalData", value);
}
}

public List<ReferenceType>? EvaluatedResource
{
get { return _evaluatedResource; }
set {
_evaluatedResource= value;
OnPropertyChanged("evaluatedResource", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReport() { }
		public  MeasureReport(string value) : base(value) { }
		public  MeasureReport(JsonNode? source) : base(source) { }
		#endregion
	}
		public class MeasureReportGroupPopulation : BackboneElementType<MeasureReportGroupPopulation>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private FhirInteger? _count;
private ReferenceType? _subjectResults;
private List<ReferenceType>? _subjectReport;
private ReferenceType? _subjects;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirInteger? Count
{
get { return _count; }
set {
_count= value;
OnPropertyChanged("count", value);
}
}

public ReferenceType? SubjectResults
{
get { return _subjectResults; }
set {
_subjectResults= value;
OnPropertyChanged("subjectResults", value);
}
}

public List<ReferenceType>? SubjectReport
{
get { return _subjectReport; }
set {
_subjectReport= value;
OnPropertyChanged("subjectReport", value);
}
}

public ReferenceType? Subjects
{
get { return _subjects; }
set {
_subjects= value;
OnPropertyChanged("subjects", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReportGroupPopulation() { }
		public  MeasureReportGroupPopulation(string value) : base(value) { }
		public  MeasureReportGroupPopulation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureReportGroupStratifierStratumComponent : BackboneElementType<MeasureReportGroupStratifierStratumComponent>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private MeasureReportGroupStratifierStratumComponentValueChoice? _value;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public MeasureReportGroupStratifierStratumComponentValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReportGroupStratifierStratumComponent() { }
		public  MeasureReportGroupStratifierStratumComponent(string value) : base(value) { }
		public  MeasureReportGroupStratifierStratumComponent(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureReportGroupStratifierStratumPopulation : BackboneElementType<MeasureReportGroupStratifierStratumPopulation>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private FhirInteger? _count;
private ReferenceType? _subjectResults;
private List<ReferenceType>? _subjectReport;
private ReferenceType? _subjects;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public FhirInteger? Count
{
get { return _count; }
set {
_count= value;
OnPropertyChanged("count", value);
}
}

public ReferenceType? SubjectResults
{
get { return _subjectResults; }
set {
_subjectResults= value;
OnPropertyChanged("subjectResults", value);
}
}

public List<ReferenceType>? SubjectReport
{
get { return _subjectReport; }
set {
_subjectReport= value;
OnPropertyChanged("subjectReport", value);
}
}

public ReferenceType? Subjects
{
get { return _subjects; }
set {
_subjects= value;
OnPropertyChanged("subjects", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReportGroupStratifierStratumPopulation() { }
		public  MeasureReportGroupStratifierStratumPopulation(string value) : base(value) { }
		public  MeasureReportGroupStratifierStratumPopulation(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureReportGroupStratifierStratum : BackboneElementType<MeasureReportGroupStratifierStratum>, IBackboneElementType
	{

		#region Private Method
		private MeasureReportGroupStratifierStratumValueChoice? _value;
private List<MeasureReportGroupStratifierStratumComponent>? _component;
private List<MeasureReportGroupStratifierStratumPopulation>? _population;
private MeasureReportGroupStratifierStratumMeasureScoreChoice? _measureScore;

		#endregion
		#region public Method
		public MeasureReportGroupStratifierStratumValueChoice? Value
{
get { return _value; }
set {
_value= value;
OnPropertyChanged("value", value);
}
}

public List<MeasureReportGroupStratifierStratumComponent>? Component
{
get { return _component; }
set {
_component= value;
OnPropertyChanged("component", value);
}
}

public List<MeasureReportGroupStratifierStratumPopulation>? Population
{
get { return _population; }
set {
_population= value;
OnPropertyChanged("population", value);
}
}

public MeasureReportGroupStratifierStratumMeasureScoreChoice? MeasureScore
{
get { return _measureScore; }
set {
_measureScore= value;
OnPropertyChanged("measureScore", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReportGroupStratifierStratum() { }
		public  MeasureReportGroupStratifierStratum(string value) : base(value) { }
		public  MeasureReportGroupStratifierStratum(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureReportGroupStratifier : BackboneElementType<MeasureReportGroupStratifier>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private List<MeasureReportGroupStratifierStratum>? _stratum;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<MeasureReportGroupStratifierStratum>? Stratum
{
get { return _stratum; }
set {
_stratum= value;
OnPropertyChanged("stratum", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReportGroupStratifier() { }
		public  MeasureReportGroupStratifier(string value) : base(value) { }
		public  MeasureReportGroupStratifier(JsonObject? source) : base(source) {}
		#endregion
	}	

		public class MeasureReportGroup : BackboneElementType<MeasureReportGroup>, IBackboneElementType
	{

		#region Private Method
		private FhirString? _linkId;
private CodeableConcept? _code;
private ReferenceType? _subject;
private List<MeasureReportGroupPopulation>? _population;
private MeasureReportGroupMeasureScoreChoice? _measureScore;
private List<MeasureReportGroupStratifier>? _stratifier;

		#endregion
		#region public Method
		public FhirString? LinkId
{
get { return _linkId; }
set {
_linkId= value;
OnPropertyChanged("linkId", value);
}
}

public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public ReferenceType? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public List<MeasureReportGroupPopulation>? Population
{
get { return _population; }
set {
_population= value;
OnPropertyChanged("population", value);
}
}

public MeasureReportGroupMeasureScoreChoice? MeasureScore
{
get { return _measureScore; }
set {
_measureScore= value;
OnPropertyChanged("measureScore", value);
}
}

public List<MeasureReportGroupStratifier>? Stratifier
{
get { return _stratifier; }
set {
_stratifier= value;
OnPropertyChanged("stratifier", value);
}
}


		#endregion
		#region Constructor
		public  MeasureReportGroup() { }
		public  MeasureReportGroup(string value) : base(value) { }
		public  MeasureReportGroup(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class MeasureReportGroupMeasureScoreChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","dateTimeCodeableConceptPeriodRangeDuration"
        ];

        public MeasureReportGroupMeasureScoreChoice(JsonObject value) : base("measureScore", value, _supportType)
        {
        }
        public MeasureReportGroupMeasureScoreChoice(IComplexType? value) : base("measureScore", value)
        {
        }
        public MeasureReportGroupMeasureScoreChoice(IPrimitiveType? value) : base("measureScore", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"measureScore".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MeasureReportGroupStratifierStratumValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","booleanQuantityRangeReference"
        ];

        public MeasureReportGroupStratifierStratumValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public MeasureReportGroupStratifierStratumValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public MeasureReportGroupStratifierStratumValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MeasureReportGroupStratifierStratumComponentValueChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "CodeableConcept","booleanQuantityRangeReference"
        ];

        public MeasureReportGroupStratifierStratumComponentValueChoice(JsonObject value) : base("value", value, _supportType)
        {
        }
        public MeasureReportGroupStratifierStratumComponentValueChoice(IComplexType? value) : base("value", value)
        {
        }
        public MeasureReportGroupStratifierStratumComponentValueChoice(IPrimitiveType? value) : base("value", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"value".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	    public class MeasureReportGroupStratifierStratumMeasureScoreChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Quantity","dateTimeCodeableConceptPeriodRangeDuration"
        ];

        public MeasureReportGroupStratifierStratumMeasureScoreChoice(JsonObject value) : base("measureScore", value, _supportType)
        {
        }
        public MeasureReportGroupStratifierStratumMeasureScoreChoice(IComplexType? value) : base("measureScore", value)
        {
        }
        public MeasureReportGroupStratifierStratumMeasureScoreChoice(IPrimitiveType? value) : base("measureScore", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"measureScore".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
