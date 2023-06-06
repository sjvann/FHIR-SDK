
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ObservationSub
{
    public class ReferenceRange : BackboneElement<ReferenceRange>
    {

        #region Property
        [Element("low", typeof(Quantity), false, false, false, false)]
public Quantity Low {get; set;}
[Element("high", typeof(Quantity), false, false, false, false)]
public Quantity High {get; set;}
[Element("normalValue", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept NormalValue {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("appliesTo", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> AppliesTo {get; set;}
[Element("age", typeof(DataTypeService.Complex.Range), false, false, false, false)]
public DataTypeService.Complex.Range Age {get; set;}

        #endregion
        #region Constructor
        public  ReferenceRange() { }
        public  ReferenceRange(string value) : base(value) { }
        public  ReferenceRange(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ReferenceRange";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
