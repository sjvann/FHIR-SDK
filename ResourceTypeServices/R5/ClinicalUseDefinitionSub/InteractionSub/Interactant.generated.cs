
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;

namespace ResourceTypeServices.R5.ClinicalUseDefinitionSub.InteractionSub
{
    public class Interactant : BackboneElement<Interactant>
    {

        #region Property
        [Element("item", typeof(ChoiceBased), false, false, true, false)]
public ChoiceBased Item {get; set;}

        #endregion
        #region Constructor
        public  Interactant() { }
        public  Interactant(string value) : base(value) { }
        public  Interactant(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Interactant";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
