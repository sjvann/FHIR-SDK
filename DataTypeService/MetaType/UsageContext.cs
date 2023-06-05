using Core.Extension;
using DataTypeService.Based;
using DataTypeService.BaseTypes;
using DataTypeService.Choice;
using DataTypeService.Complex;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class UsageContext : ComplexType
    {

        #region Property
        public Coding? Code { get; init; }
        public ChoiceBased? Value { get; init; }
        #endregion
        #region Constructor
        public UsageContext() { }
        public UsageContext(string? value) : this(value.Parse()) { }
        public UsageContext(JsonNode? source)
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
                        case "code":
                            Code = new(cv); break;
                        case "valueCodeableConcept":
                        case "valueQuantity":
                        case "valueRange":
                        case "valueReference":
                            Value = new ChoiceBased(ck,cv); break;
                        case "_code":
                            if (Code is Coding _code)
                            {
                                SetupExtension(cv, ref _code);
                            }
                            break;
                    }
                }

            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "UsageContext";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
