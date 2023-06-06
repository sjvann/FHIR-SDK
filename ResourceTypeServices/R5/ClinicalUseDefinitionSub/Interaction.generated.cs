
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.ClinicalUseDefinitionSub.InteractionSub;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub
{
    public class Interaction : BackboneElement<Interaction>
    {

        #region Property
        [Element("interactant", typeof(Interactant), false, true, false, true)]
public IEnumerable<Interactant> Interactant {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("effect", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Effect {get; set;}
[Element("incidence", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Incidence {get; set;}
[Element("management", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Management {get; set;}

        #endregion
        #region Constructor
        public  Interaction() { }
        public  Interaction(string value) : base(value) { }
        public  Interaction(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Interaction";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
