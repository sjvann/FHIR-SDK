using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace DataTypeService.Complex
{
    public class ProductShelfLife : ComplexType<DataTypeService.Complex.ProductShelfLife> 
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
        public CodeableConcept? Type { get; init; }
        [Element("period", typeof(ChoiceBased), false, false, true, false)]
        public ChoiceBased? Period { get; init; }
        [Element("specialPrecautionsForStorage", typeof(CodeableConcept), false, true, false, false)]
        public IEnumerable<CodeableConcept>? SpecialPrecautionsForStorage { get; init; }
        #endregion
        #region Constructor
        public ProductShelfLife() { }
        public ProductShelfLife(string? value) : base(value) { }
        public ProductShelfLife(JsonNode? source):base(source)
        {
           

        }

        #endregion
        #region From Parent
        protected override string _TypeName => "ProductShelfLife";
        #endregion

        #region Public Method


        public override JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }
        #endregion
    }
}
