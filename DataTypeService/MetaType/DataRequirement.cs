using Core.Extension;
using DataTypeService.BaseTypes;
using DataTypeService.Choice;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class DataRequirement : ComplexType
    {

        #region Property
        public FhirCode? Type { get; init; }
        public IEnumerable<FhirCanonical>? Profile { get; init; }
        public ChoiceBased? Subject { get; set; }
        public IEnumerable<FhirString>? MustSupport { get; init; }
        public IEnumerable<CodeFilter>? CodeFilter { get; init; }
        public IEnumerable<DateFilter>? DateFilter { get; init; }
        public IEnumerable<ValueFilter>? ValueFilter { get; init; }
        public FhirPositiveInt? Limit { get; init; }
        public IEnumerable<Sort>? Sort { get; init; }

        #endregion
        #region Constructor
        public DataRequirement() { }
        public DataRequirement(string? value) : this(value.Parse()) { }
        public DataRequirement(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "type": Type = new(cv); break;
                        case "profile": Profile = cv?.AsArray().Select(x => new FhirCanonical(x)); break;
                        case "subject": Subject = new(ck,cv); break;
                        case "mustSupport": MustSupport = cv?.AsArray().Select(x => new FhirString(x)); break;
                        case "codeFilter": CodeFilter = cv?.AsArray().Select(x => new CodeFilter(x)); break;
                        case "dateFilter": DateFilter = cv?.AsArray().Select(x => new DateFilter(x)); break;
                        case "valueFilter": ValueFilter = cv?.AsArray().Select(x => new ValueFilter(x)); break;
                        case "limit": Limit = new(cv); break;
                        case "sort": Sort = cv?.AsArray().Select(x => new Sort(x)); break;
                        case "_type":
                            if (Type is FhirCode _type) SetupExtension(cv, ref _type);
                            break;
                        case "_profile":
                            if (Profile is IEnumerable<FhirCanonical> _profile) SetupExtensions(cv, ref _profile);
                            break;
                        case "_mustSupport":
                            if (MustSupport is IEnumerable<FhirString> _mustSupport) SetupExtensions(cv, ref _mustSupport);
                            break;
                        case "_codeFilter":
                            if (CodeFilter is IEnumerable<CodeFilter> _codeFilter) SetupExtensions(cv, ref _codeFilter);
                            break;
                        case "_dateFilter":
                            if (DateFilter is IEnumerable<DateFilter> _dateFilter) SetupExtensions(cv, ref _dateFilter);
                            break;
                        case "_valueFilter":
                            if (ValueFilter is IEnumerable<ValueFilter> _valueFilter) SetupExtensions(cv, ref _valueFilter);
                            break;
                        case "_limit":
                            if (Limit is FhirPositiveInt _limit) SetupExtension(cv, ref _limit);
                            break;
                        case "_sort":
                            if (Sort is IEnumerable<Sort> _sort) SetupExtensions(cv, ref _sort);
                            break;
                    }
                }
            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "DataRequirement";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }

    public class CodeFilter : Element
    {

        #region Property
        public FhirString? Path { get; init; }
        public FhirString? SearchParam { get; init; }
        public FhirCanonical? ValueSet { get; init; }
        public IEnumerable<Coding>? Code { get; init; }
        #endregion
        #region Constructor
        public CodeFilter() { }
        public CodeFilter(string? value) : this(value.Parse()) { }
        public CodeFilter(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "path": Path = new(cv); break;
                        case "searchParam": SearchParam = new(cv); break;
                        case "valueSet": ValueSet = new(cv); break;
                        case "code":
                            Code = cv?.AsArray().Select(x => new Coding(x));
                            break;
                    }
                }
            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "CodeFilter";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

    public class DateFilter : Element
    {

        #region Property
        public FhirString? Path { get; init; }
        public FhirString? SearchParam { get; init; }
        public ChoiceBased? Value { get; init; }
        #endregion
        #region Constructor
        public DateFilter() { }
        public DateFilter(string? value) : this(value.Parse()) { }
        public DateFilter(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "path": Path = new(cv); break;
                        case "searchParam": SearchParam = new(cv); break;
                        case "valueDateTime":
                        case "valuePeriod":
                        case "valueDuration":
                            Value = new(ck, cv); break;
                        case "_path":
                            if (Path is FhirString _path) SetupExtension(cv, ref _path);
                            break;
                        case "_searchParam":
                            if (SearchParam is FhirString _searchParam) SetupExtension(cv, ref _searchParam);
                            break;
                    }
                }


            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "DateFilter";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }

    public class ValueFilter : Element
    {

        #region Property
        public FhirString? Path { get; init; }
        public FhirString? SearchParam { get; init; }
        public FhirCode? Comparator { get; init; }
        public ChoiceBased? Value { get; init; }
        #endregion
        #region Constructor
        public ValueFilter() { }
        public ValueFilter(string? value) : this(value.Parse()) { }
        public ValueFilter(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "path": Path = new(cv); break;
                        case "searchParam": SearchParam = new(cv); break;
                        case "comparator": Comparator = new(cv); break;
                        case "valueDateTime":
                        case "valuePeriod":
                        case "valueDuration":
                            Value = new(ck, cv); break;
                        case "_path":
                            if (Path is FhirString _path) SetupExtension(cv, ref _path);
                            break;
                        case "_searchParam":
                            if (SearchParam is FhirString _searchParam) SetupExtension(cv, ref _searchParam);
                            break;
                        case "_comparator":
                            if (Comparator is FhirCode _comparator) SetupExtension(cv, ref _comparator);
                            break;

                    }
                }


            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ValueFilter";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

    public class Sort : Element
    {

        #region Property
        public FhirString? Path { get; init; }
        public FhirCode? Direction { get; init; }
        #endregion
        #region Constructor
        public Sort() { }
        public Sort(string? value) : this(value.Parse()) { }
        public Sort(JsonNode? source)
        {
            _JsonNode = source;
            if (source != null)
            {
                var values = source.AsObject().GetEnumerator();
                while (values.MoveNext())
                {
                    var ck = values.Current.Key;
                    var cv = values.Current.Value;
                    switch (ck)
                    {
                        case "path": Path = new(cv); break;
                        case "direction": Direction = new(cv); break;
                        case "_path":
                            if (Path is FhirString _path) SetupExtension(cv, ref _path);
                            break;
                        case "_direction":
                            if (Direction is FhirCode _direction) SetupExtension(cv, ref _direction);
                            break;
                    }
                }
            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "Sort";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

}
