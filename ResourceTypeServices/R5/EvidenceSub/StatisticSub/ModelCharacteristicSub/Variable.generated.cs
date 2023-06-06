
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.EvidenceSub.StatisticSub.ModelCharacteristicSub
{
    public class Variable : BackboneElement<Variable>
    {

        #region Property
        [Element("variableDefinition", typeof(Reference), false, false, false, false)]
public Reference VariableDefinition {get; set;}
[Element("handling", typeof(FhirCode), true, false, false, false)]
public FhirCode Handling {get; set;}
[Element("valueCategory", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> ValueCategory {get; set;}
[Element("valueQuantity", typeof(Quantity), false, true, false, false)]
public IEnumerable<Quantity> ValueQuantity {get; set;}
[Element("valueRange", typeof(DataTypeService.Complex.Range), false, true, false, false)]
public IEnumerable<DataTypeService.Complex.Range> ValueRange {get; set;}

        #endregion
        #region Constructor
        public  Variable() { }
        public  Variable(string value) : base(value) { }
        public  Variable(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Variable";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
