
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.IndicationGuidelineSub.DosingGuidelineSub
{
    public class Dosage : BackboneElement<Dosage>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("dosage", typeof(Dosage), false, true, false, false)]
public IEnumerable<Dosage> DosageProp {get; set;}

        #endregion
        #region Constructor
        public  Dosage() { }
        public  Dosage(string value) : base(value) { }
        public  Dosage(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Dosage";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
