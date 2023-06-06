
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub
{
    public class CrossReference : BackboneElement<CrossReference>
    {

        #region Property
        [Element("product", typeof(CodeableReference), false, false, false, false)]
public CodeableReference Product {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}

        #endregion
        #region Constructor
        public  CrossReference() { }
        public  CrossReference(string value) : base(value) { }
        public  CrossReference(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "CrossReference";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
