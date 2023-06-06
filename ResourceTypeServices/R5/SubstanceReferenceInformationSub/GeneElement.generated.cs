
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;

namespace ResourceTypeServices.R5.SubstanceReferenceInformationSub
{
    public class GeneElement : BackboneElement<GeneElement>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("element", typeof(Identifier), false, false, false, false)]
public Identifier Element {get; set;}
[Element("source", typeof(Reference), false, true, false, false)]
public IEnumerable<Reference> Source {get; set;}

        #endregion
        #region Constructor
        public  GeneElement() { }
        public  GeneElement(string value) : base(value) { }
        public  GeneElement(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "GeneElement";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
