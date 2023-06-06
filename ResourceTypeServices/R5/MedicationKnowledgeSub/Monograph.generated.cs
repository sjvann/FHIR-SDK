
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class Monograph : BackboneElement<Monograph>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("source", typeof(Reference), false, false, false, false)]
public Reference Source {get; set;}

        #endregion
        #region Constructor
        public  Monograph() { }
        public  Monograph(string value) : base(value) { }
        public  Monograph(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Monograph";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
