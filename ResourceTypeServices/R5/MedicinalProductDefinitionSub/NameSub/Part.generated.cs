
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.MedicinalProductDefinitionSub.NameSub
{
    public class Part : BackboneElement<Part>
    {

        #region Property
        [Element("part", typeof(FhirString), true, false, false, false)]
public FhirString PartProp {get; set;}
[Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}

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
