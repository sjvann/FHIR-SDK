
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using ResourceTypeServices.R5.ManufacturedItemDefinitionSub.ComponentSub;

namespace ResourceTypeServices.R5.ManufacturedItemDefinitionSub
{
    public class Component : BackboneElement<Component>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("function", typeof(CodeableConcept), false, true, false, false)]
public IEnumerable<CodeableConcept> Function {get; set;}
[Element("amount", typeof(Quantity), false, true, false, false)]
public IEnumerable<Quantity> Amount {get; set;}
[Element("constituent", typeof(Constituent), false, true, false, true)]
public IEnumerable<Constituent> Constituent {get; set;}

        #endregion
        #region Constructor
        public  Component() { }
        public  Component(string value) : base(value) { }
        public  Component(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Component";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
