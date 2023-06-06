
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.MedicationKnowledgeSub.DefinitionalSub;

namespace ResourceTypeServices.R5.MedicationKnowledgeSub
{
    public class Definitional : BackboneElement<Definitional>
    {

        #region Property
        [Element("definition", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Definition {get; set;}
[Element("doseForm", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept DoseForm {get; set;}
[Element("intendedRoute", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> IntendedRoute {get; set;}
[Element("ingredient", typeof(Ingredient), false, true, false, true)]
public IEnumerable<Ingredient> Ingredient {get; set;}
[Element("drugCharacteristic", typeof(DrugCharacteristic), false, true, false, true)]
public IEnumerable<DrugCharacteristic> DrugCharacteristic {get; set;}

        #endregion
        #region Constructor
        public  Definitional() { }
        public  Definitional(string value) : base(value) { }
        public  Definitional(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Definitional";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
