using Core.Extension;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class ExtendedContactDetail : ComplexType
    {

        #region Property
        public CodeableConcept? Purpose { get; init; }
        public IEnumerable<HumanName>? Name { get; init; }
        public IEnumerable<ContactPoint>? Telecom { get; init; }
        public Address? Address { get; init; }
        public Reference? Organization { get; init; }
        public Period? Period { get; init; }

        #endregion
        #region Constructor
        public ExtendedContactDetail() { }
        public ExtendedContactDetail(string? value) : this(value.Parse()) { }
        public ExtendedContactDetail(JsonNode? source)
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
                        case "purpose": Purpose = new(cv); break;
                        case "name": Name = cv?.AsArray().Select(x=> new HumanName(x)); break;
                        case "telecom": Telecom = cv?.AsArray().Select(x=> new ContactPoint(x)); break;
                        case "address": Address = new(cv); break;
                        case "organization": Organization = new(cv); break;
                        case "period": Period = new(cv); break;
                        case "_purpose":
                            if (Purpose is CodeableConcept _purpose) SetupExtension(cv, ref _purpose);
                            break;
                        case "_name":
                            if (Name is IEnumerable<HumanName> _name) SetupExtensions(cv, ref _name);
                            break;
                        case "_telecom":
                            if (Telecom is IEnumerable<ContactPoint> _telecom) SetupExtensions(cv, ref _telecom);
                            break;
                        case "_address":
                            if (Address is Address _address) SetupExtension(cv, ref _address);
                            break;
                        case "_organization":
                            if (Organization is Reference _organization) SetupExtension(cv, ref _organization);
                            break;
                        case "_period":
                            if (Period is Period _period) SetupExtension(cv, ref _period);
                            break;
                    }
                }
            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ExtendedContactDetail";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
