
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub.DefinitionalSub
{
    public class Ingredient : BackboneElement<Ingredient>
    {

        #region Property
        [Element("item", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Item {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("strength", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Strength {get; set;}

        #endregion
        #region Constructor
        public  Ingredient() { }
        public  Ingredient(string value) : base(value) { }
        public  Ingredient(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Ingredient";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
