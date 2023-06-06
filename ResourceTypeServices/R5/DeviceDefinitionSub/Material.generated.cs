
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceDefinitionSub
{
    public class Material : BackboneElement<Material>
    {

        #region Property
        [Element("substance", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Substance {get; set;}
[Element("alternate", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean Alternate {get; set;}
[Element("allergenicIndicator", typeof(FhirBoolean), true, false, false, false)]
public FhirBoolean AllergenicIndicator {get; set;}

        #endregion
        #region Constructor
        public  Material() { }
        public  Material(string value) : base(value) { }
        public  Material(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Material";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
