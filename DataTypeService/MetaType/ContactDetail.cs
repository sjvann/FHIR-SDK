using Core.Extension;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class ContactDetail : ComplexType
    {

        #region Property
        public FhirString? Name { get; init; }
        public IEnumerable<ContactPoint>? Telecom { get; init; }
        #endregion
        #region Constructor
        public ContactDetail() { }
        public ContactDetail(string? value) : this(value.Parse()) { }
        public ContactDetail(JsonNode? source)
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
                        case "name": Name = new(cv); break;
                        case "telecom": Telecom = cv?.AsArray().Select(x => new ContactPoint(x)); break;

                        case "_name":
                            if (Name is FhirString _name) SetupExtension(cv, ref _name);
                            break;
                        case "_telecom":
                            if (Telecom is IEnumerable<ContactPoint> _telecom)
                            {

                                SetupExtensions(cv, ref _telecom);
                            }
                            break;
                    }
                }


            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ContactDetail";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
