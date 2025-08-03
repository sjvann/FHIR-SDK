using DataTypeServices.DataTypes.ComplexTypes;
using DataTypeServices.DataTypes.PrimitiveTypes;
using DataTypeServices.TypeFramework;
using FhirCore.ExtensionMethods;
using FhirCore.Interfaces;
using System.Text.Json.Nodes;


namespace DataTypeServices.DataTypes.MetaTypes
{
    public class DataRequirement : ComplexType<DataRequirement>
    {

        private FhirCode? _type;
        private List<FhirCanonical>? _profile;
        private DataRequirementSubjectChoice? _subject;
        private List<FhirString>? _mustSupport;
        private DataRequirementCodeFilter? _codeFilter;
        private DataRequirementDateFilter? _dateFilter;
        private DataRequirementValueFilter? _valueFilter;
        private FhirPositiveInt? _limit;
        private DataRequirementSort? _sort;

        public FhirCode? Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type", value);
            }
        }
        public List<FhirCanonical>? Profile
        {
            get { return _profile; }
            set
            {
                _profile = value;
                OnPropertyChanged("profile", value);
            }
        }
        public DataRequirementSubjectChoice? Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged("subject", value);
            }
        }
        public List<FhirString>? MustSupport
        {
            get { return _mustSupport; }
            set
            {
                _mustSupport = value;
                OnPropertyChanged("mustSupport", value);
            }
        }
        public DataRequirementCodeFilter? CodeFilter
        {
            get { return _codeFilter; }
            set
            {
                _codeFilter = value;
                OnPropertyChanged("codeFilter", value);
            }
        }
        public DataRequirementDateFilter? DateFilter
        {
            get { return _dateFilter; }
            set
            {
                _dateFilter = value;
                OnPropertyChanged("dateFilter", value);
            }
        }
        public DataRequirementValueFilter? ValueFilter
        {
            get { return _valueFilter; }
            set
            {
                _valueFilter = value;
                OnPropertyChanged("valueFilter", value);
            }
        }
        public FhirPositiveInt? Limit
        {
            get { return _limit; }
            set
            {
                _limit = value;
                OnPropertyChanged("limit", value);
            }
        }
        public DataRequirementSort? Sort
        {
            get { return _sort; }
            set
            {
                _sort = value;
                OnPropertyChanged("sort", value);
            }
        }
        public DataRequirement() : base() { }
        public DataRequirement(JsonObject? value) : base(value) { }
        public DataRequirement(string value) : base(value) { }
    }


    public class DataRequirementSort : ComplexType<DataRequirementSort>
    {
        private FhirString? _path;
        private FhirCode? _direction;

        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }
        public FhirCode? Direction
        {
            get { return _direction; }
            set
            {
                _direction = value;
                OnPropertyChanged("direction", value);
            }
        }
        public DataRequirementSort() : base() { }
        public DataRequirementSort(JsonObject? value) : base(value) { }
        public DataRequirementSort(string value) : base(value) { }
    }

    public class DataRequirementValueFilter : ComplexType<DataRequirementValueFilter>
    {
        private FhirString? _path;
        private FhirString? _searchParam;
        private FhirCode? _comparator;
        private DataRequirementValueChoice? _value;

        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }
        public FhirString? SearchParam
        {
            get { return _searchParam; }
            set
            {
                _searchParam = value;
                OnPropertyChanged("searchParam", value);
            }
        }
        public FhirCode? Comparator
        {
            get { return _comparator; }
            set
            {
                _comparator = value;
                OnPropertyChanged("comparator", value);
            }
        }
        public DataRequirementValueChoice? Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("value", value);
            }
        }
        public DataRequirementValueFilter() : base() { }
        public DataRequirementValueFilter(JsonObject? value) : base(value) { }
        public DataRequirementValueFilter(string value) : base(value) { }
    }

    public class DataRequirementDateFilter : ComplexType<DataRequirementDateFilter>
    {
        private FhirString? _path;
        private FhirString? _searchParam;
        private DataRequirementValueChoice? _value;


        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }
        public FhirString? SearchParam
        {
            get { return _searchParam; }
            set
            {
                _searchParam = value;
                OnPropertyChanged("searchParam", value);
            }
        }
        public DataRequirementValueChoice? Value
        {
            get { return _value; }
            set
            {
                _value = value;
                OnPropertyChanged("value", value);
            }
        }
        public DataRequirementDateFilter() : base() { }
        public DataRequirementDateFilter(JsonObject? value) : base(value) { }
        public DataRequirementDateFilter(string value) : base(value) { }
    }

    public class DataRequirementCodeFilter : ComplexType<DataRequirementCodeFilter>
    {
        private FhirString? _path;
        private FhirString? _searchParam;
        private FhirCanonical? _valueSet;
        private List<DataTypeServices.DataTypes.ComplexTypes.Coding>? _code;

        public FhirString? Path
        {
            get { return _path; }
            set
            {
                _path = value;
                OnPropertyChanged("path", value);
            }
        }
        public FhirString? SearchParam
        {
            get { return _searchParam; }
            set
            {
                _searchParam = value;
                OnPropertyChanged("searchParam", value);
            }
        }
        public FhirCanonical? ValueSet
        {
            get { return _valueSet; }
            set
            {
                _valueSet = value;
                OnPropertyChanged("valueSet", value);
            }
        }
        public List<DataTypeServices.DataTypes.ComplexTypes.Coding>? Code
        {
            get { return _code; }
            set
            {
                _code = value;
                OnPropertyChanged("code", value);
            }
        }

        public DataRequirementCodeFilter() : base() { }
        public DataRequirementCodeFilter(JsonObject? value) : base(value) { }
        public DataRequirementCodeFilter(string value) : base(value) { }
    }


    public class DataRequirementSubjectChoice : ChoiceType
    {
        private static readonly List<string> _supportType = [
"CodeableConcept","Reference"
];

        public DataRequirementSubjectChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public DataRequirementSubjectChoice(IComplexType? value) : base("subject", value)
        {
        }
        public DataRequirementSubjectChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) => "subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }

    public class DataRequirementValueChoice : ChoiceType
    {
        private static readonly List<string> _supportType = [
"dateTime","Period","Duration"
];

        public DataRequirementValueChoice(JsonObject value) : base("subject", value, _supportType)
        {
        }
        public DataRequirementValueChoice(IComplexType? value) : base("subject", value)
        {
        }
        public DataRequirementValueChoice(IPrimitiveType? value) : base("subject", value) { }

        public override string GetPrefixName(bool withCapital = true) => "subject".ToTitleCase(withCapital);

        public override List<string> SetSupportDataType()
        {
            return _supportType;
        }
    }
}
