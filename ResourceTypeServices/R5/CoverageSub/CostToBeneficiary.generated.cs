
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.CoverageSub.CostToBeneficiarySub;

namespace ResourceTypeServices.R5.CoverageSub
{
    public class CostToBeneficiary : BackboneElement<CostToBeneficiary>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("network", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Network {get; set;}
[Element("unit", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Unit {get; set;}
[Element("term", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Term {get; set;}
[Element("value", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Value {get; set;}
[Element("exception", typeof(ResourceTypeServices.R5.CoverageSub.CostToBeneficiarySub.Exception), false, true, false, true)]
public IEnumerable<ResourceTypeServices.R5.CoverageSub.CostToBeneficiarySub.Exception> Exception {get; set;}

        #endregion
        #region Constructor
        public  CostToBeneficiary() { }
        public  CostToBeneficiary(string value) : base(value) { }
        public  CostToBeneficiary(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CostToBeneficiary";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
