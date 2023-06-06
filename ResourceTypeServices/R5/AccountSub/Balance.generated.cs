
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.AccountSub
{
    public class Balance : BackboneElement<Balance>
    {

        #region Property
        [Element("aggregate", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Aggregate {get; set;}
[Element("term", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Term {get; set;}
[Element("estimate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Estimate {get; set;}
[Element("amount", typeof(Money), false, false, false, false)]
public Money Amount {get; set;}

        #endregion
        #region Constructor
        public  Balance() { }
        public  Balance(string value) : base(value) { }
        public  Balance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Balance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
