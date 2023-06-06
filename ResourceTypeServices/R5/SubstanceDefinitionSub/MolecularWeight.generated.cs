
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub
{
    public class MolecularWeight : BackboneElement<MolecularWeight>
    {

        #region Property
        [Element("method", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Method {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("amount", typeof(Quantity), false, false, false, false)]
public Quantity Amount {get; set;}

        #endregion
        #region Constructor
        public  MolecularWeight() { }
        public  MolecularWeight(string value) : base(value) { }
        public  MolecularWeight(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "MolecularWeight";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
