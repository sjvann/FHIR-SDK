using Core.Attribute;
using DataTypeService.BaseTypes;
using DataTypeService.Primitive;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class MonetaryComponent : ComplexType<MonetaryComponent>
    {

        #region Property
        [Element("type", typeof(FhirCode), true, false, false, false)]
        public FhirCode? Type { get; set; }
        [Element("code", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Code { get; set; }
        [Element("factor", typeof(FhirDecimal), true, false, false, false)]
        public FhirDecimal? Factor { get; set; }
        [Element("amount", typeof(Money), false, false, false, false)]
        public Money? Amount { get; set; }
        #endregion
        #region Constructor
        public MonetaryComponent() { }
        public MonetaryComponent(string? value) : base(value) { }
        public MonetaryComponent(JsonNode? source) : base(source) { }

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
