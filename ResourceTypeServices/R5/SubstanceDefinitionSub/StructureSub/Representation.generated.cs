
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstanceDefinitionSub.StructureSub
{
    public class Representation : BackboneElement<Representation>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("representation", typeof(FhirString), true, false, false, false)]
public FhirString RepresentationProp {get; set;}
[Element("format", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Format {get; set;}
[Element("document", typeof(Reference), false, false, false, false)]
public Reference Document {get; set;}

        #endregion
        #region Constructor
        public  Representation() { }
        public  Representation(string value) : base(value) { }
        public  Representation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Representation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
