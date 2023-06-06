
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;
using ResourceTypeServices.R5.ExplanationOfBenefitSub.BenefitBalanceSub;

namespace ResourceTypeServices.R5.ExplanationOfBenefitSub
{
    public class BenefitBalance : BackboneElement<BenefitBalance>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("excluded", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Excluded {get; set;}
[Element("name", typeof(FhirString), true, false, false, false)]
public FhirString Name {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}
[Element("network", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Network {get; set;}
[Element("unit", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Unit {get; set;}
[Element("term", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Term {get; set;}
[Element("financial", typeof(Financial), false, true, false, true)]
public IEnumerable<Financial> Financial {get; set;}

        #endregion
        #region Constructor
        public  BenefitBalance() { }
        public  BenefitBalance(string value) : base(value) { }
        public  BenefitBalance(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "BenefitBalance";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
