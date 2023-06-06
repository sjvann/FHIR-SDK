
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.SpecimenSub
{
    public class Feature : BackboneElement<Feature>
    {

        #region Property
        [Element("type", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Type {get; set;}
[Element("description", typeof(FhirString), true, false, false, false)]
public FhirString Description {get; set;}

        #endregion
        #region Constructor
        public  Feature() { }
        public  Feature(string value) : base(value) { }
        public  Feature(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "Feature";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
