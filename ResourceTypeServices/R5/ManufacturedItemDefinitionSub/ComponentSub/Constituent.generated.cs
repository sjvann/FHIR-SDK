
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.ManufacturedItemDefinitionSub.ComponentSub
{
    public class Constituent : BackboneElement<Constituent>
    {

        #region Property
        [Element("amount", typeof(Quantity), false, true, false, false)]
public IEnumerable<Quantity> Amount {get; set;}
[Element("location", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Location {get; set;}
[Element("function", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Function {get; set;}
[Element("hasIngredient", typeof(CodeableReference), false, true, false, false)]
public IEnumerable<CodeableReference> HasIngredient {get; set;}

        #endregion
        #region Constructor
        public  Constituent() { }
        public  Constituent(string value) : base(value) { }
        public  Constituent(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Constituent";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
