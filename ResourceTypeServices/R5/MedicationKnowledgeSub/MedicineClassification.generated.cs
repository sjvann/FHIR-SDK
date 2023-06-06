
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class MedicineClassification : BackboneElement<MedicineClassification>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("source", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Source {get; set;}
[Element("classification", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Classification {get; set;}

        #endregion
        #region Constructor
        public  MedicineClassification() { }
        public  MedicineClassification(string value) : base(value) { }
        public  MedicineClassification(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MedicineClassification";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
