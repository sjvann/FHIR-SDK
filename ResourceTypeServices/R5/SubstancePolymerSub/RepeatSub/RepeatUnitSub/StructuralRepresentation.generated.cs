
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SubstancePolymerSub.RepeatSub.RepeatUnitSub
{
    public class StructuralRepresentation : BackboneElement<StructuralRepresentation>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("representation", typeof(FhirString), true, false, false, false)]
public FhirString Representation {get; set;}
[Element("format", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Format {get; set;}
[Element("attachment", typeof(Attachment), false, false, false, false)]
public Attachment Attachment {get; set;}

        #endregion
        #region Constructor
        public  StructuralRepresentation() { }
        public  StructuralRepresentation(string value) : base(value) { }
        public  StructuralRepresentation(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "StructuralRepresentation";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
