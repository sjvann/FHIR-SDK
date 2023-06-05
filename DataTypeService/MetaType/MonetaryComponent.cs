using Core.Extension;
using DataTypeService.Based;
using DataTypeService.BaseTypes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.MetaType
{
    public class MonetaryComponent : ComplexType
    {

        #region Property
        public FhirCode? Type { get; set; }
        public CodeableConcept? Code { get; set; }
        public FhirDecimal? Factor { get; set; }
        public Money? Amount { get; set; }
        #endregion
        #region Constructor
        public MonetaryComponent() { }
        public MonetaryComponent(string? value) : this(value.Parse()) { }
        public MonetaryComponent(JsonNode? source)
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
                        case "code": Code = new(cv); break;
                        case "factor": Factor = new(cv); break;
                        case "amount": Amount = new(cv); break;
                        case "_type":
                            if (Type is FhirCode _type) SetupExtension(cv, ref _type);
                            break;
                        case "_code":
                            if (Code is CodeableConcept _code) SetupExtension(cv, ref _code);
                            break;
                        case "_factor":
                            if (Factor is FhirDecimal _factor) SetupExtension(cv, ref _factor);
                            break;
                        case "_amount":
                            if (Amount is Money _amount) SetupExtension(cv, ref _amount);
                            break;
                    }
                }

            }

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "MonetaryComponent";
        #endregion

        #region Public Method
        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }

}
