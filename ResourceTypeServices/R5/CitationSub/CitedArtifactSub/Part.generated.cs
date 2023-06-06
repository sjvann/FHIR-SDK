
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.CitationSub.CitedArtifactSub
{
    public class Part : BackboneElement<Part>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("value", typeof(FhirString), true, false, false, false)]
public FhirString Value {get; set;}
[Element("baseCitation", typeof(Reference), false, false, false, false)]
public Reference BaseCitation {get; set;}

        #endregion
        #region Constructor
        public  Part() { }
        public  Part(string value) : base(value) { }
        public  Part(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Part";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
