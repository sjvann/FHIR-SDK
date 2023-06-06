
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class RelatedMedicationKnowledge : BackboneElement<RelatedMedicationKnowledge>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("reference", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Reference {get; set;}

        #endregion
        #region Constructor
        public  RelatedMedicationKnowledge() { }
        public  RelatedMedicationKnowledge(string value) : base(value) { }
        public  RelatedMedicationKnowledge(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "RelatedMedicationKnowledge";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
