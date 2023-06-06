
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class Cost : BackboneElement<Cost>
    {

        #region Property
        [Element("effectiveDate", typeof(Period), false, true, false, false)]
public IEnumerable<Period> EffectiveDate {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("source", typeof(FhirString), true, false, false, false)]
public FhirString Source {get; set;}
[Element("cost", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased CostProp {get; set;}

        #endregion
        #region Constructor
        public  Cost() { }
        public  Cost(string value) : base(value) { }
        public  Cost(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Cost";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
