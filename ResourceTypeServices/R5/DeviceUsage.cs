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
    public class DeviceUsage : ResourceType<DeviceUsage>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _basedOn;
private FhirCode? _status;
private List<CodeableConcept>? _category;
private ReferenceType? _patient;
private List<ReferenceType>? _derivedFrom;
private ReferenceType? _context;
private DeviceUsageTimingChoice? _timing;
private FhirDateTime? _dateAsserted;
private CodeableConcept? _usageStatus;
private List<CodeableConcept>? _usageReason;
private DeviceUsageAdherence? _adherence;
private ReferenceType? _informationSource;
private CodeableReference? _device;
private List<CodeableReference>? _reason;
private CodeableReference? _bodySite;
private List<Annotation>? _note;

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

public List<ReferenceType>? BasedOn
{
get { return _basedOn; }
set {
_basedOn= value;
OnPropertyChanged("basedOn", value);
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

public List<CodeableConcept>? Category
{
get { return _category; }
set {
_category= value;
OnPropertyChanged("category", value);
}
}

public ReferenceType? Patient
{
get { return _patient; }
set {
_patient= value;
OnPropertyChanged("patient", value);
}
}

public List<ReferenceType>? DerivedFrom
{
get { return _derivedFrom; }
set {
_derivedFrom= value;
OnPropertyChanged("derivedFrom", value);
}
}

public ReferenceType? Context
{
get { return _context; }
set {
_context= value;
OnPropertyChanged("context", value);
}
}

public DeviceUsageTimingChoice? Timing
{
get { return _timing; }
set {
_timing= value;
OnPropertyChanged("timing", value);
}
}

public FhirDateTime? DateAsserted
{
get { return _dateAsserted; }
set {
_dateAsserted= value;
OnPropertyChanged("dateAsserted", value);
}
}

public CodeableConcept? UsageStatus
{
get { return _usageStatus; }
set {
_usageStatus= value;
OnPropertyChanged("usageStatus", value);
}
}

public List<CodeableConcept>? UsageReason
{
get { return _usageReason; }
set {
_usageReason= value;
OnPropertyChanged("usageReason", value);
}
}

public DeviceUsageAdherence? Adherence
{
get { return _adherence; }
set {
_adherence= value;
OnPropertyChanged("adherence", value);
}
}

public ReferenceType? InformationSource
{
get { return _informationSource; }
set {
_informationSource= value;
OnPropertyChanged("informationSource", value);
}
}

public CodeableReference? Device
{
get { return _device; }
set {
_device= value;
OnPropertyChanged("device", value);
}
}

public List<CodeableReference>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}

public CodeableReference? BodySite
{
get { return _bodySite; }
set {
_bodySite= value;
OnPropertyChanged("bodySite", value);
}
}

public List<Annotation>? Note
{
get { return _note; }
set {
_note= value;
OnPropertyChanged("note", value);
}
}


		#endregion
		#region Constructor
		public  DeviceUsage() { }
		public  DeviceUsage(string value) : base(value) { }
		public  DeviceUsage(JsonNode? source) : base(source) { }
		#endregion
	}
		public class DeviceUsageAdherence : BackboneElementType<DeviceUsageAdherence>, IBackboneElementType
	{

		#region Private Method
		private CodeableConcept? _code;
private List<CodeableConcept>? _reason;

		#endregion
		#region public Method
		public CodeableConcept? Code
{
get { return _code; }
set {
_code= value;
OnPropertyChanged("code", value);
}
}

public List<CodeableConcept>? Reason
{
get { return _reason; }
set {
_reason= value;
OnPropertyChanged("reason", value);
}
}


		#endregion
		#region Constructor
		public  DeviceUsageAdherence() { }
		public  DeviceUsageAdherence(string value) : base(value) { }
		public  DeviceUsageAdherence(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class DeviceUsageTimingChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Timing","PerioddateTime"
        ];

        public DeviceUsageTimingChoice(JsonObject value) : base("timing", value, _supportType)
        {
        }
        public DeviceUsageTimingChoice(IComplexType? value) : base("timing", value)
        {
        }
        public DeviceUsageTimingChoice(IPrimitiveType? value) : base("timing", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"timing".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
