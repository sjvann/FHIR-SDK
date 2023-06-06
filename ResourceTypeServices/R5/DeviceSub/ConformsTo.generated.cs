
using Core.Attribute;
using DataTypeService.BaseTypes;
using System.Text.Json.Nodes;
using DataTypeService.Complex;
using DataTypeService.Primitive;

namespace ResourceTypeServices.R5.DeviceSub
{
    public class ConformsTo : BackboneElement<ConformsTo>
    {

        #region Property
        [Element("category", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Category {get; set;}
[Element("specification", typeof(CodeableConcept), false, false, false, false)]
public CodeableConcept Specification {get; set;}
[Element("version", typeof(FhirString), true, false, false, false)]
public FhirString Version {get; set;}

        #endregion
        #region Constructor
        public  ConformsTo() { }
        public  ConformsTo(string value) : base(value) { }
        public  ConformsTo(JsonNode source) : base(source) {}
        #endregion
        #region From Parent
        protected override string _TypeName => "ConformsTo";

        #endregion

        #region public Method
        public JsonNode GetJsonNode()
        {
            return SetupJsonNode(this);
        }

        #endregion
    }
}
