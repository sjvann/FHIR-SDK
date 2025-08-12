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
    public class RegulatedAuthorization : ResourceType<RegulatedAuthorization>
	{
		#region private Property
		private List<Identifier>? _identifier;
private List<ReferenceType>? _subject;
private CodeableConcept? _type;
private FhirMarkdown? _description;
private List<CodeableConcept>? _region;
private CodeableConcept? _status;
private FhirDateTime? _statusDate;
private Period? _validityPeriod;
private List<CodeableReference>? _indication;
private CodeableConcept? _intendedUse;
private List<CodeableConcept>? _basis;
private ReferenceType? _holder;
private ReferenceType? _regulator;
private List<ReferenceType>? _attachedDocument;
private RegulatedAuthorizationCase? _case;

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

public List<ReferenceType>? Subject
{
get { return _subject; }
set {
_subject= value;
OnPropertyChanged("subject", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public FhirMarkdown? Description
{
get { return _description; }
set {
_description= value;
OnPropertyChanged("description", value);
}
}

public List<CodeableConcept>? Region
{
get { return _region; }
set {
_region= value;
OnPropertyChanged("region", value);
}
}

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public FhirDateTime? StatusDate
{
get { return _statusDate; }
set {
_statusDate= value;
OnPropertyChanged("statusDate", value);
}
}

public Period? ValidityPeriod
{
get { return _validityPeriod; }
set {
_validityPeriod= value;
OnPropertyChanged("validityPeriod", value);
}
}

public List<CodeableReference>? Indication
{
get { return _indication; }
set {
_indication= value;
OnPropertyChanged("indication", value);
}
}

public CodeableConcept? IntendedUse
{
get { return _intendedUse; }
set {
_intendedUse= value;
OnPropertyChanged("intendedUse", value);
}
}

public List<CodeableConcept>? Basis
{
get { return _basis; }
set {
_basis= value;
OnPropertyChanged("basis", value);
}
}

public ReferenceType? Holder
{
get { return _holder; }
set {
_holder= value;
OnPropertyChanged("holder", value);
}
}

public ReferenceType? Regulator
{
get { return _regulator; }
set {
_regulator= value;
OnPropertyChanged("regulator", value);
}
}

public List<ReferenceType>? AttachedDocument
{
get { return _attachedDocument; }
set {
_attachedDocument= value;
OnPropertyChanged("attachedDocument", value);
}
}

public RegulatedAuthorizationCase? Case
{
get { return _case; }
set {
_case= value;
OnPropertyChanged("case", value);
}
}


		#endregion
		#region Constructor
		public  RegulatedAuthorization() { }
		public  RegulatedAuthorization(string value) : base(value) { }
		public  RegulatedAuthorization(JsonNode? source) : base(source) { }
		#endregion
	}
		public class RegulatedAuthorizationCase : BackboneElementType<RegulatedAuthorizationCase>, IBackboneElementType
	{

		#region Private Method
		private Identifier? _identifier;
private CodeableConcept? _type;
private CodeableConcept? _status;
private RegulatedAuthorizationCaseDateChoice? _date;

		#endregion
		#region public Method
		public Identifier? Identifier
{
get { return _identifier; }
set {
_identifier= value;
OnPropertyChanged("identifier", value);
}
}

public CodeableConcept? Type
{
get { return _type; }
set {
_type= value;
OnPropertyChanged("type", value);
}
}

public CodeableConcept? Status
{
get { return _status; }
set {
_status= value;
OnPropertyChanged("status", value);
}
}

public RegulatedAuthorizationCaseDateChoice? Date
{
get { return _date; }
set {
_date= value;
OnPropertyChanged("date", value);
}
}


		#endregion
		#region Constructor
		public  RegulatedAuthorizationCase() { }
		public  RegulatedAuthorizationCase(string value) : base(value) { }
		public  RegulatedAuthorizationCase(JsonObject? source) : base(source) {}
		#endregion
	}	

	

		    public class RegulatedAuthorizationCaseDateChoice : ChoiceType 
    {
        
        private static readonly List<string> _supportType = [
        "Period","dateTime"
        ];

        public RegulatedAuthorizationCaseDateChoice(JsonObject value) : base("date", value, _supportType)
        {
        }
        public RegulatedAuthorizationCaseDateChoice(IComplexType? value) : base("date", value)
        {
        }
        public RegulatedAuthorizationCaseDateChoice(IPrimitiveType? value) : base("date", value) { }

        public override string GetPrefixName(bool withCapital = true) =>"date".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return  _supportType;
        }
    }
	

}
